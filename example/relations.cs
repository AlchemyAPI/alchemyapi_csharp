
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


		// Extract a ranked list of relations from a web URL.
		string xml = alchemyObj.URLGetRelations("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Extract a ranked list of relations from a text string.
		xml = alchemyObj.TextGetRelations("Hello there, my name is Bob Jones.  I live in the United States of America.  Where do you live, Fred?");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract a ranked list of relations from a HTML document.
		xml = alchemyObj.HTMLGetRelations(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
		
		AlchemyAPI_RelationParams relationParams = new AlchemyAPI_RelationParams();
		relationParams.setSentiment(true);
		relationParams.setEntities(true);
		relationParams.setDisambiguate(true);
		relationParams.setSentimentExcludeEntities(true);
		xml = alchemyObj.TextGetRelations("Madonna enjoys tasty Pepsi.  I love her style.", relationParams);
        Console.WriteLine (xml);
		
		relationParams.setSentiment(true);
		relationParams.setRequireEntities(true);
		relationParams.setSentimentExcludeEntities(false);
		xml = alchemyObj.TextGetRelations("Madonna enjoys tasty Pepsi.  I love her style.", relationParams);
        Console.WriteLine (xml);
		
	}

}
