using SideshowBob.Machine;
using SideshowBob.Machine.Enumerations;
using SideshowBob.Person.Clients;
using System;
using System.Globalization;
using System.Linq;

namespace SideshowBob
{
    class ConsoleApp
    {
        static void Main()
        {
            AuthorisedDealer.Instance.SettingUpAuthorisedDealer("KamorAuto", "Bul. Bulgaria", "Sofia", "Bulgaria","088723434");
            AuthorisedDealer.Instance.AddVehicle(new Limosine("black", 4, Model.AlfaRomeo156, DateTime.Now, 55000.0m, true, false, 240));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("white", 4, Model.AudiA8, DateTime.Parse("01/08/2010"), 40000.0m, true, false, 280));
            AuthorisedDealer.Instance.AddVehicle(new Limosine("black", 4, Model.CorvetteC6Coupe, DateTime.Parse("01/2/2010"), 60000.0m, true, false, 300));
            AuthorisedDealer.Instance.AddVehicle(new Motorcycle("blue", 2, Model.KawasakiNinja, DateTime.Parse("06/8/2010"), 35000.0m, true, false, 320));
            AuthorisedDealer.Instance.AddVehicle(new Van("yellow", 4, Model.DaciaLogan, DateTime.Parse("12/10/2007"), 20000.0m, true, false, 200));
            AuthorisedDealer.Instance.AddClient(new Company("Gosho OOD", 10001));
            foreach (var item in AuthorisedDealer.Instance.Vehicles)
            {
                Console.WriteLine(item);
            }

            foreach (var item in AuthorisedDealer.Instance.Clients)
            {
                Console.WriteLine(item);
            }
                        		 
            //LINQ queries
            //Console.WriteLine(AuthorisedDealer.Instance.SelectVehiclesByYear(2007));

            //Console.WriteLine(AuthorisedDealer.Instance.SelectVehiclesByPrice(40000));
            
        }
    }
}
