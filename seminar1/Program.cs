/* Создание и вывод таблицы в файл (кодировка!)
*/
string result = String.Empty;

string[] marks = { "троечник", "ударник", "отличник" };
string[] fnames = { "Сергей", "Дмитрий", "Ирина", "Алиса" };
string[] lnames = { "Петров(-а)", "Баранов(-а)", "Ленин(-а)", "Гаврилов(-а)" };

for (int i = 0; i < 100; i++)
{
  string fname = fnames[new Random().Next(fnames.Length)];
  string lname = lnames[new Random().Next(lnames.Length)];
  string mark = marks[new Random().Next(marks.Length)];
  result += $"{i + 1}; {fname}; {lname}; {mark};\n";
}
//Console.WriteLine($"{result}");
File.WriteAllText("db.csv", result);


/* Через draw.io
  Table_УЧЕНИКИ
    id
    fname
    lname
    mark
*/

