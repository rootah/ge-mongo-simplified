using System;
using MongoDB.Bson;

namespace ge_mongo_simplified.Classes
{
    class Student
    {
// ReSharper disable once InconsistentNaming
        public ObjectId _id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string fullname { get; set; }
        public Boolean underage { get; set; }
        public string pname { get; set; }
        public string source { get; set; }
        public string mphone { get; set; }
        public string hphone { get; set; }
        public string addphone { get; set; }
        public string email { get; set; }
        public string skype { get; set; }
        public string vk { get; set; }
        public string watsapp { get; set; }
        public string cost { get; set; }
        public string discount { get; set; }
        public string groupno { get; set; }
        public Boolean isindividual { get; set; }
        public Boolean synced { get; set; }

    }
}
