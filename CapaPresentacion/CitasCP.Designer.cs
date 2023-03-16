
namespace CapaPresentacion
{
    partial class CitasCP
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuscarDoctor = new System.Windows.Forms.Button();
            this.btnBuscarRecepcionista = new System.Windows.Forms.Button();
            this.btnBuscarAnimal = new System.Windows.Forms.Button();
            this.txtIdRecepcionista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdDoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAnimal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFechaCita = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHoraCita = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtValorBuscado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuscarDoctor);
            this.groupBox5.Controls.Add(this.btnBuscarRecepcionista);
            this.groupBox5.Controls.Add(this.btnBuscarAnimal);
            this.groupBox5.Controls.Add(this.txtIdRecepcionista);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtIdDoctor);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtIdAnimal);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtIdCita);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtFechaCita);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtHoraCita);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.txtFechaRegistro);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 64);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(492, 347);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cita";
            // 
            // btnBuscarDoctor
            // 
            this.btnBuscarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDoctor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDoctor.Location = new System.Drawing.Point(207, 282);
            this.btnBuscarDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarDoctor.Name = "btnBuscarDoctor";
            this.btnBuscarDoctor.Size = new System.Drawing.Size(99, 26);
            this.btnBuscarDoctor.TabIndex = 42;
            this.btnBuscarDoctor.Text = "Buscar";
            this.btnBuscarDoctor.UseVisualStyleBackColor = false;
            this.btnBuscarDoctor.Click += new System.EventHandler(this.btnBuscarDoctor_Click);
            // 
            // btnBuscarRecepcionista
            // 
            this.btnBuscarRecepcionista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRecepcionista.ForeColor = System.Drawing.Color.White;
            this.btnBuscarRecepcionista.Location = new System.Drawing.Point(207, 234);
            this.btnBuscarRecepcionista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarRecepcionista.Name = "btnBuscarRecepcionista";
            this.btnBuscarRecepcionista.Size = new System.Drawing.Size(99, 26);
            this.btnBuscarRecepcionista.TabIndex = 41;
            this.btnBuscarRecepcionista.Text = "Buscar";
            this.btnBuscarRecepcionista.UseVisualStyleBackColor = false;
            this.btnBuscarRecepcionista.Click += new System.EventHandler(this.btnBuscarRecepcionista_Click);
            // 
            // btnBuscarAnimal
            // 
            this.btnBuscarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAnimal.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAnimal.Location = new System.Drawing.Point(207, 185);
            this.btnBuscarAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarAnimal.Name = "btnBuscarAnimal";
            this.btnBuscarAnimal.Size = new System.Drawing.Size(99, 26);
            this.btnBuscarAnimal.TabIndex = 40;
            this.btnBuscarAnimal.Text = "Buscar";
            this.btnBuscarAnimal.UseVisualStyleBackColor = false;
            this.btnBuscarAnimal.Click += new System.EventHandler(this.btnBuscarAnimal_Click);
            // 
            // txtIdRecepcionista
            // 
            this.txtIdRecepcionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRecepcionista.Location = new System.Drawing.Point(141, 234);
            this.txtIdRecepcionista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdRecepcionista.Name = "txtIdRecepcionista";
            this.txtIdRecepcionista.ReadOnly = true;
            this.txtIdRecepcionista.Size = new System.Drawing.Size(56, 24);
            this.txtIdRecepcionista.TabIndex = 23;
            this.txtIdRecepcionista.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "IdRecepcionista:";
            // 
            // txtIdDoctor
            // 
            this.txtIdDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDoctor.Location = new System.Drawing.Point(141, 282);
            this.txtIdDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdDoctor.Name = "txtIdDoctor";
            this.txtIdDoctor.ReadOnly = true;
            this.txtIdDoctor.Size = new System.Drawing.Size(56, 24);
            this.txtIdDoctor.TabIndex = 21;
            this.txtIdDoctor.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id Doctor:";
            // 
            // txtIdAnimal
            // 
            this.txtIdAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAnimal.Location = new System.Drawing.Point(141, 185);
            this.txtIdAnimal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdAnimal.Name = "txtIdAnimal";
            this.txtIdAnimal.ReadOnly = true;
            this.txtIdAnimal.Size = new System.Drawing.Size(56, 24);
            this.txtIdAnimal.TabIndex = 19;
            this.txtIdAnimal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Id Animal:";
            // 
            // txtIdCita
            // 
            this.txtIdCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCita.Location = new System.Drawing.Point(141, 31);
            this.txtIdCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.ReadOnly = true;
            this.txtIdCita.Size = new System.Drawing.Size(56, 24);
            this.txtIdCita.TabIndex = 17;
            this.txtIdCita.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Id:";
            // 
            // txtFechaCita
            // 
            this.txtFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCita.Location = new System.Drawing.Point(141, 109);
            this.txtFechaCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaCita.Name = "txtFechaCita";
            this.txtFechaCita.Size = new System.Drawing.Size(243, 24);
            this.txtFechaCita.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 114);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 18);
            this.label19.TabIndex = 11;
            this.label19.Text = "Fecha Cita:";
            // 
            // txtHoraCita
            // 
            this.txtHoraCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraCita.Location = new System.Drawing.Point(141, 141);
            this.txtHoraCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraCita.Name = "txtHoraCita";
            this.txtHoraCita.Size = new System.Drawing.Size(116, 24);
            this.txtHoraCita.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 143);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 18);
            this.label22.TabIndex = 4;
            this.label22.Text = "Hora Cita:";
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRegistro.Location = new System.Drawing.Point(141, 64);
            this.txtFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(243, 24);
            this.txtFechaRegistro.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 68);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 18);
            this.label23.TabIndex = 0;
            this.label23.Text = "Fecha Registro:";
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(13, 451);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.Size = new System.Drawing.Size(583, 177);
            this.dgvCitas.TabIndex = 16;
            this.dgvCitas.SelectionChanged += new System.EventHandler(this.dgvCitas_SelectionChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCerrar);
            this.groupBox6.Controls.Add(this.btnEliminar);
            this.groupBox6.Controls.Add(this.btnNuevo);
            this.groupBox6.Controls.Add(this.btnGuardar);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(537, 71);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(385, 158);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Acciones";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(223, 91);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 38);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(223, 34);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 38);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(32, 34);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 38);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(32, 91);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 38);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtValorBuscado
            // 
            this.txtValorBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorBuscado.Location = new System.Drawing.Point(662, 500);
            this.txtValorBuscado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorBuscado.Name = "txtValorBuscado";
            this.txtValorBuscado.Size = new System.Drawing.Size(343, 24);
            this.txtValorBuscado.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 464);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar Cita:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(882, 542);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 38);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CitasCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1094, 703);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtValorBuscado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CitasCP";
            this.Text = "CitasCP";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtValorBuscado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtFechaCita;
        public System.Windows.Forms.TextBox txtHoraCita;
        public System.Windows.Forms.TextBox txtFechaRegistro;
        public System.Windows.Forms.TextBox txtIdCita;
        public System.Windows.Forms.TextBox txtIdRecepcionista;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIdDoctor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtIdAnimal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarDoctor;
        private System.Windows.Forms.Button btnBuscarRecepcionista;
        private System.Windows.Forms.Button btnBuscarAnimal;
        private System.Windows.Forms.Timer timer1;
    }
}