namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int NumberOfColumn = 11;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = NumberOfColumn;
            dataGridView1.Columns[0].Name = "Назва";
            dataGridView1.Columns[1].Name = "Ціна";
            dataGridView1.Columns[2].Name = "Країна походження";
            dataGridView1.Columns[3].Name = "Дата пакування";
            dataGridView1.Columns[4].Name = "Термін придатності";
            dataGridView1.Columns[5].Name = "Кількість";
            dataGridView1.Columns[6].Name = "Одиниця виміру";
            dataGridView1.Columns[7].Name = "Кількість сторінок";
            dataGridView1.Columns[8].Name = "Видавництво";
            dataGridView1.Columns[9].Name = "Перелік авторів";
            dataGridView1.Columns[10].Name = "Опис";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void Inizialozation()
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void видалитиРядокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.RowCount;
            if (rowNumber == 0)
            {
                MessageBox.Show(rowNumber.ToString() + " рядків тому видалення неможливе");
            }
            else
            {
                dataGridView1.Rows.RemoveAt(rowNumber - 1);
            }
        }

        private void продуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();

        }
        private void Access()
        {
            textBox1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}