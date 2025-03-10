namespace com.ktgame.config.core
{
    public interface IConfigCache
    {
        void Cache(IConfigBlueprint blueprint);
        void Load(IConfigBlueprint blueprint);
    }
}