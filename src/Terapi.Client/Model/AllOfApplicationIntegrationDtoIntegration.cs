
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// AllOfApplicationIntegrationDtoIntegration
    /// </summary>
    [DataContract]
        public partial class AllOfApplicationIntegrationDtoIntegration : IntegrationDto,  IEquatable<AllOfApplicationIntegrationDtoIntegration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfApplicationIntegrationDtoIntegration" /> class.
        /// </summary>
        public AllOfApplicationIntegrationDtoIntegration(Guid? id = default(Guid?), string title = default(string), string nameIdentifier = default(string), string shortDescription = default(string), string icon = default(string), AllOfIntegrationDtoReleaseStatus releaseStatus = default(AllOfIntegrationDtoReleaseStatus), DateTime? launchDate = default(DateTime?), string documentationUrl = default(string), string swaggerUrl = default(string), List<IntegrationEndpointDto> integrationEndpoints = default(List<IntegrationEndpointDto>), List<IntegrationEventDto> integrationEvents = default(List<IntegrationEventDto>)) : base(id, title, nameIdentifier, shortDescription, icon, releaseStatus, launchDate, documentationUrl, swaggerUrl, integrationEndpoints, integrationEvents)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfApplicationIntegrationDtoIntegration {\n");
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
            return this.Equals(input as AllOfApplicationIntegrationDtoIntegration);
        }

        /// <summary>
        /// Returns true if AllOfApplicationIntegrationDtoIntegration instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfApplicationIntegrationDtoIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfApplicationIntegrationDtoIntegration input)
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
