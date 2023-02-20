Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
string dayText = Convert.ToString(day);
if (day < 6)
{
    Console.WriteLine("Рабочий день!");
}
else
  {
     Console.WriteLine("Выходной день!");
  }
