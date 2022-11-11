using TypeFiles;
//WorkWithFile file = new WorkWithFile();
void Menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine();
    Console.WriteLine("1. Создать файл");
    Console.WriteLine("2. Переместить файл");
    Console.WriteLine("3. Записать в текстовый документ");
    Console.WriteLine("4. Удалить файл");
}
void GetMenu()
{
    string select = Console.ReadLine();
    bool parse = int.TryParse(select, out var selected);
    if (parse)
    {
        switch (selected)
        {
            case 1:
                WorkWithFile file1 = new WorkWithFile();
                file1.CreateFile();
                break;
            case 2:
                WorkWithFile file2 = new WorkWithFile();
                file2.MoveFile();
                break;
            case 3:
                WorkWithFile file3 = new WorkWithFile();
                file3.WriteByteStringInFile();
                break;
            case 4:
                WorkWithFile file = new WorkWithFile();
                file.DeleteFile();
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Ошибка");
                Console.WriteLine();
                break;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка");
        Console.WriteLine();
    }

}
while (true)
{
    Menu();
    GetMenu();
}
