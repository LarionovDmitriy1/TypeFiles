using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace TypeFiles;

public class WorkWithFile
{
    private string filePapka = @"C:\Users\Студент1\Desktop\Папка\Papka.txt";
    private string fileMamka = @"C:\Users\Студент1\Desktop\Мамка\Mamka.txt";
    public WorkWithFile()
    {

    }
    public void CreateFile()
    {

        FileInfo fileinf = new FileInfo(filePapka);
        FileInfo fileinf1 = new FileInfo(fileMamka);
        Console.WriteLine("Где хотите создать файл");
        Console.WriteLine("1. Папка");
        Console.WriteLine("2. Мамка");
        string select = Console.ReadLine();
        bool parse = int.TryParse(select, out var selected);
        switch (selected)
        {
            case 1:
                if (!fileinf.Exists)
                {
                    fileinf.Create();
                    Console.WriteLine();
                    Console.WriteLine("Текстовый документ в папке создан");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Документ уже создан");
                    Console.WriteLine();

                }
                break;
            case 2:
                if (!fileinf1.Exists)
                {
                    fileinf1.Create();
                    Console.WriteLine();
                    Console.WriteLine("Текстовый документ в папке создан");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Документ уже создан");
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("Ошибка");
                break;
        }
    }
    public void MoveFile()
    {
        FileInfo fileinf1 = new FileInfo(fileMamka);
        FileInfo fileinf = new FileInfo(filePapka);
        Console.WriteLine("Откуда хотите переместить документ");
        Console.WriteLine("1. Папка");
        Console.WriteLine("2. Мамка");
        string select = Console.ReadLine();
        bool parse = int.TryParse(select, out var selected);
        if (parse)
        {
            switch (selected)
            {
                case 1:
                    fileinf.MoveTo(fileMamka);
                    break;
                case 2:
                    fileinf1.MoveTo(filePapka);
                    break;


            }

        }
    }
    public void WriteByteStringInFile()
    {
        Console.WriteLine("Куда записать текст");
        Console.WriteLine("1. Папка");
        Console.WriteLine("2. Мамка");
        //  FileInfo fileinf = new FileInfo(filePapka);
        // FileInfo fileinf1 = new FileInfo(fileMamka);
        string menu = Console.ReadLine();

        bool parse = int.TryParse(menu, out var selected);
        if (parse)
        {
            switch (selected)
            {
                case 1:
                    using (FileStream fstream = File.Open(filePapka, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {
                        Console.WriteLine("Что записать");
                        string select = Console.ReadLine();
                        byte[] buffer = Encoding.Default.GetBytes(select);
                        fstream.Write(buffer, 0, buffer.Length);
                        Console.WriteLine("Текст записан в файл");
                    }

                    break;
                //case 2:
                //    if (fileinf1.Exists)
                //    {
                //        using (FileStream fstream = new FileStream(fileinf1.FullName, FileMode.Open))
                //        {
                //            Console.WriteLine("Что записать");
                //            string select = Console.ReadLine();
                //            byte[] buffer = Encoding.Default.GetBytes(select);
                //            fstream.Write(buffer, 0, buffer.Length);
                //            Console.WriteLine("Текст записан в файл");
                //        }
                //    }
                //    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }

    }
    public void DeleteFile()
    {
        FileInfo fileinf = new FileInfo(filePapka);
        FileInfo fileinf1 = new FileInfo(fileMamka);
        Console.WriteLine("Где хотите удалить файл");
        Console.WriteLine("1. Папка");
        Console.WriteLine("2. Мамка");
        string select = Console.ReadLine();
        bool parse = int.TryParse(select, out var selected);
        switch (selected)
        {
            case 1:
                if (fileinf.Exists)
                {
                    fileinf.Delete();
                    Console.WriteLine();
                    Console.WriteLine("Документ удалён");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Документа нет в файле");
                    Console.WriteLine();
                }
                break;
            case 2:
                if (fileinf1.Exists)
                {
                    fileinf1.Delete();
                    Console.WriteLine();
                    Console.WriteLine("Документ удалён");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Документа нет в файле");
                    Console.WriteLine();
                }
                break;
            default:
                Console.WriteLine("Ошибка");
                break;
        }
    }
}
