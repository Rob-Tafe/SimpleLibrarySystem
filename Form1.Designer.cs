namespace SimpleLibrarySystem
{
    partial class SimpleLibrarySystemForm
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
            BtnInfo = new Button();
            BtnLogInOut = new Button();
            SuspendLayout();
            // 
            // LbMain
            // 
            LbMain.FormattingEnabled = true;
            LbMain.ItemHeight = 15;
            LbMain.Location = new Point(130, 53);
            LbMain.Name = "LbMain";
            LbMain.Size = new Size(360, 289);
            LbMain.TabIndex = 0;
            // 
            // TBInput
            // 
            TBInput.Location = new Point(130, 15);
            TBInput.Name = "TBInput";
            TBInput.Size = new Size(254, 23);
            TBInput.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(390, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(100, 23);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnBorrow
            // 
            BtnBorrow.Location = new Point(15, 131);
            BtnBorrow.Name = "BtnBorrow";
            BtnBorrow.Size = new Size(100, 55);
            BtnBorrow.TabIndex = 3;
            BtnBorrow.Text = "Borrow Book";
            BtnBorrow.UseVisualStyleBackColor = true;
            BtnBorrow.Click += BtnBorrow_Click;
            // 
            // BtnReturn
            // 
            BtnReturn.Location = new Point(15, 211);
            BtnReturn.Name = "BtnReturn";
            BtnReturn.Size = new Size(100, 55);
            BtnReturn.TabIndex = 4;
            BtnReturn.Text = "Return Book";
            BtnReturn.UseVisualStyleBackColor = true;
            BtnReturn.Click += BtnReturn_Click;
            // 
            // BtnCurrentlyBorrowed
            // 
            BtnCurrentlyBorrowed.Location = new Point(15, 288);
            BtnCurrentlyBorrowed.Name = "BtnCurrentlyBorrowed";
            BtnCurrentlyBorrowed.Size = new Size(100, 55);
            BtnCurrentlyBorrowed.TabIndex = 5;
            BtnCurrentlyBorrowed.Text = "My Currently Borrowed Books";
            BtnCurrentlyBorrowed.UseVisualStyleBackColor = true;
            BtnCurrentlyBorrowed.Click += BtnCurrentlyBorrowed_Click;
            // 
            // BtnAllBooks
            // 
            BtnAllBooks.Location = new Point(505, 125);
            BtnAllBooks.Name = "BtnAllBooks";
            BtnAllBooks.Size = new Size(100, 55);
            BtnAllBooks.TabIndex = 6;
            BtnAllBooks.Text = "Show All Books";
            BtnAllBooks.UseVisualStyleBackColor = true;
            BtnAllBooks.Click += BtnAllBooks_Click;
            // 
            // BtnAllBorrowedBooks
            // 
            BtnAllBorrowedBooks.Location = new Point(505, 201);
            BtnAllBorrowedBooks.Name = "BtnAllBorrowedBooks";
            BtnAllBorrowedBooks.Size = new Size(100, 55);
            BtnAllBorrowedBooks.TabIndex = 7;
            BtnAllBorrowedBooks.Text = "Show All Borrowed Books";
            BtnAllBorrowedBooks.UseVisualStyleBackColor = true;
            BtnAllBorrowedBooks.Click += BtnAllBorrowedBooks_Click;
            // 
            // BtnAllMembersList
            // 
            BtnAllMembersList.Location = new Point(505, 53);
            BtnAllMembersList.Name = "BtnAllMembersList";
            BtnAllMembersList.Size = new Size(100, 55);
            BtnAllMembersList.TabIndex = 8;
            BtnAllMembersList.Text = "Show All Library Members";
            BtnAllMembersList.UseVisualStyleBackColor = true;
            BtnAllMembersList.Click += BtnAllMembersList_Click;
            // 
            // BtnAllMembersWithBorrowed
            // 
            BtnAllMembersWithBorrowed.Location = new Point(505, 273);
            BtnAllMembersWithBorrowed.Name = "BtnAllMembersWithBorrowed";
            BtnAllMembersWithBorrowed.Size = new Size(100, 70);
            BtnAllMembersWithBorrowed.TabIndex = 9;
            BtnAllMembersWithBorrowed.Text = "Show All Members With Borrowed Books";
            BtnAllMembersWithBorrowed.UseVisualStyleBackColor = true;
            BtnAllMembersWithBorrowed.Click += BtnAllMembersWithBorrowed_Click;
            // 
            // TbFeedback
            // 
            TbFeedback.Location = new Point(15, 357);
            TbFeedback.Name = "TbFeedback";
            TbFeedback.ReadOnly = true;
            TbFeedback.Size = new Size(590, 23);
            TbFeedback.TabIndex = 10;
            // 
            // BtnInfo
            // 
            BtnInfo.Location = new Point(15, 53);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new Size(100, 55);
            BtnInfo.TabIndex = 11;
            BtnInfo.Text = "Display Info of Selected Item";
            BtnInfo.UseVisualStyleBackColor = true;
            BtnInfo.Click += BtnInfo_Click;
            // 
            // BtnLogInOut
            // 
            BtnLogInOut.Location = new Point(505, 15);
            BtnLogInOut.Name = "BtnLogInOut";
            BtnLogInOut.Size = new Size(100, 23);
            BtnLogInOut.TabIndex = 12;
            BtnLogInOut.Text = "Login / Logout";
            BtnLogInOut.UseVisualStyleBackColor = true;
            BtnLogInOut.Click += BtnLogInOut_Click;
            // 
            // SimpleLibrarySystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 396);
            Controls.Add(BtnLogInOut);
            Controls.Add(BtnInfo);
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
            Name = "SimpleLibrarySystemForm";
            Text = "Simple Library System";
            Load += SimpleLibrarySystemForm_Load;
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
        private Button BtnInfo;
        private Button BtnLogInOut;
    }
}
