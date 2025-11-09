namespace SmartBusProject
{
    internal static class Program
    {
        public static List<User> users = new List<User>();
        public static List<Cafes> cafes = new List<Cafes>();
        public static List<Product> product = new List<Product>();
        public static List<CartItem> cartProducts = new List<CartItem>();
        public static User userInstance;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            users.Add(new User("driver", "driver", UserType.Driver));
            users.Add(new User("dimos", "12345", UserType.Passenger));
            users.Add(new User("fotfot", "12345", UserType.Passenger));


            cafes.Add(new Cafes("Old Dog", "Address 12", 8));
            cafes.Add(new Cafes("Flocafe", "Address 18", 12));
            cafes.Add(new Cafes("Coffe Island", "Address 20", 10));
            cafes.Add(new Cafes("Coffe Berry", "Address 78", 5));
            cafes.Add(new Cafes("Everest", "Address 55", 10));
          
            product.Add(new Product("Cappucino", 2.30));
            product.Add(new Product("Espresso", 2.10));
            product.Add(new Product("Latte", 3.00));
            product.Add(new Product("Irish Coffee", 3.80));
            product.Add(new Product("Freddo Cappucino", 2.80));
            product.Add(new Product("Freddo Espresso", 2.50));
            product.Add(new Product("Nescafe Frappe", 2.40));
            product.Add(new Product("Nescafe", 2.40));
            product.Add(new Product("Tost", 2.00));
            product.Add(new Product("Coca Cola", 1.20));
            product.Add(new Product("Sprite", 1.40));
            product.Add(new Product("Fanda Blue", 1.30));
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuForm());
        }
    }
}