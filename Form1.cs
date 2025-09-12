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

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberNameAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberEmailAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberActiveAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class memberHasBooksCheckedOutAttribute : Attribute
    {

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

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookTitleAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookAuthorAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookPublicationDateAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookISBNAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookNumberOfCopiesAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookNumberOfAvailableCopiesAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookCopyTrackerAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookCheckedOutDateAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class bookDueDateAttribute : Attribute
    {

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

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class allBooksBorrowedListAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class allMembersListAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class allMembersThatHaveBooksBorrowedListAttribute : Attribute
    {

    }
    // End of Attributes for the LibraryDataTracking class

    [allBooksList, allBooksBorrowedList, allMembersList, allMembersThatHaveBooksBorrowedList]
    public class LibraryDataTracking
    {
        


    }



} // End of SimpleLibrarySystem namespace
