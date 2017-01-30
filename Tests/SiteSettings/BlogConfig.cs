using System;
using System.Runtime.Serialization;

namespace Tests.SiteSettings
{
    [Serializable]
    public enum BlogConfig
    {
        [EnumMember] MaxBlogsPerPage = 1
    }
}
