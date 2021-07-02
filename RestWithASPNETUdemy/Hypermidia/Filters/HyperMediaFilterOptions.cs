using RestWithASPNETUdemy.Hypermidia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermidia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentReponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
