﻿using System;

namespace Classes
{
    // Клас Address
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public void ShowAddress()
        {
            Console.WriteLine($"Address: {Index}, {Country}, {City}, {Street}, {House}, {Apartment}");
        }
    }

    // Клас Converter
    class Converter
    {
        public double UsdToUah { get; set; }
        public double EurToUah { get; set; }
        public double RubToUah { get; set; }

        public Converter(double usdToUah, double eurToUah, double rubToUah)
        {
            UsdToUah = usdToUah;
            EurToUah = eurToUah;
            RubToUah = rubToUah;
        }

        public double ConvertFromUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / UsdToUah;
                case "eur":
                    return amount / EurToUah;
                case "rub":
                    return amount / RubToUah;
                default:
                    throw new ArgumentException("Unknown currency");
            }
        }

        public double ConvertToUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * UsdToUah;
                case "eur":
                    return amount * EurToUah;
                case "rub":
                    return amount * RubToUah;
                default:
                    throw new ArgumentException("Unknown currency");
            }
        }
    }

    // Клас Employee
    class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string lastName, string firstName, string position, int experience)
        {
            LastName = lastName;
            FirstName = firstName;
            Position = position;
            Experience = experience;
        }

        public double CalculateSalary()
        {
            double baseSalary = 5000;
            double experienceBonus = Experience * 500;
            return baseSalary + experienceBonus;
        }

        public void ShowEmployeeInfo()
        {
            double salary = CalculateSalary();
            Console.WriteLine($"Employee: {FirstName} {LastName}, Position: {Position}, Salary: {salary} UAH");
        }
    }

    // Клас User
    class User
    {
        public string Login { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }
        public DateTime RegistrationDate { get; }

        public User(string login, string name, string surname, string email)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Email = email;
            RegistrationDate = DateTime.Now;
        }

        public void ShowUserInfo()
        {
            Console.WriteLine($"User: {Login}, Name: {Name} {Surname}, Email: {Email}, Registration Date: {RegistrationDate}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Виконання завдання з класом Address
            Address myAddress = new Address()
            {
                Index = "01001",
                Country = "Ukraine",
                City = "Kyiv",
                Street = "Khreshchatyk",
                House = "1",
                Apartment = "10"
            };
            myAddress.ShowAddress();
            Console.WriteLine();

            // Виконання завдання з класом Converter
            Converter myConverter = new Converter(36.6, 39.5, 0.5);
            double uahToUsd = myConverter.ConvertFromUah(1000, "usd");
            double usdToUah = myConverter.ConvertToUah(100, "usd");
            Console.WriteLine($"1000 UAH to USD: {uahToUsd}");
            Console.WriteLine($"100 USD to UAH: {usdToUah}");
            Console.WriteLine();

            // Виконання завдання з класом Employee
            Employee employee = new Employee("Ivanov", "Ivan", "Manager", 5);
            employee.ShowEmployeeInfo();
            Console.WriteLine();

            // Виконання завдання з класом User
            User user = new User("jdoe", "John", "Doe", "jdoe@example.com");
            user.ShowUserInfo();
        }
    }
}
