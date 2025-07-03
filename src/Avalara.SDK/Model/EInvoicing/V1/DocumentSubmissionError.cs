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
    /// Returns an HTTP status code and message for an &#39;exception&#39;
    /// </summary>
    [DataContract(Name = "DocumentSubmissionError")]
    public partial class DocumentSubmissionError : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSubmissionError" /> class.
        /// </summary>
        /// <param name="statusCode">The three-digit HTTP status code for the exception.</param>
        /// <param name="message">A message explaining the exception.</param>
        public DocumentSubmissionError(string statusCode = default(string), string message = default(string))
        {
            this.StatusCode = statusCode;
            this.Message = message;
        }

        /// <summary>
        /// The three-digit HTTP status code for the exception
        /// </summary>
        /// <value>The three-digit HTTP status code for the exception</value>
        /// <example>400</example>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// A message explaining the exception
        /// </summary>
        /// <value>A message explaining the exception</value>
        /// <example>Failed to parse document</example>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentSubmissionError {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
