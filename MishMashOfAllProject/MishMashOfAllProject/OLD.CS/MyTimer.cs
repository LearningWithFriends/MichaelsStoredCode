using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    public class MyTimer
    {

        public void ATimer(IPluggable pluggable)
        {
            Console.WriteLine(pluggable.Grounded);
            Console.WriteLine(pluggable.Voltage);
            return;
        }

    }
}
