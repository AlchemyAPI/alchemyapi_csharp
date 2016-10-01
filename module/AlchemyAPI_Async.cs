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
        #region GetAuthor
        async public Task<string> URLGetAuthorAsync(string url)
        {
            CheckURL(url);

            return await URLGetAuthorAsync(url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> URLGetAuthorAsync(string url, AlchemyAPI_BaseParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetAuthor", "url", parameters);
        }

       async  public Task<string> HTMLGetAuthorAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetAuthorAsync(html, url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> HTMLGetAuthorAsync(string html, string url, AlchemyAPI_BaseParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetAuthor", "html", parameters);
        }
        #endregion

        #region GetRankedNamedEntities
        async public Task<string> URLGetRankedNamedEntitiesAsync(string url)
        {
            CheckURL(url);

            return await URLGetRankedNamedEntitiesAsync(url, new AlchemyAPI_EntityParams());
        }

        async public Task<string> URLGetRankedNamedEntitiesAsync(string url, AlchemyAPI_EntityParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetRankedNamedEntities", "url", parameters);
        }

        async public Task<string> HTMLGetRankedNamedEntities(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetRankedNamedEntitiesAsync(html, url, new AlchemyAPI_EntityParams());
        }


        async public Task<string> HTMLGetRankedNamedEntitiesAsync(string html, string url, AlchemyAPI_EntityParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetRankedNamedEntities", "html", parameters);
        }
        async public Task<string> TextGetRankedNamedEntitiesAsync(string text, AlchemyAPI_EntityParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            string res = await POSTAsync("TextGetRankedNamedEntities", "text", parameters);
            return res;
        }
        #endregion

        #region GetRankedConcepts
        async public Task<string> URLGetRankedConceptsAsync(string url)
        {
            CheckURL(url);

            return await URLGetRankedConceptsAsync(url, new AlchemyAPI_ConceptParams());
        }

        async public Task<string> URLGetRankedConceptsAsync(string url, AlchemyAPI_ConceptParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetRankedConcepts", "url", parameters);
        }

        async public Task<string> HTMLGetRankedConceptsAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetRankedConceptsAsync(html, url, new AlchemyAPI_ConceptParams());
        }

        async public Task<string> HTMLGetRankedConceptsAsync(string html, string url, AlchemyAPI_ConceptParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetRankedConcepts", "html", parameters);
        }

        async public Task<string> TextGetRankedConceptsAsync(string text)
        {
            CheckText(text);

            return await TextGetRankedConceptsAsync(text, new AlchemyAPI_ConceptParams());
        }

        async public Task<string> TextGetRankedConceptsAsync(string text, AlchemyAPI_ConceptParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetRankedConcepts", "text", parameters);
        }
        #endregion

        #region GetRankedKeywords
        async public Task<string> URLGetRankedKeywordsAsync(string url)
        {
            CheckURL(url);

            return await URLGetRankedKeywordsAsync(url, new AlchemyAPI_KeywordParams());
        }

        async public Task<string> URLGetRankedKeywordsAsync(string url, AlchemyAPI_KeywordParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetRankedKeywords", "url", parameters);
        }

        async public Task<string> HTMLGetRankedKeywordsAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetRankedKeywordsAsync(html, url, new AlchemyAPI_KeywordParams());
        }

        async public Task<string> HTMLGetRankedKeywordsAsync(string html, string url, AlchemyAPI_KeywordParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetRankedKeywords", "html", parameters);
        }

        async public Task<string> TextGetRankedKeywordsAsync(string text)
        {
            CheckText(text);

            return await TextGetRankedKeywordsAsync(text, new AlchemyAPI_KeywordParams());
        }

        async public Task<string> TextGetRankedKeywordsAsync(string text, AlchemyAPI_KeywordParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetRankedKeywords", "text", parameters);
        }
        #endregion

        #region GetLanguage
        async public Task<string> URLGetLanguageAsync(string url)
        {
            CheckURL(url);

            return await URLGetLanguageAsync(url, new AlchemyAPI_LanguageParams());
        }

        async public Task<string> URLGetLanguageAsync(string url, AlchemyAPI_LanguageParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetLanguage", "url", parameters);
        }

        async public Task<string> HTMLGetLanguageAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetLanguageAsync(html, url, new AlchemyAPI_LanguageParams());
        }

        async public Task<string> HTMLGetLanguageAsync(string html, string url, AlchemyAPI_LanguageParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetLanguage", "html", parameters);
        }

        async public Task<string> TextGetLanguageAsync(string text)
        {
            CheckText(text);

            return await TextGetLanguageAsync(text, new AlchemyAPI_LanguageParams());
        }

        async public Task<string> TextGetLanguageAsync(string text, AlchemyAPI_LanguageParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetLanguage", "text", parameters);
        }
        #endregion

        #region GetCategory
        async public Task<string> URLGetCategoryAsync(string url)
        {
            CheckURL(url);

            return await URLGetCategoryAsync(url, new AlchemyAPI_CategoryParams());
        }

        async public Task<string> URLGetCategoryAsync(string url, AlchemyAPI_CategoryParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetCategory", "url", parameters);
        }

        async public Task<string> HTMLGetCategoryAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetCategoryAsync(html, url, new AlchemyAPI_CategoryParams());
        }

        async public Task<string> HTMLGetCategoryAsync(string html, string url, AlchemyAPI_CategoryParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetCategory", "html", parameters);
        }

        async public Task<string> TextGetCategoryAsync(string text)
        {
            CheckText(text);

            return await TextGetCategoryAsync(text, new AlchemyAPI_CategoryParams());
        }

        async public Task<string> TextGetCategoryAsync(string text, AlchemyAPI_CategoryParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetCategory", "text", parameters);
        }
        #endregion

        #region GetText
        async public Task<string> URLGetTextAsync(string url)
        {
            CheckURL(url);

            return await URLGetTextAsync(url, new AlchemyAPI_TextParams());
        }

        async public Task<string> URLGetTextAsync(string url, AlchemyAPI_TextParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetText", "url", parameters);
        }

        async public Task<string> HTMLGetTextAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetTextAsync(html, url, new AlchemyAPI_TextParams());
        }

        async public Task<string> HTMLGetTextAsync(string html, string url, AlchemyAPI_TextParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetText", "html", parameters);
        }
        #endregion

        #region GetRawText
        async public Task<string> URLGetRawTextAsync(string url)
        {
            CheckURL(url);

            return await URLGetRawTextAsync(url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> URLGetRawTextAsync(string url, AlchemyAPI_BaseParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetRawText", "url", parameters);
        }

        async public Task<string> HTMLGetRawTextAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetRawTextAsync(html, url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> HTMLGetRawTextAsync(string html, string url, AlchemyAPI_BaseParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetRawText", "html", parameters);
        }
        #endregion

        #region GetTitle
        async public Task<string> URLGetTitleAsync(string url)
        {
            CheckURL(url);

            return await URLGetTitleAsync(url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> URLGetTitleAsync(string url, AlchemyAPI_BaseParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetTitle", "url", parameters);
        }

        async public Task<string> HTMLGetTitleAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetTitleAsync(html, url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> HTMLGetTitleAsync(string html, string url, AlchemyAPI_BaseParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetTitle", "html", parameters);
        }
        #endregion

        #region GetFeedLinks
        async public Task<string> URLGetFeedLinksAsync(string url)
        {
            CheckURL(url);

            return await URLGetFeedLinksAsync(url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> URLGetFeedLinksAsync(string url, AlchemyAPI_BaseParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetFeedLinks", "url", parameters);
        }

        async public Task<string> HTMLGetFeedLinksAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetFeedLinksAsync(html, url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> HTMLGetFeedLinksAsync(string html, string url, AlchemyAPI_BaseParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetFeedLinks", "html", parameters);
        }
        #endregion

        #region GetMicroformats
        async public Task<string> URLGetMicroformatsAsync(string url)
        {
            CheckURL(url);

            return await URLGetMicroformatsAsync(url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> URLGetMicroformatsAsync(string url, AlchemyAPI_BaseParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetMicroformatData", "url", parameters);
        }

        async public Task<string> HTMLGetMicroformatsAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetMicroformatsAsync(html, url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> HTMLGetMicroformatsAsync(string html, string url, AlchemyAPI_BaseParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetMicroformatData", "html", parameters);
        }
        #endregion

        #region GetConstraintQuery
        async public Task<string> URLGetConstraintQueryAsync(string url, string query)
        {
            CheckURL(url);
            if (query.Length < 2)
            {
                System.ApplicationException ex =
                    new System.ApplicationException("Invalid constraint query specified.");

                throw ex;
            }

            AlchemyAPI_ConstraintQueryParams cqParams = new AlchemyAPI_ConstraintQueryParams();
            cqParams.setCQuery(query);

            return await URLGetConstraintQueryAsync(url, cqParams);
        }

        async public Task<string> URLGetConstraintQueryAsync(string url, AlchemyAPI_ConstraintQueryParams parameters)
        {
            CheckURL(url);
            if (parameters.getCQuery().Length < 2)
            {
                System.ApplicationException ex =
                    new System.ApplicationException("Invalid constraint query specified.");

                throw ex;
            }

            parameters.setUrl(url);

            return await POSTAsync("URLGetConstraintQuery", "url", parameters);
        }

        async public Task<string> HTMLGetConstraintQueryAsync(string html, string url, string query)
        {
            CheckHTML(html, url);
            if (query.Length < 2)
            {
                System.ApplicationException ex =
                    new System.ApplicationException("Invalid constraint query specified.");

                throw ex;
            }

            AlchemyAPI_ConstraintQueryParams cqParams = new AlchemyAPI_ConstraintQueryParams();
            cqParams.setCQuery(query);

            return await HTMLGetConstraintQueryAsync(html, url, cqParams);
        }

        async public Task<string> HTMLGetConstraintQueryAsync(string html, string url, AlchemyAPI_ConstraintQueryParams parameters)
        {
            CheckHTML(html, url);
            if (parameters.getCQuery().Length < 2)
            {
                System.ApplicationException ex =
                    new System.ApplicationException("Invalid constraint query specified.");

                throw ex;
            }

            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetConstraintQuery", "html", parameters);
        }
        #endregion

        #region GetTextSentiment
        async public Task<string> URLGetTextSentimentAsync(string url)
        {
            CheckURL(url);

            return await URLGetTextSentimentAsync(url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> URLGetTextSentimentAsync(string url, AlchemyAPI_BaseParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetTextSentiment", "url", parameters);
        }

        async public Task<string> HTMLGetTextSentimentAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetTextSentimentAsync(html, url, new AlchemyAPI_BaseParams());
        }

        async public Task<string> HTMLGetTextSentimentAsync(string html, string url, AlchemyAPI_BaseParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetTextSentiment", "html", parameters);
        }

        async public Task<string> TextGetTextSentimentAsync(string text)
        {
            CheckText(text);

            return await TextGetTextSentimentAsync(text, new AlchemyAPI_BaseParams());
        }

        async public Task<string> TextGetTextSentimentAsync(string text, AlchemyAPI_BaseParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetTextSentiment", "text", parameters);
        }
        #endregion

        #region GetTargetedSentiment
        async public Task<string> URLGetTargetedSentimentAsync(string url, string target)
        {
            CheckURL(url);
            CheckText(target);

            return await URLGetTargetedSentimentAsync(url, target, new AlchemyAPI_TargetedSentimentParams());
        }

        async public Task<string> URLGetTargetedSentimentAsync(string url, string target, AlchemyAPI_TargetedSentimentParams parameters)
        {
            CheckURL(url);
            CheckText(target);

            parameters.setUrl(url);
            parameters.setTarget(target);

            return await GETAsync("URLGetTargetedSentiment", "url", parameters);
        }

        async public Task<string> HTMLGetTargetedSentimentAsync(string html, string url, string target)
        {
            CheckHTML(html, url);
            CheckText(target);

            return await HTMLGetTargetedSentimentAsync(html, url, target, new AlchemyAPI_TargetedSentimentParams());
        }

        async public Task<string> HTMLGetTargetedSentimentAsync(string html, string url, string target, AlchemyAPI_TargetedSentimentParams parameters)
        {

            CheckHTML(html, url);
            CheckText(target);

            parameters.setHtml(html);
            parameters.setUrl(url);
            parameters.setTarget(target);

            return await POSTAsync("HTMLGetTargetedSentiment", "html", parameters);
        }

        async public Task<string> TextGetTargetedSentimentAsync(string text, string target)
        {
            CheckText(text);
            CheckText(target);

            return await TextGetTargetedSentimentAsync(text, target, new AlchemyAPI_TargetedSentimentParams());
        }

        async public Task<string> TextGetTargetedSentimentAsync(string text, string target, AlchemyAPI_TargetedSentimentParams parameters)
        {
            CheckText(text);
            CheckText(target);

            parameters.setText(text);
            parameters.setTarget(target);

            return await POSTAsync("TextGetTargetedSentiment", "text", parameters);
        }
        #endregion

        #region GetRelations
        async public Task<string> URLGetRelationsAsync(string url)
        {
            CheckURL(url);

            return await URLGetRelationsAsync(url, new AlchemyAPI_RelationParams());
        }

        async public Task<string> URLGetRelationsAsync(string url, AlchemyAPI_RelationParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetRelations", "url", parameters);
        }

        async public Task<string> HTMLGetRelationsAsync(string html, string url)
        {
            CheckHTML(html, url);

            return await HTMLGetRelationsAsync(html, url, new AlchemyAPI_RelationParams());
        }

        async public Task<string> HTMLGetRelationsAsync(string html, string url, AlchemyAPI_RelationParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetRelations", "html", parameters);
        }

        async public Task<string> TextGetRelationsAsync(string text)
        {
            CheckText(text);

            return await TextGetRelationsAsync(text, new AlchemyAPI_RelationParams());
        }

        async public Task<string> TextGetRelationsAsync(string text, AlchemyAPI_RelationParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetRelations", "text", parameters);
        }
        #endregion

        #region GetCombinedData
        async public Task<string> URLGetCombinedDataAsync(string url, AlchemyAPI_CombinedDataParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetCombinedData", "url", parameters);
        }
        async public Task<string> TextGetCombinedDataAsync(string text, AlchemyAPI_CombinedDataParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetCombinedData", "text", parameters);
        }
        #endregion

        #region GetRankedTaxonomy
        async public Task<string> URLGetRankedTaxonomyAsync(string url)
        {
            return await URLGetRankedTaxonomyAsync(url, new AlchemyAPI_TaxonomyParams());
        }
        async public Task<string> URLGetRankedTaxonomyAsync(string url, AlchemyAPI_TaxonomyParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetRankedTaxonomy", "url", parameters);
        }
        async public Task<string> HTMLGetRankedTaxonomyAsync(string html, string url)
        {
            return await HTMLGetRankedTaxonomyAsync(html, url, new AlchemyAPI_TaxonomyParams());
        }
        async public Task<string> HTMLGetRankedTaxonomyAsync(string html, string url, AlchemyAPI_TaxonomyParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetRankedTaxonomy", "html", parameters);
        }
        async public Task<string> TextGetRankedTaxonomyAsync(string text)
        {
            return await TextGetRankedTaxonomyAsync(text, new AlchemyAPI_TaxonomyParams());
        }
        async public Task<string> TextGetRankedTaxonomyAsync(string text, AlchemyAPI_TaxonomyParams parameters)
        {
            CheckText(text);
            parameters.setText(text);

            return await POSTAsync("TextGetRankedTaxonomy", "text", parameters);
        }
        #endregion

        #region GetImage
        async public Task<string> HTMLGetImageAsync(string html, string url)
        {
            return await HTMLGetImageAsync(html, url, new AlchemyAPI_ImageParams());
        }
        async public Task<string> HTMLGetImageAsync(string html, string url, AlchemyAPI_ImageParams parameters)
        {
            CheckHTML(html, url);
            parameters.setHtml(html);
            parameters.setUrl(url);

            return await POSTAsync("HTMLGetImage", "html", parameters);
        }
        async public Task<string> URLGetImageAsync(string url)
        {
            return await URLGetImageAsync(url, new AlchemyAPI_ImageParams());
        }
        async public Task<string> URLGetImageAsync(string url, AlchemyAPI_ImageParams parameters)
        {
            CheckURL(url);
            parameters.setUrl(url);

            return await GETAsync("URLGetImage", "url", parameters);
        }
        #endregion

        #region GetRankedImageKeywords
        async public Task<string> URLGetRankedImageKeywordsAsync(string url)
        {
            AlchemyAPI_RankedImageKeywords pms = new AlchemyAPI_RankedImageKeywords
            {
                ImageURL = url
            };

            return await URLGetRankedImageKeywordsAsync(pms);
        }
        async public Task<string> URLGetRankedImageKeywordsAsync(AlchemyAPI_RankedImageKeywords parameters)
        {
            CheckURL(parameters.ImageURL);

            return await GETAsync("URLGetRankedImageKeywords", "url", parameters);
        }
        async public Task<string> ImageGetRankedImageKeywordsAsync(AlchemyAPI_RankedImageKeywords parameters)
        {
            return await GETAsync("ImageGetRankedImageKeywords", "image", parameters);
        }
        #endregion

        #region GetPostDo
        async private Task<string> GETAsync(string callName, string callPrefix, AlchemyAPI_BaseParams parameters)
        { 
            StringBuilder uri = new StringBuilder();
            uri.Append(_requestUri).Append(callPrefix).Append("/").Append(callName);
            uri.Append("?apikey=").Append(_apiKey).Append(parameters.getParameterString());

            parameters.resetBaseParams();

            Uri address = new Uri(uri.ToString());
            //In progress VVVVVV
            using (HttpClient hClient = new HttpClient())
            {
                hClient.Timeout = System.TimeSpan.FromMilliseconds(8000);
                StringBuilder d = new StringBuilder();
                d.Append("apikey=").Append(_apiKey).Append(parameters.getParameterString());
                var s = new StringContent(d.ToString());

                using (HttpResponseMessage results = await hClient.GetAsync(address).ConfigureAwait(false))
                {
                    String ret = await DoRequestAsync(results, parameters.getOutputMode());
                    return ret;
                }
            }
            //In progress ^^^^^^
            /*
            HttpWebRequest wreq = WebRequest.Create(address) as HttpWebRequest;
            wreq.Proxy = null;

            byte[] postData = parameters.GetPostData();

            if (postData == null)
            {
                wreq.Method = "GET";
            }
            else
            {
                wreq.Method = "POST";
                using (var ps = wreq.GetRequestStream())
                {
                    ps.Write(postData, 0, postData.Length);
                }
            }
            return DoRequest(wreq, parameters.getOutputMode());*/
        }

        private async Task<String> POSTAsync(string callName, string callPrefix, AlchemyAPI_BaseParams parameters)
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
        #endregion

    }
}
