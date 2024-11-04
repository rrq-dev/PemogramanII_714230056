using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230056
{
    public abstract class Product_714230056
    {
        private string myType;
        private string myTitle;

        public Product_714230056()
        {

        }

        public Product_714230056(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        public string MyType
        {
            get { return myType; }
            set { myType = value; }
        }
        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        public abstract void DisplayInfo();
    }
}

