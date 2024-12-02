using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   15996101 &#x3D; UnknownExceptionWhenTryingFetchApplications  15996102 &#x3D; UserNotFound  15996103 &#x3D; UnknownExceptionWhenInsertApplication
    /// </summary>
    /// <value>  15996101 &#x3D; UnknownExceptionWhenTryingFetchApplications  15996102 &#x3D; UserNotFound  15996103 &#x3D; UnknownExceptionWhenInsertApplication</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum UserApplicationListRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_15996101 for value: 15996101
        /// </summary>
        [EnumMember(Value = "15996101")]
        NUMBER_15996101 = 1,
        /// <summary>
        /// Enum NUMBER_15996102 for value: 15996102
        /// </summary>
        [EnumMember(Value = "15996102")]
        NUMBER_15996102 = 2,
        /// <summary>
        /// Enum NUMBER_15996103 for value: 15996103
        /// </summary>
        [EnumMember(Value = "15996103")]
        NUMBER_15996103 = 3    }
}
