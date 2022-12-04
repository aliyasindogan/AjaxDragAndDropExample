using AjaxDragAndDropExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxDragAndDropExample.Controllers
{
    public class CustomerController : Controller
    {
        AjaxDbContext _context;

        public CustomerController(AjaxDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.CustomerRooms.Select(x => x.CustomerID).ToList();
            ViewBag.ListCustomers = _context.Customers.Where(x => customers.Contains(x.Id) == false).ToList();
            ViewBag.ListRooms = _context.Rooms.ToList();

            #region ListRooms
            var customerRooms = _context.CustomerRooms.ToList();
            List<CustomerRoomViewModel> models = new List<CustomerRoomViewModel>();
            bool _isCapacity = false;

            foreach (var item in customerRooms)
            {
                var _room = _context.Rooms.SingleOrDefault(x => x.Id == item.RoomID);
                var _fullName = _context.Customers.SingleOrDefault(x => x.Id == item.CustomerID).FullName;
                var roomCount = _context.CustomerRooms.Count(x => x.RoomID == item.RoomID);
                if (roomCount < _room.RoomTypeID)
                    _isCapacity = true;
                else
                    _isCapacity = false;
                models.Add(new CustomerRoomViewModel
                {
                    CustomerRoomID = item.Id,
                    CustomerId = item.CustomerID,
                    RoomID = item.RoomID,
                    RoomName = _room.RoomName,
                    FullName = _fullName,
                    RoomTypeID = _room.RoomTypeID,
                    IsCapacity = _isCapacity
                });
            }
            ViewBag.ListCustomerRooms = models;
            #endregion
            return View();
        }

    }
}
