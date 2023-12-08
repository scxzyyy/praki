using System;

class Phone
{
    public string Model { get; set; }
    public string Number { get; set; }

    public Phone(string model, string number)
    {
        Model = model;
        Number = number;
    }

    public void Call(string number)
    {
        Console.WriteLine($"Набрать {number} с {Model}");
    }
}

class Smartphone : Phone
{
    public double CameraResolution { get; set; }

    public Smartphone(string model, string number, double cameraResolution)
        : base(model, number)
    {
        CameraResolution = cameraResolution;
    }

    public void TakePhoto()
    {
        Console.WriteLine($"Делать фото камерой от {Model}");
    }
}

class TransportVehicle
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public TransportVehicle(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }
}

class PolitekhMachine : TransportVehicle
{
    public PolitekhMachine(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    public void PlayLoudBadMusic()
    {
        Console.WriteLine("Громко слушать ужасную музыку");
    }
}

class Airplane : TransportVehicle
{
    public Airplane(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    public void DustField()
    {
        Console.WriteLine("Опылить поле");
    }
}

class ConcreteMixer : TransportVehicle
{
    public ConcreteMixer(string name, int maxSpeed) : base(name, maxSpeed)
    {
    }

    public void MixConcrete()
    {
        Console.WriteLine("Мешать бетон");
    }
}

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Human(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

class Employee : Human
{
    public string Position { get; set; }

    public Employee(string name, int age, string gender, string position)
        : base(name, age, gender)
    {
        Position = position;
    }
}

class Program
{
    static void Main()
    {
        Phone myHomePhone = new Phone("Samsung A51", "89015673423");
        myHomePhone.Call("85672537414");

        Smartphone myWorkPhone = new Smartphone("ZPhone", "89152343245", 80.5);
        myWorkPhone.Call("112");
        myWorkPhone.TakePhoto();

        // Пример использования классов TransportVehicle
        PolitekhMachine car = new PolitekhMachine("LoudCar", 120);
        car.PlayLoudBadMusic();

        Airplane airplane = new Airplane("Jet", 800);
        airplane.DustField();

        ConcreteMixer mixer = new ConcreteMixer("CementKing", 60);
        mixer.MixConcrete();

        
        Human person = new Human("Алина", 10, "Женский"); // Пример использования классов Human и Employee
        Console.WriteLine($"{person.Name} , {person.Gender} пол, возраст:{person.Age} лет.");

        Employee employee = new Employee("Андрей", 50, "Мужской", "Менеджер");
        Console.WriteLine($"{employee.Name} , {employee.Gender} пол, возраст: {employee.Age} лет, должность: {employee.Position}.");

        // Расчет среднего арифметического чисел
        int[] numbers = { 10, 20, 30, 40, 50 };
        double sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = sum / numbers.Length;

        Console.WriteLine("Среднее арифметическое чисел в массиве: " + average);
    }
}