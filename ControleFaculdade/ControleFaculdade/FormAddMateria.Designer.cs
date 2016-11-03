namespace ControleFaculdade
{
    partial class FormAddMateria
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
            this.lblNomeDaMateria = new System.Windows.Forms.Label();
            this.txtNomeDaMateria = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeDaMateria
            // 
            this.lblNomeDaMateria.AutoSize = true;
            this.lblNomeDaMateria.Location = new System.Drawing.Point(29, 33);
            this.lblNomeDaMateria.Name = "lblNomeDaMateria";
            this.lblNomeDaMateria.Size = new System.Drawing.Size(93, 13);
            this.lblNomeDaMateria.TabIndex = 0;
            this.lblNomeDaMateria.Text = "Nome Da Matéria:";
            // 
            // txtNomeDaMateria
            // 
            this.txtNomeDaMateria.Location = new System.Drawing.Point(32, 50);
            this.txtNomeDaMateria.Name = "txtNomeDaMateria";
            this.txtNomeDaMateria.Size = new System.Drawing.Size(444, 20);
            this.txtNomeDaMateria.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(401, 258);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(320, 258);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // FormAddMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNomeDaMateria);
            this.Controls.Add(this.lblNomeDaMateria);
            this.Name = "FormAddMateria";
            this.Text = "FormAddMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDaMateria;
        private System.Windows.Forms.TextBox txtNomeDaMateria;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnOk;
    }
}