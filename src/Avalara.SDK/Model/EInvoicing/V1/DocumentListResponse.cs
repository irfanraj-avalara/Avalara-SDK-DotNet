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
    /// Returns the requested list of documents
    /// </summary>
    [DataContract]
    public partial class DocumentListResponse :  IEquatable<DocumentListResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentListResponse" /> class.
        /// </summary>
        /// <param name="recordSetCount">Count of collections for the given date range.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="value">Array of invoices matching query parameters (required).</param>
        public DocumentListResponse(string recordSetCount = default(string), string nextLink = default(string), List<DocumentSummary> value = default(List<DocumentSummary>))
        {
            this.NextLink = nextLink;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for DocumentListResponse and cannot be null");
            }
            else
            {
                this.Value = value;
            }

            this.RecordSetCount = recordSetCount;
            this.NextLink = nextLink;
        }

        /// <summary>
        /// Count of collections for the given date range
        /// </summary>
        /// <value>Count of collections for the given date range</value>
        [DataMember(Name="@recordSetCount", EmitDefaultValue=false)]
        public string RecordSetCount { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name="@nextLink", EmitDefaultValue=true)]
        public string NextLink { get; set; }

        /// <summary>
        /// Array of invoices matching query parameters
        /// </summary>
        /// <value>Array of invoices matching query parameters</value>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public List<DocumentSummary> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentListResponse {\n");
            sb.Append("  RecordSetCount: ").Append(RecordSetCount).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DocumentListResponse);
        }

        /// <summary>
        /// Returns true if DocumentListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordSetCount == input.RecordSetCount ||
                    (this.RecordSetCount != null &&
                    this.RecordSetCount.Equals(input.RecordSetCount))
                ) && 
                (
                    this.NextLink == input.NextLink ||
                    (this.NextLink != null &&
                    this.NextLink.Equals(input.NextLink))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.RecordSetCount != null)
                    hashCode = hashCode * 59 + this.RecordSetCount.GetHashCode();
                if (this.NextLink != null)
                    hashCode = hashCode * 59 + this.NextLink.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }

}
