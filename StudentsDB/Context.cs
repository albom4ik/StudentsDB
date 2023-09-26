namespace StudentsDB
{
    public class Context
    {
        private static Context _context;
        private static string _login;

        public static string Login { get { return _login; } }

        public static void LogInSystem(string login) => _login = login;

        public static void LogOutSystem() => _login = null;

        private Context() { }

        public static Context Init() 
        {
            if (_context != null)
                _context = new Context();

            return _context;
        }
    }
}
