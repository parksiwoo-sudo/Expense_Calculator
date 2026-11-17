using Expense_Calculator.Controls;

namespace Expense_Calculator
{
    public partial class MainForm : Form
    {
        private List<Expense> expenses = new List<Expense>();

        private ExpensePage expensePage;
        private StatisticsPage statisticsPage;

        public MainForm()
        {
            InitializeComponent();

            expensePage = new ExpensePage(expenses);
            statisticsPage = new StatisticsPage(expenses);

            ShowPage(expensePage);
        }

        private void ShowPage(UserControl page)
        {
            pnlContent.Controls.Clear();

            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPage(expensePage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statisticsPage.RefreshStatistics();

            statisticsPage.RefreshBudget(expensePage.MonthlyBudget);

            ShowPage(statisticsPage);
        }
    }
}
