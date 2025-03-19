using System.Text;

StringBuilder sb = new StringBuilder("Hello, world!");
string stringToInsert = " beautiful";

int insertPosition = sb.Length / 2; 
sb.Insert(insertPosition, stringToInsert);

Console.WriteLine(sb.ToString());