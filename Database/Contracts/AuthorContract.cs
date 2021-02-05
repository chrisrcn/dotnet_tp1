using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Database.Contracts
{
	public static class AuthorContract
    {
        public const String AUTHOR_TABLE = "author";
        public const String AUTHOR_ID = "id";
        public const String AUTHOR_FIRSTNAME = "firstname";
        public const String AUTHOR_LASTNAME = "lastname";

        public const String DATABASE_NAME_CONCAT = "_";

        public const String AUTHOR_COLUMN_ID = AUTHOR_TABLE + DATABASE_NAME_CONCAT + AUTHOR_ID;
        public const String AUTHOR_COLUMN_FIRSTNAME = AUTHOR_TABLE + DATABASE_NAME_CONCAT + AUTHOR_FIRSTNAME;
        public const String AUTHOR_COLUMN_LASTNAME = AUTHOR_TABLE + DATABASE_NAME_CONCAT + AUTHOR_LASTNAME;

    }
}
