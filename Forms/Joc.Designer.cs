namespace Puzzle2.Forms
{
    partial class Joc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_picture = new System.Windows.Forms.Button();
            this.pictureBox_full = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_9 = new System.Windows.Forms.RadioButton();
            this.radioButton_4 = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_full)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege imagine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Squares:";
            // 
            // button_picture
            // 
            this.button_picture.Location = new System.Drawing.Point(189, 97);
            this.button_picture.Name = "button_picture";
            this.button_picture.Size = new System.Drawing.Size(174, 38);
            this.button_picture.TabIndex = 2;
            this.button_picture.Text = "Choose picture";
            this.button_picture.UseVisualStyleBackColor = true;
            this.button_picture.Click += new System.EventHandler(this.button_picture_Click);
            // 
            // pictureBox_full
            // 
            this.pictureBox_full.Location = new System.Drawing.Point(465, 67);
            this.pictureBox_full.Name = "pictureBox_full";
            this.pictureBox_full.Size = new System.Drawing.Size(191, 135);
            this.pictureBox_full.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_full.TabIndex = 3;
            this.pictureBox_full.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_9);
            this.groupBox1.Controls.Add(this.radioButton_4);
            this.groupBox1.Location = new System.Drawing.Point(180, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 38);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_9
            // 
            this.radioButton_9.AutoSize = true;
            this.radioButton_9.Location = new System.Drawing.Point(63, 11);
            this.radioButton_9.Name = "radioButton_9";
            this.radioButton_9.Size = new System.Drawing.Size(35, 20);
            this.radioButton_9.TabIndex = 1;
            this.radioButton_9.TabStop = true;
            this.radioButton_9.Text = "9";
            this.radioButton_9.UseVisualStyleBackColor = true;
            this.radioButton_9.CheckedChanged += new System.EventHandler(this.radioButton_9_CheckedChanged);
            // 
            // radioButton_4
            // 
            this.radioButton_4.AutoSize = true;
            this.radioButton_4.Location = new System.Drawing.Point(9, 12);
            this.radioButton_4.Name = "radioButton_4";
            this.radioButton_4.Size = new System.Drawing.Size(35, 20);
            this.radioButton_4.TabIndex = 0;
            this.radioButton_4.TabStop = true;
            this.radioButton_4.Text = "4";
            this.radioButton_4.UseVisualStyleBackColor = true;
            this.radioButton_4.CheckedChanged += new System.EventHandler(this.radioButton_4_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume:";
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(189, 60);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(100, 22);
            this.textBox_Nume.TabIndex = 6;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(533, 279);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 32);
            this.label_time.TabIndex = 7;
            // 
            // Joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 474);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox_Nume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_full);
            this.Controls.Add(this.button_picture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Joc";
            this.Text = "Joc";
            this.Load += new System.EventHandler(this.Joc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_full)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_picture;
        private System.Windows.Forms.PictureBox pictureBox_full;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_9;
        private System.Windows.Forms.RadioButton radioButton_4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.Label label_time;
    }
}