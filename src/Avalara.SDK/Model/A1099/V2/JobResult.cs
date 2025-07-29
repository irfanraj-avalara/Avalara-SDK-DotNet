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
 * ## 🔐 Authentication  Generate a **license key** from: *[Avalara Portal](https://www.avalara.com/us/en/signin.html) → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;

namespace Avalara.SDK.Model.A1099.V2
{
/// <summary>
    /// JobResult
    /// </summary>
    [DataContract(Name = "JobResult")]
    public partial class JobResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobResult" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="dryRun">Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them..</param>
        /// <param name="upsert">Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order:  * Form ID  * Form Reference ID and tax year  * Form TIN and tax year.</param>
        /// <param name="status">Status of the job.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="totalProcessed">Total number of forms processed.</param>
        /// <param name="totalRows">Total number of forms in the request.</param>
        /// <param name="updatedValid">Number of forms updated and valid for e-filing and e-delivery.</param>
        /// <param name="updatedNoEmail">Number of forms updated and valid for e-filing but missing email or email is undeliverable.</param>
        /// <param name="updatedInvalid">Number of forms updated but invalid for e-filing.</param>
        /// <param name="skippedDuplicate">Number of forms skipped because they would have updated a record already updated once in the request.</param>
        /// <param name="skippedInvalid">Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing.</param>
        /// <param name="skippedMultipleMatches">Number of forms skipped because they matched multiple forms.</param>
        /// <param name="notFound">Number of forms skipped because no matching form or issuer could be found.</param>
        /// <param name="createdInvalid">Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors.</param>
        /// <param name="createdNoEmail">Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable.</param>
        /// <param name="createdValid">Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery.</param>
        public JobResult(string id = default(string), string type = default(string), bool dryRun = default(bool), bool upsert = default(bool), string status = default(string), string errorMessage = default(string), int totalProcessed = default(int), int totalRows = default(int), int updatedValid = default(int), int updatedNoEmail = default(int), int updatedInvalid = default(int), int skippedDuplicate = default(int), int skippedInvalid = default(int), int skippedMultipleMatches = default(int), int notFound = default(int), int createdInvalid = default(int), int createdNoEmail = default(int), int createdValid = default(int))
        {
            this.Id = id;
            this.Type = type;
            this.DryRun = dryRun;
            this.Upsert = upsert;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.TotalProcessed = totalProcessed;
            this.TotalRows = totalRows;
            this.UpdatedValid = updatedValid;
            this.UpdatedNoEmail = updatedNoEmail;
            this.UpdatedInvalid = updatedInvalid;
            this.SkippedDuplicate = skippedDuplicate;
            this.SkippedInvalid = skippedInvalid;
            this.SkippedMultipleMatches = skippedMultipleMatches;
            this.NotFound = notFound;
            this.CreatedInvalid = createdInvalid;
            this.CreatedNoEmail = createdNoEmail;
            this.CreatedValid = createdValid;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them.
        /// </summary>
        /// <value>Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them.</value>
        [DataMember(Name = "dryRun", EmitDefaultValue = true)]
        public bool DryRun { get; set; }

        /// <summary>
        /// Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order:  * Form ID  * Form Reference ID and tax year  * Form TIN and tax year
        /// </summary>
        /// <value>Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order:  * Form ID  * Form Reference ID and tax year  * Form TIN and tax year</value>
        [DataMember(Name = "upsert", EmitDefaultValue = true)]
        public bool Upsert { get; set; }

        /// <summary>
        /// Status of the job
        /// </summary>
        /// <value>Status of the job</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Total number of forms processed
        /// </summary>
        /// <value>Total number of forms processed</value>
        [DataMember(Name = "totalProcessed", EmitDefaultValue = false)]
        public int TotalProcessed { get; set; }

        /// <summary>
        /// Total number of forms in the request
        /// </summary>
        /// <value>Total number of forms in the request</value>
        [DataMember(Name = "totalRows", EmitDefaultValue = false)]
        public int TotalRows { get; set; }

        /// <summary>
        /// Number of forms updated and valid for e-filing and e-delivery
        /// </summary>
        /// <value>Number of forms updated and valid for e-filing and e-delivery</value>
        [DataMember(Name = "updatedValid", EmitDefaultValue = false)]
        public int UpdatedValid { get; set; }

        /// <summary>
        /// Number of forms updated and valid for e-filing but missing email or email is undeliverable
        /// </summary>
        /// <value>Number of forms updated and valid for e-filing but missing email or email is undeliverable</value>
        [DataMember(Name = "updatedNoEmail", EmitDefaultValue = false)]
        public int UpdatedNoEmail { get; set; }

        /// <summary>
        /// Number of forms updated but invalid for e-filing
        /// </summary>
        /// <value>Number of forms updated but invalid for e-filing</value>
        [DataMember(Name = "updatedInvalid", EmitDefaultValue = false)]
        public int UpdatedInvalid { get; set; }

        /// <summary>
        /// Number of forms skipped because they would have updated a record already updated once in the request
        /// </summary>
        /// <value>Number of forms skipped because they would have updated a record already updated once in the request</value>
        [DataMember(Name = "skippedDuplicate", EmitDefaultValue = false)]
        public int SkippedDuplicate { get; set; }

        /// <summary>
        /// Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing
        /// </summary>
        /// <value>Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing</value>
        [DataMember(Name = "skippedInvalid", EmitDefaultValue = false)]
        public int SkippedInvalid { get; set; }

        /// <summary>
        /// Number of forms skipped because they matched multiple forms
        /// </summary>
        /// <value>Number of forms skipped because they matched multiple forms</value>
        [DataMember(Name = "skippedMultipleMatches", EmitDefaultValue = false)]
        public int SkippedMultipleMatches { get; set; }

        /// <summary>
        /// Number of forms skipped because no matching form or issuer could be found
        /// </summary>
        /// <value>Number of forms skipped because no matching form or issuer could be found</value>
        [DataMember(Name = "notFound", EmitDefaultValue = false)]
        public int NotFound { get; set; }

        /// <summary>
        /// Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors
        /// </summary>
        /// <value>Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors</value>
        [DataMember(Name = "createdInvalid", EmitDefaultValue = false)]
        public int CreatedInvalid { get; set; }

        /// <summary>
        /// Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable
        /// </summary>
        /// <value>Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable</value>
        [DataMember(Name = "createdNoEmail", EmitDefaultValue = false)]
        public int CreatedNoEmail { get; set; }

        /// <summary>
        /// Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery
        /// </summary>
        /// <value>Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery</value>
        [DataMember(Name = "createdValid", EmitDefaultValue = false)]
        public int CreatedValid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DryRun: ").Append(DryRun).Append("\n");
            sb.Append("  Upsert: ").Append(Upsert).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  TotalProcessed: ").Append(TotalProcessed).Append("\n");
            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  UpdatedValid: ").Append(UpdatedValid).Append("\n");
            sb.Append("  UpdatedNoEmail: ").Append(UpdatedNoEmail).Append("\n");
            sb.Append("  UpdatedInvalid: ").Append(UpdatedInvalid).Append("\n");
            sb.Append("  SkippedDuplicate: ").Append(SkippedDuplicate).Append("\n");
            sb.Append("  SkippedInvalid: ").Append(SkippedInvalid).Append("\n");
            sb.Append("  SkippedMultipleMatches: ").Append(SkippedMultipleMatches).Append("\n");
            sb.Append("  NotFound: ").Append(NotFound).Append("\n");
            sb.Append("  CreatedInvalid: ").Append(CreatedInvalid).Append("\n");
            sb.Append("  CreatedNoEmail: ").Append(CreatedNoEmail).Append("\n");
            sb.Append("  CreatedValid: ").Append(CreatedValid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
