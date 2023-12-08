using System;

class Car
{
    private string carName;
    private int maxSpeed;

    public Car(string name, int speed)
    {
        carName = name;
        maxSpeed = speed;
    }

    public string GetCarInfo()
    {
        return $"Автомобиль: {carName}, Максимальная скорость: {maxSpeed} км/ч";
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("BMW", 250);
        Car car2 = new Car("Audi", 240);
        Car car3 = new Car("Mercedes", 260);
        Car car4 = new Car("Toyota", 220);
        
        // Выводим информацию о каждом автомобиле перед гонками
        Console.WriteLine(car1.GetCarInfo());
        Console.WriteLine(car2.GetCarInfo());
        Console.WriteLine(car3.GetCarInfo());
        Console.WriteLine(car4.GetCarInfo());

        // Имитация гонок с рандомным выбором победителя
        Random random = new Random();
        Car[] cars = { car1, car2, car3, car4 };
        Car winner = cars[random.Next(cars.Length)]; // случайный выбор победителя

        Console.WriteLine("\nРезультаты гонок:");

        // Выводим информацию о победителе
        Console.WriteLine($"Победитель гонок: {winner.GetCarInfo()}");
    }
}
