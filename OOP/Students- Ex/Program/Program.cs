using System;


namespace Program
{
    class Students
    {
        static void Main()
        {

            string firstStudentNames = null;
            Console.Write("Write first student names: ");
            firstStudentNames = Console.ReadLine();
            string firstStudentClass = null;
            Console.Write("Write first student's class: ");
            firstStudentClass = Console.ReadLine();
            string firstStudentSpecialty = null;
            Console.Write("Write first student's specialty: ");
            firstStudentSpecialty = Console.ReadLine();
            string firstStudentUniversity = null;
            Console.Write("Write first student's university: ");
            firstStudentUniversity = Console.ReadLine();
            string firstStudentEmail = null;
            Console.Write("Write first student's email: ");
            firstStudentEmail = Console.ReadLine();
            string firstStudentPhone = null;
            Console.Write("Write first student's phone: ");
            firstStudentPhone = Console.ReadLine();

            Console.WriteLine();

            Students firstStudent = new Students(firstStudentNames
                , firstStudentClass
                , firstStudentSpecialty
                , firstStudentUniversity
                , firstStudentEmail
                , firstStudentPhone);

            firstStudent.name = firstStudentNames;
            firstStudent.@class = firstStudentClass;
            firstStudent.specialty = firstStudentSpecialty;
            firstStudent.university = firstStudentUniversity;
            firstStudent.email = firstStudentEmail;
            firstStudent.phone = firstStudentPhone;


            string secondStudentNames = null;
            Console.Write("Write second student names: ");
            secondStudentNames = Console.ReadLine();
            string secondStudentClass = null;
            Console.Write("Write second student's class: ");
            secondStudentClass = Console.ReadLine();
            string secondStudentSpecialty = null;
            Console.Write("Write second student's specialty: ");
            secondStudentSpecialty = Console.ReadLine();
            string secondStudentUniversity = null;
            Console.Write("Write second student's university: ");
            secondStudentUniversity = Console.ReadLine();
            string secondStudentEmail = null;
            Console.Write("Write second student's email: ");
            secondStudentEmail = Console.ReadLine();
            string secondStudentPhone = null;
            Console.Write("Write second student's phone: ");
            secondStudentPhone = Console.ReadLine();

            Console.WriteLine();

            Students secondStudent = new Students(secondStudentNames
                , secondStudentSpecialty
                , secondStudentClass
                , secondStudentUniversity
                , secondStudentEmail
                , secondStudentPhone);

            secondStudent.name = secondStudentNames;
            secondStudent.@class = secondStudentClass;
            secondStudent.specialty = secondStudentSpecialty;
            secondStudent.university = secondStudentUniversity;
            secondStudent.email = secondStudentEmail;
            secondStudent.phone = secondStudentPhone;

            string thirdStudentNames = null;
            Console.Write("Write third student names: ");
            thirdStudentNames = Console.ReadLine();
            string thirdStudentClass = null;
            Console.Write("Write third student's class: ");
            thirdStudentClass = Console.ReadLine();
            string thirdStudentSpecialty = null;
            Console.Write("Write third student's specialty: ");
            thirdStudentSpecialty = Console.ReadLine();
            string thirdStudentUniversity = null;
            Console.Write("Write third student's university: ");
            thirdStudentUniversity = Console.ReadLine();
            string thirdStudentEmail = null;
            Console.Write("Write third student's email: ");
            thirdStudentEmail = Console.ReadLine();
            string thirdStudentPhone = null;
            Console.Write("Write third student's phone: ");
            thirdStudentPhone = Console.ReadLine();

            Console.WriteLine();

            Students thirdStudent = new Students(thirdStudentNames
                , thirdStudentSpecialty
                , thirdStudentClass
                , thirdStudentUniversity
                , thirdStudentEmail
                , thirdStudentPhone);

            thirdStudent.name = thirdStudentNames;
            thirdStudent.@class = thirdStudentClass;
            thirdStudent.specialty = thirdStudentSpecialty;
            thirdStudent.university = thirdStudentUniversity;
            thirdStudent.email = thirdStudentEmail;
            thirdStudent.phone = thirdStudentPhone;



            Students[] students = new Students[] { firstStudent, secondStudent, thirdStudent };
            foreach (Students student in students)
            {
                student.Print();
            }
        }


        private string name;
        private string @class;
        private string specialty;
        private string university;
        private string email;
        private string phone;

        public Students()
        {
        }
        public Students(string name
            , string @class
            , string specialty
            , string university
            , string email
            , string phone)
        {
            this.name = name;
            this.@class = @class;
            this.specialty = specialty;
            this.university = university;
            this.email = email;
            this.phone = phone;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Class
        {
            get { return @class; }
            set { @class = value; }
        }
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public string University
        {
            get { return university; }
            set { university = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {@class}");
            Console.WriteLine($"Specialtu: {specialty}");
            Console.WriteLine($"University: {university}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone: {phone}");

            Console.ReadLine();

        }
    }
}
