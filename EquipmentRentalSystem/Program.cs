using EquipmentRentalSystem.Data;

namespace EquipmentRentalSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseInitializer.Initialize();

            Application.Run(new LoginForm());
        }
    }
}