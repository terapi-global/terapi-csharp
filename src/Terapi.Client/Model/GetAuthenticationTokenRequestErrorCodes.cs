using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   23999101 &#x3D; UnknownExceptionWhenTryingFetchApplicationApiKey  23999102 &#x3D; FailedToFindApplicationApiKey  23999103 &#x3D; UnknownExceptionWhenTryingToGetUserAuthenticationToken
    /// </summary>
    /// <value>  23999101 &#x3D; UnknownExceptionWhenTryingFetchApplicationApiKey  23999102 &#x3D; FailedToFindApplicationApiKey  23999103 &#x3D; UnknownExceptionWhenTryingToGetUserAuthenticationToken</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum GetAuthenticationTokenRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_23999101 for value: 23999101
        /// </summary>
        [EnumMember(Value = "23999101")]
        NUMBER_23999101 = 1,
        /// <summary>
        /// Enum NUMBER_23999102 for value: 23999102
        /// </summary>
        [EnumMember(Value = "23999102")]
        NUMBER_23999102 = 2,
        /// <summary>
        /// Enum NUMBER_23999103 for value: 23999103
        /// </summary>
        [EnumMember(Value = "23999103")]
        NUMBER_23999103 = 3    }
}
