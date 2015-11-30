namespace BookStore
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label_Dept = new System.Windows.Forms.Label();
            this.label_Emp = new System.Windows.Forms.Label();
            this.comboBox_Dept = new System.Windows.Forms.ComboBox();
            this.comboBox_Emp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(689, 491);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.comboBox_Emp);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox_Dept);
            this.splitContainer2.Panel2.Controls.Add(this.label_Emp);
            this.splitContainer2.Panel2.Controls.Add(this.label_Dept);
            this.splitContainer2.Size = new System.Drawing.Size(190, 491);
            this.splitContainer2.SplitterDistance = 112;
            this.splitContainer2.TabIndex = 0;
            // 
            // label_Dept
            // 
            this.label_Dept.AutoSize = true;
            this.label_Dept.Location = new System.Drawing.Point(34, 5);
            this.label_Dept.Name = "label_Dept";
            this.label_Dept.Size = new System.Drawing.Size(53, 12);
            this.label_Dept.TabIndex = 0;
            this.label_Dept.Text = "選擇部門";
            // 
            // label_Emp
            // 
            this.label_Emp.AutoSize = true;
            this.label_Emp.Location = new System.Drawing.Point(34, 41);
            this.label_Emp.Name = "label_Emp";
            this.label_Emp.Size = new System.Drawing.Size(33, 12);
            this.label_Emp.TabIndex = 1;
            this.label_Emp.Text = "label2";
            // 
            // comboBox_Dept
            // 
            this.comboBox_Dept.FormattingEnabled = true;
            this.comboBox_Dept.Location = new System.Drawing.Point(36, 20);
            this.comboBox_Dept.Name = "comboBox_Dept";
            this.comboBox_Dept.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Dept.TabIndex = 2;
            // 
            // comboBox_Emp
            // 
            this.comboBox_Emp.FormattingEnabled = true;
            this.comboBox_Emp.Location = new System.Drawing.Point(36, 56);
            this.comboBox_Emp.Name = "comboBox_Emp";
            this.comboBox_Emp.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Emp.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 491);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox comboBox_Emp;
        private System.Windows.Forms.ComboBox comboBox_Dept;
        private System.Windows.Forms.Label label_Emp;
        private System.Windows.Forms.Label label_Dept;
    }
}

