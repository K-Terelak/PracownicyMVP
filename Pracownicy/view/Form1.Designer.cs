namespace Pracownicy.View
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_employee = new System.Windows.Forms.GroupBox();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_add_employee = new System.Windows.Forms.Button();
            this.rb_mandate_contract = new System.Windows.Forms.RadioButton();
            this.rb_time_contract = new System.Windows.Forms.RadioButton();
            this.rb_full_contract = new System.Windows.Forms.RadioButton();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.numUD_salary = new System.Windows.Forms.NumericUpDown();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_employees = new System.Windows.Forms.ListBox();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_surname = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.gb_employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_surname)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_employee
            // 
            this.gb_employee.Controls.Add(this.dtp_birthday);
            this.gb_employee.Controls.Add(this.btn_add_employee);
            this.gb_employee.Controls.Add(this.rb_mandate_contract);
            this.gb_employee.Controls.Add(this.rb_time_contract);
            this.gb_employee.Controls.Add(this.rb_full_contract);
            this.gb_employee.Controls.Add(this.cb_position);
            this.gb_employee.Controls.Add(this.numUD_salary);
            this.gb_employee.Controls.Add(this.tb_surname);
            this.gb_employee.Controls.Add(this.tb_name);
            this.gb_employee.Controls.Add(this.label6);
            this.gb_employee.Controls.Add(this.label5);
            this.gb_employee.Controls.Add(this.label4);
            this.gb_employee.Controls.Add(this.label3);
            this.gb_employee.Controls.Add(this.label2);
            this.gb_employee.Controls.Add(this.label1);
            this.gb_employee.Location = new System.Drawing.Point(10, 11);
            this.gb_employee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_employee.Name = "gb_employee";
            this.gb_employee.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_employee.Size = new System.Drawing.Size(302, 345);
            this.gb_employee.TabIndex = 0;
            this.gb_employee.TabStop = false;
            this.gb_employee.Text = "Dane pracownika";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birthday.Location = new System.Drawing.Point(99, 80);
            this.dtp_birthday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(162, 20);
            this.dtp_birthday.TabIndex = 16;
            // 
            // btn_add_employee
            // 
            this.btn_add_employee.Location = new System.Drawing.Point(5, 309);
            this.btn_add_employee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_employee.Name = "btn_add_employee";
            this.btn_add_employee.Size = new System.Drawing.Size(261, 19);
            this.btn_add_employee.TabIndex = 15;
            this.btn_add_employee.Text = "Dodaj";
            this.btn_add_employee.UseVisualStyleBackColor = true;
            this.btn_add_employee.Click += new System.EventHandler(this.btn_add_employee_Click);
            // 
            // rb_mandate_contract
            // 
            this.rb_mandate_contract.AutoSize = true;
            this.rb_mandate_contract.Location = new System.Drawing.Point(99, 234);
            this.rb_mandate_contract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_mandate_contract.Name = "rb_mandate_contract";
            this.rb_mandate_contract.Size = new System.Drawing.Size(101, 17);
            this.rb_mandate_contract.TabIndex = 14;
            this.rb_mandate_contract.TabStop = true;
            this.rb_mandate_contract.Text = "umowa zlecenie";
            this.rb_mandate_contract.UseVisualStyleBackColor = true;
            this.rb_mandate_contract.CheckedChanged += new System.EventHandler(this.rb__CheckedChanged);
            // 
            // rb_time_contract
            // 
            this.rb_time_contract.AutoSize = true;
            this.rb_time_contract.Location = new System.Drawing.Point(99, 206);
            this.rb_time_contract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_time_contract.Name = "rb_time_contract";
            this.rb_time_contract.Size = new System.Drawing.Size(147, 17);
            this.rb_time_contract.TabIndex = 13;
            this.rb_time_contract.TabStop = true;
            this.rb_time_contract.Text = "umowa na czas określony";
            this.rb_time_contract.UseVisualStyleBackColor = true;
            this.rb_time_contract.CheckedChanged += new System.EventHandler(this.rb__CheckedChanged);
            // 
            // rb_full_contract
            // 
            this.rb_full_contract.AutoSize = true;
            this.rb_full_contract.Location = new System.Drawing.Point(99, 173);
            this.rb_full_contract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_full_contract.Name = "rb_full_contract";
            this.rb_full_contract.Size = new System.Drawing.Size(161, 17);
            this.rb_full_contract.TabIndex = 12;
            this.rb_full_contract.TabStop = true;
            this.rb_full_contract.Text = "umowa na czas nieokreślony";
            this.rb_full_contract.UseVisualStyleBackColor = true;
            this.rb_full_contract.CheckedChanged += new System.EventHandler(this.rb__CheckedChanged);
            // 
            // cb_position
            // 
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy programista",
            "Starszy programista"});
            this.cb_position.Location = new System.Drawing.Point(99, 142);
            this.cb_position.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(162, 21);
            this.cb_position.TabIndex = 11;
            // 
            // numUD_salary
            // 
            this.numUD_salary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUD_salary.Location = new System.Drawing.Point(99, 114);
            this.numUD_salary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numUD_salary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUD_salary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_salary.Name = "numUD_salary";
            this.numUD_salary.Size = new System.Drawing.Size(63, 20);
            this.numUD_salary.TabIndex = 10;
            this.numUD_salary.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(99, 50);
            this.tb_surname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(162, 20);
            this.tb_surname.TabIndex = 8;
            this.tb_surname.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(99, 20);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(162, 20);
            this.tb_name.TabIndex = 7;
            this.tb_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rodzaj umowy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stanowisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pensja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data urodzenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię:";
            // 
            // lb_employees
            // 
            this.lb_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_employees.CausesValidation = false;
            this.lb_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_employees.FormattingEnabled = true;
            this.lb_employees.ItemHeight = 31;
            this.lb_employees.Location = new System.Drawing.Point(316, 15);
            this.lb_employees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_employees.Name = "lb_employees";
            this.lb_employees.Size = new System.Drawing.Size(678, 376);
            this.lb_employees.TabIndex = 1;
            this.lb_employees.SelectedIndexChanged += new System.EventHandler(this.lb_employees_SelectedIndexChanged);
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_surname
            // 
            this.errorProvider_surname.ContainerControl = this;
            // 
            // btn_save
            // 
            this.btn_save.CausesValidation = false;
            this.btn_save.Location = new System.Drawing.Point(15, 362);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 19);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Zapisz";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.CausesValidation = false;
            this.btn_load.Location = new System.Drawing.Point(152, 361);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(124, 19);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Wczytaj";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1001, 448);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lb_employees);
            this.Controls.Add(this.gb_employee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Pracownicy";
            this.gb_employee.ResumeLayout(false);
            this.gb_employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_surname)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_employee;
        private System.Windows.Forms.NumericUpDown numUD_salary;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.RadioButton rb_mandate_contract;
        private System.Windows.Forms.RadioButton rb_time_contract;
        private System.Windows.Forms.RadioButton rb_full_contract;
        private System.Windows.Forms.Button btn_add_employee;
        private System.Windows.Forms.ListBox lb_employees;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.ErrorProvider errorProvider_surname;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
    }
}

