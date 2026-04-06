using System.Drawing.Drawing2D;

namespace lab8_1
{
    public partial class MainForm : Form
    {
        private delegate double Statistics(List<int> arr);
        private Statistics? stats;

        private List<int> data = new List<int>();
        private Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();
            GenerateArray();
        }

        private void GenerateArray()
        {
            data.Clear();
            arrBox.Text = String.Empty;

            int n = rand.Next(5, 16);
            for (int i = 0; i < n; i++)
            {
                data.Add(rand.Next(1, 101));
            }
            arrBox.Text = string.Join("; ", data);
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            GenerateArray();
        }

        private void sepPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, panel.Width, panel.Height),
                Color.FromArgb(100, Color.Orange),
                Color.Transparent,
                90f))
            {
                e.Graphics.FillRectangle(brush, panel.ClientRectangle);
            }
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            stats = arr =>
            {
                double sum = 0;
                foreach (int x in arr)
                {
                    sum += x;
                }
                return sum;
            };
            resBox.Text = stats(data).ToString();
        }

        private void avgBtn_Click(object sender, EventArgs e)
        {
            stats = arr =>
            {
                double sum = 0;
                foreach (int x in arr)
                {
                    sum += x;
                }
                return sum / arr.Count;
            };
            resBox.Text = stats(data).ToString();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(nBox.Text, out double n))
            {
                MessageBox.Show("Введите корректное значение числа N", "Ошибка");
                return;
            }

            stats = arr => 
            {
                double c = 0;
                foreach(int x in arr)
                {
                    if (x > n) c++;
                }
                return c;
            };
            resBox.Text = stats(data).ToString();
        }
    }
}
