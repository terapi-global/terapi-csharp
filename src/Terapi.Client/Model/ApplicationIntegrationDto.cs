
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// ApplicationIntegrationDto
    /// </summary>
    [DataContract]
        public partial class ApplicationIntegrationDto :  IEquatable<ApplicationIntegrationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationIntegrationDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="application">application.</param>
        /// <param name="integration">integration.</param>
        public ApplicationIntegrationDto(Guid? id = default(Guid?), AllOfApplicationIntegrationDtoApplication application = default(AllOfApplicationIntegrationDtoApplication), AllOfApplicationIntegrationDtoIntegration integration = default(AllOfApplicationIntegrationDtoIntegration))
        {
            this.Id = id;
            this.Application = application;
            this.Integration = integration;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public AllOfApplicationIntegrationDtoApplication Application { get; set; }

        /// <summary>
        /// Gets or Sets Integration
        /// </summary>
        [DataMember(Name="integration", EmitDefaultValue=false)]
        public AllOfApplicationIntegrationDtoIntegration Integration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationIntegrationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Integration: ").Append(Integration).Append("\n");
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
            return this.Equals(input as ApplicationIntegrationDto);
        }

        /// <summary>
        /// Returns true if ApplicationIntegrationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationIntegrationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationIntegrationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Integration == input.Integration ||
                    (this.Integration != null &&
                    this.Integration.Equals(input.Integration))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.Integration != null)
                    hashCode = hashCode * 59 + this.Integration.GetHashCode();
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
