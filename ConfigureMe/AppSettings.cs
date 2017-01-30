using System;
using System.Collections.Generic;
using System.Configuration;

namespace ConfigureMe
{
    /// <summary>
    /// Provides helper methods to extract values from appSettings. Requires ConfigurationManager  
    /// </summary>
    public class AppSettings : IAppSettings
    {
        public string GetString<T>(T key) where T : struct
        {
            string setting = GetSetting(key);

            return setting;
        }

        public bool GetBool<T>(T key) where T : struct
        {
            string setting = GetSetting(key);

            bool result;

            if (bool.TryParse(setting, out result))
            {
                return result;
            }

            throw new InvalidOperationException($"App key {key} is not a true/false value");
        }

        /// <summary>
        /// Returns a list of strings that are delimited on a given character. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public string[] GetStringList<T>(T key, char delimiter) where T : struct
        {
            string setting = GetSetting(key);

            return setting.Replace(" ", string.Empty).Split(delimiter);
        }

        public int GetInt<T>(T key) where T : struct
        {
            string setting = GetSetting(key);

            int result;

            if (int.TryParse(setting, out result))
            {
                return result;
            }

            throw new InvalidOperationException("Could not parse integer in AppSettings");
        }

        public float GetFloat<T>(T key) where T : struct
        {
            string setting = GetSetting(key);

            float result;

            if (float.TryParse(setting, out result))
            {
                return result;
            }

            throw new InvalidOperationException("Could not parse float in AppSettings");
        }

        public decimal GetDecimal<T>(T key) where T : struct
        {
            string setting = GetSetting(key);

            decimal result;

            if (decimal.TryParse(setting, out result))
            {
                return result;
            }

            throw new InvalidOperationException("Could not parse decimal in AppSettings");
        }

        public double GetDouble<T>(T key) where T : struct
        {
            string setting = GetSetting(key);

            double result;

            if (double.TryParse(setting, out result))
            {
                return result;
            }

            throw new InvalidOperationException("Could not parse double in AppSettings");
        }

        public Guid GetGuid<T>(T key) where T : struct
        {
            string setting = GetSetting(key);

            Guid result;

            if (Guid.TryParse(setting, out result))
            {
                return result;
            }

            throw new InvalidOperationException("Could not parse Guid in AppSettings");
        }
        public string GetSetting<T>(T key)
        {
            if (!typeof(T).IsEnum) throw new NotSupportedException();

            string setting = ConfigurationManager.AppSettings[key.ToString()];

            if (setting == null)
            {
                throw new KeyNotFoundException($"App key {key} is null for this environment. Check that the key exists in config file including its targetted environment.");
            }

            return setting;
        }
    }
}
