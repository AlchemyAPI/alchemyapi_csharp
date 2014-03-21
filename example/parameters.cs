
using System;
using System.IO;
using AlchemyAPI;


public class TestApp
{
	static public void Main ()
	{
		// Create an AlchemyAPI object.
		AlchemyAPI.AlchemyAPI alchemyObj = new AlchemyAPI.AlchemyAPI();
        AlchemyAPI_KeywordParams keywordParams = new AlchemyAPI_KeywordParams();
        AlchemyAPI_EntityParams entityParams = new AlchemyAPI_EntityParams();

		// Load an API key from disk.
		alchemyObj.LoadAPIKey("api_key.txt");
        keywordParams.setMaxRetrieve(1);
        keywordParams.setShowSourceText(true);
        keywordParams.setSourceText(AlchemyAPI_KeywordParams.SourceTextMode.RAW);
		keywordParams.setSentiment(true);
		// Extract a ranked list of named entities from a web URL with parameters.
		string xml = alchemyObj.URLGetRankedKeywords("http://www.techcrunch.com/", keywordParams);
		Console.WriteLine (xml);

		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


        entityParams.setMaxRetrieve(3);
        entityParams.setDisambiguate(true);
        entityParams.setOutputMode(AlchemyAPI_BaseParams.OutputMode.RDF);
		entityParams.setSentiment(true);
		// Extract a ranked list of named entities from a HTML document with parameters.
		xml = alchemyObj.HTMLGetRankedNamedEntities(htmlDoc, "http://www.test.com/", entityParams);
		Console.WriteLine (xml);
		
	}

}
