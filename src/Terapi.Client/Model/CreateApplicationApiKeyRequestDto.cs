
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// CreateApplicationApiKeyRequestDto
    /// </summary>
    [DataContract]
        public partial class CreateApplicationApiKeyRequestDto :  IEquatable<CreateApplicationApiKeyRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApplicationApiKeyRequestDto" /> class.
        /// </summary>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="ipAddresses">ipAddresses.</param>
        /// <param name="applicationId">applicationId.</param>
        public CreateApplicationApiKeyRequestDto(string webUrl = default(string), List<string> ipAddresses = default(List<string>), Guid? applicationId = default(Guid?))
        {
            this.WebUrl = webUrl;
            this.IpAddresses = ipAddresses;
            this.ApplicationId = applicationId;
        }
        
        /// <summary>
        /// Gets or Sets WebUrl
        /// </summary>
        [DataMember(Name="webUrl", EmitDefaultValue=false)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or Sets IpAddresses
        /// </summary>
        [DataMember(Name="ipAddresses", EmitDefaultValue=false)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationApiKeyRequestDto {\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
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
            return this.Equals(input as CreateApplicationApiKeyRequestDto);
        }

        /// <summary>
        /// Returns true if CreateApplicationApiKeyRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateApplicationApiKeyRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateApplicationApiKeyRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    this.IpAddresses != null &&
                    input.IpAddresses != null &&
                    this.IpAddresses.SequenceEqual(input.IpAddresses)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
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
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
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
