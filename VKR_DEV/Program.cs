using System.Text;

namespace VKR_DEV
{
    static class AuthClass
    {
        //Статичное поле, которое хранит значение статуса авторизации
        public static bool IsAuthenticated = false;
        //Статичное поле, которое хранит значения ID пользователя
        public static int auth_id = 0;
        //Статичное поле, которое хранит значения ФИО пользователя
        public static string auth_fio = null;
        //Статичное поле, которое хранит значения ФИО пользователя
        public static string auth_role_title = null;
        //Статичное поле, которое хранит количество привелегий пользователя
        public static int auth_role = 0;

        static string sha256(string randomString)
        {
            //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}