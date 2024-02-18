using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle2.Forms
{
    public partial class ClasamentJucator : Form
    {
        public ClasamentJucator()
        {
            InitializeComponent();
        }

        private void ClasamentJucator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clasamentDataSet.Clasament' table. You can move, or remove it, as needed.
            this.clasamentTableAdapter.Fill(this.clasamentDataSet.Clasament);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
