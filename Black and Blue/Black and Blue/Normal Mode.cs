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
    public partial class Normal_Mode : Form
    {

        #region

        private ListOfWords myWordList;
        public ListOfWords MyWordList
        {
            get { return myWordList; }
            set { myWordList = value; }
        }

        private QuizList myQuizList;
        public QuizList MyQuizList
        {
            get { return myQuizList; }
            set { myQuizList = value; }
        }

        #endregion

        public int questionNumber = 0;
        public int numberOfQuestions = 0;

        public Normal_Mode(ListOfWords list)
        {
            InitializeComponent();
            MyWordList = list;           
            initializeQuizList();
            loadQnA();
        }

        public void initializeQuizList()
        {
            MyQuizList = new QuizList();
            List<int> initializer = new List<int>();
            for (int i = 0; i < MyWordList.WordItem.Count; i++) initializer.Add(i);
            MyQuizList.QuizItem = shuffle(initializer, initializer.Count, initializer.Count);
        }

        public List<int> shuffle(List<int> srcList, int src, int des)
        {
            List<int> unshuffledList = new List<int>();
            List<int> shuffledList = new List<int>();
            Random random = new Random();
            int j = 0;
            int num;

            foreach (int element in srcList)
                unshuffledList.Add(element);

            while (shuffledList.Count != des)
            {
                num = random.Next(0, src - 1 - j);
                shuffledList.Add(unshuffledList[num]);
                unshuffledList.RemoveAt(num);
                j++;
            }

            return shuffledList;

        }

        public void loadQnA()
        {

            List<int> unshuffledAnswers = new List<int>();
            List<int> shuffledAnswers = new List<int>();
            unshuffledAnswers = MyQuizList.QuizItem;
            Random rd = new Random();
            Word theQuestionWord = MyWordList.WordItem[MyQuizList.QuizItem[questionNumber]];

            shuffledAnswers = shuffle(unshuffledAnswers, unshuffledAnswers.Count, 4);

            int correctAnswerPosition = correctAvailable(theQuestionWord, shuffledAnswers);

            if (correctAnswerPosition == -1) shuffledAnswers[rd.Next(0, 3)] = MyQuizList.QuizItem[questionNumber];
            
            lbWord.Text = theQuestionWord.OneWord;
            btn1.Text = MyWordList.WordItem[shuffledAnswers[0]].Meaning;
            btn2.Text = MyWordList.WordItem[shuffledAnswers[1]].Meaning;
            btn3.Text = MyWordList.WordItem[shuffledAnswers[2]].Meaning;
            btn4.Text = MyWordList.WordItem[shuffledAnswers[3]].Meaning;

            questionNumber++;

        }

        public int correctAvailable(Word word, List<int> list)
        {
            int j = 0;
            Random rd = new Random();

            while (j < 4)
            {
                if (word.Meaning == MyWordList.WordItem[list[j]].Meaning)
                    return j;
                j++;
            }
            
            return -1;
        }

        public void isCorrect(string word, string meaning)
        {
            for (int i = 0; i < MyWordList.WordItem.Count; i++)
                if (word == MyWordList.WordItem[i].OneWord)
                {
                    if (meaning == MyWordList.WordItem[i].Meaning)
                    {
                        MyQuizList.Answer.Add(true);
                        break;
                    }
                    else
                    {
                        MyQuizList.Answer.Add(false);
                        break;
                    }
                }

        }

        public int numberOfCorrects()
        {
            int i = 0;
            foreach (bool answer in MyQuizList.Answer)
                if (answer) i++;
            return i;
        }

        public void gameTime(string word, string meaning)
        {
            isCorrect(word, meaning);
            
            numberOfQuestions++;

            if (numberOfQuestions == MyQuizList.QuizItem.Count)
            {
                MessageBox.Show("YOU GOT " + numberOfCorrects().ToString() + "/" + MyQuizList.QuizItem.Count + " CORRECT ANSWERS", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else loadQnA();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            gameTime(lbWord.Text, btn.Text);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("QUIT THE GAME?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dlr == DialogResult.Yes)
                this.Close();
        }
    }
}
