
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// UserProfileStatisticsDto
    /// </summary>
    [DataContract]
        public partial class UserProfileStatisticsDto :  IEquatable<UserProfileStatisticsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileStatisticsDto" /> class.
        /// </summary>
        /// <param name="availableIntegrations">availableIntegrations.</param>
        /// <param name="availableApiCalls">availableApiCalls.</param>
        /// <param name="applicationsCount">applicationsCount.</param>
        public UserProfileStatisticsDto(int? availableIntegrations = default(int?), int? availableApiCalls = default(int?), int? applicationsCount = default(int?))
        {
            this.AvailableIntegrations = availableIntegrations;
            this.AvailableApiCalls = availableApiCalls;
            this.ApplicationsCount = applicationsCount;
        }
        
        /// <summary>
        /// Gets or Sets AvailableIntegrations
        /// </summary>
        [DataMember(Name="availableIntegrations", EmitDefaultValue=false)]
        public int? AvailableIntegrations { get; set; }

        /// <summary>
        /// Gets or Sets AvailableApiCalls
        /// </summary>
        [DataMember(Name="availableApiCalls", EmitDefaultValue=false)]
        public int? AvailableApiCalls { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationsCount
        /// </summary>
        [DataMember(Name="applicationsCount", EmitDefaultValue=false)]
        public int? ApplicationsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileStatisticsDto {\n");
            sb.Append("  AvailableIntegrations: ").Append(AvailableIntegrations).Append("\n");
            sb.Append("  AvailableApiCalls: ").Append(AvailableApiCalls).Append("\n");
            sb.Append("  ApplicationsCount: ").Append(ApplicationsCount).Append("\n");
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
            return this.Equals(input as UserProfileStatisticsDto);
        }

        /// <summary>
        /// Returns true if UserProfileStatisticsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfileStatisticsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileStatisticsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailableIntegrations == input.AvailableIntegrations ||
                    (this.AvailableIntegrations != null &&
                    this.AvailableIntegrations.Equals(input.AvailableIntegrations))
                ) && 
                (
                    this.AvailableApiCalls == input.AvailableApiCalls ||
                    (this.AvailableApiCalls != null &&
                    this.AvailableApiCalls.Equals(input.AvailableApiCalls))
                ) && 
                (
                    this.ApplicationsCount == input.ApplicationsCount ||
                    (this.ApplicationsCount != null &&
                    this.ApplicationsCount.Equals(input.ApplicationsCount))
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
                if (this.AvailableIntegrations != null)
                    hashCode = hashCode * 59 + this.AvailableIntegrations.GetHashCode();
                if (this.AvailableApiCalls != null)
                    hashCode = hashCode * 59 + this.AvailableApiCalls.GetHashCode();
                if (this.ApplicationsCount != null)
                    hashCode = hashCode * 59 + this.ApplicationsCount.GetHashCode();
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
