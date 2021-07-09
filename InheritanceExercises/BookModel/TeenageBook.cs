using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.BookModel
{
    public class TeenageBook : Book
    {
        static List<TeenageBook> teenageBooks = new List<TeenageBook>();

        public static List<TeenageBook> GetTeenageBooks()
        {
            return teenageBooks;
        }

        public static void AddTeenageBook(TeenageBook teenageBook)
        {
            teenageBooks.Add(teenageBook);
        }

        public static string SearchTeenageBook(string title)
        {
            string returnString = "Book does not exist";

            foreach (TeenageBook book in teenageBooks)
            {
                if(book.Title == title)
                {
                    returnString = $"Title: {book.Title}\nAuthor: {book.Author}\nCategory: {book.Category}\nYear: {book.Year}\nPages: {book.Pages}";
                    break;
                }
            }

            return returnString;
        }
    }
}
