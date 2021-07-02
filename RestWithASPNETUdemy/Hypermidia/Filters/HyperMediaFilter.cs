using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace RestWithASPNETUdemy.Hypermidia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        public readonly HyperMediaFilterOptions _hyperMediaFilterOptions;

        public HyperMediaFilter(HyperMediaFilterOptions hyperMediaFilterOptions)
        {
            _hyperMediaFilterOptions = hyperMediaFilterOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            var enricher = _hyperMediaFilterOptions.ContentReponseEnricherList.FirstOrDefault(x => x.CanEnrich(context));
        }
    }
}
