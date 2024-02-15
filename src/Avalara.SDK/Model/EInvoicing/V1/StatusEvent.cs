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
    /// Displays when a status event occurred
    /// </summary>
    [DataContract]
    public partial class StatusEvent :  IEquatable<StatusEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusEvent" /> class.
        /// </summary>
        /// <param name="eventDateTime">The date and time when the status event occured, displayed in the format YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="message">A message describing the status event.</param>
        public StatusEvent(string eventDateTime = default(string), string message = default(string))
        {
            this.EventDateTime = eventDateTime;
            this.Message = message;
        }

        /// <summary>
        /// The date and time when the status event occured, displayed in the format YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The date and time when the status event occured, displayed in the format YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="eventDateTime", EmitDefaultValue=false)]
        public string EventDateTime { get; set; }

        /// <summary>
        /// A message describing the status event
        /// </summary>
        /// <value>A message describing the status event</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusEvent {\n");
            sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatusEvent);
        }

        /// <summary>
        /// Returns true if StatusEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of StatusEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventDateTime == input.EventDateTime ||
                    (this.EventDateTime != null &&
                    this.EventDateTime.Equals(input.EventDateTime))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.EventDateTime != null)
                    hashCode = hashCode * 59 + this.EventDateTime.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }

}
