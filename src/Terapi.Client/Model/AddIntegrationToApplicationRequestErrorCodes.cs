using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   18999101 &#x3D; ApplicationNotFound  18999102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  18999103 &#x3D; IntegrationNotFound  18999104 &#x3D; UnknownExceptionWhenCheckIntegrationExistence  18999105 &#x3D; UnknownExceptionWhenAddIntegrationToApplication  18999106 &#x3D; IntegrationAlreadyAddedToTheApplication  18999107 &#x3D; UnknownExceptionWhenCheckApplicationIntegrationUniqueness
    /// </summary>
    /// <value>  18999101 &#x3D; ApplicationNotFound  18999102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  18999103 &#x3D; IntegrationNotFound  18999104 &#x3D; UnknownExceptionWhenCheckIntegrationExistence  18999105 &#x3D; UnknownExceptionWhenAddIntegrationToApplication  18999106 &#x3D; IntegrationAlreadyAddedToTheApplication  18999107 &#x3D; UnknownExceptionWhenCheckApplicationIntegrationUniqueness</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum AddIntegrationToApplicationRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_18999101 for value: 18999101
        /// </summary>
        [EnumMember(Value = "18999101")]
        NUMBER_18999101 = 1,
        /// <summary>
        /// Enum NUMBER_18999102 for value: 18999102
        /// </summary>
        [EnumMember(Value = "18999102")]
        NUMBER_18999102 = 2,
        /// <summary>
        /// Enum NUMBER_18999103 for value: 18999103
        /// </summary>
        [EnumMember(Value = "18999103")]
        NUMBER_18999103 = 3,
        /// <summary>
        /// Enum NUMBER_18999104 for value: 18999104
        /// </summary>
        [EnumMember(Value = "18999104")]
        NUMBER_18999104 = 4,
        /// <summary>
        /// Enum NUMBER_18999105 for value: 18999105
        /// </summary>
        [EnumMember(Value = "18999105")]
        NUMBER_18999105 = 5,
        /// <summary>
        /// Enum NUMBER_18999106 for value: 18999106
        /// </summary>
        [EnumMember(Value = "18999106")]
        NUMBER_18999106 = 6,
        /// <summary>
        /// Enum NUMBER_18999107 for value: 18999107
        /// </summary>
        [EnumMember(Value = "18999107")]
        NUMBER_18999107 = 7    }
}
