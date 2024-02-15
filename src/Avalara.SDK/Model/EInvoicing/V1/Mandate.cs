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
    /// Mandate
    /// </summary>
    [DataContract]
    public partial class Mandate :  IEquatable<Mandate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mandate" /> class.
        /// </summary>
        /// <param name="mandateId">Mandate UUID.</param>
        /// <param name="countryMandate">Country mandate name.</param>
        /// <param name="countryCode">Country code.</param>
        /// <param name="description">Mandate description.</param>
        /// <param name="supportedByPartnerAPI">Indicates whether this mandate supported by the partner API.</param>
        /// <param name="mandateFormat">Mandate format.</param>
        /// <param name="inputDataFormats">Format and version used when inputting the data.</param>
        /// <param name="workflowIds">Workflow ID list.</param>
        public Mandate(string mandateId = default(string), string countryMandate = default(string), string countryCode = default(string), string description = default(string), bool supportedByPartnerAPI = default(bool), string mandateFormat = default(string), List<InputDataFormats> inputDataFormats = default(List<InputDataFormats>), List<WorkflowIds> workflowIds = default(List<WorkflowIds>))
        {
            this.MandateId = mandateId;
            this.CountryMandate = countryMandate;
            this.CountryCode = countryCode;
            this.Description = description;
            this.SupportedByPartnerAPI = supportedByPartnerAPI;
            this.MandateFormat = mandateFormat;
            this.InputDataFormats = inputDataFormats;
            this.WorkflowIds = workflowIds;
        }

        /// <summary>
        /// Mandate UUID
        /// </summary>
        /// <value>Mandate UUID</value>
        [DataMember(Name="mandateId", EmitDefaultValue=false)]
        public string MandateId { get; set; }

        /// <summary>
        /// Country mandate name
        /// </summary>
        /// <value>Country mandate name</value>
        [DataMember(Name="countryMandate", EmitDefaultValue=false)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// Country code
        /// </summary>
        /// <value>Country code</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Mandate description
        /// </summary>
        /// <value>Mandate description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether this mandate supported by the partner API
        /// </summary>
        /// <value>Indicates whether this mandate supported by the partner API</value>
        [DataMember(Name="supportedByPartnerAPI", EmitDefaultValue=false)]
        public bool SupportedByPartnerAPI { get; set; }

        /// <summary>
        /// Mandate format
        /// </summary>
        /// <value>Mandate format</value>
        [DataMember(Name="mandateFormat", EmitDefaultValue=false)]
        public string MandateFormat { get; set; }

        /// <summary>
        /// Format and version used when inputting the data
        /// </summary>
        /// <value>Format and version used when inputting the data</value>
        [DataMember(Name="inputDataFormats", EmitDefaultValue=false)]
        public List<InputDataFormats> InputDataFormats { get; set; }

        /// <summary>
        /// Workflow ID list
        /// </summary>
        /// <value>Workflow ID list</value>
        [DataMember(Name="workflowIds", EmitDefaultValue=false)]
        public List<WorkflowIds> WorkflowIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Mandate {\n");
            sb.Append("  MandateId: ").Append(MandateId).Append("\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SupportedByPartnerAPI: ").Append(SupportedByPartnerAPI).Append("\n");
            sb.Append("  MandateFormat: ").Append(MandateFormat).Append("\n");
            sb.Append("  InputDataFormats: ").Append(InputDataFormats).Append("\n");
            sb.Append("  WorkflowIds: ").Append(WorkflowIds).Append("\n");
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
            return this.Equals(input as Mandate);
        }

        /// <summary>
        /// Returns true if Mandate instances are equal
        /// </summary>
        /// <param name="input">Instance of Mandate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mandate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MandateId == input.MandateId ||
                    (this.MandateId != null &&
                    this.MandateId.Equals(input.MandateId))
                ) && 
                (
                    this.CountryMandate == input.CountryMandate ||
                    (this.CountryMandate != null &&
                    this.CountryMandate.Equals(input.CountryMandate))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SupportedByPartnerAPI == input.SupportedByPartnerAPI ||
                    (this.SupportedByPartnerAPI != null &&
                    this.SupportedByPartnerAPI.Equals(input.SupportedByPartnerAPI))
                ) && 
                (
                    this.MandateFormat == input.MandateFormat ||
                    (this.MandateFormat != null &&
                    this.MandateFormat.Equals(input.MandateFormat))
                ) && 
                (
                    this.InputDataFormats == input.InputDataFormats ||
                    this.InputDataFormats != null &&
                    input.InputDataFormats != null &&
                    this.InputDataFormats.SequenceEqual(input.InputDataFormats)
                ) && 
                (
                    this.WorkflowIds == input.WorkflowIds ||
                    this.WorkflowIds != null &&
                    input.WorkflowIds != null &&
                    this.WorkflowIds.SequenceEqual(input.WorkflowIds)
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
                if (this.MandateId != null)
                    hashCode = hashCode * 59 + this.MandateId.GetHashCode();
                if (this.CountryMandate != null)
                    hashCode = hashCode * 59 + this.CountryMandate.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SupportedByPartnerAPI != null)
                    hashCode = hashCode * 59 + this.SupportedByPartnerAPI.GetHashCode();
                if (this.MandateFormat != null)
                    hashCode = hashCode * 59 + this.MandateFormat.GetHashCode();
                if (this.InputDataFormats != null)
                    hashCode = hashCode * 59 + this.InputDataFormats.GetHashCode();
                if (this.WorkflowIds != null)
                    hashCode = hashCode * 59 + this.WorkflowIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
