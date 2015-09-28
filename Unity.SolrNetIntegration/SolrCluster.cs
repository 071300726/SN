using Microsoft.Practices.Unity;
using SolrNet;
using SolrNet.Commands.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity.SolrNetIntegration
{
    public class SolrCluster<T> : ISolrOperations<T>
    {
        private IList<SolrCore> _cores;
        private IUnityContainer _container;
        private ISolrQueryEndpointLocator _solrQueryEndpointLocator;

        public SolrCluster(IUnityContainer container, IList<SolrCore> cores, ISolrQueryEndpointLocator solrQueryEndpointLocator)
        {
            _container = container;
            _cores = cores;
            _solrQueryEndpointLocator = solrQueryEndpointLocator;
        }

        
        private string GetSolrInstance(string q, QueryOptions options)
        {
            return _solrQueryEndpointLocator.GetCoreId(_cores.Select(c => c.Id).ToList(), q, options);
        }

        private ISolrOperations<T> GetSolrOperations(string name)
        {
            return _container.Resolve<ISolrOperations<T>>(name);
        }

        #region ISolrOperations
        public SolrQueryResults<T> Query(string q, SolrNet.Commands.Parameters.QueryOptions options)
        {
            return GetSolrOperations(GetSolrInstance(q, options)).Query(q, options);
        }
        #endregion


        #region ISolrOperations NotImplemented
        public ResponseHeader Commit()
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Rollback()
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Optimize()
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Add(T doc)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Add(T doc, AddParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddWithBoost(T doc, double boost)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddWithBoost(T doc, double boost, AddParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ExtractResponse Extract(ExtractParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Add(IEnumerable<T> docs)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddRange(IEnumerable<T> docs)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Add(IEnumerable<T> docs, AddParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddRange(IEnumerable<T> docs, AddParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddWithBoost(IEnumerable<KeyValuePair<T, double?>> docs)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddRangeWithBoost(IEnumerable<KeyValuePair<T, double?>> docs)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddWithBoost(IEnumerable<KeyValuePair<T, double?>> docs, AddParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader AddRangeWithBoost(IEnumerable<KeyValuePair<T, double?>> docs, AddParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(T doc)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(T doc, DeleteParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(IEnumerable<T> docs)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(IEnumerable<T> docs, DeleteParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(ISolrQuery q)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(ISolrQuery q, DeleteParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(string id, DeleteParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(IEnumerable<string> ids)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(IEnumerable<string> ids, DeleteParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(IEnumerable<string> ids, ISolrQuery q)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Delete(IEnumerable<string> ids, ISolrQuery q, DeleteParameters parameters)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader BuildSpellCheckDictionary()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SolrNet.Mapping.Validation.ValidationResult> EnumerateValidationResults()
        {
            throw new NotImplementedException();
        }

        public SolrQueryResults<T> Query(string q)
        {
            throw new NotImplementedException();
        }

        public SolrQueryResults<T> Query(string q, ICollection<SortOrder> orders)
        {
            throw new NotImplementedException();
        }


        public SolrQueryResults<T> Query(ISolrQuery q)
        {
            throw new NotImplementedException();
        }

        public SolrQueryResults<T> Query(ISolrQuery query, ICollection<SortOrder> orders)
        {
            throw new NotImplementedException();
        }

        public ICollection<KeyValuePair<string, int>> FacetFieldQuery(SolrFacetFieldQuery facets)
        {
            throw new NotImplementedException();
        }

        public SolrQueryResults<T> Query(ISolrQuery query, SolrNet.Commands.Parameters.QueryOptions options)
        {
            throw new NotImplementedException();
        }

        public SolrNet.Impl.SolrMoreLikeThisHandlerResults<T> MoreLikeThis(SolrMLTQuery query, SolrNet.Commands.Parameters.MoreLikeThisHandlerQueryOptions options)
        {
            throw new NotImplementedException();
        }

        public ResponseHeader Ping()
        {
            throw new NotImplementedException();
        }

        public SolrNet.Schema.SolrSchema GetSchema(string schemaFileName)
        {
            throw new NotImplementedException();
        }

        public SolrDIHStatus GetDIHStatus(KeyValuePair<string, string> options)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
