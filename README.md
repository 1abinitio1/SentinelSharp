# SentinelSharp
A library to interface with Copernicus sentinel data using c#  
You can use this library to search and download satelite data from the european Copernicus program.

Here is a basic guide on how to use the Library:

Step 1:  
  Create an instance of the SentinelSearch class  
	
Step 2:  
  Initialize that instance using: (essentially log into the service)  
  SentinelSearch.InitWebClient(Username,Password);  
	
Step 3:  
  Create an array of BaseSearchFilter's  
  (for example you could add a PointIntersectionFilter)  
  all Search Filter classes can be found in SentinelSharp.SearchFilters  
	
Step 4:  
  Use the SentinelSearch instance to call BuildQuerry  
  You pass it an array of BaseSearchFilter's and it returns a string with the search querry  
	
Step 5:  
  Use the SentinelSearch instance to call Search  
  You pass it the search queery string, with a page number  
  and it returns an array of product infos (the search results)  
  
