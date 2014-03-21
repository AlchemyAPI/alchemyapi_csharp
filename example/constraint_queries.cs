
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


		// Extract first link from an URL.
		string xml = alchemyObj.URLGetConstraintQuery("http://microformats.org/wiki/hcard", "1st link");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract first link from a HTML.
		xml = alchemyObj.HTMLGetConstraintQuery(htmlDoc, "http://www.test.com/", "1st link");;
		Console.WriteLine (xml);
	}
 
}

