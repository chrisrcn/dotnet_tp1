using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Database.Contracts
{
    public static class CustomerContract
    {
        public const String CUSTOMER_TABLE = "customer";
        public const String CUSTOMER_ID = "id";
        public const String CUSTOMER_FIRSTNAME = "firstname";
        public const String CUSTOMER_LASTNAME = "lastname";

        public const String DATABASE_NAME_CONCAT = "_";
        public const String CUSTOMER_COLUMN_ID = CUSTOMER_TABLE + DATABASE_NAME_CONCAT + CUSTOMER_ID;
        public const String CUSTOMER_COLUMN_FIRSTNAME = CUSTOMER_TABLE + DATABASE_NAME_CONCAT + CUSTOMER_FIRSTNAME;
        public const String CUSTOMER_COLUMN_LASTNAME = CUSTOMER_TABLE + DATABASE_NAME_CONCAT + CUSTOMER_LASTNAME;
    }
}