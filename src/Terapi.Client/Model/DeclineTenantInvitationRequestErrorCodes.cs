using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   20996101 &#x3D; TenantNotFound  20996102 &#x3D; UnknownExceptionWhileFetchingTenant  20996103 &#x3D; UnknownExceptionWhileDecliningTenant  20996104 &#x3D; TenantIsNotInInvitedStatus  20996105 &#x3D; UnknownExceptionWhileCheckingIfTenantIsInCorrectStatus
    /// </summary>
    /// <value>  20996101 &#x3D; TenantNotFound  20996102 &#x3D; UnknownExceptionWhileFetchingTenant  20996103 &#x3D; UnknownExceptionWhileDecliningTenant  20996104 &#x3D; TenantIsNotInInvitedStatus  20996105 &#x3D; UnknownExceptionWhileCheckingIfTenantIsInCorrectStatus</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum DeclineTenantInvitationRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_20996101 for value: 20996101
        /// </summary>
        [EnumMember(Value = "20996101")]
        NUMBER_20996101 = 1,
        /// <summary>
        /// Enum NUMBER_20996102 for value: 20996102
        /// </summary>
        [EnumMember(Value = "20996102")]
        NUMBER_20996102 = 2,
        /// <summary>
        /// Enum NUMBER_20996103 for value: 20996103
        /// </summary>
        [EnumMember(Value = "20996103")]
        NUMBER_20996103 = 3,
        /// <summary>
        /// Enum NUMBER_20996104 for value: 20996104
        /// </summary>
        [EnumMember(Value = "20996104")]
        NUMBER_20996104 = 4,
        /// <summary>
        /// Enum NUMBER_20996105 for value: 20996105
        /// </summary>
        [EnumMember(Value = "20996105")]
        NUMBER_20996105 = 5    }
}
