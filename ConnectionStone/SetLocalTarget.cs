namespace ConnectionStone
{
    public static class setLocalTarget
    {
        public static void SetLocalTarget(this IConnection c, int port)
        {
            c.target = localEndPoint.LocalEndPoint(port);
        }
    }
}