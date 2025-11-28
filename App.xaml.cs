using Bancea_Raul_Lab7.Data;

namespace Bancea_Raul_Lab7
{
    public partial class App : Application
    {
        private static ShoppingListDatabase? database;

        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    var path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "ShoppingList.db3");

                    database = new ShoppingListDatabase(path);
                }

                return database;
            }
        }

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
