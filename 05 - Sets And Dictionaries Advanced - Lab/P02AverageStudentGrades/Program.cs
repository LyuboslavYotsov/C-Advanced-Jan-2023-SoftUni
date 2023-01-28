using System;
using System.Collections.Generic;
using System.Linq;

int count = int.Parse(Console.ReadLine());
Dictionary<string,List<decimal>> studentsGrades = new Dictionary<string,List<decimal>>();

for (int i = 0; i < count; i++)
{
    string[] studendInfo = Console.ReadLine()
        .Split(' ',StringSplitOptions.RemoveEmptyEntries);
    string name = studendInfo[0];
    decimal grade = decimal.Parse(studendInfo[1]);

    if (!studentsGrades.ContainsKey(name))
    {
        studentsGrades.Add(name, new List<decimal>());
    }
    studentsGrades[name].Add(grade);
}

foreach (var studentGrade in studentsGrades)
{
    Console.Write($"{studentGrade.Key} -> ");

    foreach (var grade in studentGrade.Value)
    {
        Console.Write($"{grade:f2} ");
    }
    Console.Write($"(avg: {studentGrade.Value.Average():f2})");
    Console.WriteLine();
}