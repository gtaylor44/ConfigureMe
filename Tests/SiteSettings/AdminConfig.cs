using System;
using System.Runtime.Serialization;

namespace Tests.SiteSettings
{
    [Serializable]
    public enum AdminConfig
    {
        [EnumMember]BabySubscription = 1,
        [EnumMember]StandardSubscription = 2,
        [EnumMember]PremiumSubscription = 3,
        [EnumMember]PeopleWithPower = 4

    }
}
