# Avalara.SDK.Model.EInvoicing.V1.FetchDocumentsRequestMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkflowId** | **string** | Specifies a unique ID for this workflow. | 
**DataFormat** | **string** | Specifies the data format for this workflow | 
**DataFormatVersion** | **decimal** | Specifies the data format version number | 
**OutputDataFormat** | **string** | Specifies the format of the output document to be generated for the recipient. This format should be chosen based on the recipient&#39;s preferences or requirements as defined by applicable e-invoicing regulations. When not specified for mandates that don&#39;t require a specific output format, the system will use the default format defined for that mandate. | 
**OutputDataFormatVersion** | **decimal** | Specifies the version of the selected output document format | 
**CountryCode** | **string** | The two-letter ISO-3166 country code for the country for which document is being retrieved | 
**CountryMandate** | **string** | The e-invoicing mandate for the specified country | 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

