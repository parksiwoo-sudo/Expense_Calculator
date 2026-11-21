namespace Expense_Calculator.Controls
{
    partial class StatisticsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsPage));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "식비", "\\", "%" }, -1, Color.Empty, Color.Empty, new Font("맑은 고딕", 10F));
            ListViewItem listViewItem2 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "교통비", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 10F)), new ListViewItem.ListViewSubItem(null, "\\", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)), new ListViewItem.ListViewSubItem(null, "%", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)) }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "쇼핑", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 10F)), new ListViewItem.ListViewSubItem(null, "\\", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)), new ListViewItem.ListViewSubItem(null, "%", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)) }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "문화생활", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 10F)), new ListViewItem.ListViewSubItem(null, "\\", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)), new ListViewItem.ListViewSubItem(null, "%", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)) }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "기타", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 10F)), new ListViewItem.ListViewSubItem(null, "\\", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)), new ListViewItem.ListViewSubItem(null, "%", SystemColors.WindowText, SystemColors.Window, new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129)) }, -1);
            pnlHeader = new Panel();
            picHeader = new PictureBox();
            lblSubTitle = new Label();
            lblTitle = new Label();
            cardSummary = new Panel();
            pnlSummaryInner = new Panel();
            lblCountValue = new Label();
            number = new Label();
            pic = new PictureBox();
            picTotal = new PictureBox();
            lblTotalValue = new Label();
            amount = new Label();
            lblSummaryTitle = new Label();
            picSummary = new PictureBox();
            cardPeriod = new Panel();
            pnlPeriodSum = new Panel();
            lblPeriodValue = new Label();
            label11 = new Label();
            btnSearch = new Button();
            cboMonth = new ComboBox();
            Month = new Label();
            cboYear = new ComboBox();
            picCount = new PictureBox();
            Year = new Label();
            lblPeriodTitle = new Label();
            cardCategory = new Panel();
            picChart = new PictureBox();
            lvCategory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lblCategoryTitle = new Label();
            picCategory = new PictureBox();
            cardBudget = new Panel();
            label1 = new Label();
            panel10 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            lblRemainPercent = new Label();
            lblUsedPercent = new Label();
            pbBudget = new ProgressBar();
            lblRemainValue = new Label();
            above = new Label();
            lblBudgetValue = new Label();
            NOW = new Label();
            lblUsedValue = new Label();
            MonthBudget = new Label();
            lblBudgetTitle = new Label();
            picBudget = new PictureBox();
            imgColors = new ImageList(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHeader).BeginInit();
            cardSummary.SuspendLayout();
            pnlSummaryInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSummary).BeginInit();
            cardPeriod.SuspendLayout();
            pnlPeriodSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCount).BeginInit();
            cardCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCategory).BeginInit();
            cardBudget.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBudget).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(picHeader);
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(949, 100);
            pnlHeader.TabIndex = 0;
            // 
            // picHeader
            // 
            picHeader.Image = (Image)resources.GetObject("picHeader.Image");
            picHeader.Location = new Point(7, 10);
            picHeader.Name = "picHeader";
            picHeader.Size = new Size(59, 59);
            picHeader.SizeMode = PictureBoxSizeMode.Zoom;
            picHeader.TabIndex = 1;
            picHeader.TabStop = false;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("맑은 고딕", 10F);
            lblSubTitle.ForeColor = Color.Black;
            lblSubTitle.Location = new Point(72, 48);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(402, 19);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "등록된 지출 내역을 기반으로 지출 현황을 확인할 수 있습니다.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(70, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "지출 통계 및 분석";
            // 
            // cardSummary
            // 
            cardSummary.BackColor = Color.White;
            cardSummary.Controls.Add(pnlSummaryInner);
            cardSummary.Controls.Add(lblSummaryTitle);
            cardSummary.Controls.Add(picSummary);
            cardSummary.Location = new Point(15, 100);
            cardSummary.Name = "cardSummary";
            cardSummary.Size = new Size(465, 225);
            cardSummary.TabIndex = 1;
            // 
            // pnlSummaryInner
            // 
            pnlSummaryInner.BackColor = Color.FromArgb(245, 247, 252);
            pnlSummaryInner.Controls.Add(lblCountValue);
            pnlSummaryInner.Controls.Add(number);
            pnlSummaryInner.Controls.Add(pic);
            pnlSummaryInner.Controls.Add(picTotal);
            pnlSummaryInner.Controls.Add(lblTotalValue);
            pnlSummaryInner.Controls.Add(amount);
            pnlSummaryInner.Location = new Point(20, 65);
            pnlSummaryInner.Name = "pnlSummaryInner";
            pnlSummaryInner.Size = new Size(432, 127);
            pnlSummaryInner.TabIndex = 2;
            // 
            // lblCountValue
            // 
            lblCountValue.AutoSize = true;
            lblCountValue.Font = new Font("맑은 고딕", 17F, FontStyle.Bold);
            lblCountValue.Location = new Point(341, 49);
            lblCountValue.Name = "lblCountValue";
            lblCountValue.Size = new Size(50, 31);
            lblCountValue.TabIndex = 6;
            lblCountValue.Text = "0건";
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(339, 30);
            number.Name = "number";
            number.Size = new Size(59, 15);
            number.TabIndex = 5;
            number.Text = "등록 건수";
            // 
            // pic
            // 
            pic.Image = (Image)resources.GetObject("pic.Image");
            pic.Location = new Point(269, 22);
            pic.Name = "pic";
            pic.Size = new Size(64, 64);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 4;
            pic.TabStop = false;
            // 
            // picTotal
            // 
            picTotal.Image = (Image)resources.GetObject("picTotal.Image");
            picTotal.Location = new Point(12, 22);
            picTotal.Name = "picTotal";
            picTotal.Size = new Size(64, 64);
            picTotal.SizeMode = PictureBoxSizeMode.Zoom;
            picTotal.TabIndex = 2;
            picTotal.TabStop = false;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("맑은 고딕", 17F, FontStyle.Bold);
            lblTotalValue.Location = new Point(82, 49);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(46, 31);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "₩0";
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Location = new Point(82, 32);
            amount.Name = "amount";
            amount.Size = new Size(75, 15);
            amount.TabIndex = 0;
            amount.Text = "총 지출 금액";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblSummaryTitle.Location = new Point(58, 14);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(140, 25);
            lblSummaryTitle.TabIndex = 1;
            lblSummaryTitle.Text = "전체 지출 요약";
            // 
            // picSummary
            // 
            picSummary.Image = (Image)resources.GetObject("picSummary.Image");
            picSummary.Location = new Point(15, 10);
            picSummary.Name = "picSummary";
            picSummary.Size = new Size(36, 36);
            picSummary.SizeMode = PictureBoxSizeMode.Zoom;
            picSummary.TabIndex = 0;
            picSummary.TabStop = false;
            // 
            // cardPeriod
            // 
            cardPeriod.BackColor = Color.White;
            cardPeriod.Controls.Add(pnlPeriodSum);
            cardPeriod.Controls.Add(btnSearch);
            cardPeriod.Controls.Add(cboMonth);
            cardPeriod.Controls.Add(Month);
            cardPeriod.Controls.Add(cboYear);
            cardPeriod.Controls.Add(picCount);
            cardPeriod.Controls.Add(Year);
            cardPeriod.Controls.Add(lblPeriodTitle);
            cardPeriod.Location = new Point(486, 100);
            cardPeriod.Name = "cardPeriod";
            cardPeriod.Size = new Size(450, 225);
            cardPeriod.TabIndex = 2;
            // 
            // pnlPeriodSum
            // 
            pnlPeriodSum.BackColor = Color.FromArgb(245, 247, 252);
            pnlPeriodSum.Controls.Add(lblPeriodValue);
            pnlPeriodSum.Controls.Add(label11);
            pnlPeriodSum.Location = new Point(27, 149);
            pnlPeriodSum.Name = "pnlPeriodSum";
            pnlPeriodSum.Size = new Size(402, 42);
            pnlPeriodSum.TabIndex = 7;
            // 
            // lblPeriodValue
            // 
            lblPeriodValue.Font = new Font("맑은 고딕", 15F);
            lblPeriodValue.ForeColor = Color.FromArgb(0, 70, 200);
            lblPeriodValue.Location = new Point(186, 0);
            lblPeriodValue.Name = "lblPeriodValue";
            lblPeriodValue.Size = new Size(233, 35);
            lblPeriodValue.TabIndex = 1;
            lblPeriodValue.Text = "\\";
            lblPeriodValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 13F);
            label11.Location = new Point(6, 8);
            label11.Name = "label11";
            label11.Size = new Size(174, 25);
            label11.TabIndex = 0;
            label11.Text = "조회 기간 지출 합계";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 102, 255);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(303, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 33);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "조회";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboMonth
            // 
            cboMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonth.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            cboMonth.FormattingEnabled = true;
            cboMonth.Items.AddRange(new object[] { "", "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" });
            cboMonth.Location = new Point(188, 83);
            cboMonth.Name = "cboMonth";
            cboMonth.Size = new Size(86, 29);
            cboMonth.TabIndex = 5;
            // 
            // Month
            // 
            Month.AutoSize = true;
            Month.Location = new Point(188, 65);
            Month.Name = "Month";
            Month.Size = new Size(19, 15);
            Month.TabIndex = 4;
            Month.Text = "월";
            // 
            // cboYear
            // 
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYear.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(59, 83);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(110, 29);
            cboYear.TabIndex = 3;
            // 
            // picCount
            // 
            picCount.Image = (Image)resources.GetObject("picCount.Image");
            picCount.Location = new Point(24, 10);
            picCount.Name = "picCount";
            picCount.Size = new Size(36, 36);
            picCount.SizeMode = PictureBoxSizeMode.Zoom;
            picCount.TabIndex = 2;
            picCount.TabStop = false;
            // 
            // Year
            // 
            Year.AutoSize = true;
            Year.Location = new Point(58, 65);
            Year.Name = "Year";
            Year.Size = new Size(31, 15);
            Year.TabIndex = 1;
            Year.Text = "연도";
            // 
            // lblPeriodTitle
            // 
            lblPeriodTitle.AutoSize = true;
            lblPeriodTitle.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblPeriodTitle.Location = new Point(66, 14);
            lblPeriodTitle.Name = "lblPeriodTitle";
            lblPeriodTitle.Size = new Size(159, 25);
            lblPeriodTitle.TabIndex = 0;
            lblPeriodTitle.Text = "기간별 지출 조회";
            // 
            // cardCategory
            // 
            cardCategory.BackColor = Color.White;
            cardCategory.Controls.Add(picChart);
            cardCategory.Controls.Add(lvCategory);
            cardCategory.Controls.Add(lblCategoryTitle);
            cardCategory.Controls.Add(picCategory);
            cardCategory.Location = new Point(15, 331);
            cardCategory.Name = "cardCategory";
            cardCategory.Size = new Size(531, 244);
            cardCategory.TabIndex = 3;
            // 
            // picChart
            // 
            picChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picChart.BackColor = Color.White;
            picChart.Location = new Point(32, 70);
            picChart.Name = "picChart";
            picChart.Size = new Size(145, 157);
            picChart.TabIndex = 3;
            picChart.TabStop = false;
            // 
            // lvCategory
            // 
            lvCategory.BorderStyle = BorderStyle.None;
            lvCategory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvCategory.Font = new Font("맑은 고딕", 10F);
            lvCategory.FullRowSelect = true;
            lvCategory.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvCategory.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            lvCategory.Location = new Point(225, 66);
            lvCategory.Name = "lvCategory";
            lvCategory.Scrollable = false;
            lvCategory.Size = new Size(303, 176);
            lvCategory.TabIndex = 2;
            lvCategory.UseCompatibleStateImageBehavior = false;
            lvCategory.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "카테고리";
            columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "지출 금액";
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "비율";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 90;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblCategoryTitle.Location = new Point(58, 14);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(197, 25);
            lblCategoryTitle.TabIndex = 1;
            lblCategoryTitle.Text = "카테고리별 지출 통계";
            // 
            // picCategory
            // 
            picCategory.Image = (Image)resources.GetObject("picCategory.Image");
            picCategory.Location = new Point(15, 10);
            picCategory.Name = "picCategory";
            picCategory.Size = new Size(36, 36);
            picCategory.SizeMode = PictureBoxSizeMode.Zoom;
            picCategory.TabIndex = 0;
            picCategory.TabStop = false;
            // 
            // cardBudget
            // 
            cardBudget.BackColor = Color.White;
            cardBudget.Controls.Add(label1);
            cardBudget.Controls.Add(panel10);
            cardBudget.Controls.Add(panel8);
            cardBudget.Controls.Add(lblRemainPercent);
            cardBudget.Controls.Add(lblUsedPercent);
            cardBudget.Controls.Add(pbBudget);
            cardBudget.Controls.Add(lblRemainValue);
            cardBudget.Controls.Add(above);
            cardBudget.Controls.Add(lblBudgetValue);
            cardBudget.Controls.Add(NOW);
            cardBudget.Controls.Add(lblUsedValue);
            cardBudget.Controls.Add(MonthBudget);
            cardBudget.Controls.Add(lblBudgetTitle);
            cardBudget.Controls.Add(picBudget);
            cardBudget.Location = new Point(552, 331);
            cardBudget.Name = "cardBudget";
            cardBudget.Size = new Size(373, 244);
            cardBudget.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(122, 87);
            label1.Name = "label1";
            label1.Size = new Size(174, 30);
            label1.TabIndex = 14;
            label1.Text = "\\";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(230, 233, 240);
            panel10.Location = new Point(23, 83);
            panel10.Name = "panel10";
            panel10.Size = new Size(375, 1);
            panel10.TabIndex = 13;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(230, 233, 240);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(20, 120);
            panel8.Name = "panel8";
            panel8.Size = new Size(375, 1);
            panel8.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(230, 233, 240);
            panel9.Location = new Point(0, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(375, 1);
            panel9.TabIndex = 12;
            // 
            // lblRemainPercent
            // 
            lblRemainPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRemainPercent.Location = new Point(269, 207);
            lblRemainPercent.Name = "lblRemainPercent";
            lblRemainPercent.Size = new Size(86, 20);
            lblRemainPercent.TabIndex = 10;
            lblRemainPercent.Text = "100.0% 남음";
            lblRemainPercent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUsedPercent
            // 
            lblUsedPercent.AutoSize = true;
            lblUsedPercent.ForeColor = Color.FromArgb(30, 60, 140);
            lblUsedPercent.Location = new Point(23, 207);
            lblUsedPercent.Name = "lblUsedPercent";
            lblUsedPercent.Size = new Size(62, 15);
            lblUsedPercent.TabIndex = 9;
            lblUsedPercent.Text = "0.0% 사용";
            // 
            // pbBudget
            // 
            pbBudget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbBudget.Location = new Point(23, 180);
            pbBudget.Name = "pbBudget";
            pbBudget.Size = new Size(332, 24);
            pbBudget.TabIndex = 8;
            // 
            // lblRemainValue
            // 
            lblRemainValue.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblRemainValue.Location = new Point(190, 180);
            lblRemainValue.Name = "lblRemainValue";
            lblRemainValue.Size = new Size(205, 30);
            lblRemainValue.TabIndex = 7;
            lblRemainValue.Text = "\\";
            lblRemainValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // above
            // 
            above.AutoSize = true;
            above.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            above.Location = new Point(23, 130);
            above.Name = "above";
            above.Size = new Size(80, 21);
            above.TabIndex = 6;
            above.Text = "남은 예산";
            // 
            // lblBudgetValue
            // 
            lblBudgetValue.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblBudgetValue.Location = new Point(107, 48);
            lblBudgetValue.Name = "lblBudgetValue";
            lblBudgetValue.Size = new Size(190, 30);
            lblBudgetValue.TabIndex = 5;
            lblBudgetValue.Text = "\\";
            lblBudgetValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NOW
            // 
            NOW.AutoSize = true;
            NOW.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            NOW.Location = new Point(23, 92);
            NOW.Name = "NOW";
            NOW.Size = new Size(80, 21);
            NOW.TabIndex = 4;
            NOW.Text = "현재 지출";
            // 
            // lblUsedValue
            // 
            lblUsedValue.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblUsedValue.Location = new Point(107, 126);
            lblUsedValue.Name = "lblUsedValue";
            lblUsedValue.Size = new Size(190, 30);
            lblUsedValue.TabIndex = 3;
            lblUsedValue.Text = "\\";
            lblUsedValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MonthBudget
            // 
            MonthBudget.AutoSize = true;
            MonthBudget.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            MonthBudget.Location = new Point(23, 57);
            MonthBudget.Name = "MonthBudget";
            MonthBudget.Size = new Size(64, 21);
            MonthBudget.TabIndex = 2;
            MonthBudget.Text = "월 예산";
            // 
            // lblBudgetTitle
            // 
            lblBudgetTitle.AutoSize = true;
            lblBudgetTitle.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblBudgetTitle.Location = new Point(58, 14);
            lblBudgetTitle.Name = "lblBudgetTitle";
            lblBudgetTitle.Size = new Size(140, 25);
            lblBudgetTitle.TabIndex = 1;
            lblBudgetTitle.Text = "예산 사용 현황";
            // 
            // picBudget
            // 
            picBudget.Image = (Image)resources.GetObject("picBudget.Image");
            picBudget.Location = new Point(15, 10);
            picBudget.Name = "picBudget";
            picBudget.Size = new Size(36, 36);
            picBudget.SizeMode = PictureBoxSizeMode.Zoom;
            picBudget.TabIndex = 0;
            picBudget.TabStop = false;
            // 
            // imgColors
            // 
            imgColors.ColorDepth = ColorDepth.Depth32Bit;
            imgColors.ImageSize = new Size(16, 16);
            imgColors.TransparentColor = Color.Transparent;
            // 
            // StatisticsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 252);
            Controls.Add(cardBudget);
            Controls.Add(cardCategory);
            Controls.Add(cardPeriod);
            Controls.Add(cardSummary);
            Controls.Add(pnlHeader);
            Name = "StatisticsPage";
            Size = new Size(949, 600);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHeader).EndInit();
            cardSummary.ResumeLayout(false);
            cardSummary.PerformLayout();
            pnlSummaryInner.ResumeLayout(false);
            pnlSummaryInner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSummary).EndInit();
            cardPeriod.ResumeLayout(false);
            cardPeriod.PerformLayout();
            pnlPeriodSum.ResumeLayout(false);
            pnlPeriodSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCount).EndInit();
            cardCategory.ResumeLayout(false);
            cardCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCategory).EndInit();
            cardBudget.ResumeLayout(false);
            cardBudget.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBudget).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubTitle;
        private Label lblTitle;
        private PictureBox picHeader;
        private Panel cardSummary;
        private Panel pnlSummaryInner;
        private Label lblSummaryTitle;
        private PictureBox picSummary;
        private Panel cardPeriod;
        private Panel cardCategory;
        private Panel cardBudget;
        private Label lblCountValue;
        private Label number;
        private PictureBox pic;
        private PictureBox picTotal;
        private Label lblTotalValue;
        private Label amount;
        private ComboBox cboMonth;
        private Label Month;
        private ComboBox cboYear;
        private PictureBox picCount;
        private Label Year;
        private Label lblPeriodTitle;
        private Panel pnlPeriodSum;
        private Label lblPeriodValue;
        private Label label11;
        private Button btnSearch;
        private ListView lvCategory;
        private Label lblCategoryTitle;
        private PictureBox picCategory;
        private Label lblRemainValue;
        private Label above;
        private Label lblBudgetValue;
        private Label NOW;
        private Label lblUsedValue;
        private Label MonthBudget;
        private Label lblBudgetTitle;
        private PictureBox picBudget;
        private Panel panel10;
        private Panel panel8;
        private Panel panel9;
        private Label lblRemainPercent;
        private Label lblUsedPercent;
        private ProgressBar pbBudget;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private PictureBox picChart;
        private ImageList imgColors;
        private Label label1;
    }
}
