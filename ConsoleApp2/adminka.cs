using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class adminka : Form
    {
        public лицо frm;
        public adminka()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                frm.AdminCreate();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm.Show();
            Close();
        }
    }
}
