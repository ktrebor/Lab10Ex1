using Azure.Core;
using Lab10Ex1.Models;

//Seed();

static void ShowStudentsAlphabetically()
{
    using var ctx = new StudentsDbContext();

    foreach (var student in ctx.Students.OrderBy(s=>s.lastName))
    {
        Console.WriteLine(student);
    }
}

ShowStudentsAlphabetically();

static void Seed()
{
    using var ctx = new StudentsDbContext();

    ctx.Students.Add(
        new Student
        {
            firstName = "popescu",
            lastName = "georgel",
            age = 25,
            major = Major.Informatica
        });

    ctx.Students.Add(
        new Student
        {
            firstName = "ilinca",
            lastName = "lacrima",
            age = 27,
            major = Major.Informatica
        });

    ctx.Students.Add(
    new Student
    {
        firstName = "dorel",
        lastName = "logofatu",
        age = 23,
        major = Major.Constructii
    });

    ctx.Students.Add(
        new Student
        {
            firstName = "adriana",
            lastName = "merlescu",
            age = 21,
            major = Major.Litere
        });

    ctx.SaveChanges();
}