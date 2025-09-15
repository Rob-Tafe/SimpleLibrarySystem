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


namespace SimpleLibrarySystem
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        } // End of Form1 method


    } // End of Form1 class


    public class LibraryMembers
    {

        public string memberID {  get; set; }
        public string memberName { get; set; }
        public string memberEmail { get; set; }
        public bool memberActive { get; set; }
        public List<string> booksCheckedOut { get; set; } = new List<string>();

    }


    public class Books
    {

        public string bookIDAttribute { get; set; }
        public string bookTitleAttribute { get; set; }
        public string bookAuthorAttribute { get; set; }
        public string bookPublicationDate {  get; set; }
        public string bookISBN {  get; set; }
        public int bookNumberOfCopies { get; set; }
        public int bookNumberOfAvailableCopies { get; set; }
        public string bookCheckedOutDate { get; set; }
        public string bookDueDate { get; set; }

    }


    // Attributes for the BookOperations class
    // End of Attributes for the BookOperations class

    public class BookOperations
    {



    }


    public class LibraryDataTracking
    {

        public List<string> allBooksList { get; set; } = new List<string>();
        public List<string> allBooksBorrowedList { get; set; } = new List<string>();
        public List<string> allMembersList { get; set; } = new List<string>();
        public List<string> allMembersThatHaveBooksBorrowedList { get; set; } = new List<string>();

    }


} // End of SimpleLibrarySystem namespace
