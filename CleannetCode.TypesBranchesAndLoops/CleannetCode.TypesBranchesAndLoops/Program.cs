// Built-in types
bool isRain = true;
byte age = 75;
sbyte sbvar = -85;
char letter = 'm';
decimal money = 1000000m;
double xCoord = 34.234d;
float height = 27.3f;
int booksCount = 123;
uint uIntVar = uint.MaxValue;
nint nativeInt = 449;
nuint nativeUInt = nuint.MinValue;
long starsCount = long.MaxValue;
ulong uLongVar = ulong.MaxValue;
short shortVar = 3823;
ushort uShortVar = 8392;

// Print values
Console.WriteLine(isRain);
Console.WriteLine(age);
Console.WriteLine(sbvar);
Console.WriteLine(letter);
Console.WriteLine(money);
Console.WriteLine(xCoord);
Console.WriteLine(height);
Console.WriteLine(booksCount);
Console.WriteLine(uIntVar);
Console.WriteLine(nativeInt);
Console.WriteLine(nativeUInt);
Console.WriteLine(starsCount);
Console.WriteLine(uLongVar);
Console.WriteLine(shortVar);
Console.WriteLine(uShortVar);

Console.WriteLine();

// Branches
if (money < 0)
{
    Console.WriteLine("Да ты в долгах, как в шелках, дружок!");
}
else if (money < 1000000m)
{
    Console.WriteLine($"Вы всего лишь {money}-нер :(");
}
else
{
    Console.WriteLine("Вы миллионер!");
}

Console.WriteLine();

// for loop
int anniversaryCount = 0;
for (int i = 1; i <= age; i++)
{
    if (i % 10 == 0) anniversaryCount++;
}
Console.WriteLine($"У вас было {anniversaryCount} юбилеев.");

Console.WriteLine();

// while loop
while (false)
{
    // Работает, пока истинно условие.
}

// do-while loop
do
{
    // Выполняется минимум один раз, а затем работает, пока истинно условие.
} while (false);
