using System;
using System.Collections.Generic;

namespace com.ktgame.config.core
{
    public class NullConfigProvider : IConfigProvider
    {
        public event Action OnFetchSuccess;
        public event Action OnFetchError;
        public event Action OnSetDefaultComplete;

        private IDictionary<string, object> _defaults;

        public IConfigValue GetValue(string id)
        {
            if (!_defaults.ContainsKey(id))
            {
                return new NullConfigValue(string.Empty);
            }

            var value = _defaults[id];
            return new NullConfigValue(value);
        }

        public void SetDefaultValues(IConfigBlueprint config)
        {
            _defaults = config.Export();
            OnSetDefaultComplete?.Invoke();
        }

        public void Fetch()
        {
            OnFetchSuccess?.Invoke();
        }
    }
}