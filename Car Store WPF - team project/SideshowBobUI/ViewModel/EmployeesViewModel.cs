using SideshowBob;
using SideshowBob.Person.Employees;
using SideshowBobUI.Common;
using System.Collections.ObjectModel;
using SideshowBob.Person.Enumerations;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SideshowBobUI.ViewModel
{
    public class EmployeesViewModel : Employee
    {
        private Employee selectedEmployee;

        public EmployeesViewModel()
        {
            RemoveCommand = new DelegateCommand(OnExecuteRemoveCommand, CanExecuteRemoveCommand);
            ChangeStatusCommand = new DelegateCommand(OnExecuteChangeStatusCommand, CanExecuteChangeStatusCommand);
            AddCommand = new DelegateCommand(OnExecuteAddCommand, CanExecuteAddCommand);
            EditCommand = new DelegateCommand(OnExecuteEditCommand, CanExecuteEditCommand);
            //Hardcode

            AuthorisedDealer.Instance.AddEmployee(new CarDealer("Jeliazka", "Zdravkova", Gender.Female, 1200, 34));
            AuthorisedDealer.Instance.AddEmployee(new CarDealer("Stefka", "Savova", Gender.Female, 3000, 19));
            AuthorisedDealer.Instance.AddEmployee(new Mechanic("Sasho", "Peshev", Gender.Male, 2150, 31));
            AuthorisedDealer.Instance.AddEmployee(new Mechanic("Pesho", "Peshev", Gender.Male, 5000, 45));
            AuthorisedDealer.Instance.AddEmployee(new Mechanic("Niki", "Nikolov", Gender.Male, 900, 55));
            AuthorisedDealer.Instance.AddEmployee(new CarDealer("Kiril", "Stanoev", Gender.Male, 899, 33));
        }

        public Employee SelectedEmployee
        {
            get
            {
                return this.selectedEmployee;
            }
            set
            {
                if (this.selectedEmployee == value)
                {
                    return;
                }

                this.selectedEmployee = value;

                if (value != null)
                {
                    this.FirstName= value.FirstName;
                    this.LastName = value.LastName;
                    this.Gender = value.Gender;
                    this.Age = value.Age;
                    this.IsBusy = value.IsBusy;

                    EditCommand.RaiseCanExecuteChanged();
                    RemoveCommand.RaiseCanExecuteChanged();
                    ChangeStatusCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public IEnumerable<Gender> Genders
        {
            get
            {
                return Enum.GetValues(typeof(Gender)).Cast<Gender>();
            }
        }

        public ObservableCollection<Employee> ListOfEmployees
        {
            get
            {
                return AuthorisedDealer.Instance.Employees;
            }
            set
            {
                if (AuthorisedDealer.Instance.Employees == value)
                    return;

                AuthorisedDealer.Instance.Employees = value;
            }
        }


        #region Edit Command

        public DelegateCommand EditCommand { get; set; }

        public void OnExecuteEditCommand(object e)
        {
            this.selectedEmployee.FirstName = FirstName;
            this.selectedEmployee.LastName = LastName;
            this.selectedEmployee.Gender = Gender;
            this.selectedEmployee.Age = Age;
            this.selectedEmployee.Salary = Salary;
        }

        private bool CanExecuteEditCommand(object e)
        {
            if (selectedEmployee != null)
                return true;

            return false;
        }

        #endregion

        #region Add Command

        public DelegateCommand AddCommand { get; set; }

        public void OnExecuteAddCommand(object e)
        {
            ListOfEmployees.Add(selectedEmployee);
        }

        private bool CanExecuteAddCommand(object e)
        {
            if (selectedEmployee != null)
                return true;

            return false;
        }

        #endregion

        #region Remove Command

        public DelegateCommand RemoveCommand { get; set; }

        public void OnExecuteRemoveCommand(object e)
        {
            ListOfEmployees.Remove(selectedEmployee);
        }

        private bool CanExecuteRemoveCommand(object e)
        {
            if (selectedEmployee != null)
                return true;

            return false;
        }

        #endregion

        #region ChangeStatusCommand Command

        public DelegateCommand ChangeStatusCommand { get; set; }

        public void OnExecuteChangeStatusCommand(object e)
        {
            if (selectedEmployee.IsBusy == true)
            {
                this.selectedEmployee.IsBusy = false;
            }
            else
            {
                this.selectedEmployee.IsBusy = true;
            }
        }

        private bool CanExecuteChangeStatusCommand(object e)
        {
            if (selectedEmployee != null)
                return true;

            return false;
        }
        
        #endregion
    }
}
