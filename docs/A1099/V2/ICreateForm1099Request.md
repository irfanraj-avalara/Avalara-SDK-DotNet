# Avalara.SDK.Model.A1099.V2.ICreateForm1099Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalOrdinaryDividends** | **string** | Total ordinary dividends | [optional] 
**QualifiedDividends** | **string** | Qualified dividends | [optional] 
**TotalCapitalGainDistr** | **string** | Total capital gain distributions | [optional] 
**UnrecapSec1250Gain** | **string** | Unrecaptured Section 1250 gain | [optional] 
**Section1202Gain** | **string** | Section 1202 gain | [optional] 
**CollectiblesGain** | **string** | Collectibles (28%) gain | [optional] 
**Section897OrdinaryDividends** | **string** | Section 897 ordinary dividends | [optional] 
**Section897CapitalGain** | **string** | Section 897 capital gain | [optional] 
**NondividendDistributions** | **string** | Nondividend distributions | [optional] 
**FederalIncomeTaxWithheld** | **double** | Federal income tax withheld | [optional] 
**Section199ADividends** | **string** | Section 199A dividends | [optional] 
**InvestmentExpenses** | **string** | Investment expenses | [optional] 
**ForeignTaxPaid** | **string** | Foreign tax paid | [optional] 
**ForeignCountryOrUSPossession** | **string** | Foreign country or U.S. possession | [optional] 
**CashLiquidationDistributions** | **string** | Cash liquidation distributions | [optional] 
**NoncashLiquidationDistributions** | **string** | Noncash liquidation distributions | [optional] 
**ExemptInterestDividends** | **string** | Exempt-interest dividends | [optional] 
**SpecifiedPrivateActivityBondInterestDividends** | **string** | Specified private activity bond interest dividends | [optional] 
**FatcaFilingRequirement** | **bool** | FATCA filing requirement | [optional] 
**Type** | **string** |  | [optional] 
**IssuerId** | **string** | Issuer ID | [optional] 
**ReferenceId** | **string** | Reference ID | [optional] 
**RecipientTin** | **string** | Recipient Tax ID Number | [optional] 
**RecipientName** | **string** | Recipient name | 
**TinType** | **string** | Type of TIN (Tax ID Number). Will be one of:  * SSN  * EIN  * ITIN  * ATIN | [optional] 
**RecipientSecondName** | **string** | Recipient second name | [optional] 
**Address** | **string** | Address | 
**Address2** | **string** | Address line 2 | [optional] 
**City** | **string** | City | 
**State** | **string** | US state. Required if CountryCode is \&quot;US\&quot;. | [optional] 
**Zip** | **string** | Zip/postal code | [optional] 
**RecipientEmail** | **string** | Recipient email address | [optional] 
**AccountNumber** | **string** | Account number | [optional] 
**OfficeCode** | **string** | Office code | [optional] 
**RecipientNonUsProvince** | **string** | Foreign province | [optional] 
**CountryCode** | **string** | Country code, as defined at https://www.irs.gov/e-file-providers/country-codes | 
**FederalEFile** | **bool** | Boolean indicating that federal e-filing should be scheduled for this form | [optional] 
**PostalMail** | **bool** | Boolean indicating that postal mailing to the recipient should be scheduled for this form | [optional] 
**StateEFile** | **bool** | Boolean indicating that state e-filing should be scheduled for this form | [optional] 
**TinMatch** | **bool** | Boolean indicating that TIN Matching should be scheduled for this form | [optional] 
**AddressVerification** | **bool** | Boolean indicating that address verification should be scheduled for this form | [optional] 
**StateAndLocalWithholding** | [**StateAndLocalWithholdingRequest**](StateAndLocalWithholdingRequest.md) | State and local withholding information | [optional] 
**SecondTinNotice** | **bool** | Second TIN notice | [optional] 
**Rents** | **double** | Rents | [optional] 
**Royalties** | **double** | Royalties | [optional] 
**OtherIncome** | **double** | Other income | [optional] 
**FedIncomeTaxWithheld** | **double** | Federal income tax withheld | [optional] 
**FishingBoatProceeds** | **double** | Fishing boat proceeds | [optional] 
**MedicalHealthCarePayments** | **double** | Medical and health care payments | [optional] 
**DirectSalesIndicator** | **bool** | Payer made direct sales totaling $5,000 or more of consumer products to recipient for resale | [optional] 
**SubstitutePayments** | **double** | Substitute payments in lieu of dividends or interest | [optional] 
**CropInsuranceProceeds** | **double** | Crop insurance proceeds | [optional] 
**GrossProceedsPaidToAttorney** | **double** | Gross proceeds paid to an attorney | [optional] 
**FishPurchasedForResale** | **double** | Fish purchased for resale | [optional] 
**Section409ADeferrals** | **double** | Section 409A deferrals | [optional] 
**ExcessGoldenParachutePayments** | **double** | (Legacy field) Excess golden parachute payments | [optional] 
**NonqualifiedDeferredCompensation** | **double** | Nonqualified deferred compensation | [optional] 
**NonemployeeCompensation** | **double** | Nonemployee compensation | 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

