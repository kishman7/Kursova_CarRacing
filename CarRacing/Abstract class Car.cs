using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRacing
{
    abstract class Car : ICar // абстрактний клас для створення моделів машин
    {
        public string ModelCar { get; set; }
        public int maxSpeed { get; set; } = 100;
        double speed = 1;
        public double SpeedCar { get=> speed;
            set
            {
                speed = value;
                if (value > maxSpeed)
                {
                    speed = maxSpeed;
                }
            }
        }

        double distanc = 0;
        public double Distanc { get=> distanc; 
            set
            {
                distanc = value;
                if (distanc >= 100)
                {
                    EventFinish(this);
                }
            }
            
                
                 }
        public Car(string modelCar)
        {
            ModelCar = modelCar;
        }
        public void Model()
        {
            Console.WriteLine($"Model Car: {ModelCar}");
        }
        Random random = new Random();
        public void Speed ()
        {
            SpeedCar += random.Next(1,10);
            Console.WriteLine($"Distanc Car{ModelCar}: {Distanc}");
            Distanc += SpeedCar / 10;
        }
        public void Driver()
        {
            Console.WriteLine($"Car {ModelCar} go!");
        }
        //public event Racing Start; // подія для старта
        public delegate void Finish(Car car);
        public event Finish EventFinish; // подія для фініша

    }
}
