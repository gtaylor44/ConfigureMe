using System;
using System.Runtime.Serialization;

namespace Tests.SiteSettings
{
    [Serializable]
    public enum BlogConfig
    {
        [EnumMember] BlogsEnabled = 1,
        [EnumMember] MaxBlogsPerPage = 2
    }
}
