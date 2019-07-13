using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    class Office : ITelevisionShow
    {
        public void NextEpisode()
        {
            Console.WriteLine("Next Office Episode"); 
        }

        public void PreviousEpisode()
        {
            Console.WriteLine("Previous Office Episode");
        }

        public void StopWatching()
        {
            Console.WriteLine("Stop watching Office");
        }

        public void Watch()
        {
            Console.WriteLine("Start watching Office");
        }
    }
}
