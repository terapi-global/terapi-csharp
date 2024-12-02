using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   17999101 &#x3D; UnknownExceptionWhenTryingFetchIntegrations
    /// </summary>
    /// <value>  17999101 &#x3D; UnknownExceptionWhenTryingFetchIntegrations</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum IntegrationListRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_17999101 for value: 17999101
        /// </summary>
        [EnumMember(Value = "17999101")]
        NUMBER_17999101 = 1    }
}
