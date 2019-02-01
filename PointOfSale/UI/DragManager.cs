using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI
{
    public class DragManager
    {
        private Form Parent;
        bool _mouseDown;
        Point _lastLocation;

        public DragManager(Form parent, List<Control> controllers)
        {
            Parent = parent;
            foreach (Control controller in controllers)
            {
                controller.MouseUp += Controller_MouseUp;
                controller.MouseDown += Controller_MouseDown;
                controller.MouseMove += Controller_MouseMove;
            }
        }

        private void Controller_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void Controller_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Parent.Location = new Point(
                    (Parent.Location.X - _lastLocation.X) + e.X, (Parent.Location.Y - _lastLocation.Y) + e.Y);

                Parent.Update();
            }
        }

        private void Controller_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
