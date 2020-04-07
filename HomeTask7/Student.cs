using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{

    private string firstName, lastName;
    private List<int> ratings = new List<int>();

    private void AddRating(int rating) => ratings.Add(rating);
    public decimal GetAverageRating() => (decimal)ratings.Average();

    public List<int> PrintAllRatingsOfStudent()
    {
        if (ratings.Count == 0)
        {
            Console.WriteLine("Список оценок пуст");
            return null;
        }
        else
        {
            return ratings;
        }

    }
}

