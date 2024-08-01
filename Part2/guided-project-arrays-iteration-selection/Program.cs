using System;

// initialize variables - graded assignments 

int[] sophiaArray = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewArray = { 92, 89, 81, 96, 90, 89 };
int[] emmaArray = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganArray = { 90, 95, 87, 88, 96, 96 };
int[] beckyArray = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisArray = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericArray = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorArray = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int currentAssignments = 5;
string[] studentName = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
string currentStudentLetterGrade = "";
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentName)
{

    int[] studentArray = { };
    if (name == "Sophia")
    {
        studentArray = sophiaArray;
    }
    if (name == "Andrew")
    {
        studentArray = andrewArray;
    }
    if (name == "Emma")
    {
        studentArray = emmaArray;
    }
    if (name == "Logan")
    {
        studentArray = loganArray;
    }
    if (name == "Becky")
    {
        studentArray = beckyArray;
    }
    if (name == "Chris")
    {
        studentArray = chrisArray;
    }
    if (name == "Eric")
    {
        studentArray = ericArray;
    }
    if (name == "Gregor")
    {
        studentArray = gregorArray;
    }
    int studentSum = 0;
    decimal currentStudentGrade;
    //Thêm phần bonus Exam
    int bonusExam = 0;

    foreach (int score in studentArray)
    {
        bonusExam += 1;
        if (bonusExam <= currentAssignments)
        {
            studentSum += score;
        }
        else
        {
            studentSum += score / 10;
        }

    }
    currentStudentGrade = (decimal)studentSum / currentAssignments;

    //Tính rank
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";
    Console.WriteLine($"{name}:\t\t" + currentStudentGrade + "\t" + currentStudentLetterGrade);
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
