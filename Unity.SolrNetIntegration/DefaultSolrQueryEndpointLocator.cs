using SolrNet.Impl.QuerySerializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity.SolrNetIntegration
{
    public class DefaultSolrQueryEndpointLocator : ISolrQueryEndpointLocator
    {
        public string GetCoreId(IList<string> coreIds, string q, SolrNet.Commands.Parameters.QueryOptions options)
        {
            if (coreIds == null || coreIds.Count == 0)
            {
                throw new Exception("no core abvailable");
            }


            var rnd = new Random();

            return coreIds[rnd.Next(coreIds.Count - 1)];
        }
    }
}
