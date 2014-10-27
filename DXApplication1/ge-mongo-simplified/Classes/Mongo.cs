using System.ComponentModel;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ge_mongo_simplified.Classes
{
    class Mongo
    {
        public static string connectionString = @"mongodb://localhost";
        public static MongoClient client = new MongoClient(connectionString);
        public static MongoServer server = client.GetServer();
        public static MongoDatabase database = server.GetDatabase(@"devdb");
        public static MongoCollection groupCollection = database.GetCollection(@"devgroups");
        public static MongoCollection stdCollection = database.GetCollection(@"devstds");

        public static BindingList<Group> groupList()
        {
            var groupList = new BindingList<Group>(groupCollection.FindAllAs<Group>().ToList());
            return groupList;
        }

        public static Student getStudentInfo(string id)
        {
            var q = Query.EQ(@"_id", ObjectId.Parse(id));
            var std = stdCollection.FindOneAs<Student>(q);
            return std;
        }
    }
}
