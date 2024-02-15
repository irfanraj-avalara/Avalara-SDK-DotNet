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
    /// Mandates for which this field is conditional
    /// </summary>
    [DataContract]
    public partial class ConditionalForField :  IEquatable<ConditionalForField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalForField" /> class.
        /// </summary>
        /// <param name="countryMandate">countryMandate.</param>
        /// <param name="requiredWhen">Array of scenarios which describe when a particular field is conditional for a country mandate.</param>
        public ConditionalForField(string countryMandate = default(string), List<RequiredWhenField> requiredWhen = default(List<RequiredWhenField>))
        {
            this.CountryMandate = countryMandate;
            this.RequiredWhen = requiredWhen;
        }

        /// <summary>
        /// Gets or Sets CountryMandate
        /// </summary>
        [DataMember(Name="countryMandate", EmitDefaultValue=false)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// Array of scenarios which describe when a particular field is conditional for a country mandate
        /// </summary>
        /// <value>Array of scenarios which describe when a particular field is conditional for a country mandate</value>
        [DataMember(Name="requiredWhen", EmitDefaultValue=false)]
        public List<RequiredWhenField> RequiredWhen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionalForField {\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
            sb.Append("  RequiredWhen: ").Append(RequiredWhen).Append("\n");
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
            return this.Equals(input as ConditionalForField);
        }

        /// <summary>
        /// Returns true if ConditionalForField instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionalForField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionalForField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryMandate == input.CountryMandate ||
                    (this.CountryMandate != null &&
                    this.CountryMandate.Equals(input.CountryMandate))
                ) && 
                (
                    this.RequiredWhen == input.RequiredWhen ||
                    this.RequiredWhen != null &&
                    input.RequiredWhen != null &&
                    this.RequiredWhen.SequenceEqual(input.RequiredWhen)
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
                if (this.CountryMandate != null)
                    hashCode = hashCode * 59 + this.CountryMandate.GetHashCode();
                if (this.RequiredWhen != null)
                    hashCode = hashCode * 59 + this.RequiredWhen.GetHashCode();
                return hashCode;
            }
        }
    }

}
