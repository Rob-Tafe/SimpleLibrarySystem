/*
 *  Program:        Simple Library System
 *  
 *  Description:    A simple library program for use in AT2,
 *                  Object oriented design and testing cluster
 *                  
 *  Author:         Robert Sewell
 *  
 *  Date:           10/09/2025
 */


using System;
using System.Text;
using System.Text.RegularExpressions;


namespace SimpleLibrarySystem
{


    public partial class SimpleLibrarySystemForm : Form
    {


        public SimpleLibrarySystemForm()
        {
            InitializeComponent();
        } // End of Form1 method


    } // End of Form1 class


    public class LibraryMembers
    {

        public int memberID {  get; set; }
        public string memberName { get; set; }
        public string memberEmail { get; set; }
        public bool memberActive { get; set; }
        public List<string> booksCheckedOut { get; set; } = new List<string>();

        /* This is the constructor that will allow us to create new instances
        *  of the LibraryMembers class and assign values to the variables manually
        *  as part of the new instance declaration
        */
        public LibraryMembers(int id, string name, string email, bool active)
        {
            memberID = id;
            memberName = name;
            memberEmail = email;
            memberActive = active;
        } // End of LibraryMembers constructor

    } // End of LibraryMembers superclass


    public class Books
    {

        public int bookID { get; set; }
        public string bookTitle { get; set; }
        public string bookAuthor { get; set; }
        public string bookPublicationDate {  get; set; }
        public string bookISBN {  get; set; }
        public string bookCheckedOutDate { get; set; }
        public string bookDueDate { get; set; }

        /* This is the constructor that will allow us to create new instances
        *  of the Books class and assign values to the variables manually
        *  as part of the new instance declaration
        */
        public Books(int id, string title, string author, string publication, string isbn, string checkedOutDate, string dueDate)
        {
            bookID = id;
            bookTitle = title;
            bookAuthor = author;
            bookPublicationDate = publication;
            bookISBN = isbn;
            bookCheckedOutDate = checkedOutDate;
            bookDueDate = dueDate;
        } // End of Books constructor

    } // End of Books superclass


    // Attributes for the BookOperations class
    // End of Attributes for the BookOperations class

    public class BookOperations
    {



    } // End of BookOperations class


    public class LibraryDataTracking
    {
        // These variables maybe shouldn't be get/set? ******
        public int bookNumberOfCopies { get; set; }
        public int bookNumberOfAvailableCopies { get; set; }

        public List<string> allBooksList { get; set; } = new List<string>();
        public List<string> allBooksBorrowedList { get; set; } = new List<string>();
        public List<string> allMembersList { get; set; } = new List<string>();
        public List<string> allMembersThatHaveBooksBorrowedList { get; set; } = new List<string>();

    } // End of LibraryDataTracking superclass


    public class PopulateData
    {
        public void populateLibraryMembers()
        {
            LibraryMembers newMember1 = new LibraryMembers(0001, "Anna", "anna@email.com", true);
            LibraryMembers newMember2 = new LibraryMembers(0002, "Brandt", "brandt@email.com", true);
            LibraryMembers newMember3 = new LibraryMembers(0003, "Cecilia", "cecilia@email.com", true);
            LibraryMembers newMember4 = new LibraryMembers(0004, "Dante", "dante@email.com", true);
            LibraryMembers newMember5 = new LibraryMembers(0005, "Eryn", "eryn@email.com", true);
        }

        public void populateBooks()
        {
            Books newBook1 = new Books(1001, "The Hobbit", "J.R.R. Tolkien", "1937", "978-0-00-748729-5", "", "");
            Books newBook2 = new Books(1002, "Pro C# 10 with .NET 6", "Andrew Troelsen, Phil Japikse", "2022", "978-1-4842-7868-0", "", "");
            Books newBook3 = new Books(1003, "Machinery's Handbook 31st Edition", "Erik Oberg, Franklin D. Jones, Holbrook L. Horton, Henry H. Ryfeel, Christopher J. McCauly", "2020", "978-0-8311-3731-1", "", "");
            Books newBook4 = new Books(1004, "War and Peace", "Leo Tolstoy", "1868", "978-0-241-26554-3", "", "");
            Books newBook5 = new Books(1005, "The Hobbit", "J.R.R. Tolkien", "1937", "978-0-00-748729-5", "", "");
            Books newBook6 = new Books(1006, "The Art of War", "Sun Tzu", "2020", "978-1-78404-202-8", "", "");

        }


    } // End of PopulateData class


} // End of SimpleLibrarySystem namespace