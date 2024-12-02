using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   15998101 &#x3D; ApplicationNotFound  15998102 &#x3D; UnknownExceptionWhenFetchApplication  15998103 &#x3D; UnknownExceptionWhenInsertApplication
    /// </summary>
    /// <value>  15998101 &#x3D; ApplicationNotFound  15998102 &#x3D; UnknownExceptionWhenFetchApplication  15998103 &#x3D; UnknownExceptionWhenInsertApplication</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum UpdateApplicationRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_15998101 for value: 15998101
        /// </summary>
        [EnumMember(Value = "15998101")]
        NUMBER_15998101 = 1,
        /// <summary>
        /// Enum NUMBER_15998102 for value: 15998102
        /// </summary>
        [EnumMember(Value = "15998102")]
        NUMBER_15998102 = 2,
        /// <summary>
        /// Enum NUMBER_15998103 for value: 15998103
        /// </summary>
        [EnumMember(Value = "15998103")]
        NUMBER_15998103 = 3    }
}
