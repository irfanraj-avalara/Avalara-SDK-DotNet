# Avalara.SDK.Api.EInvoicing.V1.TaxIdentifiersApi

All URIs are relative to *https://api.sbx.avalara.com/einvoicing*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaxIdentifierSchemaByCountry**](TaxIdentifiersApi.md#taxidentifierschemabycountry) | **GET** /tax-identifiers/schema | Returns the tax identifier request &amp; response schema for a specific country.
[**ValidateTaxIdentifier**](TaxIdentifiersApi.md#validatetaxidentifier) | **POST** /tax-identifiers/validate | Validates a tax identifier.


<a name="taxidentifierschemabycountry"></a>
# **TaxIdentifierSchemaByCountry**
> TaxIdentifierSchemaByCountry200Response TaxIdentifierSchemaByCountry (TaxIdentifierSchemaByCountryRequestSdk requestParameters)

Returns the tax identifier request & response schema for a specific country.

This endpoint retrieves the request and response schema required to validate tax identifiers based on a specific country's requirements. This can include both standard fields and any additional parameters required by the respective country's tax authority.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.EInvoicing.V1;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Example
{
    public class TaxIdentifierSchemaByCountryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TaxIdentifiersApi(apiClient);
            var requestParameters = new TaxIdentifierSchemaByCountryRequestSdk();
            requestParameters.AvalaraVersion = 1.4;  // string | The HTTP Header meant to specify the version of the API intended to be used.
            requestParameters.CountryCode = DE;  // string | The two-letter ISO-3166 country code for which the schema should be retrieved.
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\". (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 
            requestParameters.Type = request;  // string | Specifies whether to return the request or response schema. (optional) 

            try
            {
                // Returns the tax identifier request & response schema for a specific country.
                TaxIdentifierSchemaByCountry200Response result = apiInstance.TaxIdentifierSchemaByCountry(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxIdentifiersApi.TaxIdentifierSchemaByCountry: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Request Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used. | 
 **CountryCode** | **string**| The two-letter ISO-3166 country code for which the schema should be retrieved. | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;. | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 
 **Type** | **string**| Specifies whether to return the request or response schema. | [optional] 

### Return type

[**TaxIdentifierSchemaByCountry200Response**](TaxIdentifierSchemaByCountry200Response.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Correlation-Id -  <br>  |
| **400** | Invalid request |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="validatetaxidentifier"></a>
# **ValidateTaxIdentifier**
> TaxIdentifierResponse ValidateTaxIdentifier (ValidateTaxIdentifierRequestSdk requestParameters)

Validates a tax identifier.

This endpoint verifies whether a given tax identifier is valid and properly formatted according to the rules of the applicable country or tax system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.EInvoicing.V1;
using Avalara.SDK.Client;
using Avalara.SDK.Model.EInvoicing.V1;

namespace Example
{
    public class ValidateTaxIdentifierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new TaxIdentifiersApi(apiClient);
            var requestParameters = new ValidateTaxIdentifierRequestSdk();
            requestParameters.AvalaraVersion = 1.4;  // string | The HTTP Header meant to specify the version of the API intended to be used.
            requestParameters.TaxIdentifierRequest = new TaxIdentifierRequest(); // TaxIdentifierRequest | 
            requestParameters.XAvalaraClient = John's E-Invoicing-API Client;  // string | You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \"Fingerprint\". (optional) 
            requestParameters.XCorrelationID = f3f0d19a-01a1-4748-8a58-f000d0424f43;  // string | The caller can use this as an identifier to use as a correlation id to trace the call. (optional) 

            try
            {
                // Validates a tax identifier.
                TaxIdentifierResponse result = apiInstance.ValidateTaxIdentifier(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxIdentifiersApi.ValidateTaxIdentifier: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Request Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **AvalaraVersion** | **string**| The HTTP Header meant to specify the version of the API intended to be used. | 
 **TaxIdentifierRequest** | [**TaxIdentifierRequest**](TaxIdentifierRequest.md)|  | 
 **XAvalaraClient** | **string**| You can freely use any text you wish for this value. This feature can help you diagnose and solve problems with your software. The header can be treated like a \&quot;Fingerprint\&quot;. | [optional] 
 **XCorrelationID** | **string**| The caller can use this as an identifier to use as a correlation id to trace the call. | [optional] 

### Return type

[**TaxIdentifierResponse**](TaxIdentifierResponse.md)

### Authorization

[Bearer](../../../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response. |  * X-Correlation-Id -  <br>  |
| **400** | Invalid request |  * X-Correlation-Id -  <br>  |
| **401** | Unauthorized |  * X-Correlation-Id -  <br>  |
| **403** | Forbidden |  * X-Correlation-Id -  <br>  |
| **429** | Rate limit exceeded |  * X-Correlation-Id -  <br>  |
| **500** | Internal server error |  * X-Correlation-Id -  <br>  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

