using System;
using System.Net.Sockets;
using Microsoft.Extensions.Primitives;

namespace TownshipPopulation
{
    /// <summary>
    /// Abstract base for every resident. Holds the fields shared by all
    /// residents behind private backing fields (encapsulation), and leaves
    /// GetSummary() for each concrete subtype to define (abstraction) —
    /// calling code only ever needs to know it is holding a "Person".
    /// </summary>


    public abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirst;
        private string _sex;
        private string _maritalStatus;
        private string _nationalId;
        private string _homeAddress;
        private string _nationality;
        private string _phoneNumber;

        protected Person(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string sex,
            string maritalStatus,
            string nationalId,
            string homeAddress,
            string nationality = "Congolese",
            string phoneNumber = ""
            )
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Sex = sex;
            MaritalStatus = maritalStatus;
            NationalId = nationalId;
            HomeAddress = homeAddress;
            Nationality = nationality;
            PhoneNumber = phoneNumber;

        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = string.IsNullOrWhiteSpace(value)
                                ? throw new ArgumentException("First name cannot be empty.")
                                : value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = string.IsNullOrWhiteSpace(value)
                    ? throw new ArgumentException("Last name cannot be empty.")
                    : value;
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirst;
            set => _dateOfBirst = value > DateTime.Now
                    ? throw new ArgumentException("Date of birth cannot be in the fure.")
                    : value;
        }
        public string Sex
        {
            get => _sex;
            set => _sex = value;
        }

        public string MaritalStatus
        {
            get => _maritalStatus;
            set => _maritalStatus = value;
        }

        public string NationalId
        {
            get => _nationalId;
            set => _nationalId = string.IsNullOrWhiteSpace(value)
                    ? throw new ArgumentException("National ID cannot be empty.")
                    : value;
        }

        public string HomeAddress
        {
            get => _homeAddress;
            set => _homeAddress = string.IsNullOrWhiteSpace(value)
                    ? throw new ArgumentException("Home address cannot be empty.")
                    : value;

        }

        public String Nationality
        {
            get => _nationality;
            set => _nationality = string.IsNullOrWhiteSpace(value) ? "UnKnow" : value;
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value ?? string.Empty;
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    age--;
                return age;
            }

        }

        public string GetFullName() => $"{FirstName} {LastName}";
        public abstract string GetSummary();
    }

}


