
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// UpdateApplicationRequest
    /// </summary>
    [DataContract]
        public partial class UpdateApplicationRequest :  IEquatable<UpdateApplicationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApplicationRequest" /> class.
        /// </summary>
        /// <param name="dto">dto.</param>
        public UpdateApplicationRequest(AllOfUpdateApplicationRequestDto dto = default(AllOfUpdateApplicationRequestDto))
        {
            this.Dto = dto;
        }
        
        /// <summary>
        /// Gets or Sets Dto
        /// </summary>
        [DataMember(Name="dto", EmitDefaultValue=false)]
        public AllOfUpdateApplicationRequestDto Dto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationRequest {\n");
            sb.Append("  Dto: ").Append(Dto).Append("\n");
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
            return this.Equals(input as UpdateApplicationRequest);
        }

        /// <summary>
        /// Returns true if UpdateApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dto == input.Dto ||
                    (this.Dto != null &&
                    this.Dto.Equals(input.Dto))
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
                if (this.Dto != null)
                    hashCode = hashCode * 59 + this.Dto.GetHashCode();
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