namespace ControleFaculdade
{
    partial class FormADD
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
            this.btnAddAtividade = new System.Windows.Forms.Button();
            this.btnAddMateria = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAtividade
            // 
            this.btnAddAtividade.Location = new System.Drawing.Point(292, 119);
            this.btnAddAtividade.Name = "btnAddAtividade";
            this.btnAddAtividade.Size = new System.Drawing.Size(118, 54);
            this.btnAddAtividade.TabIndex = 3;
            this.btnAddAtividade.Text = "Atividade";
            this.btnAddAtividade.UseVisualStyleBackColor = true;
            this.btnAddAtividade.Click += new System.EventHandler(this.btnAddAtividade_Click);
            // 
            // btnAddMateria
            // 
            this.btnAddMateria.Location = new System.Drawing.Point(79, 119);
            this.btnAddMateria.Name = "btnAddMateria";
            this.btnAddMateria.Size = new System.Drawing.Size(118, 54);
            this.btnAddMateria.TabIndex = 2;
            this.btnAddMateria.Text = "Matéria";
            this.btnAddMateria.UseVisualStyleBackColor = true;
            this.btnAddMateria.Click += new System.EventHandler(this.btnAddMateria_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.Location = new System.Drawing.Point(401, 258);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(75, 23);
            this.btnVolta.TabIndex = 4;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // FormADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 293);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnAddAtividade);
            this.Controls.Add(this.btnAddMateria);
            this.Name = "FormADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Materia/Atividade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormADD_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAtividade;
        private System.Windows.Forms.Button btnAddMateria;
        private System.Windows.Forms.Button btnVolta;
    }
}