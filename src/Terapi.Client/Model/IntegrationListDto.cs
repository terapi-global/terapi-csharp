
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// IntegrationListDto
    /// </summary>
    [DataContract]
        public partial class IntegrationListDto :  IEquatable<IntegrationListDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationListDto" /> class.
        /// </summary>
        /// <param name="totalRecords">totalRecords (required).</param>
        /// <param name="currentPage">currentPage (required).</param>
        /// <param name="perPage">perPage (required).</param>
        /// <param name="items">items (required).</param>
        public IntegrationListDto(int? totalRecords = default(int?), int? currentPage = default(int?), int? perPage = default(int?), List<IntegrationDto> items = default(List<IntegrationDto>))
        {
            // to ensure "totalRecords" is required (not null)
            if (totalRecords == null)
            {
                throw new InvalidDataException("totalRecords is a required property for IntegrationListDto and cannot be null");
            }
            else
            {
                this.TotalRecords = totalRecords;
            }
            // to ensure "currentPage" is required (not null)
            if (currentPage == null)
            {
                throw new InvalidDataException("currentPage is a required property for IntegrationListDto and cannot be null");
            }
            else
            {
                this.CurrentPage = currentPage;
            }
            // to ensure "perPage" is required (not null)
            if (perPage == null)
            {
                throw new InvalidDataException("perPage is a required property for IntegrationListDto and cannot be null");
            }
            else
            {
                this.PerPage = perPage;
            }
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new InvalidDataException("items is a required property for IntegrationListDto and cannot be null");
            }
            else
            {
                this.Items = items;
            }
        }
        
        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name="perPage", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<IntegrationDto> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationListDto {\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as IntegrationListDto);
        }

        /// <summary>
        /// Returns true if IntegrationListDto instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationListDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationListDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalRecords == input.TotalRecords ||
                    (this.TotalRecords != null &&
                    this.TotalRecords.Equals(input.TotalRecords))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.TotalRecords != null)
                    hashCode = hashCode * 59 + this.TotalRecords.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
