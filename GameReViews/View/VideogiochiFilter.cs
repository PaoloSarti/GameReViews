using GameReViews.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GameReViews.View
{
    public class VideogiochiFilter : FilterBindingListAdapter<Videogioco>
    {
        public VideogiochiFilter(BindingList<Videogioco> videogiochi)
            : base(videogiochi as IBindingList)
        {

        }

        protected override bool ISVisible(Videogioco videogioco)
        {
            if (videogioco.Recensione == null)
                return false;
            else
                return true;
        }
    }
}
