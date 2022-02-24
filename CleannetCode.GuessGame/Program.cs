Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!");
Console.WriteLine();
Console.WriteLine("Нажмите любую клавишу, чтобы начать игру.");
Console.ReadKey();

Console.Clear();
int minHiddenNumber = 0;
int maxHiddenNumber = 999;
int hiddenNumber = new Random().Next(minHiddenNumber, maxHiddenNumber + 1);
Console.WriteLine($"Загадано число от {minHiddenNumber} до {maxHiddenNumber}. Вам необходимо угадать число.");
Console.Write("Введите число и нажмите Enter: ");

int attemptCount = 0;
bool hiddenNumberGuessed = false;
while (!hiddenNumberGuessed)
{
    string? userInput = Console.ReadLine();
    int attempt = -1;
    Console.WriteLine();
    if (int.TryParse(userInput, out attempt))
    {
        if (attempt < minHiddenNumber || attempt > maxHiddenNumber)
        {
            Console.Write($"Введенное число вне диапазона от {minHiddenNumber} до {maxHiddenNumber}. Попробуйте еще раз: ");
        }
        else
        {
            attemptCount++;
            if (attempt == hiddenNumber)
            {
                hiddenNumberGuessed = true;
            }
            else if (attempt < hiddenNumber)
            {
                Console.Write($"Ваша попытка: {attempt}. Загаданное число больше. Попробуйте еще раз: ");
            }
            else
            {
                Console.Write($"Ваша попытка: {attempt}. Загаданное число меньше. Попробуйте еще раз: ");
            }
        }
    }
    else
    {
        Console.Write("Некорректный ввод. Попробуйте еще раз: ");
    }
}

Console.Clear();
Console.WriteLine($"Поздравляем! Вы угадали число! Количество попыток: {attemptCount}.");
