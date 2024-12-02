
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// UnifiedContactsListResponse
    /// </summary>
    [DataContract]
        public partial class UnifiedContactsListResponse :  IEquatable<UnifiedContactsListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedContactsListResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="error">error.</param>
        public UnifiedContactsListResponse(bool? success = default(bool?), AllOfUnifiedContactsListResponseError error = default(AllOfUnifiedContactsListResponseError))
        {
            this.Success = success;
            this.Error = error;
        }
        
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public AllOfUnifiedContactsListResponseData Data { get; private set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public AllOfUnifiedContactsListResponseError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedContactsListResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as UnifiedContactsListResponse);
        }

        /// <summary>
        /// Returns true if UnifiedContactsListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedContactsListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedContactsListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
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