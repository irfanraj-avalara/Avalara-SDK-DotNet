# Avalara.SDK.Api.A1099.V2.Class1099JobsApi

All URIs are relative to *https://api-ava1099.gamma.qa.us-west-2.aws.avalara.io/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetJob**](Class1099JobsApi.md#getjob) | **GET** /1099/jobs/{id} | Retrieves information about the job


<a name="getjob"></a>
# **GetJob**
> JobResult GetJob (GetJobRequest requestParameters)

Retrieves information about the job

Retrieves information about the job

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
    public class GetJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099JobsApi(apiClient);
            var requestParameters = new GetJobRequest();
            requestParameters.Id = "id_example";  // string | Job id obtained from other API responses, like `/1099/bulk-upsert`.
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = d5813dd9-0646-48b6-85a6-5b1db5100588;  // string | Unique correlation Id in a GUID format

            try
            {
                // Retrieves information about the job
                JobResult result = apiInstance.GetJob(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099JobsApi.GetJob: " + e.Message );
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
 **Id** | **string**| Job id obtained from other API responses, like &#x60;/1099/bulk-upsert&#x60;. | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 

### Return type

[**JobResult**](JobResult.md)

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

