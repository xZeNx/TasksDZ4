// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

int degree(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}
  Console.Write("Ведите первое число: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int Naturaldegree = degree(numberA, numberB);
  Console.WriteLine("Ответ: " + Naturaldegree);
