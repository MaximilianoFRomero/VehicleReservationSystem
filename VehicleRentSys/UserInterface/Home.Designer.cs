namespace VehicleRentSys.UserInterface
{
    partial class Home
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
            LblNewUser = new Label();
            LblNewName = new Label();
            txtName = new TextBox();
            lblNewLastName = new Label();
            txtLastName = new TextBox();
            btnCreateUser = new Button();
            label1 = new Label();
            cmbUsers = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbVehicles = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            txtCost = new TextBox();
            dataGridView1 = new DataGridView();
            Reservations = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            RentCost = new DataGridViewTextBoxColumn();
            btnReservation = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblNewUser
            // 
            LblNewUser.AutoSize = true;
            LblNewUser.Location = new Point(12, 9);
            LblNewUser.Name = "LblNewUser";
            LblNewUser.Size = new Size(84, 15);
            LblNewUser.TabIndex = 0;
            LblNewUser.Text = "Nuevo usuario";
            // 
            // LblNewName
            // 
            LblNewName.AutoSize = true;
            LblNewName.Location = new Point(12, 38);
            LblNewName.Name = "LblNewName";
            LblNewName.Size = new Size(54, 15);
            LblNewName.TabIndex = 1;
            LblNewName.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 2;
            // 
            // lblNewLastName
            // 
            lblNewLastName.AutoSize = true;
            lblNewLastName.Location = new Point(335, 39);
            lblNewLastName.Name = "lblNewLastName";
            lblNewLastName.Size = new Size(54, 15);
            lblNewLastName.TabIndex = 3;
            lblNewLastName.Text = "Apellido:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(415, 35);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(152, 23);
            txtLastName.TabIndex = 4;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(623, 35);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(147, 23);
            btnCreateUser.TabIndex = 5;
            btnCreateUser.Text = "AÑADIR USUARIO";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Nueva Reserva";
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(104, 133);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(152, 23);
            cmbUsers.TabIndex = 7;
            cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 136);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Vehiculo:";
            // 
            // cmbVehicles
            // 
            cmbVehicles.FormattingEnabled = true;
            cmbVehicles.Location = new Point(415, 133);
            cmbVehicles.Name = "cmbVehicles";
            cmbVehicles.Size = new Size(152, 23);
            cmbVehicles.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha Inicio:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(152, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 183);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 13;
            label5.Text = "Fecha Fin:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(415, 177);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(152, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(599, 185);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 15;
            label6.Text = "Costo:";
            // 
            // txtCost
            // 
            txtCost.Enabled = false;
            txtCost.Location = new Point(646, 180);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(124, 23);
            txtCost.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Reservations, User, Brand, StartDate, EndDate, RentCost });
            dataGridView1.Location = new Point(87, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 183);
            dataGridView1.TabIndex = 17;
            // 
            // Reservations
            // 
            Reservations.HeaderText = "Reserva";
            Reservations.Name = "Reservations";
            // 
            // User
            // 
            User.HeaderText = "Usuario";
            User.Name = "User";
            // 
            // Brand
            // 
            Brand.HeaderText = "Marca";
            Brand.Name = "Brand";
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Inicio";
            StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            EndDate.HeaderText = "Fin";
            EndDate.Name = "EndDate";
            // 
            // RentCost
            // 
            RentCost.HeaderText = "Costo";
            RentCost.Name = "RentCost";
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(623, 226);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(147, 23);
            btnReservation.TabIndex = 18;
            btnReservation.Text = "AÑADIR RESERVA";
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReservation);
            Controls.Add(dataGridView1);
            Controls.Add(txtCost);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(cmbVehicles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbUsers);
            Controls.Add(label1);
            Controls.Add(btnCreateUser);
            Controls.Add(txtLastName);
            Controls.Add(lblNewLastName);
            Controls.Add(txtName);
            Controls.Add(LblNewName);
            Controls.Add(LblNewUser);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNewUser;
        private Label LblNewName;
        private TextBox txtName;
        private Label lblNewLastName;
        private TextBox txtLastName;
        private Button btnCreateUser;
        private Label label1;
        private ComboBox cmbUsers;
        private Label label2;
        private Label label3;
        private ComboBox cmbVehicles;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private TextBox txtCost;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Reservations;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn RentCost;
        private Button btnReservation;
    }
}