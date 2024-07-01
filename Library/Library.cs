using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.ElementClasses
{
    public class Library
    {
        public string LibraryName { get; set; }
        private Book[] _books;
        private Journal[] _journals;
        private AudioBook[] _audioBooks;

        public Library(string libraryName, int bookCount, int journalCount, int audioBookCount)
        {
            LibraryName = libraryName;
            _books = new Book[bookCount];
            _journals = new Journal[journalCount];
            _audioBooks = new AudioBook[audioBookCount];
        }

        #region Book Operations

        public void GetBookList()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int count = 0;
            foreach (var book in _books)
            {
                count++;
                if (book is not null)
                {
                    Console.Write($"{count}. ");
                    Console.WriteLine(book.ToString());
                }
                else
                {

                    Console.WriteLine("Siyahi bosdur");
                }
            }
        }

        public void SearchBook(string name = null, string author = null, int year = 0, string type = null)
        {
            foreach (var book in _books)
            {
                if (book.BookName == name || book.Author == author || book.Type == type || book.Year == year)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public bool CreateBook(Book book)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] is null)
                {
                    _books[i] = book;
                    return true;
                }
            }
            _books = _books.Append(book).ToArray();
            return true;
        }

        public bool DeleteBook(int index)
        {
            if (index < 0 || index >= _books.Length)
                return false;

            var _newBooks = _books.ToList();
            _newBooks.RemoveAt(index);
            _books = _newBooks.ToArray();
            return true;
        }

        public bool RentBook(int index)
        {
            if (index < 0 || index >= _books.Length)
                return false;

            var updateData = _books[index];
            updateData.IsRented = true;
            return true;
        }

        public bool RentReturnBook(int index)
        {
            if (index < 0 || index >= _books.Length)
                return false;

            var updateData = _books[index];
            updateData.IsRented = false;
            return true;
        }

        #endregion

        #region Journal Operations

        public void GetJournalList()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int count = 0;
            foreach (var journal in _journals)
            {
                count++;
                if (journal is not null)
                {
                    Console.Write($"{count}. ");
                    Console.WriteLine(journal.ToString());
                }
                else
                {
                    Console.WriteLine("Siyahi bosdur");
                }
            }
        }

        public void SearchJournal(string name = "", string type = "", int year = 0)
        {
            foreach (var journal in _journals)
            {
                if (journal.JournalName == name || journal.JournalType == type || journal.Year == year)
                {
                    Console.WriteLine(journal.ToString());
                }
            }
        }

        public bool CreateJournal(Journal journal)
        {
            for (int i = 0; i < _journals.Length; i++)
            {
                if (_journals[i] is null)
                {
                    _journals[i] = journal;
                    return true;
                }
            }
            _journals = _journals.Append(journal).ToArray();
            return true;
        }

        public bool DeleteJournal(int index)
        {
            if (index < 0 || index >= _journals.Length)
                return false;

            var _newJournals = _journals.ToList();
            _newJournals.RemoveAt(index);
            _journals = _newJournals.ToArray();
            return true;
        }

        public bool RentJournal(int index)
        {
            if (index < 0 || index >= _journals.Length)
                return false;

            var updateData = _journals[index];
            updateData.IsRented = true;
            return true;
        }

        public bool RentReturnJournal(int index)
        {
            if (index < 0 || index >= _journals.Length)
                return false;

            var updateData = _journals[index];
            updateData.IsRented = false;
            return true;
        }

        #endregion

        #region Audio Book Operations

        public void GetAudioBookList()
        {
            int count = 0;
            foreach (var audioBook in _audioBooks)
            {
                count++;
                if (audioBook is not null)
                {
                    Console.Write($"{count}. ");
                    Console.WriteLine(audioBook.ToString());
                }
                else
                {
                    Console.WriteLine("Siyahi bosdur");
                }
            }
        }

        public void SearchAudioBook(string name = "", string author = "", int year = 0, string type = "")
        {
            foreach (var audioBook in _audioBooks)
            {
                if (audioBook.BookName == name || audioBook.Author == author || audioBook.Type == type || audioBook.Year == year)
                {
                    Console.WriteLine(audioBook.ToString());
                }
            }
        }

        public bool CreateAudioBook(AudioBook audioBook)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_audioBooks[i] is null)
                {
                    _audioBooks[i] = audioBook;
                    return true;
                }
            }
            _audioBooks = _audioBooks.Append(audioBook).ToArray();
            return true;
        }

        public bool DeleteAudioBook(int index)
        {
            if (index < 0 || index >= _audioBooks.Length)
                return false;

            var _newBooks = _audioBooks.ToList();
            _newBooks.RemoveAt(index);
            _audioBooks = _newBooks.ToArray();
            return true;
        }

        public bool RentAudioBook(int index)
        {
            if (index < 0 || index >= _audioBooks.Length)
                return false;

            var updateData = _audioBooks[index];
            updateData.IsRented = true;
            return true;
        }

        public bool RentAudioReturnBook(int index)
        {
            if (index < 0 || index >= _audioBooks.Length)
                return false;

            var updateData = _audioBooks[index];
            updateData.IsRented = false;
            return true;
        }

        #endregion
    }


}
