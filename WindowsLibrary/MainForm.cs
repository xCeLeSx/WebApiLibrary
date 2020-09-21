using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsLibrary.Models;

namespace WindowsLibrary

    
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUsersGrid();
            LoadBorrowsGrid();
            LoadBooksGrid();
        }


        private void LoadUsersGrid()
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("uzytkownicy", Method.GET, DataFormat.Json);
            var response = client.Execute<IEnumerable<User>>(request);

            List<User> tolist = response.Data.ToList();
            var list = new BindingList<User>(tolist);

            var source = new BindingSource(list, null);
            UsersGrid.ColumnHeadersVisible = true;
            UsersGrid.DataSource = source;
        }



        private void LoadUsersGrid(object sender, EventArgs e)
        {
            LoadUsersGrid();
        }

        private void LoadBooksGrid()
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("ksiazki", Method.GET, DataFormat.Json);
            var response = client.Execute<IEnumerable<Book>>(request);

            List<Book> tolist = response.Data.ToList();
            var list = new BindingList<Book>(tolist);

            var source = new BindingSource(list, null);
            BooksGrid.ColumnHeadersVisible = true;
            BooksGrid.DataSource = source;
        }

        private void LoadBorrowsGrid(object sender, EventArgs e)
        {
            LoadBorrowsGrid();
        }

        private void LoadBorrowsGrid()
        {
            RestClient client = new RestClient("https://localhost:5001/api/");
            RestRequest request = new RestRequest("wypozyczenia", Method.GET, DataFormat.Json);
            var response = client.Execute<IEnumerable<Borrow>>(request);

            List<Borrow> tolist = response.Data.ToList();

            var list = new BindingList<Borrow>(tolist);

            var source = new BindingSource(list, null);
            BorrowsGrid.ColumnHeadersVisible = true;
            BorrowsGrid.DataSource = source;
        }

        private void LoadBooksGrid(object sender, EventArgs e)
        {
            LoadBooksGrid();
        }


        private void DeleteRowUsersGrid(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tego Użytkownika?",
            "Usuwanie Użytkownika",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                int id = Convert.ToInt32(UsersGrid.CurrentRow.Cells["UserId"].Value);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("uzytkownicy/" + id, Method.DELETE, DataFormat.Json);
                var response = client.Delete(request);

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DeleteRowBooksGrid(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tą Książkę?",
            "Usuwanie Książki",
            MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                int id = Convert.ToInt32(BooksGrid.CurrentRow.Cells["BookId"].Value);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("ksiazki/" + id, Method.DELETE, DataFormat.Json);
                var response = client.Delete(request);

            }
            else
            {
                e.Cancel = true;
            }
        }



        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "" && mtbPesel.Text != "")
            {
                User user = new User();
                user.FirstName = tbFirstName.Text;
                user.LastName = tbLastName.Text;
                user.BirthDate = dtBirthDate.Value;
                user.Pesel = Convert.ToInt64(mtbPesel.Text);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("uzytkownicy", Method.POST, DataFormat.Json);

                request.AddJsonBody(user);
                var response = client.Post<User>(request);

                MessageBox.Show("Dodano nowego Użytkownika.");

                tbFirstName.Clear();
                tbLastName.Clear();
                dtBirthDate.Value = DateTime.Now;
                mtbPesel.Clear();
                LoadUsersGrid();
            }
        }

        private void UsersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbUserId.Text = UsersGrid.CurrentRow.Cells["UserId"].Value.ToString();
            tbFirstName.Text = UsersGrid.CurrentRow.Cells["FirstName"].Value.ToString();
            tbLastName.Text = UsersGrid.CurrentRow.Cells["LastName"].Value.ToString();
            dtBirthDate.Value = Convert.ToDateTime(UsersGrid.CurrentRow.Cells["BirthDate"].Value);
            mtbPesel.Text = UsersGrid.CurrentRow.Cells["Pesel"].Value.ToString();        
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text != "")
            {
                User user = new User();
                user.UserId = Convert.ToInt32(tbUserId.Text);
                user.FirstName = tbFirstName.Text;
                user.LastName = tbLastName.Text;
                user.BirthDate = dtBirthDate.Value;
                user.Pesel = Convert.ToInt64(mtbPesel.Text);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("uzytkownicy/" + user.UserId, Method.PUT, DataFormat.Json);

                request.AddJsonBody(user);
                var response = client.Put<User>(request);

                MessageBox.Show("Edytowano Użytkownika.");

                tbUserId.Clear();
                tbFirstName.Clear();
                tbLastName.Clear();
                dtBirthDate.Value = DateTime.Now;
                mtbPesel.Clear();
                LoadUsersGrid();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text != "")
            {
                int UserId = Convert.ToInt32(tbUserId.Text);

                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tego Użytkownika?",
    "Usuwanie Użytkownika",
    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    RestClient client = new RestClient("https://localhost:5001/api/");
                    RestRequest request = new RestRequest("uzytkownicy/" + UserId, Method.DELETE, DataFormat.Json);
                    var response = client.Delete(request);
                }
                tbUserId.Clear();
                tbFirstName.Clear();
                tbLastName.Clear();
                dtBirthDate.Value = DateTime.Now;
                mtbPesel.Clear();
                LoadUsersGrid();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" && tbAuthor.Text != "" && tbPublisher.Text != "")
            {
                Book book = new Book();
                book.Title = tbTitle.Text;
                book.Author = tbAuthor.Text;
                book.Added = dtAddedDate.Value;
                book.Publisher = tbPublisher.Text;

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("ksiazki", Method.POST, DataFormat.Json);

                request.AddJsonBody(book);
                var response = client.Post<Book>(request);

                MessageBox.Show("Dodano nową Książke.");

                tbPublisher.Clear();
                tbTitle.Clear();
                dtAddedDate.Value = DateTime.Now;
                tbAuthor.Clear();
                LoadBooksGrid();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (tbBookId.Text != "")
            {
                Book book = new Book();
                book.BookId = Convert.ToInt32(tbBookId.Text);
                book.Title = tbTitle.Text;
                book.Author = tbAuthor.Text;
                book.Added = dtAddedDate.Value;
                book.Publisher = tbPublisher.Text;

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("ksiazki/" + book.BookId, Method.PUT, DataFormat.Json);

                request.AddJsonBody(book);
                var response = client.Put<Book>(request);

                MessageBox.Show("Edytowano Książke.");

                tbBookId.Clear();
                tbPublisher.Clear();
                tbTitle.Clear();
                dtAddedDate.Value = DateTime.Now;
                tbAuthor.Clear();
                LoadBooksGrid();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (tbBookId.Text != "")
            {
                int BookId = Convert.ToInt32(tbBookId.Text);

                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć tą Książke?",
    "Usuwanie Książki",
    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    RestClient client = new RestClient("https://localhost:5001/api/");
                    RestRequest request = new RestRequest("ksiazki/" + BookId, Method.DELETE, DataFormat.Json);
                    var response = client.Delete(request);
                }
                tbBookId.Clear();
                tbPublisher.Clear();
                tbTitle.Clear();
                dtAddedDate.Value = DateTime.Now;
                tbAuthor.Clear();
                LoadBooksGrid();
            }
        }

        private void BooksGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBookId.Text = BooksGrid.CurrentRow.Cells["BookId"].Value.ToString();
            tbTitle.Text = BooksGrid.CurrentRow.Cells["Title"].Value.ToString();
            tbAuthor.Text = BooksGrid.CurrentRow.Cells["Author"].Value.ToString();
            dtAddedDate.Value = Convert.ToDateTime(BooksGrid.CurrentRow.Cells["Added"].Value);
            tbPublisher.Text = BooksGrid.CurrentRow.Cells["Publisher"].Value.ToString();
        }

        private void BorrowsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBorrowId.Text = BorrowsGrid.CurrentRow.Cells["BorrowId"].Value.ToString();
            tbBook.Text = BorrowsGrid.CurrentRow.Cells["BookId"].Value.ToString();
            tbUser.Text = BorrowsGrid.CurrentRow.Cells["UserId"].Value.ToString();
            dtBorrowDate.Value = Convert.ToDateTime(BorrowsGrid.CurrentRow.Cells["BorrowDate"].Value);
            dtReturnDate.Value = Convert.ToDateTime(BorrowsGrid.CurrentRow.Cells["ReturnDate"].Value);
            dtReturnDate.Visible = true;
            lbReturnDate.Visible = true;
            cbReturn.Visible = true;
            if (BorrowsGrid.CurrentRow.Cells["Return"].Value.ToString() == "True")
            {
                cbReturn.CheckState = CheckState.Checked;
            }
            else
            { cbReturn.CheckState = CheckState.Unchecked;
            }
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            if (tbBook.Text != "" && tbUser.Text != "" )
            {

                Borrow borrow = new Borrow();
                borrow.BookId = Convert.ToInt32(tbBook.Text);
                borrow.UserId = Convert.ToInt32(tbUser.Text);
                borrow.BorrowDate = dtBorrowDate.Value;
                borrow.ReturnDate = borrow.BorrowDate;
                borrow.Return = Convert.ToBoolean("False");

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("wypozyczenia", Method.POST, DataFormat.Json);

                request.AddJsonBody(borrow);
                var response = client.Post<Borrow>(request);

                MessageBox.Show("Dodano nowe Wypożyczenie.");

                tbBook.Clear();
                tbUser.Clear();
                dtBorrowDate.Value = DateTime.Now;
                dtReturnDate.Value = DateTime.Now;

                cbReturn.CheckState = CheckState.Unchecked;
                LoadBorrowsGrid();
            }
        }

        private void btnEditBorrow_Click(object sender, EventArgs e)
        {
            if (tbBorrowId.Text != "")
            {
                String cb;

                if (cbReturn.CheckState == CheckState.Checked)
                {
                    cb = "True";
                }
                else
                {
                    cb = "False";
                }

                Borrow borrow = new Borrow();
                borrow.BorrowId = Convert.ToInt32(tbBorrowId.Text);
                borrow.BookId = Convert.ToInt32(tbBook.Text);
                borrow.UserId = Convert.ToInt32(tbUser.Text);
                borrow.BorrowDate = dtBorrowDate.Value;
                borrow.ReturnDate = dtReturnDate.Value;
                borrow.Return = Convert.ToBoolean(cb);

                RestClient client = new RestClient("https://localhost:5001/api/");
                RestRequest request = new RestRequest("wypozyczenia/" + borrow.BorrowId, Method.PUT, DataFormat.Json);

                request.AddJsonBody(borrow);
                var response = client.Put<Borrow>(request);

                MessageBox.Show("Edytowano Wypożyczenie.");

                tbBorrowId.Clear();
                tbBook.Clear();
                tbUser.Clear();
                dtBorrowDate.Value = DateTime.Now;
                dtReturnDate.Value = DateTime.Now;

                cbReturn.CheckState = CheckState.Unchecked;

                dtReturnDate.Visible = false;
                lbReturnDate.Visible = false;
                cbReturn.Visible = false;

                LoadBorrowsGrid();
            }
        }

        private void btnDeleteBorrow_Click(object sender, EventArgs e)
        {
            if (tbBorrowId.Text != "")
            {
                int BorrowId = Convert.ToInt32(tbBorrowId.Text);

                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć te Wypożyczenie?",
    "Usuwanie Wypożyczenia",
    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    RestClient client = new RestClient("https://localhost:5001/api/");
                    RestRequest request = new RestRequest("wypozyczenia/" + BorrowId, Method.DELETE, DataFormat.Json);
                    var response = client.Delete(request);
                }
                tbBorrowId.Clear();
                tbBook.Clear();
                tbUser.Clear();
                dtBorrowDate.Value = DateTime.Now;
                dtReturnDate.Value = DateTime.Now;

                cbReturn.CheckState = CheckState.Unchecked;

                dtReturnDate.Visible = false;
                lbReturnDate.Visible = false;
                cbReturn.Visible = false;

                LoadBorrowsGrid();
            }
        }
    }
}
