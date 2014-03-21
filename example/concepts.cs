
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


		// Extract concept tags for a web URL.
		string xml = alchemyObj.URLGetRankedConcepts("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Extract concept tags for a text string.
		xml = alchemyObj.TextGetRankedConcepts("This thing has a steering wheel, tires, and an engine.  Do you know what it is?");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract concept tags for a HTML document.
		xml = alchemyObj.HTMLGetRankedConcepts(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

