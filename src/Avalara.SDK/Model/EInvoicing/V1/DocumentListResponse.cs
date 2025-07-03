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
    [DataContract(Name = "DocumentListResponse")]
    public partial class DocumentListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentListResponse" /> class.
        /// </summary>
        /// <param name="recordsetCount">Count of collections for the given date range.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="value">Array of documents matching query parameters (required).</param>
        public DocumentListResponse(string recordsetCount = default(string), string nextLink = default(string), List<DocumentSummary> value = default(List<DocumentSummary>))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for DocumentListResponse and cannot be null");
            }
            this.Value = value;
            this.RecordsetCount = recordsetCount;
            this.NextLink = nextLink;
        }

        /// <summary>
        /// Count of collections for the given date range
        /// </summary>
        /// <value>Count of collections for the given date range</value>
        /// <example>1</example>
        [DataMember(Name = "@recordsetCount", EmitDefaultValue = false)]
        public string RecordsetCount { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name = "@nextLink", EmitDefaultValue = true)]
        public string NextLink { get; set; }

        /// <summary>
        /// Array of documents matching query parameters
        /// </summary>
        /// <value>Array of documents matching query parameters</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public List<DocumentSummary> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentListResponse {\n");
            sb.Append("  RecordsetCount: ").Append(RecordsetCount).Append("\n");
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
