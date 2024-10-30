namespace LibrarySystem
{
    public class Book
    {
        // Fields
        public string title;
        public string author;
        public int pages;
        public bool isCheckedOut;

        // Constructor with two parameters
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.pages = 268;
            this.isCheckedOut = false;
        }

        // Overloaded constructor with three parameters
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.isCheckedOut = false;
        }

        // Method to check out the book
        public void CheckOut()
        {
            isCheckedOut = true;
        }

        // Method to return the book
        public void ReturnBook()
        {
            isCheckedOut = false;
        }

        // Override ToString method to display book details
        public override string ToString()
        {
            return $"Title: {title}, Author: {author}, Pages: {pages}, Checked Out: {(isCheckedOut ? "Yes" : "No")}";
        }
    }
}