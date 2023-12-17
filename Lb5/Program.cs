using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb5
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public abstract void Move();
    }

    
    public class Human
    {
        public int Speed { get; set; }

        public void Move()
        {
            
        }
    }

    
    public class Car : Vehicle
    {
        
        public override void Move()
        {
            
        }
    }

    public class Bus : Vehicle
    {
        
        public override void Move()
        {
           
        }
    }

    public class Train : Vehicle
    {
      
        public override void Move()
        {
            
        }
    }

    
    public class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        
        public void CalculateOptimalRoute(Car car)
        {
            
        }

        public void CalculateOptimalRoute(Bus bus)
        {
           
        }

        public void CalculateOptimalRoute(Train train)
        {
            
        }
    }

    
    public class TransportNetwork
    {
        private List<Vehicle> vehicles;

        public TransportNetwork()
        {
            vehicles = new List<Vehicle>();
        }

        
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        
        public void ControlMovement()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 60;
            car.Capacity = 5;

            Bus bus = new Bus();
            bus.Speed = 40;
            bus.Capacity = 30;

            Train train = new Train();
            train.Speed = 100;
            train.Capacity = 200;

            TransportNetwork network = new TransportNetwork();
            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            network.ControlMovement();
        }
    }
}
