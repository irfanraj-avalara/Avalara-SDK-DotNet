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
    /// CoveredIndividualReferenceResponse
    /// </summary>
    [DataContract(Name = "CoveredIndividualReferenceResponse")]
    public partial class CoveredIndividualReferenceResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoveredIndividualReferenceResponse" /> class.
        /// </summary>
        /// <param name="id">Covered individual ID.</param>
        /// <param name="firstName">Covered individual&#39;s first name.</param>
        /// <param name="middleName">Covered individual&#39;s middle name.</param>
        /// <param name="lastName">Covered individual&#39;s last name.</param>
        /// <param name="nameSuffix">Covered individual&#39;s name suffix.</param>
        /// <param name="tin">Covered individual&#39;s TIN (SSN or ITIN).</param>
        /// <param name="birthDate">Covered individual&#39;s date of birth.</param>
        /// <param name="coveredMonth0">Coverage indicator for all 12 months.</param>
        /// <param name="coveredMonth1">Coverage indicator for January.</param>
        /// <param name="coveredMonth2">Coverage indicator for February.</param>
        /// <param name="coveredMonth3">Coverage indicator for March.</param>
        /// <param name="coveredMonth4">Coverage indicator for April.</param>
        /// <param name="coveredMonth5">Coverage indicator for May.</param>
        /// <param name="coveredMonth6">Coverage indicator for June.</param>
        /// <param name="coveredMonth7">Coverage indicator for July.</param>
        /// <param name="coveredMonth8">Coverage indicator for August.</param>
        /// <param name="coveredMonth9">Coverage indicator for September.</param>
        /// <param name="coveredMonth10">Coverage indicator for October.</param>
        /// <param name="coveredMonth11">Coverage indicator for November.</param>
        /// <param name="coveredMonth12">Coverage indicator for December.</param>
        public CoveredIndividualReferenceResponse(string id = default(string), string firstName = default(string), string middleName = default(string), string lastName = default(string), string nameSuffix = default(string), string tin = default(string), DateTime? birthDate = default(DateTime?), bool coveredMonth0 = default(bool), bool coveredMonth1 = default(bool), bool coveredMonth2 = default(bool), bool coveredMonth3 = default(bool), bool coveredMonth4 = default(bool), bool coveredMonth5 = default(bool), bool coveredMonth6 = default(bool), bool coveredMonth7 = default(bool), bool coveredMonth8 = default(bool), bool coveredMonth9 = default(bool), bool coveredMonth10 = default(bool), bool coveredMonth11 = default(bool), bool coveredMonth12 = default(bool))
        {
            this.Id = id;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.NameSuffix = nameSuffix;
            this.Tin = tin;
            this.BirthDate = birthDate;
            this.CoveredMonth0 = coveredMonth0;
            this.CoveredMonth1 = coveredMonth1;
            this.CoveredMonth2 = coveredMonth2;
            this.CoveredMonth3 = coveredMonth3;
            this.CoveredMonth4 = coveredMonth4;
            this.CoveredMonth5 = coveredMonth5;
            this.CoveredMonth6 = coveredMonth6;
            this.CoveredMonth7 = coveredMonth7;
            this.CoveredMonth8 = coveredMonth8;
            this.CoveredMonth9 = coveredMonth9;
            this.CoveredMonth10 = coveredMonth10;
            this.CoveredMonth11 = coveredMonth11;
            this.CoveredMonth12 = coveredMonth12;
        }

        /// <summary>
        /// Covered individual ID
        /// </summary>
        /// <value>Covered individual ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Covered individual&#39;s first name
        /// </summary>
        /// <value>Covered individual&#39;s first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Covered individual&#39;s middle name
        /// </summary>
        /// <value>Covered individual&#39;s middle name</value>
        [DataMember(Name = "middleName", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Covered individual&#39;s last name
        /// </summary>
        /// <value>Covered individual&#39;s last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Covered individual&#39;s name suffix
        /// </summary>
        /// <value>Covered individual&#39;s name suffix</value>
        [DataMember(Name = "nameSuffix", EmitDefaultValue = true)]
        public string NameSuffix { get; set; }

        /// <summary>
        /// Covered individual&#39;s TIN (SSN or ITIN)
        /// </summary>
        /// <value>Covered individual&#39;s TIN (SSN or ITIN)</value>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// Covered individual&#39;s date of birth
        /// </summary>
        /// <value>Covered individual&#39;s date of birth</value>
        [DataMember(Name = "birthDate", EmitDefaultValue = true)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Coverage indicator for all 12 months
        /// </summary>
        /// <value>Coverage indicator for all 12 months</value>
        [DataMember(Name = "coveredMonth0", EmitDefaultValue = true)]
        public bool CoveredMonth0 { get; set; }

        /// <summary>
        /// Coverage indicator for January
        /// </summary>
        /// <value>Coverage indicator for January</value>
        [DataMember(Name = "coveredMonth1", EmitDefaultValue = true)]
        public bool CoveredMonth1 { get; set; }

        /// <summary>
        /// Coverage indicator for February
        /// </summary>
        /// <value>Coverage indicator for February</value>
        [DataMember(Name = "coveredMonth2", EmitDefaultValue = true)]
        public bool CoveredMonth2 { get; set; }

        /// <summary>
        /// Coverage indicator for March
        /// </summary>
        /// <value>Coverage indicator for March</value>
        [DataMember(Name = "coveredMonth3", EmitDefaultValue = true)]
        public bool CoveredMonth3 { get; set; }

        /// <summary>
        /// Coverage indicator for April
        /// </summary>
        /// <value>Coverage indicator for April</value>
        [DataMember(Name = "coveredMonth4", EmitDefaultValue = true)]
        public bool CoveredMonth4 { get; set; }

        /// <summary>
        /// Coverage indicator for May
        /// </summary>
        /// <value>Coverage indicator for May</value>
        [DataMember(Name = "coveredMonth5", EmitDefaultValue = true)]
        public bool CoveredMonth5 { get; set; }

        /// <summary>
        /// Coverage indicator for June
        /// </summary>
        /// <value>Coverage indicator for June</value>
        [DataMember(Name = "coveredMonth6", EmitDefaultValue = true)]
        public bool CoveredMonth6 { get; set; }

        /// <summary>
        /// Coverage indicator for July
        /// </summary>
        /// <value>Coverage indicator for July</value>
        [DataMember(Name = "coveredMonth7", EmitDefaultValue = true)]
        public bool CoveredMonth7 { get; set; }

        /// <summary>
        /// Coverage indicator for August
        /// </summary>
        /// <value>Coverage indicator for August</value>
        [DataMember(Name = "coveredMonth8", EmitDefaultValue = true)]
        public bool CoveredMonth8 { get; set; }

        /// <summary>
        /// Coverage indicator for September
        /// </summary>
        /// <value>Coverage indicator for September</value>
        [DataMember(Name = "coveredMonth9", EmitDefaultValue = true)]
        public bool CoveredMonth9 { get; set; }

        /// <summary>
        /// Coverage indicator for October
        /// </summary>
        /// <value>Coverage indicator for October</value>
        [DataMember(Name = "coveredMonth10", EmitDefaultValue = true)]
        public bool CoveredMonth10 { get; set; }

        /// <summary>
        /// Coverage indicator for November
        /// </summary>
        /// <value>Coverage indicator for November</value>
        [DataMember(Name = "coveredMonth11", EmitDefaultValue = true)]
        public bool CoveredMonth11 { get; set; }

        /// <summary>
        /// Coverage indicator for December
        /// </summary>
        /// <value>Coverage indicator for December</value>
        [DataMember(Name = "coveredMonth12", EmitDefaultValue = true)]
        public bool CoveredMonth12 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CoveredIndividualReferenceResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NameSuffix: ").Append(NameSuffix).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  CoveredMonth0: ").Append(CoveredMonth0).Append("\n");
            sb.Append("  CoveredMonth1: ").Append(CoveredMonth1).Append("\n");
            sb.Append("  CoveredMonth2: ").Append(CoveredMonth2).Append("\n");
            sb.Append("  CoveredMonth3: ").Append(CoveredMonth3).Append("\n");
            sb.Append("  CoveredMonth4: ").Append(CoveredMonth4).Append("\n");
            sb.Append("  CoveredMonth5: ").Append(CoveredMonth5).Append("\n");
            sb.Append("  CoveredMonth6: ").Append(CoveredMonth6).Append("\n");
            sb.Append("  CoveredMonth7: ").Append(CoveredMonth7).Append("\n");
            sb.Append("  CoveredMonth8: ").Append(CoveredMonth8).Append("\n");
            sb.Append("  CoveredMonth9: ").Append(CoveredMonth9).Append("\n");
            sb.Append("  CoveredMonth10: ").Append(CoveredMonth10).Append("\n");
            sb.Append("  CoveredMonth11: ").Append(CoveredMonth11).Append("\n");
            sb.Append("  CoveredMonth12: ").Append(CoveredMonth12).Append("\n");
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
