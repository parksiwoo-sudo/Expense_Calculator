
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Expense_Calculator;
using System.Linq;
namespace Expense_Calculator.Controls
{
    public partial class StatisticsPage : UserControl
    {
        // 카테고리 이름과 색
        private readonly string[] _categories =
        {
            "식비", "교통비", "쇼핑", "문화생활", "기타"
        };

        private readonly Color[] _colors =
        {
            Color.FromArgb(51, 144, 255),
            Color.FromArgb(76, 175, 80),
            Color.FromArgb(255, 179, 0),
            Color.FromArgb(240, 98, 146),
            Color.FromArgb(189, 189, 200)
        };

        // 카테고리별 지출 금액
        private decimal[] _sums = new decimal[5];

        // MainForm에서 전달받은 지출 데이터
        private List<Expense> expenses;

        public StatisticsPage(List<Expense> expenses)
        {
            InitializeComponent();

            this.expenses = expenses;

            // 색 사각형 이미지 생성
            foreach (Color c in _colors)
            {
                Bitmap bmp = new Bitmap(16, 16);

                using (Graphics g = Graphics.FromImage(bmp))
                    g.Clear(c);

                imgColors.Images.Add(bmp);
            }

            lvCategory.SmallImageList = imgColors;

            // 원형 차트 그리기 이벤트 연결
            picChart.Paint += picChart_Paint;

            // 실제 지출 데이터를 이용해 통계 계산
            RefreshStatistics();

            InitializePeriodComboBoxes();
            RefreshStatistics();

        }

        // 실제 Expense 데이터를 이용해 카테고리별 금액 계산
        public void RefreshStatistics()
        {
            decimal totalAmount = expenses.Sum(x => x.Amount);

            // 등록된 지출 건수
            int expenseCount = expenses.Count;

            // 화면에 표시
            lblTotalValue.Text = "₩" + totalAmount.ToString("N0");
            lblCountValue.Text = expenseCount.ToString() + "건";

            InitializePeriodComboBoxes();
            decimal[] sums = new decimal[6];

            foreach (Expense expense in expenses)
            {
                int index = Array.IndexOf(_categories, expense.Category);

                // 등록된 카테고리가 아니면 기타로 분류
                if (index == -1)
                    index = 5;

                sums[index] += expense.Amount;
            }

            SetCategorySums(sums);
        }

        // 카테고리별 금액을 받아 표와 원형 차트 갱신
        public void SetCategorySums(decimal[] sums)
        {
            _sums = sums;
            decimal total = sums.Sum();

            lvCategory.Items.Clear();

            for (int i = 0; i < _categories.Length; i++)
            {
                double pct = total == 0
                    ? 0
                    : (double)(sums[i] * 100m / total);

                ListViewItem item = new ListViewItem(_categories[i], i);

                item.SubItems.Add("₩" + sums[i].ToString("N0"));
                item.SubItems.Add(pct.ToString("0.0") + "%");

                lvCategory.Items.Add(item);
            }

            // 원형 차트 다시 그리기
            picChart.Invalidate();
        }

        // 원형 차트 그리기
        private void picChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            decimal total = _sums.Sum();

            int size = Math.Min(picChart.Width, picChart.Height) - 20;

            if (size <= 0)
                return;

            Rectangle rect = new Rectangle(
                (picChart.Width - size) / 2,
                (picChart.Height - size) / 2,
                size,
                size
            );

            if (total == 0)
            {
                g.FillEllipse(Brushes.Gainsboro, rect);
            }
            else
            {
                float start = -90f;

                for (int i = 0; i < _sums.Length; i++)
                {
                    if (_sums[i] == 0)
                        continue;

                    float sweep = (float)(360m * _sums[i] / total);

                    using (SolidBrush brush = new SolidBrush(_colors[i]))
                    {
                        g.FillPie(brush, rect, start, sweep);
                    }

                    start += sweep;
                }
            }

            // 가운데 흰 원을 덮어서 도넛 모양 만들기
            int hole = size * 55 / 100;

            Rectangle holeRect = new Rectangle(
                rect.X + (size - hole) / 2,
                rect.Y + (size - hole) / 2,
                hole,
                hole
            );

            g.FillEllipse(Brushes.White, holeRect);

            // 가운데 총 지출 금액 표시
            using (StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            using (Font f = new Font("맑은 고딕", 10F, FontStyle.Bold))
            {
                g.DrawString(
                    "총 지출\n₩" + total.ToString("N0"),
                    f,
                    Brushes.Black,
                    holeRect,
                    sf
                );
            }
        }
        public void RefreshBudget(decimal monthlyBudget)
        {
            DateTime now = DateTime.Now;

            // 이번 달 지출 합계
            decimal monthlySpent = expenses
                .Where(x => x.Date.Year == now.Year &&
                            x.Date.Month == now.Month)
                .Sum(x => x.Amount);

            // 남은 예산
            decimal remaining = monthlyBudget - monthlySpent;

            // 금액 표시
            lblBudgetValue.Text = "₩" + monthlyBudget.ToString("N0");
            label1.Text = "₩" + monthlySpent.ToString("N0");

            if (remaining >= 0)
                lblUsedValue.Text = "₩" + remaining.ToString("N0");
            else
                lblUsedValue.Text = "초과 ₩" + Math.Abs(remaining).ToString("N0");

            // 사용률 계산
            double percent = monthlyBudget > 0
                ? (double)(monthlySpent / monthlyBudget) * 100
                : 0;

            lblUsedPercent.Text = percent.ToString("F1") + "% 사용";
            lblRemainPercent.Text = Math.Max(0, 100 - percent).ToString("F1") + "% 남음";

            // 게이지는 100%까지만 표시
            pbBudget.Value = (int)Math.Min(100, Math.Max(0, percent));
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem == null ||
                cboMonth.SelectedItem == null)
            {
                MessageBox.Show("연도와 월을 선택해주세요.");
                return;
            }

            int year = int.Parse(cboYear.SelectedItem.ToString());

            int month = int.Parse(
                cboMonth.SelectedItem.ToString().Replace("월", "")
            );

            decimal periodTotal = expenses
                .Where(x => x.Date.Year == year &&
                            x.Date.Month == month)
                .Sum(x => x.Amount);

            lblPeriodValue.Text = "₩" + periodTotal.ToString("N0");
        }
        private void InitializePeriodComboBoxes()
        {
            int currentYear = DateTime.Now.Year;

            cboYear.Items.Clear();

            var years = expenses
                .Select(x => x.Date.Year)
                .Append(currentYear)
                .Distinct()
                .OrderByDescending(x => x);

            foreach (int year in years)
            {
                cboYear.Items.Add(year.ToString());
            }

            cboYear.SelectedItem = currentYear.ToString();

            cboMonth.SelectedIndex = DateTime.Now.Month - 1;
        }
    }
}
