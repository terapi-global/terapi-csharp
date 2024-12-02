using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   20998101 &#x3D; ApplicationIntegrationNotFound  20998102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  20998103 &#x3D; UnknownExceptionWhenCreateTenant  20998104 &#x3D; UnknownExceptionWhenSendingEmailToInvitedEmailAddress  20998105 &#x3D; UserNotFound  20998106 &#x3D; UnknownExceptionWhenInsertApplication  20998107 &#x3D; UnknownExceptionWhenCreateUserTenant  20998108 &#x3D; UnknownExceptionWhenCreatingEmailContent  20998109 &#x3D; UnknownExceptionWhenCreatingEmailAcceptInvitationUrl  20998110 &#x3D; UnknownExceptionWhenAddingTenantInKeycloak  20998111 &#x3D; UnknownExceptionWhenAddingTenantInOrganization
    /// </summary>
    /// <value>  20998101 &#x3D; ApplicationIntegrationNotFound  20998102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  20998103 &#x3D; UnknownExceptionWhenCreateTenant  20998104 &#x3D; UnknownExceptionWhenSendingEmailToInvitedEmailAddress  20998105 &#x3D; UserNotFound  20998106 &#x3D; UnknownExceptionWhenInsertApplication  20998107 &#x3D; UnknownExceptionWhenCreateUserTenant  20998108 &#x3D; UnknownExceptionWhenCreatingEmailContent  20998109 &#x3D; UnknownExceptionWhenCreatingEmailAcceptInvitationUrl  20998110 &#x3D; UnknownExceptionWhenAddingTenantInKeycloak  20998111 &#x3D; UnknownExceptionWhenAddingTenantInOrganization</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum InviteTenantRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_20998101 for value: 20998101
        /// </summary>
        [EnumMember(Value = "20998101")]
        NUMBER_20998101 = 1,
        /// <summary>
        /// Enum NUMBER_20998102 for value: 20998102
        /// </summary>
        [EnumMember(Value = "20998102")]
        NUMBER_20998102 = 2,
        /// <summary>
        /// Enum NUMBER_20998103 for value: 20998103
        /// </summary>
        [EnumMember(Value = "20998103")]
        NUMBER_20998103 = 3,
        /// <summary>
        /// Enum NUMBER_20998104 for value: 20998104
        /// </summary>
        [EnumMember(Value = "20998104")]
        NUMBER_20998104 = 4,
        /// <summary>
        /// Enum NUMBER_20998105 for value: 20998105
        /// </summary>
        [EnumMember(Value = "20998105")]
        NUMBER_20998105 = 5,
        /// <summary>
        /// Enum NUMBER_20998106 for value: 20998106
        /// </summary>
        [EnumMember(Value = "20998106")]
        NUMBER_20998106 = 6,
        /// <summary>
        /// Enum NUMBER_20998107 for value: 20998107
        /// </summary>
        [EnumMember(Value = "20998107")]
        NUMBER_20998107 = 7,
        /// <summary>
        /// Enum NUMBER_20998108 for value: 20998108
        /// </summary>
        [EnumMember(Value = "20998108")]
        NUMBER_20998108 = 8,
        /// <summary>
        /// Enum NUMBER_20998109 for value: 20998109
        /// </summary>
        [EnumMember(Value = "20998109")]
        NUMBER_20998109 = 9,
        /// <summary>
        /// Enum NUMBER_20998110 for value: 20998110
        /// </summary>
        [EnumMember(Value = "20998110")]
        NUMBER_20998110 = 10,
        /// <summary>
        /// Enum NUMBER_20998111 for value: 20998111
        /// </summary>
        [EnumMember(Value = "20998111")]
        NUMBER_20998111 = 11    }
}
