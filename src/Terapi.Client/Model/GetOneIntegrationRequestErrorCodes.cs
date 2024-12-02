using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   17997101 &#x3D; UnknownExceptionWhenTryingFetchOneIntegration
    /// </summary>
    /// <value>  17997101 &#x3D; UnknownExceptionWhenTryingFetchOneIntegration</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum GetOneIntegrationRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_17997101 for value: 17997101
        /// </summary>
        [EnumMember(Value = "17997101")]
        NUMBER_17997101 = 1    }
}
