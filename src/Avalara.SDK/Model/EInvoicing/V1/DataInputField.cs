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
    [DataContract]
    public partial class DataInputField :  IEquatable<DataInputField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataInputField" /> class.
        /// </summary>
        /// <param name="id">Field UUID.</param>
        /// <param name="fieldId">Field ID.</param>
        /// <param name="applicableDocumentRoots">applicableDocumentRoots.</param>
        /// <param name="path">Path to this field.</param>
        /// <param name="varNameSpace">Namespace of this field.</param>
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
        public DataInputField(string id = default(string), string fieldId = default(string), List<Object> applicableDocumentRoots = default(List<Object>), string path = default(string), string varNameSpace = default(string), string fieldName = default(string), string exampleOrFixedValue = default(string), Object acceptedValues = default(Object), string documentationLink = default(string), string description = default(string), bool isSegment = default(bool), DataInputFieldRequiredFor requiredFor = default(DataInputFieldRequiredFor), List<ConditionalForField> conditionalFor = default(List<ConditionalForField>), DataInputFieldNotUsedFor notUsedFor = default(DataInputFieldNotUsedFor), DataInputFieldOptionalFor optionalFor = default(DataInputFieldOptionalFor))
        {
            this.Id = id;
            this.FieldId = fieldId;
            this.ApplicableDocumentRoots = applicableDocumentRoots;
            this.Path = path;
            this.VarNameSpace = varNameSpace;
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
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Field ID
        /// </summary>
        /// <value>Field ID</value>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicableDocumentRoots
        /// </summary>
        [DataMember(Name="applicableDocumentRoots", EmitDefaultValue=false)]
        public List<Object> ApplicableDocumentRoots { get; set; }

        /// <summary>
        /// Path to this field
        /// </summary>
        /// <value>Path to this field</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Namespace of this field
        /// </summary>
        /// <value>Namespace of this field</value>
        [DataMember(Name="nameSpace", EmitDefaultValue=false)]
        public string VarNameSpace { get; set; }

        /// <summary>
        /// Field name
        /// </summary>
        /// <value>Field name</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// An example of the content for this field
        /// </summary>
        /// <value>An example of the content for this field</value>
        [DataMember(Name="exampleOrFixedValue", EmitDefaultValue=false)]
        public string ExampleOrFixedValue { get; set; }

        /// <summary>
        /// An object representing the acceptable values for this field
        /// </summary>
        /// <value>An object representing the acceptable values for this field</value>
        [DataMember(Name="acceptedValues", EmitDefaultValue=false)]
        public Object AcceptedValues { get; set; }

        /// <summary>
        /// An example of the content for this field
        /// </summary>
        /// <value>An example of the content for this field</value>
        [DataMember(Name="documentationLink", EmitDefaultValue=false)]
        public string DocumentationLink { get; set; }

        /// <summary>
        /// A description of this field
        /// </summary>
        /// <value>A description of this field</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Is this a segment of the schema
        /// </summary>
        /// <value>Is this a segment of the schema</value>
        [DataMember(Name="isSegment", EmitDefaultValue=false)]
        public bool IsSegment { get; set; }

        /// <summary>
        /// Gets or Sets RequiredFor
        /// </summary>
        [DataMember(Name="requiredFor", EmitDefaultValue=false)]
        public DataInputFieldRequiredFor RequiredFor { get; set; }

        /// <summary>
        /// Gets or Sets ConditionalFor
        /// </summary>
        [DataMember(Name="conditionalFor", EmitDefaultValue=false)]
        public List<ConditionalForField> ConditionalFor { get; set; }

        /// <summary>
        /// Gets or Sets NotUsedFor
        /// </summary>
        [DataMember(Name="notUsedFor", EmitDefaultValue=false)]
        public DataInputFieldNotUsedFor NotUsedFor { get; set; }

        /// <summary>
        /// Gets or Sets OptionalFor
        /// </summary>
        [DataMember(Name="optionalFor", EmitDefaultValue=false)]
        public DataInputFieldOptionalFor OptionalFor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataInputField {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  ApplicableDocumentRoots: ").Append(ApplicableDocumentRoots).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  VarNameSpace: ").Append(VarNameSpace).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataInputField);
        }

        /// <summary>
        /// Returns true if DataInputField instances are equal
        /// </summary>
        /// <param name="input">Instance of DataInputField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataInputField input)
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
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.ApplicableDocumentRoots == input.ApplicableDocumentRoots ||
                    this.ApplicableDocumentRoots != null &&
                    input.ApplicableDocumentRoots != null &&
                    this.ApplicableDocumentRoots.SequenceEqual(input.ApplicableDocumentRoots)
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.VarNameSpace == input.VarNameSpace ||
                    (this.VarNameSpace != null &&
                    this.VarNameSpace.Equals(input.VarNameSpace))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.ExampleOrFixedValue == input.ExampleOrFixedValue ||
                    (this.ExampleOrFixedValue != null &&
                    this.ExampleOrFixedValue.Equals(input.ExampleOrFixedValue))
                ) && 
                (
                    this.AcceptedValues == input.AcceptedValues ||
                    (this.AcceptedValues != null &&
                    this.AcceptedValues.Equals(input.AcceptedValues))
                ) && 
                (
                    this.DocumentationLink == input.DocumentationLink ||
                    (this.DocumentationLink != null &&
                    this.DocumentationLink.Equals(input.DocumentationLink))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IsSegment == input.IsSegment ||
                    (this.IsSegment != null &&
                    this.IsSegment.Equals(input.IsSegment))
                ) && 
                (
                    this.RequiredFor == input.RequiredFor ||
                    (this.RequiredFor != null &&
                    this.RequiredFor.Equals(input.RequiredFor))
                ) && 
                (
                    this.ConditionalFor == input.ConditionalFor ||
                    this.ConditionalFor != null &&
                    input.ConditionalFor != null &&
                    this.ConditionalFor.SequenceEqual(input.ConditionalFor)
                ) && 
                (
                    this.NotUsedFor == input.NotUsedFor ||
                    (this.NotUsedFor != null &&
                    this.NotUsedFor.Equals(input.NotUsedFor))
                ) && 
                (
                    this.OptionalFor == input.OptionalFor ||
                    (this.OptionalFor != null &&
                    this.OptionalFor.Equals(input.OptionalFor))
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
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.ApplicableDocumentRoots != null)
                    hashCode = hashCode * 59 + this.ApplicableDocumentRoots.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.VarNameSpace != null)
                    hashCode = hashCode * 59 + this.VarNameSpace.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.ExampleOrFixedValue != null)
                    hashCode = hashCode * 59 + this.ExampleOrFixedValue.GetHashCode();
                if (this.AcceptedValues != null)
                    hashCode = hashCode * 59 + this.AcceptedValues.GetHashCode();
                if (this.DocumentationLink != null)
                    hashCode = hashCode * 59 + this.DocumentationLink.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsSegment != null)
                    hashCode = hashCode * 59 + this.IsSegment.GetHashCode();
                if (this.RequiredFor != null)
                    hashCode = hashCode * 59 + this.RequiredFor.GetHashCode();
                if (this.ConditionalFor != null)
                    hashCode = hashCode * 59 + this.ConditionalFor.GetHashCode();
                if (this.NotUsedFor != null)
                    hashCode = hashCode * 59 + this.NotUsedFor.GetHashCode();
                if (this.OptionalFor != null)
                    hashCode = hashCode * 59 + this.OptionalFor.GetHashCode();
                return hashCode;
            }
        }
    }

}
