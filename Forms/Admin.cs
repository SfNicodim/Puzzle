using Puzzle2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(listBox1.SelectedIndex))
            {
                case 0:
                    {
                        var clasamentAdmin = new ClasamentAdmin();
                        this.Hide();
                        clasamentAdmin.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        var form = new Form1();
                        this.Hide();
                        form.ShowDialog();
                        break;
                    }
            }
        }
    }
}
