using System;
using System.Runtime.Serialization;

namespace Tests.SiteSettings
{
    [Serializable]
    public enum CoreConfig
    {
        [EnumMember] ServerErrorMessage = 1,
        [EnumMember] ImNotInConfigFile = 2 // This key is not present in App.config by purpose for testing
    }
}
