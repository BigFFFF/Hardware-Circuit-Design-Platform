using System.Drawing;
using System.Windows.Forms;

namespace Embedded._03_Function {
    public class MoveControl {
        public MoveControl(Control ctrl) {
            currentControl = ctrl;
            AddEvents();
        }

        private Control currentControl;
        private Point pPoint;
        private Point cPoint;


        private void AddEvents() {
            currentControl.MouseMove += new MouseEventHandler(MouseMove);
            currentControl.MouseDown += new MouseEventHandler(MouseDown);
            currentControl.MouseUp += new MouseEventHandler(MouseUp);
        }

        private void MouseUp(object sender, MouseEventArgs e) {
            this.currentControl.Refresh();
        }

        private void MouseDown(object sender, MouseEventArgs e) {
            pPoint = Cursor.Position;
        }

        private void MouseMove(object sender, MouseEventArgs e) {
            int x = 0, y = 0;

            Cursor.Current = Cursors.SizeAll;

            if (e.Button == MouseButtons.Left) {
                cPoint = Cursor.Position;

                x = (cPoint.X - pPoint.X);
                y = (cPoint.Y - pPoint.Y);
                int ph = PublicVar.PicGateHV >> 1, pw = PublicVar.PicGateWV >> 2;
                if ((x < -ph | (x > ph) | (y < -ph) | (y > ph))) {
                    if (x < -pw) {
                        x = -ph;
                    }
                    else if (x > pw) {
                        x = ph;
                    }
                    else {
                        x = 0;
                    }

                    if (y < -pw) {
                        y = -ph;
                    }
                    else if (y > pw) {
                        y = ph;
                    }
                    else {
                        y = 0;
                    }
                    currentControl.Location = new Point(currentControl.Location.X + x, currentControl.Location.Y + y);
                    pPoint = cPoint;
                }
            }
        }




    }
}
