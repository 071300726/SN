using System.Configuration;

namespace Unity.SolrNetIntegration.Config {
  public class SolrServerElement : ConfigurationElement {
    private const string ID = "id";
    private const string URL = "url";
    private const string DOCUMENT_TYPE = "documentType";
    private const string USERNAME = "username";
    private const string PASSWORD = "password";

    [ConfigurationProperty(ID, IsKey = true, IsRequired = true)]
    public string Id {
      get { return base[ID].ToString(); }
      set { base[ID] = value; }
    }

    [ConfigurationProperty(URL, IsKey = true, IsRequired = true)]
    public string Url {
      get { return base[URL].ToString(); }
      set { base[URL] = value; }
    }

    [ConfigurationProperty(DOCUMENT_TYPE, IsKey = true, IsRequired = true)]
    public string DocumentType {
      get { return base[DOCUMENT_TYPE].ToString(); }
      set { base[DOCUMENT_TYPE] = value; }
    }

    [ConfigurationProperty(USERNAME, IsKey = true, IsRequired = false)]
    public string Username
    {
        get { return base[USERNAME].ToString(); }
        set { base[USERNAME] = value; }
    }
    [ConfigurationProperty(PASSWORD, IsKey = true, IsRequired = false)]
    public string Password
    {
        get { return base[PASSWORD].ToString(); }
        set { base[PASSWORD] = value; }
    }




    public override string ToString() {
        return string.Format("Id: {0} Url: {1} DocType: {2} Username: {3} Password: {4}", Id, Url, DocumentType, Username, Password);
    }
  }
}