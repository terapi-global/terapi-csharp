using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   16995101 &#x3D; ApplicationApiKeyNotFound  16995102 &#x3D; UnknownExceptionWhenTryingFetchApplications
    /// </summary>
    /// <value>  16995101 &#x3D; ApplicationApiKeyNotFound  16995102 &#x3D; UnknownExceptionWhenTryingFetchApplications</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationApiKeyByApplicationIdErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_16995101 for value: 16995101
        /// </summary>
        [EnumMember(Value = "16995101")]
        NUMBER_16995101 = 1,
        /// <summary>
        /// Enum NUMBER_16995102 for value: 16995102
        /// </summary>
        [EnumMember(Value = "16995102")]
        NUMBER_16995102 = 2    }
}
