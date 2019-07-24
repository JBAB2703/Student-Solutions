using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args)
        {
            Student brailee = new Student(); //The constructor is "Student()" and this is the format of a constructor which is a special method
            brailee.SetStatus("current");
            brailee.FirstName = "Brailee";
            brailee.IsPaid = true;
            brailee.Birthday = new DateTime(1990, 01, 01);

            brailee.SetCreditScore(9000);
            brailee.SetCreditScore(90);
            brailee.SetCreditScore(900);
            Console.WriteLine($"Brailee credit score is {brailee.CreditScore}");

            Student jesse = new Student();
            jesse.FirstName = "Jesse";
            jesse.SetStatus("past");
            jesse.IsPaid = true;
            jesse.Birthday = new DateTime(1974, 11, 24);

            Student alex = new Student();
            alex.FirstName = "Alex";
            alex.IsPaid = true;
            alex.Birthday = new DateTime(1992, 02, 23);

            Student maggie = new Student();
            maggie.FirstName = "Maggie";
            maggie.LastName = "Henry";
            maggie.Address = "123 City Street";
            maggie.IsPaid = true;
            maggie.Birthday = new DateTime(1990, 01, 01);

            string name = jesse.FirstName;  
        }
    }
    class Student {
        // Naming a class: They are singular, start with a capitalized letter and are things or nouns
        // When designing a class you want to begin by defining each thing within the class
        public int ID { get; set; } // primary key
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
        public int CreditScore { get; private set; } //because this is set to "private set" it can be read however, it can't be set in any other class

        //Methods refer to 24July2019 notes
        public void SetStatus(string status) {

            if ((status == "CURRENT") || (status == "PAST") || (status == "FUTURE")) {
                this.Status = status;
            } else {
                Console.WriteLine("Status must be: PAST, CURRENT or FUTURE");
            }

        }

        public void SetCreditScore(int score)
        {
            if (score >= 400 && score <= 900)
            {
                this.CreditScore = score;
            } else {
                Console.WriteLine("Invalid Credit Score");
            }
            
        }
        public Student(string firstName, string LastName)
        {
            this.FirstName = firstName; //"this" means this instance that I am creating
            this.LastName = LastName;
        }
        public Student() { }
    }
}
    