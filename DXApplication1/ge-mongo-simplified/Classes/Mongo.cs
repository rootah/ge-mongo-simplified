using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using ge_mongo_simplified.Properties;
using ge_mongo_simplified.UserControls.GroupRelated.FormRelated;
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

        public static Group getGroupDocument(string id)
        {
            var q = Query.EQ(@"_id", ObjectId.Parse(id));
            var groupDoc = groupCollection.FindOneAs<Group>(q);
            return groupDoc;
        }

        public static Student getStudentInfo(string id)
        {
            var q = Query.EQ(@"_id", ObjectId.Parse(id));
            var std = stdCollection.FindOneAs<Student>(q);
            return std;
        }

        public static void groupInsert(GeneralUC groupGeneralControl)
        {
            var daylist = new BsonArray();
            foreach (var item in groupGeneralControl.daysCBE.Properties.Items.Cast<CheckedListBoxItem>().Where(item => item.CheckState == CheckState.Checked))
            {
                daylist.Add(item.ToString());
            }
            var newgroup = new Group
            {
                _id = new ObjectId(),
                num = groupGeneralControl.numTE.Text,
                lvl = groupGeneralControl.lvlCBE.Text,
                duration = groupGeneralControl.durationCBE.Text,
                time = groupGeneralControl.timeTE.Text,
                days = new BsonArray(daylist)
            };

            groupCollection.Insert(newgroup);

            Settings.Default.groupID = newgroup._id.ToString();
            Settings.Default.groupNo = newgroup.num;
            Settings.Default.Save();

            var parentForm = (Form) groupGeneralControl.TopLevelControl;
            if (parentForm != null) parentForm.Close();
        }

        public static void groupUpdate(GeneralUC groupGeneralControl)
        {
            var daylist = new BsonArray();
            foreach (var item in groupGeneralControl.daysCBE.Properties.Items.Cast<CheckedListBoxItem>().Where(item => item.CheckState == CheckState.Checked))
            {
                daylist.Add(item.ToString());
            }

            groupCollection.Update(
                Query.EQ("_id", ObjectId.Parse(Settings.Default.groupID)),
                Update
                .Set("num", groupGeneralControl.numTE.Text)
                .Set("lvl", groupGeneralControl.lvlCBE.Text)
                .Set("duration", groupGeneralControl.durationCBE.Text)
                .Set("time", groupGeneralControl.timeTE.Text)
                .Set("days", new BsonArray(daylist)
                ));

            Settings.Default.groupNo = groupGeneralControl.numTE.Text;
            Settings.Default.Save();
            var parentForm = (Form)groupGeneralControl.TopLevelControl;
            if (parentForm != null) parentForm.Close();
        }
    }
}
