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
    /// Form1099TypeNec
    /// </summary>
    [DataContract(Name = "Form1099TypeNec")]
    public partial class Form1099TypeNec : IValidatableObject
    {
        /// <summary>
        /// Defines FormType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormTypeEnum
        {
            /// <summary>
            /// Enum Form1099Nec for value: Form1099Nec
            /// </summary>
            [EnumMember(Value = "Form1099Nec")]
            Form1099Nec = 1,

            /// <summary>
            /// Enum Form1099Misc for value: Form1099Misc
            /// </summary>
            [EnumMember(Value = "Form1099Misc")]
            Form1099Misc = 2,

            /// <summary>
            /// Enum Form1099Div for value: Form1099Div
            /// </summary>
            [EnumMember(Value = "Form1099Div")]
            Form1099Div = 3
        }


        /// <summary>
        /// Gets or Sets FormType
        /// </summary>
        /// <example>Form1099Nec</example>
        [DataMember(Name = "formType", EmitDefaultValue = false)]
        public FormTypeEnum? FormType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099TypeNec" /> class.
        /// </summary>
        /// <param name="form1099NecCsvRequests">form1099NecCsvRequests.</param>
        /// <param name="formType">formType.</param>
        public Form1099TypeNec(List<Form1099NecCsvRequest> form1099NecCsvRequests = default(List<Form1099NecCsvRequest>), FormTypeEnum? formType = default(FormTypeEnum?))
        {
            this.Form1099NecCsvRequests = form1099NecCsvRequests;
            this.FormType = formType;
        }

        /// <summary>
        /// Gets or Sets Form1099NecCsvRequests
        /// </summary>
        [DataMember(Name = "form1099NecCsvRequests", EmitDefaultValue = true)]
        public List<Form1099NecCsvRequest> Form1099NecCsvRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099TypeNec {\n");
            sb.Append("  Form1099NecCsvRequests: ").Append(Form1099NecCsvRequests).Append("\n");
            sb.Append("  FormType: ").Append(FormType).Append("\n");
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
