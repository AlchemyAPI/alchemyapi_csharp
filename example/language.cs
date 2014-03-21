
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


		// Detect the language for a web URL.
		string xml = alchemyObj.URLGetLanguage("http://news.google.de/");
		Console.WriteLine (xml);


		// Detect the language for a text string (requires at least 15 characters).
		xml = alchemyObj.TextGetLanguage("Hello there, my name is Bob Jones.  I live in the United States of America.  Where do you live, Fred?");
		Console.WriteLine (xml);


		// Load a HTML document to analyze.
		StreamReader streamReader = new StreamReader("data/example.html");
		string htmlDoc = streamReader.ReadToEnd();
		streamReader.Close();


		// Detect the language for a HTML document.
		xml = alchemyObj.HTMLGetLanguage(htmlDoc, "http://www.test.com/");
		Console.WriteLine (xml);
	}
 
}

