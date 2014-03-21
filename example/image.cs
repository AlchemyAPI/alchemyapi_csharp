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

		AlchemyAPI_ImageParams prms = new AlchemyAPI_ImageParams();
		prms.ImageMode = PageImageMode.AlwaysInfer;

		string xml = alchemyObj.URLGetImage("http://www.theguardian.com/world/2013/dec/01/ukraine-largest-street-protests-orange-revolution", prms);

		Console.WriteLine(xml);
	}
}