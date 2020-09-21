namespace WindowsLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTab = new System.Windows.Forms.TabControl();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.BooksPage = new System.Windows.Forms.TabPage();
            this.BooksGrid = new System.Windows.Forms.DataGridView();
            this.BorrowsPage = new System.Windows.Forms.TabPage();
            this.BorrowsGrid = new System.Windows.Forms.DataGridView();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.mtbPesel = new System.Windows.Forms.MaskedTextBox();
            this.lbPesel = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.lbAddedDate = new System.Windows.Forms.Label();
            this.dtAddedDate = new System.Windows.Forms.DateTimePicker();
            this.lbBorrowDate = new System.Windows.Forms.Label();
            this.dtBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteBorrow = new System.Windows.Forms.Button();
            this.tbBorrowId = new System.Windows.Forms.TextBox();
            this.btnEditBorrow = new System.Windows.Forms.Button();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.lbBook = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.tbBook = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.cbReturn = new System.Windows.Forms.CheckBox();
            this.MainTab.SuspendLayout();
            this.UsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.BooksPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).BeginInit();
            this.BorrowsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.UsersPage);
            this.MainTab.Controls.Add(this.BooksPage);
            this.MainTab.Controls.Add(this.BorrowsPage);
            this.MainTab.Location = new System.Drawing.Point(0, -1);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1016, 451);
            this.MainTab.TabIndex = 0;
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.btnDeleteUser);
            this.UsersPage.Controls.Add(this.tbUserId);
            this.UsersPage.Controls.Add(this.btnEditUser);
            this.UsersPage.Controls.Add(this.btnAddUser);
            this.UsersPage.Controls.Add(this.lbBirthDate);
            this.UsersPage.Controls.Add(this.lbPesel);
            this.UsersPage.Controls.Add(this.mtbPesel);
            this.UsersPage.Controls.Add(this.lbLastName);
            this.UsersPage.Controls.Add(this.lbFirstName);
            this.UsersPage.Controls.Add(this.dtBirthDate);
            this.UsersPage.Controls.Add(this.tbLastName);
            this.UsersPage.Controls.Add(this.tbFirstName);
            this.UsersPage.Controls.Add(this.UsersGrid);
            this.UsersPage.Location = new System.Drawing.Point(4, 25);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(1008, 422);
            this.UsersPage.TabIndex = 0;
            this.UsersPage.Text = "Użytkownicy";
            this.UsersPage.UseVisualStyleBackColor = true;
            this.UsersPage.Enter += new System.EventHandler(this.LoadUsersGrid);
            // 
            // UsersGrid
            // 
            this.UsersGrid.AllowUserToAddRows = false;
            this.UsersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(0, 0);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.ReadOnly = true;
            this.UsersGrid.RowHeadersWidth = 51;
            this.UsersGrid.RowTemplate.Height = 24;
            this.UsersGrid.Size = new System.Drawing.Size(743, 419);
            this.UsersGrid.TabIndex = 0;
            this.UsersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGrid_CellDoubleClick);
            this.UsersGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DeleteRowUsersGrid);
            // 
            // BooksPage
            // 
            this.BooksPage.Controls.Add(this.lbAddedDate);
            this.BooksPage.Controls.Add(this.dtAddedDate);
            this.BooksPage.Controls.Add(this.tbPublisher);
            this.BooksPage.Controls.Add(this.btnDeleteBook);
            this.BooksPage.Controls.Add(this.tbBookId);
            this.BooksPage.Controls.Add(this.btnEditBook);
            this.BooksPage.Controls.Add(this.btnAddBook);
            this.BooksPage.Controls.Add(this.lbPublisher);
            this.BooksPage.Controls.Add(this.lbAuthor);
            this.BooksPage.Controls.Add(this.lbTitle);
            this.BooksPage.Controls.Add(this.tbAuthor);
            this.BooksPage.Controls.Add(this.tbTitle);
            this.BooksPage.Controls.Add(this.BooksGrid);
            this.BooksPage.Location = new System.Drawing.Point(4, 25);
            this.BooksPage.Name = "BooksPage";
            this.BooksPage.Padding = new System.Windows.Forms.Padding(3);
            this.BooksPage.Size = new System.Drawing.Size(1008, 422);
            this.BooksPage.TabIndex = 1;
            this.BooksPage.Text = "Książki";
            this.BooksPage.UseVisualStyleBackColor = true;
            this.BooksPage.Enter += new System.EventHandler(this.LoadBooksGrid);
            // 
            // BooksGrid
            // 
            this.BooksGrid.AllowUserToAddRows = false;
            this.BooksGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGrid.Location = new System.Drawing.Point(0, 2);
            this.BooksGrid.Name = "BooksGrid";
            this.BooksGrid.ReadOnly = true;
            this.BooksGrid.RowHeadersWidth = 51;
            this.BooksGrid.RowTemplate.Height = 24;
            this.BooksGrid.Size = new System.Drawing.Size(743, 419);
            this.BooksGrid.TabIndex = 1;
            this.BooksGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksGrid_CellDoubleClick);
            this.BooksGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DeleteRowBooksGrid);
            // 
            // BorrowsPage
            // 
            this.BorrowsPage.Controls.Add(this.cbReturn);
            this.BorrowsPage.Controls.Add(this.lbReturnDate);
            this.BorrowsPage.Controls.Add(this.dtReturnDate);
            this.BorrowsPage.Controls.Add(this.lbBorrowDate);
            this.BorrowsPage.Controls.Add(this.dtBorrowDate);
            this.BorrowsPage.Controls.Add(this.btnDeleteBorrow);
            this.BorrowsPage.Controls.Add(this.tbBorrowId);
            this.BorrowsPage.Controls.Add(this.btnEditBorrow);
            this.BorrowsPage.Controls.Add(this.btnAddBorrow);
            this.BorrowsPage.Controls.Add(this.lbBook);
            this.BorrowsPage.Controls.Add(this.lbUser);
            this.BorrowsPage.Controls.Add(this.tbBook);
            this.BorrowsPage.Controls.Add(this.tbUser);
            this.BorrowsPage.Controls.Add(this.BorrowsGrid);
            this.BorrowsPage.Location = new System.Drawing.Point(4, 25);
            this.BorrowsPage.Name = "BorrowsPage";
            this.BorrowsPage.Size = new System.Drawing.Size(1008, 422);
            this.BorrowsPage.TabIndex = 2;
            this.BorrowsPage.Text = "Wypożyczenia";
            this.BorrowsPage.UseVisualStyleBackColor = true;
            this.BorrowsPage.Enter += new System.EventHandler(this.LoadBorrowsGrid);
            // 
            // BorrowsGrid
            // 
            this.BorrowsGrid.AllowUserToAddRows = false;
            this.BorrowsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrowsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowsGrid.Location = new System.Drawing.Point(0, 2);
            this.BorrowsGrid.Name = "BorrowsGrid";
            this.BorrowsGrid.ReadOnly = true;
            this.BorrowsGrid.RowHeadersWidth = 51;
            this.BorrowsGrid.RowTemplate.Height = 24;
            this.BorrowsGrid.Size = new System.Drawing.Size(743, 419);
            this.BorrowsGrid.TabIndex = 1;
            this.BorrowsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BorrowsGrid_CellDoubleClick);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(749, 65);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(749, 127);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 22);
            this.tbLastName.TabIndex = 2;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBirthDate.Location = new System.Drawing.Point(749, 240);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtBirthDate.TabIndex = 5;
            // 
            // lbFirstName
            // 
            this.lbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(746, 45);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(33, 17);
            this.lbFirstName.TabIndex = 5;
            this.lbFirstName.Text = "Imię";
            // 
            // lbLastName
            // 
            this.lbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(749, 104);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(67, 17);
            this.lbLastName.TabIndex = 6;
            this.lbLastName.Text = "Nazwisko";
            // 
            // mtbPesel
            // 
            this.mtbPesel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbPesel.Location = new System.Drawing.Point(749, 182);
            this.mtbPesel.Mask = "00000000000";
            this.mtbPesel.Name = "mtbPesel";
            this.mtbPesel.Size = new System.Drawing.Size(100, 22);
            this.mtbPesel.TabIndex = 4;
            this.mtbPesel.ValidatingType = typeof(int);
            // 
            // lbPesel
            // 
            this.lbPesel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPesel.AutoSize = true;
            this.lbPesel.Location = new System.Drawing.Point(746, 162);
            this.lbPesel.Name = "lbPesel";
            this.lbPesel.Size = new System.Drawing.Size(43, 17);
            this.lbPesel.TabIndex = 8;
            this.lbPesel.Text = "Pesel";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(749, 220);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(105, 17);
            this.lbBirthDate.TabIndex = 9;
            this.lbBirthDate.Text = "Data urodzenia";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Location = new System.Drawing.Point(749, 280);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(200, 23);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Dodaj Użytkownika";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.Location = new System.Drawing.Point(749, 309);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(200, 48);
            this.btnEditUser.TabIndex = 12;
            this.btnEditUser.Text = "Edytuj wybranego Użytkownika";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // tbUserId
            // 
            this.tbUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserId.Location = new System.Drawing.Point(749, 6);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(100, 22);
            this.tbUserId.TabIndex = 13;
            this.tbUserId.Visible = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.Location = new System.Drawing.Point(749, 363);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(200, 51);
            this.btnDeleteUser.TabIndex = 15;
            this.btnDeleteUser.Text = "Usuń wybranego Użytkownika";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBook.Location = new System.Drawing.Point(749, 363);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(200, 51);
            this.btnDeleteBook.TabIndex = 27;
            this.btnDeleteBook.Text = "Usuń wybraną Książke";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // tbBookId
            // 
            this.tbBookId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBookId.Location = new System.Drawing.Point(749, 6);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(100, 22);
            this.tbBookId.TabIndex = 26;
            this.tbBookId.Visible = false;
            // 
            // btnEditBook
            // 
            this.btnEditBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBook.Location = new System.Drawing.Point(749, 309);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(200, 48);
            this.btnEditBook.TabIndex = 25;
            this.btnEditBook.Text = "Edytuj wybraną Książke";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Location = new System.Drawing.Point(749, 280);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(200, 23);
            this.btnAddBook.TabIndex = 24;
            this.btnAddBook.Text = "Dodaj Książke";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lbPublisher
            // 
            this.lbPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(746, 162);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(68, 17);
            this.lbPublisher.TabIndex = 22;
            this.lbPublisher.Text = "Wydawca";
            // 
            // lbAuthor
            // 
            this.lbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(749, 104);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(42, 17);
            this.lbAuthor.TabIndex = 21;
            this.lbAuthor.Text = "Autor";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(746, 45);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(39, 17);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Tytuł";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthor.Location = new System.Drawing.Point(749, 127);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(100, 22);
            this.tbAuthor.TabIndex = 17;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Location = new System.Drawing.Point(749, 65);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 22);
            this.tbTitle.TabIndex = 16;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPublisher.Location = new System.Drawing.Point(750, 183);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(100, 22);
            this.tbPublisher.TabIndex = 28;
            // 
            // lbAddedDate
            // 
            this.lbAddedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAddedDate.AutoSize = true;
            this.lbAddedDate.Location = new System.Drawing.Point(749, 219);
            this.lbAddedDate.Name = "lbAddedDate";
            this.lbAddedDate.Size = new System.Drawing.Size(93, 17);
            this.lbAddedDate.TabIndex = 30;
            this.lbAddedDate.Text = "Data dodania";
            // 
            // dtAddedDate
            // 
            this.dtAddedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAddedDate.Location = new System.Drawing.Point(749, 239);
            this.dtAddedDate.Name = "dtAddedDate";
            this.dtAddedDate.Size = new System.Drawing.Size(200, 22);
            this.dtAddedDate.TabIndex = 29;
            // 
            // lbBorrowDate
            // 
            this.lbBorrowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBorrowDate.AutoSize = true;
            this.lbBorrowDate.Location = new System.Drawing.Point(749, 164);
            this.lbBorrowDate.Name = "lbBorrowDate";
            this.lbBorrowDate.Size = new System.Drawing.Size(129, 17);
            this.lbBorrowDate.TabIndex = 42;
            this.lbBorrowDate.Text = "Data wypożyczenia";
            // 
            // dtBorrowDate
            // 
            this.dtBorrowDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBorrowDate.Location = new System.Drawing.Point(749, 184);
            this.dtBorrowDate.Name = "dtBorrowDate";
            this.dtBorrowDate.Size = new System.Drawing.Size(200, 22);
            this.dtBorrowDate.TabIndex = 41;
            this.dtBorrowDate.Value = new System.DateTime(2020, 9, 18, 23, 47, 35, 0);
            // 
            // btnDeleteBorrow
            // 
            this.btnDeleteBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBorrow.Location = new System.Drawing.Point(749, 364);
            this.btnDeleteBorrow.Name = "btnDeleteBorrow";
            this.btnDeleteBorrow.Size = new System.Drawing.Size(200, 51);
            this.btnDeleteBorrow.TabIndex = 39;
            this.btnDeleteBorrow.Text = "Usuń wybrane Wypożyczenie";
            this.btnDeleteBorrow.UseVisualStyleBackColor = true;
            this.btnDeleteBorrow.Click += new System.EventHandler(this.btnDeleteBorrow_Click);
            // 
            // tbBorrowId
            // 
            this.tbBorrowId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBorrowId.Location = new System.Drawing.Point(749, 7);
            this.tbBorrowId.Name = "tbBorrowId";
            this.tbBorrowId.Size = new System.Drawing.Size(100, 22);
            this.tbBorrowId.TabIndex = 38;
            this.tbBorrowId.Visible = false;
            // 
            // btnEditBorrow
            // 
            this.btnEditBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditBorrow.Location = new System.Drawing.Point(749, 310);
            this.btnEditBorrow.Name = "btnEditBorrow";
            this.btnEditBorrow.Size = new System.Drawing.Size(200, 48);
            this.btnEditBorrow.TabIndex = 37;
            this.btnEditBorrow.Text = "Edytuj wybrane Wypożyczenie";
            this.btnEditBorrow.UseVisualStyleBackColor = true;
            this.btnEditBorrow.Click += new System.EventHandler(this.btnEditBorrow_Click);
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBorrow.Location = new System.Drawing.Point(749, 281);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(200, 23);
            this.btnAddBorrow.TabIndex = 36;
            this.btnAddBorrow.Text = "Dodaj Wypożyczenie";
            this.btnAddBorrow.UseVisualStyleBackColor = true;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // lbBook
            // 
            this.lbBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBook.AutoSize = true;
            this.lbBook.Location = new System.Drawing.Point(749, 105);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(57, 17);
            this.lbBook.TabIndex = 34;
            this.lbBook.Text = "Książka";
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(746, 46);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(78, 17);
            this.lbUser.TabIndex = 33;
            this.lbUser.Text = "Użytkownik";
            // 
            // tbBook
            // 
            this.tbBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBook.Location = new System.Drawing.Point(749, 128);
            this.tbBook.Name = "tbBook";
            this.tbBook.Size = new System.Drawing.Size(100, 22);
            this.tbBook.TabIndex = 32;
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUser.Location = new System.Drawing.Point(749, 66);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 22);
            this.tbUser.TabIndex = 31;
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Location = new System.Drawing.Point(749, 217);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(83, 17);
            this.lbReturnDate.TabIndex = 44;
            this.lbReturnDate.Text = "Data zwrotu";
            this.lbReturnDate.Visible = false;
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtReturnDate.Location = new System.Drawing.Point(749, 243);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(200, 22);
            this.dtReturnDate.TabIndex = 43;
            this.dtReturnDate.Value = new System.DateTime(2020, 9, 18, 23, 47, 35, 0);
            this.dtReturnDate.Visible = false;
            // 
            // cbReturn
            // 
            this.cbReturn.AutoSize = true;
            this.cbReturn.Location = new System.Drawing.Point(849, 216);
            this.cbReturn.Name = "cbReturn";
            this.cbReturn.Size = new System.Drawing.Size(100, 21);
            this.cbReturn.TabIndex = 45;
            this.cbReturn.Text = "Zwrócono?";
            this.cbReturn.UseVisualStyleBackColor = true;
            this.cbReturn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.MainTab);
            this.Name = "MainForm";
            this.Text = "WindowLibrary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.UsersPage.ResumeLayout(false);
            this.UsersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.BooksPage.ResumeLayout(false);
            this.BooksPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).EndInit();
            this.BorrowsPage.ResumeLayout(false);
            this.BorrowsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.TabPage BooksPage;
        private System.Windows.Forms.TabPage BorrowsPage;
        private System.Windows.Forms.DataGridView BooksGrid;
        private System.Windows.Forms.DataGridView BorrowsGrid;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbPesel;
        private System.Windows.Forms.MaskedTextBox mtbPesel;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TextBox tbBookId;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label lbAddedDate;
        private System.Windows.Forms.DateTimePicker dtAddedDate;
        private System.Windows.Forms.CheckBox cbReturn;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.Label lbBorrowDate;
        private System.Windows.Forms.DateTimePicker dtBorrowDate;
        private System.Windows.Forms.Button btnDeleteBorrow;
        private System.Windows.Forms.TextBox tbBorrowId;
        private System.Windows.Forms.Button btnEditBorrow;
        private System.Windows.Forms.Button btnAddBorrow;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox tbBook;
        private System.Windows.Forms.TextBox tbUser;
    }
}

