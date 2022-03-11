using Lab1;
using System.Diagnostics;

var team = new ResearchTeam("Theme", "Team", 124, TimeFrame.Year);

Console.WriteLine(team.ToShortString());

Console.WriteLine($"Year: { team[TimeFrame.Year] }");
Console.WriteLine($"TwoYears: {team[TimeFrame.TwoYears]}");
Console.WriteLine($"Long: {team[TimeFrame.Long]}");

team.ResearchTheme = "Вода";
team.TeamName = "Команда а";
team.RegistrationNumber = 3829432;
team.ResearchDuration = TimeFrame.TwoYears;
team.Papers = new List<Paper>()
{
	new Paper(
		"Вода сестрица",
		new Person("Иван", "Иванов", new DateTime(1964, 6, 12)),
		new DateTime(2004, 5, 12)),
	new Paper(
		"Вода три пятерки",
		new Person("Виктор", "Корнеплод", new DateTime(1958, 3, 24)),
		new DateTime(2007, 7, 15))
};

Console.WriteLine(team);

team.AddPapers(new[]
{
	new Paper(
		"Вода borjomi",
		new Person("Руслан", "Красноперов", new DateTime(1996, 8, 30)), 
		DateTime.Now),
	new Paper(
		"Вода святой источник",
		new Person("Петро", "Дмитров", new DateTime(1970, 7, 23)),
		new DateTime(2015, 5, 30))
});

Console.WriteLine(team);
Console.WriteLine($"Самая поздняя публицкация: {team.LatePaper}");


var papersArray = new Paper[1_000_000];
for (int i = 0; i < papersArray.Length; i++)
{
	papersArray[i] = new Paper();
}
var swArray = new Stopwatch();
swArray.Start();
foreach(var paper in papersArray)
{
	TestMethod(paper);
}
swArray.Stop();

var papersMatrix = new Paper[1000, 1000];
for (int i = 0; i < papersMatrix.GetLength(0); i++)
{
	for (int j = 0; j < papersMatrix.GetLength(1); j++)
	{
		papersMatrix[i, j] = new Paper();
	}
}
var swMatrix = new Stopwatch();
swMatrix.Start();
foreach (var paper in papersMatrix)
{
	TestMethod(paper);
}
swMatrix.Stop();


var papersJaggedArray = new Paper[1000][];
for (int i = 0; i < papersJaggedArray.Length; i++)
{
	papersJaggedArray[i] = new Paper[1000];
	for (int j = 0; j < papersJaggedArray[i].Length; j++)
	{
		papersJaggedArray[i][j] = new Paper();
	}
}
var swJaggedArray = new Stopwatch();
swJaggedArray.Start();
foreach(var pArray in papersJaggedArray)
{
	foreach(var paper in pArray)
	{
		TestMethod(paper);
	}
}
swJaggedArray.Stop();

Console.WriteLine($"Тест \nОбычный массив: {swArray.Elapsed}" +
	$"\nМатрица: {swMatrix.Elapsed}" +
	$"\nСтупенчатый: {swJaggedArray.Elapsed}");


void TestMethod(Paper paper)
{
	paper.Author = new Person();
	paper.Name = "new name";
	paper.PublicationTime = DateTime.Now;
}