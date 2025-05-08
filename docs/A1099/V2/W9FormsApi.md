# Avalara.SDK.Api.A1099.V2.W9FormsApi

All URIs are relative to *https://api-ava1099.gamma.qa.us-west-2.aws.avalara.io/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateW9Form**](W9FormsApi.md#createw9form) | **POST** /w9/forms | Create a W9/W4/W8 form
[**DeleteW9Form**](W9FormsApi.md#deletew9form) | **DELETE** /w9/forms/{id} | Delete a form
[**GetW9Form**](W9FormsApi.md#getw9form) | **GET** /w9/forms/{id} | Retrieve a W9/W4/W8 form
[**GetW9FormRequest**](W9FormsApi.md#getw9formrequest) | **GET** /w9/forms/requests/{formRequestId} | Retrieve a form request
[**ListW9Forms**](W9FormsApi.md#listw9forms) | **GET** /w9/forms | List W9/W4/W8 forms.
[**UpdateW9Form**](W9FormsApi.md#updatew9form) | **PUT** /w9/forms/{id} | Update a W9/W4/W8 form
[**UploadW9Files**](W9FormsApi.md#uploadw9files) | **PUT** /w9/forms/{id}/attachment | Upload files for a W9/W4/W8 form


<a name="createw9form"></a>
# **CreateW9Form**
> IW9FormDataModelsOneOf CreateW9Form (CreateW9FormRequest requestParameters)

Create a W9/W4/W8 form

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
    public class CreateW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new CreateW9FormRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = a1f670b5-1ad3-497a-aca7-e9174e0cf6e6;  // string | Unique correlation Id in a GUID format
            requestParameters.IW9FormDataModelsOneOf = new IW9FormDataModelsOneOf(); // IW9FormDataModelsOneOf | Form to be created (optional) 

            try
            {
                // Create a W9/W4/W8 form
                IW9FormDataModelsOneOf result = apiInstance.CreateW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.CreateW9Form: " + e.Message );
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
 **IW9FormDataModelsOneOf** | [**IW9FormDataModelsOneOf**](IW9FormDataModelsOneOf.md)| Form to be created | [optional] 

### Return type

[**IW9FormDataModelsOneOf**](IW9FormDataModelsOneOf.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created W9/W4/W8 form |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="deletew9form"></a>
# **DeleteW9Form**
> void DeleteW9Form (DeleteW9FormRequest requestParameters)

Delete a form

Delete a form

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
    public class DeleteW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new DeleteW9FormRequest();
            requestParameters.Id = "id_example";  // string | Id of the form to delete
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = e51b7752-76a6-4f5d-ade3-508bca242241;  // string | Unique correlation Id in a GUID format

            try
            {
                // Delete a form
                apiInstance.DeleteW9Form(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.DeleteW9Form: " + e.Message );
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
 **Id** | **string**| Id of the form to delete | 
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
| **204** | Empty response |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getw9form"></a>
# **GetW9Form**
> IW9FormDataModelsOneOf GetW9Form (GetW9FormRequest requestParameters)

Retrieve a W9/W4/W8 form

Retreive a W9/W4/W8 form

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
    public class GetW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new GetW9FormRequest();
            requestParameters.Id = "id_example";  // string | Id of the form
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 7d52bb1a-2fa5-4bd9-8d58-b89718c648c8;  // string | Unique correlation Id in a GUID format

            try
            {
                // Retrieve a W9/W4/W8 form
                IW9FormDataModelsOneOf result = apiInstance.GetW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.GetW9Form: " + e.Message );
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
 **Id** | **string**| Id of the form | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

[**IW9FormDataModelsOneOf**](IW9FormDataModelsOneOf.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | W9/W4/W8 form with id |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="getw9formrequest"></a>
# **GetW9FormRequest**
> FormRequestModel GetW9FormRequest (GetW9FormRequestRequest requestParameters)

Retrieve a form request

Retrieve a form request after creation: not likely to be useful except in testing. Previously-valid form requests will be Not Found after `expires_at`.

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
    public class GetW9FormRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new GetW9FormRequestRequest();
            requestParameters.FormRequestId = "formRequestId_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 78b55fe3-8cc3-484a-b010-7254a0c4497b;  // string | Unique correlation Id in a GUID format

            try
            {
                // Retrieve a form request
                FormRequestModel result = apiInstance.GetW9FormRequest(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.GetW9FormRequest: " + e.Message );
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
 **FormRequestId** | **string**|  | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

[**FormRequestModel**](FormRequestModel.md)

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
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="listw9forms"></a>
# **ListW9Forms**
> PaginatedW9FormsModel ListW9Forms (ListW9FormsRequest requestParameters)

List W9/W4/W8 forms.

List W9/W4/W8 forms.

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
    public class ListW9FormsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new ListW9FormsRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 53d9d720-e729-40be-bebc-1438d2a0f74a;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | When true, returns a @recordSetCount in the result set (optional) 

            try
            {
                // List W9/W4/W8 forms.
                PaginatedW9FormsModel result = apiInstance.ListW9Forms(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.ListW9Forms: " + e.Message );
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

[**PaginatedW9FormsModel**](PaginatedW9FormsModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of forms |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updatew9form"></a>
# **UpdateW9Form**
> IW9FormDataModelsOneOf UpdateW9Form (UpdateW9FormRequest requestParameters)

Update a W9/W4/W8 form

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
    public class UpdateW9FormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new UpdateW9FormRequest();
            requestParameters.Id = "id_example";  // string | Id of the form to update
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = cc819fb3-098f-41a8-9e9a-8b87f8230268;  // string | Unique correlation Id in a GUID format
            requestParameters.IW9FormDataModelsOneOf = new IW9FormDataModelsOneOf(); // IW9FormDataModelsOneOf | Form to be updated (optional) 

            try
            {
                // Update a W9/W4/W8 form
                IW9FormDataModelsOneOf result = apiInstance.UpdateW9Form(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.UpdateW9Form: " + e.Message );
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
 **Id** | **string**| Id of the form to update | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **IW9FormDataModelsOneOf** | [**IW9FormDataModelsOneOf**](IW9FormDataModelsOneOf.md)| Form to be updated | [optional] 

### Return type

[**IW9FormDataModelsOneOf**](IW9FormDataModelsOneOf.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated W9/W4/W8 form |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="uploadw9files"></a>
# **UploadW9Files**
> string UploadW9Files (UploadW9FilesRequest requestParameters)

Upload files for a W9/W4/W8 form

Upload files for a W9/W4/W8 form

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
    public class UploadW9FilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new W9FormsApi(apiClient);
            var requestParameters = new UploadW9FilesRequest();
            requestParameters.Id = "id_example";  // string | Id of the form
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = befc0897-e2db-4b03-8913-e83c7b47cb06;  // string | Unique correlation Id in a GUID format
            requestParameters.File = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                // Upload files for a W9/W4/W8 form
                string result = apiInstance.UploadW9Files(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling W9FormsApi.UploadW9Files: " + e.Message );
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
 **Id** | **string**| Id of the form | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **File** | **FileParameter****FileParameter**|  | [optional] 

### Return type

**string**

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | W9/W4/W8 form with id |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

