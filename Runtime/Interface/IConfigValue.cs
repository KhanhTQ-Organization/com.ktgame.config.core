namespace com.ktgame.config.core
{
    public interface IConfigValue
    {
        float Float { get; }
        double Double { get; }
        int Int { get; }
        long Long { get; }
        string String { get; }
        bool Boolean { get; }
    }
}