using Microsoft.Data.SqlClient;

namespace AssignmentAppl
{
    public class UserService
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=DataB;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";

        public void Login()
        {
            Console.Write("Enter UserName: ");
            string uname = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Using Parameters to prevent SQL Injection
                string query = "SELECT * FROM [user1] WHERE uname=@uname AND password=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    Console.WriteLine($"\nAccess Granted. Welcome {uname}!");
                else
                    Console.WriteLine("\nInvalid Username or Password.");
            }
        }

        public void CreateUser()
        {
            Console.Write("Enter New Username: ");
            string uName = Console.ReadLine();
            Console.Write("Enter New Password: ");
            string Pass = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [user1](uname, password) VALUES(@uname, @pass)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uname", uName);
                cmd.Parameters.AddWithValue("@pass", Pass);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "User added successfully!" : "Error creating user.");
            }
        }

        public void UpdatePassword()
        {
            Console.Write("Enter Username to change password: ");
            string uName = Console.ReadLine();
            Console.Write("Enter New Password: ");
            string pass = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE [user1] SET password=@pass WHERE uname=@uname";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@uname", uName);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "Password updated successfully!" : "User not found.");
            }
        }
    }
}