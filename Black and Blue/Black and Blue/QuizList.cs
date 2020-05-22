using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_and_Blue
{
    public class QuizList
    {

        private List<int> quizItem;
        public List<int> QuizItem
        {
            get { return quizItem; }
            set { quizItem = value; }
        }

        private List<bool> answer;
        public List<bool> Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public QuizList()
        {
            QuizItem = new List<int>();
            Answer = new List<bool>();
        }

    }
}
