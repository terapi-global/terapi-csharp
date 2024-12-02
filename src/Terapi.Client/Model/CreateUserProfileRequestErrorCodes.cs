using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   14998101 &#x3D; UnknownExceptionWhenFetchJwtUserProfile  14998102 &#x3D; UnknownExceptionWhenCreateUserProfile  14998103 &#x3D; IncorrectDataInUserJwtPayload  14998104 &#x3D; UnknownExceptionWhenSubscribeUserToFreePlan  14998105 &#x3D; UserAlreadyExistInDataStorage  14998106 &#x3D; UnknownExceptionWhenCheckUserExistence
    /// </summary>
    /// <value>  14998101 &#x3D; UnknownExceptionWhenFetchJwtUserProfile  14998102 &#x3D; UnknownExceptionWhenCreateUserProfile  14998103 &#x3D; IncorrectDataInUserJwtPayload  14998104 &#x3D; UnknownExceptionWhenSubscribeUserToFreePlan  14998105 &#x3D; UserAlreadyExistInDataStorage  14998106 &#x3D; UnknownExceptionWhenCheckUserExistence</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CreateUserProfileRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_14998101 for value: 14998101
        /// </summary>
        [EnumMember(Value = "14998101")]
        NUMBER_14998101 = 1,
        /// <summary>
        /// Enum NUMBER_14998102 for value: 14998102
        /// </summary>
        [EnumMember(Value = "14998102")]
        NUMBER_14998102 = 2,
        /// <summary>
        /// Enum NUMBER_14998103 for value: 14998103
        /// </summary>
        [EnumMember(Value = "14998103")]
        NUMBER_14998103 = 3,
        /// <summary>
        /// Enum NUMBER_14998104 for value: 14998104
        /// </summary>
        [EnumMember(Value = "14998104")]
        NUMBER_14998104 = 4,
        /// <summary>
        /// Enum NUMBER_14998105 for value: 14998105
        /// </summary>
        [EnumMember(Value = "14998105")]
        NUMBER_14998105 = 5,
        /// <summary>
        /// Enum NUMBER_14998106 for value: 14998106
        /// </summary>
        [EnumMember(Value = "14998106")]
        NUMBER_14998106 = 6    }
}
