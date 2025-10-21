// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using Module2Review;

var students = new List<Student>();




var sammee = new Student();
sammee.Name = "Sammee";
sammee.Id = 1;
sammee.AddGrade(99.4);
sammee.AddGrade(99.4, 94, 97, 98.5);
students.Add(sammee);


var buzz = new Student()
{
    Name = "Buzz",
    Id = 2,
};
buzz.AddGrade(97.5);
buzz.AddGrade(98.5, 95, 98, 96);
students.Add(buzz);


var grady = new Student("Grady", 3);
grady.AddGrade(92);
grady.AddGrade(97, 92.5, 93, 95);
students.Add(grady);


var roobee = new Student()
{
    Name = "Roobee",
    Id = 4,
};
roobee.AddGrade(95.5);
roobee.AddGrade(95.5, 94, 97, 96);
students.Add(roobee);

var beanie = new Student();
beanie.Name = "Beanie";
beanie.Id = 5;
beanie.AddGrade(94);
beanie.AddGrade(94, 93, 97.5, 92);
students.Add(beanie);


Console.WriteLine("Id  Name     Grades");
foreach (var student in students)
{
    
    Console.WriteLine($"{student.Id} {student.Name}  {string.Join(", ", student.Grades)}");
}




