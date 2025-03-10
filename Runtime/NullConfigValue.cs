using System;

namespace com.ktgame.config.core
{
    public class NullConfigValue : IConfigValue
    {
        private readonly object _value;
        public float Float => (float)Convert.ToDouble(_value);
        public double Double => Convert.ToDouble(_value);
        public int Int => Convert.ToInt32(_value);
        public long Long => Convert.ToInt64(_value);
        public string String => Convert.ToString(_value);
        public bool Boolean => Convert.ToBoolean(_value);

        public NullConfigValue(object value)
        {
            _value = value;
        }
    }
}