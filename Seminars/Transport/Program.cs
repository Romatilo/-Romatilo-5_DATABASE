int routesCount = 50;   // Зададим 50 маршруторов, по 20 автобусов на маршрут, по 2 водителя и 2 кондуктора на автобус
int busPerRoute = 20;
int busesCount = routesCount * busPerRoute;
int driversCount = busesCount * 2;
int conductorsCount = busesCount * 2;
string[] maleNames = File.ReadAllLines("male_names.txt");
string[] femaleNames = File.ReadAllLines("female_names.txt");
string[] maleSurnames = File.ReadAllLines("male_surnames.txt");
string[] femaleSurnames = File.ReadAllLines("female_surnames.txt");
int[] routeNumber = new int[routesCount];
int[] busNumber = new int[busesCount];

// Создадим список автобусов (с четырехзначными номерами)
for (int i = 1; i < busesCount+1; i++)
{
    busNumber[i] = i;
    File.AppendAllText("busNumber.csv", $"{busNumber[i]}\n");
    File.AppendAllText("busNumber.csv", $"{busNumber[i]}\n");
}

// Создадим водителей и кондукторов. Немного сексизма: все водители - мужчины, все кондукторы - женщины X-D
for (int i = 0; i < driversCount; i++)
{
    File.AppendAllText("drivers.csv", $"{maleSurnames[Random.Shared.Next(maleSurnames.Length)]} {maleNames[Random.Shared.Next(maleNames.Length)]}\n");
    File.AppendAllText("conductors.csv", $"{femaleSurnames[Random.Shared.Next(femaleSurnames.Length)]} {femaleNames[Random.Shared.Next(femaleNames.Length)]}\n");
}