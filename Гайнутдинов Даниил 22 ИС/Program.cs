using System;

class Student
{
    public string FIO;
    public int Ocenka1;
    public int Ocenka2;

    public void Show()
    {
        Console.WriteLine("ФИО: " + FIO);
        Console.WriteLine("Оценка 1: " + Ocenka1);
        Console.WriteLine("Оценка 2: " + Ocenka2);
    }

    public float SredOcenka()
    {
        return (Ocenka1 + Ocenka2) / 2.0f;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.FIO = "Иванов";
        student.Ocenka1 = 3;
        student.Ocenka2 = 5;

        student.Show();

        float srednyaOcenka = student.SredOcenka();
        Console.WriteLine("Средняя оценка: " + srednyaOcenka);

        Console.ReadKey();
    }
}