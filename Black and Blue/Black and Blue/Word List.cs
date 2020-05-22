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
    public partial class Word_List : Form
    {

        #region

        private ListOfWords myWordList;
        public ListOfWords MyWordList
        {
            get { return myWordList; }
            set { myWordList = value; }
        }

        private ListOfWords searchList;
        public ListOfWords SearchList
        {
            get { return searchList; }
            set { searchList = value; }
        }

        private ListOfSublists mySublistList;
        public ListOfSublists MySublistList
        {
            get { return mySublistList; }
            set { mySublistList = value; }
        }

        #endregion

        public Point mouseLocation;
        public List<Label> myMeaningList;
        public int prevSelectIndex;
        public int numOfMeanings = 14;
        public int numOfInserts = 0;
        
        public Word_List(ListOfWords list1, ListOfSublists list2)
        {
            InitializeComponent();
            lbWordInserted.Text = "WORD COUNT: " + list1.WordItem.Count;
            MyWordList = list1;
            MySublistList = list2;
            initializeSublistAutoCompletion();
            wordCount();
            loadListToCLB(MyWordList);                    
            defaultBtn();
        }

        public void initializeSublistAutoCompletion()
        {
            tbSearchSublist.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (Sublist sublist in MySublistList.SublistList)
                tbSearchSublist.AutoCompleteCustomSource.Add(sublist.ListName);
        }
        
        public void defaultBtn()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnDelAll.Enabled = true;
        }

        public void wordCount()
        {
            lbWordInserted.Text = "WORD COUNT: " + MyWordList.WordItem.Count;
        }

        public void loadListToCLB(ListOfWords list)
        {

            myMeaningList = new List<Label>();
            clbWordlist.Items.Clear();
            flpMeaning.Controls.Clear();
            myMeaningList.Clear();
            prevSelectIndex = 0;

            for (int i = 0; i < list.WordItem.Count; i++)
            {
                Label label = new Label();
                label.Size = new Size(flpMeaning.Width, flpMeaning.Height / numOfMeanings);
                myMeaningList.Add(label);
                myMeaningList[i].Text = list.WordItem[i].Meaning;
            }

            foreach (Word word in list.WordItem)
                clbWordlist.Items.Add(word.OneWord);

            foreach (Label label in myMeaningList)
                flpMeaning.Controls.Add(label);

        }

        public void loadSublistToCLB(Sublist list)
        {
            ListOfWords listOfWords = new ListOfWords();

            for (int i = 0; i < list.SublistWords.Count(); i++)
                listOfWords.WordItem.Add(MyWordList.WordItem[list.SublistWords[i]]);

            loadListToCLB(listOfWords);
        }

        private void btnSearchSublist_Click(object sender, EventArgs e)
        {
            Sublist sublist = new Sublist();

            for (int i = 0; i < MySublistList.SublistList.Count(); i++)
                if (tbSearchSublist.Text == MySublistList.SublistList[i].ListName)
                    sublist = MySublistList.SublistList[i];

            loadSublistToCLB(sublist);
        }

        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            SearchList = new ListOfWords();

            for (int i = 0; i < MyWordList.WordItem.Count; i++)
            {
                if (MyWordList.WordItem[i].OneWord.StartsWith(tbWord.Text))
                    SearchList.WordItem.Add(MyWordList.WordItem[i]);
            }

            if (SearchList.WordItem.Count == 0)
            {
                return;
            }

            loadListToCLB(SearchList);

        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            Word_Manager wordManager = new Word_Manager(false, null, null);
            wordManager.ShowDialog();

            if (Word_Manager.MyWord == null) return;

            if (!isAvailable(Word_Manager.MyWord))
            {
                MyWordList.WordItem.Add(Word_Manager.MyWord);
                numOfInserts++;
                wordCount();
                MyWordList.WordItem = sortByAlphabet();
                loadListToCLB(MyWordList);
            }

            btnDelAll.Enabled = true;
        }
        
        private bool isAvailable(Word addedWord)
        {
            foreach(Word word in MyWordList.WordItem)
            {
                if (addedWord.OneWord == word.OneWord)
                    return true;
            }

            return false;
        }

        private void btnAddSublist_Click(object sender, EventArgs e)
        {
            SublistManager sublistManager = new SublistManager(MyWordList, MySublistList);
            sublistManager.ShowDialog();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            int index = clbWordlist.SelectedIndex;
            Word_Manager wordManager = new Word_Manager(true, MyWordList.WordItem[index].OneWord, MyWordList.WordItem[index].Meaning);           
            wordManager.ShowDialog();

            if (Word_Manager.isEdited)
            {
                MyWordList.WordItem[index].OneWord = Word_Manager.MyWord.OneWord;
                MyWordList.WordItem[index].Meaning = Word_Manager.MyWord.Meaning;
                MyWordList.WordItem = sortByAlphabet();
                loadListToCLB(MyWordList);
                btnEdit.Enabled = false;
            }

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {

            List<string> tempList = new List<string>();
            
            foreach (Word word in MyWordList.WordItem)
            {
                tempList.Add(word.Meaning);
            }

            for (int i = 0; i < MyWordList.WordItem.Count; i++)
            {
                myWordList.WordItem[i].Meaning = myWordList.WordItem[i].OneWord;
            }

            for (int j = 0; j < MyWordList.WordItem.Count; j++)
            {
                MyWordList.WordItem[j].OneWord = tempList[j];
            }

            MyWordList.WordItem = sortByAlphabet();
            loadListToCLB(MyWordList);

        }

        public List<Word> sortByAlphabet()
        { 
            return MyWordList.WordItem.OrderBy(x => x.OneWord).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("DELETE WORD(S)?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dlr == DialogResult.No) return;

            List<int> removeList = new List<int>();

            foreach (int s in clbWordlist.CheckedIndices) removeList.Add(s);

            int j = 0;

            for (int i = 0; i < MyWordList.WordItem.Count; i++)
                if (i == removeList[0] - j)
                {
                    MyWordList.WordItem.RemoveAt(i);
                    i--;
                    removeList.RemoveAt(0);
                    if (removeList.Count == 0) break;
                    j++;
                }

            loadListToCLB(MyWordList);
            wordCount();
            defaultBtn();
        }

        private void clbWordlist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbWordlist.CheckedItems.Count == 0)
                btnDelete.Enabled = true;
            if (clbWordlist.CheckedItems.Count == 1 && clbWordlist.GetItemCheckState(clbWordlist.SelectedIndex) == CheckState.Checked)
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to delete every word and list?", "!!WARNING!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlr == DialogResult.No) return;

            MyWordList.WordItem.Clear();
            clbWordlist.Items.Clear();
            flpMeaning.Controls.Clear();
            tbWord.Clear();
            defaultBtn();
            btnDelAll.Enabled = false;
            wordCount();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbWordlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            flpMeaning.Controls[prevSelectIndex].BackColor = Color.Cyan;
            flpMeaning.Controls[clbWordlist.SelectedIndex].BackColor = Color.RoyalBlue;
            prevSelectIndex = clbWordlist.SelectedIndex;
        }

    }
}
