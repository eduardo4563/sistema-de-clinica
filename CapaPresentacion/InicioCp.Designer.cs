
namespace CapaPresentacion
{
    partial class InicioCp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioCp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aunteticarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.iniciarSeccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1006, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(153, 711);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepcionistaToolStripMenuItem,
            this.doctorToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // recepcionistaToolStripMenuItem
            // 
            this.recepcionistaToolStripMenuItem.Name = "recepcionistaToolStripMenuItem";
            this.recepcionistaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.recepcionistaToolStripMenuItem.Text = "Recepcionista";
            this.recepcionistaToolStripMenuItem.Click += new System.EventHandler(this.recepcionistaToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // iniciarSeccionToolStripMenuItem
            // 
            this.iniciarSeccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aunteticarToolStripMenuItem});
            this.iniciarSeccionToolStripMenuItem.Name = "iniciarSeccionToolStripMenuItem";
            this.iniciarSeccionToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.iniciarSeccionToolStripMenuItem.Text = "Iniciar seccion";
            this.iniciarSeccionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSeccionToolStripMenuItem_Click);
            // 
            // aunteticarToolStripMenuItem
            // 
            this.aunteticarToolStripMenuItem.Name = "aunteticarToolStripMenuItem";
            this.aunteticarToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.aunteticarToolStripMenuItem.Text = "Aunteticar";
            this.aunteticarToolStripMenuItem.Click += new System.EventHandler(this.aunteticarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1006, 711);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // InicioCp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioCp";
            this.Text = "InicioCp";
            this.Load += new System.EventHandler(this.InicioCp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aunteticarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}