namespace EntityFramework
{
    partial class Norms
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
            this.chidlGrDbDataSet1 = new EntityFramework.ChidlGrDbDataSet1();
            this.normsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normsTableAdapter = new EntityFramework.ChidlGrDbDataSet1TableAdapters.NormsTableAdapter();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальныйРостDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.максимальныйРостDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальныйВесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.максимальныйВесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chidlGrDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.возрастDataGridViewTextBoxColumn,
            this.минимальныйРостDataGridViewTextBoxColumn,
            this.максимальныйРостDataGridViewTextBoxColumn,
            this.минимальныйВесDataGridViewTextBoxColumn,
            this.максимальныйВесDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.normsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(555, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // chidlGrDbDataSet1
            // 
            this.chidlGrDbDataSet1.DataSetName = "ChidlGrDbDataSet1";
            this.chidlGrDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // normsBindingSource
            // 
            this.normsBindingSource.DataMember = "Norms";
            this.normsBindingSource.DataSource = this.chidlGrDbDataSet1;
            // 
            // normsTableAdapter
            // 
            this.normsTableAdapter.ClearBeforeFill = true;
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            this.возрастDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // минимальныйРостDataGridViewTextBoxColumn
            // 
            this.минимальныйРостDataGridViewTextBoxColumn.DataPropertyName = "Минимальный рост";
            this.минимальныйРостDataGridViewTextBoxColumn.HeaderText = "Минимальный рост";
            this.минимальныйРостDataGridViewTextBoxColumn.Name = "минимальныйРостDataGridViewTextBoxColumn";
            this.минимальныйРостDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // максимальныйРостDataGridViewTextBoxColumn
            // 
            this.максимальныйРостDataGridViewTextBoxColumn.DataPropertyName = "Максимальный рост";
            this.максимальныйРостDataGridViewTextBoxColumn.HeaderText = "Максимальный рост";
            this.максимальныйРостDataGridViewTextBoxColumn.Name = "максимальныйРостDataGridViewTextBoxColumn";
            this.максимальныйРостDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // минимальныйВесDataGridViewTextBoxColumn
            // 
            this.минимальныйВесDataGridViewTextBoxColumn.DataPropertyName = "Минимальный вес";
            this.минимальныйВесDataGridViewTextBoxColumn.HeaderText = "Минимальный вес";
            this.минимальныйВесDataGridViewTextBoxColumn.Name = "минимальныйВесDataGridViewTextBoxColumn";
            this.минимальныйВесDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // максимальныйВесDataGridViewTextBoxColumn
            // 
            this.максимальныйВесDataGridViewTextBoxColumn.DataPropertyName = "Максимальный вес";
            this.максимальныйВесDataGridViewTextBoxColumn.HeaderText = "Максимальный вес";
            this.максимальныйВесDataGridViewTextBoxColumn.Name = "максимальныйВесDataGridViewTextBoxColumn";
            this.максимальныйВесDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Norms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 174);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Norms";
            this.Text = "Norms";
            this.Load += new System.EventHandler(this.Norms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chidlGrDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ChidlGrDbDataSet1 chidlGrDbDataSet1;
        private System.Windows.Forms.BindingSource normsBindingSource;
        private ChidlGrDbDataSet1TableAdapters.NormsTableAdapter normsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальныйРостDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn максимальныйРостDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальныйВесDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn максимальныйВесDataGridViewTextBoxColumn;
    }
}