
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


		// Categorize a web URL by topic.
		string xml = alchemyObj.URLGetCategory("http://www.techcrunch.com/");
		Console.WriteLine (xml);


		// Categorize some text.
		xml = alchemyObj.TextGetCategory("Latest on the War in Iraq.");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Categorize a HTML document by topic.
		xml = alchemyObj.HTMLGetCategory(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

