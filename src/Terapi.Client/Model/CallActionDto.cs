
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// CallActionDto
    /// </summary>
    [DataContract]
        public partial class CallActionDto :  IEquatable<CallActionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallActionDto" /> class.
        /// </summary>
        /// <param name="actionResult">actionResult.</param>
        public CallActionDto(Object actionResult = default(Object))
        {
            this.ActionResult = actionResult;
        }
        
        /// <summary>
        /// Gets or Sets ActionResult
        /// </summary>
        [DataMember(Name="actionResult", EmitDefaultValue=false)]
        public Object ActionResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallActionDto {\n");
            sb.Append("  ActionResult: ").Append(ActionResult).Append("\n");
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
            return this.Equals(input as CallActionDto);
        }

        /// <summary>
        /// Returns true if CallActionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CallActionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallActionDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionResult == input.ActionResult ||
                    (this.ActionResult != null &&
                    this.ActionResult.Equals(input.ActionResult))
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
                if (this.ActionResult != null)
                    hashCode = hashCode * 59 + this.ActionResult.GetHashCode();
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
