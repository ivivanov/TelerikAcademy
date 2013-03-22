using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SideshowBob.Person.Clients;
using SideshowBob.Person.Employees;
using SideshowBob.Machine;
using SideshowBob.Machine.Enumerations;

namespace SideshowBob
{
    public struct Address
    {
        public string street;
        public string city;
        public string state;
    }
    //Singleton 
    public class AuthorisedDealer : INotifyPropertyChanged
    {
        #region Fields
        
        private static AuthorisedDealer instance;
        
        private string name;
        private string street;
        private string city;
        private string state;
        public Address address;
        private string phone;
        private ObservableCollection<Vehicle> vehicles=new ObservableCollection<Vehicle>();
        private ObservableCollection<Client> clients=  new ObservableCollection<Client>();
        private ObservableCollection<Employee> employees =new ObservableCollection<Employee>();
        
        #endregion
        
        #region Constructors
        
        private AuthorisedDealer()
        {
        }

        #endregion
        
        #region Properties

        public static AuthorisedDealer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthorisedDealer();
                }
                return instance;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                OnPropertyChanged("Name");
            }
        }
            
        public string Street
        {
            get
            {
                return this.address.street;
            }
            set
            {
                this.address.street = value;
                OnPropertyChanged("Street");
            }
        }
            
        public string City
        {
            get
            {
                return this.address.city;
            }
            set
            {
                this.address.city = value;
                OnPropertyChanged("City");
            }
        }
            
        public string State
        {
            get
            {
                return this.address.state;
            }
            set
            {
                this.address.city = value;
                OnPropertyChanged("State");
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public ObservableCollection<Vehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
            set
            {
                this.vehicles = value;
            }
        }
            
        public ObservableCollection<Client> Clients
        {
            get
            {
                return this.clients;
            }
            set
            {
                this.clients = value;
            }

        }
            
        public ObservableCollection<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }

        
            
        #endregion
        
        #region Methods
            
        public void SettingUpAuthorisedDealer(string name, string street, string city, string state, string phone)
        {
            this.name = name;
            this.street = street;
            this.city = city;
            this.state = state;
            this.phone = phone;
            this.vehicles =     new ObservableCollection<Vehicle>();
            this.clients =      new ObservableCollection<Client>();
            this.employees =    new ObservableCollection<Employee>();
        }
            
        public void AddVehicle(Vehicle newVehicle)
        {
            try
            {
                this.vehicles.Add(newVehicle);
            }
            catch
            {
                throw new Exception("Trying to add invalid vehicle!");
            }
        }
            
        public void AddEmployee(Employee newEmployee)
        {
            try
            {
                this.employees.Add(newEmployee);
            }
            catch
            {
                throw new Exception("Trying to add invalid employee!");
            }
        }
            
        public void AddClient(Client newClinet)
        {
            try
            {
                this.clients.Add(newClinet);
            }
            catch
            {
                throw new Exception("Trying to add invalid client!");
            }
        }

        public override string ToString()
        {            
            return String.Format("Name: {0}\nAddress: {1}, {2}, {3}\nPhone: {4}\nVehicles in stock: {5}\nNumber of clients: {6}\nNumber of employees: {7}",
            this.name, this.street, this.city, this.state, this.phone, 5, this.clients.Count, 6);            
        }

        public IEnumerable<Model> ModelValues
        {
            get
            {
                return Enum.GetValues(typeof(Model)).Cast<Model>();
            }
        }
        public IEnumerable<Category> CategoryValues
        {
            get
            {
                return Enum.GetValues(typeof(Category)).Cast<Category>();
            }
        }

        #endregion

        #region Queries

        public ObservableCollection<Vehicle> SelectVehiclesAfterYear(int year)          //selects vehicles produced after year x
        {
            ObservableCollection<Vehicle> collection = new ObservableCollection<Vehicle>();
            var vehicleByYear =
                from vehicle in Vehicles
                where vehicle.Year.Year >= year
                select vehicle;

            foreach (var item in vehicleByYear)
            {
                collection.Add(item);
            }
            return collection;
        }

        public ObservableCollection<Vehicle> SelectVehiclesBelowPrice(decimal price)          
        {
            ObservableCollection<Vehicle> collection = new ObservableCollection<Vehicle>();     //selects vehicles up to a price x
            var vehicleByPrice =
                from vehicle in Vehicles
                where vehicle.Price <= price
                select vehicle;
            
            foreach (var item in vehicleByPrice)
            {
                collection.Add(item);
            }

            return collection;
        }       
              

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
            
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
