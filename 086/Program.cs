//Задача_86  Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string s="tAAAjaaaaE.";
char a='a';
int c=0;
for(int i=0;i<s.Length;i++)
if(s[i]==a)
c++;
 System.Console.WriteLine(c);