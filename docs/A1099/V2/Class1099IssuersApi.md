# Avalara.SDK.Api.A1099.V2.Class1099IssuersApi

All URIs are relative to *https://api-ava1099.gamma.qa.us-west-2.aws.avalara.io/avalara1099*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateIssuer**](Class1099IssuersApi.md#createissuer) | **POST** /1099/issuers | Create an issuer
[**DeleteIssuer**](Class1099IssuersApi.md#deleteissuer) | **DELETE** /1099/issuers/{id} | Delete an issuer
[**GetIssuer**](Class1099IssuersApi.md#getissuer) | **GET** /1099/issuers/{id} | Get an issuer
[**ListIssuers**](Class1099IssuersApi.md#listissuers) | **GET** /1099/issuers | List issuers
[**UpdateIssuer**](Class1099IssuersApi.md#updateissuer) | **PUT** /1099/issuers/{id} | Update an issuer


<a name="createissuer"></a>
# **CreateIssuer**
> IssuerModel CreateIssuer (CreateIssuerRequest requestParameters)

Create an issuer

Create a new issuer

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
    public class CreateIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new CreateIssuerRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = de1d7808-7142-4d7f-9615-70a5cb4e4aa5;  // string | Unique correlation Id in a GUID format
            requestParameters.IssuerModel = new IssuerModel(); // IssuerModel | The issuer to create (optional) 

            try
            {
                // Create an issuer
                IssuerModel result = apiInstance.CreateIssuer(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.CreateIssuer: " + e.Message );
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
 **IssuerModel** | [**IssuerModel**](IssuerModel.md)| The issuer to create | [optional] 

### Return type

[**IssuerModel**](IssuerModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created issuer |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="deleteissuer"></a>
# **DeleteIssuer**
> void DeleteIssuer (DeleteIssuerRequest requestParameters)

Delete an issuer

Delete an issuer

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
    public class DeleteIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new DeleteIssuerRequest();
            requestParameters.Id = "id_example";  // string | Id of the issuer to delete
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 63408873-6519-409e-89ff-426a1b4f26b0;  // string | Unique correlation Id in a GUID format

            try
            {
                // Delete an issuer
                apiInstance.DeleteIssuer(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.DeleteIssuer: " + e.Message );
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
 **Id** | **string**| Id of the issuer to delete | 
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

<a name="getissuer"></a>
# **GetIssuer**
> IssuerModel GetIssuer (GetIssuerRequest requestParameters)

Get an issuer

Get an issuer

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
    public class GetIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new GetIssuerRequest();
            requestParameters.Id = "id_example";  // string | 
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = a33051b5-d211-4a36-bd3a-18a18bcb7712;  // string | Unique correlation Id in a GUID format

            try
            {
                // Get an issuer
                IssuerModel result = apiInstance.GetIssuer(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.GetIssuer: " + e.Message );
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

[**IssuerModel**](IssuerModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Single issuer |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="listissuers"></a>
# **ListIssuers**
> PaginatedQueryResultModelIssuerModel ListIssuers (ListIssuersRequest requestParameters)

List issuers

List issuers for a given tax year. Filterable fields are name, referenceId and taxYear

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
    public class ListIssuersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new ListIssuersRequest();
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 6483b3ae-1573-4cc3-a7d2-ed593c669cd2;  // string | Unique correlation Id in a GUID format
            requestParameters.Filter = "filter_example";  // string | A filter statement to identify specific records to retrieve. For more information on filtering, see <a href=\"https://developer.avalara.com/avatax/filtering-in-rest/\">Filtering in REST</a>. (optional) 
            requestParameters.Top = 10;  // int? | If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)  (default to 10)
            requestParameters.Skip = 0;  // int? | If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets. (optional)  (default to 0)
            requestParameters.OrderBy = "orderBy_example";  // string | A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC. (optional) 
            requestParameters.Count = true;  // bool? | When true, returns a @recordSetCount in the result set (optional) 

            try
            {
                // List issuers
                PaginatedQueryResultModelIssuerModel result = apiInstance.ListIssuers(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.ListIssuers: " + e.Message );
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

[**PaginatedQueryResultModelIssuerModel**](PaginatedQueryResultModelIssuerModel.md)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of issuers |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Authentication failed |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

<a name="updateissuer"></a>
# **UpdateIssuer**
> void UpdateIssuer (UpdateIssuerRequest requestParameters)

Update an issuer

Update an existing issuer

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
    public class UpdateIssuerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";
            
            ApiClient apiClient= new ApiClient(config);
            
            var apiInstance = new Class1099IssuersApi(apiClient);
            var requestParameters = new UpdateIssuerRequest();
            requestParameters.Id = "id_example";  // string | Id of the issuer to Update
            requestParameters.AvalaraVersion = 2.0;  // string | API version
            requestParameters.XCorrelationId = 369b51d1-f4ba-45e1-8273-c3935ebca96a;  // string | Unique correlation Id in a GUID format
            requestParameters.IssuerModel = new IssuerModel(); // IssuerModel | The issuer to update (optional) 

            try
            {
                // Update an issuer
                apiInstance.UpdateIssuer(requestParameters);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Class1099IssuersApi.UpdateIssuer: " + e.Message );
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
 **Id** | **string**| Id of the issuer to Update | 
 **AvalaraVersion** | **string**| API version | 
 **XCorrelationId** | **string**| Unique correlation Id in a GUID format | 
 **IssuerModel** | [**IssuerModel**](IssuerModel.md)| The issuer to update | [optional] 

### Return type

void (empty response body)

### Authorization

[bearer](../../../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Issuer updated |  -  |
| **400** | Bad request (e.g., invalid sort key) |  -  |
| **401** | Unauthorized |  -  |
| **404** | Resource Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

