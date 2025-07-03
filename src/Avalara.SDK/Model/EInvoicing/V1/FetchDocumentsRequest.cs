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
    /// FetchDocumentsRequest
    /// </summary>
    [DataContract(Name = "FetchDocuments_request")]
    public partial class FetchDocumentsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchDocumentsRequest" /> class.
        /// </summary>
        /// <param name="data">Array of key-value pairs used to retrieve inbound documents from the Tax Authority.</param>
        /// <param name="metadata">metadata.</param>
        public FetchDocumentsRequest(List<FetchDocumentsRequestDataInner> data = default(List<FetchDocumentsRequestDataInner>), FetchDocumentsRequestMetadata metadata = default(FetchDocumentsRequestMetadata))
        {
            this.Data = data;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Array of key-value pairs used to retrieve inbound documents from the Tax Authority
        /// </summary>
        /// <value>Array of key-value pairs used to retrieve inbound documents from the Tax Authority</value>
        /// <example>[{&quot;key&quot;:&quot;Confirmation_Number&quot;,&quot;value&quot;:&quot;987654321&quot;},{&quot;key&quot;:&quot;Customer_VAT_Number&quot;,&quot;value&quot;:&quot;777777715&quot;}]</example>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<FetchDocumentsRequestDataInner> Data { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public FetchDocumentsRequestMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FetchDocumentsRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
