using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Database.Contracts
{
    public static class BookContract
    {
        public const String BOOK_TABLE = "book";
        public const String BOOK_ID = "id";
        public const String BOOK_NAME = "name";
        public const String BOOK_NB_PAGE = "nb_page";

        public const String DATABASE_NAME_CONCAT = "_";
        public const String BOOK_COLUMN_ID = BOOK_TABLE + DATABASE_NAME_CONCAT + BOOK_ID;
        public const String BOOK_COLUMN_NAME = BOOK_TABLE + DATABASE_NAME_CONCAT + BOOK_NAME;
        public const String BOOK_COLUMN_NB_PAGE = BOOK_TABLE + DATABASE_NAME_CONCAT + BOOK_NB_PAGE;

    }
}