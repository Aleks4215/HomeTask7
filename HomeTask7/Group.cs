using System;
using System.Collections.Generic;

public class Group
{
    List<Student> students = new List<Student>();
    Student student = new Student();

    public void GetRatingsForAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Нет добавленных студентов");
        }
        else
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].PrintAllRatingsOfStudent();
            }
        }
    }
    public void GetAverageRatingsOfAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Нет добавленных студентов");
        }
        else
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].GetAverageRating();
            }
        }
    }

    public void GetAverageRatingOfGroup()
    {
        decimal avr;
        decimal sum = 0.0m;
        if (students.Count == 0)
        {
            Console.WriteLine("Нет добавленных студентов");
        }
        else
        {
            for (int i = 0; i < students.Count; i++)
            {
                sum += students[i].GetAverageRating();
            }
            avr = sum / students.Count;
        }
    }
}
