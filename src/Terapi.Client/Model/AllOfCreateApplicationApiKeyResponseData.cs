
using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Terapi.Client.Model
{
    /// <summary>
    /// AllOfCreateApplicationApiKeyResponseData
    /// </summary>
    [DataContract]
        public partial class AllOfCreateApplicationApiKeyResponseData : ApplicationApiKeyDto,  IEquatable<AllOfCreateApplicationApiKeyResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfCreateApplicationApiKeyResponseData" /> class.
        /// </summary>
        public AllOfCreateApplicationApiKeyResponseData(string webUrl = default(string), List<string> ipAddresses = default(List<string>), string secretKey = default(string), Guid? applicationId = default(Guid?), Guid? id = default(Guid?)) : base(webUrl, ipAddresses, secretKey, applicationId, id)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfCreateApplicationApiKeyResponseData {\n");
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
            return this.Equals(input as AllOfCreateApplicationApiKeyResponseData);
        }

        /// <summary>
        /// Returns true if AllOfCreateApplicationApiKeyResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfCreateApplicationApiKeyResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfCreateApplicationApiKeyResponseData input)
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
