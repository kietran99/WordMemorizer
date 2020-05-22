using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_and_Blue
{
    public partial class SublistManager : Form
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

        public int numOfWords = 15;

        public SublistManager(ListOfWords list1, ListOfSublists list2)
        {
            InitializeComponent();
            MyWordList = list1;
            MySublistList = list2;
            initializeAutoCompletion();
        }

        public void loadSublist(Sublist sublist)
        {

            flpSublistWords.Controls.Clear();

            foreach(int i in sublist.SublistWords)
            {
                Label label = new Label();
                label.Text = MyWordList.WordItem[i].OneWord;
                label.Size = new Size(flpSublistWords.Width / 2, flpSublistWords.Height / numOfWords);
                flpSublistWords.Controls.Add(label);
            }
        }

        public void initializeAutoCompletion()
        {
            tbSearchSublist.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            tbSubWord.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (Sublist sublist in MySublistList.SublistList)
                tbSearchSublist.AutoCompleteCustomSource.Add(sublist.ListName);
            foreach (Word word in MyWordList.WordItem)
                tbSubWord.AutoCompleteCustomSource.Add(word.OneWord);
        }

        private void btnNewSublist_Click(object sender, EventArgs e)
        {
            if (tbNewSublist.Text == "")
                return;
            MySublistList.SublistList.Add(new Sublist());
            MySublistList.SublistList[mySublistList.SublistList.Count() - 1].ListName = tbNewSublist.Text;
            MessageBox.Show("SUBLIST ADDED");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int pos = findWordPosition();            
            bool available = false;

            if (pos == -1)
            {
                MessageBox.Show("WORD NOT FOUND");
                return;
            }

            for (int i = 0; i < MySublistList.SublistList.Count(); i++)
            {
                if (MySublistList.SublistList[i].ListName.Equals(tbSearchSublist.Text))
                {
                    if (!MySublistList.SublistList[i].SublistWords.Contains(pos))
                        MySublistList.SublistList[i].SublistWords.Add(pos);
                    else
                    {
                        MessageBox.Show("WORD ALREADY AVAILABLE");
                        available = true;
                    }
                        break;
                }
            }

            if (!available) MessageBox.Show("WORD ADDED");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int pos = findWordPosition();

            if (pos == -1)
            {
                MessageBox.Show("WORD NOT FOUND");
                return;
            }

            for (int i = 0; i < MySublistList.SublistList.Count(); i++)
            {
                if (MySublistList.SublistList[i].ListName.Equals(tbSearchSublist.Text))
                {
                    bool removeSuccess = mySublistList.SublistList[i].SublistWords.Remove(pos);
                    if (removeSuccess)
                        MessageBox.Show("WORD REMOVED");
                    else MessageBox.Show("WORD NOT FOUND");
                    break;
                }
            }
        }

        public int findWordPosition()
        {
            int pos = -1;

            for (int j = 0; j < MyWordList.WordItem.Count(); j++)
            {
                if (MyWordList.WordItem[j].OneWord.Equals(tbSubWord.Text))
                {
                    pos = j;
                    break;
                }
            }

            return pos;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSubWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
                tbSearchSublist.Focus();
        }

        private void tbSearchSublist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                tbSubWord.Focus();
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnSearchSublist_Click(object sender, EventArgs e)
        {
            Sublist sublist = new Sublist();

            for (int i = 0; i < MySublistList.SublistList.Count(); i++)
                if (MySublistList.SublistList[i].ListName.Equals(tbSearchSublist.Text))
                    sublist = MySublistList.SublistList[i];

            loadSublist(sublist);
        }
    }
}
