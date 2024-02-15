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
    /// Mandates for which this field is not used
    /// </summary>
    [DataContract]
    public partial class NotUsedForField :  IEquatable<NotUsedForField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotUsedForField" /> class.
        /// </summary>
        /// <param name="countryMandate">countryMandate.</param>
        public NotUsedForField(string countryMandate = default(string))
        {
            this.CountryMandate = countryMandate;
        }

        /// <summary>
        /// Gets or Sets CountryMandate
        /// </summary>
        [DataMember(Name="countryMandate", EmitDefaultValue=false)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotUsedForField {\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
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
            return this.Equals(input as NotUsedForField);
        }

        /// <summary>
        /// Returns true if NotUsedForField instances are equal
        /// </summary>
        /// <param name="input">Instance of NotUsedForField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotUsedForField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryMandate == input.CountryMandate ||
                    (this.CountryMandate != null &&
                    this.CountryMandate.Equals(input.CountryMandate))
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
                return hashCode;
            }
        }
    }

}
