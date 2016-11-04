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
            this.txtNomeDaAtividade = new System.Windows.Forms.TextBox();
            this.lblNomeDaAtividade = new System.Windows.Forms.Label();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.dtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblDescricaoDaAtividade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 106);
            this.textBox1.TabIndex = 7;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // FormAddAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescricaoDaAtividade);
            this.Controls.Add(this.dtDataEntrega);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.txtNomeDaAtividade);
            this.Controls.Add(this.lblNomeDaAtividade);
            this.Name = "FormAddAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Nova Atividade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDaAtividade;
        private System.Windows.Forms.Label lblNomeDaAtividade;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.DateTimePicker dtDataEntrega;
        private System.Windows.Forms.Label lblDescricaoDaAtividade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}