namespace Module2Review;

public class Course
{
    public string CourseName{get;set;}
    public string CourseCode{get;set;}

    public List<Student> EnrolledStudents {get; set;}

    public Course()
    {
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
        Console.WriteLine($"{student.Name} has been enrolled in Coding.");
    }
    
    
    
    
        
    

}