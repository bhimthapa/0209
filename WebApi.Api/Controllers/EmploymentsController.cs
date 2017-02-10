using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Data;
using WebApi.Data.Entities;

namespace WebApi.Api.Controllers
{
    public class EmploymentsController : ApiController
    {
        private WebApiDbContext db = new WebApiDbContext();

        // GET: api/Employments
        public IQueryable<Employment> GetEmployments()
        {
            return db.Employments;
        }

        [HttpPost]
        [Route("PostData")]
        public string PostData(FormDataCollection data)
        {

            Employment obj = new Employment();
            obj.EmploymentId = 1; //Convert.ToInt32(data.Get("Empid").ToString());
            obj.FirstName = data.Get("FirstName");
            obj.LastName = data.Get("LastName");
            string salary = data.Get("Salary").ToString();
            obj.Salary = Convert.ToInt32(salary);
            obj.Address = data.Get("Address");
            obj.PhoneNo = data.Get("PhoneNo");
            db.Employments.Add(obj);
            db.SaveChanges();
           // int x = 10;
            return "Record is saved";

        }


        [HttpGet]
        [Route("DeleteData")]
        public string DeleteData(string id)
        {

           // Employment obj = new Employment();
           // string id= data.Get("Empid").ToString();

            Employment employment = db.Employments.Find(Convert.ToInt32(id));
            //if (employment == null)
            //{
            //    return NotFound();
            //}

            db.Employments.Remove(employment);
            db.SaveChanges();

            
            return "Record is Deleted";

        }


        // GET: api/Employments/5
        [ResponseType(typeof(Employment))]
        public IHttpActionResult GetEmployment(int id)
        {
            Employment employment = db.Employments.Find(id);
            if (employment == null)
            {
                return NotFound();
            }

            return Ok(employment);
        }

        // PUT: api/Employments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployment(int id, Employment employment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employment.EmploymentId)
            {
                return BadRequest();
            }

            db.Entry(employment).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmploymentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employments
        [ResponseType(typeof(Employment))]
        public IHttpActionResult PostEmployment(Employment employment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employments.Add(employment);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employment.EmploymentId }, employment);
        }

        // DELETE: api/Employments/5
        [ResponseType(typeof(Employment))]
        public IHttpActionResult DeleteEmployment(int id)
        {
            Employment employment = db.Employments.Find(id);
            if (employment == null)
            {
                return NotFound();
            }

            db.Employments.Remove(employment);
            db.SaveChanges();

            return Ok(employment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmploymentExists(int id)
        {
            return db.Employments.Count(e => e.EmploymentId == id) > 0;
        }
    }
}