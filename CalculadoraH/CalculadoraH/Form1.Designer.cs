namespace CalculadoraH
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
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIVISIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mULTIPLICACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbEstado = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(327, 12);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(91, 16);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "Resualtado:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(122, 129);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(184, 22);
            this.txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(493, 129);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(184, 22);
            this.txtNumero2.TabIndex = 2;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 179);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.Size = new System.Drawing.Size(786, 166);
            this.dgvHistorial.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sUMAToolStripMenuItem,
            this.rESTAToolStripMenuItem,
            this.dIVISIONToolStripMenuItem,
            this.mULTIPLICACIONToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sUMAToolStripMenuItem
            // 
            this.sUMAToolStripMenuItem.Name = "sUMAToolStripMenuItem";
            this.sUMAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sUMAToolStripMenuItem.Text = "SUMA";
            this.sUMAToolStripMenuItem.Click += new System.EventHandler(this.sUMAToolStripMenuItem_Click);
            // 
            // rESTAToolStripMenuItem
            // 
            this.rESTAToolStripMenuItem.Name = "rESTAToolStripMenuItem";
            this.rESTAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rESTAToolStripMenuItem.Text = "RESTA";
            this.rESTAToolStripMenuItem.Click += new System.EventHandler(this.rESTAToolStripMenuItem_Click);
            // 
            // dIVISIONToolStripMenuItem
            // 
            this.dIVISIONToolStripMenuItem.Name = "dIVISIONToolStripMenuItem";
            this.dIVISIONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dIVISIONToolStripMenuItem.Text = "DIVISION";
            this.dIVISIONToolStripMenuItem.Click += new System.EventHandler(this.dIVISIONToolStripMenuItem_Click);
            // 
            // mULTIPLICACIONToolStripMenuItem
            // 
            this.mULTIPLICACIONToolStripMenuItem.Name = "mULTIPLICACIONToolStripMenuItem";
            this.mULTIPLICACIONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mULTIPLICACIONToolStripMenuItem.Text = "MULTIPLICACION";
            this.mULTIPLICACIONToolStripMenuItem.Click += new System.EventHandler(this.mULTIPLICACIONToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbEstado
            // 
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(177, 20);
            this.lbEstado.Text = "Contador de operaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIVISIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mULTIPLICACIONToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbEstado;
    }
}

