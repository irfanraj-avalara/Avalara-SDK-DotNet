# Avalara.SDK.Api.Track1099.V2.AuthorizedApiRequestsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet**](AuthorizedApiRequestsApi.md#apiauthorizedapirequestsauthorizedapirequestidexecuteget) | **GET** /api/authorized_api_requests/{authorizedApiRequestId}/$execute | Execute URL for downloads
[**ApiAuthorizedApiRequestsAuthorizedApiRequestIdGet**](AuthorizedApiRequestsApi.md#apiauthorizedapirequestsauthorizedapirequestidget) | **GET** /api/authorized_api_requests/{authorizedApiRequestId} | Retrieve URL for downloads
[**ApiAuthorizedApiRequestsPost**](AuthorizedApiRequestsApi.md#apiauthorizedapirequestspost) | **POST** /api/authorized-api-requests | 


<a name="apiauthorizedapirequestsauthorizedapirequestidexecuteget"></a>
# **ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet**
> void ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet (ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest requestParameters)

Execute URL for downloads

Execute the URL you created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new AuthorizedApiRequestsApi(apiClient);
            var requestParameters = new ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGetRequest();
            requestParameters.AuthorizedApiRequestId = "authorizedApiRequestId_example";  // string | 
            requestParameters.R = "r_example";  // string | 

            try
            {
                // Execute URL for downloads
                apiInstance.ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizedApiRequestsApi.ApiAuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet: " + e.Message );
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
 **AuthorizedApiRequestId** | **string**|  | 
 **R** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="apiauthorizedapirequestsauthorizedapirequestidget"></a>
# **ApiAuthorizedApiRequestsAuthorizedApiRequestIdGet**
> AuthorizedApiRequestV2DataModel ApiAuthorizedApiRequestsAuthorizedApiRequestIdGet (ApiAuthorizedApiRequestsAuthorizedApiRequestIdGetRequest requestParameters)

Retrieve URL for downloads

Retrieve the URL you created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class ApiAuthorizedApiRequestsAuthorizedApiRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new AuthorizedApiRequestsApi(apiClient);
            var requestParameters = new ApiAuthorizedApiRequestsAuthorizedApiRequestIdGetRequest();
            requestParameters.AuthorizedApiRequestId = "authorizedApiRequestId_example";  // string | 

            try
            {
                // Retrieve URL for downloads
                AuthorizedApiRequestV2DataModel result = apiInstance.ApiAuthorizedApiRequestsAuthorizedApiRequestIdGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizedApiRequestsApi.ApiAuthorizedApiRequestsAuthorizedApiRequestIdGet: " + e.Message );
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
 **AuthorizedApiRequestId** | **string**|  | 

### Return type

[**AuthorizedApiRequestV2DataModel**](AuthorizedApiRequestV2DataModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="apiauthorizedapirequestspost"></a>
# **ApiAuthorizedApiRequestsPost**
> AuthorizedApiRequestV2DataModel ApiAuthorizedApiRequestsPost (ApiAuthorizedApiRequestsPostRequest requestParameters)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Track1099.V2;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Track1099.V2;

namespace Example
{
    public class ApiAuthorizedApiRequestsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new AuthorizedApiRequestsApi(apiClient);
            var requestParameters = new ApiAuthorizedApiRequestsPostRequest();
            requestParameters.AuthorizedApiRequestModel = new AuthorizedApiRequestModel(); // AuthorizedApiRequestModel |  (optional) 

            try
            {
                AuthorizedApiRequestV2DataModel result = apiInstance.ApiAuthorizedApiRequestsPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizedApiRequestsApi.ApiAuthorizedApiRequestsPost: " + e.Message );
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
 **AuthorizedApiRequestModel** | [**AuthorizedApiRequestModel**](AuthorizedApiRequestModel.md)|  | [optional] 

### Return type

[**AuthorizedApiRequestV2DataModel**](AuthorizedApiRequestV2DataModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

