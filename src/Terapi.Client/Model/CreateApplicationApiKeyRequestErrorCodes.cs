using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   16999101 &#x3D; ApplicationNotFound  16999102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  16999103 &#x3D; UnknownExceptionWhenGenerateApplicationApiKey
    /// </summary>
    /// <value>  16999101 &#x3D; ApplicationNotFound  16999102 &#x3D; UnknownExceptionWhenCheckApplicationExistence  16999103 &#x3D; UnknownExceptionWhenGenerateApplicationApiKey</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum CreateApplicationApiKeyRequestErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_16999101 for value: 16999101
        /// </summary>
        [EnumMember(Value = "16999101")]
        NUMBER_16999101 = 1,
        /// <summary>
        /// Enum NUMBER_16999102 for value: 16999102
        /// </summary>
        [EnumMember(Value = "16999102")]
        NUMBER_16999102 = 2,
        /// <summary>
        /// Enum NUMBER_16999103 for value: 16999103
        /// </summary>
        [EnumMember(Value = "16999103")]
        NUMBER_16999103 = 3    }
}
