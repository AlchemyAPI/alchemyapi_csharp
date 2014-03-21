﻿using System;
using System.Web;


namespace AlchemyAPI
{
	public class AlchemyAPI_CategoryParams : AlchemyAPI_BaseParams
	{
		public enum SourceTextMode
		{
			NONE,
			CLEANED_OR_RAW,
			CQUERY,
			XPATH
		}
	
		private SourceTextMode sourceText;
		private string cQuery;
		private string xPath;
		private string baseUrl;

		public SourceTextMode getSourceText()
		{
			return sourceText;
		}

		public void setSourceText(SourceTextMode sourceText)
		{
			this.sourceText = sourceText;
		}

		public string getCQuery()
		{
			return cQuery;
		}

		public void setCQuery(string cQuery)
		{
			this.cQuery = cQuery;
		}

		public string getXPath()
		{
			return xPath;
		}

		public void setXPath(string xPath)
		{
			this.xPath = xPath;
		}

		public string getBaseUrl()
		{
			return baseUrl;
		}

		public void setBaseUrl(string baseUrl)
		{
			this.baseUrl = baseUrl;
		}
	
		override public string getParameterString()
		{
			string retstring = base.getParameterString();

			if (sourceText != SourceTextMode.NONE)
			{
				if( sourceText == SourceTextMode.CLEANED_OR_RAW )
					retstring += "&sourceText=cleaned_or_raw";
				else if( sourceText == SourceTextMode.CQUERY )
					 retstring += "&sourceText=cquery";
				else if( sourceText == SourceTextMode.CQUERY )
					 retstring += "&sourceText=xpath";
			}
			if (cQuery != null) retstring += "&cquery=" + HttpUtility.UrlEncode(cQuery);
			if (xPath != null) retstring += "&xpath=" + HttpUtility.UrlEncode(xPath);
			if (baseUrl != null) retstring += "&baseUrl=" + HttpUtility.UrlEncode(baseUrl);
		   
			return retstring;
		}
	}
}
