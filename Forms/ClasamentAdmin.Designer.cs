namespace Puzzle2.Forms
{
    partial class ClasamentAdmin
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
            this.clasamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentDataSet = new Puzzle2.ClasamentDataSet();
            this.clasamentTableAdapter = new Puzzle2.ClasamentDataSetTableAdapters.ClasamentTableAdapter();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPatrateleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_del = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // clasamentBindingSource
            // 
            this.clasamentBindingSource.DataMember = "Clasament";
            this.clasamentBindingSource.DataSource = this.clasamentDataSetBindingSource;
            // 
            // clasamentDataSetBindingSource
            // 
            this.clasamentDataSetBindingSource.DataSource = this.clasamentDataSet;
            this.clasamentDataSetBindingSource.Position = 0;
            // 
            // clasamentDataSet
            // 
            this.clasamentDataSet.DataSetName = "ClasamentDataSet";
            this.clasamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasamentTableAdapter
            // 
            this.clasamentTableAdapter.ClearBeforeFill = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(322, 367);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(129, 50);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.timpDataGridViewTextBoxColumn,
            this.nrPatrateleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasamentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 244);
            this.dataGridView1.TabIndex = 2;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // timpDataGridViewTextBoxColumn
            // 
            this.timpDataGridViewTextBoxColumn.DataPropertyName = "Timp";
            this.timpDataGridViewTextBoxColumn.HeaderText = "Timp";
            this.timpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timpDataGridViewTextBoxColumn.Name = "timpDataGridViewTextBoxColumn";
            this.timpDataGridViewTextBoxColumn.ReadOnly = true;
            this.timpDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrPatrateleDataGridViewTextBoxColumn
            // 
            this.nrPatrateleDataGridViewTextBoxColumn.DataPropertyName = "NrPatratele";
            this.nrPatrateleDataGridViewTextBoxColumn.HeaderText = "NrPatratele";
            this.nrPatrateleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrPatrateleDataGridViewTextBoxColumn.Name = "nrPatrateleDataGridViewTextBoxColumn";
            this.nrPatrateleDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrPatrateleDataGridViewTextBoxColumn.Width = 125;
            // 
            // clasamentBindingSource1
            // 
            this.clasamentBindingSource1.DataMember = "Clasament";
            this.clasamentBindingSource1.DataSource = this.clasamentDataSetBindingSource;
            // 
            // textBox_del
            // 
            this.textBox_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_del.Location = new System.Drawing.Point(278, 302);
            this.textBox_del.Name = "textBox_del";
            this.textBox_del.Size = new System.Drawing.Size(100, 38);
            this.textBox_del.TabIndex = 3;
            // 
            // ClasamentAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_delete);
            this.Name = "ClasamentAdmin";
            this.Text = "ClasamentAdmin";
            this.Load += new System.EventHandler(this.ClasamentAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource clasamentDataSetBindingSource;
        private ClasamentDataSet clasamentDataSet;
        private System.Windows.Forms.BindingSource clasamentBindingSource;
        private ClasamentDataSetTableAdapters.ClasamentTableAdapter clasamentTableAdapter;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPatrateleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clasamentBindingSource1;
        private System.Windows.Forms.TextBox textBox_del;
    }
}