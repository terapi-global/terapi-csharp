using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   19999101 &#x3D; UnknownExceptionWhenTryingFetchCategories
    /// </summary>
    /// <value>  19999101 &#x3D; UnknownExceptionWhenTryingFetchCategories</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryListRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_19999101 for value: 19999101
        /// </summary>
        [EnumMember(Value = "19999101")]
        NUMBER_19999101 = 1    }
}
