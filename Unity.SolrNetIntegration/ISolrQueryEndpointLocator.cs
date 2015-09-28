using SolrNet;
using SolrNet.Commands.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity.SolrNetIntegration
{
    public interface ISolrQueryEndpointLocator
    {

        string GetCoreId(IList<string> coreIds, string q, QueryOptions options);
        

    }
}
