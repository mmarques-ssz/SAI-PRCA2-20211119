namespace WFA_SomaPOO
{
    partial class Form1
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
            this.chkNegativo = new System.Windows.Forms.CheckBox();
            this.chkPar = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMenor0 = new System.Windows.Forms.RadioButton();
            this.radMaior0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPar = new System.Windows.Forms.RadioButton();
            this.radImpar = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkNegativo
            // 
            this.chkNegativo.AutoSize = true;
            this.chkNegativo.Enabled = false;
            this.chkNegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNegativo.Location = new System.Drawing.Point(335, 468);
            this.chkNegativo.Name = "chkNegativo";
            this.chkNegativo.Size = new System.Drawing.Size(144, 35);
            this.chkNegativo.TabIndex = 26;
            this.chkNegativo.Text = "Negativo";
            this.chkNegativo.UseVisualStyleBackColor = true;
            // 
            // chkPar
            // 
            this.chkPar.AutoSize = true;
            this.chkPar.Enabled = false;
            this.chkPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPar.Location = new System.Drawing.Point(156, 468);
            this.chkPar.Name = "chkPar";
            this.chkPar.Size = new System.Drawing.Size(78, 35);
            this.chkPar.TabIndex = 25;
            this.chkPar.Text = "Par";
            this.chkPar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMenor0);
            this.groupBox2.Controls.Add(this.radMaior0);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(335, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 131);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // radMenor0
            // 
            this.radMenor0.AutoSize = true;
            this.radMenor0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenor0.Location = new System.Drawing.Point(29, 59);
            this.radMenor0.Name = "radMenor0";
            this.radMenor0.Size = new System.Drawing.Size(73, 35);
            this.radMenor0.TabIndex = 13;
            this.radMenor0.TabStop = true;
            this.radMenor0.Text = "< 0";
            this.radMenor0.UseVisualStyleBackColor = true;
            // 
            // radMaior0
            // 
            this.radMaior0.AutoSize = true;
            this.radMaior0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaior0.Location = new System.Drawing.Point(29, 18);
            this.radMaior0.Name = "radMaior0";
            this.radMaior0.Size = new System.Drawing.Size(89, 35);
            this.radMaior0.TabIndex = 12;
            this.radMaior0.TabStop = true;
            this.radMaior0.Text = ">= 0";
            this.radMaior0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPar);
            this.groupBox1.Controls.Add(this.radImpar);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(153, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 131);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // radPar
            // 
            this.radPar.AutoSize = true;
            this.radPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPar.Location = new System.Drawing.Point(22, 68);
            this.radPar.Name = "radPar";
            this.radPar.Size = new System.Drawing.Size(77, 35);
            this.radPar.TabIndex = 11;
            this.radPar.Text = "Par";
            this.radPar.UseVisualStyleBackColor = true;
            // 
            // radImpar
            // 
            this.radImpar.AutoSize = true;
            this.radImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radImpar.Location = new System.Drawing.Point(22, 27);
            this.radImpar.Name = "radImpar";
            this.radImpar.Size = new System.Drawing.Size(104, 35);
            this.radImpar.TabIndex = 10;
            this.radImpar.Text = "Ímpar";
            this.radImpar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Resultado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "2º número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "1º número";
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(325, 75);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(150, 38);
            this.txtN2.TabIndex = 19;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(233, 150);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(137, 63);
            this.btnSomar.TabIndex = 18;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(165, 75);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(150, 38);
            this.txtN1.TabIndex = 17;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(371, 264);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(29, 31);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 544);
            this.Controls.Add(this.chkNegativo);
            this.Controls.Add(this.chkPar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNegativo;
        private System.Windows.Forms.CheckBox chkPar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMenor0;
        private System.Windows.Forms.RadioButton radMaior0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPar;
        private System.Windows.Forms.RadioButton radImpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblResultado;
    }
}

