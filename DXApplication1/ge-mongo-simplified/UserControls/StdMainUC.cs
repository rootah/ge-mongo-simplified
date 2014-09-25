﻿using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ge_mongo_simplified.UserControls
{
    public partial class StdMainUC : XtraUserControl
    {
        public static string connectionString = "mongodb://localhost";
        public static MongoClient client = new MongoClient(connectionString);
        public static MongoServer server = client.GetServer();
        public static MongoDatabase database = server.GetDatabase("devdb");
        public static MongoCollection collection = database.GetCollection("devstds");

        public StdMainUC()
        {
            InitializeComponent();
        }

        private void formCheck()
        {
            if (fnameTE.Text == string.Empty || lnameTE.Text == string.Empty)
            {
                XtraMessageBox.Show(@"Check names!" + Environment.NewLine + " ");
                fnameTE.Focus();
            }
            else writeResult();
        }

        private void writeResult()
        {
            var topLevelControl = (Form)TopLevelControl;
            var id = ObjectId.GenerateNewId(); 
            var newStd = new Student
            {
                _id = id,
                fname = fnameTE.Text,
                lname = lnameTE.Text,
                fullname = fnameTE.Text + @" " + lnameTE.Text,
                underage = underageCE.Checked,
                pname = pnameTE.Text,
                source = sourceCB.Text,
                mphone = mainphoneTE.Text,
                hphone = homephoneTE.Text,
                addphone = addphoneTE.Text,
                email = emailTE.Text,
                skype = skypeTE.Text,
                vk = vkTE.Text,
                watsapp = wappTE.Text,
                cost = costTE.Text,
                discountcheck = discountCE.Checked,
                discountval = discountTE.Text,
                groupno = groupnoCB.Text,
                start = startDE.DateTime.ToShortDateString(),
                end = endDE.DateTime.ToShortDateString(),
                endreason = reasonTE.Text};

            collection.Insert(newStd);
            lastActionWrite();
            Properties.Settings.Default.stdLastID = id.ToString();
            Properties.Settings.Default.Save();
            if (topLevelControl != null) topLevelControl.Close();
        }
        private void lastActionWrite()
        {
            //var topLevelControl = (Form)TopLevelControl;
            Properties.Settings.Default.lastAction = "Student [" + fnameTE.Text + @" " + lnameTE.Text + "] added";
            //if (topLevelControl != null) topLevelControl.Text = @"Student [" + fnameTE.Text + @" " + lnameTE.Text + @"]";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            formCheck();
            //var topForm = (Form) TopLevelControl;
            //if (topForm != null) topForm.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            pnameControl.Visibility = underageCE.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            parentResize();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (discountCE.Checked)
                discountControl.Control.Enabled = true;
            else
            {
                discountControl.Control.Enabled = false;
                discountControl.Control.Text = string.Empty;}
        }

        private void tabbedControlGroup1_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            parentResize();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;
            if (topLevelControl != null) topLevelControl.Close();
        }

        private void parentResize()
        {
            var topLevelControl = (Form)TopLevelControl;
            if (topLevelControl != null)
                topLevelControl.ClientSize = new Size(ClientSize.Width, layoutControl1.Root.MinSize.Height);
        }

        private void addphoneCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addphoneControl.Visibility = addphoneCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            addphoneTE.Text = string.Empty;
            parentResize();
        }

        private void skypeCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            skypeControl.Visibility = skypeCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            skypeTE.Text = string.Empty;
            separatorVisibility();
            parentResize();
        }

        private void emailCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            emailControl.Visibility = emailCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            emailTE.Text = string.Empty;
            separatorVisibility();
            parentResize();
        }

        private void wappCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wappControl.Visibility = wappCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            wappTE.Text = string.Empty;
            separatorVisibility();
            parentResize();
        }

        private void vkCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vkControl.Visibility = vkCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            vkTE.Text = string.Empty;
            separatorVisibility();
            parentResize();
        }

        private void separatorVisibility()
        {
            if (vkControl.Visible || wappControl.Visible || emailControl.Visible || skypeControl.Visible)
                simpleSeparator1.Visibility = LayoutVisibility.Always;
            else simpleSeparator1.Visibility = LayoutVisibility.Never;
        }

        private void hphoneCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            homephoneControl.Visibility = hphoneCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            homephoneTE.Text = string.Empty;
            parentResize();}

        private void wappTE_Enter(object sender, EventArgs e)
        {
            wappTE.Text = String.Empty;
            wappTE.Properties.Items.Clear();
            if (mainphoneTE.Text != String.Empty)
                wappTE.Properties.Items.Add(mainphoneTE.Text);
            if (addphoneTE.Text != String.Empty)
                wappTE.Properties.Items.Add(addphoneTE.Text);
        }

        public void studentEditFormFill()
        {
            var std = Mongo.getStudentInfo(Properties.Settings.Default.stdID);
            fnameTE.Text = std.fname;
            lnameTE.Text = std.lname;
            if (std.underage)
                underageCE.Checked = true;
            if (std.pname != String.Empty)
                pnameTE.Text = std.pname;
            if (std.mphone != String.Empty)
            {
                mainphoneControl.Visibility = LayoutVisibility.Always;
                mainphoneTE.Text = std.mphone;
            }
            if (std.hphone != String.Empty)
            {
                homephoneControl.Visibility = LayoutVisibility.Always;
                homephoneTE.Text = std.hphone;
            }
            if (std.addphone != String.Empty)
            {
                addphoneControl.Visibility = LayoutVisibility.Always;
                addphoneTE.Text = std.addphone;
            }
            if (std.email != String.Empty)
            {
                emailControl.Visibility = LayoutVisibility.Always;
                if (!simpleSeparator1.Visible)
                    simpleSeparator1.Visibility = LayoutVisibility.Always;
                emailTE.Text = std.email;
            }
            if (std.skype != String.Empty)
            {
                skypeControl.Visibility = LayoutVisibility.Always;
                if (!simpleSeparator1.Visible)
                    simpleSeparator1.Visibility = LayoutVisibility.Always;
                skypeTE.Text = std.skype;
            }
            if (std.vk != String.Empty)
            {
                vkControl.Visibility = LayoutVisibility.Always;
                if (!simpleSeparator1.Visible)
                    simpleSeparator1.Visibility = LayoutVisibility.Always;
                vkTE.Text = std.vk;
            }
            if (std.watsapp != String.Empty)
            {
                wappControl.Visibility = LayoutVisibility.Always;
                if (!simpleSeparator1.Visible)
                    simpleSeparator1.Visibility = LayoutVisibility.Always;
                wappTE.Text = std.watsapp;
            }
            if (std.groupno != String.Empty)
            {
                groupnoCB.Text = std.groupno;
                groupPayLabel.Text = std.groupno;
                // insert group pay period here! //
            }   
            if (std.source != String.Empty)
                sourceCB.Text = std.source;
            if (std.start != String.Empty)
                startDE.EditValue = DateTime.Parse(std.start);
            if (std.end != String.Empty)
                endDE.EditValue = DateTime.Parse(std.end);
            if (std.endreason != String.Empty)
                reasonTE.Text = std.endreason;
            if (std.cost != String.Empty)
                costTE.Text = std.cost;
            if (std.discountcheck)
                discountCE.Checked = true;
            if (std.discountval != String.Empty)
            {
                discountTE.Enabled = true;
                discountTE.Text = std.discountval;
            }
            
            parentResize();
        }
    }
}
