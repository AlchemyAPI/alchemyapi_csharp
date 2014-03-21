
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


		// Extract page text from a web URL. (ignoring ads, navigation links, etc.)
		string xml = alchemyObj.URLGetText("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Extract raw page text from a web URL. (including ads, navigation links, etc.)
		xml = alchemyObj.URLGetRawText("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Extract a title from a web URL.
		xml = alchemyObj.URLGetTitle("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract page text from a HTML document. (ignoring ads, navigation links, etc.)
		xml = alchemyObj.HTMLGetText(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);


		// Extract raw page text from a HTML document. (including ads, navigation links, etc.)
		xml = alchemyObj.HTMLGetRawText(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);


		// Extract a title from a HTML document.
		xml = alchemyObj.HTMLGetTitle(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

