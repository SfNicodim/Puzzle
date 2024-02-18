using Puzzle2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle2
{
    public partial class Form1 : Form
    {
        public static string connectionString= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Stefan\\Scoala\\C#\\Lesson 15 15.2.2024\\Puzzle2\\Clasament.mdf\";Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = connectionString;
            ds = new DataSet();
            conn.Open();

            SqlCommand command = new SqlCommand("TRUNCATE TABLE Clasament", conn);
            command.ExecuteNonQuery();

            string line;

            using (StreamReader file = new StreamReader(ClasamentAdmin.filePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] fields = line.Split(' ');
                    SqlCommand cmd = new SqlCommand("INSERT INTO Clasament(Nume, Timp, NrPatratele) VALUES (@Nume, @Timp, @NrPatratele)", conn);
                    cmd.Parameters.AddWithValue("@Nume", fields[0].ToString());
                    cmd.Parameters.AddWithValue("@Timp", fields[1].ToString());
                    cmd.Parameters.AddWithValue("@NrPatratele", Convert.ToInt16(fields[2]));
                    cmd.ExecuteNonQuery();
                }
            }

                
            conn.Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "jucator")
            {
                var jucator = new Jucator();
                this.Hide();
                jucator.ShowDialog();
            }
            else if (textBox.Text == "admin")
            {
                var admin = new Admin();
                this.Hide();
                admin.ShowDialog();
            }
        }
    }
}
