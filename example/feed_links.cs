
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


		// Extract RSS / ATOM feed links from a web URL.
		string xml = alchemyObj.URLGetFeedLinks("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract RSS / ATOM feed links from a HTML document.
		xml = alchemyObj.HTMLGetFeedLinks(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

