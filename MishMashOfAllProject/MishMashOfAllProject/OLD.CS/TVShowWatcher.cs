using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    class  TVShowWatcher
    {
        private ITelevisionShow _show;
        public TVShowWatcher(ITelevisionShow Show)
        {
            _show = Show;
        }
       public void Next()
            {
            _show.NextEpisode();
            }
        public void Previous()
            {
                _show.PreviousEpisode();
            }
        public void Stop()
            {
                _show.StopWatching();
            }
        public void Watch()
            {
                _show.Watch();
            }
        
    }
}
