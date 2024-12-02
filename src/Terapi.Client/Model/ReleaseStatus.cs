using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   0 &#x3D; Released  1 &#x3D; Pending  2 &#x3D; NotPlanned
    /// </summary>
    /// <value>  0 &#x3D; Released  1 &#x3D; Pending  2 &#x3D; NotPlanned</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ReleaseStatus
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,
        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2,
        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 3    }
}
