using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int NumberOfColumn = 12;
        private bool flag;
        private Product product;
        private Book book;
        public Form1()
        {
           
            InitializeComponent();
            InitializeFoem();
        }
        private void InitializeFoem()
        {
            dataGridView1.ColumnCount = NumberOfColumn;
            dataGridView1.Columns[0].Name = "Тип продукту";
            dataGridView1.Columns[1].Name = "Назва";
            dataGridView1.Columns[2].Name = "Ціна";
            dataGridView1.Columns[3].Name = "Країна походження";
            dataGridView1.Columns[4].Name = "Дата пакування";
            dataGridView1.Columns[5].Name = "Опис";
            dataGridView1.Columns[6].Name = "Термін придатності";
            dataGridView1.Columns[7].Name = "Кількість";
            dataGridView1.Columns[8].Name = "Одиниця виміру";
            dataGridView1.Columns[9].Name = "Кількість сторінок";
            dataGridView1.Columns[10].Name = "Видавництво";
            dataGridView1.Columns[11].Name = "Перелік авторів";
            NotVisiableBoxAndLabels();

            dataGridView1.AllowUserToAddRows = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
            product = new Product();
            NotVisiableBoxAndLabels();
            AccessVisibleForProductTextBoxandLabel();
            flag = true;
        }
        private void NotVisiableBoxAndLabels()
        {
            RemoveDatefromTextBox();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
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
            button1.Visible = false;
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
            label1.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            label12.Visible = true;
            label8.Visible = true;
            button1.Visible = true;
        }
        private void AccessVisibleForBookTextBoxandLabel()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox11.Visible = true;
            textBox10.Visible = true;
            textBox4.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            label1.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label10.Visible = true;
            label6.Visible = true;
            label11.Visible = true;
            label7.Visible = true;
            button1.Visible = true;
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
            book=new Book();
            NotVisiableBoxAndLabels();
            AccessVisibleForBookTextBoxandLabel();
            flag = false;
        }
        private void RemoveDatefromTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                if(textBox1.Text=="")
                {
                    book.Name = "No information";
                }
                else
                {
                    book.Name = textBox1.Text;
                }
                if(textBox2.Text=="")
                {
                    book.Price = "No information";
                }
                else
                {
                    if(decimal.TryParse(textBox2.Text, out decimal n))
                    {
                        book.Price = string.Format("{0:C2}", n);
                    }
                    else
                    {
                        book.Price = "Wrong value";
                    }
                }
                if (textBox11.Text=="")
                {
                    book.Country = "No information";
                }
                else
                {
                    book.Country = textBox11.Text;
                }
                if (textBox3.Text=="")
                {
                    book.PackingDate = "No information";
                }
                else
                {
                    book.PackingDate = textBox3.Text;
                }
                if (textBox10.Text=="")
                {
                    book.Description = "No information";
                }
                else
                {
                    book.Description = textBox10.Text;
                }
                if (textBox9.Text=="")
                {
                    book.numberOfPages = "No information";
                }
                else
                {
                    if(uint.TryParse(textBox9.Text, out uint n))
                    {
                        book.numberOfPages = textBox9.Text;
                    }
                    else
                    {
                        book.numberOfPages = "Wrong value";
                    }
                }
                if (textBox8.Text=="")
                {
                    book.PublishingHouse = "No information";
                }
                else
                {
                    book.PublishingHouse=textBox8.Text;
                }
                if (textBox4.Text=="")
                {
                    book.Authors = "No information";
                }
                else
                {
                    book.Authors=textBox4.Text;
                }
                RemoveDatefromTextBox();
                dataGridView1.Rows.Add("Книга", book.Name, book.Price, book.Country, book.PackingDate, book.Description, "", "", "", book.numberOfPages, book.PublishingHouse, book.Authors);
            }
            else
            {
                if (textBox1.Text == "")
                {
                    product.Name = "No information";
                }
                else
                {
                    product.Name = textBox1.Text;
                }
                if (textBox2.Text == "")
                {
                    product.Price = "No information";
                }
                else
                {
                    if (decimal.TryParse(textBox2.Text, out decimal n))
                    {
                        product.Price = string.Format("{0:C2}", n);
                    }
                    else
                    {
                        product.Price = "Wrong value";
                    }
                }
                    if (textBox11.Text == "")
                    {
                        product.Country = "No information";
                    }
                    else
                    {
                        product.Country = textBox11.Text;
                    }
                    if (textBox3.Text == "")
                    {
                       product.PackingDate = "No information";
                    }
                    else
                    {
                        product.PackingDate = textBox3.Text;
                    }
                    if (textBox10.Text == "")
                    {
                        product.Description = "No information";
                    }
                    else
                    {
                        product.Description = textBox10.Text;
                    }
                if(textBox6.Text == "")
                {
                    product.ExpirationDate = "No information";
                }
                else
                {
                    if(uint.TryParse(textBox6.Text, out uint n))
                    {
                        product.ExpirationDate = textBox6.Text;
                    }
                    else
                    {
                        product.ExpirationDate = "Wrong value";
                    }
                }
                if (textBox5.Text == "")
                {
                    product.Number = "No information";
                }
                else
                {
                    if (uint.TryParse(textBox5.Text, out uint n))
                    {
                        product.Number = textBox5.Text;
                    }
                    else
                    {
                        product.Number = "Wrong value";
                    }
                }
                if (textBox7.Text == "")
                {
                    product.Demension = "No information";
                }
                else
                {
                   product.Demension= textBox7.Text;
                }
                RemoveDatefromTextBox();
                dataGridView1.Rows.Add("Продукт", product.Name, product.Price, product.Country, product.PackingDate, product.Description, product.ExpirationDate, product.Number, product.Demension, "", "", "");
            }
            
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Ви хочете вийти з програми?", "Завершення програми", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void експортВTxtФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file | *.txt";
                saveFileDialog.ShowDialog();
                filename = saveFileDialog.FileName;

                int rowsCount = dataGridView1.Rows.Count;
                TextWriter textWriter = new StreamWriter(filename);
                textWriter.Write("  " + dataGridView1.Columns[0].Name + "   " + dataGridView1.Columns[1].Name + "   "  + dataGridView1.Columns[2].Name + "   " + dataGridView1.Columns[3].Name + "   " + dataGridView1.Columns[4].Name + "   " + dataGridView1.Columns[5].Name + "   " + dataGridView1.Columns[6].Name + "   " + dataGridView1.Columns[7].Name + "   " + dataGridView1.Columns[8].Name + "   " + dataGridView1.Columns[9].Name + "   " + dataGridView1.Columns[10].Name + "   " + dataGridView1.Columns[11].Name );
                textWriter.WriteLine("");
                for(int i=0; i<rowsCount; i++)
                {
                    for (int j =0; j< NumberOfColumn; j++)
                    {
                        textWriter.Write("  " + dataGridView1.Rows[i].Cells[j].Value.ToString() + "  ");
                    }
                    textWriter.WriteLine(" ");                  
                }
                textWriter.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    
