
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
    /// ApplicationApiKeyDto
    /// </summary>
    [DataContract]
        public partial class ApplicationApiKeyDto :  IEquatable<ApplicationApiKeyDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationApiKeyDto" /> class.
        /// </summary>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="ipAddresses">ipAddresses.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="id">id.</param>
        public ApplicationApiKeyDto(string webUrl = default(string), List<string> ipAddresses = default(List<string>), string secretKey = default(string), Guid? applicationId = default(Guid?), Guid? id = default(Guid?))
        {
            this.WebUrl = webUrl;
            this.IpAddresses = ipAddresses;
            this.SecretKey = secretKey;
            this.ApplicationId = applicationId;
            this.Id = id;
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
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name="secretKey", EmitDefaultValue=false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public Guid? ApplicationId { get; set; }

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
            sb.Append("class ApplicationApiKeyDto {\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
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
            return this.Equals(input as ApplicationApiKeyDto);
        }

        /// <summary>
        /// Returns true if ApplicationApiKeyDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationApiKeyDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationApiKeyDto input)
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
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
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
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.SecretKey != null)
                    hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
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
