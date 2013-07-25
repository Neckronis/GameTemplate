using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Vestibule
{
    public static class GlobalManager
    {
        static GameWindow window;

        public static void Initialize(GameWindow window)
        {
            GlobalManager.window = window;
        }

        public static GameWindow Window
        {
            get { return window; }
            set { window = value; }
        }
    }
}
