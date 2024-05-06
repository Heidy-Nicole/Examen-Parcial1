namespace ejer4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersona = new DataGridView();
            persona_id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            ap_paterno = new DataGridViewTextBoxColumn();
            ap_materno = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            btnObtener = new Button();
            dgvCuenta = new DataGridView();
            cuentabancaria_id = new DataGridViewTextBoxColumn();
            numero_cuenta = new DataGridViewTextBoxColumn();
            saldo = new DataGridViewTextBoxColumn();
            persona_idd = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Columns.AddRange(new DataGridViewColumn[] { persona_id, nombre, ap_paterno, ap_materno, correo, rol, departamento });
            dgvPersona.Location = new Point(39, 24);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.RowHeadersWidth = 51;
            dgvPersona.Size = new Size(994, 188);
            dgvPersona.TabIndex = 0;
            // 
            // persona_id
            // 
            persona_id.HeaderText = "Id Persona";
            persona_id.MinimumWidth = 6;
            persona_id.Name = "persona_id";
            persona_id.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // ap_paterno
            // 
            ap_paterno.HeaderText = "Paterno";
            ap_paterno.MinimumWidth = 6;
            ap_paterno.Name = "ap_paterno";
            ap_paterno.Width = 125;
            // 
            // ap_materno
            // 
            ap_materno.HeaderText = "Materno";
            ap_materno.MinimumWidth = 6;
            ap_materno.Name = "ap_materno";
            ap_materno.Width = 125;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.Width = 125;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.Width = 125;
            // 
            // departamento
            // 
            departamento.HeaderText = "Departamento";
            departamento.MinimumWidth = 6;
            departamento.Name = "departamento";
            departamento.Width = 125;
            // 
            // btnObtener
            // 
            btnObtener.Location = new Point(60, 457);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(183, 94);
            btnObtener.TabIndex = 2;
            btnObtener.Text = "OBTENER DATOS";
            btnObtener.UseVisualStyleBackColor = true;
            btnObtener.Click += btnObtener_Click;
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Columns.AddRange(new DataGridViewColumn[] { cuentabancaria_id, numero_cuenta, saldo, persona_idd, tipo });
            dgvCuenta.Location = new Point(39, 240);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.Size = new Size(714, 188);
            dgvCuenta.TabIndex = 3;
            dgvCuenta.CellContentClick += dgvCuenta_CellContentClick;
            // 
            // cuentabancaria_id
            // 
            cuentabancaria_id.HeaderText = "Cuenta";
            cuentabancaria_id.MinimumWidth = 6;
            cuentabancaria_id.Name = "cuentabancaria_id";
            cuentabancaria_id.Width = 125;
            // 
            // numero_cuenta
            // 
            numero_cuenta.HeaderText = "Numero cuenta";
            numero_cuenta.MinimumWidth = 6;
            numero_cuenta.Name = "numero_cuenta";
            numero_cuenta.Width = 125;
            // 
            // saldo
            // 
            saldo.HeaderText = "Saldo";
            saldo.MinimumWidth = 6;
            saldo.Name = "saldo";
            saldo.Width = 125;
            // 
            // persona_idd
            // 
            persona_idd.HeaderText = "Id Persona";
            persona_idd.MinimumWidth = 6;
            persona_idd.Name = "persona_idd";
            persona_idd.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 563);
            Controls.Add(dgvCuenta);
            Controls.Add(btnObtener);
            Controls.Add(dgvPersona);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersona;
        private Button btnObtener;
        private DataGridViewTextBoxColumn persona_id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn ap_paterno;
        private DataGridViewTextBoxColumn ap_materno;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn departamento;
        private DataGridView dgvCuenta;
        private DataGridViewTextBoxColumn cuentabancaria_id;
        private DataGridViewTextBoxColumn numero_cuenta;
        private DataGridViewTextBoxColumn saldo;
        private DataGridViewTextBoxColumn persona_idd;
        private DataGridViewTextBoxColumn tipo;
    }
}
