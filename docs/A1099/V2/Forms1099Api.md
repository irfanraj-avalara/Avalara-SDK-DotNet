# Avalara.SDK.Api.A1099.V2.Forms1099Api

All URIs are relative to *https://api-ava1099.eta.sbx.us-east-1.aws.avalara.io/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkUpsert1099Forms**](Forms1099Api.md#bulkupsert1099forms) | **POST** /1099/forms/$bulk-upsert | Create or update multiple 1099 forms.
[**Create1099Form**](Forms1099Api.md#create1099form) | **POST** /1099/forms | Create a 1099 form.
[**Delete1099Form**](Forms1099Api.md#delete1099form) | **DELETE** /1099/forms/{id} | Delete a 1099 form.
[**Get1099Form**](Forms1099Api.md#get1099form) | **GET** /1099/forms/{id} | Retrieve a 1099 form.
[**Get1099FormPdf**](Forms1099Api.md#get1099formpdf) | **GET** /1099/forms/{id}/pdf | Retrieve the PDF file for a single 1099 by form id.
[**List1099Forms**](Forms1099Api.md#list1099forms) | **GET** /1099/forms | Retrieve a list of 1099 forms based on query parameters.
[**Update1099Form**](Forms1099Api.md#update1099form) | **PUT** /1099/forms/{id} | Update a 1099 form.


<a name="bulkupsert1099forms"></a>
# **BulkUpsert1099Forms**
> Form1099ProccessResult BulkUpsert1099Forms (BulkUpsert1099FormsRequest requestParameters)

Create or update multiple 1099 forms.

This endpoint allows you to create or update multiple 1099 forms.  The following is an example of a 1099-NEC payload.  ```json  {    \"formType\": \"1099-NEC\",    \"forms\": [      {        \"issuerID\": \"180337282\",        \"issuerReferenceId\": \"ISS123\",        \"issuerTin\": \"12-3000000\",        \"taxYear\": 2024,        \"referenceID\": \"REF-002\",        \"recipientName\": \"Jane Smith\",        \"recipientSecondName\": \"\",        \"recipientTin\": \"987-65-4321\",        \"tinType\": 1,        \"streetAddress\": \"123 Center St\",        \"streetAddressLine2\": \"\",        \"city\": \"Santa Monica\",        \"state\": \"CA\",        \"zip\": \"90401\",        \"countryCode\": \"US\",        \"recipientNonUsProvince\": \"\",        \"recipientEmail\": \"\",        \"accountNumber\": \"\",        \"officeCode\": \"\",        \"secondTinNotice\": false,        \"nonemployeeCompensation\": 123.45,        \"payerMadeDirectSales\": false,        \"federalIncomeTaxWithheld\": 12.34,        \"stateAndLocalWithholding\": {          \"state\": \"CA\",          \"stateIdNumber\": \"123123123\"          \"stateIncome\": 123.45,          \"stateTaxWithheld\": 12.34,          \"locality\": \"Santa Monica\",          \"localityIdNumber\": \"456456\",          \"localTaxWithheld\": 12.34          \"localIncome\": 50000.00         },        \"federalEFile\": true,        \"postalMail\": true,        \"stateEFile\": true,        \"tinMatch\": true,        \"addressVerification\": true       }     ]   }  ```  The following is an example of a 1099-R payload.  ```json  {    \"formType\": \"1099-R\",    \"forms\": [      {        \"issuerID\": \"180337282\",        \"issuerReferenceId\": \"ISS123\",        \"issuerTin\": \"12-3000000\",        \"taxYear\": 2024,        \"referenceID\": \"REF-002\",        \"recipientName\": \"Jane Smith\",        \"recipientSecondName\": \"Second name\",        \"recipientTin\": \"987-65-4321\",        \"tinType\": 1,        \"streetAddress\": \"123 Center St\",        \"streetAddressLine2\": \"Side Address\",        \"city\": \"Santa Monica\",        \"state\": \"CA\",        \"zip\": \"90401\",        \"countryCode\": \"US\",        \"recipientNonUsProvince\": \"\",        \"recipientEmail\": \"email@email.com\",        \"accountNumber\": \"1234\",        \"officeCode\": \"345\",        \"grossDistribution\": 123.45,        \"taxableAmount\": 12.34,        \"taxableAmountNotDetermined\": false,        \"totalDistributionDetermined\": true,        \"capitalGain\": 0,        \"federalIncomeTaxWithheld\": 10.00,        \"employeeContributionsOrDesignatedRothOrInsurancePremiums\": 2000.00,        \"netUnrealizedAppreciationInEmployerSecurities\": 10.00,        \"distributionCode\": \"M\",        \"secondDistributionCode\": \"B\",        \"iraSepSimple\": true,        \"traditionalIraSepSimpleOrRothConversionAmount\": 3000.00,        \"otherAmount\": 500.00,        \"otherPercentage\": \"10\",        \"totalDistributionPercentage\": \"99\",        \"totalEmployeeContributions\": 15000.00,        \"amountAllocableToIrrWithin5Years\": 1000.00,        \"firstYearOfDesignatedRothContribution\": 2020,        \"fatcaFilingRequirement\": true,        \"dateOfPayment\": \"2024-01-01\",        \"stateAndLocalWithholding\": {          \"state\": \"CA\",          \"stateIdNumber\": \"123123123\",          \"stateIncome\": 50000.00,          \"stateTaxWithheld\": 2500.00,          \"locality\": \"Santa Monica\",          \"localityIdNumber\": \"456456\",          \"localTaxWithheld\": 1000.00,          \"localIncome\": 50000.00        },        \"federalEFile\": true,        \"postalMail\": true,        \"stateEFile\": true,        \"tinMatch\": true,        \"addressVerification\": true      }     ]   }  ```                For the full version of the payload and its schema details, refer to the Swagger schemas section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class BulkUpsert1099FormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Forms1099Api(apiClient);
            var requestParameters = new BulkUpsert1099FormsRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 3963ab89-2b81-4887-a569-1f04b75f3f17;  // string | Unique correlation Id in a GUID format
            requestParameters.DryRun = false;  // bool? |  (optional)  (default to false)
            requestParameters.BulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(); // BulkUpsert1099FormsRequest |  (optional) 

            try
            {
                // Create or update multiple 1099 forms.
                Form1099ProccessResult result = apiInstance.BulkUpsert1099Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Forms1099Api.BulkUpsert1099Forms: " + e.Message );
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
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **DryRun** | **bool?**|  | [optional] [default to false]
 **BulkUpsert1099FormsRequest** | [**BulkUpsert1099FormsRequest**](BulkUpsert1099FormsRequest.md)|  | [optional] 

### Return type

[**Form1099ProccessResult**](Form1099ProccessResult.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="create1099form"></a>
# **Create1099Form**
> FormResponseBase Create1099Form (Create1099FormRequest requestParameters)

Create a 1099 form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class Create1099FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Forms1099Api(apiClient);
            var requestParameters = new Create1099FormRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 9a89782f-78e0-42ef-bbec-f477a189f3e0;  // string | Unique correlation Id in a GUID format
            requestParameters.ICreateForm1099Request = new ICreateForm1099Request(); // ICreateForm1099Request |  (optional) 

            try
            {
                // Create a 1099 form.
                FormResponseBase result = apiInstance.Create1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Forms1099Api.Create1099Form: " + e.Message );
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
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **ICreateForm1099Request** | [**ICreateForm1099Request**](ICreateForm1099Request.md)|  | [optional] 

### Return type

[**FormResponseBase**](FormResponseBase.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="delete1099form"></a>
# **Delete1099Form**
> void Delete1099Form (Delete1099FormRequest requestParameters)

Delete a 1099 form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class Delete1099FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Forms1099Api(apiClient);
            var requestParameters = new Delete1099FormRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = e903c4c1-7152-414c-8620-395f33cb4e5e;  // string | Unique correlation Id in a GUID format

            try
            {
                // Delete a 1099 form.
                apiInstance.Delete1099Form(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Forms1099Api.Delete1099Form: " + e.Message );
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
 **Id** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="get1099form"></a>
# **Get1099Form**
> FormResponseBase Get1099Form (Get1099FormRequest requestParameters)

Retrieve a 1099 form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class Get1099FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Forms1099Api(apiClient);
            var requestParameters = new Get1099FormRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 52c66a6d-1c3f-4d36-bb30-ad91fefdea10;  // string | Unique correlation Id in a GUID format

            try
            {
                // Retrieve a 1099 form.
                FormResponseBase result = apiInstance.Get1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Forms1099Api.Get1099Form: " + e.Message );
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
 **Id** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

[**FormResponseBase**](FormResponseBase.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="get1099formpdf"></a>
# **Get1099FormPdf**
> FormResponseBase Get1099FormPdf (Get1099FormPdfRequest requestParameters)

Retrieve the PDF file for a single 1099 by form id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class Get1099FormPdfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Forms1099Api(apiClient);
            var requestParameters = new Get1099FormPdfRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 1ea4ab5a-d240-4e79-9834-16e0b50e7f4e;  // string | Unique correlation Id in a GUID format
            requestParameters.MarkEdelivered = true;  // bool? | The parameter for marked e-delivered (optional) 

            try
            {
                // Retrieve the PDF file for a single 1099 by form id.
                FormResponseBase result = apiInstance.Get1099FormPdf(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Forms1099Api.Get1099FormPdf: " + e.Message );
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
 **Id** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **MarkEdelivered** | **bool?**| The parameter for marked e-delivered | [optional] 

### Return type

[**FormResponseBase**](FormResponseBase.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="list1099forms"></a>
# **List1099Forms**
> Form1099List List1099Forms (List1099FormsRequest requestParameters)

Retrieve a list of 1099 forms based on query parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class List1099FormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Forms1099Api(apiClient);
            var requestParameters = new List1099FormsRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = e77dca14-9113-49b8-9b50-fb4333924e9b;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>.    Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.    Supported filtering fields are as follows:        issuerId      issuerReferenceId      taxYear      addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified      createdAt      edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted      email      federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held      firstPayeeName      mailStatus - possible values are: sent, unscheduled, pending, delivered      referenceId      tinMatchStatus - possible values are: none, pending, matched, failed      type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC      updatedAt      validity - possible values are: true, false (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results.     Used with skip to provide pagination for large datasets.     Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example issuerReferenceId ASC.    Supported sorting fields are:         issuerReferenceId       taxYear       createdAt       firstPayeeName      updatedAt (optional) 

            try
            {
                // Retrieve a list of 1099 forms based on query parameters.
                Form1099List result = apiInstance.List1099Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Forms1099Api.List1099Forms: " + e.Message );
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
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **Filter** | **string**| A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.    Collections support filtering only on certain fields. An attempt to filter on an unsupported field will receive a 400 Bad Request response.    Supported filtering fields are as follows:        issuerId      issuerReferenceId      taxYear      addressVerificationStatus - possible values are: unknown, pending, failed, incomplete, unchanged, verified      createdAt      edeliveryStatus - possible values are: sent, unscheduled, bad_verify, bad_verify_limit, scheduled, bounced, accepted      email      federalEfileStatus - possible values are: unscheduled, scheduled, sent, corrected_scheduled, accepted, corrected, corrected_accepted, held      firstPayeeName      mailStatus - possible values are: sent, unscheduled, pending, delivered      referenceId      tinMatchStatus - possible values are: none, pending, matched, failed      type - possible values are: 940, 941, 943, 944, 945, 1042, 1042-S, 1095-B, 1095-C, 1097-BTC, 1098, 1098-C, 1098-E, 1098-Q, 1098-T, 3921, 3922, 5498, 5498-ESA, 5498-SA, 1099-MISC, 1099-A, 1099-B, 1099-C, 1099-CAP, 1099-DIV, 1099-G, 1099-INT, 1099-K, 1099-LS, 1099-LTC, 1099-NEC, 1099-OID, 1099-PATR, 1099-Q, 1099-R, 1099-S, 1099-SA, T4A, W-2, W-2G, 1099-HC      updatedAt      validity - possible values are: true, false | [optional] 
 **Top** | **int?**| If nonzero, return no more than this number of results.     Used with skip to provide pagination for large datasets.     Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. | [optional] [default to 10]
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] [default to 0]
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example issuerReferenceId ASC.    Supported sorting fields are:         issuerReferenceId       taxYear       createdAt       firstPayeeName      updatedAt | [optional] 

### Return type

[**Form1099List**](Form1099List.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="update1099form"></a>
# **Update1099Form**
> FormResponseBase Update1099Form (Update1099FormRequest requestParameters)

Update a 1099 form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.A1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Example
{
    public class Update1099FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Forms1099Api(apiClient);
            var requestParameters = new Update1099FormRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = da876dff-58bf-4899-adef-07acb9d31773;  // string | Unique correlation Id in a GUID format
            requestParameters.IUpdateForm1099Request = new IUpdateForm1099Request(); // IUpdateForm1099Request |  (optional) 

            try
            {
                // Update a 1099 form.
                FormResponseBase result = apiInstance.Update1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Forms1099Api.Update1099Form: " + e.Message );
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
 **Id** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **IUpdateForm1099Request** | [**IUpdateForm1099Request**](IUpdateForm1099Request.md)|  | [optional] 

### Return type

[**FormResponseBase**](FormResponseBase.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

