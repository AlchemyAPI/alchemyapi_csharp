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
		alchemyObj.LoadAPIKey("taxo_api_key.txt");

		string htmlDoc = File.ReadAllText("data/example.html");

		string xml = alchemyObj.URLGetRankedTaxonomy("http://www.politico.com/blogs/media/2012/02/detroit-news-ed-upset-over-romney-edit-115247.html");

		Console.WriteLine(xml);

		xml = alchemyObj.HTMLGetRankedTaxonomy(htmlDoc, "http://www.test.com/");
		Console.WriteLine(xml);
	}
}