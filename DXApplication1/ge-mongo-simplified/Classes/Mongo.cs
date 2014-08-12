using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ge_mongo_simplified.Classes
{
    class Mongo
    {
        private static string _connectionString;
        private static MongoClient _client;
        private static MongoServer _server;
        private static MongoDatabase _gebase;
        private static MongoCollection<Group> _groupcollection;

        public static void MongoInit()
        {
            _connectionString = "mongodb://localhost";
            _client = new MongoClient(_connectionString);
            _server = _client.GetServer();
            _gebase = _server.GetDatabase("devdb");
            _groupcollection = _gebase.GetCollection<Group>("devgroups");
        }
    }
}
