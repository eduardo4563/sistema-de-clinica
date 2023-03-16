
namespace CapaPresentacion
{
    partial class INICIO
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.iniciarSeccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepcionistaToolStripMenuItem,
            this.doctoresToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.dToolStripMenuItem.Text = "Gestion";
            // 
            // recepcionistaToolStripMenuItem
            // 
            this.recepcionistaToolStripMenuItem.Name = "recepcionistaToolStripMenuItem";
            this.recepcionistaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recepcionistaToolStripMenuItem.Text = "Recepcionista";
            this.recepcionistaToolStripMenuItem.Click += new System.EventHandler(this.recepcionistaToolStripMenuItem_Click);
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.doctoresToolStripMenuItem.Text = "Doctores";
            this.doctoresToolStripMenuItem.Click += new System.EventHandler(this.doctoresToolStripMenuItem_Click);
            // 
            // iniciarSeccionToolStripMenuItem
            // 
            this.iniciarSeccionToolStripMenuItem.Name = "iniciarSeccionToolStripMenuItem";
            this.iniciarSeccionToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.iniciarSeccionToolStripMenuItem.Text = "Iniciar seccion";
            this.iniciarSeccionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSeccionToolStripMenuItem_Click);
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSeccionToolStripMenuItem;
    }
}