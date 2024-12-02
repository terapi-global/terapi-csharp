using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   20999101 &#x3D; UnknownExceptionWhenTryingFetchTenants  20999102 &#x3D; UserNotFound  20999103 &#x3D; UnknownExceptionWhenInsertApplication
    /// </summary>
    /// <value>  20999101 &#x3D; UnknownExceptionWhenTryingFetchTenants  20999102 &#x3D; UserNotFound  20999103 &#x3D; UnknownExceptionWhenInsertApplication</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum UserTenantListRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_20999101 for value: 20999101
        /// </summary>
        [EnumMember(Value = "20999101")]
        NUMBER_20999101 = 1,
        /// <summary>
        /// Enum NUMBER_20999102 for value: 20999102
        /// </summary>
        [EnumMember(Value = "20999102")]
        NUMBER_20999102 = 2,
        /// <summary>
        /// Enum NUMBER_20999103 for value: 20999103
        /// </summary>
        [EnumMember(Value = "20999103")]
        NUMBER_20999103 = 3    }
}
