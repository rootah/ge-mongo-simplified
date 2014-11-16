using System;
using MongoDB.Bson;

namespace ge_mongo_simplified.Classes
{
    internal class GroupGrid
    {
// ReSharper disable once InconsistentNaming
        public ObjectId _id { get; set; }
        public string num { get; set; }
    }
    internal class Group
    {
// ReSharper disable once InconsistentNaming
        public ObjectId _id { get; set; }
        public string num { get; set; }
        public string lvl { get; set; }
        public BsonArray days { get; set; }
        public string time { get; set; }
        public string duration { get; set; }
        //public string status { get; set; }

        //public string Kind { get; set; }
        public BsonDateTime startDate { get; set; }
        public BsonDateTime endDate { get; set; }
        public BsonArray periods { get; set; }
        public BsonDateTime periodStart { get; set; }
        public BsonDateTime periodEnd { get; set; }
        public int stdCount { get; set; }
        public Boolean synced { get; set; }
    }
}