Minimum Target Framework: .Net 4.5

Note: THIS IS NOT PRODUCTON CODE. This SDK is example code to get you started making programmatic calls to AlchemyAPI. 

================================
AlchemyAPI .NET SDK: version 0.10
================================

This is a .NET (C#) implementation of the AlchemyAPI SDK.  Mono and .NET
sections for installation and examples are below.  AlchemyAPI keys
can be downloaded from alchemyapi.com

================================
MONO
================================

INSTALLATION

To compile this module and generate the AlchemyAPI.dll file, enter the "module" directory and run the "build.sh" 
script.

To install this module, copy the AlchemyAPI.dll file  created from the previous step into your desired
.NET import directory, or set your MONO_PATH environment variable to point
to the directory containing the compiled AlchemyAPI.dll file.


RUNNING EXAMPLES

Several code examples are included to illustrate using the AlchemyAPI
for named entity extraction, text classification, language identification,
and other tasks.

All code samples are within the "example" directory.

To run these code samples you must first edit the (example/api_key.txt) file, 
adding your assigned AlchemyAPI API key.

Compiling Code Samples:

   1. Run "build.sh" (Compiles code using Mono)

Running Code Samples:

   1. Entity Extraction: ./run-test.sh entities.exe

   2. Concept Tagging: ./run-test.sh concepts.exe

   3. Keyword Extraction: ./run-test.sh keywords.exe

   4. Text Categorization: ./run-test.sh categories.exe

   5. Language Identification: ./run-test.sh language.exe

   6. HTML Text Extraction: ./run-test.sh text_extract.exe

   7. HTML Structured Content Scraping: ./run-test.sh constraint_queries.exe

   8. Microformats Extraction: ./run-test.sh microformats.exe

   9. RSS / ATOM Feed Links Extraction: ./run-test.sh feed_links.exe
   
  10. Sentiment Analysis: ./run-test.sh sentiment.exe
  
  11. Relations Extraction:  ./run-test.sh relations.exe
   
  12. Example Parameter Usage:  ./run-test.sh parameters.exe

  13. Author Extraction ./run-test.sh author.exe
  
   
================================
Windows .NET
================================

INSTALLATION

To compile this module and generate the AlchemyAPI.dll file, enter the "module" directory and run the "build.bat" 
script.

To install this module, copy the AlchemyAPI.dll file generated from the previous step into your desired
.NET import directory.  For purposes of running examples, the dll is
copied into the example folder.

RUNNING EXAMPLES

Several code examples are included to illustrate using the AlchemyAPI
for named entity extraction, text classification, language identification,
and other tasks.

All code samples are within the "example" directory.

To run these code samples you must first edit the (example/api_key.txt) file, 
adding your assigned AlchemyAPI API key.

Compiling Code Samples:

   1. Run "build.bat" (Compiles code using .NET)

Running Code Samples:

   1. Entity Extraction: entities.exe

   2. Concept Tagging: concepts.exe

   3. Keyword Extraction: keywords.exe

   4. Text Categorization: categories.exe

   5. Language Identification: language.exe

   6. HTML Text Extraction: text_extract.exe

   7. HTML Structured Content Scraping: constraint_queries.exe

   8. Microformats Extraction: microformats.exe

   9. RSS / ATOM Feed Links Extraction: feed_links.exe
   
  10. Setiment Analysis: sentiment.exe

  11. Relations Extraction: relations.exe

  12. Example Parameter Usage:  parameters.exe

  13. Author Extraction: authors.exe


DEPENDENCIES

This module requires a C# compiler such as Mono or Microsoft Visual Studio.NET

The included "build.sh" is for use with the Mono C# compiler only.


COPYRIGHT AND LICENCE

Copyright (C) 2009-2012 Orchestr8, LLC.

This library is free software; you can redistribute it and/or modify
it under the same terms as Mono itself, either Mono version 2.2 or,
at your option, any later version of Mono 2.2 you may have available.


