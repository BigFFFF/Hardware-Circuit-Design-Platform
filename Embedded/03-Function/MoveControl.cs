using System.Drawing;
using System.Windows.Forms;

namespace Embedded._03_Function {
    public class MoveControl {
        public MoveControl(Control ctrl) {
            currentControl = ctrl;
            AddEvents();
        }

        private readonly Control currentControl;
        private Point pPoint;
        private Point cPoint;

        public Control CurrentControl => currentControl;

        public Point PPoint { get => pPoint; set => pPoint = value; }
        public Point CPoint { get => cPoint; set => cPoint = value; }

        private void AddEvents() {
            CurrentControl.MouseMove += new MouseEventHandler(MouseMove);
            CurrentControl.MouseDown += new MouseEventHandler(MouseDown);
            CurrentControl.MouseUp += new MouseEventHandler(MouseUp);
        }

        private void MouseUp(object sender, MouseEventArgs e) {
            CurrentControl.Refresh();
        }

        private void MouseDown(object sender, MouseEventArgs e) {
            PPoint = Cursor.Position;
        }

        private void MouseMove(object sender, MouseEventArgs e) {
            int x, y;

            Cursor.Current = Cursors.SizeAll;

            if (e.Button == MouseButtons.Left) {
                CPoint = Cursor.Position;

                x = (CPoint.X - PPoint.X);
                y = (CPoint.Y - PPoint.Y);
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
                    CurrentControl.Location = new Point(CurrentControl.Location.X + x, CurrentControl.Location.Y + y);
                    PPoint = CPoint;
                }
            }
        }




    }
}
