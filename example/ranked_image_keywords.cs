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

        // Use the upload image class
        AlchemyAPI_RankedImageKeywords fozzle = new AlchemyAPI_RankedImageKeywords();
        fozzle.SetImage("data/fozzle.jpg");

        string ret = alchemyObj.ImageGetRankedImageKeywords(fozzle);

        Console.WriteLine(ret);

        ret = alchemyObj.URLGetRankedImageKeywords("http://truestorieswithgill.com/wp-content/uploads/2013/09/20130915-190532.jpg");

        Console.WriteLine(ret);
    }
}