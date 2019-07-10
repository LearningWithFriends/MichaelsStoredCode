using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    class MyDictionary
    {
        private Dictionary<int,string> newDictionary = new Dictionary<int, string>();
        public void SetKeyValue(int key, string value)
        {
            
            newDictionary.Add(key, value);
        }
        public string GetValue(int key)
        {
            if (newDictionary.ContainsKey(key))
            {
                return newDictionary[key];
            }
            else
            {
                return "This key is not present";
            }
        }
    }
}
