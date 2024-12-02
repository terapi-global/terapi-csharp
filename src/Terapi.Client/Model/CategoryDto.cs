
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// CategoryDto
    /// </summary>
    [DataContract]
        public partial class CategoryDto :  IEquatable<CategoryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryDto" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="isParent">isParent.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="id">id.</param>
        public CategoryDto(string title = default(string), bool? isParent = default(bool?), Guid? parentId = default(Guid?), Guid? id = default(Guid?))
        {
            this.Title = title;
            this.IsParent = isParent;
            this.ParentId = parentId;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets IsParent
        /// </summary>
        [DataMember(Name="isParent", EmitDefaultValue=false)]
        public bool? IsParent { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryDto {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IsParent: ").Append(IsParent).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CategoryDto);
        }

        /// <summary>
        /// Returns true if CategoryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.IsParent == input.IsParent ||
                    (this.IsParent != null &&
                    this.IsParent.Equals(input.IsParent))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.IsParent != null)
                    hashCode = hashCode * 59 + this.IsParent.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
