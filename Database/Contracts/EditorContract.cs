using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Database.Contracts
{
    public static class EditorContract
    {
        public const String EDITOR_TABLE = "bookshop";
        public const String EDITOR_ID = "id";
        public const String EDITOR_NAME = "name";

        public const String DATABASE_NAME_CONCAT = "_";
        public const String EDITOR_COLUMN_ID = EDITOR_TABLE + DATABASE_NAME_CONCAT + EDITOR_ID;
        public const String EDITOR_COLUMN_NAME = EDITOR_TABLE + DATABASE_NAME_CONCAT + EDITOR_NAME;
    }
}