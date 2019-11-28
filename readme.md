Simple test Cosmosdb Mongo .NET console app for testing/ troubleshooting purposes only. This app reads all the items from the CosmosDB collection.

Rebuild the solution, or restore the Nuget packages, or Nuget-install the following packages:
MongoDB.Driver
MongoDB.Bson
MongoDB.Bson.Serialization

Replace the YOUR_COSMOS_CONNECTIONSTRING , YOUR_COSMOS_DATABASE_NAME , and YOUR_COSMOS_COLLECTION_NAME in the app.config.

Important: See the note in the app.config for how to escape the & character (ampersand) which must be done in order to use the connection string in the app.config.

Modify the following line in the Program.cs according to the column that you want to print out. In this case, it prints out the value of the column named "id" (which is case-sensitive), but if you want to print another column name, modify this line accordingly.
Console.WriteLine(entity["id"].ToString()); 

Build using C# 7.1 or later.

