using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_and_Blue
{
    [Serializable]

    public class ListOfWords
    {

        private List<Word> wordItem;
        public List<Word> WordItem
        {
            get { return wordItem; }
            set { wordItem = value; }
        }

        public ListOfWords()
        {
            WordItem = new List<Word>();
        }

    }
}
