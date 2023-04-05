using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте приложение «Список книг для прочтения».
//Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять
//есть ли книга в списке, и т. д. Используйте механизм свойств, перегрузки
//операторов, индексаторов.
//
namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] b = new Book[3];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Book();
                Console.WriteLine("Введите название книги: ");
                b[i].Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию автора: ");
                b[i].Author = Console.ReadLine();

              //  b[i].Code(); // свойство Code только для чтения
                Console.WriteLine("Введите год издания: ");
                b[i].Year = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", b[i].Code, b[i].Name, b[i].Author, b[i].Year);
            }
        }
    }
    class Book
    {

        static int counter = 0;
        public Book() // Конструктор класса
        {
            this.id_code = counter++;
        }
        int id_code;
        public int Code
        {
            get
            {
                return id_code;
            }
        }
        string name;
        public string Name // Свойство
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
            }
        }

        string author;
        public string Author // Свойство
        {
            get
            {
                return author;
            }
            set
            {
                if (value != "")
                    author = value;
            }
        }
        int year;
        public int Year // Свойство
        {
            get
            {
                return year;
            }
            set
            {
                if (value != 0)
                    year = value;
            }
        }
    }
}
    


