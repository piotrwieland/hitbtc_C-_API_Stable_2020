/* 
 * HitBTC API
 *
 * Create API keys in your profile https://hitbtc.com/settings/api-keys and use public API key as username and secret as password to authorize. 
 *
 * OpenAPI spec version: 2.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Error
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        public Error(ErrorError error = default(ErrorError))
        {
            this._Error = error;
        }
        
        /// <summary>
        /// Gets or Sets _Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorError _Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  _Error: ").Append(_Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Error == input._Error ||
                    (this._Error != null &&
                    this._Error.Equals(input._Error))
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
                if (this._Error != null)
                    hashCode = hashCode * 59 + this._Error.GetHashCode();
                return hashCode;
            }
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

}
