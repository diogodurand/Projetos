namespace ControleFaculdade
{
    partial class FormAddAtividade
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
            this.txtNomeDaAtividade = new System.Windows.Forms.TextBox();
            this.lblNomeDaAtividade = new System.Windows.Forms.Label();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.dtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblDescricaoDaAtividade = new System.Windows.Forms.Label();
            this.boxDescAtividade = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.tblMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBControleFaculdadeDataSet = new ControleFaculdade.DBControleFaculdadeDataSet();
            this.dBControleFaculdadeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMateriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMateriaTableAdapter1 = new ControleFaculdade.DBControleFaculdadeDataSetTableAdapters.tblMateriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControleFaculdadeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControleFaculdadeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMateriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeDaAtividade
            // 
            this.txtNomeDaAtividade.Location = new System.Drawing.Point(32, 67);
            this.txtNomeDaAtividade.Name = "txtNomeDaAtividade";
            this.txtNomeDaAtividade.Size = new System.Drawing.Size(221, 20);
            this.txtNomeDaAtividade.TabIndex = 3;
            // 
            // lblNomeDaAtividade
            // 
            this.lblNomeDaAtividade.AutoSize = true;
            this.lblNomeDaAtividade.Location = new System.Drawing.Point(29, 50);
            this.lblNomeDaAtividade.Name = "lblNomeDaAtividade";
            this.lblNomeDaAtividade.Size = new System.Drawing.Size(102, 13);
            this.lblNomeDaAtividade.TabIndex = 2;
            this.lblNomeDaAtividade.Text = "Nome Da Atividade:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(263, 50);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(73, 13);
            this.lblDataEntrega.TabIndex = 4;
            this.lblDataEntrega.Text = "Data Entrega:";
            // 
            // dtDataEntrega
            // 
            this.dtDataEntrega.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEntrega.Location = new System.Drawing.Point(266, 67);
            this.dtDataEntrega.Name = "dtDataEntrega";
            this.dtDataEntrega.Size = new System.Drawing.Size(137, 20);
            this.dtDataEntrega.TabIndex = 5;
            // 
            // lblDescricaoDaAtividade
            // 
            this.lblDescricaoDaAtividade.AutoSize = true;
            this.lblDescricaoDaAtividade.Location = new System.Drawing.Point(29, 103);
            this.lblDescricaoDaAtividade.Name = "lblDescricaoDaAtividade";
            this.lblDescricaoDaAtividade.Size = new System.Drawing.Size(122, 13);
            this.lblDescricaoDaAtividade.TabIndex = 6;
            this.lblDescricaoDaAtividade.Text = "Descrição Da Atividade:";
            // 
            // boxDescAtividade
            // 
            this.boxDescAtividade.Location = new System.Drawing.Point(31, 120);
            this.boxDescAtividade.Multiline = true;
            this.boxDescAtividade.Name = "boxDescAtividade";
            this.boxDescAtividade.Size = new System.Drawing.Size(222, 106);
            this.boxDescAtividade.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(320, 258);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(401, 258);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(29, 20);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 10;
            this.lblMateria.Text = "Materia:";
            // 
            // comboMateria
            // 
            this.comboMateria.DataSource = this.tblMateriaBindingSource1;
            this.comboMateria.DisplayMember = "NOME_MATERIA";
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(80, 20);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(173, 21);
            this.comboMateria.TabIndex = 11;
            this.comboMateria.ValueMember = "ID";
            // 
            // dBControleFaculdadeDataSet
            // 
            this.dBControleFaculdadeDataSet.DataSetName = "DBControleFaculdadeDataSet";
            this.dBControleFaculdadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBControleFaculdadeDataSetBindingSource
            // 
            this.dBControleFaculdadeDataSetBindingSource.DataSource = this.dBControleFaculdadeDataSet;
            this.dBControleFaculdadeDataSetBindingSource.Position = 0;
            // 
            // tblMateriaBindingSource1
            // 
            this.tblMateriaBindingSource1.DataMember = "tblMateria";
            this.tblMateriaBindingSource1.DataSource = this.dBControleFaculdadeDataSet;
            // 
            // tblMateriaTableAdapter1
            // 
            this.tblMateriaTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.boxDescAtividade);
            this.Controls.Add(this.lblDescricaoDaAtividade);
            this.Controls.Add(this.dtDataEntrega);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.txtNomeDaAtividade);
            this.Controls.Add(this.lblNomeDaAtividade);
            this.Name = "FormAddAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Nova Atividade";
            this.Load += new System.EventHandler(this.FormAddAtividade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControleFaculdadeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBControleFaculdadeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMateriaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDaAtividade;
        private System.Windows.Forms.Label lblNomeDaAtividade;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.DateTimePicker dtDataEntrega;
        private System.Windows.Forms.Label lblDescricaoDaAtividade;
        private System.Windows.Forms.TextBox boxDescAtividade;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox comboMateria;
        
        private System.Windows.Forms.BindingSource tblMateriaBindingSource;
        
        
        private System.Windows.Forms.BindingSource dBControleFaculdadeDataSetBindingSource;
        private DBControleFaculdadeDataSet dBControleFaculdadeDataSet;
        private System.Windows.Forms.BindingSource tblMateriaBindingSource1;
        private DBControleFaculdadeDataSetTableAdapters.tblMateriaTableAdapter tblMateriaTableAdapter1;
    }
}