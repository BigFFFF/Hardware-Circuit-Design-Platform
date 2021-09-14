using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embedded._02_Form
{
    public partial class FrmMain : Form
    {
        private int locationY;
        private uint inputNum;
        private List<TextBox> inputList;

        public FrmMain()
        {
            InitializeComponent();

            locationY = 1;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            this.toolStripStatusLabel1.Text = "您好,欢迎登录系统！" + "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void Picture_Click(string pathStr1, string gateName) {
            string pathStr2 = "", pathStr3 = "";
            int inputI, outputI;

            using FrmGate frmGate = new FrmGate
            {
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
                    try {
                        PictureBox pb = new PictureBox
                        {
                            Image = Image.FromFile(Application.StartupPath + "\\..\\..\\05-Image\\" + pathStr1 + " - " + pathStr2 + pathStr3 + ".png"),
                            Name = pathStr1 + pathStr2 + pathStr3,
                            Location = new Point(57, 35 * locationY),
                            Size = new Size(64, 64)
                        };
                        BoxDesign.Controls.Add(pb);
                        locationY += 2;
                    }
                    catch {
                        MessageBox.Show("选择了错误方向，请检查", "添加门电路错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        frmGate.DialogResult = DialogResult.Cancel;
                    }
                }                
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try {
                inputNum = Convert.ToUInt32(TextInputNum.Text.Trim());
            }
            catch {
                MessageBox.Show("输入端数有误，请检查！", "输入端数错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            inputList = new List<TextBox>();

            for (int i = 1; i < inputNum + 1; i++) {
                TextBox textBox = new TextBox {
                    //int->ASCII->String(A开始)
                    Name = Convert.ToString(Convert.ToChar(64 + i)),
                    Text = Convert.ToString(Convert.ToChar(64 + i)),
                    Location = new Point(25, 35 * i),
                    Size = new Size(32, 32)
                };
                inputList.Add(textBox);
            }
            BoxDesign.Controls.AddRange(inputList.ToArray());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            BoxDesign.Controls.Clear();
            locationY = 1;
        }

        private void PictureAnd_Click(object sender, EventArgs e)
        {
            string pathStr1 = "and";
            Picture_Click(pathStr1, LabelAnd.Text.Trim());
        }

        private void PictureOr_Click(object sender, EventArgs e)
        {
            string pathStr1 = "or";
            Picture_Click(pathStr1, LabelOr.Text.Trim());
        }

        private void PictureNot_Click(object sender, EventArgs e)
        {
            string pathStr1 = "not";
            Picture_Click(pathStr1, LabelNot.Text.Trim());
        }

        private void PictureNand_Click(object sender, EventArgs e)
        {
            string pathStr1 = "nand";
            Picture_Click(pathStr1, LabelNand.Text.Trim());
        }

        private void PictureNor_Click(object sender, EventArgs e)
        {
            string pathStr1 = "nor";
            Picture_Click(pathStr1, LabelNor.Text.Trim());
        }

        private void PictureXor_Click(object sender, EventArgs e)
        {
            string pathStr1 = "xor";
            Picture_Click(pathStr1, LabelXor.Text.Trim());
        }

        private void PictureXnor_Click(object sender, EventArgs e)
        {
            string pathStr1 = "xnor";
            Picture_Click(pathStr1, LabelXnor.Text.Trim());
        }

        private void PictureWire_Click(object sender, EventArgs e)
        {
            string pathStr1 = "wire";
            Picture_Click(pathStr1, LabelWire.Text.Trim());
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();   //退出当前线程上的消息循环
            }
            else
            {
                e.Cancel = true;    //手动取消
            }
        }
    }

}
