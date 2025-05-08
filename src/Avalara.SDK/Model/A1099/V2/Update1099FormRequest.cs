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
    /// Update1099FormRequest
    /// </summary>
    [JsonConverter(typeof(Update1099FormRequestJsonConverter))]
    [DataContract(Name = "Update1099Form_request")]
    public partial class Update1099FormRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Update1099FormRequest" /> class
        /// with the <see cref="Form1099DivCsvRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099DivCsvRequest.</param>
        public Update1099FormRequest(Form1099DivCsvRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Update1099FormRequest" /> class
        /// with the <see cref="Form1099MiscCsvRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099MiscCsvRequest.</param>
        public Update1099FormRequest(Form1099MiscCsvRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Update1099FormRequest" /> class
        /// with the <see cref="Form1099NecCsvRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099NecCsvRequest.</param>
        public Update1099FormRequest(Form1099NecCsvRequest actualInstance)
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
                if (value.GetType() == typeof(Form1099DivCsvRequest) || value is Form1099DivCsvRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099MiscCsvRequest) || value is Form1099MiscCsvRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099NecCsvRequest) || value is Form1099NecCsvRequest)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1099DivCsvRequest, Form1099MiscCsvRequest, Form1099NecCsvRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Form1099DivCsvRequest`. If the actual instance is not `Form1099DivCsvRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099DivCsvRequest</returns>
        public Form1099DivCsvRequest GetForm1099DivCsvRequest()
        {
            return (Form1099DivCsvRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099MiscCsvRequest`. If the actual instance is not `Form1099MiscCsvRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099MiscCsvRequest</returns>
        public Form1099MiscCsvRequest GetForm1099MiscCsvRequest()
        {
            return (Form1099MiscCsvRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099NecCsvRequest`. If the actual instance is not `Form1099NecCsvRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099NecCsvRequest</returns>
        public Form1099NecCsvRequest GetForm1099NecCsvRequest()
        {
            return (Form1099NecCsvRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Update1099FormRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Update1099FormRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Update1099FormRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Update1099FormRequest</returns>
        public static Update1099FormRequest FromJson(string jsonString)
        {
            Update1099FormRequest newUpdate1099FormRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUpdate1099FormRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099DivCsvRequest).GetProperty("AdditionalProperties") == null)
                {
                    newUpdate1099FormRequest = new Update1099FormRequest(JsonConvert.DeserializeObject<Form1099DivCsvRequest>(jsonString, Update1099FormRequest.SerializerSettings));
                }
                else
                {
                    newUpdate1099FormRequest = new Update1099FormRequest(JsonConvert.DeserializeObject<Form1099DivCsvRequest>(jsonString, Update1099FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099DivCsvRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099DivCsvRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099MiscCsvRequest).GetProperty("AdditionalProperties") == null)
                {
                    newUpdate1099FormRequest = new Update1099FormRequest(JsonConvert.DeserializeObject<Form1099MiscCsvRequest>(jsonString, Update1099FormRequest.SerializerSettings));
                }
                else
                {
                    newUpdate1099FormRequest = new Update1099FormRequest(JsonConvert.DeserializeObject<Form1099MiscCsvRequest>(jsonString, Update1099FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099MiscCsvRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099MiscCsvRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099NecCsvRequest).GetProperty("AdditionalProperties") == null)
                {
                    newUpdate1099FormRequest = new Update1099FormRequest(JsonConvert.DeserializeObject<Form1099NecCsvRequest>(jsonString, Update1099FormRequest.SerializerSettings));
                }
                else
                {
                    newUpdate1099FormRequest = new Update1099FormRequest(JsonConvert.DeserializeObject<Form1099NecCsvRequest>(jsonString, Update1099FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099NecCsvRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099NecCsvRequest: {1}", jsonString, exception.ToString()));
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
            return newUpdate1099FormRequest;
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
    /// Custom JSON converter for Update1099FormRequest
    /// </summary>
    public class Update1099FormRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Update1099FormRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return Update1099FormRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Update1099FormRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
