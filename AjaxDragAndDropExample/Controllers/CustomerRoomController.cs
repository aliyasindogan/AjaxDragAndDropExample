using AjaxDragAndDropExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxDragAndDropExample.Controllers
{
    public class CustomerRoomController : Controller
    {
        private readonly AjaxDbContext _context;

        public CustomerRoomController(AjaxDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public JsonResult Add(int customerId, int roomId)
        {
            string message = "";
            var isCustomerRoom = _context.CustomerRooms.Any(x => x.CustomerID == customerId);
            if (!isCustomerRoom)
            {
                var room = _context.Rooms.SingleOrDefault(x => x.Id == roomId);
                var roomCount = _context.CustomerRooms.Count(x => x.RoomID == roomId);
                if (roomCount < room.RoomTypeID)
                {
                    _context.CustomerRooms.Add(new CustomerRoom { RoomID = roomId, CustomerID = customerId });
                    _context.SaveChanges();
                    message = "İŞLEM BAŞARILI!";
                }
                else
                    message = "BU ODA DOLU!";
            }
            return Json(message);
        }
        public ActionResult Delete(int id)
        {
            var customerRoom = _context.CustomerRooms.Find(id);
            _context.CustomerRooms.Remove(customerRoom);
            _context.SaveChanges();
            return Redirect("/Customer/Index");
        }
    }
}
