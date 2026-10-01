using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace FileDz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.InputEncoding = Encoding.UTF8;

            //// ======== TASK 2 ========
            //Console.WriteLine("Введіть шлях до папки:");
            //string path = Console.ReadLine() ?? string.Empty;

            //Console.WriteLine("Введіть маску файлів (наприклад, *.txt):");
            //string pattern = Console.ReadLine() ?? "*.*";

            //if (Directory.Exists(path))
            //{
            //    List<string> files = Directory.GetFiles(path, pattern, SearchOption.AllDirectories).ToList();
            //    foreach (string file in files)
            //        Console.WriteLine(file);
            //}
            //else
            //    Console.WriteLine("Папка не існує.");



            //// ======== TASK 3 ========
            //Console.WriteLine("Введіть шлях до папки для видалення:");
            //string path = Console.ReadLine() ?? string.Empty;

            //Console.WriteLine("Введіть маску файлів (наприклад, *.txt):");
            //string pattern = Console.ReadLine() ?? "*.*";

            //if (Directory.Exists(path))
            //{
            //    string[] files = Directory.GetFiles(path, pattern, SearchOption.AllDirectories);
            //    foreach (string file in files)
            //        File.Delete(file);
            //}
            //else
            //    Console.WriteLine("Папка не існує.");



            //// ======== TASK 4 ========
            //Console.Write("Введіть назву ресторану: ");
            //string name = Console.ReadLine() ?? "";

            //string pattern = @"^[^%&()]+$";

            //if (Regex.IsMatch(name, pattern))
            //    Console.WriteLine("Назва коректна!");
            //else
            //    Console.WriteLine("Помилка: назва порожня або містить заборонені символи");



            //// ======== TASK 5 ========
            //Console.Write("Введіть адресу: ");
            //string address = Console.ReadLine() ?? "";

            //string pattern = @"^[a-zA-Z\d]+$";

            //if(Regex.IsMatch(address, pattern))
            //    Console.WriteLine("Адреса коректна!");
            //else
            //    Console.WriteLine("Помилка: адреса порожня або містить заборонені символи");



            //// ======== TASK 6 ========
            //Console.Write("Введіть назву кухні ресторану: ");
            //string cuisine = Console.ReadLine() ?? "";

            //string pattern = @"^[a-zA-Z]+$";

            //if (Regex.IsMatch(cuisine, pattern))
            //    Console.WriteLine("Назва кухні коректна!");
            //else
            //    Console.WriteLine("Помилка: назва кухні порожня або містить заборонені символи");



            //// ======== TASK 7 ========
            //Console.Write("Введіть оцінку роботи ресторану: ");
            //string rating = Console.ReadLine() ?? "";

            //string pattern = @"^(1[0-2]|[1-9])$";

            //Console.WriteLine(Regex.IsMatch(rating, pattern) ? "Оцінка коректна!" : "Помилка");



            //// ======== TASK 8 ========
            //Console.Write("Нік: ");
            //string nick = Console.ReadLine();
            //if (!Regex.IsMatch(nick, @"^[a-zA-Z0-9_]{3,20}$"))
            //{
            //    Console.WriteLine("Помилка в ніку!");
            //    return;
            //}

            //Console.Write("Email: ");
            //string email = Console.ReadLine();
            //if (!Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w{2,}$"))
            //{
            //    Console.WriteLine("Помилка в email!");
            //    return;
            //}

            //Console.Write("Ваш телефон: ");
            //string userPhone = Console.ReadLine();
            //if (!Regex.IsMatch(userPhone, @"^(\+?38)?0\d{9}$"))
            //{
            //    Console.WriteLine("Помилка в номері телефону!");
            //    return;
            //}

            //Console.Write("Назва ресторану: ");
            //string name = Console.ReadLine();
            //if (!Regex.IsMatch(name, @"^[^%&()]+$"))
            //{
            //    Console.WriteLine("Помилка в назві ресторану!");
            //    return;
            //}

            //Console.Write("Адреса ресторану: ");
            //string address = Console.ReadLine();
            //if (!Regex.IsMatch(address, @"^[a-zA-Zа-яА-ЯіІїЇєЄґҐ0-9\s\.,'-]+$"))
            //{
            //    Console.WriteLine("Помилка в адресі!");
            //    return;
            //}

            //Console.Write("Кухня: ");
            //string cuisine = Console.ReadLine();
            //if (!Regex.IsMatch(cuisine, @"^[a-zA-Zа-яА-ЯіІїЇєЄґҐ\s-]+$"))
            //{
            //    Console.WriteLine("Помилка в назві кухні!");
            //    return;
            //}

            //Console.Write("Телефон ресторану: ");
            //string restPhone = Console.ReadLine();
            //if (!Regex.IsMatch(restPhone, @"^(\+?38)?0\d{9}$"))
            //{
            //    Console.WriteLine("Помилка в телефоні ресторану!");
            //    return;
            //}

            //Console.Write("Оцінка (1-12): ");
            //string rating = Console.ReadLine();
            //if (!Regex.IsMatch(rating, @"^(1[0-2]|[1-9])$"))
            //{
            //    Console.WriteLine("Помилка! Оцінка має бути від 1 до 12.");
            //    return;
            //}

            //Console.Write("Відгук: ");
            //string review = Console.ReadLine();
            //if (!Regex.IsMatch(review, @"^.{5,}$"))
            //{
            //    Console.WriteLine("Відгук занадто короткий (мінімум 5 символів)!");
            //    return;
            //}

            //string data = $"{nick}; {email}; {userPhone}; {name}; {address}; {cuisine}; {restPhone}; Оцінка: {rating}; Відгук: {review}\n";

            //File.AppendAllText("reviews.txt", data);
            //Console.WriteLine("\nДані успішно збережено у файл reviews.txt!");
        }
    }
}
