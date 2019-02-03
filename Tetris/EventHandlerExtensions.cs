using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    static public class EventHandlerExtensions
    {
        static public void Fire(this EventHandler eventHandler, object sender, EventArgs e)
        {
            if (eventHandler != null)
                eventHandler(sender, e);
        }
        static public void Fire<T>(this EventHandler<T> eventHandler, object sender, T e)
            where T : EventArgs
        {
            if (eventHandler != null)
                eventHandler(sender, e);
        }
    }
}
