using System;
using System.Collections.Generic;

public class Group
{
    List<Student> students = new List<Student>();
    Student student = new Student();

    private void GetRatingsForAllStudents()
    {
        if(students.Count == 0)
        {
            Console.WriteLine("Нет добавленных студентов");
        } else
        {
            for(int i = 0; i < students.Count -1; i++)
            {
                students[i].PrintAllRatingsOfStudent();
            }
        }
    }
}
