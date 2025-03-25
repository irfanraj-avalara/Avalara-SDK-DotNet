# Avalara.SDK - the Unified C# library for next gen Avalara services.

Unified SDK consists of services on top of which the Avalara Compliance Cloud platform is built. These services are foundational and provide functionality such as einvoicing.


<a name="frameworks-supported"></a>

## Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6

<a name="dependencies"></a>

## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [Polly](https://www.nuget.org/packages/Polly/) - 7.2.2 or later
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
using System;

using Avalara.SDK.Client;
using Avalara.SDK.Helpers;
using Avalara.SDK.Api.EInvoicing.V1;
using System.Threading.Tasks;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration configuration = new Configuration
            {
                Environment = AvalaraEnvironment.Sandbox,
                BearerToken = Environment.GetEnvironmentVariable("BEARER_TOKEN"), // Your Bearer token to connect to Avalara
                AppName = "Test",
                AppVersion = "1.0",
                MachineName = "LocalBox"
            };

            ApiClient apiClient = new ApiClient(configuration);

            var mandatesApi = new MandatesApi(apiClient);
            var requestParameters = new GetMandatesRequest();
            requestParameters.XAvalaraClient = "\"Swagger UI; 22.7.0; Custom; 1.0\"";  // string | Identifies the software you are using to call this API.  For more information on the client header, see [Client Headers](https://developer.avalara.com/avatax/client-headers/) . (optional)  (default to "Swagger UI; 22.7.0; Custom; 1.0")

            try
            {
                // Retrieve the list of Mandates
                var response = await mandatesApi.GetMandatesAsync(requestParameters);
                Debug.WriteLine(response);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressesApi.ResolveAddressPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
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
*DataInputFieldsApi* | [**GetDataInputFields**](docs/EInvoicing/V1/DataInputFieldsApi.md#getdatainputfields) | **GET** /data-input-fields | Returns the optionality of document fields for different country mandates
*DocumentsApi* | [**DownloadDocument**](docs/EInvoicing/V1/DocumentsApi.md#downloaddocument) | **GET** /documents/{documentId}/$download | Returns a copy of the document
*DocumentsApi* | [**FetchDocuments**](docs/EInvoicing/V1/DocumentsApi.md#fetchdocuments) | **POST** /documents/$fetch | Fetch the inbound document from a tax authority
*DocumentsApi* | [**GetDocumentList**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentlist) | **GET** /documents | Returns a summary of documents for a date range
*DocumentsApi* | [**GetDocumentStatus**](docs/EInvoicing/V1/DocumentsApi.md#getdocumentstatus) | **GET** /documents/{documentId}/status | Checks the status of a document
*DocumentsApi* | [**SubmitDocument**](docs/EInvoicing/V1/DocumentsApi.md#submitdocument) | **POST** /documents | Submits a document to Avalara E-Invoicing API
*InteropApi* | [**SubmitInteropDocument**](docs/EInvoicing/V1/InteropApi.md#submitinteropdocument) | **POST** /interop/documents | Submit a document
*MandatesApi* | [**GetMandateDataInputFields**](docs/EInvoicing/V1/MandatesApi.md#getmandatedatainputfields) | **GET** /mandates/{mandateId}/data-input-fields | Returns document field information for a country mandate, a selected document type, and its version
*MandatesApi* | [**GetMandates**](docs/EInvoicing/V1/MandatesApi.md#getmandates) | **GET** /mandates | List country mandates that are supported by the Avalara E-Invoicing platform
*TradingPartnersApi* | [**BatchSearchParticipants**](docs/EInvoicing/V1/TradingPartnersApi.md#batchsearchparticipants) | **POST** /trading-partners/batch-searches | Creates a batch search and performs a batch search in the directory for participants in the background.
*TradingPartnersApi* | [**DownloadBatchSearchReport**](docs/EInvoicing/V1/TradingPartnersApi.md#downloadbatchsearchreport) | **GET** /trading-partners/batch-searches/{id}/$download-results | Download batch search results in a csv file.
*TradingPartnersApi* | [**GetBatchSearchDetail**](docs/EInvoicing/V1/TradingPartnersApi.md#getbatchsearchdetail) | **GET** /trading-partners/batch-searches/{id} | Get the batch search details for a given id.
*TradingPartnersApi* | [**ListBatchSearches**](docs/EInvoicing/V1/TradingPartnersApi.md#listbatchsearches) | **GET** /trading-partners/batch-searches | List all batch searches that were previously submitted.
*TradingPartnersApi* | [**SearchParticipants**](docs/EInvoicing/V1/TradingPartnersApi.md#searchparticipants) | **GET** /trading-partners | Returns a list of participants matching the input query.

<a name="documentation-for-A1099-V2-api-endpoints"></a>
### A1099 V2 API Documentation

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizedAPIRequestsApi* | [**AuthorizedApiRequestsAuthorizedApiRequestIdExecuteGet**](docs/A1099/V2/AuthorizedAPIRequestsApi.md#authorizedapirequestsauthorizedapirequestidexecuteget) | **GET** /authorized-api-requests/{authorizedApiRequestId}/$execute | Execute URL for downloads
*AuthorizedAPIRequestsApi* | [**AuthorizedApiRequestsAuthorizedApiRequestIdGet**](docs/A1099/V2/AuthorizedAPIRequestsApi.md#authorizedapirequestsauthorizedapirequestidget) | **GET** /authorized-api-requests/{authorizedApiRequestId} | Retrieve URL for downloads
*AuthorizedAPIRequestsApi* | [**AuthorizedApiRequestsPost**](docs/A1099/V2/AuthorizedAPIRequestsApi.md#authorizedapirequestspost) | **POST** /authorized-api-requests | Create URL for downloads
*Class1099IssuersApi* | [**Call1099IssuersGet**](docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget) | **GET** /1099/issuers | List issuers
*Class1099IssuersApi* | [**Call1099IssuersIssuerIdDelete**](docs/A1099/V2/Class1099IssuersApi.md#call1099issuersissueriddelete) | **DELETE** /1099/issuers/{issuerId} | Delete an issuer
*Class1099IssuersApi* | [**Call1099IssuersIssuerIdGet**](docs/A1099/V2/Class1099IssuersApi.md#call1099issuersissueridget) | **GET** /1099/issuers/{issuerId} | Get a single issuer
*Class1099IssuersApi* | [**Call1099IssuersIssuerIdPut**](docs/A1099/V2/Class1099IssuersApi.md#call1099issuersissueridput) | **PUT** /1099/issuers/{issuerId} | Update an issuer
*Class1099IssuersApi* | [**Call1099IssuersPost**](docs/A1099/V2/Class1099IssuersApi.md#call1099issuerspost) | **POST** /1099/issuers | Create a new issuer
*FormRequestsApi* | [**FormRequestsFormRequestIdGet**](docs/A1099/V2/FormRequestsApi.md#formrequestsformrequestidget) | **GET** /form-requests/{formRequestId} | Get form request
*W4W8W9FormsApi* | [**W9FormsFormIdGet**](docs/A1099/V2/W4W8W9FormsApi.md#w9formsformidget) | **GET** /w9/forms/{formId} | Retrieve a W9/W8/W4 form
*W4W8W9FormsApi* | [**W9FormsGet**](docs/A1099/V2/W4W8W9FormsApi.md#w9formsget) | **GET** /w9/forms | List W9/W4/W8 forms.
*W4W8W9FormsApi* | [**W9FormsPost**](docs/A1099/V2/W4W8W9FormsApi.md#w9formspost) | **POST** /w9/forms | Create a new W9/W8/W4 form
*W9CompaniesApi* | [**W9CompaniesPost**](docs/A1099/V2/W9CompaniesApi.md#w9companiespost) | **POST** /w9/companies | Creates a new company

<a name="documentation-for-models"></a>
## Documentation for Models

<a name="documentation-for-EInvoicing-V1-models"></a>
### EInvoicing V1 Model Documentation

 - [Model.EInvoicing.V1.BadDownloadRequest](docs/EInvoicing/V1/BadDownloadRequest.md)
 - [Model.EInvoicing.V1.BadRequest](docs/EInvoicing/V1/BadRequest.md)
 - [Model.EInvoicing.V1.BatchSearch](docs/EInvoicing/V1/BatchSearch.md)
 - [Model.EInvoicing.V1.BatchSearchListResponse](docs/EInvoicing/V1/BatchSearchListResponse.md)
 - [Model.EInvoicing.V1.ConditionalForField](docs/EInvoicing/V1/ConditionalForField.md)
 - [Model.EInvoicing.V1.DataInputField](docs/EInvoicing/V1/DataInputField.md)
 - [Model.EInvoicing.V1.DataInputFieldNotUsedFor](docs/EInvoicing/V1/DataInputFieldNotUsedFor.md)
 - [Model.EInvoicing.V1.DataInputFieldOptionalFor](docs/EInvoicing/V1/DataInputFieldOptionalFor.md)
 - [Model.EInvoicing.V1.DataInputFieldRequiredFor](docs/EInvoicing/V1/DataInputFieldRequiredFor.md)
 - [Model.EInvoicing.V1.DataInputFieldsResponse](docs/EInvoicing/V1/DataInputFieldsResponse.md)
 - [Model.EInvoicing.V1.DirectorySearchResponse](docs/EInvoicing/V1/DirectorySearchResponse.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInner](docs/EInvoicing/V1/DirectorySearchResponseValueInner.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInnerAddressesInner](docs/EInvoicing/V1/DirectorySearchResponseValueInnerAddressesInner.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInnerIdentifiersInner](docs/EInvoicing/V1/DirectorySearchResponseValueInnerIdentifiersInner.md)
 - [Model.EInvoicing.V1.DirectorySearchResponseValueInnerSupportedDocumentTypesInner](docs/EInvoicing/V1/DirectorySearchResponseValueInnerSupportedDocumentTypesInner.md)
 - [Model.EInvoicing.V1.DocumentFetch](docs/EInvoicing/V1/DocumentFetch.md)
 - [Model.EInvoicing.V1.DocumentListResponse](docs/EInvoicing/V1/DocumentListResponse.md)
 - [Model.EInvoicing.V1.DocumentStatusResponse](docs/EInvoicing/V1/DocumentStatusResponse.md)
 - [Model.EInvoicing.V1.DocumentSubmissionError](docs/EInvoicing/V1/DocumentSubmissionError.md)
 - [Model.EInvoicing.V1.DocumentSubmitResponse](docs/EInvoicing/V1/DocumentSubmitResponse.md)
 - [Model.EInvoicing.V1.DocumentSummary](docs/EInvoicing/V1/DocumentSummary.md)
 - [Model.EInvoicing.V1.ErrorResponse](docs/EInvoicing/V1/ErrorResponse.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequest](docs/EInvoicing/V1/FetchDocumentsRequest.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequestDataInner](docs/EInvoicing/V1/FetchDocumentsRequestDataInner.md)
 - [Model.EInvoicing.V1.FetchDocumentsRequestMetadata](docs/EInvoicing/V1/FetchDocumentsRequestMetadata.md)
 - [Model.EInvoicing.V1.ForbiddenError](docs/EInvoicing/V1/ForbiddenError.md)
 - [Model.EInvoicing.V1.InputDataFormats](docs/EInvoicing/V1/InputDataFormats.md)
 - [Model.EInvoicing.V1.InternalServerError](docs/EInvoicing/V1/InternalServerError.md)
 - [Model.EInvoicing.V1.Mandate](docs/EInvoicing/V1/Mandate.md)
 - [Model.EInvoicing.V1.MandateDataInputField](docs/EInvoicing/V1/MandateDataInputField.md)
 - [Model.EInvoicing.V1.MandateDataInputFieldNamespace](docs/EInvoicing/V1/MandateDataInputFieldNamespace.md)
 - [Model.EInvoicing.V1.MandatesResponse](docs/EInvoicing/V1/MandatesResponse.md)
 - [Model.EInvoicing.V1.NotFoundError](docs/EInvoicing/V1/NotFoundError.md)
 - [Model.EInvoicing.V1.NotUsedForField](docs/EInvoicing/V1/NotUsedForField.md)
 - [Model.EInvoicing.V1.RequiredWhenField](docs/EInvoicing/V1/RequiredWhenField.md)
 - [Model.EInvoicing.V1.StatusEvent](docs/EInvoicing/V1/StatusEvent.md)
 - [Model.EInvoicing.V1.SubmitDocumentMetadata](docs/EInvoicing/V1/SubmitDocumentMetadata.md)
 - [Model.EInvoicing.V1.SubmitInteropDocument202Response](docs/EInvoicing/V1/SubmitInteropDocument202Response.md)
 - [Model.EInvoicing.V1.WorkflowIds](docs/EInvoicing/V1/WorkflowIds.md)


<a name="documentation-for-A1099-V2-models"></a>
### A1099 V2 Model Documentation

 - [Model.A1099.V2.AuthorizedApiRequestModel](docs/A1099/V2/AuthorizedApiRequestModel.md)
 - [Model.A1099.V2.AuthorizedApiRequestV2DataModel](docs/A1099/V2/AuthorizedApiRequestV2DataModel.md)
 - [Model.A1099.V2.BaseFormDataModel](docs/A1099/V2/BaseFormDataModel.md)
 - [Model.A1099.V2.CompanyModel](docs/A1099/V2/CompanyModel.md)
 - [Model.A1099.V2.ErrorModel](docs/A1099/V2/ErrorModel.md)
 - [Model.A1099.V2.FormDataModel](docs/A1099/V2/FormDataModel.md)
 - [Model.A1099.V2.FormRequestModel](docs/A1099/V2/FormRequestModel.md)
 - [Model.A1099.V2.HttpValidationProblemDetails](docs/A1099/V2/HttpValidationProblemDetails.md)
 - [Model.A1099.V2.IssuerModel](docs/A1099/V2/IssuerModel.md)
 - [Model.A1099.V2.IssuerModelPaginatedQueryResultModel](docs/A1099/V2/IssuerModelPaginatedQueryResultModel.md)
 - [Model.A1099.V2.Model1099IssuersIssuerIdGet400Response](docs/A1099/V2/Model1099IssuersIssuerIdGet400Response.md)
 - [Model.A1099.V2.PaginatedQueryResultModel1](docs/A1099/V2/PaginatedQueryResultModel1.md)
 - [Model.A1099.V2.PaginatedW9FormsModel](docs/A1099/V2/PaginatedW9FormsModel.md)
 - [Model.A1099.V2.ProblemDetails](docs/A1099/V2/ProblemDetails.md)
 - [Model.A1099.V2.W4FormDataModel](docs/A1099/V2/W4FormDataModel.md)
 - [Model.A1099.V2.W8BenFormDataModel](docs/A1099/V2/W8BenFormDataModel.md)
 - [Model.A1099.V2.W8BeneFormDataModel](docs/A1099/V2/W8BeneFormDataModel.md)
 - [Model.A1099.V2.W8ImyFormDataModel](docs/A1099/V2/W8ImyFormDataModel.md)
 - [Model.A1099.V2.W9FormDataModel](docs/A1099/V2/W9FormDataModel.md)
 - [Model.A1099.V2.W9FormsPostRequest](docs/A1099/V2/W9FormsPostRequest.md)
