
using System;
using System.IO;
using AlchemyAPI;


public class TestApp
{
	static public void Main ()
	{
		// Create an AlchemyAPI object.
		AlchemyAPI.AlchemyAPI alchemyObj = new AlchemyAPI.AlchemyAPI();
		AlchemyAPI_KeywordParams alchemyParams = new AlchemyAPI_KeywordParams();
		alchemyParams.setOutputMode(AlchemyAPI_BaseParams.OutputMode.JSON);


		// Load an API key from disk.
		alchemyObj.LoadAPIKey("api_key.txt");


		// Extract topic keywords for a web URL.
		string response = alchemyObj.URLGetRankedKeywords("http://www.techcrunch.com/", alchemyParams);
		Console.WriteLine (response);


		// Extract topic keywords for a text string.
		response = alchemyObj.TextGetRankedKeywords("Hello there, my name is Bob Jones.  I live in the United States of America.  Where do you live, Fred?", alchemyParams);
		Console.WriteLine (response);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Extract topic keywords for a HTML document.
		response = alchemyObj.HTMLGetRankedKeywords(htmlDoc, "http://www.test.com/", alchemyParams);
		Console.WriteLine (response);
	}
 
}

