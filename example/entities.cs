
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


		// Extract a ranked list of named entities from a web URL.
		string xml = alchemyObj.URLGetRankedNamedEntities("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Extract a ranked list of named entities from a text string.
		xml = alchemyObj.TextGetRankedNamedEntities("Hello there, my name is Bob Jones.  I live in the United States of America.  Where do you live, Fred?");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract a ranked list of named entities from a HTML document.
		xml = alchemyObj.HTMLGetRankedNamedEntities(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}

}
