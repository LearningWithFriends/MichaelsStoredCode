using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    class LearningSomeNewShitClass
    {
        //I'll be playing with LinkedLists tonight !

        // https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

        public void PlayingWithLLists()
        {
            LinkedList<String> list = new LinkedList<string>();
            list.AddLast("this");
            list.AddLast(" is");
            list.AddLast(" a Test");
            list.AddLast(" a Test");

            foreach (string item in list)
            {
                Console.Write(item);
            }

        }
    }
    
}



