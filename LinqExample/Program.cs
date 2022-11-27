// See https://aka.ms/new-console-template for more information
using LinqExample;

Console.WriteLine("Hello from Linq Lession!");


// LINQ using in Collection
List<string> nameList = new List<string>();

nameList.Add("Mg Mg");
nameList.Add("Mya Mya");
nameList.Add("Hla Hla");
nameList.Add("Bo Bo");
nameList.Add("Aung Aung");
nameList.Add("Kyaw Kyaw");

string? selectedPerson = nameList.FirstOrDefault(x => x == "Hla Hla");

Console.WriteLine(selectedPerson);


// LINQ using list of object

List<Student> studentList = new List<Student>();

Student student1 = new Student()
{
    Name = "Mg Mg",
    DOB = "13/3/1998",
    Address = "Pathein",
    Age = 8,
};

Student student2 = new Student()
{
    Name = "Aung Aung",
    DOB = "13/3/1995",
    Address = "Yangon",
    Age = 9,
};


Student student3 = new Student()
{
    Name = "Hla Hla",
    DOB = "13/3/1991",
    Address = "Bago",
    Age = 15,
};


Student student4 = new Student()
{
    Name = "Kyaw Hla",
    DOB = "13/3/1995",
    Address = "Pathein",
    Age = 20,
};

studentList.Add(student1);
studentList.Add(student2);
studentList.Add(student3);
studentList.Add(student4);


Student? ageOver20Student = studentList.Where(x => x.Age > 10).FirstOrDefault();
List<Student> ageOver20Student2= studentList.Where(x => x.Age > 10).ToList();


if (ageOver20Student != null)
{
    Console.WriteLine(ageOver20Student);
}
