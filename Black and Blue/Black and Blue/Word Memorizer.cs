using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Black_and_Blue
{
    public partial class Form1 : Form
    {

        #region

        private ListOfWords myWordList;
        public ListOfWords MyWordList
        {
            get { return myWordList; }
            set { myWordList = value; }
        }

        private ListOfSublists mySublistList;
        public ListOfSublists MySublistList
        {
            get { return mySublistList; }
            set { mySublistList = value; }
        }

        #endregion

        public Point mouseLocation;
        private string savePath1 = "WordList.xml";
        private string savePath2 = "SubListList.xml";

        public Form1()
        {
            InitializeComponent();

            try
            {
                DeserializeFromXML(savePath1, savePath2);
                makeGlobalList();
            }
            catch
            {
                setDefaultLists();
            }

            initializeSublistAutoCompletion();
            upperCase();
        }

        public void upperCase()
        {
            foreach (Word word in MyWordList.WordItem)
            {
                word.OneWord = word.OneWord.ToUpper();
                word.Meaning = word.Meaning.ToUpper();
            }
        }

        public void makeGlobalList()
        {
            Sublist sublist = new Sublist();
            sublist.ListName = "ALL";

            for (int i = 0; i < MyWordList.WordItem.Count(); i++)
                sublist.SublistWords.Add(i);

            mySublistList.SublistList.Add(sublist);
        }

        public void setDefaultLists()
        {
            MyWordList = new ListOfWords();
            MySublistList = new ListOfSublists();
            Word item = new Word();
            MyWordList.WordItem.Add(item);
            MyWordList.WordItem[0].OneWord = "Default Word";
            MyWordList.WordItem[0].Meaning = "Default Meaning";
        }

        public void initializeSublistAutoCompletion()
        {
            tbCurrentSublist.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (Sublist sublist in MySublistList.SublistList)
                tbCurrentSublist.AutoCompleteCustomSource.Add(sublist.ListName);
        }

        private void SerializeToXML(object saveList1, object saveList2, string savePath1, string savePath2)
        {
            FileStream fs1 = new FileStream(savePath1, FileMode.Create, FileAccess.Write);
            FileStream fs2 = new FileStream(savePath2, FileMode.Create, FileAccess.Write);
            XmlSerializer serializer1 = new XmlSerializer(typeof(ListOfWords));
            XmlSerializer serializer2 = new XmlSerializer(typeof(ListOfSublists));
            serializer1.Serialize(fs1, saveList1);
            serializer2.Serialize(fs2, saveList2);
            fs1.Close();
            fs2.Close();
        }

        private void DeserializeFromXML(string savePath1, string savePath2)
        {
            FileStream fs1 = new FileStream(savePath1, FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(savePath2, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(ListOfWords));
                XmlSerializer serializer2 = new XmlSerializer(typeof(ListOfSublists));
                MyWordList = (ListOfWords)serializer1.Deserialize(fs1);
                MySublistList = (ListOfSublists)serializer2.Deserialize(fs2);
                fs1.Close();               
                fs2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                fs1.Close();
                fs2.Close();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePosition;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePosition;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = new Point(mousePosition.X - this.Width + panel3.Width, mousePosition.Y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = new Point(mousePosition.X, mousePosition.Y - this.Height + panel2.Height);
            } 
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Word_List wordList = new Word_List(MyWordList, MySublistList);
            wordList.ShowDialog();
            MyWordList = wordList.MyWordList;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(MyWordList, MySublistList, savePath1, savePath2);
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {

            foreach (Sublist sublist in MySublistList.SublistList)
                if (sublist.ListName.Equals(tbCurrentSublist.Text))
                {
                    Normal_Mode normalMode = new Normal_Mode(initializeSublist(sublist));
                    normalMode.ShowDialog();
                    return;
                }

            MessageBox.Show("SUBLIST NOT AVAILABLE");
        }

        public ListOfWords initializeSublist(Sublist sublist)
        {
            ListOfWords listOfWords = new ListOfWords();

            foreach (int i in sublist.SublistWords)
                listOfWords.WordItem.Add(MyWordList.WordItem[i]);

            return listOfWords;
        }

    }
}
