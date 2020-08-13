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
    /// Currency
    /// </summary>
    [DataContract]
    public partial class Currency :  IEquatable<Currency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Currency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Currency" /> class.
        /// </summary>
        /// <param name="id">Currency code (required).</param>
        /// <param name="fullName">fullName (required).</param>
        /// <param name="crypto">True for cryptocurrencies, false for fiat, ICO and others. (required).</param>
        /// <param name="payinEnabled">True if cryptocurrency support generate adress or paymentId for deposits (required).</param>
        /// <param name="payinPaymentId">True if cryptocurrency requred use paymentId for deposits (required).</param>
        /// <param name="payinConfirmations">Confirmations count for cryptocurrency deposits (required).</param>
        /// <param name="payoutEnabled">payoutEnabled (required).</param>
        /// <param name="payoutFee">Default withdraw fee (required).</param>
        /// <param name="payoutIsPaymentId">True if cryptocurrency allow use paymentId for withdraw (required).</param>
        /// <param name="delisted">True if currency delisted (stopped deposit and trading) (required).</param>
        /// <param name="transferEnabled">transferEnabled (required).</param>
        public Currency(string id = default(string), string fullName = default(string), bool? crypto = default(bool?), bool? payinEnabled = default(bool?), bool? payinPaymentId = default(bool?), int? payinConfirmations = default(int?), bool? payoutEnabled = default(bool?), string payoutFee = default(string), bool? payoutIsPaymentId = default(bool?), bool? delisted = default(bool?), bool? transferEnabled = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Currency and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "fullName" is required (not null)
            if (fullName == null)
            {
                throw new InvalidDataException("fullName is a required property for Currency and cannot be null");
            }
            else
            {
                this.FullName = fullName;
            }
            // to ensure "crypto" is required (not null)
            if (crypto == null)
            {
                throw new InvalidDataException("crypto is a required property for Currency and cannot be null");
            }
            else
            {
                this.Crypto = crypto;
            }
            // to ensure "payinEnabled" is required (not null)
            if (payinEnabled == null)
            {
                throw new InvalidDataException("payinEnabled is a required property for Currency and cannot be null");
            }
            else
            {
                this.PayinEnabled = payinEnabled;
            }
            // to ensure "payinPaymentId" is required (not null)
            if (payinPaymentId == null)
            {
                throw new InvalidDataException("payinPaymentId is a required property for Currency and cannot be null");
            }
            else
            {
                this.PayinPaymentId = payinPaymentId;
            }
            // to ensure "payinConfirmations" is required (not null)
            if (payinConfirmations == null)
            {
                throw new InvalidDataException("payinConfirmations is a required property for Currency and cannot be null");
            }
            else
            {
                this.PayinConfirmations = payinConfirmations;
            }
            // to ensure "payoutEnabled" is required (not null)
            if (payoutEnabled == null)
            {
                throw new InvalidDataException("payoutEnabled is a required property for Currency and cannot be null");
            }
            else
            {
                this.PayoutEnabled = payoutEnabled;
            }
            // to ensure "payoutFee" is required (not null)
            if (payoutFee == null)
            {
                throw new InvalidDataException("payoutFee is a required property for Currency and cannot be null");
            }
            else
            {
                this.PayoutFee = payoutFee;
            }
            // to ensure "payoutIsPaymentId" is required (not null)
            if (payoutIsPaymentId == null)
            {
                throw new InvalidDataException("payoutIsPaymentId is a required property for Currency and cannot be null");
            }
            else
            {
                this.PayoutIsPaymentId = payoutIsPaymentId;
            }
            // to ensure "delisted" is required (not null)
            if (delisted == null)
            {
                throw new InvalidDataException("delisted is a required property for Currency and cannot be null");
            }
            else
            {
                this.Delisted = delisted;
            }
            // to ensure "transferEnabled" is required (not null)
            if (transferEnabled == null)
            {
                throw new InvalidDataException("transferEnabled is a required property for Currency and cannot be null");
            }
            else
            {
                this.TransferEnabled = transferEnabled;
            }
        }
        
        /// <summary>
        /// Currency code
        /// </summary>
        /// <value>Currency code</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// True for cryptocurrencies, false for fiat, ICO and others.
        /// </summary>
        /// <value>True for cryptocurrencies, false for fiat, ICO and others.</value>
        [DataMember(Name="crypto", EmitDefaultValue=false)]
        public bool? Crypto { get; set; }

        /// <summary>
        /// True if cryptocurrency support generate adress or paymentId for deposits
        /// </summary>
        /// <value>True if cryptocurrency support generate adress or paymentId for deposits</value>
        [DataMember(Name="payinEnabled", EmitDefaultValue=false)]
        public bool? PayinEnabled { get; set; }

        /// <summary>
        /// True if cryptocurrency requred use paymentId for deposits
        /// </summary>
        /// <value>True if cryptocurrency requred use paymentId for deposits</value>
        [DataMember(Name="payinPaymentId", EmitDefaultValue=false)]
        public bool? PayinPaymentId { get; set; }

        /// <summary>
        /// Confirmations count for cryptocurrency deposits
        /// </summary>
        /// <value>Confirmations count for cryptocurrency deposits</value>
        [DataMember(Name="payinConfirmations", EmitDefaultValue=false)]
        public int? PayinConfirmations { get; set; }

        /// <summary>
        /// Gets or Sets PayoutEnabled
        /// </summary>
        [DataMember(Name="payoutEnabled", EmitDefaultValue=false)]
        public bool? PayoutEnabled { get; set; }

        /// <summary>
        /// Default withdraw fee
        /// </summary>
        /// <value>Default withdraw fee</value>
        [DataMember(Name="payoutFee", EmitDefaultValue=false)]
        public string PayoutFee { get; set; }

        /// <summary>
        /// True if cryptocurrency allow use paymentId for withdraw
        /// </summary>
        /// <value>True if cryptocurrency allow use paymentId for withdraw</value>
        [DataMember(Name="payoutIsPaymentId", EmitDefaultValue=false)]
        public bool? PayoutIsPaymentId { get; set; }

        /// <summary>
        /// True if currency delisted (stopped deposit and trading)
        /// </summary>
        /// <value>True if currency delisted (stopped deposit and trading)</value>
        [DataMember(Name="delisted", EmitDefaultValue=false)]
        public bool? Delisted { get; set; }

        /// <summary>
        /// Gets or Sets TransferEnabled
        /// </summary>
        [DataMember(Name="transferEnabled", EmitDefaultValue=false)]
        public bool? TransferEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Currency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Crypto: ").Append(Crypto).Append("\n");
            sb.Append("  PayinEnabled: ").Append(PayinEnabled).Append("\n");
            sb.Append("  PayinPaymentId: ").Append(PayinPaymentId).Append("\n");
            sb.Append("  PayinConfirmations: ").Append(PayinConfirmations).Append("\n");
            sb.Append("  PayoutEnabled: ").Append(PayoutEnabled).Append("\n");
            sb.Append("  PayoutFee: ").Append(PayoutFee).Append("\n");
            sb.Append("  PayoutIsPaymentId: ").Append(PayoutIsPaymentId).Append("\n");
            sb.Append("  Delisted: ").Append(Delisted).Append("\n");
            sb.Append("  TransferEnabled: ").Append(TransferEnabled).Append("\n");
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
            return this.Equals(input as Currency);
        }

        /// <summary>
        /// Returns true if Currency instances are equal
        /// </summary>
        /// <param name="input">Instance of Currency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Currency input)
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
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.Crypto == input.Crypto ||
                    (this.Crypto != null &&
                    this.Crypto.Equals(input.Crypto))
                ) && 
                (
                    this.PayinEnabled == input.PayinEnabled ||
                    (this.PayinEnabled != null &&
                    this.PayinEnabled.Equals(input.PayinEnabled))
                ) && 
                (
                    this.PayinPaymentId == input.PayinPaymentId ||
                    (this.PayinPaymentId != null &&
                    this.PayinPaymentId.Equals(input.PayinPaymentId))
                ) && 
                (
                    this.PayinConfirmations == input.PayinConfirmations ||
                    (this.PayinConfirmations != null &&
                    this.PayinConfirmations.Equals(input.PayinConfirmations))
                ) && 
                (
                    this.PayoutEnabled == input.PayoutEnabled ||
                    (this.PayoutEnabled != null &&
                    this.PayoutEnabled.Equals(input.PayoutEnabled))
                ) && 
                (
                    this.PayoutFee == input.PayoutFee ||
                    (this.PayoutFee != null &&
                    this.PayoutFee.Equals(input.PayoutFee))
                ) && 
                (
                    this.PayoutIsPaymentId == input.PayoutIsPaymentId ||
                    (this.PayoutIsPaymentId != null &&
                    this.PayoutIsPaymentId.Equals(input.PayoutIsPaymentId))
                ) && 
                (
                    this.Delisted == input.Delisted ||
                    (this.Delisted != null &&
                    this.Delisted.Equals(input.Delisted))
                ) && 
                (
                    this.TransferEnabled == input.TransferEnabled ||
                    (this.TransferEnabled != null &&
                    this.TransferEnabled.Equals(input.TransferEnabled))
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
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Crypto != null)
                    hashCode = hashCode * 59 + this.Crypto.GetHashCode();
                if (this.PayinEnabled != null)
                    hashCode = hashCode * 59 + this.PayinEnabled.GetHashCode();
                if (this.PayinPaymentId != null)
                    hashCode = hashCode * 59 + this.PayinPaymentId.GetHashCode();
                if (this.PayinConfirmations != null)
                    hashCode = hashCode * 59 + this.PayinConfirmations.GetHashCode();
                if (this.PayoutEnabled != null)
                    hashCode = hashCode * 59 + this.PayoutEnabled.GetHashCode();
                if (this.PayoutFee != null)
                    hashCode = hashCode * 59 + this.PayoutFee.GetHashCode();
                if (this.PayoutIsPaymentId != null)
                    hashCode = hashCode * 59 + this.PayoutIsPaymentId.GetHashCode();
                if (this.Delisted != null)
                    hashCode = hashCode * 59 + this.Delisted.GetHashCode();
                if (this.TransferEnabled != null)
                    hashCode = hashCode * 59 + this.TransferEnabled.GetHashCode();
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