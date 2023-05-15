
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
            this.btndoctor = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnrecepcionista = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblposiciton = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
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
            // btndoctor
            // 
            this.btndoctor.Location = new System.Drawing.Point(65, 210);
            this.btndoctor.Name = "btndoctor";
            this.btndoctor.Size = new System.Drawing.Size(269, 65);
            this.btndoctor.TabIndex = 1;
            this.btndoctor.Text = "Doctor";
            this.btndoctor.UseVisualStyleBackColor = true;
            this.btndoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(358, 210);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(269, 65);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            // 
            // btnrecepcionista
            // 
            this.btnrecepcionista.Location = new System.Drawing.Point(664, 210);
            this.btnrecepcionista.Name = "btnrecepcionista";
            this.btnrecepcionista.Size = new System.Drawing.Size(269, 65);
            this.btnrecepcionista.TabIndex = 2;
            this.btnrecepcionista.Text = "recepcionista";
            this.btnrecepcionista.UseVisualStyleBackColor = true;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(44, 56);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 16);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "label1";
            // 
            // lblposiciton
            // 
            this.lblposiciton.AutoSize = true;
            this.lblposiciton.Location = new System.Drawing.Point(44, 90);
            this.lblposiciton.Name = "lblposiciton";
            this.lblposiciton.Size = new System.Drawing.Size(44, 16);
            this.lblposiciton.TabIndex = 4;
            this.lblposiciton.Text = "label2";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(44, 134);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(44, 16);
            this.lblcorreo.TabIndex = 5;
            this.lblcorreo.Text = "label3";
            // 
            // PrincipalCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(224)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1289, 743);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblposiciton);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnrecepcionista);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btndoctor);
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
        private System.Windows.Forms.Button btndoctor;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnrecepcionista;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblposiciton;
        private System.Windows.Forms.Label lblcorreo;
    }
}

