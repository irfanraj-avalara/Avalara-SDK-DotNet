# Avalara.SDK.Api.Track1099.V2.FormRequestsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiFormRequestsFormRequestIdGet**](FormRequestsApi.md#apiformrequestsformrequestidget) | **GET** /api/form-requests/{formRequestId} | 


<a name="apiformrequestsformrequestidget"></a>
# **ApiFormRequestsFormRequestIdGet**
> FormRequestModel ApiFormRequestsFormRequestIdGet (ApiFormRequestsFormRequestIdGetRequest requestParameters)



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
    public class ApiFormRequestsFormRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new FormRequestsApi(apiClient);
            var requestParameters = new ApiFormRequestsFormRequestIdGetRequest();
            requestParameters.FormRequestId = "formRequestId_example";  // string | 

            try
            {
                FormRequestModel result = apiInstance.ApiFormRequestsFormRequestIdGet(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FormRequestsApi.ApiFormRequestsFormRequestIdGet: " + e.Message );
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

