namespace CapaPresentacion.administrador
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lblposiciton = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(30, 525);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(248, 63);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.Text = "cerrar secion";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(49, 156);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(44, 16);
            this.lblcorreo.TabIndex = 8;
            this.lblcorreo.Text = "label3";
            // 
            // lblposiciton
            // 
            this.lblposiciton.AutoSize = true;
            this.lblposiciton.Location = new System.Drawing.Point(49, 101);
            this.lblposiciton.Name = "lblposiciton";
            this.lblposiciton.Size = new System.Drawing.Size(44, 16);
            this.lblposiciton.TabIndex = 7;
            this.lblposiciton.Text = "label2";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(49, 57);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 16);
            this.lblnombre.TabIndex = 6;
            this.lblnombre.Text = "label1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 636);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblposiciton);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lblposiciton;
        private System.Windows.Forms.Label lblnombre;
    }
}