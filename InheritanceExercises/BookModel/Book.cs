using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercises.BookModel
{
    public class Book
    {
        protected string title;
        protected string author;
        protected string category;
        protected int year;
        protected int pages;

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Category { get { return category; } set { category = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int Pages { get { return pages; } set { pages = value; } }


        public Book()
        {
            Title = "Harry Potter & The Hydra";
            Author = "J.K Rowling";
            Category = "Fantasy, Teenager";
            Year = 2010;
            Pages = 100;
        }

        public Book(int pages)
        {
            Pages = pages;
        }

    }
}
