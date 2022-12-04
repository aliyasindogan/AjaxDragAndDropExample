namespace AjaxDragAndDropExample.Models
{
    public class CustomerRoomListViewModel
    {
        public List<Room> Rooms { get; set; }
        public List<Customer> Customers { get; set; }
        public List<CustomerRoomViewModel> CustomerRooms { get; set; }
    }
}
