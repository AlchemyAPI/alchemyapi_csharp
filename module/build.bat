
csc /target:library AlchemyAPI.cs AlchemyAPI_BaseParams.cs AlchemyAPI_CategoryParams.cs AlchemyAPI_ConceptParams.cs AlchemyAPI_ConstraintQueryParams.cs AlchemyAPI_EntityParams.cs AlchemyAPI_KeywordParams.cs AlchemyAPI_LanguageParams.cs AlchemyAPI_TextParams.cs AlchemyAPI_RelationParams.cs AlchemyAPI_TargetedSentimentParams.cs AlchemyAPI_CombinedDataParams.cs AlchemyAPI_TaxonomyParams.cs AlchemyAPI_ImageParams.cs -r:System.Data.dll -r:System.Web.dll

copy "AlchemyAPI.dll" "..\example\"
