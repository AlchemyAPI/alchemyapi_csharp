using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Threading.Tasks;
using System.Net.Http;

namespace AlchemyAPI
{
    public partial class AlchemyAPI
    {
        async public Task<string> TextGetRankedNamedEntitiesAsync(string text, AlchemyAPI_EntityParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            string res = await POSTasync("TextGetRankedNamedEntities", "text", parameters);
            return res;
        }

        private async Task<String> POSTasync(string callName, string callPrefix, AlchemyAPI_BaseParams parameters)
        {
            Uri address = new Uri(_requestUri + callPrefix + "/" + callName);
            
            using (HttpClient hClient = new HttpClient())
            {
                hClient.Timeout = System.TimeSpan.FromMilliseconds(8000);
                StringBuilder d = new StringBuilder();
                d.Append("apikey=").Append(_apiKey).Append(parameters.getParameterString());
                var s = new StringContent(d.ToString());

                using (HttpResponseMessage results = await hClient.PostAsync(address, s).ConfigureAwait(false))
                {
                    String ret = await DoRequestAsync(results, parameters.getOutputMode());
                    return ret;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <param name="outputMode"></param>
        /// <returns>XML</returns>
        async private Task<String> DoRequestAsync(HttpResponseMessage response, AlchemyAPI_BaseParams.OutputMode outputMode)
        {
            string xml;
            using (StreamReader r = new StreamReader(await response.Content.ReadAsStreamAsync()))
            {
                xml = await r.ReadToEndAsync();
            }
            if (string.IsNullOrEmpty(xml))
                throw new XmlException("The API request returned back an empty response. Please verify that the url is correct.");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);

            XmlElement root = xmlDoc.DocumentElement;

            if (AlchemyAPI_BaseParams.OutputMode.XML == outputMode)
            {
                XmlNode status = root.SelectSingleNode("/results/status");

                if (status.InnerText != "OK")
                {
                    string errorMessage = "Error making API call.";

                    try
                    {
                        XmlNode statusInfo = root.SelectSingleNode("/results/statusInfo");
                        errorMessage = statusInfo.InnerText;
                    }
                    catch
                    {
                        errorMessage = "An error occurred: Unable to access XmlNode /results/statusInfo";
                    }
                    System.ApplicationException ex = new System.ApplicationException(errorMessage);

                    throw ex;
                }
            }
            else if (AlchemyAPI_BaseParams.OutputMode.RDF == outputMode)
            {
                XmlNamespaceManager nm = new XmlNamespaceManager(xmlDoc.NameTable);
                nm.AddNamespace("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#");
                nm.AddNamespace("aapi", "http://rdf.alchemyapi.com/rdf/v1/s/aapi-schema#");
                XmlNode status = root.SelectSingleNode("/rdf:RDF/rdf:Description/aapi:ResultStatus", nm);

                if (status.InnerText != "OK")
                {
                    string errorMessage = "Error making API call.";

                    try
                    {
                        XmlNode statusInfo = root.SelectSingleNode("/results/statusInfo");
                        errorMessage = statusInfo.InnerText;
                    }
                    catch
                    {
                        errorMessage = "An error occurred: Unable to access XmlNode /results/statusInfo";
                    }
                    System.ApplicationException ex = new System.ApplicationException(errorMessage);

                    throw ex;
                }
            }
            return xml;
        }
    }
}
