string[] maleNames = File.ReadAllLines("male_names.txt");
string[] femaleNames = File.ReadAllLines("female_names.txt");
string[] maleSurnames = File.ReadAllLines("male_surnames.txt");
string[] femaleSurnames = File.ReadAllLines("female_surnames.txt");


for (int i = 1; i < 101; i++)
{
    File.AppendAllText("drivers.csv", $"{i} {maleSurnames[Random.Shared.Next(maleSurnames.Length)]} {maleNames[Random.Shared.Next(maleNames.Length)]}\n");
    File.AppendAllText("conductors.csv", $"{i} {femaleSurnames[Random.Shared.Next(femaleSurnames.Length)]} {femaleNames[Random.Shared.Next(femaleNames.Length)]}\n");
}