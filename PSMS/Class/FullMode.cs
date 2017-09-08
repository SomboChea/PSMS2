using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PSMS.Class
{
    class FullMode
    {
        public static void Fullscreen(Form context)
        {
            context.Width = Screen.PrimaryScreen.Bounds.Width;
            context.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        public static void Fullscreen(Form context, bool workingAreaEnable)
        {
            if (workingAreaEnable)
            {
                context.Width = Screen.PrimaryScreen.WorkingArea.Width;
                context.Height = Screen.PrimaryScreen.WorkingArea.Height;
            } else
            {
                Fullscreen(context);
            }
        }
        
    }
}
