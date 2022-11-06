using LoanContract = Elli.Api.Loans.Model.LoanContract;
using Elli.Api.Schema.Api;
using Elli.Api.Schema.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Elli.Api.Base;

namespace Elli.Api.Extensions
{
    public static class LoanContractExtension
    {
        private static Dictionary<string, string> _missingJsonPathsDict;
        private static JObject _loanContractJson;

        /// <summary>
        /// Initialize field mapping json paths.
        /// </summary>
        /// <param name="accessToken">Access token.</param>
        public static void InitializeFieldMapping(AccessToken accessToken, ApiConfiguration config)
        {
            if (_missingJsonPathsDict == null || _missingJsonPathsDict.Count == 0)
            {
                _missingJsonPathsDict = new Dictionary<string, string>();
                var clientProvider = ApiClientProvider.GetApiClient<PathGeneratorApi>(accessToken, config);
                var contract = new PathGeneratorContract();
                _missingJsonPathsDict = clientProvider.GetWebhookNotificationPath(contract);
            }
        }

        /// <summary>
        /// Get value for the field from loan contract.
        /// </summary>
        /// <param name="loanContract">Loan contract where value for the field needs to be fetched.</param>
        /// <param name="fieldId">Field Id</param>
        /// <param name="customId">Id of the field in Loan contract if fieldId doesn't give value.</param>
        /// <returns>Value for the field.</returns>
        public static object GetValueForField(this LoanContract loanContract, string fieldId, string customId = "")
        {
            if (string.IsNullOrWhiteSpace(fieldId))
            {
                return null;
            }
            var originalFieldId = fieldId;
            var index = ModifyFieldIdForRepeatableCollection(ref fieldId);
            var jsonPath = GetJsonPath(fieldId);
            if (string.IsNullOrEmpty(jsonPath))
            {
                return null;
            }
            if (_loanContractJson == null || _loanContractJson["encompassId"] == null || _loanContractJson["encompassId"].ToString() != loanContract.EncompassId)
            {
                _loanContractJson = JObject.Parse(JsonConvert.SerializeObject(loanContract));
            }
            var modifiedJsonPath = GetModifiedPath(jsonPath, originalFieldId, index, customId);
            var jsonValues = _loanContractJson.SelectTokens(modifiedJsonPath);
            //If json path yields more than one result return null as user needs to pass customId to get to exact field.
            if (jsonValues.Count() > 1)
            {
                return null;
            }
            return jsonValues.FirstOrDefault();
        }

        /// <summary>
        /// To get modified fieldId for Repeatable collection.Other type of fields will remain unchanged.
        /// To get json path for repeatable collection we need to replace index with "00" in field Id for repeatable collection.
        /// </summary>
        /// <param name="fieldId">Field Id.</param>
        /// <returns>Index for collection. For repeatable it is non zero, for others it will be 0.</returns>
        private static int ModifyFieldIdForRepeatableCollection(ref string fieldId)
        {
            var index = 0;
            int num;
            var prefix = string.Empty;
            //All repeatable collection fields except "TQL4506T", "HUD" and "FM" doesn't has integer in its prefix. Hence, this needs special handling.
            if (fieldId.StartsWith("TQL4506T", StringComparison.OrdinalIgnoreCase) || fieldId.StartsWith("HUD", StringComparison.OrdinalIgnoreCase)
                || fieldId.StartsWith("FM", StringComparison.OrdinalIgnoreCase))
            {
                //Reverse the field and get integers from end.
                var tempfielId = fieldId.Reverse();
                var indexPropertyIntegral = string.Concat(tempfielId.TakeWhile(c => int.TryParse(c.ToString(), out num)));
                //If integral part in less than 4 then it is not repeatable collection.
                // Repetable collection are in format "TQL4506T0101", "HUD0205", "FM0304".
                if (indexPropertyIntegral.Count() < 4)
                {
                    return index;
                }
                //Handle TQL4506T separately as the field prefix contains integers and hence logic outside the if block won't work.
                if (fieldId.StartsWith("TQL4506T", StringComparison.OrdinalIgnoreCase))
                {
                    var intPart = fieldId.Replace("TQL4506T", "");
                    if (!string.IsNullOrEmpty(intPart) && intPart.Length >= 4 && int.TryParse(intPart.Substring(0, intPart.Length - 2), out index))
                    {
                        fieldId = "TQL4506T" + "00" + intPart.Substring(intPart.Length - 2);
                    }
                    return index;
                }
            }
            RepeatableCollectionPrefix repeatableCollectionEnum;
            //Get the prefix before index by taking the string till we hit a number. Rest is index followed by property Id.
            prefix = string.Concat(fieldId.ToCharArray().TakeWhile(c => !int.TryParse(c.ToString(), out num)));
                
            if (Enum.TryParse(prefix, out repeatableCollectionEnum))
            {
                //This contains index followed by property id.
                var intPart = fieldId.Replace(prefix, "");
                //Last 2 digits is the Id of property and hence left over is index.
                //Index is not necessarily of 2 digits unlike as shown in Encompassfields.xml. It can exceed 99 thus forming 3 digits(has seen couple of cases).
                //Hence to get index we strip out last 2 digits which is id for the specific property.
                if (!string.IsNullOrEmpty(intPart) && intPart.Length >= 4 && int.TryParse(intPart.Substring(0, intPart.Length - 2), out index))
                {
                    fieldId = prefix + "00" + intPart.Substring(intPart.Length - 2);
                }
                else
                {
                    return index;
                }
            }
            return index;
        }

        /// <summary>
        /// Get json path for fieldId.
        /// </summary>
        /// <param name="fieldId">Field for which json path needs to be fetched.</param>
        /// <returns>Json path for the field.</returns>
        private static string GetJsonPath(string fieldId)
        {
            if (_missingJsonPathsDict == null || _missingJsonPathsDict.Count == 0)
            {
                throw new Exception("Please initialize the field mapping first.");
            }
            if (_missingJsonPathsDict.ContainsKey(fieldId))
            {
                return _missingJsonPathsDict[fieldId];
            }
            return null;
        }

        /// <summary>
        /// The json path return by the API has forward slahes and is not valid json. This method converts those paths to valid json.
        /// This  modified path can be used to fetch token from json object.
        /// </summary>
        /// <param name="input">json path with forward slash.</param>
        /// <param name="originalFieldId">Original fieldId passed by user.</param>
        /// <param name="repeatableIndex">Index of the repeaatable collection field for which json path is passed.</param>
        /// <param name="customId">Id of the collection field in format entity/index.</param>
        /// <returns>Valid json path tha can be used to fetch token from json object.</returns>
        private static string GetModifiedPath(string input, string originalFieldId, int repeatableIndex = 0 , string customId = "")
        {
            //For repeatable collection replace index of application with 0 as we are dealing with only current application.
            input = input.Replace("applications/*", "applications/0");
            //For custom fields use fieldName as identifier.
            if (input.IndexOf("/customfields/", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                customId = "fieldName == \"" + originalFieldId + "\"";
            }
            else if (!string.IsNullOrWhiteSpace(customId))
            {
                customId = "id == \"" + customId + "\"";
            }
            //If Id property of the field is passed use it.
            if (!string.IsNullOrWhiteSpace(customId))
            {
                //Replace "/" with "|" as down the line we need to replace "/" with "." to get valid json path but not the "/" in id property.
                customId = customId.Replace("/", "|");

                //Check if json path already contains condition i.e. if it contains "[?(@" and ")]".
                //E.g.: "/gfeFees[?(@/gfeFeeType == \"OtherCost\" && @/gfeFeeIndex == \"1\")]/description" 
                if (input.Contains("[?(@") && input.Contains(")]"))
                {
                    var inputSplit = input.Split(new string[] { "[?(@" }, StringSplitOptions.None);
                    var entity = inputSplit[0];
                    var identifiers = inputSplit[1].Split(new string[] { ")]" }, StringSplitOptions.None);
                    var condition = identifiers[0];
                    var property = identifiers[1];
                    //Overwrite exiting condition with customId if passed by user. This is because Id property can uniquely identify the property in entity.
                    input = entity + "[?(@/" + customId + ")]" + property;
                }
                else
                {
                    //If repeatable collection replace "/*" i.e. index with custom Id. Didn't find any json path for repeatable collection that already has condition.
                    //Hence, json path "/applications/*/residences/*/title" will be "/applications/*/residences[?(@/id == "entity/index")]/title"
                    if (repeatableIndex > 0)
                    {
                        input = input.Replace("/*", "[?(@/" + customId + ")]");
                    }
                    //Add conditon for custom ID if there is no condition.
                    else
                    {
                        var slashIndex = input.LastIndexOf("/");
                        input = input.Substring(0, slashIndex) + "[?(@/" + customId + ")]" + input.Substring(slashIndex, input.Length - slashIndex);
                    }
                }
            }
            //If no custom id is passed replace "/*" with index computed via fieldId of repeatable collection.
            else if (repeatableIndex > 0)
            {
                input = input.Replace("*", (repeatableIndex - 1).ToString());
            }

            var newPath = string.Empty;
            //Check if json path contains numbers as index(non repeatable collection) E.g. /purchaseCredits/1/amount
            var regex = new Regex("(\\/[0-9]{1,3}\\/)");
            var splitData = regex.Split(input);
            foreach (var item in splitData)
            {
                int index;
                //If json path contains numbers as index(non repeatable collection) enclose it in square brackets. E.g. /purchaseCredits/[1]/amount
                if (int.TryParse(item.Replace("/", ""), out index))
                {
                    newPath += "[" + index.ToString() + "].";
                }
                //Below is the reason of replacing "/" with "|" in custom Id as we don't want to get it replaced.
                else
                {
                    newPath += item.Replace("/", ".");
                }
            }
            //Replace """ with "'" to make valid json.
            //Restore "/" back from "|".
            newPath = "$" + newPath.Replace("\"", "'").Replace("|", "/");

            return newPath;
        }

        /// <summary>
        /// All possible prefixes for Repeatable collection.
        /// </summary>
        internal enum RepeatableCollectionPrefix
        {
            BE,
            BR,
            CE,
            CR,
            CUST,
            DD,
            FBE,
            FCE,
            FL,
            UNFL,
            NBOC,
            XCOC,
            FM,
            HTD,
            HTR,
            HUD,
            AEA,
            IR,
            AR,
            LP,
            NYFEES,
            TA,
            AB,
            HC,
            SP,
            TQLFRAUDALERT,
            TQLCOMPLIANCEALERT,
            TQL4506T,
            TQLDOCDATE,
            TR
        }
    }
}
