using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   21997101 &#x3D; TenantNotFound  21997102 &#x3D; IntegrationNotFound  21997103 &#x3D; UnknownExceptionWhenCallingThirdPartyApi  21997104 &#x3D; UnknownExceptionWhenCallAction  21997105 &#x3D; IntegrationIsNotEnabled
    /// </summary>
    /// <value>  21997101 &#x3D; TenantNotFound  21997102 &#x3D; IntegrationNotFound  21997103 &#x3D; UnknownExceptionWhenCallingThirdPartyApi  21997104 &#x3D; UnknownExceptionWhenCallAction  21997105 &#x3D; IntegrationIsNotEnabled</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CallActionErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_21997101 for value: 21997101
        /// </summary>
        [EnumMember(Value = "21997101")]
        NUMBER_21997101 = 1,
        /// <summary>
        /// Enum NUMBER_21997102 for value: 21997102
        /// </summary>
        [EnumMember(Value = "21997102")]
        NUMBER_21997102 = 2,
        /// <summary>
        /// Enum NUMBER_21997103 for value: 21997103
        /// </summary>
        [EnumMember(Value = "21997103")]
        NUMBER_21997103 = 3,
        /// <summary>
        /// Enum NUMBER_21997104 for value: 21997104
        /// </summary>
        [EnumMember(Value = "21997104")]
        NUMBER_21997104 = 4,
        /// <summary>
        /// Enum NUMBER_21997105 for value: 21997105
        /// </summary>
        [EnumMember(Value = "21997105")]
        NUMBER_21997105 = 5    }
}
