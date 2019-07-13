using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    class Friends : ITelevisionShow
    {
        public void NextEpisode()
        {
            Console.WriteLine("Next friends Episode");
        }

        public void PreviousEpisode()
        {
            Console.WriteLine("Previous friends Episode");
        }

        public void StopWatching()
        {
            Console.WriteLine("Stop friends Watching");
        }

        public void Watch()
        {
            Console.WriteLine("Start friends Watching");
        }
    }
}
