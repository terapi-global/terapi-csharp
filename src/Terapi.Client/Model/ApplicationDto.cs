
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// ApplicationDto
    /// </summary>
    [DataContract]
        public partial class ApplicationDto :  IEquatable<ApplicationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDto" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="category">category.</param>
        /// <param name="officialLandingUrl">officialLandingUrl.</param>
        /// <param name="redirectBaseUrl">redirectBaseUrl.</param>
        /// <param name="privacyPolicyUrl">privacyPolicyUrl.</param>
        /// <param name="endUserLicenseAgreementUrl">endUserLicenseAgreementUrl.</param>
        /// <param name="totalIntegrations">totalIntegrations.</param>
        /// <param name="totalTenants">totalTenants.</param>
        /// <param name="totalApiCalls">totalApiCalls.</param>
        /// <param name="id">id.</param>
        public ApplicationDto(string name = default(string), string description = default(string), string category = default(string), string officialLandingUrl = default(string), string redirectBaseUrl = default(string), string privacyPolicyUrl = default(string), string endUserLicenseAgreementUrl = default(string), int? totalIntegrations = default(int?), int? totalTenants = default(int?), int? totalApiCalls = default(int?), Guid? id = default(Guid?))
        {
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.OfficialLandingUrl = officialLandingUrl;
            this.RedirectBaseUrl = redirectBaseUrl;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.EndUserLicenseAgreementUrl = endUserLicenseAgreementUrl;
            this.TotalIntegrations = totalIntegrations;
            this.TotalTenants = totalTenants;
            this.TotalApiCalls = totalApiCalls;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets OfficialLandingUrl
        /// </summary>
        [DataMember(Name="officialLandingUrl", EmitDefaultValue=false)]
        public string OfficialLandingUrl { get; set; }

        /// <summary>
        /// Gets or Sets RedirectBaseUrl
        /// </summary>
        [DataMember(Name="redirectBaseUrl", EmitDefaultValue=false)]
        public string RedirectBaseUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyPolicyUrl
        /// </summary>
        [DataMember(Name="privacyPolicyUrl", EmitDefaultValue=false)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Gets or Sets EndUserLicenseAgreementUrl
        /// </summary>
        [DataMember(Name="endUserLicenseAgreementUrl", EmitDefaultValue=false)]
        public string EndUserLicenseAgreementUrl { get; set; }

        /// <summary>
        /// Gets or Sets TotalIntegrations
        /// </summary>
        [DataMember(Name="totalIntegrations", EmitDefaultValue=false)]
        public int? TotalIntegrations { get; set; }

        /// <summary>
        /// Gets or Sets TotalTenants
        /// </summary>
        [DataMember(Name="totalTenants", EmitDefaultValue=false)]
        public int? TotalTenants { get; set; }

        /// <summary>
        /// Gets or Sets TotalApiCalls
        /// </summary>
        [DataMember(Name="totalApiCalls", EmitDefaultValue=false)]
        public int? TotalApiCalls { get; set; }

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
            sb.Append("class ApplicationDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  OfficialLandingUrl: ").Append(OfficialLandingUrl).Append("\n");
            sb.Append("  RedirectBaseUrl: ").Append(RedirectBaseUrl).Append("\n");
            sb.Append("  PrivacyPolicyUrl: ").Append(PrivacyPolicyUrl).Append("\n");
            sb.Append("  EndUserLicenseAgreementUrl: ").Append(EndUserLicenseAgreementUrl).Append("\n");
            sb.Append("  TotalIntegrations: ").Append(TotalIntegrations).Append("\n");
            sb.Append("  TotalTenants: ").Append(TotalTenants).Append("\n");
            sb.Append("  TotalApiCalls: ").Append(TotalApiCalls).Append("\n");
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
            return this.Equals(input as ApplicationDto);
        }

        /// <summary>
        /// Returns true if ApplicationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.OfficialLandingUrl == input.OfficialLandingUrl ||
                    (this.OfficialLandingUrl != null &&
                    this.OfficialLandingUrl.Equals(input.OfficialLandingUrl))
                ) && 
                (
                    this.RedirectBaseUrl == input.RedirectBaseUrl ||
                    (this.RedirectBaseUrl != null &&
                    this.RedirectBaseUrl.Equals(input.RedirectBaseUrl))
                ) && 
                (
                    this.PrivacyPolicyUrl == input.PrivacyPolicyUrl ||
                    (this.PrivacyPolicyUrl != null &&
                    this.PrivacyPolicyUrl.Equals(input.PrivacyPolicyUrl))
                ) && 
                (
                    this.EndUserLicenseAgreementUrl == input.EndUserLicenseAgreementUrl ||
                    (this.EndUserLicenseAgreementUrl != null &&
                    this.EndUserLicenseAgreementUrl.Equals(input.EndUserLicenseAgreementUrl))
                ) && 
                (
                    this.TotalIntegrations == input.TotalIntegrations ||
                    (this.TotalIntegrations != null &&
                    this.TotalIntegrations.Equals(input.TotalIntegrations))
                ) && 
                (
                    this.TotalTenants == input.TotalTenants ||
                    (this.TotalTenants != null &&
                    this.TotalTenants.Equals(input.TotalTenants))
                ) && 
                (
                    this.TotalApiCalls == input.TotalApiCalls ||
                    (this.TotalApiCalls != null &&
                    this.TotalApiCalls.Equals(input.TotalApiCalls))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.OfficialLandingUrl != null)
                    hashCode = hashCode * 59 + this.OfficialLandingUrl.GetHashCode();
                if (this.RedirectBaseUrl != null)
                    hashCode = hashCode * 59 + this.RedirectBaseUrl.GetHashCode();
                if (this.PrivacyPolicyUrl != null)
                    hashCode = hashCode * 59 + this.PrivacyPolicyUrl.GetHashCode();
                if (this.EndUserLicenseAgreementUrl != null)
                    hashCode = hashCode * 59 + this.EndUserLicenseAgreementUrl.GetHashCode();
                if (this.TotalIntegrations != null)
                    hashCode = hashCode * 59 + this.TotalIntegrations.GetHashCode();
                if (this.TotalTenants != null)
                    hashCode = hashCode * 59 + this.TotalTenants.GetHashCode();
                if (this.TotalApiCalls != null)
                    hashCode = hashCode * 59 + this.TotalApiCalls.GetHashCode();
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
