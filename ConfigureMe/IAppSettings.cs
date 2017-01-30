using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureMe
{
    public interface IAppSettings
    {
        string GetString<T>(T key) where T : struct;
        string[] GetStringList<T>(T key, char delimiter) where T : struct;
        bool GetBool<T>(T key) where T : struct;
        int GetInt<T>(T key) where T : struct;
        float GetFloat<T>(T key) where T : struct;
        double GetDouble<T>(T key) where T : struct;
        decimal GetDecimal<T>(T key) where T : struct;
        Guid GetGuid<T>(T key) where T : struct;
    }
}
