using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20180328_FirrstWinFormsApp
{
    class MyButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            Location = new System.Drawing.Point(Location.X + Width, Location.Y + Height);
        }
    }
}
