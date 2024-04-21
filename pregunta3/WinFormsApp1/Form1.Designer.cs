namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            txtdireccion = new TextBox();
            label5 = new Label();
            txtedad = new TextBox();
            label4 = new Label();
            btneliminar = new Button();
            btnmodificar = new Button();
            btnguardar = new Button();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            txtid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvPersona = new DataGridView();
            groupBox2 = new GroupBox();
            txttipo = new TextBox();
            label6 = new Label();
            txtsaldo = new TextBox();
            label7 = new Label();
            btneliminarcuenta = new Button();
            btnmodificarcuenta = new Button();
            btnguardarcuenta = new Button();
            txtnumero = new TextBox();
            txtidPersona = new TextBox();
            txtidcuenta = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgvCuenta = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtedad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btneliminar);
            groupBox1.Controls.Add(btnmodificar);
            groupBox1.Controls.Add(btnguardar);
            groupBox1.Controls.Add(txtapellido);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 325);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Persona";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(112, 177);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(209, 27);
            txtdireccion.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 177);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Direccion";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(112, 140);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(209, 27);
            txtedad.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 143);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 9;
            label4.Text = "Edad";
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(32, 264);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(306, 29);
            btneliminar.TabIndex = 8;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(191, 229);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(147, 29);
            btnmodificar.TabIndex = 7;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(32, 229);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(153, 29);
            btnguardar.TabIndex = 6;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(112, 107);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(209, 27);
            txtapellido.TabIndex = 5;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(112, 71);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(209, 27);
            txtnombre.TabIndex = 4;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(112, 35);
            txtid.Name = "txtid";
            txtid.Size = new Size(209, 27);
            txtid.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 107);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Persona";
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Location = new Point(420, 40);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.RowHeadersWidth = 51;
            dgvPersona.Size = new Size(704, 325);
            dgvPersona.TabIndex = 1;
            dgvPersona.CellDoubleClick += dgvPersona_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txttipo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtsaldo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btneliminarcuenta);
            groupBox2.Controls.Add(btnmodificarcuenta);
            groupBox2.Controls.Add(btnguardarcuenta);
            groupBox2.Controls.Add(txtnumero);
            groupBox2.Controls.Add(txtidPersona);
            groupBox2.Controls.Add(txtidcuenta);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(27, 408);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 325);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "cuentaBancaria";
            // 
            // txttipo
            // 
            txttipo.Location = new Point(129, 170);
            txttipo.Name = "txttipo";
            txttipo.Size = new Size(209, 27);
            txttipo.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 177);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 11;
            label6.Text = "tipoCuenta";
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point(129, 136);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(209, 27);
            txtsaldo.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 143);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 9;
            label7.Text = "Saldo";
            // 
            // btneliminarcuenta
            // 
            btneliminarcuenta.Location = new Point(32, 264);
            btneliminarcuenta.Name = "btneliminarcuenta";
            btneliminarcuenta.Size = new Size(306, 29);
            btneliminarcuenta.TabIndex = 8;
            btneliminarcuenta.Text = "Eliminar";
            btneliminarcuenta.UseVisualStyleBackColor = true;
            btneliminarcuenta.Click += btneliminarcuenta_Click;
            // 
            // btnmodificarcuenta
            // 
            btnmodificarcuenta.Location = new Point(191, 229);
            btnmodificarcuenta.Name = "btnmodificarcuenta";
            btnmodificarcuenta.Size = new Size(147, 29);
            btnmodificarcuenta.TabIndex = 7;
            btnmodificarcuenta.Text = "Modificar";
            btnmodificarcuenta.UseVisualStyleBackColor = true;
            btnmodificarcuenta.Click += btnmodificarcuenta_Click;
            // 
            // btnguardarcuenta
            // 
            btnguardarcuenta.Location = new Point(32, 229);
            btnguardarcuenta.Name = "btnguardarcuenta";
            btnguardarcuenta.Size = new Size(153, 29);
            btnguardarcuenta.TabIndex = 6;
            btnguardarcuenta.Text = "Guardar";
            btnguardarcuenta.UseVisualStyleBackColor = true;
            btnguardarcuenta.Click += btnguardarcuenta_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(129, 104);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(209, 27);
            txtnumero.TabIndex = 5;
            // 
            // txtidPersona
            // 
            txtidPersona.Location = new Point(129, 71);
            txtidPersona.Name = "txtidPersona";
            txtidPersona.Size = new Size(209, 27);
            txtidPersona.TabIndex = 4;
            // 
            // txtidcuenta
            // 
            txtidcuenta.Enabled = false;
            txtidcuenta.Location = new Point(129, 38);
            txtidcuenta.Name = "txtidcuenta";
            txtidcuenta.Size = new Size(209, 27);
            txtidcuenta.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 107);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 2;
            label8.Text = "numeroCuenta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 74);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 1;
            label9.Text = "ID Persona";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 38);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 0;
            label10.Text = "ID Cuenta";
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Location = new Point(434, 408);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.Size = new Size(704, 325);
            dgvCuenta.TabIndex = 14;
            dgvCuenta.CellDoubleClick += dgvCuenta_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 797);
            Controls.Add(dgvCuenta);
            Controls.Add(groupBox2);
            Controls.Add(dgvPersona);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btneliminar;
        private Button btnmodificar;
        private Button btnguardar;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private TextBox txtid;
        private Label label3;
        private Label label2;
        private DataGridView dgvPersona;
        private TextBox txtdireccion;
        private Label label5;
        private TextBox txtedad;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txttipo;
        private Label label6;
        private TextBox txtsaldo;
        private Label label7;
        private Button btneliminarcuenta;
        private Button btnmodificarcuenta;
        private Button btnguardarcuenta;
        private TextBox txtnumero;
        private TextBox txtidPersona;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtidcuenta;
        private DataGridView dgvCuenta;
    }
}
