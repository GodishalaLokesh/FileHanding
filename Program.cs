using System.IO;

/*
namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileStream file = File.Create("test.txt");
            //Console.WriteLine("Done");
            //file.Close();


            ////automatically close
            //using (File.Create("test.txt"))
            //{

            //}

            /*
            using (File.Create("E://Lokesh/C# Programs/myfirstfile.txt"))
            {

            }
            Console.WriteLine("File created successfully");
            */

            //File.WriteAllText("test.txt", "Hello bhAAi");
            //Console.WriteLine("Text written Successfully");

            //string name = "Bittu\nAlice\nBob\nbhAAi";
            //File.WriteAllText("test.txt", name);
            //Console.WriteLine("Written successfully");

            //File.WriteAllText("message.txt", "Welcome to C#");
            //Console.WriteLine("Done");


            /*
            string name = "Rohan";
            int age = 24;
            string data = "Name : " + name + "\nAge : " + age;
            File.WriteAllText("StudentInfo.txt", data);
            Console.WriteLine("Done");
            */

            /*
            string name = "Lokesh";
            string department = "Development";
            int salary = 50000;
            DateTime joiningDate = new DateTime(2026,01,28);
            string info = "Name : " + name +
                          "\nDepartment : " + department +
                          "\nSalary : " + salary +
                          "\nJoiningDate : " + joiningDate.ToString("dd-MM-yyyy");
            File.WriteAllText("EmployeeInfo.txt", info);
            Console.WriteLine("Done");
            */

            /*
            string name1 = "Lokesh";
            string department1 = "Development";
            int salary1 = 50000;
            string emp1 = $"Employee 1 \nName: {name1} \nDepartment : {department1} \nSalary : {salary1}";

            string name2 = "Lokesh";
            string department2 = "Development";
            int salary2 = 50000;
            string emp2 = $"\nEmployee 2 \nName: {name2} \nDepartment : {department2} \nSalary : {salary2}";

            string name3 = "Lokesh";
            string department3 = "Development";
            int salary3 = 50000;
            string emp3 = $"\nEmployee 3 \nName: {name3} \nDepartment : {department3} \nSalary : {salary3}";

            string info = emp1 + emp2 + emp3;
            
            File.WriteAllText("EmployeeInfo.txt", info);
            Console.WriteLine("Done");
            */


            //-----Read all lines---------------------->>

            /*
            string data = File.ReadAllText("EmployeeInfo.txt");
            Console.WriteLine(data);
            */

            /*
            if (File.Exists("Lokesh.txt"))
            {
                string data = File.ReadAllText("Lokesh.txt");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File not found");
            }
            */


            /*
            //-------> Append All text

            string emp1 = "Employee 1\n" +
                           "Name : Lokesh\n" +
                           "Department : Development\n" +
                           "Salary : 50000";
            File.WriteAllText("EmpInfo.txt", emp1);

            string emp2 =
               "\n\nEmployee 2\n" +
               "Name : Rahul\n" +
               "Department : HR\n" +
               "Salary : 45000";
            File.AppendAllText("EmpInfo.txt", emp2);

            Console.WriteLine("Data saved");
            */

            /*
            string[] students = File.ReadAllLines("studentInfo.txt");
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }
            */
            /*

            string data = File.ReadAllText("studentInfo.txt");
            Console.WriteLine(data);

            Console.ReadLine();

            
        }
    }
}
*/

namespace FileHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            FileInfo file = new FileInfo("EmpInfo.txt");
            Console.WriteLine("File Name : "+file.Name);
            Console.WriteLine("File Path : " + file.FullName);
            Console.WriteLine("File Size : " + file.Length+" bytes");
            Console.WriteLine("File Extension : " + file.Extension);
            Console.WriteLine("File Name : " + file.CreationTime);
            Console.WriteLine("File Name : " + file.LastWriteTime);
            */

            //DirectoryInfo d = new DirectoryInfo("net10.0");
            //FileInfo[] files = d.GetFiles();
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //DirectoryInfo d = new DirectoryInfo("Reports");
            //d.Create();
            //Console.WriteLine(d.Exists);

            //File.Create("C:\\Projects\\FileHandling\\bin\\Debug\\net10.0\\Reports\\Mar.txt");
            //Console.WriteLine("Done");

            /*
            DirectoryInfo d = new DirectoryInfo("Reports");
            FileInfo[] f = d.GetFiles();
            foreach (var item in f)
            {
                Console.WriteLine(item.Name);
            }
            */
            
            // File.Delete("xyz.txt");
            if (File.Exists("xyz.txt"))
            {
                File.Delete("xyz.txt");
            }
            else
            {
                Console.WriteLine("File not found"); ;
            }



        }
    }
}

