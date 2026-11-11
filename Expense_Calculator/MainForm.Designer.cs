namespace Expense_Calculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            pnlContent = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.HotTrack;
            pnlSidebar.Controls.Add(button2);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Font = new Font("맑은 고딕", 13F);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 853);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1202, 853);
            pnlContent.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 13F);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 63);
            label1.TabIndex = 0;
            label1.Text = "지출계산기";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("맑은 고딕", 10F);
            button1.Location = new Point(3, 48);
            button1.Name = "button1";
            button1.Size = new Size(211, 82);
            button1.TabIndex = 1;
            button1.Text = "지출 내역 관리\r\n(등록/수정/삭제)\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("맑은 고딕", 10F);
            button2.Location = new Point(3, 136);
            button2.Name = "button2";
            button2.Size = new Size(211, 82);
            button2.TabIndex = 2;
            button2.Text = "지출 통계\r\n(합산/분석)";
            button2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1200, 750);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}
