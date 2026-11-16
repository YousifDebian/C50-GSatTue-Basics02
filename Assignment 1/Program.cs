namespace Assignment_1
{
    class Book
    {
        public string? Title { get; set; }
        public int Pages { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.

            object book = new Book { Title = "C# Basics", Pages = 400 };
            Console.WriteLine(book);

            #endregion
        }
    }
}
