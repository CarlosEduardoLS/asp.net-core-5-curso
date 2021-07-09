using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermidia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
