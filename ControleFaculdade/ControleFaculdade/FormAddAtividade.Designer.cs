﻿namespace ControleFaculdade
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
            this.SuspendLayout();
            // 
            // txtNomeDaAtividade
            // 
            this.txtNomeDaAtividade.Location = new System.Drawing.Point(32, 50);
            this.txtNomeDaAtividade.Name = "txtNomeDaAtividade";
            this.txtNomeDaAtividade.Size = new System.Drawing.Size(221, 20);
            this.txtNomeDaAtividade.TabIndex = 3;
            // 
            // lblNomeDaAtividade
            // 
            this.lblNomeDaAtividade.AutoSize = true;
            this.lblNomeDaAtividade.Location = new System.Drawing.Point(29, 33);
            this.lblNomeDaAtividade.Name = "lblNomeDaAtividade";
            this.lblNomeDaAtividade.Size = new System.Drawing.Size(102, 13);
            this.lblNomeDaAtividade.TabIndex = 2;
            this.lblNomeDaAtividade.Text = "Nome Da Atividade:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(263, 33);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(73, 13);
            this.lblDataEntrega.TabIndex = 4;
            this.lblDataEntrega.Text = "Data Entrega:";
            // 
            // dtDataEntrega
            // 
            this.dtDataEntrega.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataEntrega.Location = new System.Drawing.Point(266, 50);
            this.dtDataEntrega.Name = "dtDataEntrega";
            this.dtDataEntrega.Size = new System.Drawing.Size(137, 20);
            this.dtDataEntrega.TabIndex = 5;
            // 
            // lblDescricaoDaAtividade
            // 
            this.lblDescricaoDaAtividade.AutoSize = true;
            this.lblDescricaoDaAtividade.Location = new System.Drawing.Point(29, 86);
            this.lblDescricaoDaAtividade.Name = "lblDescricaoDaAtividade";
            this.lblDescricaoDaAtividade.Size = new System.Drawing.Size(122, 13);
            this.lblDescricaoDaAtividade.TabIndex = 6;
            this.lblDescricaoDaAtividade.Text = "Descrição Da Atividade:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 106);
            this.textBox1.TabIndex = 7;
            // 
            // FormAddAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescricaoDaAtividade);
            this.Controls.Add(this.dtDataEntrega);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.txtNomeDaAtividade);
            this.Controls.Add(this.lblNomeDaAtividade);
            this.Name = "FormAddAtividade";
            this.Text = "FormAddAtividade";
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
    }
}