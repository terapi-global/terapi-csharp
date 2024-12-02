
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// AllOfTenantDtoApplicationIntegration
    /// </summary>
    [DataContract]
        public partial class AllOfTenantDtoApplicationIntegration : ApplicationIntegrationDto,  IEquatable<AllOfTenantDtoApplicationIntegration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfTenantDtoApplicationIntegration" /> class.
        /// </summary>
        public AllOfTenantDtoApplicationIntegration(Guid? id = default(Guid?), AllOfApplicationIntegrationDtoApplication application = default(AllOfApplicationIntegrationDtoApplication), AllOfApplicationIntegrationDtoIntegration integration = default(AllOfApplicationIntegrationDtoIntegration)) : base(id, application, integration)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfTenantDtoApplicationIntegration {\n");
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
            return this.Equals(input as AllOfTenantDtoApplicationIntegration);
        }

        /// <summary>
        /// Returns true if AllOfTenantDtoApplicationIntegration instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfTenantDtoApplicationIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfTenantDtoApplicationIntegration input)
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
