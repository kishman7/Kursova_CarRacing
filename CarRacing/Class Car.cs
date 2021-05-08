using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRacing
{
    class SportCar : Car
    {
        public SportCar(string sportCar) : base(sportCar) 
        {
            maxSpeed = 45;
        }

    }
    class LightCar : Car
    {
        public LightCar(string lightCar) : base(lightCar) 
        {
            maxSpeed = 45;
        }
    }
    class Truck : Car
    {
        public Truck(string truckCar) : base(truckCar)
        {
            maxSpeed = 40;
        }
    }
    class Bus : Car
    {
        public Bus(string busCar) : base(busCar)
        {
            maxSpeed = 25;
        }
    }
    class GameRacing
    {
        List<Car> cars = new List<Car> {
        new SportCar("SportCar"), new LightCar("LightCar"), new Truck("Truck"), new Bus("Bus")
        };

        public delegate void Start();
        public Start start_delegate;


        public void Competition() // підписуємо обєкти до делегата Start та до події EventFinish
        {
            start_delegate += cars[0].Driver;
            start_delegate += cars[1].Driver;
            start_delegate += cars[2].Driver;
            start_delegate += cars[3].Driver;

            cars[0].EventFinish += GameRacing_EventFinish;
            cars[1].EventFinish += GameRacing_EventFinish;
            cars[2].EventFinish += GameRacing_EventFinish;
            cars[3].EventFinish += GameRacing_EventFinish;
        }

        private void GameRacing_EventFinish(Car car)
        {
            finish_game = false;
            Console.WriteLine($"Winner car: {car.ModelCar}");
        }
        bool finish_game = true;
        public void Gonka ()
        {
            while (finish_game)
            {
                foreach (Car item in cars)
                {
                    item.Speed();
                }
                Thread.Sleep(200);


            }
            
        }

    }
}
