using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   18998 &#x3D; UnknownExceptionWhenTryingFetchApplicationIntegrations  18999 &#x3D; ApplicationNotFound
    /// </summary>
    /// <value>  18998 &#x3D; UnknownExceptionWhenTryingFetchApplicationIntegrations  18999 &#x3D; ApplicationNotFound</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ApplicationIntegrationListByApplicationIdRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_18998 for value: 18998
        /// </summary>
        [EnumMember(Value = "18998")]
        NUMBER_18998 = 1,
        /// <summary>
        /// Enum NUMBER_18999 for value: 18999
        /// </summary>
        [EnumMember(Value = "18999")]
        NUMBER_18999 = 2    }
}
