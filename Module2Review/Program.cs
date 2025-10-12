// See https://aka.ms/new-console-template for more information

using Module2Review;

var students = new List<Student>();






var Sammee = new Student();
Sammee.Name = "Sammee";
Sammee.Id = 1;
students.Add(Sammee);

var Buzz = new Student()
{
    Name = "Buzz",
    Id = 2,
};
students.Add(Buzz);

var Grady = new Student("Grady", 3);
students.Add(Grady);


var Roobee = new Student()
{
    Name = "Roobee",
    Id = 4,
};
students.Add(Roobee);

var Beanie = new Student();
Beanie.Name = "Beanie";
Beanie.Id = 5;
students.Add(Beanie);

