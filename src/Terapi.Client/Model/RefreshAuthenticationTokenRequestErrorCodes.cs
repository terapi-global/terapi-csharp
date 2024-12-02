using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   23998101 &#x3D; UnknownExceptionWhenTryingToRefreshUserAuthenticationToken
    /// </summary>
    /// <value>  23998101 &#x3D; UnknownExceptionWhenTryingToRefreshUserAuthenticationToken</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum RefreshAuthenticationTokenRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_23998101 for value: 23998101
        /// </summary>
        [EnumMember(Value = "23998101")]
        NUMBER_23998101 = 1    }
}
