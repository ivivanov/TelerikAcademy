using SideshowBob;
using SideshowBob.Machine;
using SideshowBob.Machine.Enumerations;
using SideshowBobUI.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace SideshowBobUI.ViewModel
{
    public class VehiclesViewModel : Vehicle
    {
        #region Fields

        private Vehicle selectedVehicle;
       
        #endregion

        #region Constructors

        public VehiclesViewModel()
        {
            RemoveCommand = new DelegateCommand(OnExecuteRemoveCommand, CanExecuteRemoveCommand);
            AddCommand = new DelegateCommand(OnExecuteRemoveCommand, CanExecuteRemoveCommand);
            //Hardcode

            AuthorisedDealer.Instance.AddVehicle(new Motorcycle("Black", 2, Model.YamahaR1, DateTime.Now, 12000m, true, false, 220));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("Black", 4, Model.AudiA8, DateTime.Now, 12000m, true, false, 220));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("Yellow", 4, Model.BentleyAzure, DateTime.Now, 12300m, true, false, 220));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("White", 4, Model.BMW5Series, DateTime.Now, 71203m, true, false, 220));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("Green", 4, Model.CitroenJumper, DateTime.Now, 60500m, true, false, 220));
        }
        #endregion

        #region Properties

        public IEnumerable<Category> Categories
        {
            get
            {
                return AuthorisedDealer.Instance.CategoryValues;
            }
        }

        public IEnumerable<Model> Models
        {
            get
            {
                return AuthorisedDealer.Instance.ModelValues;
            }
        }

        public ObservableCollection<Vehicle> ListOfVehicles
        {
            get
            {
                return AuthorisedDealer.Instance.Vehicles;
            }
            set
            {
                if (AuthorisedDealer.Instance.Vehicles == value) return;

                AuthorisedDealer.Instance.Vehicles = value;
            }
        }

        public Vehicle SelectedVehicle
        {
            get
            {
                return selectedVehicle;
            }
            set
            {
                if (this.selectedVehicle == value)
                {
                    return;
                }

                this.selectedVehicle = value;

                if (value != null)
                {
                    //Type type = typeof(Vehicle);
                    //FieldInfo field = type.GetField("Name");
                    //object temp = field.GetValue(null);
                    //this.Category = (Category) Enum.Parse( typeof(Category),value.GetType().Name);
                    this.Color = value.Color;
                    this.Wheels = value.Wheels;
                    this.Model = value.Model;
                    this.Year = value.Year;
                    this.Price = decimal.Parse(value.Price.ToString());
                    this.Speed = value.Speed;
                    RemoveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        #endregion

        #region Add Command

        public DelegateCommand AddCommand
        {
            get;
            set;
        }

        public void OnExecuteAddCommand(object e)
        {
            ListOfVehicles.Add(SelectedVehicle);
        }

        private bool CanExecuteAddCommand(object e)
        {
            if (SelectedVehicle != null) return true;

            return false;

        }
        //private void AddButtonClick(object sender, RoutedEventArgs e)
        //{
        //    switch (CategoryTB.Text.ToString())
        //    {
        //        case ("Limosine"):
        //            string color = ColorTB.Text;
        //            int wheels = int.Parse(WheelsTB.Text);
        //            Model model = (Model)Enum.Parse(typeof(Model), ModelTB.SelectedValue.ToString());
        //            DateTime date = DateP.SelectedDate.Value;
        //            decimal price = decimal.Parse(PriceTB.Text);
        //            double speed = double.Parse(SpeedTB.Text);
        //            AuthorisedDealer.Instance.Vehicles.Add(new Limosine(color, wheels, model, date, price, true, false, speed));
        //            break;
        //        case ("Motorcycle"):
        //            break;
        //        case ("SUV"):
        //            break;
        //        case ("Truck"):
        //            break;
        //        case ("Van"):
        //            break;
        //    }
        //}
        #endregion

        #region Remove Command

        public DelegateCommand RemoveCommand
        {
            get;
            set;
        }

        public void OnExecuteRemoveCommand(object e)
        {
            ListOfVehicles.Remove(SelectedVehicle);
        }

        private bool CanExecuteRemoveCommand(object e)
        {
            if (SelectedVehicle != null) return true;

            return false;

        }

        #endregion

        #region Methods

        public override void AbleToTransport()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
