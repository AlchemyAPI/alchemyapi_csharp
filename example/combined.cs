
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

		AlchemyAPI_CombinedDataParams prms = new AlchemyAPI_CombinedDataParams();
		prms.Extractions = CombinedExtract.Title | CombinedExtract.Author | CombinedExtract.Entity | CombinedExtract.Concept;

		string xml = alchemyObj.URLGetCombinedData("http://www.politico.com/blogs/media/2012/02/detroit-news-ed-upset-over-romney-edit-115247.html", prms);
		Console.WriteLine(xml);
	}
}