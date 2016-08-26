namespace ConnectionStone
{
    public static class SetLocalSource
    {
        public static void setLocalSource(this IPortBound c, int port, localEndPoint.SourceStyle style = localEndPoint.SourceStyle.Private)
        {
            c.source = localEndPoint.LocalEndPoint(port, style);
        }
    }
}
