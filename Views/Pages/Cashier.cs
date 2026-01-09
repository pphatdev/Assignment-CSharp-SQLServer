using System.Data;
using AssignmentCSharpAndSqlServer.DB;

namespace AssignmentCSharpAndSqlServer.Views.Pages
{
    public partial class Cashier : UserControl
    {
        private DataTable cartItems = null!;
        private decimal totalAmount = 0;
        private DataTable productsData = null!;

        public Cashier()
        {
            InitializeComponent();
        }
    }
}
