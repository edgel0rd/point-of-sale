using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class ETabControl : TabControl
    {
        public ETabControl()
        {
            //if (!this.DesignMode) this.Multiline = true;
            this.Multiline = true;
        }

        protected override void WndProc(ref Message m)
        {
            //m.Result = new IntPtr(1);
            if (m.Msg == 0x1328 && !this.DesignMode)
                m.Result = new IntPtr(1);
            else
                base.WndProc(ref m);
        }
    }
}
