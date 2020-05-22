using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_and_Blue
{
    public class Sublist
    {
        private string listName;
        public string ListName
        {
            get { return listName; }
            set { listName = value; }
        }

        private List<int> sublistWords;
        public List<int> SublistWords
        {
            get { return sublistWords; }
            set { sublistWords = value; }
        }

        public Sublist()
        {
            SublistWords = new List<int>();
        }
    }
}
