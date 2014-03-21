
using System;
using System.IO;
using AlchemyAPI;


public class TestApp
{
	static public void Main ()
	{
		// Create an AlchemyAPI object.
		AlchemyAPI.AlchemyAPI alchemyObj = new AlchemyAPI.AlchemyAPI();


		// Load an API key from disk.
		alchemyObj.LoadAPIKey("api_key.txt");


		// Extract sentiment for a web URL.
		string xml = alchemyObj.URLGetTextSentiment("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Extract sentiment from a text string.
		xml = alchemyObj.TextGetTextSentiment("Hello there, my name is Bob Jones.  I live in the United States of America.  Where do you live, Fred?");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract sentiment from a HTML document.
		xml = alchemyObj.HTMLGetTextSentiment(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);


		// Extract named entities with entity-targeted sentiment.
		AlchemyAPI_EntityParams entityParams = new AlchemyAPI_EntityParams();
		entityParams.setSentiment(true);
		xml = alchemyObj.TextGetRankedNamedEntities("Bryan Adams' genius is unsurpassed.", entityParams);
		Console.WriteLine (xml);


		// Extract keywords with keyword-targeted sentiment.
		AlchemyAPI_KeywordParams keywordParams = new AlchemyAPI_KeywordParams();
		keywordParams.setSentiment(true);
		xml = alchemyObj.TextGetRankedKeywords("Bryan Adams' genius is unsurpassed.", keywordParams);
		Console.WriteLine (xml);
		
		// Extract Targeted Sentiment
		AlchemyAPI_TargetedSentimentParams sentimentParams = new AlchemyAPI_TargetedSentimentParams();
		sentimentParams.setShowSourceText(true);
		xml = alchemyObj.TextGetTargetedSentiment("This car is terrible.", "car", sentimentParams);
		Console.WriteLine(xml);
		
		xml = alchemyObj.URLGetTargetedSentiment("http://techcrunch.com/2012/03/01/keen-on-anand-rajaraman-how-walmart-wants-to-leapfrog-over-amazon-tctv/", "Walmart",sentimentParams);
		Console.WriteLine(xml);
		
		xml = alchemyObj.HTMLGetTargetedSentiment(htmlDoc, "http://www.test.com/", "WujWuj", sentimentParams);
		Console.WriteLine(xml);
	}
 
}

