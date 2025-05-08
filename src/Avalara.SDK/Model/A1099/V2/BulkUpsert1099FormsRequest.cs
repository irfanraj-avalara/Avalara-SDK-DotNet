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
using System.Reflection;

namespace Avalara.SDK.Model.A1099.V2
{
    /// <summary>
    /// BulkUpsert1099FormsRequest
    /// </summary>
    [JsonConverter(typeof(BulkUpsert1099FormsRequestJsonConverter))]
    [DataContract(Name = "BulkUpsert1099Forms_request")]
    public partial class BulkUpsert1099FormsRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099TypeDiv" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099TypeDiv.</param>
        public BulkUpsert1099FormsRequest(Form1099TypeDiv actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099TypeMisc" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099TypeMisc.</param>
        public BulkUpsert1099FormsRequest(Form1099TypeMisc actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099TypeNec" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099TypeNec.</param>
        public BulkUpsert1099FormsRequest(Form1099TypeNec actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Form1099TypeDiv) || value is Form1099TypeDiv)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099TypeMisc) || value is Form1099TypeMisc)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099TypeNec) || value is Form1099TypeNec)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1099TypeDiv, Form1099TypeMisc, Form1099TypeNec");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Form1099TypeDiv`. If the actual instance is not `Form1099TypeDiv`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099TypeDiv</returns>
        public Form1099TypeDiv GetForm1099TypeDiv()
        {
            return (Form1099TypeDiv)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099TypeMisc`. If the actual instance is not `Form1099TypeMisc`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099TypeMisc</returns>
        public Form1099TypeMisc GetForm1099TypeMisc()
        {
            return (Form1099TypeMisc)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099TypeNec`. If the actual instance is not `Form1099TypeNec`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099TypeNec</returns>
        public Form1099TypeNec GetForm1099TypeNec()
        {
            return (Form1099TypeNec)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpsert1099FormsRequest {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, BulkUpsert1099FormsRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of BulkUpsert1099FormsRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of BulkUpsert1099FormsRequest</returns>
        public static BulkUpsert1099FormsRequest FromJson(string jsonString)
        {
            BulkUpsert1099FormsRequest newBulkUpsert1099FormsRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newBulkUpsert1099FormsRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099TypeDiv).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099TypeDiv>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099TypeDiv>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099TypeDiv");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099TypeDiv: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099TypeMisc).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099TypeMisc>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099TypeMisc>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099TypeMisc");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099TypeMisc: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099TypeNec).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099TypeNec>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099TypeNec>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099TypeNec");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099TypeNec: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newBulkUpsert1099FormsRequest;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for BulkUpsert1099FormsRequest
    /// </summary>
    public class BulkUpsert1099FormsRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(BulkUpsert1099FormsRequest).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return BulkUpsert1099FormsRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return BulkUpsert1099FormsRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
