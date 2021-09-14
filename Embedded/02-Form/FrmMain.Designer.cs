namespace Embedded._02_Form
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TextInputNum = new System.Windows.Forms.TextBox();
            this.BoxGate = new System.Windows.Forms.GroupBox();
            this.LabelWire = new System.Windows.Forms.Label();
            this.LabelXnor = new System.Windows.Forms.Label();
            this.LabelXor = new System.Windows.Forms.Label();
            this.LabelNor = new System.Windows.Forms.Label();
            this.LabelNand = new System.Windows.Forms.Label();
            this.LabelNot = new System.Windows.Forms.Label();
            this.LabelOr = new System.Windows.Forms.Label();
            this.LabelAnd = new System.Windows.Forms.Label();
            this.PictureWire = new System.Windows.Forms.PictureBox();
            this.PictureXnor = new System.Windows.Forms.PictureBox();
            this.PictureXor = new System.Windows.Forms.PictureBox();
            this.PictureNor = new System.Windows.Forms.PictureBox();
            this.PictureNand = new System.Windows.Forms.PictureBox();
            this.PictureNot = new System.Windows.Forms.PictureBox();
            this.PictureOr = new System.Windows.Forms.PictureBox();
            this.PictureAnd = new System.Windows.Forms.PictureBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxDesign = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SysTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BoxGate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureXnor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureXor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAnd)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入端数：";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.Location = new System.Drawing.Point(28, 68);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(81, 41);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // TextInputNum
            // 
            this.TextInputNum.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextInputNum.Location = new System.Drawing.Point(132, 24);
            this.TextInputNum.Name = "TextInputNum";
            this.TextInputNum.Size = new System.Drawing.Size(88, 30);
            this.TextInputNum.TabIndex = 2;
            // 
            // BoxGate
            // 
            this.BoxGate.Controls.Add(this.LabelWire);
            this.BoxGate.Controls.Add(this.LabelXnor);
            this.BoxGate.Controls.Add(this.LabelXor);
            this.BoxGate.Controls.Add(this.LabelNor);
            this.BoxGate.Controls.Add(this.LabelNand);
            this.BoxGate.Controls.Add(this.LabelNot);
            this.BoxGate.Controls.Add(this.LabelOr);
            this.BoxGate.Controls.Add(this.LabelAnd);
            this.BoxGate.Controls.Add(this.PictureWire);
            this.BoxGate.Controls.Add(this.PictureXnor);
            this.BoxGate.Controls.Add(this.PictureXor);
            this.BoxGate.Controls.Add(this.PictureNor);
            this.BoxGate.Controls.Add(this.PictureNand);
            this.BoxGate.Controls.Add(this.PictureNot);
            this.BoxGate.Controls.Add(this.PictureOr);
            this.BoxGate.Controls.Add(this.PictureAnd);
            this.BoxGate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BoxGate.Location = new System.Drawing.Point(28, 125);
            this.BoxGate.Name = "BoxGate";
            this.BoxGate.Size = new System.Drawing.Size(192, 490);
            this.BoxGate.TabIndex = 3;
            this.BoxGate.TabStop = false;
            this.BoxGate.Text = "器件列表";
            // 
            // LabelWire
            // 
            this.LabelWire.AutoSize = true;
            this.LabelWire.Location = new System.Drawing.Point(90, 439);
            this.LabelWire.Name = "LabelWire";
            this.LabelWire.Size = new System.Drawing.Size(57, 19);
            this.LabelWire.TabIndex = 15;
            this.LabelWire.Text = "导 线";
            // 
            // LabelXnor
            // 
            this.LabelXnor.AutoSize = true;
            this.LabelXnor.Location = new System.Drawing.Point(90, 388);
            this.LabelXnor.Name = "LabelXnor";
            this.LabelXnor.Size = new System.Drawing.Size(66, 19);
            this.LabelXnor.TabIndex = 14;
            this.LabelXnor.Text = "同或门";
            // 
            // LabelXor
            // 
            this.LabelXor.AutoSize = true;
            this.LabelXor.Location = new System.Drawing.Point(90, 332);
            this.LabelXor.Name = "LabelXor";
            this.LabelXor.Size = new System.Drawing.Size(66, 19);
            this.LabelXor.TabIndex = 13;
            this.LabelXor.Text = "异或门";
            // 
            // LabelNor
            // 
            this.LabelNor.AutoSize = true;
            this.LabelNor.Location = new System.Drawing.Point(90, 273);
            this.LabelNor.Name = "LabelNor";
            this.LabelNor.Size = new System.Drawing.Size(66, 19);
            this.LabelNor.TabIndex = 12;
            this.LabelNor.Text = "或非门";
            // 
            // LabelNand
            // 
            this.LabelNand.AutoSize = true;
            this.LabelNand.Location = new System.Drawing.Point(90, 215);
            this.LabelNand.Name = "LabelNand";
            this.LabelNand.Size = new System.Drawing.Size(66, 19);
            this.LabelNand.TabIndex = 11;
            this.LabelNand.Text = "与非门";
            // 
            // LabelNot
            // 
            this.LabelNot.AutoSize = true;
            this.LabelNot.Location = new System.Drawing.Point(90, 158);
            this.LabelNot.Name = "LabelNot";
            this.LabelNot.Size = new System.Drawing.Size(57, 19);
            this.LabelNot.TabIndex = 10;
            this.LabelNot.Text = "非 门";
            // 
            // LabelOr
            // 
            this.LabelOr.AutoSize = true;
            this.LabelOr.Location = new System.Drawing.Point(90, 100);
            this.LabelOr.Name = "LabelOr";
            this.LabelOr.Size = new System.Drawing.Size(57, 19);
            this.LabelOr.TabIndex = 9;
            this.LabelOr.Text = "或 门";
            // 
            // LabelAnd
            // 
            this.LabelAnd.AutoSize = true;
            this.LabelAnd.Location = new System.Drawing.Point(90, 41);
            this.LabelAnd.Name = "LabelAnd";
            this.LabelAnd.Size = new System.Drawing.Size(57, 19);
            this.LabelAnd.TabIndex = 8;
            this.LabelAnd.Text = "与 门";
            // 
            // PictureWire
            // 
            this.PictureWire.Image = global::Embedded.Properties.Resources.wireICO;
            this.PictureWire.Location = new System.Drawing.Point(13, 427);
            this.PictureWire.Name = "PictureWire";
            this.PictureWire.Size = new System.Drawing.Size(50, 50);
            this.PictureWire.TabIndex = 7;
            this.PictureWire.TabStop = false;
            this.PictureWire.Click += new System.EventHandler(this.PictureWire_Click);
            // 
            // PictureXnor
            // 
            this.PictureXnor.Image = global::Embedded.Properties.Resources.xnorICO;
            this.PictureXnor.Location = new System.Drawing.Point(13, 370);
            this.PictureXnor.Name = "PictureXnor";
            this.PictureXnor.Size = new System.Drawing.Size(50, 50);
            this.PictureXnor.TabIndex = 6;
            this.PictureXnor.TabStop = false;
            this.PictureXnor.Click += new System.EventHandler(this.PictureXnor_Click);
            // 
            // PictureXor
            // 
            this.PictureXor.Image = global::Embedded.Properties.Resources.xorICO;
            this.PictureXor.Location = new System.Drawing.Point(13, 313);
            this.PictureXor.Name = "PictureXor";
            this.PictureXor.Size = new System.Drawing.Size(50, 50);
            this.PictureXor.TabIndex = 5;
            this.PictureXor.TabStop = false;
            this.PictureXor.Click += new System.EventHandler(this.PictureXor_Click);
            // 
            // PictureNor
            // 
            this.PictureNor.Image = global::Embedded.Properties.Resources.norICO1;
            this.PictureNor.Location = new System.Drawing.Point(13, 256);
            this.PictureNor.Name = "PictureNor";
            this.PictureNor.Size = new System.Drawing.Size(50, 50);
            this.PictureNor.TabIndex = 4;
            this.PictureNor.TabStop = false;
            this.PictureNor.Click += new System.EventHandler(this.PictureNor_Click);
            // 
            // PictureNand
            // 
            this.PictureNand.Image = global::Embedded.Properties.Resources.nandICO;
            this.PictureNand.Location = new System.Drawing.Point(13, 199);
            this.PictureNand.Name = "PictureNand";
            this.PictureNand.Size = new System.Drawing.Size(50, 50);
            this.PictureNand.TabIndex = 3;
            this.PictureNand.TabStop = false;
            this.PictureNand.Click += new System.EventHandler(this.PictureNand_Click);
            // 
            // PictureNot
            // 
            this.PictureNot.Image = global::Embedded.Properties.Resources.notICO;
            this.PictureNot.Location = new System.Drawing.Point(13, 142);
            this.PictureNot.Name = "PictureNot";
            this.PictureNot.Size = new System.Drawing.Size(50, 50);
            this.PictureNot.TabIndex = 2;
            this.PictureNot.TabStop = false;
            this.PictureNot.Click += new System.EventHandler(this.PictureNot_Click);
            // 
            // PictureOr
            // 
            this.PictureOr.Image = global::Embedded.Properties.Resources.orICO;
            this.PictureOr.Location = new System.Drawing.Point(13, 85);
            this.PictureOr.Name = "PictureOr";
            this.PictureOr.Size = new System.Drawing.Size(50, 50);
            this.PictureOr.TabIndex = 1;
            this.PictureOr.TabStop = false;
            this.PictureOr.Click += new System.EventHandler(this.PictureOr_Click);
            // 
            // PictureAnd
            // 
            this.PictureAnd.Image = global::Embedded.Properties.Resources.andICO;
            this.PictureAnd.Location = new System.Drawing.Point(13, 28);
            this.PictureAnd.Name = "PictureAnd";
            this.PictureAnd.Size = new System.Drawing.Size(50, 50);
            this.PictureAnd.TabIndex = 0;
            this.PictureAnd.TabStop = false;
            this.PictureAnd.Click += new System.EventHandler(this.PictureAnd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDelete.Location = new System.Drawing.Point(139, 68);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(81, 41);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(240, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "表达式：";
            // 
            // BoxDesign
            // 
            this.BoxDesign.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BoxDesign.Location = new System.Drawing.Point(244, 103);
            this.BoxDesign.Name = "BoxDesign";
            this.BoxDesign.Size = new System.Drawing.Size(915, 627);
            this.BoxDesign.TabIndex = 6;
            this.BoxDesign.TabStop = false;
            this.BoxDesign.Text = "设计区域";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(28, 633);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "组件电路";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(139, 633);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 41);
            this.button4.TabIndex = 8;
            this.button4.Text = "重建";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(28, 689);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 41);
            this.button5.TabIndex = 9;
            this.button5.Text = "求表达式";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(139, 689);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 41);
            this.button6.TabIndex = 2;
            this.button6.Text = "求值";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(240, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "逻辑值：";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SysTime,
            this.toolStripStatusLabel2});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 734);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1171, 22);
            this.StatusStrip1.TabIndex = 11;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // SysTime
            // 
            this.SysTime.Name = "SysTime";
            this.SysTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 756);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BoxDesign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BoxGate);
            this.Controls.Add(this.TextInputNum);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "硬件电路设计平台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.BoxGate.ResumeLayout(false);
            this.BoxGate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureXnor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureXor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAnd)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.TextBox TextInputNum;
        private System.Windows.Forms.GroupBox BoxGate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox BoxDesign;
        private System.Windows.Forms.PictureBox PictureAnd;
        private System.Windows.Forms.PictureBox PictureWire;
        private System.Windows.Forms.PictureBox PictureXnor;
        private System.Windows.Forms.PictureBox PictureXor;
        private System.Windows.Forms.PictureBox PictureNor;
        private System.Windows.Forms.PictureBox PictureNand;
        private System.Windows.Forms.PictureBox PictureNot;
        private System.Windows.Forms.PictureBox PictureOr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label LabelWire;
        private System.Windows.Forms.Label LabelXnor;
        private System.Windows.Forms.Label LabelXor;
        private System.Windows.Forms.Label LabelNor;
        private System.Windows.Forms.Label LabelNand;
        private System.Windows.Forms.Label LabelNot;
        private System.Windows.Forms.Label LabelOr;
        private System.Windows.Forms.Label LabelAnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SysTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer Timer;
    }
}