using System;
using System.Collections.Generic;

class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string State { get; set; }
    public int Pincode { get; set; }
    public int DepartmentFee { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}

class Program
{
    private static Dictionary<int, int> departmentFees = new Dictionary<int, int>
    {
        { 1, 400 },
        { 2, 800 },
        { 3, 1200 },
        { 4, 5000 },
        { 5, 6000 }
    };

    private static List<Patient> patients = new List<Patient>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to ABC Hospital!");

        for (int i = 0; i < 10; i++)
        {
            AddPatient();
        }

        SearchPatient();
    }

    static void AddPatient()
    {
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter state: ");
        string state = Console.ReadLine();

        Console.Write("Enter pincode: ");
        int pincode = int.Parse(Console.ReadLine());

        Console.WriteLine("Select the department for treatment:");
        foreach (var fee in departmentFees)
        {
            Console.WriteLine($"{fee.Key}. {GetDepartmentName(fee.Key)}  : {fee.Value}");
        }

        Console.Write("Enter department choice: ");
        int departmentChoice = int.Parse(Console.ReadLine());

        int departmentFee = departmentFees[departmentChoice];

        Patient patient = new Patient
        {
            FirstName = firstName,
            LastName = lastName,
            Gender = gender,
            Age = age,
            PhoneNumber = phoneNumber,
            State = state,
            Pincode = pincode,
            DepartmentFee = departmentFee
        };

        patients.Add(patient);
        Console.WriteLine($"Patient {patient.FullName} added successfully.");
    }

    static void SearchPatient()
    {
        Console.Write("Enter the phone number to search for a patient: ");
        string phoneNumber = Console.ReadLine();

        Patient patient = patients.Find(p => p.PhoneNumber == phoneNumber);

        if (patient != null)
        {
            Console.WriteLine($"Patient Details:\nName: {patient.FullName}\nGender: {patient.Gender}\nAge: {patient.Age}\nPhone Number: {patient.PhoneNumber}\nState: {patient.State}\nPincode: {patient.Pincode}\nDepartment Fee: {patient.DepartmentFee}");
        }
        else
        {
            Console.WriteLine("Patient not found.");
        }
    }

    static string GetDepartmentName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "General";
            case 2:
                return "ENT";
            case 3:
                return "Cardiology";
            case 4:
                return "Operation Theater";
            case 5:
                return "Intensive care Unit";
            default:
                return string.Empty;
        }
    }
}