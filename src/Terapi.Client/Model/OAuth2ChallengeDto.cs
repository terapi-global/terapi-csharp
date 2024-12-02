
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// OAuth2ChallengeDto
    /// </summary>
    [DataContract]
        public partial class OAuth2ChallengeDto :  IEquatable<OAuth2ChallengeDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2ChallengeDto" /> class.
        /// </summary>
        /// <param name="redirectUrl">redirectUrl.</param>
        /// <param name="tokens">tokens.</param>
        public OAuth2ChallengeDto(string redirectUrl = default(string), AllOfOAuth2ChallengeDtoTokens tokens = default(AllOfOAuth2ChallengeDtoTokens))
        {
            this.RedirectUrl = redirectUrl;
            this.Tokens = tokens;
        }
        
        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name="tokens", EmitDefaultValue=false)]
        public AllOfOAuth2ChallengeDtoTokens Tokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuth2ChallengeDto {\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(input as OAuth2ChallengeDto);
        }

        /// <summary>
        /// Returns true if OAuth2ChallengeDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuth2ChallengeDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuth2ChallengeDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.Tokens == input.Tokens ||
                    (this.Tokens != null &&
                    this.Tokens.Equals(input.Tokens))
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
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
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
