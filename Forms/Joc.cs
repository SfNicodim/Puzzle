using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle2.Forms
{   
    public partial class Joc : Form
    {
        SqlConnection conn = new SqlConnection();
        DataSet ds;
        private int timeSec;
        private int timeMin;
        private int numberOfSquares = 4;
        private Bitmap originalImage;
        private List<PictureBox> pictureBoxList = new List<PictureBox>();
        private PictureBox clickedPictureBox1 = null;
        private PictureBox clickedPictureBox2 = null;
        public Joc()
        {
            InitializeComponent();
        }

        private void button_picture_Click(object sender, EventArgs e)
        {
            string specificFolderPath = "Properties.Resources";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = specificFolderPath;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the selected file path
                    string selectedFilePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    pictureBox_full.Image = Image.FromFile(selectedFilePath);
                }
            }
            originalImage = new Bitmap(pictureBox_full.Image);
        }

        private void Joc_Load(object sender, EventArgs e)
        {

        }
        private void CutDisplayResizedAndShuffledImage()
        {
            // Specify the desired size for the squares
            int squareSize;
            if (numberOfSquares == 3) squareSize = 70;
            else squareSize = 100;

            // Resize the original image to fit within the square area
            Bitmap resizedImage = new Bitmap(originalImage, new Size(squareSize * numberOfSquares, squareSize * numberOfSquares));

            for (int row = 0; row < numberOfSquares; row++)
            {
                for (int col = 0; col < numberOfSquares; col++)
                {
                    // Create a new Bitmap for each square
                    Bitmap square = new Bitmap(squareSize, squareSize);

                    // Create a graphics object for the square
                    using (Graphics g = Graphics.FromImage(square))
                    {
                        // Define the portion of the resized image to be drawn on the square
                        Rectangle sourceRectangle = new Rectangle(col * squareSize, row * squareSize, squareSize, squareSize);

                        // Draw the portion of the resized image onto the square
                        g.DrawImage(resizedImage, 0, 0, sourceRectangle, GraphicsUnit.Pixel);
                    }

                    // Create a PictureBox for the square
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(squareSize, squareSize),
                        Location = new Point(80 + col * squareSize, 160 + row * squareSize), // Adjusted position
                        Image = square,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Enabled = true,
                        Tag = new Point(col, row)
                    };
                    pictureBox.Click += PictureBox_Click;
                    pictureBoxList.Add(pictureBox);
                }
            }

            // Shuffle the PictureBox list using Fisher-Yates shuffle
            Random random = new Random();
            int n = pictureBoxList.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                PictureBox value = pictureBoxList[k];
                pictureBoxList[k] = pictureBoxList[n];
                pictureBoxList[n] = value;
            }

            // Display the shuffled PictureBox controls on the form
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                PictureBox pictureBox = pictureBoxList[i];
                pictureBox.Location = new Point(80 + (i % numberOfSquares) * squareSize, 160 + (i / numberOfSquares) * squareSize);
                this.Controls.Add(pictureBox);
            }
        }
        private void radioButton_4_CheckedChanged(object sender, EventArgs e)
        {
            numberOfSquares = 2;

            CutDisplayResizedAndShuffledImage();
        }
    
        private void radioButton_9_CheckedChanged(object sender, EventArgs e)
        {
            numberOfSquares = 3;
            CutDisplayResizedAndShuffledImage();
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;

            if (clickedPictureBox1 == null)
            {
                timer.Start();
                // First click
                clickedPictureBox1 = clickedPictureBox;
            }
            else if (clickedPictureBox2 == null)
            {
                clickedPictureBox2 = clickedPictureBox;

                try
                {
                    Point tempLocation = clickedPictureBox1.Location;
                    clickedPictureBox1.Location = clickedPictureBox2.Location;
                    clickedPictureBox2.Location = tempLocation;

                    clickedPictureBox1 = null;
                    clickedPictureBox2 = null;
                    if (AreSquaresInCorrectOrder())
                    {
                        timer.Stop();
                        timeSec += timeMin * 60;
                        using (StreamWriter writer = new StreamWriter(ClasamentAdmin.filePath, true))
                        {
                            // Write a line with timestamp, textbox data, and int variable
                            writer.WriteLine($"{textBox_Nume.Text} {timeMin.ToString()}:{timeSec.ToString()} {numberOfSquares^2}");
                        }
                        MessageBox.Show("Congratulations! Puzzle solved!");
                        textBox_Nume.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        
        int left = 0, top = 0;
        private bool AreSquaresInCorrectOrder()
        {
            for (int i = 0; i < pictureBoxList.Count; i++)
            {
                if (numberOfSquares == 2)
                {
                    left = (pictureBoxList[i].Left - 80) / 100;
                    top = (pictureBoxList[i].Top - 160) / 100;
                    
                }
                if(numberOfSquares == 3)
                {
                    left = (pictureBoxList[i].Left - 80) / 50;
                    top = (pictureBoxList[i].Top - 160) / 50;
                }
                Point currentPosition = new Point(left, top);
                Point originalPosition = (Point)pictureBoxList[i].Tag;

                if (currentPosition != originalPosition)
                {
                    return false; // Squares are not in the correct order
                }
            }
            return true;
        }
        
            private void timer_Tick(object sender, EventArgs e)
        {
            label_time.Text=timeMin.ToString()+":"+timeSec.ToString();
            if (timeSec == 59)
            {
                timeMin++;
                timeSec = 0;
            }
            else timeSec++;
        }
    }
}
