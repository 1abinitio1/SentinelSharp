using System.Collections;
using System.Collections.Generic;

namespace SentinelSharp
{
    public class SentinelSearch
    {
        public System.Net.WebClient WebClient;// = new System.Net.WebClient();

        string name;
        string pass;
        string hub = "https://scihub.copernicus.eu/dhus/search?q=";
        string sp5hub = "https://s5phub.copernicus.eu/dhus/search?q=";

        public void InitWebClient(string Name, string Password)
        {
            WebClient = new System.Net.WebClient();
            name = Name;
            pass = Password;
            WebClient.Credentials = new System.Net.NetworkCredential(name, pass);
        }

        public ProductInfo[] Search(string Querry, int page, int rows = 100)
        {
            string search = hub + Querry + "&rows=" + rows + "&start=" + (page * rows);
            string data = WebClient.DownloadString(search);
            
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.LoadXml(data);

            
            return ParseSearch(xmlDoc);
        }

        /// <summary>
        /// Searches the s5 precersor data
        /// </summary>
        /// <param name="Querry"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ProductInfo[] Sp5Search(string Querry, int page, int rows = 100)
        {
            string search = hub + Querry + "&rows=" + rows + "&start=" + (page * rows);
            string data = WebClient.DownloadString(search);
            
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.LoadXml(data);

            return ParseSearch(xmlDoc);
        }

        public ProductInfo[] ParseSearch(System.Xml.XmlDocument xmlDocument)
        {
            System.Xml.XmlNode xmlNode = xmlDocument.ChildNodes[1];

            List<ProductInfo> data = new List<ProductInfo>();

            for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
            {
                if (xmlNode.ChildNodes[i].Name == "entry")
                {
                    data.Add(ParseEntry(xmlNode.ChildNodes[i]));
                }
            }
            return data.ToArray();
        }

        ProductInfo ParseEntry(System.Xml.XmlNode xmlNode)
        {
            ProductInfo productInfo = new ProductInfo();
            for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
            {
                if (xmlNode.ChildNodes[i].OuterXml.Contains("<link rel=\"icon\" href=\""))
                {
                    productInfo.PreviewLink = xmlNode.ChildNodes[i].OuterXml.Substring(23, xmlNode.ChildNodes[i].OuterXml.Length - 63);
                }

                if (xmlNode.ChildNodes[i].OuterXml.Contains("<id xmlns=\"http://www.w3.org/2005/Atom\">"))
                {
                    productInfo.Id = xmlNode.ChildNodes[i].OuterXml.Substring(40, xmlNode.ChildNodes[i].OuterXml.Length - 45);
                }

                if (xmlNode.ChildNodes[i].OuterXml.Contains("<link href=\""))
                {
                    productInfo.FullDataLink = xmlNode.ChildNodes[i].OuterXml.Substring(12, xmlNode.ChildNodes[i].OuterXml.Length - 52);
                }
            }
            return productInfo;
        }

        public string BuildQuerry(BaseSearchFilter[] searchFilters)
        {
            if (searchFilters.Length == 0)
            {
                return "";
            }
            string querry = searchFilters[0].Build();

            for (int i = 1; i < searchFilters.Length; i++)
            {
                querry += " AND " + searchFilters[i].Build();
            }

            return querry;

        }
    }
}
