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
    /// SubmitInteropDocument202Response
    /// </summary>
    [DataContract(Name = "SubmitInteropDocument_202_response")]
    public partial class SubmitInteropDocument202Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitInteropDocument202Response" /> class.
        /// </summary>
        /// <param name="interchangeId">The unique interchange ID for this submission..</param>
        /// <param name="message">A message indicating that the document has been accepted..</param>
        public SubmitInteropDocument202Response(string interchangeId = default(string), string message = default(string))
        {
            this.InterchangeId = interchangeId;
            this.Message = message;
        }

        /// <summary>
        /// The unique interchange ID for this submission.
        /// </summary>
        /// <value>The unique interchange ID for this submission.</value>
        /// <example>1a70d108-d550-424f-b6c7-755f12d4daf4</example>
        [DataMember(Name = "interchangeId", EmitDefaultValue = false)]
        public string InterchangeId { get; set; }

        /// <summary>
        /// A message indicating that the document has been accepted.
        /// </summary>
        /// <value>A message indicating that the document has been accepted.</value>
        /// <example>Document accepted for processing.</example>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubmitInteropDocument202Response {\n");
            sb.Append("  InterchangeId: ").Append(InterchangeId).Append("\n");
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
