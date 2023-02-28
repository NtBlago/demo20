using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo20
{
    public partial class view_form : Form
    {
        public view_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void view_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade3DataSet1.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter1.Fill(this.trade3DataSet1.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_dellete_data fm = new add_dellete_data();
                fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_dellete_data fm = new add_dellete_data();
            fm.Show();
        }
    }
}
