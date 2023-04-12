using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy.Presenter
{
    class MainPresenter
    {
        private View.Form1 _view;
        private Model.MainModel _model;

        public MainPresenter(View.Form1 view, Model.MainModel model)
        {
            _view = view;
            _model = model;


            _view.AddEmployee += _view_AddEmployee;
            _view.SaveEmployees += _view_SaveEmployees;
            _view.ReadEmployees += _view_ReadEmployees;
            _view.SelectedEmployee += _view_SelectedEmployee;
            _view.ShowErrorProvider += _view_ShowErrorProvider;
            _view.HideErrorProvider += _view_HideErrorProvider;
            UpdateView();
        }

        private void _view_ShowErrorProvider(String tbName) => _view.DisplayError = tbName;


        private void _view_HideErrorProvider(String tbName) => _view.HideError = tbName;


        private void _view_AddEmployee(string name, string surname, DateTime birthdate, decimal salary, Position position, TypeOfContract contract)
        {
            Employee e = new Employee(name, surname, birthdate, salary, position, contract);
            _model.EmployeeTmp.AddEmployee(e);
            UpdateView();
        }

        private void _view_SelectedEmployee(int index) => UpdateEmployee(index);


        private void _view_SaveEmployees() => _model.EmployeeTmp.SaveToFile();

        private void _view_ReadEmployees()
        {
            _model.EmployeeTmp.ReadFromFile();
            UpdateView();
        }

        private void UpdateView() => _view.DisplayList = _model.EmployeeTmp.employeeList;
        private void UpdateEmployee(int index) => _view.DisplayEmployee = _model.EmployeeTmp.employeeList[index];

    }
}
