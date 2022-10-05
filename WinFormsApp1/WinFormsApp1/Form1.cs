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
            NotVisiableBoxAndLabels();
    
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
            //NotVisiableBoxAndLabels();
            //AccessVisibleForProductTextBoxandLabel();
            dataGridView1.Rows.Add("Pizza", "45", "Italy", "14/45/1978", "435", "retrter", "tretrg", "", "", "", "4354534");
        }
        private void NotVisiableBoxAndLabels()
        {
            textBox1.Visible = false;
            textBox1.Clear();
            textBox2.Visible = false;
            textBox2.Clear();
            textBox3.Visible = false;
            textBox3.Clear();
            textBox4.Visible = false;
            textBox4.Clear();
            textBox5.Visible = false;
            textBox5.Clear();
            textBox6.Visible = false;
            textBox6.Clear();
            textBox7.Visible = false;
            textBox7.Clear();
            textBox8.Visible = false;
            textBox8.Clear();
            textBox9.Visible = false;
            textBox9.Clear();
            textBox10.Visible = false;
            textBox10.Clear();
            textBox11.Visible = false;
            textBox11.Clear();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void AccessVisibleForProductTextBoxandLabel()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox11.Visible = true;
            textBox10.Visible = true;
            textBox6.Visible = true;
            textBox5.Visible = true;
            textBox7.Visible = true;
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

        private void книгаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Poter", "4543", "Germany", "56/53/87", "", "", "", "546456", "5rteter", "Tolkin", "rtreter");
        }
    }
}