namespace Puzzle2.Forms
{
    partial class ClasamentJucator
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clasamentDataSet = new Puzzle2.ClasamentDataSet();
            this.clasamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentTableAdapter = new Puzzle2.ClasamentDataSetTableAdapters.ClasamentTableAdapter();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrPatrateleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.timpDataGridViewTextBoxColumn,
            this.nrPatrateleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasamentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(430, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clasamentDataSet
            // 
            this.clasamentDataSet.DataSetName = "ClasamentDataSet";
            this.clasamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasamentBindingSource
            // 
            this.clasamentBindingSource.DataMember = "Clasament";
            this.clasamentBindingSource.DataSource = this.clasamentDataSet;
            // 
            // clasamentTableAdapter
            // 
            this.clasamentTableAdapter.ClearBeforeFill = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // timpDataGridViewTextBoxColumn
            // 
            this.timpDataGridViewTextBoxColumn.DataPropertyName = "Timp";
            this.timpDataGridViewTextBoxColumn.HeaderText = "Timp";
            this.timpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timpDataGridViewTextBoxColumn.Name = "timpDataGridViewTextBoxColumn";
            this.timpDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrPatrateleDataGridViewTextBoxColumn
            // 
            this.nrPatrateleDataGridViewTextBoxColumn.DataPropertyName = "NrPatratele";
            this.nrPatrateleDataGridViewTextBoxColumn.HeaderText = "NrPatratele";
            this.nrPatrateleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrPatrateleDataGridViewTextBoxColumn.Name = "nrPatrateleDataGridViewTextBoxColumn";
            this.nrPatrateleDataGridViewTextBoxColumn.Width = 125;
            // 
            // ClasamentJucator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClasamentJucator";
            this.Text = "ClasamentJucator";
            this.Load += new System.EventHandler(this.ClasamentJucator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ClasamentDataSet clasamentDataSet;
        private System.Windows.Forms.BindingSource clasamentBindingSource;
        private ClasamentDataSetTableAdapters.ClasamentTableAdapter clasamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrPatrateleDataGridViewTextBoxColumn;
    }
}