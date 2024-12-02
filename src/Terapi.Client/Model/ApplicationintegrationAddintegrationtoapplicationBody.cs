
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// ApplicationintegrationAddintegrationtoapplicationBody
    /// </summary>
    [DataContract]
        public partial class ApplicationintegrationAddintegrationtoapplicationBody : AddIntegrationToApplicationRequest,  IEquatable<ApplicationintegrationAddintegrationtoapplicationBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationintegrationAddintegrationtoapplicationBody" /> class.
        /// </summary>
        public ApplicationintegrationAddintegrationtoapplicationBody(AllOfAddIntegrationToApplicationRequestDto dto = default(AllOfAddIntegrationToApplicationRequestDto)) : base(dto)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationintegrationAddintegrationtoapplicationBody {\n");
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
            return this.Equals(input as ApplicationintegrationAddintegrationtoapplicationBody);
        }

        /// <summary>
        /// Returns true if ApplicationintegrationAddintegrationtoapplicationBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationintegrationAddintegrationtoapplicationBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationintegrationAddintegrationtoapplicationBody input)
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
