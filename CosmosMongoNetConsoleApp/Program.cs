using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace CosmosMongoNetConsoleApp
{
    class Program
    {
        // The Azure CosmosDB connection for running this sample.
        private static readonly string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        // The Azure CosmosDB database name
        static string databaseId = ConfigurationManager.AppSettings["databaseId"];

        //The Azure CosmosDB collection name
        static string collectionId = ConfigurationManager.AppSettings["collectionId"];

        private static IMongoDatabase database;

        private static IMongoCollection<BsonDocument> collection;

        public static async Task Main(string[] args)
        {
            Program p = new Program();
            MongoClient client = new MongoClient(ConnectionString);
            database = client.GetDatabase(databaseId);
            collection = database.GetCollection<BsonDocument>(collectionId);

            List<BsonDocument> list = collection.Find(new BsonDocument()).ToList();
            Console.WriteLine("Items in collection:\n");

            //return the value for the column named 'id', for each item in the collection
            foreach (var entity in list)
            {
                var bson = BsonSerializer.Deserialize<BsonDocument>(entity);
                Console.WriteLine(entity["id"].ToString());
            }
        }
    }
}
