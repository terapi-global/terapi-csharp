using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   15999101 &#x3D; ApplicationNameAlreadyExist  15999102 &#x3D; UnknownExceptionWhenValidateApplicationNameUniqueness  15999103 &#x3D; UnknownExceptionWhenInsertApplication  15999104 &#x3D; UserNotFound  15999105 &#x3D; UnknownExceptionWhenCreateOrganization
    /// </summary>
    /// <value>  15999101 &#x3D; ApplicationNameAlreadyExist  15999102 &#x3D; UnknownExceptionWhenValidateApplicationNameUniqueness  15999103 &#x3D; UnknownExceptionWhenInsertApplication  15999104 &#x3D; UserNotFound  15999105 &#x3D; UnknownExceptionWhenCreateOrganization</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CreateApplicationRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_15999101 for value: 15999101
        /// </summary>
        [EnumMember(Value = "15999101")]
        NUMBER_15999101 = 1,
        /// <summary>
        /// Enum NUMBER_15999102 for value: 15999102
        /// </summary>
        [EnumMember(Value = "15999102")]
        NUMBER_15999102 = 2,
        /// <summary>
        /// Enum NUMBER_15999103 for value: 15999103
        /// </summary>
        [EnumMember(Value = "15999103")]
        NUMBER_15999103 = 3,
        /// <summary>
        /// Enum NUMBER_15999104 for value: 15999104
        /// </summary>
        [EnumMember(Value = "15999104")]
        NUMBER_15999104 = 4,
        /// <summary>
        /// Enum NUMBER_15999105 for value: 15999105
        /// </summary>
        [EnumMember(Value = "15999105")]
        NUMBER_15999105 = 5    }
}
