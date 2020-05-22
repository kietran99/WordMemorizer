using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_and_Blue
{

    [Serializable]

    public class ListOfSublists
    {

        private List<Sublist> sublistList;
        public List<Sublist> SublistList
        {
            get { return sublistList; }
            set { sublistList = value; }
        }

        public ListOfSublists()
        {
            SublistList = new List<Sublist>();
        }

    }
}
