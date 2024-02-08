List<int> integers = new List<int>() { 1, 3, -10, 6, 83, 4, 17, 25, -43, 6, 9, 83, 100 };

//Find summen af alle tal over 9

//Lav en iterativ udgave
List<int> integersAbove9 = new List<int>();
foreach(int i in integers)
{
    if(i>9) integersAbove9.Add(i);
}
int sumAllAboveNine = integersAbove9.Sum();

Console.WriteLine($"sumAllAboveNine : {sumAllAboveNine}");
//Lav en udgave der anvender predicate/lambda udtryk

sumAllAboveNine = integers.FindAll((int i) => (i > 9)).Sum();

Console.WriteLine($"sumAllAboveNine : {sumAllAboveNine}");

//Find summen af alle ikke lige tal

//Lav en iterativ udgave
List<int> integersOdd = new List<int>();
foreach (int i in integers)
{
    if (!(i % 2 == 0))
    {
        integersOdd.Add(i);
    }
}
int sumAllOdd = integersOdd.Sum();

Console.WriteLine($"sumAllUnEqual : {sumAllOdd}");

//Lav en udgave der anvender predicate/lambda udtryk
sumAllOdd = integers.FindAll((int i) => (i % 2 != 0)).Sum();
Console.WriteLine($"sumAllUnEqual : {sumAllOdd}");

//Find gennemsnittet af alle tal der er større end 0 og mindre end 20

//Lav en iterativ udgave
List<int> integersWithAVeryLongName = new List<int>();
foreach (int i in integers)
{
    if (i>0 && i < 20)
    {
        integersWithAVeryLongName.Add(i);
    }
}
double averageAllNumbersGreaterThan0AndLessThan20 = integersWithAVeryLongName.Average();

Console.WriteLine($"averageAllNumbersGreaterThan0AndLessThan20 : {averageAllNumbersGreaterThan0AndLessThan20}");
//Lav en udgave der anvender predicate/lambda udtryk

double AverageLongNumber = integers.FindAll((int i) => (i>0 && i<20)).Average();
Console.WriteLine($"averageAllNumbersGreaterThan0AndLessThan20 : {AverageLongNumber}");


//Find det højest ikke lige tal

//Lav en iterativ udgave

List<int> integersOddMaxList = new List<int>();
foreach (int i in integers)
{
    if ((i % 2 != 0))
    {
        integersOddMaxList.Add(i);
    }
}
int maxAllOdd = integersOdd.Max();
Console.WriteLine($"maxUnEqualNumber : {maxAllOdd}");
//Lav en udgave der anvender predicate/lambda udtryk
maxAllOdd = integers.FindAll((int i) => (i % 2 != 0)).Max();

Console.WriteLine($"maxUnEqualNumber : {maxAllOdd}");

//Udskriv alle ulige tal sorteret


List<int> integersOddSortedList = new List<int>();
foreach (int i in integers)
{
    if ((i % 2 != 0))
    {
        integersOddSortedList.Add(i);
    }
}
integersOddSortedList.Sort();
Console.Write("Sorted list: ");
foreach (int i in integersOddSortedList)
{
    Console.Write($"{i}, ");
}

Console.WriteLine();

List<int> sortedAllOdd = new List<int>();

sortedAllOdd = integers.FindAll((int i) => (i % 2 != 0));
sortedAllOdd.Sort();

Console.Write("Sorted list: ");
foreach (int i in sortedAllOdd)
{
    Console.Write($"{i}, ");
}
