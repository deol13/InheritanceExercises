using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.BookModel
{
    public class ChildBook : Book
    {
        static List<ChildBook> childBooks = new List<ChildBook>();

        public static List<ChildBook> GetChildBooks()
        {
            return childBooks;
        }

        public static void AddChildBook(ChildBook childBook)
        {
            childBooks.Add(childBook);
        }
    }
}
