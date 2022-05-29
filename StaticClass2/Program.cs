namespace MyApp
{
    internal class Program
    {
        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Поиск по строке  " + str);
            }

        }
        static class FindAndReplaceManager
        {
            static public void FindNext(string str)
            {
                Book book = new Book();
                book.FindNext(str);
            }
        }

        static void Main(string[] args)
        {

            /*Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется:
            Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для
            поиска по книге из примера урока 005_Delegation.При вызове этого метода, производится
            последовательный поиск строки в книге.*/
            FindAndReplaceManager.FindNext("hello");
           


                    


        }
    }
}