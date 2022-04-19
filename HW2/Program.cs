/*Задача 2: Проверка на простое число:
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”*/

int Promt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

void SimpleNumber(int N, int M)
{
    if (N / M == 1)
    {
        Console.WriteLine("Это простое число");
        return;
    }
    if (N % M != 0)
    {
        SimpleNumber(N, M + 1);
    }
    else Console.WriteLine("Это не простое число");
}

int N = Promt("Введите N => ");
SimpleNumber(N, 2);