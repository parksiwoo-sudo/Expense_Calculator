using Expense_Calculator.Controls;

namespace Expense_Calculator
{
    public partial class MainForm : Form
    {
        private List<Expense> expenses = new List<Expense>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExpensePage expensePage = new ExpensePage(expenses);

            expensePage.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(expensePage);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            ExpensePage expensePage = new ExpensePage(expenses);

            expensePage.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(expensePage);
        }
    }
}
