
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


		// Extract microformats from a web URL.
		string xml = alchemyObj.URLGetMicroformats("http://microformats.org/wiki/hcard");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/microformats.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract microformats from a HTML document.
		xml = alchemyObj.HTMLGetMicroformats(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

