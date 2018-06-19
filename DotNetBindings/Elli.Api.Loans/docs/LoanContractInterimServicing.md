# Elli.Api.Loans.Model.LoanContractInterimServicing
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BorrowerFirstName** | **string** |  | [optional] 
**BorrowerLastName** | **string** |  | [optional] 
**CalcTriggered** | **string** |  | [optional] 
**CityInsurance** | **double?** |  | [optional] 
**CurrentPrincipalBalance** | **double?** |  | [optional] 
**EscrowBalance** | **double?** |  | [optional] 
**EscrowDisbursementTransactions** | [**List&lt;LoanContractInterimServicingEscrowDisbursementTransactions&gt;**](LoanContractInterimServicingEscrowDisbursementTransactions.md) |  | [optional] 
**EscrowInterestTransactions** | [**List&lt;LoanContractInterimServicingEscrowInterestTransactions&gt;**](LoanContractInterimServicingEscrowInterestTransactions.md) |  | [optional] 
**FloodInsurance** | **double?** |  | [optional] 
**InterimServicingTransactions** | [**List&lt;LoanContractInterimServicingEscrowInterestTransactions&gt;**](LoanContractInterimServicingEscrowInterestTransactions.md) |  | [optional] 
**LastPaymentAdditionalEscrow** | **double?** |  | [optional] 
**LastPaymentAdditionalPrincipal** | **double?** |  | [optional] 
**LastPaymentBuydownSubsidyAmount** | **double?** |  | [optional] 
**LastPaymentEscrowAmount** | **double?** |  | [optional] 
**LastPaymentGuid** | **string** |  | [optional] 
**LastPaymentInterest** | **double?** |  | [optional] 
**LastPaymentLateFee** | **double?** |  | [optional] 
**LastPaymentMiscFee** | **double?** |  | [optional] 
**LastPaymentNumber** | **int?** |  | [optional] 
**LastPaymentPrincipal** | **double?** |  | [optional] 
**LastPaymentPrincipalAndInterest** | **double?** |  | [optional] 
**LastPaymentReceivedDate** | **DateTime?** |  | [optional] 
**LastPaymentStatementDate** | **DateTime?** |  | [optional] 
**LastPaymentTotalAmountReceived** | **double?** |  | [optional] 
**LastStatementPrintedDate** | **DateTime?** |  | [optional] 
**LoanSnapshotXml** | **string** |  | [optional] 
**MailingCity** | **string** |  | [optional] 
**MailingPostalCode** | **string** |  | [optional] 
**MailingState** | **string** |  | [optional] 
**MailingStreetAddress** | **string** |  | [optional] 
**MortgageAccount** | **string** |  | [optional] 
**NextEscrowTotalFloodInsurance** | **double?** |  | [optional] 
**NextEscrowTotalFloodInsuranceDueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalHazardInsurance** | **double?** |  | [optional] 
**NextEscrowTotalHazardInsuranceDueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalMortgageInsurance** | **double?** |  | [optional] 
**NextEscrowTotalMortgageInsuranceDueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalOtherTax1** | **double?** |  | [optional] 
**NextEscrowTotalOtherTax1DueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalOtherTax2** | **double?** |  | [optional] 
**NextEscrowTotalOtherTax2DueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalOtherTax3** | **double?** |  | [optional] 
**NextEscrowTotalOtherTax3DueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalPropertyTax** | **double?** |  | [optional] 
**NextEscrowTotalPropertyTaxDueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalTax** | **double?** |  | [optional] 
**NextEscrowTotalTaxDueDate** | **DateTime?** |  | [optional] 
**NextEscrowTotalUsdaMonthlyPremium** | **double?** |  | [optional] 
**NextEscrowTotalUsdaMonthlyPremiumDueDate** | **DateTime?** |  | [optional] 
**NextPaymentBuydownSubsidyAmount** | **double?** |  | [optional] 
**NextPaymentEscrowAmount** | **double?** |  | [optional] 
**NextPaymentIndexCurrentValuePercent** | **double?** |  | [optional] 
**NextPaymentInterest** | **double?** |  | [optional] 
**NextPaymentLateFee** | **double?** |  | [optional] 
**NextPaymentLatePaymentDate** | **DateTime?** |  | [optional] 
**NextPaymentMiscFee** | **double?** |  | [optional] 
**NextPaymentPastDueAmount** | **double?** |  | [optional] 
**NextPaymentPaymentDueDate** | **DateTime?** |  | [optional] 
**NextPaymentPaymentIndexDate** | **DateTime?** |  | [optional] 
**NextPaymentPrincipal** | **double?** |  | [optional] 
**NextPaymentPrincipalAndInterest** | **double?** |  | [optional] 
**NextPaymentRequestedInterestRatePercent** | **double?** |  | [optional] 
**NextPaymentStatementDueDate** | **DateTime?** |  | [optional] 
**NextPaymentTotalAmountDue** | **double?** |  | [optional] 
**NextPaymentTotalAmountWithLateFee** | **double?** |  | [optional] 
**NextPaymentUnpaidLateFee** | **double?** |  | [optional] 
**NumberOfDisbursement** | **int?** |  | [optional] 
**OtherTransactions** | [**List&lt;LoanContractInterimServicingOtherTransactions&gt;**](LoanContractInterimServicingOtherTransactions.md) |  | [optional] 
**PaymentDueDatePrinted** | **DateTime?** |  | [optional] 
**PaymentReversalTransactions** | [**List&lt;LoanContractInterimServicingPaymentReversalTransactions&gt;**](LoanContractInterimServicingPaymentReversalTransactions.md) |  | [optional] 
**PaymentTransactions** | [**List&lt;LoanContractInterimServicingPaymentTransactions&gt;**](LoanContractInterimServicingPaymentTransactions.md) |  | [optional] 
**PrintedByUserId** | **string** |  | [optional] 
**PrintedByUserName** | **string** |  | [optional] 
**SchedulePaymentTransactions** | [**List&lt;LoanContractInterimServicingSchedulePaymentTransactions&gt;**](LoanContractInterimServicingSchedulePaymentTransactions.md) |  | [optional] 
**ServicingStatus** | **string** |  | [optional] 
**TotalAdditionalEscrow** | **double?** |  | [optional] 
**TotalAdditionalEscrowYearToDate** | **double?** |  | [optional] 
**TotalAdditionalPrincipal** | **double?** |  | [optional] 
**TotalAdditionalPrincipalYearToDate** | **double?** |  | [optional] 
**TotalAmountDisbursed** | **double?** |  | [optional] 
**TotalBuydownSubsidyAmount** | **double?** |  | [optional] 
**TotalBuydownSubsidyAmountYearToDate** | **double?** |  | [optional] 
**TotalEscrow** | **double?** |  | [optional] 
**TotalEscrowYearToDate** | **double?** |  | [optional] 
**TotalHazardInsurance** | **double?** |  | [optional] 
**TotalInterest** | **double?** |  | [optional] 
**TotalInterestYearToDate** | **double?** |  | [optional] 
**TotalLateFee** | **double?** |  | [optional] 
**TotalLateFeeYearToDate** | **double?** |  | [optional] 
**TotalMiscFee** | **double?** |  | [optional] 
**TotalMiscFeeYearToDate** | **double?** |  | [optional] 
**TotalMortgageInsurance** | **double?** |  | [optional] 
**TotalNumberOfLatePayment** | **int?** |  | [optional] 
**TotalNumberOfPayment** | **int?** |  | [optional] 
**TotalOtherTaxes** | **double?** |  | [optional] 
**TotalPAndI** | **double?** |  | [optional] 
**TotalPAndIYearToDate** | **double?** |  | [optional] 
**TotalPaymentCollected** | **double?** |  | [optional] 
**TotalPaymentCollectedYearToDate** | **double?** |  | [optional] 
**TotalPrincipal** | **double?** |  | [optional] 
**TotalPrincipalYearToDate** | **double?** |  | [optional] 
**TotalTaxes** | **double?** |  | [optional] 
**TotalUsdaMonthlyPremium** | **double?** |  | [optional] 
**UnpaidBuydownSubsidyAmount** | **double?** |  | [optional] 
**UnpaidEscrow** | **double?** |  | [optional] 
**UnpaidInterest** | **double?** |  | [optional] 
**UnpaidLateFee** | **double?** |  | [optional] 
**UnpaidMiscrFee** | **double?** |  | [optional] 
**UnpaidPrincipal** | **double?** |  | [optional] 
**Comments** | **string** |  | [optional] 
**BeginningBalance** | **double?** |  | [optional] 
**LastPaymentEscrowTax** | **double?** |  | [optional] 
**LastPaymentEscrowHazardInsurance** | **double?** |  | [optional] 
**LastPaymentEscrowMortgageInsurance** | **double?** |  | [optional] 
**LastPaymentEscrowFloodInsurance** | **double?** |  | [optional] 
**LastPaymentEscrowCityPropertyTax** | **double?** |  | [optional] 
**LastPaymentEscrowOther1** | **double?** |  | [optional] 
**LastPaymentEscrowOther2** | **double?** |  | [optional] 
**LastPaymentEscrowOther3** | **double?** |  | [optional] 
**LastPaymentEscrowUSDAMonthlyPremium** | **double?** |  | [optional] 
**NextPaymentEscrowTax** | **double?** |  | [optional] 
**NextPaymentEscrowHazardInsurance** | **double?** |  | [optional] 
**NextPaymentEscrowMortgageInsurance** | **double?** |  | [optional] 
**NextPaymentEscrowFloodInsurance** | **double?** |  | [optional] 
**NextPaymentEscrowCityPropertyTax** | **double?** |  | [optional] 
**NextPaymentEscrowOther1** | **double?** |  | [optional] 
**NextPaymentEscrowOther2** | **double?** |  | [optional] 
**NextPaymentEscrowOther3** | **double?** |  | [optional] 
**NextPaymentEscrowUSDAMonthlyPremium** | **double?** |  | [optional] 
**ServicerLoanNumber** | **string** |  | [optional] 
**ServicingTransferDate** | **DateTime?** |  | [optional] 
**SubServicer** | **string** |  | [optional] 
**SubServicerLoanNumber** | **string** |  | [optional] 
**UnpaidEscrowTax** | **double?** |  | [optional] 
**UnpaidEscrowMortgageInsurance** | **double?** |  | [optional] 
**UnpaidEscrowHazardInsurance** | **double?** |  | [optional] 
**UnpaidEscrowFloodInsurance** | **double?** |  | [optional] 
**UnpaidEscrowCityPropertyTax** | **double?** |  | [optional] 
**UnpaidEscrowOther1** | **double?** |  | [optional] 
**UnpaidEscrowOther2** | **double?** |  | [optional] 
**UnpaidEscrowOther3** | **double?** |  | [optional] 
**UnpaidEscrowUSDAMonthlyPremium** | **double?** |  | [optional] 
**PurchasedPrincipal** | **double?** |  | [optional] 
**BorrHomePhoneNumber** | **string** |  | [optional] 
**BorrCellPhoneNumber** | **string** |  | [optional] 
**BorrWorkPhoneNumber** | **string** |  | [optional] 
**BorrHomeEmail** | **string** |  | [optional] 
**ScheduledPayments** | [**List&lt;LoanContractInterimServicingSchedulePaymentTransactions&gt;**](LoanContractInterimServicingSchedulePaymentTransactions.md) |  | [optional] 
**NextScheduledPayment** | [**LoanContractInterimServicingSchedulePaymentTransactions**](LoanContractInterimServicingSchedulePaymentTransactions.md) |  | [optional] 
**LastScheduledPayment** | [**LoanContractInterimServicingSchedulePaymentTransactions**](LoanContractInterimServicingSchedulePaymentTransactions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
