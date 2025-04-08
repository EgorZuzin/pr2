//using System;

namespace CarApp
{
    class Car
    {
        // Закрытые поля
        private string brand;
        private string licensePlate;
        private int mileage;

        // Свойства
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }

        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        // Конструктор
        public Car(string brand, string licensePlate, int mileage)
        {
            this.brand = brand;
            this.licensePlate = licensePlate;
            this.mileage = mileage;
        }

        // Метод для отображения информации об автомобиле
        public void Show()
        {
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Гос. номер: {LicensePlate}");
            Console.WriteLine($"Пробег: {Mileage} км");
        }

        // Метод для расчета среднего годового пробега
        public double CalculateAverageAnnualMileage(int age)
        {
            return (double)Mileage / age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Car
            Car myCar = new Car("Жигули", "Т144ТО", 10350);

            // Вывод значений свойств объекта
            myCar.Show();

            // Рассчет среднего годового пробега
            int age = 5; // Возраст автомобиля
            double averageAnnualMileage = myCar.CalculateAverageAnnualMileage(age);
            Console.WriteLine($"Средний годовой пробег: {averageAnnualMileage} км/год");

            // Ожидание нажатия клавиши перед закрытием консоли
            Console.ReadKey();
        }
    }
}
