using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermidia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
