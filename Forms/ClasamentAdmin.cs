using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Puzzle2.Forms
{
    public partial class ClasamentAdmin : Form
    {
        public static string filePath = "C:\\Stefan\\Scoala\\C#\\Lesson 15 15.2.2024\\Puzzle2\\Resurse\\Data\\Clasament.txt";
        public ClasamentAdmin()
        {
            InitializeComponent();
        }
        
        private void ClasamentAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clasamentDataSet.Clasament' table. You can move, or remove it, as needed.
            this.clasamentTableAdapter.Fill(this.clasamentDataSet.Clasament);

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string nameToDel= textBox_del.Text;
            List<string> _ = new List<string>();
            using (var reader = new StreamReader(filePath))
            {

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var values = line.Split(' ');

                    if (values[0] == nameToDel)
                        continue;

                    _.Add($"{values[0]} {values[1]} {values[2]} ");

                }

            }

            File.WriteAllLines(filePath, _);
        }
    }
}
