//Задача_№85  Преобразовать во вводимой с клавиатуры строке строчные латинские буквы в прописные

string s="asdплвasdфывфывasskjhjdfidddsa"; // string? s=Console.ReadLine();

System.Text.StringBuilder sb=new System.Text.StringBuilder(s);
for(int i=0;i<sb.Length;i++)
  if (sb[i]>='a' && sb[i]<='z')
    sb[i]=char.ToUpper(s[i]);
s=sb.ToString();
System.Console.WriteLine(s);   



