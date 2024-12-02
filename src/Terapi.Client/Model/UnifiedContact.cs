
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
    /// UnifiedContact
    /// </summary>
    [DataContract]
        public partial class UnifiedContact :  IEquatable<UnifiedContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedContact" /> class.
        /// </summary>
        /// <param name="externalId">externalId (required).</param>
        /// <param name="companyName">companyName (required).</param>
        /// <param name="companyId">companyId (required).</param>
        /// <param name="platformSource">platformSource (required).</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="phoneNumbers">phoneNumbers (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="profileUrl">profileUrl (required).</param>
        public UnifiedContact(string externalId = default(string), string companyName = default(string), string companyId = default(string), string platformSource = default(string), string firstName = default(string), string lastName = default(string), List<string> phoneNumbers = default(List<string>), string email = default(string), string profileUrl = default(string))
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new InvalidDataException("externalId is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.ExternalId = externalId;
            }
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new InvalidDataException("companyName is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.CompanyName = companyName;
            }
            // to ensure "companyId" is required (not null)
            if (companyId == null)
            {
                throw new InvalidDataException("companyId is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.CompanyId = companyId;
            }
            // to ensure "platformSource" is required (not null)
            if (platformSource == null)
            {
                throw new InvalidDataException("platformSource is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.PlatformSource = platformSource;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "phoneNumbers" is required (not null)
            if (phoneNumbers == null)
            {
                throw new InvalidDataException("phoneNumbers is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.PhoneNumbers = phoneNumbers;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "profileUrl" is required (not null)
            if (profileUrl == null)
            {
                throw new InvalidDataException("profileUrl is a required property for UnifiedContact and cannot be null");
            }
            else
            {
                this.ProfileUrl = profileUrl;
            }
        }
        
        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Gets or Sets PlatformSource
        /// </summary>
        [DataMember(Name="platformSource", EmitDefaultValue=false)]
        public string PlatformSource { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ProfileUrl
        /// </summary>
        [DataMember(Name="profileUrl", EmitDefaultValue=false)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedContact {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  PlatformSource: ").Append(PlatformSource).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
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
            return this.Equals(input as UnifiedContact);
        }

        /// <summary>
        /// Returns true if UnifiedContact instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.PlatformSource == input.PlatformSource ||
                    (this.PlatformSource != null &&
                    this.PlatformSource.Equals(input.PlatformSource))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ProfileUrl == input.ProfileUrl ||
                    (this.ProfileUrl != null &&
                    this.ProfileUrl.Equals(input.ProfileUrl))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.PlatformSource != null)
                    hashCode = hashCode * 59 + this.PlatformSource.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ProfileUrl != null)
                    hashCode = hashCode * 59 + this.ProfileUrl.GetHashCode();
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
