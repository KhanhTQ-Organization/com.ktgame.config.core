using System.Linq;
using UnityEngine;

namespace com.ktgame.config.core
{
    public class ConfigPlayerPrefCache : IConfigCache
    {
        #region Implement IConfigCache

        public void Cache(IConfigBlueprint blueprint)
        {
            foreach (var key in blueprint.StringKeys)
            {
                PlayerPrefs.SetString(key, blueprint.GetString(key));
            }

            foreach (var key in blueprint.IntKeys)
            {
                PlayerPrefs.SetInt(key, blueprint.GetInt(key));
            }

            foreach (var key in blueprint.FloatKeys)
            {
                PlayerPrefs.SetFloat(key, blueprint.GetFloat(key));
            }

            foreach (var key in blueprint.BoolKeys)
            {
                PlayerPrefs.SetInt(key, blueprint.GetBool(key) ? 1 : 0);
            }
            
        }

        public void Load(IConfigBlueprint blueprint)
        {
            foreach (var key in blueprint.StringKeys.ToList())
            {
                blueprint.SetString(key, PlayerPrefs.GetString(key, blueprint.GetString(key)));
            }

            foreach (var key in blueprint.IntKeys.ToList())
            {
                blueprint.SetInt(key, PlayerPrefs.GetInt(key, blueprint.GetInt(key)));
            }

            foreach (var key in blueprint.FloatKeys.ToList())
            {
                blueprint.SetFloat(key, PlayerPrefs.GetFloat(key, blueprint.GetFloat(key)));
            }

            foreach (var key in blueprint.BoolKeys.ToList())
            {
                blueprint.SetBool(key, PlayerPrefs.GetInt(key, blueprint.GetBool(key) ? 1 : 0) == 1);
            }
        }

        #endregion
    }
}