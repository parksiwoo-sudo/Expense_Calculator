namespace Expense_Calculator.Controls
{
    partial class ExpensePage
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensePage));
            dtpDate = new DateTimePicker();
            cboCategory = new ComboBox();
            txtDescription = new TextBox();
            nudAmount = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lvExpenses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            imageList1 = new ImageList(components);
            lblTotalAmount = new Label();
            lblExpenseCount = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            progressBarBudget = new ProgressBar();
            lblPercent = new Label();
            label10 = new Label();
            txtBudget = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("맑은 고딕", 9F);
            dtpDate.Location = new Point(21, 283);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(243, 31);
            dtpDate.TabIndex = 0;
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("맑은 고딕", 9F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "식비", "교통비", "문화생활", "쇼핑", "기타" });
            cboCategory.Location = new Point(270, 281);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(222, 33);
            cboCategory.TabIndex = 1;
            cboCategory.Text = "카테고리";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("맑은 고딕", 9F);
            txtDescription.Location = new Point(498, 283);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 31);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "지출 내용";
            // 
            // nudAmount
            // 
            nudAmount.Font = new Font("맑은 고딕", 9F);
            nudAmount.Location = new Point(654, 281);
            nudAmount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(180, 31);
            nudAmount.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("맑은 고딕", 9F);
            btnAdd.Location = new Point(840, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "등록";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("맑은 고딕", 9F);
            btnUpdate.Location = new Point(958, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "수정";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("맑은 고딕", 9F);
            btnDelete.Location = new Point(1076, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvExpenses
            // 
            lvExpenses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvExpenses.Location = new Point(21, 387);
            lvExpenses.Name = "lvExpenses";
            lvExpenses.Size = new Size(741, 210);
            lvExpenses.SmallImageList = imageList1;
            lvExpenses.TabIndex = 7;
            lvExpenses.UseCompatibleStateImageBehavior = false;
            lvExpenses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "번호";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "날짜";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "카테고리";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "지출 내용";
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "금액";
            columnHeader5.Width = 100;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "bus.png.png");
            imageList1.Images.SetKeyName(1, "Fork.png.png");
            imageList1.Images.SetKeyName(2, "cat.png.png");
            imageList1.Images.SetKeyName(3, "shopping.png.png");
            imageList1.Images.SetKeyName(4, "film.png.png");
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotalAmount.Location = new Point(86, 128);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(156, 25);
            lblTotalAmount.TabIndex = 8;
            lblTotalAmount.Text = "총 지출 금액 표기";
            // 
            // lblExpenseCount
            // 
            lblExpenseCount.AutoSize = true;
            lblExpenseCount.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblExpenseCount.Location = new Point(320, 125);
            lblExpenseCount.Name = "lblExpenseCount";
            lblExpenseCount.Size = new Size(150, 25);
            lblExpenseCount.TabIndex = 9;
            lblExpenseCount.Text = "등록된 내역 표기";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F);
            label3.Location = new Point(101, 333);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 10;
            label3.Text = "지출 내역 목록";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F);
            label2.Location = new Point(17, 236);
            label2.Name = "label2";
            label2.Size = new Size(57, 30);
            label2.TabIndex = 12;
            label2.Text = "날짜";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11F);
            label4.Location = new Point(284, 236);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 13;
            label4.Text = "카테고리";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 11F);
            label5.Location = new Point(494, 236);
            label5.Name = "label5";
            label5.Size = new Size(109, 30);
            label5.TabIndex = 14;
            label5.Text = "지출 내용";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 11F);
            label6.Location = new Point(650, 236);
            label6.Name = "label6";
            label6.Size = new Size(57, 30);
            label6.TabIndex = 15;
            label6.Text = "금액";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11F);
            label1.Location = new Point(17, 78);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 16;
            label1.Text = "총 지출 금액";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 11F);
            label7.Location = new Point(266, 78);
            label7.Name = "label7";
            label7.Size = new Size(131, 30);
            label7.TabIndex = 17;
            label7.Text = "등록된 내역";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11F);
            label8.Location = new Point(494, 78);
            label8.Name = "label8";
            label8.Size = new Size(87, 30);
            label8.TabIndex = 18;
            label8.Text = "월 예산";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label9.Location = new Point(86, 13);
            label9.Name = "label9";
            label9.Size = new Size(205, 38);
            label9.TabIndex = 19;
            label9.Text = "지출 내역 관리";
            // 
            // progressBarBudget
            // 
            progressBarBudget.Location = new Point(719, 125);
            progressBarBudget.Name = "progressBarBudget";
            progressBarBudget.Size = new Size(243, 34);
            progressBarBudget.TabIndex = 20;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("맑은 고딕", 11F);
            lblPercent.Location = new Point(719, 78);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(79, 30);
            lblPercent.TabIndex = 21;
            lblPercent.Text = "퍼센트";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 11F);
            label10.Location = new Point(836, 236);
            label10.Name = "label10";
            label10.Size = new Size(230, 30);
            label10.TabIndex = 22;
            label10.Text = "지출 내역 등록 / 수정";
            // 
            // txtBudget
            // 
            txtBudget.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtBudget.Location = new Point(494, 125);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(150, 31);
            txtBudget.TabIndex = 23;
            txtBudget.Text = "월 예산 표기";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar_png;
            pictureBox1.Location = new Point(266, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.list_png;
            pictureBox2.Location = new Point(21, 333);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pen_png;
            pictureBox3.Location = new Point(17, 185);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.coins_png;
            pictureBox4.Location = new Point(17, 119);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.shopping_png;
            pictureBox5.Location = new Point(17, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 12F);
            label11.Location = new Point(92, 185);
            label11.Name = "label11";
            label11.Size = new Size(222, 32);
            label11.TabIndex = 29;
            label11.Text = "지출내역 수정 관리";
            // 
            // ExpensePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label11);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtBudget);
            Controls.Add(label10);
            Controls.Add(lblPercent);
            Controls.Add(progressBarBudget);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblExpenseCount);
            Controls.Add(lblTotalAmount);
            Controls.Add(lvExpenses);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(nudAmount);
            Controls.Add(txtDescription);
            Controls.Add(cboCategory);
            Controls.Add(dtpDate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ExpensePage";
            Size = new Size(1200, 613);
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private ComboBox cboCategory;
        private TextBox txtDescription;
        private NumericUpDown nudAmount;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvExpenses;
        private Label lblTotalAmount;
        private Label lblExpenseCount;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private ProgressBar progressBarBudget;
        private Label lblPercent;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label10;
        private TextBox txtBudget;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label11;
    }
}
