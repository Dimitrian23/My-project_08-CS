// Задача_№84  Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числa

  string n="12Privet-/.'`"; // string? n=Console.ReadLine();
  char s='0';
  int sum=0;
  
for (int i = 0; i < n.Length; i++)
{
     s=n[i];
    System.Console.Write($"Клавиша [{s}]");
    System.Console.Write($" --> Код клавиши {(int)s}");
    System.Console.WriteLine();
if(s>=48&&s<=57)
{
   sum += n[i] - 48;  
  System.Console.WriteLine($"Сам символ({s})_Является правильной записью целого числа!");
  System.Console.WriteLine();
}
else
  System.Console.WriteLine($"Сам символ ({s})_Не является правильной записью целого числа!");
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма цифр изображённых на введённых клавишах являющихся правильной записью целого числа ={sum}");
System.Console.WriteLine();



