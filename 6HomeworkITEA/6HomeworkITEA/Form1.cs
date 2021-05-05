using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6HomeworkITEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities db = new MyDatabaseEntities();
            DataGrid dataGridView1 = new DataGrid();
            dataGridView1.Height = 3000;
            dataGridView1.Width = 3000;
            this.Controls.Add(dataGridView1);

            var v = from n in db.MyTable select n;
            dataGridView1.DataSource = v.ToList();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model2Container db = new Model2Container();
            db.Users.Add(new User { age = "45" });
            db.Users.Add(new User { age = "22" });
            db.SaveChanges();
            DataGrid dataGridView1 = new DataGrid();
            dataGridView1.Height = 3000;
            dataGridView1.Width = 3000;
            this.Controls.Add(dataGridView1);

            var v = from n in db.Users select n;
            dataGridView1.DataSource = v.ToList();
        }
    }
}
