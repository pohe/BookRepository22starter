using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRepository22starter
{
    public class BookRepositoryDictionary
    {
        #region Instance fields
        private Dictionary<string, Book> _books;
        #endregion

        #region Constructor
        public BookRepositoryDictionary()
        {
            _books = new Dictionary<string, Book>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _books.Count; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method adds a single Book object 
        /// to the List of books 
        /// </summary>
        public void AddBook(Book aBook)
        {

            // TODO
        }

        /// <summary>
        /// This method returns a Book object (if any) from
        /// the List of books, which has a matching ISBN number.
        /// If no such object exists, the method returns null.
        /// </summary>
        public Book LookupBook(string isbn)
        {
            // TODO

            return null;
        }

        /// <summary>
        /// This method deletes a Book object from the List
        /// of books, specifically the object which has a
        /// matching ISBN number. If no such object exists,
        /// no object is deleted.
        /// </summary>
        public void DeleteBook(string isbn)
        {
            // TODO
        }


        public void PrintBooks()
        {
            //TODO
        }

        public void UpdateBook(string isbn, Book bookToUpdate)
        {
            //TODO
        }

        #endregion
    }
}
