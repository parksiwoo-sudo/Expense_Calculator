using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Expense_Calculator.Controls
{

    public partial class ExpensePage : UserControl
    {
        // 기본 월 예산 100만원
        private decimal budget = 1000000m;
        public ExpensePage()
        {
            InitializeComponent();

            InitListView();

            // 기본 예산 표시
            txtBudget.Text = budget.ToString("N0");

            // 예산 변경 이벤트
            txtBudget.TextChanged += TxtBudget_TextChanged;

            // 최초 통계 갱신
            UpdateStatistics();

            // 지출 내용 입력창 이벤트

        }
        // 예산 텍스트박스가 바뀔 때 실행되는 이벤트 (sender에 ? 추가하여 경고 해결)
        private void TxtBudget_TextChanged(object? sender, EventArgs e)
        {
            UpdateStatistics();
        }

        // 리스트뷰 컬럼(열) 구조 및 오너 드로우 설정 (카테고리에 아이콘 표시)
        private void InitListView()
        {
            lvExpenses.View = View.Details;
            lvExpenses.FullRowSelect = true;
            lvExpenses.GridLines = true;
            lvExpenses.OwnerDraw = true; // 카테고리 칸에 아이콘을 직접 그리기 위해 필수!

            lvExpenses.DrawColumnHeader += (sender, e) => e.DrawDefault = true;
            lvExpenses.DrawSubItem += LvExpenses_DrawSubItem;

            lvExpenses.Columns.Clear();
            lvExpenses.Columns.Add("번호", 60, HorizontalAlignment.Center);       // 0번째 열
            lvExpenses.Columns.Add("날짜", 110, HorizontalAlignment.Center);      // 1번째 열
            lvExpenses.Columns.Add("카테고리", 110, HorizontalAlignment.Center); // 2번째 열 (아이콘 표시 위치)
            lvExpenses.Columns.Add("지출 내용", 160, HorizontalAlignment.Left);   // 3번째 열
            lvExpenses.Columns.Add("금액", 100, HorizontalAlignment.Right);     // 4번째 열

            lvExpenses.MouseClick += LvExpenses_MouseClick;
        }

        // 카테고리 이름에 따른 이미지 리스트 번호(Index) 반환 함수
        private int GetCategoryIconIndex(string category)
        {
            // 식비=1, 교통비=0, 문화생활=4, 쇼핑=3, 기타=2[cite: 8]
            switch (category.Trim())
            {
                case "식비": return 1;       // Fork.png
                case "교통비": return 0;     // bus.png
                case "문화생활": return 4;   // film.png
                case "쇼핑": return 3;       // shopping.png
                case "기타": return 2;       // cat.png
                default: return 2;         // 기본값 (기타)
            }
        }

        // 카테고리 컬럼에 아이콘과 글자를 나란히 그려주는 커스텀 드로잉 함수
        private void LvExpenses_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawBackground();

            if (e.ColumnIndex == 2) // '카테고리' 컬럼인 경우에만 아이콘을 함께 그림
            {
                string categoryText = e.SubItem.Text;
                int iconIndex = GetCategoryIconIndex(categoryText);

                int imageWidth = (imageList1 != null) ? imageList1.ImageSize.Width : 16;
                int imageHeight = (imageList1 != null) ? imageList1.ImageSize.Height : 16;

                int x = e.Bounds.X + 8;
                int y = e.Bounds.Y + (e.Bounds.Height - imageHeight) / 2;

                // 아이콘 이미지 출력
                if (imageList1 != null && iconIndex >= 0 && iconIndex < imageList1.Images.Count)
                {
                    e.Graphics.DrawImage(imageList1.Images[iconIndex], x, y, imageWidth, imageHeight);
                    x += imageWidth + 6; // 이미지 너비만큼 텍스트 시작 위치를 오른쪽으로 미룸
                }

                // 카테고리 텍스트 출력 (e.Font -> e.SubItem.Font로 수정)
                using (Brush brush = new SolidBrush(e.SubItem.ForeColor))
                {
                    StringFormat sf = new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Near
                    };
                    Rectangle textRect = new Rectangle(x, e.Bounds.Y, e.Bounds.Width - (x - e.Bounds.X), e.Bounds.Height);
                    e.Graphics.DrawString(categoryText, e.SubItem.Font, brush, textRect, sf);
                }
            }
            else // 나머지 컬럼 (번호, 날짜, 지출내용, 금액)
            {
                using (Brush brush = new SolidBrush(e.SubItem.ForeColor))
                {
                    StringFormat sf = new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Near
                    };

                    if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                        sf.Alignment = StringAlignment.Center;
                    else if (e.ColumnIndex == 4)
                        sf.Alignment = StringAlignment.Far;

                    Rectangle rect = new Rectangle(e.Bounds.X + 4, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height);
                    e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, brush, rect, sf); // e.Font -> e.SubItem.Font로 수정
                }
            }
        }

        // [등록] 버튼 클릭 이벤트
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("지출 내용을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = cboCategory.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string desc = txtDescription.Text;
            decimal amount = nudAmount.Value;

            int nextNo = lvExpenses.Items.Count + 1;

            // 순서: 번호, 날짜, 카테고리, 지출내용, 금액
            ListViewItem item = new ListViewItem(nextNo.ToString()); // 0번째: 번호
            item.SubItems.Add(date);                                 // 1번째: 날짜
            item.SubItems.Add(category);                             // 2번째: 카테고리
            item.SubItems.Add(desc);                                 // 3번째: 지출 내용
            item.SubItems.Add(amount.ToString("N0") + "원");         // 4번째: 금액

            lvExpenses.Items.Add(item);

            txtDescription.Clear();
            nudAmount.Value = 0;

            UpdateStatistics();
        }

        // [수정] 버튼 클릭 이벤트
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvExpenses.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 목록을 먼저 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lvExpenses.SelectedItems[0];
            string category = cboCategory.Text;

            item.SubItems[1].Text = dtpDate.Value.ToString("yyyy-MM-dd");
            item.SubItems[2].Text = category;                            // 카테고리 수정
            item.SubItems[3].Text = txtDescription.Text;
            item.SubItems[4].Text = nudAmount.Value.ToString("N0") + "원";

            MessageBox.Show("수정되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateStatistics();
        }

        // [삭제] 버튼 클릭 이벤트
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvExpenses.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 목록을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in lvExpenses.SelectedItems)
            {
                lvExpenses.Items.Remove(item);
            }

            // 삭제 후 번호 재정렬 (0번째 열이 번호)
            for (int i = 0; i < lvExpenses.Items.Count; i++)
            {
                lvExpenses.Items[i].Text = (i + 1).ToString();
            }

            UpdateStatistics();
        }

        // 목록 마우스 클릭 시 입력창에 값 채우기
        private void LvExpenses_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvExpenses.SelectedItems.Count > 0)
            {
                ListViewItem item = lvExpenses.SelectedItems[0];

                // 날짜 (1번째 SubItem)
                if (DateTime.TryParse(item.SubItems[1].Text, out DateTime parsedDate))
                {
                    dtpDate.Value = parsedDate;
                }
                // 카테고리 (2번째 SubItem)
                cboCategory.Text = item.SubItems[2].Text;
                // 지출 내용 (3번째 SubItem)
                txtDescription.Text = item.SubItems[3].Text;

                // 금액 (4번째 SubItem)
                string amountStr = item.SubItems[4].Text.Replace("원", "").Replace(",", "").Trim();
                if (decimal.TryParse(amountStr, out decimal parsedAmount))
                {
                    nudAmount.Value = parsedAmount;
                }
            }
        }

        // 총 지출, 건수, 예산 대비 퍼센트 및 프로그래스바 게이지 실시간 갱신 함수
        private void UpdateStatistics()
        {
            decimal totalAmount = 0;

            foreach (ListViewItem item in lvExpenses.Items)
            {
                string amountStr = item.SubItems[4].Text.Replace("원", "").Replace(",", "").Trim();
                if (decimal.TryParse(amountStr, out decimal amt))
                {
                    totalAmount += amt;
                }
            }

            // 1. 총 지출 금액 표시
            lblTotalAmount.Text = totalAmount.ToString("N0") + "원";

            // 2. 등록된 내역 갯수 표시
            lblExpenseCount.Text = lvExpenses.Items.Count.ToString() + "건";

            // 3. 예산 사용률 퍼센트 및 프로그래스바(progressBarBudget) 연동
            decimal budget = 1000000; // 기본 예산 100만원

            if (decimal.TryParse(txtBudget.Text.Replace(",", "").Replace("원", "").Trim(), out decimal parsedBudget) && parsedBudget > 0)
            {
                budget = parsedBudget;
            }

            if (budget > 0)
            {
                double percent = (double)(totalAmount / budget) * 100;

                // 퍼센트 숫자 라벨 반영 (소수점 첫째 자리까지)
                lblPercent.Text = percent.ToString("F1") + "%";

                // 프로그래스바 게이지 반영 (progressBarBudget)
                int intPercent = (int)percent;
                if (intPercent > 100) intPercent = 100;
                if (intPercent < 0) intPercent = 0;

                progressBarBudget.Value = intPercent;
            }

        }
        // 지출 내용 입력창에 포커스가 들어왔을 때
        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "지출 내용")
            {
                txtDescription.Text = "";
            }
        }

        // 입력창에서 포커스가 벗어났을 때
        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                txtDescription.Text = "지출 내용";
            }
        }
    }
}