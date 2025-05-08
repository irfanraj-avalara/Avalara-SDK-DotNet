# Avalara.SDK.Api.A1099.V2.Class1099FormsApi

All URIs are relative to *https://api-ava1099.gamma.qa.us-west-2.aws.avalara.io/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkUpsert1099Forms**](Class1099FormsApi.md#bulkupsert1099forms) | **POST** /1099/forms/$bulk-upsert | Create or update multiple 1099 forms.
[**Create1099Form**](Class1099FormsApi.md#create1099form) | **POST** /1099/forms | Create a 1099 form.
[**Delete1099Form**](Class1099FormsApi.md#delete1099form) | **DELETE** /1099/forms/{id} | Delete a 1099 form.
[**Get1099Form**](Class1099FormsApi.md#get1099form) | **GET** /1099/forms/{id} | Retrieve a 1099 form.
[**List1099Forms**](Class1099FormsApi.md#list1099forms) | **GET** /1099/forms | Retrieve a list of 1099 forms based on query parameters.
[**Update1099Form**](Class1099FormsApi.md#update1099form) | **PUT** /1099/forms/{id} | Update a 1099 form.


<a name="bulkupsert1099forms"></a>
# **BulkUpsert1099Forms**
> Form1099CsvProccessResult BulkUpsert1099Forms (BulkUpsert1099FormsRequest requestParameters)

Create or update multiple 1099 forms.

This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  ```json  {     \"formType\": \"Form1099Misc\",     \"form1099MiscCsvRequests\": [         {             \"IssuerID\": \"123456\",             \"IssuerReferenceID\": \"REF-7890\",             \"IssuerTin\": \"98-7654321\",             \"TaxYear\": 2024,             \"ReferenceID\": \"REF-001\",             \"RecipientName\": \"John Doe\",             \"RecipientFederalID\": \"123-45-6789\",             ...         }     ]  }  ```                **Form 1099-NEC:**  ```json  {     \"formType\": \"Form1099Nec\",     \"form1099NecCsvRequests\": [         {             \"IssuerID\": \"987654\",             \"IssuerReferenceID\": \"REF-4567\",             \"IssuerTin\": \"12-3456789\",             \"TaxYear\": 2024,             \"ReferenceID\": \"REF-002\",             \"RecipientName\": \"Jane Smith\",             \"RecipientFederalID\": \"987-65-4321\",             ...         }     ]  }  ```                For the full version of the payload and its schema details, refer to the Swagger schemas section.

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
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new BulkUpsert1099FormsRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 68f29792-7aa3-4293-aa38-85d68b0ef63f;  // string | Unique correlation Id in a GUID format
            requestParameters.BulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(); // BulkUpsert1099FormsRequest |  (optional) 

            try
            {
                // Create or update multiple 1099 forms.
                Form1099CsvProccessResult result = apiInstance.BulkUpsert1099Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.BulkUpsert1099Forms: " + e.Message );
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
 **BulkUpsert1099FormsRequest** | [**BulkUpsert1099FormsRequest**](BulkUpsert1099FormsRequest.md)|  | [optional] 

### Return type

[**Form1099CsvProccessResult**](Form1099CsvProccessResult.md)

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
> FormCsvResponseBase Create1099Form (Create1099FormRequest requestParameters)

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
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Create1099FormRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 8bf839e2-8bdd-4ec9-bccc-0490107cec27;  // string | Unique correlation Id in a GUID format
            requestParameters.Update1099FormRequest = new Update1099FormRequest(); // Update1099FormRequest |  (optional) 

            try
            {
                // Create a 1099 form.
                FormCsvResponseBase result = apiInstance.Create1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Create1099Form: " + e.Message );
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
 **Update1099FormRequest** | [**Update1099FormRequest**](Update1099FormRequest.md)|  | [optional] 

### Return type

[**FormCsvResponseBase**](FormCsvResponseBase.md)

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
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Delete1099FormRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 66bfc6d9-5e88-4b44-b7f8-7c06092d0bb7;  // string | Unique correlation Id in a GUID format

            try
            {
                // Delete a 1099 form.
                apiInstance.Delete1099Form(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Delete1099Form: " + e.Message );
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
> FormCsvResponseBase Get1099Form (Get1099FormRequest requestParameters)

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
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Get1099FormRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 6c56abc7-b73a-4aff-bf62-c7a08915b262;  // string | Unique correlation Id in a GUID format

            try
            {
                // Retrieve a 1099 form.
                FormCsvResponseBase result = apiInstance.Get1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Get1099Form: " + e.Message );
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

[**FormCsvResponseBase**](FormCsvResponseBase.md)

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
> PaginatedFormCsvResponse List1099Forms (List1099FormsRequest requestParameters)

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
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new List1099FormsRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = bfc86bba-6798-406f-a0e6-dd06d048269b;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | When true, returns a @recordSetCount in the result set (optional) 

            try
            {
                // Retrieve a list of 1099 forms based on query parameters.
                PaginatedFormCsvResponse result = apiInstance.List1099Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.List1099Forms: " + e.Message );
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
 **Filter** | **string**| A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;. | [optional] 
 **Top** | **int?**| If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. | [optional] [default to 10]
 **Skip** | **int?**| If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. | [optional] [default to 0]
 **OrderBy** | **string**| A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. | [optional] 
 **Count** | **bool?**| When true, returns a @recordSetCount in the result set | [optional] 

### Return type

[**PaginatedFormCsvResponse**](PaginatedFormCsvResponse.md)

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
> FormCsvResponseBase Update1099Form (Update1099FormRequest requestParameters)

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
            
            var apiInstance = new Class1099FormsApi(apiClient);
            var requestParameters = new Update1099FormRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 239c86c8-5568-4780-a2e2-b5c4388b9cbc;  // string | Unique correlation Id in a GUID format
            requestParameters.Update1099FormRequest = new Update1099FormRequest(); // Update1099FormRequest |  (optional) 

            try
            {
                // Update a 1099 form.
                FormCsvResponseBase result = apiInstance.Update1099Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099FormsApi.Update1099Form: " + e.Message );
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
 **Update1099FormRequest** | [**Update1099FormRequest**](Update1099FormRequest.md)|  | [optional] 

### Return type

[**FormCsvResponseBase**](FormCsvResponseBase.md)

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

