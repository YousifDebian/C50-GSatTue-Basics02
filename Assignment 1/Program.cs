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

            //object book = new Book { Title = "C# Basics", Pages = 400 };
            //Console.WriteLine(book);

            #endregion

            #region Question 2

            // Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book. 

            //Book book = new Book { Title = "C# Basics", Pages = 400 };
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            #endregion

            #region Question 3

            /* Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
                int pages = "464";*/

            // compile-time error, Sol :-
            //int pages = 464;

            #endregion

            #region Question 4

            /* Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by 
                    zero", and then prints "Done" in a finally block.*/

            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    Console.WriteLine(x / y);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}


            #endregion

            #region Question 5

            // Q05. Declare an int pages = 300; then store it in a double variable without using a cast.

            //int pages = 300;
            //double dpages = pages;

            #endregion

            #region Question 6

            // Q06. Declare a double price = 49.99; then convert it into an int using a cast

            //double price = 49.99;
            //int p = (int)price;

            //Console.WriteLine(p);

            #endregion

            #region Question 7

            // Given string pagesText = "464";, convert it into an int using the Convert class.

            string pagesText = "464";
            int pages = Convert.ToInt32(pagesText);

            #endregion
        }
    }
}
