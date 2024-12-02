
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// TenantDto
    /// </summary>
    [DataContract]
        public partial class TenantDto :  IEquatable<TenantDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDto" /> class.
        /// </summary>
        /// <param name="providedName">providedName.</param>
        /// <param name="invitedEmailAddress">invitedEmailAddress.</param>
        /// <param name="invitationStatus">  0 &#x3D; Invited  1 &#x3D; Accepted  2 &#x3D; Declined.</param>
        /// <param name="applicationIntegration">applicationIntegration.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="webhookUrl">webhookUrl.</param>
        /// <param name="authorizedOriginUrl">authorizedOriginUrl.</param>
        /// <param name="id">id.</param>
        public TenantDto(string providedName = default(string), string invitedEmailAddress = default(string), AllOfTenantDtoInvitationStatus invitationStatus = default(AllOfTenantDtoInvitationStatus), AllOfTenantDtoApplicationIntegration applicationIntegration = default(AllOfTenantDtoApplicationIntegration), string clientSecret = default(string), string clientId = default(string), string webhookUrl = default(string), string authorizedOriginUrl = default(string), Guid? id = default(Guid?))
        {
            this.ProvidedName = providedName;
            this.InvitedEmailAddress = invitedEmailAddress;
            this.InvitationStatus = invitationStatus;
            this.ApplicationIntegration = applicationIntegration;
            this.ClientSecret = clientSecret;
            this.ClientId = clientId;
            this.WebhookUrl = webhookUrl;
            this.AuthorizedOriginUrl = authorizedOriginUrl;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets ProvidedName
        /// </summary>
        [DataMember(Name="providedName", EmitDefaultValue=false)]
        public string ProvidedName { get; set; }

        /// <summary>
        /// Gets or Sets InvitedEmailAddress
        /// </summary>
        [DataMember(Name="invitedEmailAddress", EmitDefaultValue=false)]
        public string InvitedEmailAddress { get; set; }

        /// <summary>
        ///   0 &#x3D; Invited  1 &#x3D; Accepted  2 &#x3D; Declined
        /// </summary>
        /// <value>  0 &#x3D; Invited  1 &#x3D; Accepted  2 &#x3D; Declined</value>
        [DataMember(Name="invitationStatus", EmitDefaultValue=false)]
        public AllOfTenantDtoInvitationStatus InvitationStatus { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationIntegration
        /// </summary>
        [DataMember(Name="applicationIntegration", EmitDefaultValue=false)]
        public AllOfTenantDtoApplicationIntegration ApplicationIntegration { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name="webhookUrl", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizedOriginUrl
        /// </summary>
        [DataMember(Name="authorizedOriginUrl", EmitDefaultValue=false)]
        public string AuthorizedOriginUrl { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantDto {\n");
            sb.Append("  ProvidedName: ").Append(ProvidedName).Append("\n");
            sb.Append("  InvitedEmailAddress: ").Append(InvitedEmailAddress).Append("\n");
            sb.Append("  InvitationStatus: ").Append(InvitationStatus).Append("\n");
            sb.Append("  ApplicationIntegration: ").Append(ApplicationIntegration).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  AuthorizedOriginUrl: ").Append(AuthorizedOriginUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as TenantDto);
        }

        /// <summary>
        /// Returns true if TenantDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProvidedName == input.ProvidedName ||
                    (this.ProvidedName != null &&
                    this.ProvidedName.Equals(input.ProvidedName))
                ) && 
                (
                    this.InvitedEmailAddress == input.InvitedEmailAddress ||
                    (this.InvitedEmailAddress != null &&
                    this.InvitedEmailAddress.Equals(input.InvitedEmailAddress))
                ) && 
                (
                    this.InvitationStatus == input.InvitationStatus ||
                    (this.InvitationStatus != null &&
                    this.InvitationStatus.Equals(input.InvitationStatus))
                ) && 
                (
                    this.ApplicationIntegration == input.ApplicationIntegration ||
                    (this.ApplicationIntegration != null &&
                    this.ApplicationIntegration.Equals(input.ApplicationIntegration))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
                ) && 
                (
                    this.AuthorizedOriginUrl == input.AuthorizedOriginUrl ||
                    (this.AuthorizedOriginUrl != null &&
                    this.AuthorizedOriginUrl.Equals(input.AuthorizedOriginUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ProvidedName != null)
                    hashCode = hashCode * 59 + this.ProvidedName.GetHashCode();
                if (this.InvitedEmailAddress != null)
                    hashCode = hashCode * 59 + this.InvitedEmailAddress.GetHashCode();
                if (this.InvitationStatus != null)
                    hashCode = hashCode * 59 + this.InvitationStatus.GetHashCode();
                if (this.ApplicationIntegration != null)
                    hashCode = hashCode * 59 + this.ApplicationIntegration.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.WebhookUrl != null)
                    hashCode = hashCode * 59 + this.WebhookUrl.GetHashCode();
                if (this.AuthorizedOriginUrl != null)
                    hashCode = hashCode * 59 + this.AuthorizedOriginUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
