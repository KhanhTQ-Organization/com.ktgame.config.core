using System;

namespace com.ktgame.config.core
{
    public interface IConfigProvider
    {
        event Action OnFetchSuccess;
        event Action OnFetchError;
        event Action OnSetDefaultComplete;
        IConfigValue GetValue(string id);
        void SetDefaultValues(IConfigBlueprint config);
        void Fetch();
    }
}