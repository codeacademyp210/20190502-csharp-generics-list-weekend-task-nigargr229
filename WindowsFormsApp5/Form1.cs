using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Employee> Employers = new List<Employee>();
            dataGridView1.ColumnCount =5;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Surname";
            dataGridView1.Columns[2].Name = "Email";
            dataGridView1.Columns[3].Name = "Position";
            dataGridView1.Columns[4].Name = "Salary";         
            

        }
        int indexRow;
        private void add(string name, string surname, string email, string position, double salary)
        {
            dataGridView1.Rows.Add(name, surname, email, position, salary);
           
        }
       
       
        private void Button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
           
            employee.Name = textBox1.Text;
            employee.Surname = textBox2.Text;
            employee.Email = textBox3.Text;
            employee.Position = textBox4.Text;
            employee.Salary = Convert.ToDouble(textBox5.Text.Replace(".", ","));
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "")
            {
                dataGridView1.Rows.Add(1);
                int top = dataGridView1.Rows.Count;
                dataGridView1.Rows[top - 2].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[top - 2].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[top - 2].Cells[2].Value = textBox3.Text;
                dataGridView1.Rows[top - 2].Cells[3].Value = textBox4.Text;
                dataGridView1.Rows[top - 2].Cells[4].Value = textBox5.Text;
                clear();
            }
            else MessageBox.Show("Fill all gaps");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            else MessageBox.Show("Please,Choose");
        }
        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }
     
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void UpdateRow()
        {
            dataGridView1.SelectedRows[0].Cells[0].Value = textBox1.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = textBox2.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = textBox3.Text;
            dataGridView1.SelectedRows[0].Cells[3].Value = textBox4.Text;
            dataGridView1.SelectedRows[0].Cells[4].Value = textBox5.Text;

            clear();
        }              
    }
}
