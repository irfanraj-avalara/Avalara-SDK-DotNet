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
    /// The Data Input Field
    /// </summary>
    [DataContract(Name = "MandateDataInputField")]
    public partial class MandateDataInputField : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandateDataInputField" /> class.
        /// </summary>
        /// <param name="fieldId">Field ID.</param>
        /// <param name="documentType">The document type.</param>
        /// <param name="documentVersion">The document version.</param>
        /// <param name="path">Path to this field.</param>
        /// <param name="pathType">The type of path.</param>
        /// <param name="fieldName">Field name.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="exampleOrFixedValue">An example of the content for this field.</param>
        /// <param name="acceptedValues">An Array representing the acceptable values for this field.</param>
        /// <param name="documentationLink">An example of the content for this field.</param>
        /// <param name="dataType">The data type of this field..</param>
        /// <param name="description">A description of this field.</param>
        /// <param name="optionality">Determines if the field if Required/Conditional/Optional or not required..</param>
        /// <param name="cardinality">Represents the number of times an element can appear within the document.</param>
        public MandateDataInputField(string fieldId = default(string), string documentType = default(string), string documentVersion = default(string), string path = default(string), string pathType = default(string), string fieldName = default(string), MandateDataInputFieldNamespace varNamespace = default(MandateDataInputFieldNamespace), string exampleOrFixedValue = default(string), List<string> acceptedValues = default(List<string>), string documentationLink = default(string), string dataType = default(string), string description = default(string), string optionality = default(string), string cardinality = default(string))
        {
            this.FieldId = fieldId;
            this.DocumentType = documentType;
            this.DocumentVersion = documentVersion;
            this.Path = path;
            this.PathType = pathType;
            this.FieldName = fieldName;
            this.Namespace = varNamespace;
            this.ExampleOrFixedValue = exampleOrFixedValue;
            this.AcceptedValues = acceptedValues;
            this.DocumentationLink = documentationLink;
            this.DataType = dataType;
            this.Description = description;
            this.Optionality = optionality;
            this.Cardinality = cardinality;
        }

        /// <summary>
        /// Field ID
        /// </summary>
        /// <value>Field ID</value>
        /// <example>1</example>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        /// The document type
        /// </summary>
        /// <value>The document type</value>
        /// <example>ubl-inovice</example>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// The document version
        /// </summary>
        /// <value>The document version</value>
        /// <example>2.1</example>
        [DataMember(Name = "documentVersion", EmitDefaultValue = false)]
        public string DocumentVersion { get; set; }

        /// <summary>
        /// Path to this field
        /// </summary>
        /// <value>Path to this field</value>
        /// <example>Invoice/cbc:CustomizationID</example>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// The type of path
        /// </summary>
        /// <value>The type of path</value>
        /// <example>xpath</example>
        [DataMember(Name = "pathType", EmitDefaultValue = false)]
        public string PathType { get; set; }

        /// <summary>
        /// Field name
        /// </summary>
        /// <value>Field name</value>
        /// <example>cbc:CustomizationID</example>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public MandateDataInputFieldNamespace Namespace { get; set; }

        /// <summary>
        /// An example of the content for this field
        /// </summary>
        /// <value>An example of the content for this field</value>
        /// <example>urn:cen.eu:en16931:2017#compliant#urn:fdc:peppol.eu:2017:poacc:billing:3.0</example>
        [DataMember(Name = "exampleOrFixedValue", EmitDefaultValue = false)]
        public string ExampleOrFixedValue { get; set; }

        /// <summary>
        /// An Array representing the acceptable values for this field
        /// </summary>
        /// <value>An Array representing the acceptable values for this field</value>
        [DataMember(Name = "acceptedValues", EmitDefaultValue = false)]
        public List<string> AcceptedValues { get; set; }

        /// <summary>
        /// An example of the content for this field
        /// </summary>
        /// <value>An example of the content for this field</value>
        /// <example>https://docs.peppol.eu/poacc/billing/3.0/syntax/ubl-invoice/cbc-CustomizationID</example>
        [DataMember(Name = "documentationLink", EmitDefaultValue = false)]
        public string DocumentationLink { get; set; }

        /// <summary>
        /// The data type of this field.
        /// </summary>
        /// <value>The data type of this field.</value>
        /// <example>object</example>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// A description of this field
        /// </summary>
        /// <value>A description of this field</value>
        /// <example>Specification identifier: An identification of the specification containing the total set of rules regarding semantic content, cardinalities and business rules to which the data contained in the instance document conforms.</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Determines if the field if Required/Conditional/Optional or not required.
        /// </summary>
        /// <value>Determines if the field if Required/Conditional/Optional or not required.</value>
        /// <example>Required</example>
        [DataMember(Name = "optionality", EmitDefaultValue = false)]
        public string Optionality { get; set; }

        /// <summary>
        /// Represents the number of times an element can appear within the document
        /// </summary>
        /// <value>Represents the number of times an element can appear within the document</value>
        /// <example>1..1</example>
        [DataMember(Name = "cardinality", EmitDefaultValue = false)]
        public string Cardinality { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MandateDataInputField {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  PathType: ").Append(PathType).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ExampleOrFixedValue: ").Append(ExampleOrFixedValue).Append("\n");
            sb.Append("  AcceptedValues: ").Append(AcceptedValues).Append("\n");
            sb.Append("  DocumentationLink: ").Append(DocumentationLink).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Optionality: ").Append(Optionality).Append("\n");
            sb.Append("  Cardinality: ").Append(Cardinality).Append("\n");
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
