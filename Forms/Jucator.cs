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
    public partial class Jucator : Form
    {
        public Jucator()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt16(listBox1.SelectedIndex))
            {
                case 0:
                    {
                        var joc = new Joc();
                        this.Hide();
                        joc.ShowDialog();
                        break;
                    }
                case 1:
                    {
                        var clasamentJucator = new ClasamentJucator();
                        this.Hide();
                        clasamentJucator.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                        break;
                    }
            }
        }
    }
}
