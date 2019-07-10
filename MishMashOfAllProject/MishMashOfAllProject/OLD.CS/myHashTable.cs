using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MishMashOfAllProject
{
    class myHashTable
    {
        public Hashtable ht = new Hashtable();


        public string getHashCode(string value)
        {
            if (ht.ContainsValue(value))
            {
                return "empty";
            }
            else
            {
                return "empty";
            }

        }
    }
}
