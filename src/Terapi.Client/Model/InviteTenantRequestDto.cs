
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// InviteTenantRequestDto
    /// </summary>
    [DataContract]
        public partial class InviteTenantRequestDto :  IEquatable<InviteTenantRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteTenantRequestDto" /> class.
        /// </summary>
        /// <param name="invitedEmailAddress">invitedEmailAddress.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="integrationId">integrationId.</param>
        /// <param name="isPublicIntegration">isPublicIntegration.</param>
        public InviteTenantRequestDto(string invitedEmailAddress = default(string), Guid? applicationId = default(Guid?), Guid? integrationId = default(Guid?), bool? isPublicIntegration = default(bool?))
        {
            this.InvitedEmailAddress = invitedEmailAddress;
            this.ApplicationId = applicationId;
            this.IntegrationId = integrationId;
            this.IsPublicIntegration = isPublicIntegration;
        }
        
        /// <summary>
        /// Gets or Sets InvitedEmailAddress
        /// </summary>
        [DataMember(Name="invitedEmailAddress", EmitDefaultValue=false)]
        public string InvitedEmailAddress { get; set; }

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
            sb.Append("class InviteTenantRequestDto {\n");
            sb.Append("  InvitedEmailAddress: ").Append(InvitedEmailAddress).Append("\n");
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
            return this.Equals(input as InviteTenantRequestDto);
        }

        /// <summary>
        /// Returns true if InviteTenantRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteTenantRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteTenantRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvitedEmailAddress == input.InvitedEmailAddress ||
                    (this.InvitedEmailAddress != null &&
                    this.InvitedEmailAddress.Equals(input.InvitedEmailAddress))
                ) && 
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
                if (this.InvitedEmailAddress != null)
                    hashCode = hashCode * 59 + this.InvitedEmailAddress.GetHashCode();
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
