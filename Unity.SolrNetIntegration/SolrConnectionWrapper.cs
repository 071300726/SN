using SolrNet.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HttpWebAdapters;
using HttpWebAdapters.Adapters;

namespace Unity.SolrNetIntegration
{
    public class SolrConnectionWrapper : SolrConnection
    {


        public SolrConnectionWrapper(string serverURL)
            : base(serverURL)
        {
        }


        public SolrConnectionWrapper(string serverURL, IHttpWebRequestFactory httpWebRequestFactory)
            : this(serverURL)
        {
            this.HttpWebRequestFactory = httpWebRequestFactory;
        }


    }
}
