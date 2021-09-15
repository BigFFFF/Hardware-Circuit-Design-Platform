using Embedded._03_Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embedded._02_Form {
    public partial class FrmMain : Form {
        private int pbCount;
        private int inputNum;
        private List<TextBox> inputList;
        private List<PictureBox> gateList;

        public List<TextBox> InputList { get => inputList; set => inputList = value; }
        public List<PictureBox> GateList { get => gateList; set => gateList = value; }

        public FrmMain() {
            InitializeComponent();
            InputList = new List<TextBox>();
            GateList = new List<PictureBox>();
            pbCount = 0;
            inputNum = 0;

            foreach (Control ctrl in BoxDesign.Controls) {
                new MoveControl(ctrl);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {

            this.toolStripStatusLabel1.Text = "您好,欢迎登录系统！" + "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }


        private void Picture_Click(string pathStr1, string gateName) {
            string pathStr2 = "", pathStr3 = "";
            int inputI, outputI;

            using FrmGate frmGate = new FrmGate {
                Text = gateName
            };
            {
                //默认方向为上下
                frmGate.ComboBoxInIndex = 2;
                frmGate.ComboBoxOutIndex = 2;

                frmGate.ShowDialog();

                if (frmGate.DialogResult == DialogResult.OK) {
                    inputI = frmGate.ComboBoxInIndex;
                    outputI = frmGate.ComboBoxOutIndex;

                    switch (inputI) {
                        case 0:
                            pathStr2 = "s";
                            break;
                        case 1:
                            pathStr2 = "x";
                            break;
                        case 2:
                            pathStr2 = "2";
                            break;
                        default:
                            break;
                    }

                    switch (outputI) {
                        case 0:
                            pathStr3 = "s";
                            break;
                        case 1:
                            pathStr3 = "x";
                            break;
                        case 2:
                            pathStr3 = "2";
                            break;
                        default:
                            break;
                    }

                    PictureBox pb = new PictureBox();
                    BoxDesign.Controls.Add(pb);
                    GateList.Add(pb);

                    try {
                        GateList[pbCount].Image = Image.FromFile(Application.StartupPath + "\\..\\..\\05-Image\\" + pathStr1 + " - " + pathStr2 + pathStr3 + ".png");
                        GateList[pbCount].Name = pathStr1;
                        GateList[pbCount].Size = new Size(PublicVar.PicGateWV, PublicVar.PicGateHV);
                        GateList[pbCount].Location = new Point(PublicVar.PicGateWV * ((pbCount / 8)  + 1), PublicVar.PicGateHV * ((pbCount % 8) + 1));
                        GateList[pbCount].DoubleClick += new EventHandler(GateDouble_Click);

                        new MoveControl(GateList[pbCount]);

                        pbCount++;
                    }
                    catch (Exception ex) {
                        BoxDesign.Controls.Remove(pb);
                        GateList.Remove(pb);
                        pb.Dispose();
                        frmGate.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("选择了错误方向，请检查!\n"+ ex.ToString(), "添加门电路错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GateDouble_Click(object sender, EventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;

            BoxDesign.Controls.Remove(pictureBox);           
            GateList.Remove(pictureBox);
            pictureBox.Dispose();

            pbCount--;
        }

        private void BtnConfirm_Click(object sender, EventArgs e) {

            try {
                if (TextInputNum.Text.Length == 0 | Convert.ToInt32(TextInputNum.Text.Trim()) < 1 | Convert.ToInt32(TextInputNum.Text.Trim()) > 256) {
                    MessageBox.Show("输入端数有误，请检查！", "输入端数错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = inputNum - 1; i >= 0; i--) {
                    BoxDesign.Controls.Remove(InputList[i]);
                    InputList[i].Dispose();
                }
                InputList.Clear();

                inputNum = Convert.ToInt32(TextInputNum.Text.Trim());
               
            }
            catch {
                MessageBox.Show("输入端数有误，请检查！", "输入端数错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < inputNum; i++) {
                TextBox textBox = new TextBox {
                    //int->ASCII->String(A开始)
                    Name = Convert.ToString(Convert.ToChar(65 + i)),
                    Text = Convert.ToString(Convert.ToChar(65 + i)) + "=1",
                    Tag = i,
                    Location = new Point((PublicVar.PicGateWV) * ((i / 16)), (PublicVar.PicGateHV / 2) * ((i % 16 + 1) + 1)),
                    Size = new Size(PublicVar.PicGateWV, PublicVar.PicGateHV / 2)
                };
                InputList.Add(textBox);
                new MoveControl(InputList[i]);
            }
            BoxDesign.Controls.AddRange(InputList.ToArray());
        }

        /**
         * 清空设计区
         */
        private void BtnDelete_Click(object sender, EventArgs e) {
            BoxDesign.Controls.Clear();

            for (int i = inputNum - 1; i >= 0; i--) {
                BoxDesign.Controls.Remove(InputList[i]);
                InputList[i].Dispose();
            }
            InputList.Clear();

            for (int i = pbCount - 1; i >= 0; i--) {
                BoxDesign.Controls.Remove(GateList[i]);
                GateList[i].Dispose();
            }
            GateList.Clear();

            pbCount = 0;
            inputNum = 0;
        }

        private void PictureAnd_Click(object sender, EventArgs e) {
            string pathStr1 = "and";
            Picture_Click(pathStr1, LabelAnd.Text.Trim());
        }

        private void PictureOr_Click(object sender, EventArgs e) {
            string pathStr1 = "or";
            Picture_Click(pathStr1, LabelOr.Text.Trim());
        }

        private void PictureNot_Click(object sender, EventArgs e) {
            string pathStr1 = "not";
            Picture_Click(pathStr1, LabelNot.Text.Trim());
        }

        private void PictureNand_Click(object sender, EventArgs e) {
            string pathStr1 = "nand";
            Picture_Click(pathStr1, LabelNand.Text.Trim());
        }

        private void PictureNor_Click(object sender, EventArgs e) {
            string pathStr1 = "nor";
            Picture_Click(pathStr1, LabelNor.Text.Trim());
        }

        private void PictureXor_Click(object sender, EventArgs e) {
            string pathStr1 = "xor";
            Picture_Click(pathStr1, LabelXor.Text.Trim());
        }

        private void PictureXnor_Click(object sender, EventArgs e) {
            string pathStr1 = "xnor";
            Picture_Click(pathStr1, LabelXnor.Text.Trim());
        }

        private void PictureWire_Click(object sender, EventArgs e) {
            string pathStr1 = "wire";
            Picture_Click(pathStr1, LabelWire.Text.Trim());
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = MessageBox.Show("您确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Application.ExitThread();   //退出当前线程上的消息循环
            }
            else {
                e.Cancel = true;    //手动取消
            }
        }

        private void InputNum_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }

}
