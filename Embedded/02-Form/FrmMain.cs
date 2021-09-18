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

    /// <summary>
    /// 主窗体类
    /// </summary>
    public partial class FrmMain : Form {

        /// <summary>
        /// 门电路数
        /// </summary>
        private int pbCount;

        /// <summary>
        /// 输入端数
        /// </summary>
        private int inputNum;

        /// <summary>
        /// 二叉树数
        /// </summary>
        private int bTSun;

        /// <summary>
        /// 输入端数列表
        /// </summary>
        private List<TextBox> inputList;

        /// <summary>
        /// 门电路数列表
        /// </summary>
        private List<PictureBox> gateList;

        /// <summary>
        /// 门电路二叉树映射
        /// </summary>
        private Gate[] bGate;

        /// <summary>
        /// 二叉树数组
        /// </summary>
        private BinaryTree[] bTree;

        public int PbCount { get => pbCount; set => pbCount = value; }
        public int InputNum { get => inputNum; set => inputNum = value; }
        public int BTSun { get => bTSun; set => bTSun = value; }
        public List<TextBox> InputList { get => inputList; set => inputList = value; }
        public List<PictureBox> GateList { get => gateList; set => gateList = value; }
        public Gate[] BGate { get => bGate; set => bGate = value; }
        public BinaryTree[] BTree { get => bTree; set => bTree = value; }
        
        public FrmMain() {
            InitializeComponent();

            InitFrmMain();
        }

        private void InitFrmMain() {
            PbCount = 0;
            InputNum = 0;
            InputList = new List<TextBox>();
            GateList = new List<PictureBox>();
            BGate = new Gate[127];
            BTree = new BinaryTree[16];

            foreach (Control ctrl in BoxDesign.Controls) {
                new MoveControl(ctrl);
            }
        }


        private void FrmMain_Load(object sender, EventArgs e) {
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {

            toolStripStatusLabel1.Text = "您好,欢迎登录系统！" + "当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        /// <summary>
        /// 电路图片点击置放
        /// </summary>
        /// <param name="pathStr1"></param>
        /// <param name="gateName"></param>
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
                        GateList[PbCount].Image = Image.FromFile(Application.StartupPath + "\\..\\..\\05-Image\\" + pathStr1 + " - " + pathStr2 + pathStr3 + ".png");
                        GateList[PbCount].Name = pathStr1 + pathStr2 + pathStr3;
                        GateList[PbCount].Size = new Size(PublicVar.PicGateWV, PublicVar.PicGateHV);
                        GateList[PbCount].Location = new Point(PublicVar.PicGateWV * ((PbCount / 8)  + 1), PublicVar.PicGateHV * ((PbCount % 8) + 1));
                        GateList[PbCount].DoubleClick += new EventHandler(GateDouble_Click);

                        new MoveControl(GateList[PbCount]);

                        PbCount++;
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

        /// <summary>
        /// 双击电路图片删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GateDouble_Click(object sender, EventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;

            BoxDesign.Controls.Remove(pictureBox);           
            GateList.Remove(pictureBox);
            pictureBox.Dispose();

            PbCount--;
        }

        /// <summary>
        /// 输入端数确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirm_Click(object sender, EventArgs e) {

            try {
                if (TextInputNum.Text.Length == 0 || Convert.ToInt32(TextInputNum.Text.Trim()) > 127) {
                    MessageBox.Show("输入端数有误，请检查！", "输入端数错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = InputNum - 1; i >= 0; i--) {
                    BoxDesign.Controls.Remove(InputList[i]);
                    InputList[i].Dispose();
                }
                InputList.Clear();

                InputNum = Convert.ToInt32(TextInputNum.Text.Trim());
               
            }
            catch {
                MessageBox.Show("输入端数有误，请检查！", "输入端数错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < InputNum; i++) {
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

        /// <summary>
        /// 清空设计区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e) {
            for (int i = InputNum - 1; i >= 0; i--) {
                BoxDesign.Controls.Remove(InputList[i]);
                InputList[i].Dispose();
            }
            InputList.Clear();

            for (int i = PbCount - 1; i >= 0; i--) {
                BoxDesign.Controls.Remove(GateList[i]);
                GateList[i].Dispose();
            }
            GateList.Clear();

            BoxDesign.Controls.Clear();

            BtnReconstruction_Click(sender, e);

            TextInputNum.Text = String.Empty;

            InitFrmMain();
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

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = MessageBox.Show("您确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Application.ExitThread();   //退出当前线程上的消息循环
            }
            else {
                e.Cancel = true;    //手动取消
            }
        }

        /// <summary>
        /// 输入端数限制输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNum_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 组件电路
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnComponent_Click(object sender, EventArgs e) {
            int preK, k = 0;

            BTSun = 0;

            //输入端数与门电路对接
            for (int i = 0; i < InputNum; i++) {
                if (BGate[i] == null) {
                    BGate[i] = new Gate(InputList[i].Text);
                }
                preK = k;
                for(int j = 0; j < PbCount; j++) {
                    if ((InputList[i].Location.Y == GateList[j].Location.Y) && ((InputList[i].Location.X + PublicVar.PicGateWV) == GateList[j].Location.X)) {
                        if (BGate[j + InputNum] == null) {
                            BGate[j + InputNum] = new Gate();
                        }
                        BGate[j + InputNum].CalBDS(GateList[j].Name.Substring(GateList[j].Name.Length - 2), GateList[j].Name.Substring(0, GateList[j].Name.Length - 2));
                        BGate[j + InputNum].LChild = BGate[i];
                        k++;
                        break;
                    }
                    else if ((InputList[i].Location.Y == (GateList[j].Location.Y + PublicVar.PicGateHV / 2)) && ((InputList[i].Location.X + PublicVar.PicGateWV) == GateList[j].Location.X)) {
                        if (BGate[j + InputNum] == null) {
                            BGate[j + InputNum] = new Gate();
                        }
                        BGate[j + InputNum].CalBDS(GateList[j].Name.Substring(GateList[j].Name.Length - 2), GateList[j].Name.Substring(0, GateList[j].Name.Length - 2));
                        BGate[j + InputNum].RChild = BGate[i];
                        k++;
                        break;
                    }
                }
                if (preK == k) {
                    //为根节点，组建一棵树
                    BTree[BTSun] = new BinaryTree(BGate[i]);

                    BTSun++;
                }
            }

            //门电路与门电路对接
            for (int i = 0; i < PbCount; i++) {
                preK = k;
                if (BGate[i + InputNum] == null) {
                    BGate[i + InputNum] = new Gate(GateList[i].Name.Substring(GateList[i].Name.Length - 2), GateList[i].Name.Substring(0, GateList[i].Name.Length - 2));
                }
                for (int j = 0; j < PbCount; j++) {
                    if (i == j) {
                        continue;
                    }
                    //比较前低后高
                    if ((GateList[i].Location.Y == (GateList[j].Location.Y + PublicVar.PicGateHV / 2)) && ((GateList[i].Location.X + PublicVar.PicGateWV) == GateList[j].Location.X)) {
                        if ((GateList[i].Name.Substring(GateList[i].Name.Length - 1) == "s") || (GateList[i].Name.Substring(GateList[j].Name.Length - 1) == "2")) {
                            if (BGate[j + InputNum] == null) {
                                BGate[j + InputNum] = new Gate();
                            }
                            BGate[j + InputNum].CalBDS(GateList[j].Name.Substring(GateList[j].Name.Length - 2), GateList[j].Name.Substring(0, GateList[j].Name.Length - 2));
                            BGate[j + InputNum].RChild = BGate[i + InputNum];
                            k++;
                        }
                    }
                    //比较前高后低
                    if ((GateList[j].Location.Y == (GateList[i].Location.Y + PublicVar.PicGateHV / 2)) && ((GateList[i].Location.X + PublicVar.PicGateWV) == GateList[j].Location.X)) {
                        if ((GateList[i].Name.Substring(GateList[i].Name.Length - 1) == "x") || (GateList[i].Name.Substring(GateList[i].Name.Length - 1) == "2")) {
                            if (BGate[j + InputNum] == null) {
                                BGate[j + InputNum] = new Gate();
                            }
                            BGate[j + InputNum].CalBDS(GateList[j].Name.Substring(GateList[j].Name.Length - 2), GateList[j].Name.Substring(0, GateList[j].Name.Length - 2));
                            BGate[j + InputNum].LChild = BGate[i + InputNum];
                            k++;
                        }
                    }
                }
                if (preK == k) {
                    BTree[BTSun] = new BinaryTree(BGate[i + InputNum]);

                    BTSun++;
                }
            }
            BtnComponent.Enabled = false;
            BtnReconstruction.Enabled = true;
            BtnEvaluation.Enabled = true;
            BtnExpression.Enabled = true;
            
        }

        /// <summary>
        /// 求表达式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExpression_Click(object sender, EventArgs e) {
            string tempText = String.Empty;

            for (int i = 0; i < InputNum; i++) {
                BGate[i].SetGateVar(InputList[i].Text);
            }

            for (int i = 0; i < BTSun; i++) {
                BTree[i].PostOrder_CalBDS_ReplaceBd(BTree[i].Head);

                tempText = tempText + "No" + i.ToString() + "=" + BTree[i].Head.Bd + ";";
            }
            LabelExpression.Text += tempText;
        }
        
        /// <summary>
        /// 求逻辑值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEvaluation_Click(object sender, EventArgs e) {
            string tempText = String.Empty;

            for (int i = 0; i < InputNum; i++) {
                BGate[i].SetGateVar(InputList[i].Text);
            }
            for (int i = 0; i < BTSun; i++) {
                BTree[i].PostOrder_Cal(BTree[i].Head);

                tempText = tempText + "No" + i.ToString() + "=" + BTree[i].Head.BGateVal + ";";
            }
            LabelEvaluation.Text += tempText;
        }

        /// <summary>
        /// 重建表达式，逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReconstruction_Click(object sender, EventArgs e) {

            BtnComponent.Enabled = true;
            BtnReconstruction.Enabled = false;

            LabelExpression.Text = "表达式：";
            LabelEvaluation.Text = "逻辑值：";


            for (int i = BTSun - 1; i >= 0; i--) {
                if (BTree[i] != null) {
                    BTree[i].Data = String.Empty;
                    BTree[i].Dispose();
                }
            }

            BTSun = 0;

            for (int i = InputNum - 1; i >= 0; i--) {
                if (BGate[i] != null) {
                    BGate[i].Dispose();
                }
            }

            BGate = new Gate[127];
            BTree = new BinaryTree[16];
        }
    }

}
