using System;
using CipherStone;

namespace ConnectionStone
{
    public static class send
    {
        public static int Send<T>(this IConnection @this, T message, Func<T, byte[]> converter = null)
        {
            converter = converter ?? (serialize.Serialize);
            return @this.SendBytes(converter(message));
        }
    }
}
