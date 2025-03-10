using System.Collections.Generic;

namespace com.ktgame.config.core
{
    public class ConfigBlueprint : IConfigBlueprint
    {
        private readonly Dictionary<string, int> _intConfigs;
        private readonly Dictionary<string, float> _floatConfigs;
        private readonly Dictionary<string, string> _stringConfigs;
        private readonly Dictionary<string, bool> _boolConfigs;

        public IEnumerable<string> IntKeys => _intConfigs.Keys;
        public IEnumerable<string> FloatKeys => _floatConfigs.Keys;
        public IEnumerable<string> StringKeys => _stringConfigs.Keys;
        public IEnumerable<string> BoolKeys => _boolConfigs.Keys;

        public ConfigBlueprint()
        {
            _intConfigs = new Dictionary<string, int>();
            _floatConfigs = new Dictionary<string, float>();
            _stringConfigs = new Dictionary<string, string>();
            _boolConfigs = new Dictionary<string, bool>();
        }

        public IConfigBlueprint SetInt(string id, int value)
        {
            if (_intConfigs.ContainsKey(id))
            {
                _intConfigs[id] = value;
                return this;
            }

            _intConfigs.Add(id, value);
            return this;
        }

        public IConfigBlueprint SetFloat(string id, float value)
        {
            if (_floatConfigs.ContainsKey(id))
            {
                _floatConfigs[id] = value;
                return this;
            }

            _floatConfigs.Add(id, value);
            return this;
        }

        public IConfigBlueprint SetString(string id, string value)
        {
            if (_stringConfigs.ContainsKey(id))
            {
                _stringConfigs[id] = value;
                return this;
            }

            _stringConfigs.Add(id, value);
            return this;
        }

        public IConfigBlueprint SetBool(string id, bool value)
        {
            if (_boolConfigs.ContainsKey(id))
            {
                _boolConfigs[id] = value;
                return this;
            }

            _boolConfigs.Add(id, value);
            return this;
        }

        public int GetInt(string key)
        {
            return _intConfigs[key];
        }

        public float GetFloat(string key)
        {
            return _floatConfigs[key];
        }

        public string GetString(string key)
        {
            return _stringConfigs[key];
        }

        public bool GetBool(string key)
        {
            return _boolConfigs[key];
        }

        public IDictionary<string, object> Export()
        {
            var configs = new Dictionary<string, object>();

            foreach (var key in IntKeys)
            {
                configs.Add(key, _intConfigs[key]);
            }

            foreach (var key in FloatKeys)
            {
                configs.Add(key, _floatConfigs[key]);
            }

            foreach (var key in StringKeys)
            {
                configs.Add(key, _stringConfigs[key]);
            }

            foreach (var key in BoolKeys)
            {
                configs.Add(key, _boolConfigs[key]);
            }

            return configs;
        }
    }
}