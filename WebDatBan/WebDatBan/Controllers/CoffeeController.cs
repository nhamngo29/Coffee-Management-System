using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebDatBan.Controllers
{
    public class CoffeeController : ApiController
    {
        CoffeeManagementDataContext db=new CoffeeManagementDataContext();
        [HttpGet]
        [Route("api/coffee/get")]
        public List<Reservation> Get()
        {
            return db.Reservations.ToList();
        }
        [HttpPost]
        [Route("api/coffee/add")]
        public bool Add([FromBody]Reservation reservation)
        {
            try
            {
                db.Reservations.InsertOnSubmit(reservation);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        [HttpPut]
        [Route("api/coffee/update")]
        public bool Update([FromBody] Reservation reservation)
        {
            try
            {
                Reservation rv = db.Reservations.SingleOrDefault(t => t.ID == reservation.ID);
                rv.Name= reservation.Name;
                rv.Status= reservation.Status;
                rv.Quantity= reservation.Quantity;
                rv.Time= reservation.Time;
                rv.IdTable = reservation.IdTable;
                rv.IdSataff= reservation.IdSataff;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        [HttpDelete]
        [Route("api/coffee/delete")]
        public bool delete(int ID)
        {
            try
            {
                Reservation rv = db.Reservations.SingleOrDefault(t => t.ID == ID);
                db.Reservations.DeleteOnSubmit(rv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
