
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
		
		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();

		// Extract concept tags for a web URL.
		string xml = alchemyObj.URLGetAuthor("http://www.politico.com/blogs/media/2012/02/detroit-news-ed-upset-over-romney-edit-115247.html");
		Console.WriteLine (xml);
		
		// Extract concept tags for a web URL.
		xml = alchemyObj.HTMLGetAuthor(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

