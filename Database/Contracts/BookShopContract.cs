using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Database.Contracts
{
    public static class BookShopContract
    {
        public const String BOOKSHOP_TABLE = "bookshop";
        public const String BOOKSHOP_ID = "id";
        public const String BOOKSHOP_NAME = "name";

        public const String DATABASE_NAME_CONCAT = "_";
        public const String BOOKSHOP_COLUMN_ID = BOOKSHOP_TABLE + DATABASE_NAME_CONCAT + BOOKSHOP_ID;
        public const String BOOKSHOP_COLUMN_NAME = BOOKSHOP_TABLE + DATABASE_NAME_CONCAT + BOOKSHOP_NAME;
    }
}