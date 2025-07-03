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
    [DataContract(Name = "DataInputField")]
    public partial class DataInputField : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataInputField" /> class.
        /// </summary>
        /// <param name="id">Field UUID.</param>
        /// <param name="fieldId">Field ID.</param>
        /// <param name="applicableDocumentRoots">applicableDocumentRoots.</param>
        /// <param name="path">Path to this field.</param>
        /// <param name="varNamespace">Namespace of this field.</param>
        /// <param name="fieldName">Field name.</param>
        /// <param name="exampleOrFixedValue">An example of the content for this field.</param>
        /// <param name="acceptedValues">An object representing the acceptable values for this field.</param>
        /// <param name="documentationLink">An example of the content for this field.</param>
        /// <param name="description">A description of this field.</param>
        /// <param name="isSegment">Is this a segment of the schema.</param>
        /// <param name="requiredFor">requiredFor.</param>
        /// <param name="conditionalFor">conditionalFor.</param>
        /// <param name="notUsedFor">notUsedFor.</param>
        /// <param name="optionalFor">optionalFor.</param>
        public DataInputField(string id = default(string), string fieldId = default(string), List<Object> applicableDocumentRoots = default(List<Object>), string path = default(string), string varNamespace = default(string), string fieldName = default(string), string exampleOrFixedValue = default(string), Object acceptedValues = default(Object), string documentationLink = default(string), string description = default(string), bool isSegment = default(bool), DataInputFieldRequiredFor requiredFor = default(DataInputFieldRequiredFor), List<ConditionalForField> conditionalFor = default(List<ConditionalForField>), DataInputFieldNotUsedFor notUsedFor = default(DataInputFieldNotUsedFor), DataInputFieldOptionalFor optionalFor = default(DataInputFieldOptionalFor))
        {
            this.Id = id;
            this.FieldId = fieldId;
            this.ApplicableDocumentRoots = applicableDocumentRoots;
            this.Path = path;
            this.Namespace = varNamespace;
            this.FieldName = fieldName;
            this.ExampleOrFixedValue = exampleOrFixedValue;
            this.AcceptedValues = acceptedValues;
            this.DocumentationLink = documentationLink;
            this.Description = description;
            this.IsSegment = isSegment;
            this.RequiredFor = requiredFor;
            this.ConditionalFor = conditionalFor;
            this.NotUsedFor = notUsedFor;
            this.OptionalFor = optionalFor;
        }

        /// <summary>
        /// Field UUID
        /// </summary>
        /// <value>Field UUID</value>
        /// <example>f1768981-7025-468b-9f87-8a8982cd6984</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Field ID
        /// </summary>
        /// <value>Field ID</value>
        /// <example>1</example>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicableDocumentRoots
        /// </summary>
        [DataMember(Name = "applicableDocumentRoots", EmitDefaultValue = false)]
        public List<Object> ApplicableDocumentRoots { get; set; }

        /// <summary>
        /// Path to this field
        /// </summary>
        /// <value>Path to this field</value>
        /// <example>invoice/cbc:CustomizationID</example>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Namespace of this field
        /// </summary>
        /// <value>Namespace of this field</value>
        /// <example>cbc:</example>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Field name
        /// </summary>
        /// <value>Field name</value>
        /// <example>cbc:CustomizationID</example>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// An example of the content for this field
        /// </summary>
        /// <value>An example of the content for this field</value>
        /// <example>urn:cen.eu:en16931:2017#compliant#urn:fdc:peppol.eu:2017:poacc:billing:3.0</example>
        [DataMember(Name = "exampleOrFixedValue", EmitDefaultValue = false)]
        public string ExampleOrFixedValue { get; set; }

        /// <summary>
        /// An object representing the acceptable values for this field
        /// </summary>
        /// <value>An object representing the acceptable values for this field</value>
        [DataMember(Name = "acceptedValues", EmitDefaultValue = false)]
        public Object AcceptedValues { get; set; }

        /// <summary>
        /// An example of the content for this field
        /// </summary>
        /// <value>An example of the content for this field</value>
        /// <example>https://docs.peppol.eu/poacc/billing/3.0/syntax/ubl-invoice/cbc-CustomizationID</example>
        [DataMember(Name = "documentationLink", EmitDefaultValue = false)]
        public string DocumentationLink { get; set; }

        /// <summary>
        /// A description of this field
        /// </summary>
        /// <value>A description of this field</value>
        /// <example>Specification identifier: An identification of the specification containing the total set of rules regarding semantic content, cardinalities and business rules to which the data contained in the instance document conforms.</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Is this a segment of the schema
        /// </summary>
        /// <value>Is this a segment of the schema</value>
        /// <example>false</example>
        [DataMember(Name = "isSegment", EmitDefaultValue = true)]
        public bool IsSegment { get; set; }

        /// <summary>
        /// Gets or Sets RequiredFor
        /// </summary>
        [DataMember(Name = "requiredFor", EmitDefaultValue = false)]
        public DataInputFieldRequiredFor RequiredFor { get; set; }

        /// <summary>
        /// Gets or Sets ConditionalFor
        /// </summary>
        [DataMember(Name = "conditionalFor", EmitDefaultValue = false)]
        public List<ConditionalForField> ConditionalFor { get; set; }

        /// <summary>
        /// Gets or Sets NotUsedFor
        /// </summary>
        [DataMember(Name = "notUsedFor", EmitDefaultValue = false)]
        public DataInputFieldNotUsedFor NotUsedFor { get; set; }

        /// <summary>
        /// Gets or Sets OptionalFor
        /// </summary>
        [DataMember(Name = "optionalFor", EmitDefaultValue = false)]
        public DataInputFieldOptionalFor OptionalFor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataInputField {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  ApplicableDocumentRoots: ").Append(ApplicableDocumentRoots).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  ExampleOrFixedValue: ").Append(ExampleOrFixedValue).Append("\n");
            sb.Append("  AcceptedValues: ").Append(AcceptedValues).Append("\n");
            sb.Append("  DocumentationLink: ").Append(DocumentationLink).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsSegment: ").Append(IsSegment).Append("\n");
            sb.Append("  RequiredFor: ").Append(RequiredFor).Append("\n");
            sb.Append("  ConditionalFor: ").Append(ConditionalFor).Append("\n");
            sb.Append("  NotUsedFor: ").Append(NotUsedFor).Append("\n");
            sb.Append("  OptionalFor: ").Append(OptionalFor).Append("\n");
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
