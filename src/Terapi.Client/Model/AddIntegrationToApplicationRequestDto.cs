
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// AddIntegrationToApplicationRequestDto
    /// </summary>
    [DataContract]
        public partial class AddIntegrationToApplicationRequestDto :  IEquatable<AddIntegrationToApplicationRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddIntegrationToApplicationRequestDto" /> class.
        /// </summary>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="integrationId">integrationId.</param>
        /// <param name="isPublicIntegration">isPublicIntegration.</param>
        public AddIntegrationToApplicationRequestDto(Guid? applicationId = default(Guid?), Guid? integrationId = default(Guid?), bool? isPublicIntegration = default(bool?))
        {
            this.ApplicationId = applicationId;
            this.IntegrationId = integrationId;
            this.IsPublicIntegration = isPublicIntegration;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationId
        /// </summary>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public Guid? IntegrationId { get; set; }

        /// <summary>
        /// Gets or Sets IsPublicIntegration
        /// </summary>
        [DataMember(Name="isPublicIntegration", EmitDefaultValue=false)]
        public bool? IsPublicIntegration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddIntegrationToApplicationRequestDto {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  IsPublicIntegration: ").Append(IsPublicIntegration).Append("\n");
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
            return this.Equals(input as AddIntegrationToApplicationRequestDto);
        }

        /// <summary>
        /// Returns true if AddIntegrationToApplicationRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AddIntegrationToApplicationRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddIntegrationToApplicationRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
                ) && 
                (
                    this.IsPublicIntegration == input.IsPublicIntegration ||
                    (this.IsPublicIntegration != null &&
                    this.IsPublicIntegration.Equals(input.IsPublicIntegration))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.IntegrationId != null)
                    hashCode = hashCode * 59 + this.IntegrationId.GetHashCode();
                if (this.IsPublicIntegration != null)
                    hashCode = hashCode * 59 + this.IsPublicIntegration.GetHashCode();
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
