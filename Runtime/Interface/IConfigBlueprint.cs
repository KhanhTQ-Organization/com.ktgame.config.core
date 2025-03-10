using System.Collections.Generic;

namespace com.ktgame.config.core
{
    public interface IConfigBlueprint
    {
        IEnumerable<string> IntKeys { get; }
        IEnumerable<string> FloatKeys { get; }
        IEnumerable<string> StringKeys { get; }
        IEnumerable<string> BoolKeys { get; }
        IConfigBlueprint SetInt(string id, int value);
        IConfigBlueprint SetFloat(string id, float value);
        IConfigBlueprint SetString(string id, string value);
        IConfigBlueprint SetBool(string id, bool value);
        int GetInt(string key);
        float GetFloat(string key);
        string GetString(string key);
        bool GetBool(string key);
        IDictionary<string, object> Export();
    }
}