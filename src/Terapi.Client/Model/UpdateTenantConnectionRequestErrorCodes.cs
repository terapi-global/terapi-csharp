using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   20997101 &#x3D; TenantNotFound  20997102 &#x3D; UnknownExceptionWhenCheckTenantExistence  20997103 &#x3D; UnknownExceptionWhenUpdateTenantConnection
    /// </summary>
    /// <value>  20997101 &#x3D; TenantNotFound  20997102 &#x3D; UnknownExceptionWhenCheckTenantExistence  20997103 &#x3D; UnknownExceptionWhenUpdateTenantConnection</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum UpdateTenantConnectionRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_20997101 for value: 20997101
        /// </summary>
        [EnumMember(Value = "20997101")]
        NUMBER_20997101 = 1,
        /// <summary>
        /// Enum NUMBER_20997102 for value: 20997102
        /// </summary>
        [EnumMember(Value = "20997102")]
        NUMBER_20997102 = 2,
        /// <summary>
        /// Enum NUMBER_20997103 for value: 20997103
        /// </summary>
        [EnumMember(Value = "20997103")]
        NUMBER_20997103 = 3    }
}
