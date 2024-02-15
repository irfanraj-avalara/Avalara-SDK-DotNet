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
    /// Mandate list response schema
    /// </summary>
    [DataContract]
    public partial class MandatesResponse :  IEquatable<MandatesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatesResponse" /> class.
        /// </summary>
        /// <param name="recordSetCount">Total count of results.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="value">Mandates schema.</param>
        public MandatesResponse(decimal recordSetCount = default(decimal), string nextLink = default(string), List<Mandate> value = default(List<Mandate>))
        {
            this.NextLink = nextLink;
            this.RecordSetCount = recordSetCount;
            this.NextLink = nextLink;
            this.Value = value;
        }

        /// <summary>
        /// Total count of results
        /// </summary>
        /// <value>Total count of results</value>
        [DataMember(Name="@recordSetCount", EmitDefaultValue=false)]
        public decimal RecordSetCount { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name="@nextLink", EmitDefaultValue=true)]
        public string NextLink { get; set; }

        /// <summary>
        /// Mandates schema
        /// </summary>
        /// <value>Mandates schema</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<Mandate> Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MandatesResponse {\n");
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
            return this.Equals(input as MandatesResponse);
        }

        /// <summary>
        /// Returns true if MandatesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MandatesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MandatesResponse input)
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
