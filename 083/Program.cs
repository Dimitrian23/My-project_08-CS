// Задача_№83 Подсчитать количество цифр среди вводимых с клавиатуры символов

string s="asdfg122";// string? s=Console.ReadLine();
int k=0;
// for(int i=0;i<s.Length;i++)
//   if(s[i]>='0'&& s[i]<='9') k++;

// foreach(char c in s)
// if(c>='0'&& c<='9') k++;

foreach(char c in s)
if(char.IsDigit(c)) k++;
System.Console.WriteLine(k);






