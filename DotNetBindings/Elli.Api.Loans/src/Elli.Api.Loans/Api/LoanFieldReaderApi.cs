using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elli.Api.Loans.Client;
using Elli.Api.Loans.Model;
using RestSharp;

namespace Elli.Api.Loans.Api
{
    public interface ILoanFieldReaderApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns list of field values.
        /// </summary>
        /// <remarks>
        /// Retrieve values for specific fields in a loan.
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="fieldIds">List of field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="includeMetadata">
        /// Possible values are true or false. If set to true, the response will include
        /// the metadata for the fields specified, and returns details such as format, description, type, options and
        /// readOnly indicator. Default behavior is false, in which case, only the fieldId and value are returned for
        /// the fields in the request body.
        /// </param>
        /// <returns>List&lt;LoanContractField&gt;</returns>
        List<LoanContractField> GetFieldValues(string loanId, List<string> fieldIds, bool? includeMetadata = null);

        /// <summary>
        /// Returns list of field values.
        /// </summary>
        /// <remarks>
        /// Retrieve values for specific fields in a loan.
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="fieldIds">List of field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="includeMetadata">
        /// Possible values are true or false. If set to true, the response will include
        /// the metadata for the fields specified, and returns details such as format, description, type, options and
        /// readOnly indicator. Default behavior is false, in which case, only the fieldId and value are returned for
        /// the fields in the request body.
        /// </param>
        /// <returns>ApiResponse of List&lt;LoanContractField&gt;</returns>
        ApiResponse<List<LoanContractField>> GetFieldValuesWithHttpInfo(string loanId, List<string> fieldIds, bool? includeMetadata = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns list of field values.
        /// </summary>
        /// <remarks>
        /// Retrieve values for specific fields in a loan.
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="fieldIds">List of field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="includeMetadata">
        /// Possible values are true or false. If set to true, the response will include
        /// the metadata for the fields specified, and returns details such as format, description, type, options and
        /// readOnly indicator. Default behavior is false, in which case, only the fieldId and value are returned for
        /// the fields in the request body.
        /// </param>
        /// <returns>Task of List&lt;LoanContractField&gt;</returns>
        System.Threading.Tasks.Task<List<LoanContractField>> GetFieldValuesAsync(string loanId, List<string> fieldIds, bool? includeMetadata = null);

        /// <summary>
        /// Returns list of field values.
        /// </summary>
        /// <remarks>
        /// Retrieve values for specific fields in a loan.
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="fieldIds">List of field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="includeMetadata">
        /// Possible values are true or false. If set to true, the response will include
        /// the metadata for the fields specified, and returns details such as format, description, type, options and
        /// readOnly indicator. Default behavior is false, in which case, only the fieldId and value are returned for
        /// the fields in the request body.
        /// </param>
        /// <returns>Task of ApiResponse (List&lt;LoanContractField&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LoanContractField>>> GetFieldValuesAsyncWithHttpInfo(string loanId, List<string> fieldIds, bool? includeMetadata = null);
        #endregion Asynchronous Operations
    }

    public partial class LoanFieldReaderApi : ILoanFieldReaderApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanFieldReaderApi"/> class.
        /// </summary>
        /// <param name="basePath"></param>
        public LoanFieldReaderApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // Ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanFieldReaderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        public LoanFieldReaderApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // Ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        public string GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Returns list of field values. Retrieve values for specific fields in a loan.
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="fieldIds">List of field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="includeMetadata">
        /// Possible values are true or false. If set to true, the response will include
        /// the metadata for the fields specified, and returns details such as format, description, type, options and
        /// readOnly indicator. Default behavior is false, in which case, only the fieldId and value are returned for
        /// the fields in the request body.
        /// </param>
        /// <returns>List&lt;LoanContractField&gt;</returns>
        public List<LoanContractField> GetFieldValues(string loanId, List<string> fieldIds, bool? includeMetadata = null)
        {
            ApiResponse<List<LoanContractField>> localVarResponse = GetFieldValuesWithHttpInfo(loanId, fieldIds, includeMetadata);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns list of field values. Retrieve values for specific fields in a loan.
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="fieldIds">List of field IDs of the values you want to retrieve from the loan.</param>
        /// <param name="includeMetadata">
        /// Possible values are true or false. If set to true, the response will include
        /// the metadata for the fields specified, and returns details such as format, description, type, options and
        /// readOnly indicator. Default behavior is false, in which case, only the fieldId and value are returned for
        /// the fields in the request body.
        /// </param>
        /// <returns>ApiResponse of List&lt;LoanContractField&gt;</returns>
        public ApiResponse<List<LoanContractField>> GetFieldValuesWithHttpInfo(string loanId, List<string> fieldIds, bool? includeMetadata = null)
        {
            // Verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new ApiException(400, "Missing required parameter 'loanId' when calling LoanFieldReaderApi->GetFieldValues");

            // Verify the required parameter 'fieldIds' is set
            if (fieldIds == null)
                throw new ApiException(400, "Missing required parameter 'fieldIds' when calling LoanFieldReaderApi->GetFieldValues");

            var localVarPath = $"/encompass/v1/loans/{loanId}/fieldReader";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loanId != null) localVarPathParams.Add("loanId", Configuration.ApiClient.ParameterToString(loanId));  // path parameter
            if (includeMetadata != null) localVarQueryParams.Add("includeMetadata", Configuration.ApiClient.ParameterToString(includeMetadata));  // query parameter
            if (fieldIds != null) localVarPostBody = Configuration.ApiClient.Serialize(fieldIds);

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFieldValues", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LoanContractField>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LoanContractField>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LoanContractField>)));
        }

        public async Task<List<LoanContractField>> GetFieldValuesAsync(string loanId, List<string> fieldIds, bool? includeMetadata = null)
        {
            ApiResponse<List<LoanContractField>> localVarResponse = await GetFieldValuesAsyncWithHttpInfo(loanId, fieldIds, includeMetadata);
            return localVarResponse.Data;
        }

        public async Task<ApiResponse<List<LoanContractField>>> GetFieldValuesAsyncWithHttpInfo(string loanId, List<string> fieldIds, bool? includeMetadata = null)
        {
            // Verify the required parameter 'loanId' is set
            if (loanId == null)
                throw new ApiException(400, "Missing required parameter 'loanId' when calling LoanFieldReaderApi->GetFieldValues");

            // Verify the required parameter 'fieldIds' is set
            if (fieldIds == null)
                throw new ApiException(400, "Missing required parameter 'fieldIds' when calling LoanFieldReaderApi->GetFieldValues");

            var localVarPath = $"/encompass/v1/loans/{loanId}/fieldReader";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loanId != null) localVarPathParams.Add("loanId", Configuration.ApiClient.ParameterToString(loanId));  // path parameter
            if (includeMetadata != null) localVarQueryParams.Add("includeMetadata", Configuration.ApiClient.ParameterToString(includeMetadata));  // query parameter
            if (fieldIds != null) localVarPostBody = Configuration.ApiClient.Serialize(fieldIds);

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFieldValues", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LoanContractField>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LoanContractField>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LoanContractField>)));
        }
    }
}
