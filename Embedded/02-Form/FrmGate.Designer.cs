namespace Embedded._02_Form
{
    partial class FrmGate
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LabelIn = new System.Windows.Forms.Label();
            this.LabelOut = new System.Windows.Forms.Label();
            this.ComboBoxIn = new System.Windows.Forms.ComboBox();
            this.ComboBoxOut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.Location = new System.Drawing.Point(47, 152);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 40);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(191, 152);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 40);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LabelIn
            // 
            this.LabelIn.AutoSize = true;
            this.LabelIn.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelIn.Location = new System.Drawing.Point(28, 49);
            this.LabelIn.Name = "LabelIn";
            this.LabelIn.Size = new System.Drawing.Size(157, 21);
            this.LabelIn.TabIndex = 2;
            this.LabelIn.Text = "输入引脚方向：";
            // 
            // LabelOut
            // 
            this.LabelOut.AutoSize = true;
            this.LabelOut.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOut.Location = new System.Drawing.Point(28, 103);
            this.LabelOut.Name = "LabelOut";
            this.LabelOut.Size = new System.Drawing.Size(157, 21);
            this.LabelOut.TabIndex = 3;
            this.LabelOut.Text = "输出引脚方向：";
            // 
            // ComboBoxIn
            // 
            this.ComboBoxIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxIn.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxIn.FormattingEnabled = true;
            this.ComboBoxIn.Items.AddRange(new object[] {
            "上",
            "下",
            "上下"});
            this.ComboBoxIn.Location = new System.Drawing.Point(191, 46);
            this.ComboBoxIn.Name = "ComboBoxIn";
            this.ComboBoxIn.Size = new System.Drawing.Size(123, 29);
            this.ComboBoxIn.TabIndex = 4;
            // 
            // ComboBoxOut
            // 
            this.ComboBoxOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOut.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxOut.FormattingEnabled = true;
            this.ComboBoxOut.Items.AddRange(new object[] {
            "上",
            "下",
            "上下"});
            this.ComboBoxOut.Location = new System.Drawing.Point(191, 100);
            this.ComboBoxOut.Name = "ComboBoxOut";
            this.ComboBoxOut.Size = new System.Drawing.Size(123, 29);
            this.ComboBoxOut.TabIndex = 5;
            // 
            // FrmGate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 219);
            this.Controls.Add(this.ComboBoxOut);
            this.Controls.Add(this.ComboBoxIn);
            this.Controls.Add(this.LabelOut);
            this.Controls.Add(this.LabelIn);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Name = "FrmGate";
            this.Text = "FrmGate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LabelIn;
        private System.Windows.Forms.Label LabelOut;
        private System.Windows.Forms.ComboBox ComboBoxIn;
        private System.Windows.Forms.ComboBox ComboBoxOut;

        public int ComboBoxInIndex {
            get { return ComboBoxIn.SelectedIndex; }
            set { ComboBoxIn.SelectedIndex = value; }
        }
        public int ComboBoxOutIndex {
            get { return ComboBoxOut.SelectedIndex; }
            set { ComboBoxOut.SelectedIndex = value; }
        }
    }
}