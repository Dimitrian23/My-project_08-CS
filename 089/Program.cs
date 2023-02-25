// Задача_№89 Подсчитать сумму цифр, встречающихся в строке

 string n="Text 12 PRiveT 2";
  char s='0';
  int sum=0;
  
for (int i = 0; i < n.Length; i++)
{
     s=n[i];
    System.Console.Write($"{s}"); 
if(s>=48&&s<=57)
{
   sum += n[i] - 48;  
}
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма цифр встречающихся в строке = ( {sum} )");



