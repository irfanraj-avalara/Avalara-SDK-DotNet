/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara E-Invoicing API
 *
 * An API that supports sending data for an E-Invoicing compliance use-case.
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

namespace Avalara.SDK.Model.EInvoicing.V1
{
    /// <summary>
    /// Key value pairs of metadata for a document submission. dataFormat can be ubl-invoice or ubl-creditnote:  &lt;br&gt;&lt;pre&gt;{  \&quot;workflowId\&quot;: \&quot;partner-einvoicing\&quot;, \&quot;dataFormat\&quot;: \&quot;ubl-invoice\&quot;, \&quot;dataFormatVersion\&quot;: \&quot;2.1\&quot;, \&quot;countryCode\&quot;: \&quot;SA\&quot;, \&quot;countryMandate\&quot;: \&quot;SA-Phase1-B2B\&quot; }&lt;/pre&gt; &lt;br&gt; 
    /// </summary>
    [DataContract]
    public partial class SubmitDocumentMetadata :  IEquatable<SubmitDocumentMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitDocumentMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubmitDocumentMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitDocumentMetadata" /> class.
        /// </summary>
        /// <param name="workflowId">Specifies a unique ID for this workflow. (required).</param>
        /// <param name="dataFormat">Specifies the data format for this workflow. (required).</param>
        /// <param name="dataFormatVersion">Specifies the data format version number. (required).</param>
        /// <param name="countryCode">The two-letter ISO-3166 country code for the country where the e-invoice is being submitted (required).</param>
        /// <param name="countryMandate">The e-invoicing mandate for the specified country. (required).</param>
        public SubmitDocumentMetadata(string workflowId = default(string), string dataFormat = default(string), string dataFormatVersion = default(string), string countryCode = default(string), string countryMandate = default(string))
        {
            // to ensure "workflowId" is required (not null)
            if (workflowId == null)
            {
                throw new InvalidDataException("workflowId is a required property for SubmitDocumentMetadata and cannot be null");
            }
            else
            {
                this.WorkflowId = workflowId;
            }

            // to ensure "dataFormat" is required (not null)
            if (dataFormat == null)
            {
                throw new InvalidDataException("dataFormat is a required property for SubmitDocumentMetadata and cannot be null");
            }
            else
            {
                this.DataFormat = dataFormat;
            }

            // to ensure "dataFormatVersion" is required (not null)
            if (dataFormatVersion == null)
            {
                throw new InvalidDataException("dataFormatVersion is a required property for SubmitDocumentMetadata and cannot be null");
            }
            else
            {
                this.DataFormatVersion = dataFormatVersion;
            }

            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new InvalidDataException("countryCode is a required property for SubmitDocumentMetadata and cannot be null");
            }
            else
            {
                this.CountryCode = countryCode;
            }

            // to ensure "countryMandate" is required (not null)
            if (countryMandate == null)
            {
                throw new InvalidDataException("countryMandate is a required property for SubmitDocumentMetadata and cannot be null");
            }
            else
            {
                this.CountryMandate = countryMandate;
            }

        }

        /// <summary>
        /// Specifies a unique ID for this workflow.
        /// </summary>
        /// <value>Specifies a unique ID for this workflow.</value>
        [DataMember(Name="workflowId", EmitDefaultValue=true)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Specifies the data format for this workflow.
        /// </summary>
        /// <value>Specifies the data format for this workflow.</value>
        [DataMember(Name="dataFormat", EmitDefaultValue=true)]
        public string DataFormat { get; set; }

        /// <summary>
        /// Specifies the data format version number.
        /// </summary>
        /// <value>Specifies the data format version number.</value>
        [DataMember(Name="dataFormatVersion", EmitDefaultValue=true)]
        public string DataFormatVersion { get; set; }

        /// <summary>
        /// The two-letter ISO-3166 country code for the country where the e-invoice is being submitted
        /// </summary>
        /// <value>The two-letter ISO-3166 country code for the country where the e-invoice is being submitted</value>
        [DataMember(Name="countryCode", EmitDefaultValue=true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The e-invoicing mandate for the specified country.
        /// </summary>
        /// <value>The e-invoicing mandate for the specified country.</value>
        [DataMember(Name="countryMandate", EmitDefaultValue=true)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmitDocumentMetadata {\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  DataFormat: ").Append(DataFormat).Append("\n");
            sb.Append("  DataFormatVersion: ").Append(DataFormatVersion).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubmitDocumentMetadata);
        }

        /// <summary>
        /// Returns true if SubmitDocumentMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitDocumentMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitDocumentMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.DataFormat == input.DataFormat ||
                    (this.DataFormat != null &&
                    this.DataFormat.Equals(input.DataFormat))
                ) && 
                (
                    this.DataFormatVersion == input.DataFormatVersion ||
                    (this.DataFormatVersion != null &&
                    this.DataFormatVersion.Equals(input.DataFormatVersion))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CountryMandate == input.CountryMandate ||
                    (this.CountryMandate != null &&
                    this.CountryMandate.Equals(input.CountryMandate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.DataFormat != null)
                    hashCode = hashCode * 59 + this.DataFormat.GetHashCode();
                if (this.DataFormatVersion != null)
                    hashCode = hashCode * 59 + this.DataFormatVersion.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CountryMandate != null)
                    hashCode = hashCode * 59 + this.CountryMandate.GetHashCode();
                return hashCode;
            }
        }
    }

}
