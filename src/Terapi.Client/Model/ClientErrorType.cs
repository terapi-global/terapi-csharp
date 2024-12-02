using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   1 &#x3D; BusinessLogic  2 &#x3D; InternalServerError
    /// </summary>
    /// <value>  1 &#x3D; BusinessLogic  2 &#x3D; InternalServerError</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ClientErrorType
    {
        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 1,
        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 2    }
}
