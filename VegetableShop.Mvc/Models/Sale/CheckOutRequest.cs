namespace VegetableShop.Mvc.Models.Sale
{
    public class CheckOutRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public List<OrderDetailViewModel> OrderDetails { set; get; } = new List<OrderDetailViewModel>();
    }
}
