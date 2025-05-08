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
    /// StateAndLocalWithholdingDivRequest
    /// </summary>
    [DataContract(Name = "StateAndLocalWithholdingDivRequest")]
    public partial class StateAndLocalWithholdingDivRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateAndLocalWithholdingDivRequest" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="stateIdNumber">stateIdNumber.</param>
        /// <param name="stateTaxWithheld">stateTaxWithheld.</param>
        /// <param name="locality">locality.</param>
        /// <param name="localityIdNumber">localityIdNumber.</param>
        /// <param name="localityTaxWithheld">localityTaxWithheld.</param>
        public StateAndLocalWithholdingDivRequest(string state = default(string), string stateIdNumber = default(string), string stateTaxWithheld = default(string), string locality = default(string), string localityIdNumber = default(string), string localityTaxWithheld = default(string))
        {
            this.State = state;
            this.StateIdNumber = stateIdNumber;
            this.StateTaxWithheld = stateTaxWithheld;
            this.Locality = locality;
            this.LocalityIdNumber = localityIdNumber;
            this.LocalityTaxWithheld = localityTaxWithheld;
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateIdNumber
        /// </summary>
        [DataMember(Name = "stateIdNumber", EmitDefaultValue = true)]
        public string StateIdNumber { get; set; }

        /// <summary>
        /// Gets or Sets StateTaxWithheld
        /// </summary>
        [DataMember(Name = "stateTaxWithheld", EmitDefaultValue = true)]
        public string StateTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [DataMember(Name = "locality", EmitDefaultValue = true)]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or Sets LocalityIdNumber
        /// </summary>
        [DataMember(Name = "localityIdNumber", EmitDefaultValue = true)]
        public string LocalityIdNumber { get; set; }

        /// <summary>
        /// Gets or Sets LocalityTaxWithheld
        /// </summary>
        [DataMember(Name = "localityTaxWithheld", EmitDefaultValue = true)]
        public string LocalityTaxWithheld { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StateAndLocalWithholdingDivRequest {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateIdNumber: ").Append(StateIdNumber).Append("\n");
            sb.Append("  StateTaxWithheld: ").Append(StateTaxWithheld).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  LocalityIdNumber: ").Append(LocalityIdNumber).Append("\n");
            sb.Append("  LocalityTaxWithheld: ").Append(LocalityTaxWithheld).Append("\n");
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
