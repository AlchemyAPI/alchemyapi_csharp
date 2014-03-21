#!/bin/sh

dmcs language.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs concepts.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs keywords.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs categories.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs feed_links.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs microformats.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs entities.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs text_extract.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs constraint_queries.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs parameters.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs sentiment.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs relations.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs author.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll

dmcs combined.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll
 
dmcs taxonomy.cs -r:System.Data.dll -r:System.Web.dll -r:../module/AlchemyAPI.dll
 
