using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    interface IMyInterfaceLearning
    {
        void TextWriter(string s);
        string TextReader(string s);

        void Stuff();
    }
    interface IWriter
    {
        void CWWriter(string s);
    }
}
