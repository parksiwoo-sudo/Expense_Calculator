using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Calculator.Controls   // ← Designer.cs 맨 위 namespace와 똑같이 맞추기
{
    public partial class StatisticsPage : UserControl
    {
        // 카테고리 이름과 색 (같은 순서로 짝이 맞음)
        private readonly string[] _categories = { "식비", "교통비", "쇼핑", "문화생활", "생활용품", "기타" };
        private readonly Color[] _colors =
        {
            Color.FromArgb(51, 144, 255),   // 식비 - 파랑
            Color.FromArgb(76, 175, 80),    // 교통비 - 초록
            Color.FromArgb(255, 179, 0),    // 쇼핑 - 노랑
            Color.FromArgb(240, 98, 146),   // 문화생활 - 분홍
            Color.FromArgb(149, 117, 205),  // 생활용품 - 보라
            Color.FromArgb(189, 189, 200)   // 기타 - 회색
        };

        private int[] _sums = new int[6];   // 카테고리별 금액

        public StatisticsPage()
        {
            InitializeComponent();

            // ① 색 추가: 색 사각형 이미지 6개를 만들어 ImageList에 넣기
            foreach (Color c in _colors)
            {
                Bitmap bmp = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(bmp))
                    g.Clear(c);                      // 16x16 칸을 한 가지 색으로 칠함
                imgColors.Images.Add(bmp);
            }
            lvCategory.SmallImageList = imgColors;    // 표에 연결

            // ② 원형표: 칸이 다시 그려질 때 picChart_Paint가 실행되게 연결
            picChart.Paint += picChart_Paint;

            // 테스트용 숫자 (식비, 교통비, 쇼핑, 문화생활, 생활용품, 기타) - 나중에 지우기
            SetCategorySums(new int[] { 170000, 100000, 80000, 50000, 40000, 30500 });
        }

        // 카테고리별 금액을 넘기면 표와 원형표가 갱신됨
        public void SetCategorySums(int[] sums)
        {
            _sums = sums;
            int total = sums.Sum();

            lvCategory.Items.Clear();
            for (int i = 0; i < _categories.Length; i++)
            {
                double pct = total == 0 ? 0 : sums[i] * 100.0 / total;
                ListViewItem item = new ListViewItem(_categories[i], i);   // i번째 색 사각형 사용
                item.SubItems.Add("₩" + sums[i].ToString("N0"));           // 지출 금액
                item.SubItems.Add(pct.ToString("0.0") + "%");              // 비율
                lvCategory.Items.Add(item);
            }

            picChart.Invalidate();   // 원형표를 다시 그리라고 요청
        }

        // 원형표 그리기
        private void picChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;   // 가장자리를 부드럽게

            int total = _sums.Sum();
            int size = Math.Min(picChart.Width, picChart.Height) - 20;   // 원의 지름
            if (size <= 0) return;

            // 원이 들어갈 정사각형 (칸 가운데)
            Rectangle rect = new Rectangle(
                (picChart.Width - size) / 2,
                (picChart.Height - size) / 2,
                size, size);

            if (total == 0)
            {
                g.FillEllipse(Brushes.Gainsboro, rect);   // 금액이 없으면 회색 원
            }
            else
            {
                float start = -90f;   // 12시 방향에서 시작
                for (int i = 0; i < _sums.Length; i++)
                {
                    if (_sums[i] == 0) continue;
                    float sweep = 360f * _sums[i] / total;   // 이 카테고리의 각도
                    using (SolidBrush brush = new SolidBrush(_colors[i]))
                        g.FillPie(brush, rect, start, sweep);   // 부채꼴 하나 칠하기
                    start += sweep;                              // 다음 조각은 이어서
                }
            }

            // 가운데 흰 원을 덮어서 도넛 모양으로 만들기
            int hole = size * 55 / 100;
            Rectangle holeRect = new Rectangle(
                rect.X + (size - hole) / 2,
                rect.Y + (size - hole) / 2,
                hole, hole);
            g.FillEllipse(Brushes.White, holeRect);

            // 가운데 글자
            using (StringFormat sf = new StringFormat
            { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (Font f = new Font("맑은 고딕", 10F, FontStyle.Bold))
            {
                g.DrawString("총 지출\n₩" + total.ToString("N0"), f, Brushes.Black, holeRect, sf);
            }
        }
    }
}