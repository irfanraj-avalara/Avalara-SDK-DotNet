# Avalara.SDK - the C# library for the foundation

Platform foundation consists of services on top of which the Avalara Compliance Cloud platform is built. These services are foundational and provide functionality such as common organization, tenant and user management for the rest of the compliance platform.

<a name="frameworks-supported"></a>

## Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>

## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

<a name="getting-started"></a>

## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.Avatax;
using Avalara.SDK.Client;
using Avalara.SDK.Model.Avatax;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

           Configuration config = new Configuration();
            config.Environment = AvalaraEnvironment.Sandbox;
            config.BearerToken = "<Your Bearer Token>";

            ApiClient apiClient= new ApiClient(config);

            var apiInstance = new AddressesApi(apiClient);
            var requestParameters = new ResolveAddressPostRequest();
            requestParameters.xAvalaraClient = "\"Swagger UI; 22.7.0; Custom; 1.0\"";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional)  (default to "Swagger UI; 22.7.0; Custom; 1.0")
            requestParameters.body = new AddressValidationInfo(); // AddressValidationInfo | The address to resolve (optional)

            try
            {
                // Retrieve geolocation information for a specified address
                AddressResolutionModel result = apiInstance.ResolveAddressPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.ResolveAddressPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-authorization"></a>

## Documentation for Authorization

<a name="OAuth Client Credentials Flow"></a>

### OAuth Client Credentials

- **Type**: OAuth
- **Flow**: client_credentials
- **Scopes**:
  - avatax_api: avatax_api scope.

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.IAMDS;
using Avalara.SDK.Client;
using Avalara.SDK.Model.IAMDS;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration configuration = new Configuration();
            configuration.Environment = AvalaraEnvironment.Sandbox;
            // Avalara Identity Client ID, it can be hard coded or stored as an environment variable as per the example.
            configuration.ClientID = Environment.GetEnvironmentVariable("CLIENT_ID");
            // Avalara Identity Client Secret, do not check in this value to source control.
            configuration.ClientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET");

            configuration.AppName = "Test";
            configuration.AppVersion = "1.0";
            configuration.MachineName = "LocalBox";

            apiclient = new ApiClient(configuration);

            var apiInstance = new AddressesApi(apiClient);

            var requestParameters = new ResolveAddressPostRequest();

            requestParameters.xAvalaraClient = "\"Swagger UI; 22.7.0; Custom; 1.0\"";  // string | Identifies the software you are using to call this API.  For more    information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional)  (default to "Swagger UI; 22.7.0; Custom; 1.0")
            requestParameters.body = new AddressValidationInfo(); // AddressValidationInfo | The address to resolve (optional)

            try
            {
                // OAuth 2 Client Credential Flow will automatically be invoked, retrieve the JWT token from Avalara Identity,
                // and append the token into the Authorization header of the request.
                AddressResolutionModel result = apiInstance.ResolveAddressPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.ResolveAddressPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}

```

<a name="OAuth Device Code Flow"></a>

### OAuth Device Code

- **Type**: OAuth
- **Flow**: device_code
- **Scopes**:
  - avatax_api: avatax_api scope.

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Avalara.SDK.Api.IAMDS;
using Avalara.SDK.Client;
using Avalara.SDK.Model.IAMDS;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration configuration = new Configuration();
            configuration.Environment = AvalaraEnvironment.Sandbox;
            // Avalara Identity Client ID, it can be hard coded or stored as an environment variable as per the example.
            configuration.ClientID = Environment.GetEnvironmentVariable("CLIENT_ID");
            configuration.AppName = "Test";
            configuration.AppVersion = "1.0";
            configuration.MachineName = "LocalBox";

            // Pass in the scope (avatax_api in this instance), and the configuration object, clientID is a required property for the flow.
            // Fetches the device code and verification url required for the user part of the flow (where they open the URI in their web browser and authenticate)
            var deviceResponse = OAuthHelper.initiateDeviceAuthorizationFlow("avatax_api", configuration);
            // Retrieves the accessToken and other metadata relating to the auth request.
            var tokenResponse = OAuthHelper.getAccessTokenForDeviceFlow(deviceResponse.DeviceCode, configuration);
            // Token retrieved from the device code flow will be used in the Authorization header for the requests.
            configuration.BearerToken = tokenResponse.AccessToken;

            apiclient = new ApiClient(configuration);

            var apiInstance = new AddressesApi(apiClient);

            var requestParameters = new ResolveAddressPostRequest();

            requestParameters.xAvalaraClient = "\"Swagger UI; 22.7.0; Custom; 1.0\"";  // string | Identifies the software you are using to call this API.  For more    information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional)  (default to "Swagger UI; 22.7.0; Custom; 1.0")
            requestParameters.body = new AddressValidationInfo(); // AddressValidationInfo | The address to resolve (optional)

            try
            {
                // OAuth 2 Client Credential Flow will automatically be invoked, retrieve the JWT token from Avalara Identity,
                // and append the token into the Authorization header of the request.
                AddressResolutionModel result = apiInstance.ResolveAddressPost(requestParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.ResolveAddressPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}

```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

<a name="documentation-for-EInvoicing-V1-api-endpoints"></a>
### EInvoicing V1 API Documentation

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DataInputFieldsApi* | [**GetDataInputFields**](docs/EInvoicing/V1/DataInputFieldsApi.md#getdatainputfields) | **GET** /data-input-fields | Returns the mandatory and conditional invoice or creditnote input fields for different country mandates
*DocumentsApi* | [**DownloadDocument**](docs/EInvoicing/V1/DocumentsApi.md#downloaddocument) | **GET** /documents/{documentId}/$download | Returns a copy of the document
*DocumentsApi* | [**GetDocumentList**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentlist) | **GET** /documents | Returns a summary of documents for a date range
*DocumentsApi* | [**GetDocumentStatus**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentstatus) | **GET** /document/{documentId}/status | Checks the status of a document
*DocumentsApi* | [**SubmitDocument**](docs/EInvoicing/V1/DocumentsApi.md#submitdocument) | **POST** /documents | Submits a document to Avalara E-Invoicing API
*MandatesApi* | [**GetMandates**](docs/EInvoicing/V1/MandatesApi.md#getmandates) | **GET** /mandates | List country mandates that are supported by the Avalara E-Invoicing platform

<a name="documentation-for-models"></a>
## Documentation for Models

<a name="documentation-for-EInvoicing-V1-models"></a>
### EInvoicing V1 Model Documentation

 - [Model.EInvoicing.V1.BadDownloadRequest](docs/EInvoicing/V1/BadDownloadRequest.md)
 - [Model.EInvoicing.V1.BadRequest](docs/EInvoicing/V1/BadRequest.md)
 - [Model.EInvoicing.V1.ConditionalForField](docs/EInvoicing/V1/ConditionalForField.md)
 - [Model.EInvoicing.V1.DataInputField](docs/EInvoicing/V1/DataInputField.md)
 - [Model.EInvoicing.V1.DataInputFieldNotUsedFor](docs/EInvoicing/V1/DataInputFieldNotUsedFor.md)
 - [Model.EInvoicing.V1.DataInputFieldOptionalFor](docs/EInvoicing/V1/DataInputFieldOptionalFor.md)
 - [Model.EInvoicing.V1.DataInputFieldRequiredFor](docs/EInvoicing/V1/DataInputFieldRequiredFor.md)
 - [Model.EInvoicing.V1.DataInputFieldsResponse](docs/EInvoicing/V1/DataInputFieldsResponse.md)
 - [Model.EInvoicing.V1.DocumentListResponse](docs/EInvoicing/V1/DocumentListResponse.md)
 - [Model.EInvoicing.V1.DocumentStatusResponse](docs/EInvoicing/V1/DocumentStatusResponse.md)
 - [Model.EInvoicing.V1.DocumentSubmissionError](docs/EInvoicing/V1/DocumentSubmissionError.md)
 - [Model.EInvoicing.V1.DocumentSubmitResponse](docs/EInvoicing/V1/DocumentSubmitResponse.md)
 - [Model.EInvoicing.V1.DocumentSummary](docs/EInvoicing/V1/DocumentSummary.md)
 - [Model.EInvoicing.V1.ForbiddenError](docs/EInvoicing/V1/ForbiddenError.md)
 - [Model.EInvoicing.V1.InputDataFormats](docs/EInvoicing/V1/InputDataFormats.md)
 - [Model.EInvoicing.V1.InternalServerError](docs/EInvoicing/V1/InternalServerError.md)
 - [Model.EInvoicing.V1.Mandate](docs/EInvoicing/V1/Mandate.md)
 - [Model.EInvoicing.V1.MandatesResponse](docs/EInvoicing/V1/MandatesResponse.md)
 - [Model.EInvoicing.V1.NotFoundError](docs/EInvoicing/V1/NotFoundError.md)
 - [Model.EInvoicing.V1.NotUsedForField](docs/EInvoicing/V1/NotUsedForField.md)
 - [Model.EInvoicing.V1.RequiredWhenField](docs/EInvoicing/V1/RequiredWhenField.md)
 - [Model.EInvoicing.V1.StatusEvent](docs/EInvoicing/V1/StatusEvent.md)
 - [Model.EInvoicing.V1.SubmitDocumentData](docs/EInvoicing/V1/SubmitDocumentData.md)
 - [Model.EInvoicing.V1.SubmitDocumentMetadata](docs/EInvoicing/V1/SubmitDocumentMetadata.md)
 - [Model.EInvoicing.V1.WorkflowIds](docs/EInvoicing/V1/WorkflowIds.md)
