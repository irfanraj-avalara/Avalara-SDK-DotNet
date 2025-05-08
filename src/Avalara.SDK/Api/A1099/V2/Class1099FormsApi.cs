/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 & W-9 API Definition
 *
 * ## 🔐 Authentication  Use **username/password** or generate a **license key** from: *Avalara Portal → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Avalara.SDK.Client;
using Avalara.SDK.Model.A1099.V2;

namespace Avalara.SDK.Api.A1099.V2
{
    /// <summary>
    /// Represents the Request object for the BulkUpsert1099Forms API
    /// </summary>
    public class BulkUpsert1099FormsRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BulkUpsert1099FormsRequest BulkUpsert1099FormsRequest { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Create1099Form API
    /// </summary>
    public class Create1099FormRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Update1099FormRequest Update1099FormRequest { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Delete1099Form API
    /// </summary>
    public class Delete1099FormRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Get1099Form API
    /// </summary>
    public class Get1099FormRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the List1099Forms API
    /// </summary>
    public class List1099FormsRequestSdk {
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// A filter statement to identify specific records to retrieve. For more information on filtering, see &lt;a href&#x3D;\&quot;https://developer.avalara.com/avatax/filtering-in-rest/\&quot;&gt;Filtering in REST&lt;/a&gt;.
        /// </summary>
        public string Filter { get; set; }
        /// <summary>
        /// If nonzero, return no more than this number of results. Used with skip to provide pagination for large datasets. Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records.
        /// </summary>
        public int? Top { get; set; }
        /// <summary>
        /// If nonzero, skip this number of results before returning data. Used with top to provide pagination for large datasets.
        /// </summary>
        public int? Skip { get; set; }
        /// <summary>
        /// A comma separated list of sort statements in the format (fieldname) [ASC|DESC], for example id ASC.
        /// </summary>
        public string OrderBy { get; set; }
        /// <summary>
        /// When true, returns a @recordSetCount in the result set
        /// </summary>
        public bool? Count { get; set; }
    }

    /// <summary>
    /// Represents the Request object for the Update1099Form API
    /// </summary>
    public class Update1099FormRequestSdk {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// API version
        /// </summary>
        public string? AvalaraVersion { get; set; } = "2.0";
        /// <summary>
        /// Unique correlation Id in a GUID format
        /// </summary>
        public string XCorrelationId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Update1099FormRequest Update1099FormRequest { get; set; }
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClass1099FormsApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create or update multiple 1099 forms.
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Misc\&quot;,     \&quot;form1099MiscCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-7890\&quot;,             \&quot;IssuerTin\&quot;: \&quot;98-7654321\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-001\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;123-45-6789\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Nec\&quot;,     \&quot;form1099NecCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;987654\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-4567\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-002\&quot;,             \&quot;RecipientName\&quot;: \&quot;Jane Smith\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;987-65-4321\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099CsvProccessResult</returns>
        Form1099CsvProccessResult BulkUpsert1099Forms(BulkUpsert1099FormsRequestSdk requestParameters);

        /// <summary>
        /// Create a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormCsvResponseBase</returns>
        FormCsvResponseBase Create1099Form(Create1099FormRequestSdk requestParameters);

        /// <summary>
        /// Delete a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        void Delete1099Form(Delete1099FormRequestSdk requestParameters);

        /// <summary>
        /// Retrieve a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormCsvResponseBase</returns>
        FormCsvResponseBase Get1099Form(Get1099FormRequestSdk requestParameters);

        /// <summary>
        /// Retrieve a list of 1099 forms based on query parameters.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>PaginatedFormCsvResponse</returns>
        PaginatedFormCsvResponse List1099Forms(List1099FormsRequestSdk requestParameters);

        /// <summary>
        /// Update a 1099 form.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormCsvResponseBase</returns>
        FormCsvResponseBase Update1099Form(Update1099FormRequestSdk requestParameters);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClass1099FormsApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create or update multiple 1099 forms.
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Misc\&quot;,     \&quot;form1099MiscCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-7890\&quot;,             \&quot;IssuerTin\&quot;: \&quot;98-7654321\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-001\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;123-45-6789\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Nec\&quot;,     \&quot;form1099NecCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;987654\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-4567\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-002\&quot;,             \&quot;RecipientName\&quot;: \&quot;Jane Smith\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;987-65-4321\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099CsvProccessResult</returns>
        System.Threading.Tasks.Task<Form1099CsvProccessResult> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormCsvResponseBase</returns>
        System.Threading.Tasks.Task<FormCsvResponseBase> Create1099FormAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormCsvResponseBase</returns>
        System.Threading.Tasks.Task<FormCsvResponseBase> Get1099FormAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a list of 1099 forms based on query parameters.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedFormCsvResponse</returns>
        System.Threading.Tasks.Task<PaginatedFormCsvResponse> List1099FormsAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update a 1099 form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormCsvResponseBase</returns>
        System.Threading.Tasks.Task<FormCsvResponseBase> Update1099FormAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Class1099FormsApi : IClass1099FormsApiSync, IClass1099FormsApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Class1099FormsApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public Class1099FormsApi(Avalara.SDK.Client.IApiClient client)
        {
             SetConfiguration(client);
             this.ExceptionFactory = Avalara.SDK.Client.Configuration.DefaultExceptionFactory;
        }       

        /// <summary>
        /// The client for accessing this underlying API.
        /// </summary>
        private Avalara.SDK.Client.IInternalApiClient Client { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        private Avalara.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create or update multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Misc\&quot;,     \&quot;form1099MiscCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-7890\&quot;,             \&quot;IssuerTin\&quot;: \&quot;98-7654321\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-001\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;123-45-6789\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Nec\&quot;,     \&quot;form1099NecCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;987654\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-4567\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-002\&quot;,             \&quot;RecipientName\&quot;: \&quot;Jane Smith\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;987-65-4321\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>Form1099CsvProccessResult</returns>
        public Form1099CsvProccessResult BulkUpsert1099Forms(BulkUpsert1099FormsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<Form1099CsvProccessResult> localVarResponse = BulkUpsert1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create or update multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Misc\&quot;,     \&quot;form1099MiscCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-7890\&quot;,             \&quot;IssuerTin\&quot;: \&quot;98-7654321\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-001\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;123-45-6789\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Nec\&quot;,     \&quot;form1099NecCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;987654\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-4567\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-002\&quot;,             \&quot;RecipientName\&quot;: \&quot;Jane Smith\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;987-65-4321\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Form1099CsvProccessResult</returns>
        private Avalara.SDK.Client.ApiResponse<Form1099CsvProccessResult> BulkUpsert1099FormsWithHttpInfo(BulkUpsert1099FormsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->BulkUpsert1099Forms");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->BulkUpsert1099Forms");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.BulkUpsert1099FormsRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Form1099CsvProccessResult>("/1099/forms/$bulk-upsert", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create or update multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Misc\&quot;,     \&quot;form1099MiscCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-7890\&quot;,             \&quot;IssuerTin\&quot;: \&quot;98-7654321\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-001\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;123-45-6789\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Nec\&quot;,     \&quot;form1099NecCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;987654\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-4567\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-002\&quot;,             \&quot;RecipientName\&quot;: \&quot;Jane Smith\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;987-65-4321\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Form1099CsvProccessResult</returns>
        public async System.Threading.Tasks.Task<Form1099CsvProccessResult> BulkUpsert1099FormsAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Form1099CsvProccessResult> localVarResponse = await BulkUpsert1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create or update multiple 1099 forms. This endpoint allows you to create or update multiple 1099 forms.  You can use one of the following payload structures:                **Form 1099-MISC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Misc\&quot;,     \&quot;form1099MiscCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;123456\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-7890\&quot;,             \&quot;IssuerTin\&quot;: \&quot;98-7654321\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-001\&quot;,             \&quot;RecipientName\&quot;: \&quot;John Doe\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;123-45-6789\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                **Form 1099-NEC:**  &#x60;&#x60;&#x60;json  {     \&quot;formType\&quot;: \&quot;Form1099Nec\&quot;,     \&quot;form1099NecCsvRequests\&quot;: [         {             \&quot;IssuerID\&quot;: \&quot;987654\&quot;,             \&quot;IssuerReferenceID\&quot;: \&quot;REF-4567\&quot;,             \&quot;IssuerTin\&quot;: \&quot;12-3456789\&quot;,             \&quot;TaxYear\&quot;: 2024,             \&quot;ReferenceID\&quot;: \&quot;REF-002\&quot;,             \&quot;RecipientName\&quot;: \&quot;Jane Smith\&quot;,             \&quot;RecipientFederalID\&quot;: \&quot;987-65-4321\&quot;,             ...         }     ]  }  &#x60;&#x60;&#x60;                For the full version of the payload and its schema details, refer to the Swagger schemas section.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Form1099CsvProccessResult)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Form1099CsvProccessResult>> BulkUpsert1099FormsWithHttpInfoAsync(BulkUpsert1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->BulkUpsert1099Forms");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->BulkUpsert1099Forms");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.BulkUpsert1099FormsRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Form1099CsvProccessResult>("/1099/forms/$bulk-upsert", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BulkUpsert1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormCsvResponseBase</returns>
        public FormCsvResponseBase Create1099Form(Create1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> localVarResponse = Create1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FormCsvResponseBase</returns>
        private Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> Create1099FormWithHttpInfo(Create1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Create1099Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Create1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.Update1099FormRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Post<FormCsvResponseBase>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormCsvResponseBase</returns>
        public async System.Threading.Tasks.Task<FormCsvResponseBase> Create1099FormAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> localVarResponse = await Create1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FormCsvResponseBase)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FormCsvResponseBase>> Create1099FormWithHttpInfoAsync(Create1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Create1099Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Create1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.Update1099FormRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<FormCsvResponseBase>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns></returns>
        public void Delete1099Form(Delete1099FormRequestSdk requestParameters)
        {
            Delete1099FormWithHttpInfo(requestParameters);
        }

        /// <summary>
        /// Delete a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> Delete1099FormWithHttpInfo(Delete1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Delete1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task Delete1099FormAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await Delete1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> Delete1099FormWithHttpInfoAsync(Delete1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Delete1099Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Delete1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormCsvResponseBase</returns>
        public FormCsvResponseBase Get1099Form(Get1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> localVarResponse = Get1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FormCsvResponseBase</returns>
        private Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> Get1099FormWithHttpInfo(Get1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Get1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
            var localVarResponse = this.Client.Get<FormCsvResponseBase>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormCsvResponseBase</returns>
        public async System.Threading.Tasks.Task<FormCsvResponseBase> Get1099FormAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> localVarResponse = await Get1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FormCsvResponseBase)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FormCsvResponseBase>> Get1099FormWithHttpInfoAsync(Get1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Get1099Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Get1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<FormCsvResponseBase>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>PaginatedFormCsvResponse</returns>
        public PaginatedFormCsvResponse List1099Forms(List1099FormsRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<PaginatedFormCsvResponse> localVarResponse = List1099FormsWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of PaginatedFormCsvResponse</returns>
        private Avalara.SDK.Client.ApiResponse<PaginatedFormCsvResponse> List1099FormsWithHttpInfo(List1099FormsRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->List1099Forms");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->List1099Forms");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.Filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "filter", requestParameters.Filter));
            }
            if (requestParameters.Top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "top", requestParameters.Top));
            }
            if (requestParameters.Skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "skip", requestParameters.Skip));
            }
            if (requestParameters.OrderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "orderBy", requestParameters.OrderBy));
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
            var localVarResponse = this.Client.Get<PaginatedFormCsvResponse>("/1099/forms", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedFormCsvResponse</returns>
        public async System.Threading.Tasks.Task<PaginatedFormCsvResponse> List1099FormsAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<PaginatedFormCsvResponse> localVarResponse = await List1099FormsWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of 1099 forms based on query parameters. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedFormCsvResponse)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<PaginatedFormCsvResponse>> List1099FormsWithHttpInfoAsync(List1099FormsRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->List1099Forms");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->List1099Forms");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestParameters.Filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "filter", requestParameters.Filter));
            }
            if (requestParameters.Top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "top", requestParameters.Top));
            }
            if (requestParameters.Skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "skip", requestParameters.Skip));
            }
            if (requestParameters.OrderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "orderBy", requestParameters.OrderBy));
            }
            if (requestParameters.Count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", requestParameters.Count));
            }
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<PaginatedFormCsvResponse>("/1099/forms", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("List1099Forms", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>FormCsvResponseBase</returns>
        public FormCsvResponseBase Update1099Form(Update1099FormRequestSdk requestParameters)
        {
            Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> localVarResponse = Update1099FormWithHttpInfo(requestParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <returns>ApiResponse of FormCsvResponseBase</returns>
        private Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> Update1099FormWithHttpInfo(Update1099FormRequestSdk requestParameters)
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Update1099Form");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.Update1099FormRequest;

            // make the HTTP request
            var localVarResponse = this.Client.Put<FormCsvResponseBase>("/1099/forms/{id}", localVarRequestOptions, requiredScopes, AvalaraMicroservice.A1099);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of FormCsvResponseBase</returns>
        public async System.Threading.Tasks.Task<FormCsvResponseBase> Update1099FormAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<FormCsvResponseBase> localVarResponse = await Update1099FormWithHttpInfoAsync(requestParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a 1099 form. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestParameters">Request Object for the API</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (FormCsvResponseBase)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<FormCsvResponseBase>> Update1099FormWithHttpInfoAsync(Update1099FormRequestSdk requestParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "";
            // verify the required parameter 'requestParameters.Id' is set
            if (requestParameters.Id == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.Id' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'requestParameters.AvalaraVersion' is set
            if (requestParameters.AvalaraVersion == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.AvalaraVersion' when calling Class1099FormsApi->Update1099Form");

            // verify the required parameter 'requestParameters.XCorrelationId' is set
            if (requestParameters.XCorrelationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'requestParameters.XCorrelationId' when calling Class1099FormsApi->Update1099Form");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.Id)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.AvalaraVersion)); // header parameter
            localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(requestParameters.XCorrelationId)); // header parameter
            localVarRequestOptions.Data = requestParameters.Update1099FormRequest;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<FormCsvResponseBase>("/1099/forms/{id}", localVarRequestOptions, cancellationToken, requiredScopes, AvalaraMicroservice.A1099).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Update1099Form", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the configuration object in APIClient
        /// </summary>        
        private void SetConfiguration(IApiClient client)
        {
            if (client == null) throw new ArgumentNullException("ApiClient");
            if (client.Configuration == null) throw new ArgumentNullException("ApiClient.Configuration");

            this.Client = (IInternalApiClient)client;
            this.Client.SdkVersion = "";
        }
        
    }

    
}
