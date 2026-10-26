namespace EF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using DBContext dBContext = new DBContext();

            if (dBContext.Database.CanConnect())
            {
                Console.WriteLine("Database created successfully!");

                Console.WriteLine("Books: " + dBContext.Books.Count());
                Console.WriteLine("Authors: " + dBContext.Authors.Count());
                Console.WriteLine("Categories: " + dBContext.Categories.Count());
            }
            else
            {
                Console.WriteLine("Database connection failed.");
            }

        }
    }
}
