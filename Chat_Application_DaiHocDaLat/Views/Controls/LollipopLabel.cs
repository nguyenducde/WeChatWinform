using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class LollipopLabel : Label
{

    public LollipopLabel()
    {

        ForeColor = ColorTranslator.FromHtml("#999999");
        BackColor = Color.Transparent;
    }
}
