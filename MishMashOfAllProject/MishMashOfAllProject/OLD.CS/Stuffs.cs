using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    public class Stuffs : IWriter, IMyInterfaceLearning
    {
        public void TextWriter(string s)
        {
            Console.WriteLine(s);
        }
        public string TextReader(string s)
        {
            string m = Console.ReadLine();
            return m;
        }
        public void Stuff() { return; }
        public void CWWriter(string s)
        {
            Console.WriteLine(s);
        }



    }
}
