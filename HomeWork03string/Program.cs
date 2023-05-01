// Задача 19, палиандр, string version
// Напишите программу, которая принимает на вход стринг - последовательность символов (букв или цифр)
// и определяет, является ли стринг палиандром
// аврора -> нет,   75антон -> нет
// аврорва -> да,   75алла57 -> да 
string ReadString(string text) //проглатывает в стринг строку символов =вводимую последовательность символов, 
// включая пробелыя, тоже считаемые вводимые символами 
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}

int CountDifTwins(string text) //для данного на входе стринга находит число пар "близнецов":
// символ на i-м месте с начала совпадает с символом на i-м месте с конца 
{
    int CountDif = 0;
    if (text.Length > 0)
    {
        int Last = text.Length - 1;
        int centre = text.Length / 2 - 1;
        for (int i = 0; i <= centre; i++)
        {
            //System.Console.Write($" {i}-й слева символ   {text[i]}   VS");
            //System.Console.WriteLine($" {i}-й справа символ   {text[Last - i]}");
            if (text[i] != text[Last - i])
            {
                CountDif++;
            }
        }
    }
    //System.Console.WriteLine($" разных пар символов {CountDif}");
    return CountDif;
}

string Word = ReadString("Введите текст (от 1 до 128 символов):");
if (Word.Length > 0)
{
    if (Word.Length > 128)
    {
        System.Console.WriteLine("Warning: Вводимая фраза слишком длинная (более 128 символов)");
    };
    int CountDif = CountDifTwins(Word);
    if (CountDifTwins(Word) == 0)
    {
        System.Console.WriteLine($" введенный текст:");
        System.Console.WriteLine(Word);
        System.Console.WriteLine($" является палиандром");
    }
    else { System.Console.WriteLine($" введенный текст не является палиандром"); }
}
else
{
    System.Console.WriteLine(" Вы ввели пустой стринг. Повторите ввод.");
}

