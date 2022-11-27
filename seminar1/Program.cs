/* Создание и вывод таблицы в файл (кодировка!)

string result = String.Empty;

string[] marks = { "троечник", "ударник", "отличник" };
for (int i = 0; i < 100; i++)
{
  int id = i;
  string fname = $"Имя_{i}";
  string lname = $"Фамилия_{i}";
  string mark = marks[new Random().Next(marks.Length)];
  result += $"{id}; {fname}; {lname}; {mark};\n";
}
//Console.WriteLine($"{result}");
File.WriteAllText("db.csv", result);

*/

/* Через draw.io
  Table_УЧЕНИКИ
    id
    fname
    lname
    mark
*/

