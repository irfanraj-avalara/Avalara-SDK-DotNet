# Avalara.SDK.Model.EInvoicing.V1.DocumentSummary
Displays a summary of information about the document

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique ID for this document | [optional] 
**ProcessDateTime** | **string** | The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss | [optional] 
**Status** | **string** | The transaction status: &lt;br&gt; &#39;Pending&#39; &lt;br&gt; &#39;Failed&#39; &lt;br&gt; &#39;Complete&#39; | [optional] 
**SupplierName** | **string** | The name of the supplier in the transaction | [optional] 
**CustomerName** | **string** | The name of the customer in the transaction | [optional] 
**DocumentNumber** | **string** | The invoice document number | [optional] 
**DocumentDate** | **string** | The invoice issue date | [optional] 
**Flow** | **string** | The invoice direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60; | [optional] 
**CountryCode** | **string** | The two-letter ISO-3166 country code for the country where the e-invoice is being submitted | [optional] 
**CountryMandate** | **string** | The e-invoicing mandate for the specified country | [optional] 
**VarInterface** | **string** | The interface where the invoice data is sent | [optional] 
**Receiver** | **string** | The invoice recipient based on the interface | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

