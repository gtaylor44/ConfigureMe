#ConfigureMe
-----------------------------
Let ConfigureMe ConfigureYou. ConfigureMe provides a simple way to extract the value of config entries in web.config and app.config files in a strongly typed fashion. 


####Getting started
-----------------------------
```c#
using ConfigureMe;

  // Mockable IAppSettings Interface.
  IAppSettings appSettings = new AppSettings();
}
```
#####The name of each enumeration should match the configuration entry in app/web.config.
Store your enumerations in some configuration namespace.

e.g. BabySubscription in web.config would be:
```xml
<configuration> 
  <appSettings>
	<add key="BabySubscription" value="4.95"/>
	<add key="BlogsEnabled" value="true"/>
  </appSettings> 
</configuration>
```

```c#
[Serializable]
public enum AdminConfig
{
	[EnumMember]BabySubscription,
    [EnumMember]StandardSubscription,
    [EnumMember]PremiumSubscription,
    [EnumMember]PeopleWithPower
}

[Serializable]
public enum BlogConfig
{
	[EnumMember] BlogsEnabled
    [EnumMember] MaxBlogsPerPage
}   

[Serializable]
public enum CoreConfig
{
    [EnumMember] ServerErrorMessage
}

```

###Example usage
---------------
```c#

// If the key does not exist or the value can't be parsed, a detailed exception is raised. 
	
string errorMessage = appSettings.GetString(CoreConfig.ServerErrorMessage);

int blogsPerPage = appSettings.GetInt(BlogConfig.MaxBlogsPerPage);

decimal babySubscription = appSettings.GetDecimal(AdminConfig.BabySubscription);

bool blogsEnabled = appSettings.GetBool(BlogConfig.BlogsEnabled);

```