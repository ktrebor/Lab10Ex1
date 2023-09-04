using Lab10Ex1.Models;

var ionica = new Student
{
    Id = 1,
    firstName = "ionica",
    lastName = "pop",
    age = 23,
    major = Major.Constructii
};

var ctx = new StudentsDbContext();