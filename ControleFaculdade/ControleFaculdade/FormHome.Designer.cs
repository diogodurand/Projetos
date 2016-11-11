namespace ControleFaculdade
{
    partial class FormHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.tblMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBControleFaculdadeDataSet = new ControleFaculdade.DBControleFaculdadeDataSet();
            this.tblMateriaTableAdapter = new ControleFaculdade.DBControleFaculdadeDataSetTableAdapters.tblMateriaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAtividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAtividadeTableAdapter = new ControleFaculdade.DBControleFaculdadeDataSetTableAdapters.tblAtividadeTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControleFaculdadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAtividadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdicionar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAdicionar
            // 
            this.MenuAdicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaToolStripMenuItem,
            this.atividadeToolStripMenuItem});
            this.MenuAdicionar.Name = "MenuAdicionar";
            this.MenuAdicionar.Padding = new System.Windows.Forms.Padding(0);
            this.MenuAdicionar.Size = new System.Drawing.Size(62, 20);
            this.MenuAdicionar.Text = "Adicionar";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // atividadeToolStripMenuItem
            // 
            this.atividadeToolStripMenuItem.Name = "atividadeToolStripMenuItem";
            this.atividadeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.atividadeToolStripMenuItem.Text = "Atividade";
            this.atividadeToolStripMenuItem.Click += new System.EventHandler(this.atividadeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DataSource = this.tblMateriaBindingSource;
            this.cmbMateria.DisplayMember = "NOME_MATERIA";
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(16, 63);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(275, 21);
            this.cmbMateria.TabIndex = 3;
            this.cmbMateria.ValueMember = "ID";
            this.cmbMateria.SelectedValueChanged += new System.EventHandler(this.cmbMateria_SelectedValueChanged);
            this.cmbMateria.Click += new System.EventHandler(this.cmbMateria_Click);
            // 
            // tblMateriaBindingSource
            // 
            this.tblMateriaBindingSource.DataMember = "tblMateria";
            this.tblMateriaBindingSource.DataSource = this.dBControleFaculdadeDataSet;
            // 
            // dBControleFaculdadeDataSet
            // 
            this.dBControleFaculdadeDataSet.DataSetName = "DBControleFaculdadeDataSet";
            this.dBControleFaculdadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMateriaTableAdapter
            // 
            this.tblMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.tblAtividadeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 418);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_ATIVIDADE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Atividade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DESC_ATIVIDADE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATA_ENTREGA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Entrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tblAtividadeBindingSource
            // 
            this.tblAtividadeBindingSource.DataMember = "tblAtividade";
            this.tblAtividadeBindingSource.DataSource = this.dBControleFaculdadeDataSet;
            // 
            // tblAtividadeTableAdapter
            // 
            this.tblAtividadeTableAdapter.ClearBeforeFill = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle da Faculdade";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControleFaculdadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAtividadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAdicionar;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbMateria;
        private DBControleFaculdadeDataSet dBControleFaculdadeDataSet;
        private System.Windows.Forms.BindingSource tblMateriaBindingSource;
        private DBControleFaculdadeDataSetTableAdapters.tblMateriaTableAdapter tblMateriaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblAtividadeBindingSource;
        private DBControleFaculdadeDataSetTableAdapters.tblAtividadeTableAdapter tblAtividadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}