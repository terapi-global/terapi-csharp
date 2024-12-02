
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// AllOfRefreshAuthenticationTokenResponseData
    /// </summary>
    [DataContract]
        public partial class AllOfRefreshAuthenticationTokenResponseData : RefreshAuthenticationTokenDto,  IEquatable<AllOfRefreshAuthenticationTokenResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfRefreshAuthenticationTokenResponseData" /> class.
        /// </summary>
        public AllOfRefreshAuthenticationTokenResponseData(string accessToken = default(string), int? expiresIn = default(int?)) : base(accessToken, expiresIn)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfRefreshAuthenticationTokenResponseData {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as AllOfRefreshAuthenticationTokenResponseData);
        }

        /// <summary>
        /// Returns true if AllOfRefreshAuthenticationTokenResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfRefreshAuthenticationTokenResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfRefreshAuthenticationTokenResponseData input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
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