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
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Text.RegularExpressions;


namespace SimpleLibrarySystem
{


    // This is the form class.
    public partial class SimpleLibrarySystemForm : Form
    {

        public SimpleLibrarySystemForm()
        {
            InitializeComponent();
        } // End of SimpleLibrarySystemForm method.

        public void SimpleLibrarySystemForm_Load(object sender, EventArgs e)
        {
            PopulateData.populateLibraryMembers();
            PopulateData.populateBooks();
            TbFeedback.Text = "Data populated!";
        }

        // This method calls the allMembersListDisplay method when the user clicks
        // the "Show All Library Members" button.
        public void BtnAllMembersList_Click(object sender, EventArgs e)
        {
            allMembersListDisplay();
        } // End of BtnAllMembersList_Click method.

        // This method displays the contents of the LibraryDataTracking.allMembersList
        // list on the LbMain ListBox.
        public void allMembersListDisplay()
        {
            LbMain.Items.Clear();

            if (LibraryDataTracking.allMembersList != null)
            {
                foreach (var member in LibraryDataTracking.allMembersList)
                {
                    LbMain.Items.Add(member);
                }
            }

            TbFeedback.Text = "Currently displaying the list of library members.";
        } // End of allMembersListDisplay method.

        // 
        private void BtnAllBooks_Click(object sender, EventArgs e)
        {
            allBooksListDisplay();
        } // End of BtnAllBooks_Click method.

        // 
        public void allBooksListDisplay()
        {
            LbMain.Items.Clear();

            if (LibraryDataTracking.allBooksList != null)
            {
                foreach (var book in LibraryDataTracking.allBooksList)
                {
                    LbMain.Items.Add(book);
                }
            }

            TbFeedback.Text = "Currently displaying the list of all books in the library.";
        } // End of allBooksListDisplay method.

        // This is the search function that will use the value entered in the TbInput text box to
        // search through the list of books for the entered value.
        private void BtnSearch_Click(object sender, EventArgs e)
        {

            TbFeedback.Clear();

            string searchVal = TBInput.Text;
            bool searchValFound = false;
            TbFeedback.Text = searchVal;

            if (!string.IsNullOrEmpty(searchVal))
            {
                int lbIndex = LbMain.FindString(searchVal);

                if (lbIndex != -1)
                {
                    LbMain.SetSelected(lbIndex, true);
                }
                else
                {
                    TbFeedback.Text = "Search string did not match any item in the list.";
                }
            }

        } // End of BtnSearch_Click method.

        // This is the method that will display all information of an object the user has
        // selected in the listbox.
        private void BtnInfo_Click(object sender, EventArgs e)
        {

            TbFeedback.Clear();

            var selectedObject = LbMain.SelectedItem;

            if (selectedObject == null)
            {
                TbFeedback.Text = "You must select an item.";
                return;
            }

            LbMain.Items.Clear();

            if (selectedObject is LibraryMembers member)
            {
                LbMain.Items.Add($"Member ID: {member.memberID}");
                LbMain.Items.Add($"Name: {member.memberName}");
                LbMain.Items.Add($"Email: {member.memberEmail}");
                LbMain.Items.Add($"Active: {member.memberActive}");
                LbMain.Items.Add("Books Checked Out:");
                if (member.booksCheckedOut.Count > 0)
                {
                    foreach (var book in member.booksCheckedOut)
                    {
                        LbMain.Items.Add($"  - {book}");
                    }
                }
                else
                {
                    LbMain.Items.Add("  - (No boooks checked out)");
                }

                TbFeedback.Text = $"Details for member: {member.memberName}";
            }
            else if (selectedObject is Books book)
            {
                LbMain.Items.Add($"Book ID: {book.bookID}");
                LbMain.Items.Add($"Title: {book.bookTitle}");
                LbMain.Items.Add($"Author: {book.bookAuthor}");
                LbMain.Items.Add($"Publication Date: {book.bookPublicationDate}");
                LbMain.Items.Add($"ISBN: {book.bookISBN}");
                LbMain.Items.Add($"Checked Out Date: {book.bookCheckedOutDate}");
                LbMain.Items.Add($"Due Date: {book.bookDueDate}");

                TbFeedback.Text = $"Details for book: {book.bookTitle}";
            }
            else
            {
                LbMain.Items.Add("Unknown object type selected.");
                TbFeedback.Text = $"Error: Selected object type not recognised.";
            }

        } // End of BtnInfo_Click method.

        private void BtnBorrow_Click(object sender, EventArgs e)
        {

            if (LbMain.SelectedItem is Books book)
            {

                if (book.bookCheckedOutDate == null || book.bookCheckedOutDate == string.Empty)
                {
                    book.bookCheckedOutDate = $"{DateOnly.FromDateTime(DateTime.Now)}";
                    book.bookDueDate = $"{DateOnly.FromDateTime(DateTime.Now.AddDays(14))}";
                    LibraryDataTracking.allBooksBorrowedList.Add(book);
                }
                else
                {
                    TbFeedback.Text = "You cannot borrow this book presently. Selected book is already checked out.";
                }

            }
            else
            {
                TbFeedback.Text = "Selected item is not a book.";
            }

        } // End of BtnBorrow_Click method.


        private void BtnAllBorrowedBooks_Click(object sender, EventArgs e)
        {

            allBooksBorrowedListDisplay();

        } // End of BtnAllBorrowedBooks_Click method.


        public void allBooksBorrowedListDisplay()
        {
            LbMain.Items.Clear();

            if (LibraryDataTracking.allBooksBorrowedList != null && LibraryDataTracking.allBooksBorrowedList.Count != 0)
            {
                TbFeedback.Text = "Currently displaying the list of all books in the library.";

                foreach (var borrowedBook in LibraryDataTracking.allBooksBorrowedList)
                {
                    LbMain.Items.Add(borrowedBook);
                }
            }
            else
            {
                TbFeedback.Text = "No books currently borrowed.";
            }

        } // End of allBooksBorrowedListDisplay method.

    } // End of SimpleLibrarySystemForm class.


    // This is out member blueprint class. It lays out the format & data that our member
    // objects will inherit.
    public class LibraryMembers
    {

        public int memberID {  get; set; }
        public string memberName { get; set; }
        public string memberEmail { get; set; }
        public bool memberActive { get; set; }
        public List<string> booksCheckedOut { get; set; } = new List<string>();

        /* This is the constructor that will allow us to create new instances
        *  of the LibraryMembers class and assign values to the variables manually
        *  as part of the new instance declaration.
        */
        public LibraryMembers(int id, string name, string email, bool active)
        {
            memberID = id;
            memberName = name;
            memberEmail = email;
            memberActive = active;
        } // End of LibraryMembers constructor.

        // This is the override string that will display when we call the
        // allMembersListDisplay method.
        public override string ToString()
        {
            return $"{memberName} \tID: {memberID} \t{memberEmail}";
        } // End of LibraryMembers override.

    } // End of LibraryMembers superclass.


    // This is our book blueprint class. It lays out the format & data that our book objects.
    // will inherit.
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
        *  as part of the new instance declaration.
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
        } // End of Books constructor.

        //
        public override string ToString()
        {
            return $"{bookTitle} \t{bookISBN} \t(ID: {bookID})";
        }

    } // End of Books superclass.


    // Attributes for the BookOperations class.
    // End of Attributes for the BookOperations class.

    public static class BookOperations
    {

        

    } // End of BookOperations class.


    public static class LibraryDataTracking
    {
        // These variables maybe shouldn't be get/set? ******
        public static int bookNumberOfCopies { get; set; }
        public static int bookNumberOfAvailableCopies { get; set; }

        public static List<Books> allBooksList = new List<Books>();
        public static List<Books> allBooksBorrowedList = new List<Books>();
        public static List<LibraryMembers> allMembersList = new List<LibraryMembers>();
        public static List<string> allMembersThatHaveBooksBorrowedList = new List<string>();

    } // End of LibraryDataTracking superclass.


    // This class is responsible for populating the data that our library system will use.
    public static class PopulateData
    {

        // This is the method responsible for populating the LibraryMembers list with data.
        public static void populateLibraryMembers()
        {
            LibraryMembers newMember1 = new LibraryMembers(0001, "Anna", "anna@email.com", true);
            LibraryDataTracking.allMembersList.Add(newMember1);
            LibraryMembers newMember2 = new LibraryMembers(0002, "Brandt", "brandt@email.com", true);
            LibraryDataTracking.allMembersList.Add(newMember2);
            LibraryMembers newMember3 = new LibraryMembers(0003, "Cecilia", "cecilia@email.com", true);
            LibraryDataTracking.allMembersList.Add(newMember3);
            LibraryMembers newMember4 = new LibraryMembers(0004, "Dante", "dante@email.com", true);
            LibraryDataTracking.allMembersList.Add(newMember4);
            LibraryMembers newMember5 = new LibraryMembers(0005, "Eryn", "eryn@email.com", true);
            LibraryDataTracking.allMembersList.Add(newMember5);
        } // End of populateLibraryMembers method.

        // This method is responsible for populating the Books list with data.
        public static void populateBooks()
        {
            Books newBook1 = new Books(1001, "The Hobbit", "J.R.R. Tolkien", "1937", "978-0-00-748729-5", "", "");
            LibraryDataTracking.allBooksList.Add(newBook1);
            Books newBook2 = new Books(1002, "Pro C# 10 with .NET 6", "Andrew Troelsen, Phil Japikse", "2022", "978-1-4842-7868-0", "", "");
            LibraryDataTracking.allBooksList.Add(newBook2);
            Books newBook3 = new Books(1003, "Machinery's Handbook 31st Edition", "Erik Oberg, Franklin D. Jones, Holbrook L. Horton, Henry H. Ryfeel, Christopher J. McCauly", "2020", "978-0-8311-3731-1", "", "");
            LibraryDataTracking.allBooksList.Add(newBook3);
            Books newBook4 = new Books(1004, "War and Peace", "Leo Tolstoy", "1868", "978-0-241-26554-3", "", "");
            LibraryDataTracking.allBooksList.Add(newBook4);
            Books newBook5 = new Books(1005, "The Hobbit", "J.R.R. Tolkien", "1937", "978-0-00-748729-5", "", "");
            LibraryDataTracking.allBooksList.Add(newBook5);
            Books newBook6 = new Books(1006, "The Art of War", "Sun Tzu", "2020", "978-1-78404-202-8", "", "");
            LibraryDataTracking.allBooksList.Add(newBook6);

        } // End of populateBooks method.

    } // End of PopulateData class.


} // End of SimpleLibrarySystem namespace.