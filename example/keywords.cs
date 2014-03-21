
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


		// Extract topic keywords for a web URL.
		string xml = alchemyObj.URLGetRankedKeywords("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Extract topic keywords for a text string.
		xml = alchemyObj.TextGetRankedKeywords("Hello there, my name is Bob Jones.  I live in the United States of America.  Where do you live, Fred?");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract topic keywords for a HTML document.
		xml = alchemyObj.HTMLGetRankedKeywords(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

