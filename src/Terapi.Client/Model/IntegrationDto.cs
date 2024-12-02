
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
    /// IntegrationDto
    /// </summary>
    [DataContract]
        public partial class IntegrationDto :  IEquatable<IntegrationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="nameIdentifier">nameIdentifier.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="icon">icon.</param>
        /// <param name="releaseStatus">  0 &#x3D; Released  1 &#x3D; Pending  2 &#x3D; NotPlanned.</param>
        /// <param name="launchDate">launchDate.</param>
        /// <param name="documentationUrl">documentationUrl.</param>
        /// <param name="swaggerUrl">swaggerUrl.</param>
        /// <param name="integrationEndpoints">integrationEndpoints.</param>
        /// <param name="integrationEvents">integrationEvents.</param>
        public IntegrationDto(Guid? id = default(Guid?), string title = default(string), string nameIdentifier = default(string), string shortDescription = default(string), string icon = default(string), AllOfIntegrationDtoReleaseStatus releaseStatus = default(AllOfIntegrationDtoReleaseStatus), DateTime? launchDate = default(DateTime?), string documentationUrl = default(string), string swaggerUrl = default(string), List<IntegrationEndpointDto> integrationEndpoints = default(List<IntegrationEndpointDto>), List<IntegrationEventDto> integrationEvents = default(List<IntegrationEventDto>))
        {
            this.Id = id;
            this.Title = title;
            this.NameIdentifier = nameIdentifier;
            this.ShortDescription = shortDescription;
            this.Icon = icon;
            this.ReleaseStatus = releaseStatus;
            this.LaunchDate = launchDate;
            this.DocumentationUrl = documentationUrl;
            this.SwaggerUrl = swaggerUrl;
            this.IntegrationEndpoints = integrationEndpoints;
            this.IntegrationEvents = integrationEvents;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets NameIdentifier
        /// </summary>
        [DataMember(Name="nameIdentifier", EmitDefaultValue=false)]
        public string NameIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name="shortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        ///   0 &#x3D; Released  1 &#x3D; Pending  2 &#x3D; NotPlanned
        /// </summary>
        /// <value>  0 &#x3D; Released  1 &#x3D; Pending  2 &#x3D; NotPlanned</value>
        [DataMember(Name="releaseStatus", EmitDefaultValue=false)]
        public AllOfIntegrationDtoReleaseStatus ReleaseStatus { get; set; }

        /// <summary>
        /// Gets or Sets LaunchDate
        /// </summary>
        [DataMember(Name="launchDate", EmitDefaultValue=false)]
        public DateTime? LaunchDate { get; set; }

        /// <summary>
        /// Gets or Sets DocumentationUrl
        /// </summary>
        [DataMember(Name="documentationUrl", EmitDefaultValue=false)]
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// Gets or Sets SwaggerUrl
        /// </summary>
        [DataMember(Name="swaggerUrl", EmitDefaultValue=false)]
        public string SwaggerUrl { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationEndpoints
        /// </summary>
        [DataMember(Name="integrationEndpoints", EmitDefaultValue=false)]
        public List<IntegrationEndpointDto> IntegrationEndpoints { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationEvents
        /// </summary>
        [DataMember(Name="integrationEvents", EmitDefaultValue=false)]
        public List<IntegrationEventDto> IntegrationEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  NameIdentifier: ").Append(NameIdentifier).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  ReleaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  LaunchDate: ").Append(LaunchDate).Append("\n");
            sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
            sb.Append("  SwaggerUrl: ").Append(SwaggerUrl).Append("\n");
            sb.Append("  IntegrationEndpoints: ").Append(IntegrationEndpoints).Append("\n");
            sb.Append("  IntegrationEvents: ").Append(IntegrationEvents).Append("\n");
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
            return this.Equals(input as IntegrationDto);
        }

        /// <summary>
        /// Returns true if IntegrationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationDto input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.NameIdentifier == input.NameIdentifier ||
                    (this.NameIdentifier != null &&
                    this.NameIdentifier.Equals(input.NameIdentifier))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.ReleaseStatus == input.ReleaseStatus ||
                    (this.ReleaseStatus != null &&
                    this.ReleaseStatus.Equals(input.ReleaseStatus))
                ) && 
                (
                    this.LaunchDate == input.LaunchDate ||
                    (this.LaunchDate != null &&
                    this.LaunchDate.Equals(input.LaunchDate))
                ) && 
                (
                    this.DocumentationUrl == input.DocumentationUrl ||
                    (this.DocumentationUrl != null &&
                    this.DocumentationUrl.Equals(input.DocumentationUrl))
                ) && 
                (
                    this.SwaggerUrl == input.SwaggerUrl ||
                    (this.SwaggerUrl != null &&
                    this.SwaggerUrl.Equals(input.SwaggerUrl))
                ) && 
                (
                    this.IntegrationEndpoints == input.IntegrationEndpoints ||
                    this.IntegrationEndpoints != null &&
                    input.IntegrationEndpoints != null &&
                    this.IntegrationEndpoints.SequenceEqual(input.IntegrationEndpoints)
                ) && 
                (
                    this.IntegrationEvents == input.IntegrationEvents ||
                    this.IntegrationEvents != null &&
                    input.IntegrationEvents != null &&
                    this.IntegrationEvents.SequenceEqual(input.IntegrationEvents)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.NameIdentifier != null)
                    hashCode = hashCode * 59 + this.NameIdentifier.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.ReleaseStatus != null)
                    hashCode = hashCode * 59 + this.ReleaseStatus.GetHashCode();
                if (this.LaunchDate != null)
                    hashCode = hashCode * 59 + this.LaunchDate.GetHashCode();
                if (this.DocumentationUrl != null)
                    hashCode = hashCode * 59 + this.DocumentationUrl.GetHashCode();
                if (this.SwaggerUrl != null)
                    hashCode = hashCode * 59 + this.SwaggerUrl.GetHashCode();
                if (this.IntegrationEndpoints != null)
                    hashCode = hashCode * 59 + this.IntegrationEndpoints.GetHashCode();
                if (this.IntegrationEvents != null)
                    hashCode = hashCode * 59 + this.IntegrationEvents.GetHashCode();
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
