using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pracownicy.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorProvider_name.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider_surname.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            cb_position.SelectedIndex = 1;

            if (isFormValid())
            {
                btn_add_employee.Enabled = true;
            }
            else
            {
                btn_add_employee.Enabled = false;
            }
        }

        public event Action<string, string, DateTime, decimal, Position, TypeOfContract> AddEmployee;
        public event Action SaveEmployees;
        public event Action ReadEmployees;
        public event Action<int> SelectedEmployee;
        public event Action<String> ShowErrorProvider;
        public event Action<String> HideErrorProvider;

        public List<Employee> DisplayList
        {
            set
            {
                lb_employees.DataSource = value.ConvertAll<String>(emp => emp.ToString());
            }
        }

        public Employee DisplayEmployee
        {
            set
            {
                if (value != null)
                {

                    tb_name.Text = value.Name;
                    tb_surname.Text = value.Surname;
                    dtp_birthday.Value = value.Birthdate;
                    numUD_salary.Value = value.Salary;

                    int indeks = 0;
                    if (value.Position == Position.Designer)
                        indeks = 1;
                    if (value.Position == Position.Engineer)
                        indeks = 2;
                    if (value.Position == Position.JuniorProgrammer)
                        indeks = 3;
                    if (value.Position == Position.SeniorProgrammer)
                        indeks = 4;
                    if (value.Position == Position.Tester)
                        indeks = 0;
                    cb_position.SelectedIndex = indeks;

                    if (value.Contract == TypeOfContract.FullContract)
                        rb_full_contract.Checked = true;
                    if (value.Contract == TypeOfContract.MandateContract)
                        rb_mandate_contract.Checked = true;
                    if (value.Contract == TypeOfContract.TimeContract)
                        rb_time_contract.Checked = true;
                }
            }
        }

        private bool isFormValid()
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text) || string.IsNullOrWhiteSpace(tb_surname.Text)
                || (rb_full_contract.Checked == false && rb_mandate_contract.Checked == false &&
                rb_time_contract.Checked == false))
                return false;
            else
                return true;
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Position position = Position.Tester;
                if ((string)cb_position.SelectedItem == "Tester")
                    position = Position.Tester;
                if ((string)cb_position.SelectedItem == "Projektant")
                    position = Position.Designer;
                if ((string)cb_position.SelectedItem == "Młodszy programista")
                    position = Position.JuniorProgrammer;
                if ((string)cb_position.SelectedItem == "Inżynier")
                    position = Position.Engineer;
                if ((string)cb_position.SelectedItem == "Starszy programista")
                    position = Position.SeniorProgrammer;

                TypeOfContract contract = TypeOfContract.FullContract;
                if (rb_full_contract.Checked)
                    contract = TypeOfContract.FullContract;
                if (rb_time_contract.Checked)
                    contract = TypeOfContract.TimeContract;
                if (rb_mandate_contract.Checked)
                    contract = TypeOfContract.MandateContract;

                AddEmployee?.Invoke(tb_name.Text, tb_surname.Text, dtp_birthday.Value, numUD_salary.Value, position, contract);
            }
        }

        public String DisplayError
        {
            set
            {
                if (value == "tb_name")
                {
                    //e.Cancel = true;
                    errorProvider_name.SetError(tb_name, "Należy podać imię.");
                }
                else if (value == "tb_surname")
                {
                  //  e.Cancel = true;
                    errorProvider_surname.SetError(tb_surname, "Należy podać nazwisko.");
                }
            }
        }

        public String HideError
        {
            set
            {
                if (value == "tb_name")
                {
                    //e.Cancel = false;
                    errorProvider_name.SetError(tb_name, null);
                }
                else if (value == "tb_surname")
                {
                    //e.Cancel = false;
                    errorProvider_surname.SetError(tb_surname, null);
                }
            }
        }

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            if (isFormValid())
            {
                btn_add_employee.Enabled = true;
            }
            else
            {
                btn_add_employee.Enabled = false;
            }

            TextBox tb = sender as TextBox;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                ShowErrorProvider?.Invoke(tb.Name);
            }
            else
            {
                HideErrorProvider?.Invoke(tb.Name);
            }
        }

        private void rb__CheckedChanged(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                btn_add_employee.Enabled = true;
            }
            else
            {
                btn_add_employee.Enabled = false;
            }
        }

        private void lb_employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            var index = lb.SelectedIndex;
            SelectedEmployee?.Invoke(index);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveEmployees?.Invoke();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            ReadEmployees?.Invoke();
        }
    }
}
