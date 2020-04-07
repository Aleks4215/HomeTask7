using System;

namespace HomeTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Student vasya = new Student();
            Student petya = new Student();

            group.students.Add(vasya);
            group.students[0].AddRating(5);
            group.students[0].AddRating(2);
            group.students[0].PrintAllRatingsOfStudent();
            group.students.Add(petya);
            group.students[1].AddRating(5);
            group.students[1].AddRating(10);
            group.students[1].PrintAllRatingsOfStudent();
            group.GetRatingsForAllStudents();
            group.GetAverageRatingOfGroup();
            group.GetAverageRatingsOfAllStudents();
            


        }
    }
}
