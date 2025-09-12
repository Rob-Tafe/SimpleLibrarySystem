namespace SimpleLibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbMain = new ListBox();
            TBInput = new TextBox();
            BtnSearch = new Button();
            BtnBorrow = new Button();
            BtnReturn = new Button();
            BtnCurrentlyBorrowed = new Button();
            BtnAllBooks = new Button();
            BtnAllBorrowedBooks = new Button();
            BtnAllMembersList = new Button();
            BtnAllMembersWithBorrowed = new Button();
            TbFeedback = new TextBox();
            SuspendLayout();
            // 
            // LbMain
            // 
            LbMain.FormattingEnabled = true;
            LbMain.ItemHeight = 15;
            LbMain.Location = new Point(160, 75);
            LbMain.Name = "LbMain";
            LbMain.Size = new Size(300, 259);
            LbMain.TabIndex = 0;
            // 
            // TBInput
            // 
            TBInput.Location = new Point(160, 30);
            TBInput.Name = "TBInput";
            TBInput.Size = new Size(300, 23);
            TBInput.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(30, 30);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(100, 55);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnBorrow
            // 
            BtnBorrow.Location = new Point(30, 110);
            BtnBorrow.Name = "BtnBorrow";
            BtnBorrow.Size = new Size(100, 55);
            BtnBorrow.TabIndex = 3;
            BtnBorrow.Text = "Borrow Book";
            BtnBorrow.UseVisualStyleBackColor = true;
            // 
            // BtnReturn
            // 
            BtnReturn.Location = new Point(30, 190);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(100, 55);
            BtnReturn.TabIndex = 4;
            BtnReturn.Text = "Return Book";
            BtnReturn.UseVisualStyleBackColor = true;
            // 
            // BtnCurrentlyBorrowed
            // 
            BtnCurrentlyBorrowed.Location = new Point(30, 270);
            BtnCurrentlyBorrowed.Name = "BtnCurrentlyBorrowed";
            BtnCurrentlyBorrowed.Size = new Size(100, 55);
            BtnCurrentlyBorrowed.TabIndex = 5;
            BtnCurrentlyBorrowed.Text = "My Currently Borrowed Books";
            BtnCurrentlyBorrowed.UseVisualStyleBackColor = true;
            // 
            // BtnAllBooks
            // 
            BtnAllBooks.Location = new Point(490, 45);
            BtnAllBooks.Name = "BtnAllBooks";
            BtnAllBooks.Size = new Size(100, 55);
            BtnAllBooks.TabIndex = 6;
            BtnAllBooks.Text = "Show All Books";
            BtnAllBooks.UseVisualStyleBackColor = true;
            // 
            // BtnAllBorrowedBooks
            // 
            BtnAllBorrowedBooks.Location = new Point(490, 115);
            BtnAllBorrowedBooks.Name = "BtnAllBorrowedBooks";
            BtnAllBorrowedBooks.Size = new Size(100, 55);
            BtnAllBorrowedBooks.TabIndex = 7;
            BtnAllBorrowedBooks.Text = "Show All Borrowed Books";
            BtnAllBorrowedBooks.UseVisualStyleBackColor = true;
            // 
            // BtnAllMembersList
            // 
            BtnAllMembersList.Location = new Point(490, 190);
            BtnAllMembersList.Name = "BtnAllMembersList";
            BtnAllMembersList.Size = new Size(100, 55);
            BtnAllMembersList.TabIndex = 8;
            BtnAllMembersList.Text = "Show All Library Members";
            BtnAllMembersList.UseVisualStyleBackColor = true;
            // 
            // BtnAllMembersWithBorrowed
            // 
            BtnAllMembersWithBorrowed.Location = new Point(490, 265);
            BtnAllMembersWithBorrowed.Name = "BtnAllMembersWithBorrowed";
            BtnAllMembersWithBorrowed.Size = new Size(100, 70);
            BtnAllMembersWithBorrowed.TabIndex = 9;
            BtnAllMembersWithBorrowed.Text = "Show All Members With Borrowed Books";
            BtnAllMembersWithBorrowed.UseVisualStyleBackColor = true;
            // 
            // TbFeedback
            // 
            TbFeedback.Location = new Point(30, 350);
            TbFeedback.Name = "TbFeedback";
            TbFeedback.ReadOnly = true;
            TbFeedback.Size = new Size(560, 23);
            TbFeedback.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 399);
            Controls.Add(TbFeedback);
            Controls.Add(BtnAllMembersWithBorrowed);
            Controls.Add(BtnAllMembersList);
            Controls.Add(BtnAllBorrowedBooks);
            Controls.Add(BtnAllBooks);
            Controls.Add(BtnCurrentlyBorrowed);
            Controls.Add(BtnReturn);
            Controls.Add(BtnBorrow);
            Controls.Add(BtnSearch);
            Controls.Add(TBInput);
            Controls.Add(LbMain);
            Name = "Form1";
            Text = "Simple Library System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbMain;
        private TextBox TBInput;
        private Button BtnSearch;
        private Button BtnBorrow;
        private Button BtnReturn;
        private Button BtnCurrentlyBorrowed;
        private Button BtnAllBooks;
        private Button BtnAllBorrowedBooks;
        private Button BtnAllMembersList;
        private Button BtnAllMembersWithBorrowed;
        private TextBox TbFeedback;
    }
}
