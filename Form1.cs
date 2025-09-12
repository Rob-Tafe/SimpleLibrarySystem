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



    // Attributes for the LibraryMembers class
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberIDAttribute : Attribute
    {
        string memberID = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberNameAttribute : Attribute
    {
        string memberName = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberEmailAttribute : Attribute
    {
        string memberEmail = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberActiveAttribute : Attribute
    {
        Boolean memberActive;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberHasBooksCheckedOutAttribute : Attribute
    {
        // List memberHasTheseBooksCheckedOut;
    }
    // End of Attributes for the LibraryMembers class

    [memberID, memberName, memberEmail, memberActive, memberHasBooksCheckedOut]
    public class LibraryMembers
    {



    }



    // Attributes for the Books class
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookIDAttribute : Attribute
    {
        int bookID;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookTitleAttribute : Attribute
    {
        string bookTitle = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookAuthorAttribute : Attribute
    {
        string bookAuthor = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookPublicationDateAttribute : Attribute
    {
        string bookPublicationDate = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookISBNAttribute : Attribute
    {
        string bookISBN = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookNumberOfCopiesAttribute : Attribute
    {
        int bookNumberOfCopies;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookNumberOfAvailableCopiesAttribute : Attribute
    {
        int bookNumberOfAvailableCopies;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookCopyTrackerAttribute : Attribute
    {
        // List bookCopyTracker;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookCheckedOutDateAttribute : Attribute
    {
        string bookCheckedOutDate = string.Empty;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookDueDateAttribute : Attribute
    {
        string bookDueDate = string.Empty;
    }
    // End of Attributes for the Books class

    [bookID, bookTitle, bookAuthor, bookPublicationDate, bookISBN, bookNumberOfCopies, 
        bookNumberOfAvailableCopies, bookCopyTracker, bookCheckedOutDate, bookDueDate]
    public class Books
    {



    }



    // Attributes for the BookOperations class
    // End of Attributes for the BookOperations class

    public class BookOperations
    {



    }



    // Attributes for the LibraryDataTracking class
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class allBooksListAttribute : Attribute
    {
        // List allBooksList;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class allBooksBorrowedListAttribute : Attribute
    {
        // List allBooksBorrowed;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class allMembersListAttribute : Attribute
    {
        // List allMembersList;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class allMembersThatHaveBooksBorrowedListAttribute : Attribute
    {
        // List allMembersThatHaveBooksBorrowed;
    }
    // End of Attributes for the LibraryDataTracking class

    [allBooksList, allBooksBorrowedList, allMembersList, allMembersThatHaveBooksBorrowedList]
    public class LibraryDataTracking
    {
        


    }



} // End of SimpleLibrarySystem namespace
