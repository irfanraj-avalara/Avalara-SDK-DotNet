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
    /// ErrorResponseErrorsInner
    /// </summary>
    [JsonConverter(typeof(ErrorResponseErrorsInnerJsonConverter))]
    [DataContract(Name = "ErrorResponse_errors_inner")]
    public partial class ErrorResponseErrorsInner : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseErrorsInner" /> class
        /// with the <see cref="ProblemDetails" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ProblemDetails.</param>
        public ErrorResponseErrorsInner(ProblemDetails actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseErrorsInner" /> class
        /// with the <see cref="HttpValidationProblemDetails" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of HttpValidationProblemDetails.</param>
        public ErrorResponseErrorsInner(HttpValidationProblemDetails actualInstance)
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
                if (value.GetType() == typeof(HttpValidationProblemDetails) || value is HttpValidationProblemDetails)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ProblemDetails) || value is ProblemDetails)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: HttpValidationProblemDetails, ProblemDetails");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ProblemDetails`. If the actual instance is not `ProblemDetails`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ProblemDetails</returns>
        public ProblemDetails GetProblemDetails()
        {
            return (ProblemDetails)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `HttpValidationProblemDetails`. If the actual instance is not `HttpValidationProblemDetails`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of HttpValidationProblemDetails</returns>
        public HttpValidationProblemDetails GetHttpValidationProblemDetails()
        {
            return (HttpValidationProblemDetails)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorResponseErrorsInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ErrorResponseErrorsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ErrorResponseErrorsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ErrorResponseErrorsInner</returns>
        public static ErrorResponseErrorsInner FromJson(string jsonString)
        {
            ErrorResponseErrorsInner newErrorResponseErrorsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newErrorResponseErrorsInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(HttpValidationProblemDetails).GetProperty("AdditionalProperties") == null)
                {
                    newErrorResponseErrorsInner = new ErrorResponseErrorsInner(JsonConvert.DeserializeObject<HttpValidationProblemDetails>(jsonString, ErrorResponseErrorsInner.SerializerSettings));
                }
                else
                {
                    newErrorResponseErrorsInner = new ErrorResponseErrorsInner(JsonConvert.DeserializeObject<HttpValidationProblemDetails>(jsonString, ErrorResponseErrorsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("HttpValidationProblemDetails");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into HttpValidationProblemDetails: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ProblemDetails).GetProperty("AdditionalProperties") == null)
                {
                    newErrorResponseErrorsInner = new ErrorResponseErrorsInner(JsonConvert.DeserializeObject<ProblemDetails>(jsonString, ErrorResponseErrorsInner.SerializerSettings));
                }
                else
                {
                    newErrorResponseErrorsInner = new ErrorResponseErrorsInner(JsonConvert.DeserializeObject<ProblemDetails>(jsonString, ErrorResponseErrorsInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ProblemDetails");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ProblemDetails: {1}", jsonString, exception.ToString()));
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
            return newErrorResponseErrorsInner;
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
    /// Custom JSON converter for ErrorResponseErrorsInner
    /// </summary>
    public class ErrorResponseErrorsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ErrorResponseErrorsInner).GetMethod("ToJson").Invoke(value, null)));
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
                    return ErrorResponseErrorsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ErrorResponseErrorsInner.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
