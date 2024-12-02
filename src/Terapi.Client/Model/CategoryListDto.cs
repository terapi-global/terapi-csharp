
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
    /// CategoryListDto
    /// </summary>
    [DataContract]
        public partial class CategoryListDto :  IEquatable<CategoryListDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryListDto" /> class.
        /// </summary>
        /// <param name="dtos">dtos.</param>
        public CategoryListDto(List<CategoryDto> dtos = default(List<CategoryDto>))
        {
            this.Dtos = dtos;
        }
        
        /// <summary>
        /// Gets or Sets Dtos
        /// </summary>
        [DataMember(Name="dtos", EmitDefaultValue=false)]
        public List<CategoryDto> Dtos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryListDto {\n");
            sb.Append("  Dtos: ").Append(Dtos).Append("\n");
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
            return this.Equals(input as CategoryListDto);
        }

        /// <summary>
        /// Returns true if CategoryListDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryListDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryListDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dtos == input.Dtos ||
                    this.Dtos != null &&
                    input.Dtos != null &&
                    this.Dtos.SequenceEqual(input.Dtos)
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
                if (this.Dtos != null)
                    hashCode = hashCode * 59 + this.Dtos.GetHashCode();
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
