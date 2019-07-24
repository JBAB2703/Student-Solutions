using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student(); //Format of a constructor which is a special method
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthdate = new DateTime(1990, 01, 01);

            Student jesse = new Student();
            jesse.FirstName = "Jesse";
            jesse.IsPaid = true;
            jesse.Birthdate = new DateTime(1974, 11, 24);

            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.IsPaid = true;
            alex.Birthdate = new DateTime(1992, 02, 23);

            Student maggie = new Student();
            maggie.FirstName = "Maggie";
            maggie.LastName = "Henry";
            maggie.Address = "123 City Street";
            maggie.IsPaid = true;
            maggit.Birthdate = new DateTime(1990, 01, 01);

            string name = jesse.FirstName;  
        }
    }
    class Student { 
        // Naming a class: They are singular, start with a capitalized letter and are things or nouns
        // When designing a class you want to begin by defining each thing within the class
        public string FirstName { get; set; }
            //You can only do two things to a Property in a class
            //Get - string n =FirstName;
            //Set - FirstName = "Greg";
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Bootcamp { get; set; }
        public string Status { get; set; } //current, future, past
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsPaid { get; set; } = false; //Example: "= false" is now the default property for that boolean
        public DateTime Birthday { get; set; }
    }
}
    