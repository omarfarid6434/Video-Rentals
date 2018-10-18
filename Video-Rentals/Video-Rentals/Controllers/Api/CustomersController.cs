using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Video_Rentals.Models;
using Video_Rentals.Dtos;

namespace Video_Rentals.Controllers.Api
{
    public class CustomersController : ApiController
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //Get/api/customers
        public IEnumerable<CustomersDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomersDto>);
        }
        //Get/api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Customer, CustomersDto>(customer));
        }

        //Post/api/customer/1
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomersDto customersDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();


            var customer = Mapper.Map<CustomersDto, Customer>(customersDto);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customersDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + " / " + customer.Id),customersDto);

        }


         //Put/api/customer/1
         [HttpPut]
        public void UpdateCustomer(int id, CustomersDto customersDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customersDto, customerInDB);   

            _context.SaveChanges();

        }

        //Delete/api/customer/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDB);
            _context.SaveChanges();
        }
    }
}
