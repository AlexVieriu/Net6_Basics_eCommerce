using System;

namespace _36_Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Add();

            var user_IoC = new User_IoC(new OracleDatabase());
            user_IoC.Add();
            
            Console.ReadLine();
        }

        // Bussiness Layer
        // 1. Procedural Programming(Concrete implementation -> bad way)
        public class User
        {
            SqlServerDataBase db;
            public User()
            {
                db = new SqlServerDataBase();
            }
            public void Add()
            {
                db.Persiste();
            }
        }


        // 2. Inversion of Control - IoC (Abstract implementation -> good way)
        public class User_IoC
        {
            private readonly IDataBase _db;

            public User_IoC(IDataBase db)
            {
                _db = db;
            }

            public void Add()
            {
                _db.Persiste();
            }
        }


        // Database Access Layer
        public class SqlServerDataBase // -> bad way
        {
            public void Persiste()
            {
                Console.WriteLine("SqlServer DataBase");
            }
        }

        public class OracleDatabase : IDataBase// -> good way
        {
            public void Persiste()
            {
                Console.WriteLine("Oracle DataBase");
            }
        }

        public class MySqlDataBase : IDataBase
        {
            public void Persiste()
            {
                Console.WriteLine("MySql DataBase");
            }
        }

        public interface IDataBase
        {
            public void Persiste();
        }
    }
}
