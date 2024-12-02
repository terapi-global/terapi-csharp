using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   16998101 &#x3D; ApplicationApiKeyNotFound  16998102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  16998103 &#x3D; UnknownExceptionWhenGenerateApplicationApiKey
    /// </summary>
    /// <value>  16998101 &#x3D; ApplicationApiKeyNotFound  16998102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  16998103 &#x3D; UnknownExceptionWhenGenerateApplicationApiKey</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum RevokeApplicationApiKeyRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_16998101 for value: 16998101
        /// </summary>
        [EnumMember(Value = "16998101")]
        NUMBER_16998101 = 1,
        /// <summary>
        /// Enum NUMBER_16998102 for value: 16998102
        /// </summary>
        [EnumMember(Value = "16998102")]
        NUMBER_16998102 = 2,
        /// <summary>
        /// Enum NUMBER_16998103 for value: 16998103
        /// </summary>
        [EnumMember(Value = "16998103")]
        NUMBER_16998103 = 3    }
}
