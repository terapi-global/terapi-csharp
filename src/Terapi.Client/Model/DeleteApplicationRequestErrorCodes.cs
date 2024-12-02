using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   15997101 &#x3D; ApplicationNotFound  15997102 &#x3D; UnknownExceptionWhenFetchApplicationExistence  15997103 &#x3D; UnknownExceptionWhenDeleteApplication
    /// </summary>
    /// <value>  15997101 &#x3D; ApplicationNotFound  15997102 &#x3D; UnknownExceptionWhenFetchApplicationExistence  15997103 &#x3D; UnknownExceptionWhenDeleteApplication</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum DeleteApplicationRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_15997101 for value: 15997101
        /// </summary>
        [EnumMember(Value = "15997101")]
        NUMBER_15997101 = 1,
        /// <summary>
        /// Enum NUMBER_15997102 for value: 15997102
        /// </summary>
        [EnumMember(Value = "15997102")]
        NUMBER_15997102 = 2,
        /// <summary>
        /// Enum NUMBER_15997103 for value: 15997103
        /// </summary>
        [EnumMember(Value = "15997103")]
        NUMBER_15997103 = 3    }
}
