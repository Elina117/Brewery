using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brewery
{
    public partial class MainForm : Form
    {
        MainForm mainForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            DialogResult result = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Завершение программы",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            

        }


    }
}
