
namespace CapaPresentacion
{
    partial class PrincipalCP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPropietarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.procesoToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.MdiWindowListItem = this.procesoToolStripMenuItem;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1289, 28);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.salirToolStripMenuItem.Text = "Cerrar seccion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPropietarios,
            this.mnuAnimal});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // mnuPropietarios
            // 
            this.mnuPropietarios.Name = "mnuPropietarios";
            this.mnuPropietarios.Size = new System.Drawing.Size(172, 26);
            this.mnuPropietarios.Text = "Propietarios";
            this.mnuPropietarios.Click += new System.EventHandler(this.mnuPropietarios_Click);
            // 
            // mnuAnimal
            // 
            this.mnuAnimal.Name = "mnuAnimal";
            this.mnuAnimal.Size = new System.Drawing.Size(172, 26);
            this.mnuAnimal.Text = "Animal";
            this.mnuAnimal.Click += new System.EventHandler(this.mnuAnimal_Click_1);
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCitas,
            this.atencionToolStripMenuItem});
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.procesoToolStripMenuItem.Text = "Proceso";
            // 
            // mnuCitas
            // 
            this.mnuCitas.Name = "mnuCitas";
            this.mnuCitas.Size = new System.Drawing.Size(151, 26);
            this.mnuCitas.Text = "Citas";
            this.mnuCitas.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // atencionToolStripMenuItem
            // 
            this.atencionToolStripMenuItem.Name = "atencionToolStripMenuItem";
            this.atencionToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.atencionToolStripMenuItem.Text = "Atencion";
            this.atencionToolStripMenuItem.Click += new System.EventHandler(this.atencionToolStripMenuItem_Click);
            // 
            // PrincipalCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(224)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1289, 743);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PrincipalCP_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCitas;
        private System.Windows.Forms.ToolStripMenuItem mnuPropietarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAnimal;
        private System.Windows.Forms.ToolStripMenuItem atencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

