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
    public partial class Word_Manager : Form
    {
        #region

        private static Word myWord;
        public static Word MyWord
        {
            get { return myWord; }
            set { myWord = value; }
        }

        #endregion

        public static bool isEdited = false;
        public bool editMode = false;
        public string prevWord, prevMeaning;

        public Word_Manager(bool editMode, string editWord, string editMeaning)
        {
            InitializeComponent();

            if (editMode)
            {
                rbEdit.Checked = true;                
                rbNewWord.Enabled = false;
                tbNewWord.Text = editWord;
                tbNewMeaning.Text = editMeaning;
                prevWord = editWord;
                prevMeaning = editMeaning;
                this.editMode = true;
                tbNewWord.Focus();
            }
            else
            {
                rbNewWord.Checked = true;
                rbEdit.Enabled = false;
                tbNewWord.Focus();
            }
        }               

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNewWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                tbNewMeaning.Focus();
        }

        private void tbNewMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.Focus();
            else if (e.KeyCode == Keys.Up)
                tbNewWord.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (tbNewWord.Text == "")
            {
                MessageBox.Show("PLEASE ENTER A WORD");
                return;
            }

                if (tbNewMeaning.Text == "")
            {
                MessageBox.Show("PLEASE ENTER A MEANING FOR YOUR WORD");
                return;
            }

            MyWord = new Word();
            MyWord.OneWord = tbNewWord.Text;
            MyWord.Meaning = tbNewMeaning.Text;

            if (MyWord.OneWord != prevWord || MyWord.Meaning != prevMeaning)
                isEdited = true;

            if (!editMode)
            {                                
                MessageBox.Show("WORD ADDED");
            }

            else if (isEdited)
            {
                MessageBox.Show("WORD UPDATED");
            }

            /*tbNewWord.Clear();
            tbNewMeaning.Clear();*/                     // Save this for adding multiple words function
            this.Close();
        }
    }
}
