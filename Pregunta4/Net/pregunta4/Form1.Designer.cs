namespace Ejer4
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
            btnObtener = new Button();
            persona_id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            ap_paterno = new DataGridViewTextBoxColumn();
            ap_materno = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            dgvCuentas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            saldo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Columns.AddRange(new DataGridViewColumn[] { persona_id, nombre, ap_paterno, ap_materno, Correo, rol, Departamento });
            dgvPersona.Location = new Point(22, 45);
            dgvPersona.Margin = new Padding(3, 4, 3, 4);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.RowHeadersWidth = 51;
            dgvPersona.Size = new Size(735, 200);
            dgvPersona.TabIndex = 1;
            dgvPersona.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnObtener
            // 
            btnObtener.Location = new Point(65, 535);
            btnObtener.Margin = new Padding(3, 4, 3, 4);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(131, 31);
            btnObtener.TabIndex = 2;
            btnObtener.Text = "Obtener datos";
            btnObtener.UseVisualStyleBackColor = true;
            btnObtener.Click += btnObtener_Click;
            // 
            // persona_id
            // 
            persona_id.HeaderText = "ID";
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
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.Width = 125;
            // 
            // Departamento
            // 
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.Width = 125;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn6, saldo });
            dgvCuentas.Location = new Point(22, 296);
            dgvCuentas.Margin = new Padding(3, 4, 3, 4);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(735, 200);
            dgvCuentas.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Rol";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // saldo
            // 
            saldo.HeaderText = "Saldo";
            saldo.MinimumWidth = 6;
            saldo.Name = "saldo";
            saldo.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvCuentas);
            Controls.Add(btnObtener);
            Controls.Add(dgvPersona);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersona;
        private Button btnObtener;
        private DataGridViewTextBoxColumn persona_id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn ap_paterno;
        private DataGridViewTextBoxColumn ap_materno;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridView dgvCuentas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn saldo;
    }
}
