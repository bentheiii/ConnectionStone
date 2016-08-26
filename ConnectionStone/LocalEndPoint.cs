using System.Net;

namespace ConnectionStone
{
    public static class localEndPoint
    {
        public enum SourceStyle { Private, Public, None }
        public static EndPoint LocalEndPoint(int port, SourceStyle style = SourceStyle.Private)
        {
            switch (style)
            {
                case SourceStyle.Private:
                    return new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                case SourceStyle.Public:
                    return new IPEndPoint(IPAddress.Any, port);
                default:
                    return new IPEndPoint(IPAddress.None, port);
            }
        }
    }
}
