using System.Text;

namespace VKR_DEV
{
    static class AuthClass
    {
        //��������� ����, ������� ������ �������� ������� �����������
        public static bool IsAuthenticated = false;
        //��������� ����, ������� ������ �������� ID ������������
        public static int auth_id = 0;
        //��������� ����, ������� ������ �������� ��� ������������
        public static string auth_fio = null;
        //��������� ����, ������� ������ �������� ��� ������������
        public static string auth_role_title = null;
        //��������� ����, ������� ������ ���������� ���������� ������������
        public static int auth_role = 0;

        static string sha256(string randomString)
        {
            //��� ���������� ����������������� �����. ����� ������� ������ ����������� � ���, ��� ������ �������� � �����
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