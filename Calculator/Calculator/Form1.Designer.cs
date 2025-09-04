using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Calculator
{
    partial class frmCalculator
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
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.ldNumero2 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(12, 208);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(221, 22);
            this.txtFirstNumber.TabIndex = 0;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(419, 208);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(213, 22);
            this.txtSecondNumber.TabIndex = 1;
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Location = new System.Drawing.Point(100, 158);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(97, 16);
            this.lbNumero1.TabIndex = 2;
            this.lbNumero1.Text = "Primer Numero";
            this.lbNumero1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ldNumero2
            // 
            this.ldNumero2.AutoSize = true;
            this.ldNumero2.Location = new System.Drawing.Point(516, 158);
            this.ldNumero2.Name = "ldNumero2";
            this.ldNumero2.Size = new System.Drawing.Size(113, 16);
            this.ldNumero2.TabIndex = 3;
            this.ldNumero2.Text = "Segundo Numero";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(311, 59);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(125, 16);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "Claculadora Basica";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(311, 292);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(75, 16);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "Resultado: ";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(25, 419);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(119, 32);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = " SUMA";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(199, 419);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(119, 32);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "RESTA";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(395, 419);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(119, 32);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "DIVISION";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(576, 419);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(119, 32);
            this.btnMultiplicacion.TabIndex = 9;
            this.btnMultiplicacion.Text = "MULTIPLICACION";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 545);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ldNumero2);
            this.Controls.Add(this.lbNumero1);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Name = "frmCalculator";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private Label lbNumero1;
        private Label ldNumero2;
        private Label lbResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDivision;
        private Button btnMultiplicacion;
        private Label lbTitulo;
    }
}

