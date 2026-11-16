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

            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);

            #endregion

            #region Question 8

            /* Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
                use int.TryParse() to safely try converting it, and print "Invalid number" if it fails. */

            //string yearText = "2023";
            //int year = int.Parse(yearText);

            //string badText = "abc";
            //if (!int.TryParse(badText, out int result))
            //    Console.WriteLine("Invalid number");

            #endregion

            #region Question 9

            /* Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
                 to prove it's now a string. */

            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType());

            #endregion

            #region Question 10

            /* Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
                variable, and print both. */

            //int copies = 100;
            //object boxed = copies;
            //int unboxed = (int)boxed;
            //Console.WriteLine(boxed);
            //Console.WriteLine(unboxed);

            #endregion

            #region Question 11

            /* Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value. */

            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year);

            #endregion

            #region Question 12

            /* Q12. Declare a string? reviewer = null;. Print whether it is null. */

            //string? reviewer = null;
            //Console.WriteLine(reviewer == null);

            #endregion

            #region Question 13

            /* Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and
                print the result. */

            Book? book = null;
            Console.WriteLine(book?.Title);

            #endregion
        }
    }
}
