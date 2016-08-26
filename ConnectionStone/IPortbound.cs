using System;
using System.Net;

namespace ConnectionStone
{
    public interface IPortBound : IDisposable
    {
        EndPoint source { get; set; }
    }
}
