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
            this.SuspendLayout();
            // 
            // txtNomeDaAtividade
            // 
            this.txtNomeDaAtividade.Location = new System.Drawing.Point(32, 50);
            this.txtNomeDaAtividade.Name = "txtNomeDaAtividade";
            this.txtNomeDaAtividade.Size = new System.Drawing.Size(444, 20);
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
            // FormAddAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
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
    }
}