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
    /// Displays a summary of information about the document
    /// </summary>
    [DataContract]
    public partial class DocumentSummary :  IEquatable<DocumentSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSummary" /> class.
        /// </summary>
        /// <param name="id">The unique ID for this document.</param>
        /// <param name="processDateTime">The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss.</param>
        /// <param name="status">The transaction status: &lt;br&gt; &#39;Pending&#39; &lt;br&gt; &#39;Failed&#39; &lt;br&gt; &#39;Complete&#39;.</param>
        /// <param name="supplierName">The name of the supplier in the transaction.</param>
        /// <param name="customerName">The name of the customer in the transaction.</param>
        /// <param name="documentNumber">The invoice document number.</param>
        /// <param name="documentDate">The invoice issue date.</param>
        /// <param name="flow">The invoice direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60;.</param>
        /// <param name="countryCode">The two-letter ISO-3166 country code for the country where the e-invoice is being submitted.</param>
        /// <param name="countryMandate">The e-invoicing mandate for the specified country.</param>
        /// <param name="varInterface">The interface where the invoice data is sent.</param>
        /// <param name="receiver">The invoice recipient based on the interface.</param>
        public DocumentSummary(string id = default(string), string processDateTime = default(string), string status = default(string), string supplierName = default(string), string customerName = default(string), string documentNumber = default(string), string documentDate = default(string), string flow = default(string), string countryCode = default(string), string countryMandate = default(string), string varInterface = default(string), string receiver = default(string))
        {
            this.Id = id;
            this.ProcessDateTime = processDateTime;
            this.Status = status;
            this.SupplierName = supplierName;
            this.CustomerName = customerName;
            this.DocumentNumber = documentNumber;
            this.DocumentDate = documentDate;
            this.Flow = flow;
            this.CountryCode = countryCode;
            this.CountryMandate = countryMandate;
            this.VarInterface = varInterface;
            this.Receiver = receiver;
        }

        /// <summary>
        /// The unique ID for this document
        /// </summary>
        /// <value>The unique ID for this document</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>The date and time when the document was processed, displayed in the format YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="processDateTime", EmitDefaultValue=false)]
        public string ProcessDateTime { get; set; }

        /// <summary>
        /// The transaction status: &lt;br&gt; &#39;Pending&#39; &lt;br&gt; &#39;Failed&#39; &lt;br&gt; &#39;Complete&#39;
        /// </summary>
        /// <value>The transaction status: &lt;br&gt; &#39;Pending&#39; &lt;br&gt; &#39;Failed&#39; &lt;br&gt; &#39;Complete&#39;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The name of the supplier in the transaction
        /// </summary>
        /// <value>The name of the supplier in the transaction</value>
        [DataMember(Name="supplierName", EmitDefaultValue=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// The name of the customer in the transaction
        /// </summary>
        /// <value>The name of the customer in the transaction</value>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// The invoice document number
        /// </summary>
        /// <value>The invoice document number</value>
        [DataMember(Name="documentNumber", EmitDefaultValue=false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// The invoice issue date
        /// </summary>
        /// <value>The invoice issue date</value>
        [DataMember(Name="documentDate", EmitDefaultValue=false)]
        public string DocumentDate { get; set; }

        /// <summary>
        /// The invoice direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60;
        /// </summary>
        /// <value>The invoice direction, where issued &#x3D; &#x60;out&#x60; and received &#x3D; &#x60;in&#x60;</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public string Flow { get; set; }

        /// <summary>
        /// The two-letter ISO-3166 country code for the country where the e-invoice is being submitted
        /// </summary>
        /// <value>The two-letter ISO-3166 country code for the country where the e-invoice is being submitted</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The e-invoicing mandate for the specified country
        /// </summary>
        /// <value>The e-invoicing mandate for the specified country</value>
        [DataMember(Name="countryMandate", EmitDefaultValue=false)]
        public string CountryMandate { get; set; }

        /// <summary>
        /// The interface where the invoice data is sent
        /// </summary>
        /// <value>The interface where the invoice data is sent</value>
        [DataMember(Name="interface", EmitDefaultValue=false)]
        public string VarInterface { get; set; }

        /// <summary>
        /// The invoice recipient based on the interface
        /// </summary>
        /// <value>The invoice recipient based on the interface</value>
        [DataMember(Name="receiver", EmitDefaultValue=false)]
        public string Receiver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessDateTime: ").Append(ProcessDateTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryMandate: ").Append(CountryMandate).Append("\n");
            sb.Append("  VarInterface: ").Append(VarInterface).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
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
            return this.Equals(input as DocumentSummary);
        }

        /// <summary>
        /// Returns true if DocumentSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ProcessDateTime == input.ProcessDateTime ||
                    (this.ProcessDateTime != null &&
                    this.ProcessDateTime.Equals(input.ProcessDateTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SupplierName == input.SupplierName ||
                    (this.SupplierName != null &&
                    this.SupplierName.Equals(input.SupplierName))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.DocumentDate == input.DocumentDate ||
                    (this.DocumentDate != null &&
                    this.DocumentDate.Equals(input.DocumentDate))
                ) && 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CountryMandate == input.CountryMandate ||
                    (this.CountryMandate != null &&
                    this.CountryMandate.Equals(input.CountryMandate))
                ) && 
                (
                    this.VarInterface == input.VarInterface ||
                    (this.VarInterface != null &&
                    this.VarInterface.Equals(input.VarInterface))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProcessDateTime != null)
                    hashCode = hashCode * 59 + this.ProcessDateTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SupplierName != null)
                    hashCode = hashCode * 59 + this.SupplierName.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.DocumentDate != null)
                    hashCode = hashCode * 59 + this.DocumentDate.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CountryMandate != null)
                    hashCode = hashCode * 59 + this.CountryMandate.GetHashCode();
                if (this.VarInterface != null)
                    hashCode = hashCode * 59 + this.VarInterface.GetHashCode();
                if (this.Receiver != null)
                    hashCode = hashCode * 59 + this.Receiver.GetHashCode();
                return hashCode;
            }
        }
    }

}
