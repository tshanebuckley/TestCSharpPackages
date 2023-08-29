using System.Collections.Immutable;

namespace TestService.Serialization
{
    public static class SerializableTypes
    {
        public static HashSet<Type> Types { get; private set; } = new HashSet<Type>()
        {
            typeof(bool),
            typeof(char),
            typeof(sbyte),
            typeof(byte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(DateTime),
            typeof(string),
            typeof(BaseObject)
        };

    }
}
