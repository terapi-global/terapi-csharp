
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// TenantUpdatetenantconnectionBody1
    /// </summary>
    [DataContract]
        public partial class TenantUpdatetenantconnectionBody1 : UpdateTenantConnectionRequest,  IEquatable<TenantUpdatetenantconnectionBody1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUpdatetenantconnectionBody1" /> class.
        /// </summary>
        public TenantUpdatetenantconnectionBody1(AllOfUpdateTenantConnectionRequestDto dto = default(AllOfUpdateTenantConnectionRequestDto)) : base(dto)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantUpdatetenantconnectionBody1 {\n");
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
            return this.Equals(input as TenantUpdatetenantconnectionBody1);
        }

        /// <summary>
        /// Returns true if TenantUpdatetenantconnectionBody1 instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantUpdatetenantconnectionBody1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantUpdatetenantconnectionBody1 input)
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
