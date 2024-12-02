using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Terapi.Client.Model
{
    /// <summary>
    ///   14997101 &#x3D; UserNotFound  14997102 &#x3D; UserDoesNotHaveActiveSubscription  14997103 &#x3D; UnknownExceptionWhenFetchUserProfileStatistics
    /// </summary>
    /// <value>  14997101 &#x3D; UserNotFound  14997102 &#x3D; UserDoesNotHaveActiveSubscription  14997103 &#x3D; UnknownExceptionWhenFetchUserProfileStatistics</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum UserProfileStatisticsErrorCodes
    {
        /// <summary>
        /// Enum NUMBER_14997101 for value: 14997101
        /// </summary>
        [EnumMember(Value = "14997101")]
        NUMBER_14997101 = 1,
        /// <summary>
        /// Enum NUMBER_14997102 for value: 14997102
        /// </summary>
        [EnumMember(Value = "14997102")]
        NUMBER_14997102 = 2,
        /// <summary>
        /// Enum NUMBER_14997103 for value: 14997103
        /// </summary>
        [EnumMember(Value = "14997103")]
        NUMBER_14997103 = 3    }
}
