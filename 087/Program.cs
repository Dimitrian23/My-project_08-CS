// Задача_№87 Удалить средний символ при нечетной длине строки и две средние буквы при четной длине строки

string s="ABCCDE";// string? s=Console.ReadLine();
if (s.Length%2==0)
  s=s.Remove(s.Length/2-1,2);
  else
    s=s.Remove(s.Length/2,1);
System.Console.WriteLine(s);








