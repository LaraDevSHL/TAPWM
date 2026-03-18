namespace PEmpregado
{
    partial class frmHorista
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
            this.btnInstancia1 = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.lblFalta = new System.Windows.Forms.Label();
            this.txtNHoras = new System.Windows.Forms.TextBox();
            this.lblNHoras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInstancia1
            // 
            this.btnInstancia1.Location = new System.Drawing.Point(297, 325);
            this.btnInstancia1.Name = "btnInstancia1";
            this.btnInstancia1.Size = new System.Drawing.Size(232, 71);
            this.btnInstancia1.TabIndex = 18;
            this.btnInstancia1.Text = "Instanciar Horista";
            this.btnInstancia1.UseVisualStyleBackColor = true;
            this.btnInstancia1.Click += new System.EventHandler(this.btnInstancia1_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(367, 237);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(329, 26);
            this.txtData.TabIndex = 17;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(367, 170);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(329, 26);
            this.txtSalario.TabIndex = 16;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(367, 138);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(329, 26);
            this.txtNome.TabIndex = 15;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(367, 106);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(329, 26);
            this.txtMatricula.TabIndex = 14;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(104, 237);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(213, 20);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Data de entrada na empresa";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(104, 169);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(97, 20);
            this.lblSalario.TabIndex = 12;
            this.lblSalario.Text = "Salário Hora";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(104, 136);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(104, 106);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 20);
            this.lblMatricula.TabIndex = 10;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(367, 269);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(329, 26);
            this.txtFaltas.TabIndex = 21;
            // 
            // lblFalta
            // 
            this.lblFalta.AutoSize = true;
            this.lblFalta.Location = new System.Drawing.Point(104, 268);
            this.lblFalta.Name = "lblFalta";
            this.lblFalta.Size = new System.Drawing.Size(98, 20);
            this.lblFalta.TabIndex = 20;
            this.lblFalta.Text = "Dias de falta";
            // 
            // txtNHoras
            // 
            this.txtNHoras.Location = new System.Drawing.Point(367, 202);
            this.txtNHoras.Name = "txtNHoras";
            this.txtNHoras.Size = new System.Drawing.Size(329, 26);
            this.txtNHoras.TabIndex = 23;
            // 
            // lblNHoras
            // 
            this.lblNHoras.AutoSize = true;
            this.lblNHoras.Location = new System.Drawing.Point(104, 201);
            this.lblNHoras.Name = "lblNHoras";
            this.lblNHoras.Size = new System.Drawing.Size(134, 20);
            this.lblNHoras.TabIndex = 22;
            this.lblNHoras.Text = "Número de Horas";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNHoras);
            this.Controls.Add(this.lblNHoras);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.lblFalta);
            this.Controls.Add(this.btnInstancia1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInstancia1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Label lblFalta;
        private System.Windows.Forms.TextBox txtNHoras;
        private System.Windows.Forms.Label lblNHoras;
    }
}