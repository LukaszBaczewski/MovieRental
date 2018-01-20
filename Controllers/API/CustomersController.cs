using AutoMapper;
using MovieRental.DTOS;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRental.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _contex;

        public CustomersController()
        {
            _contex = new ApplicationDbContext();
        }

        // Get api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _contex.Customers
                .Include(c => c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);
        }

        //Get api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _contex.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                NotFound();
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);

            _contex.Customers.Add(customer);
            _contex.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        //PUT api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customerInDb = _contex.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);

            _contex.SaveChanges();

            return Ok();
        }

        //DELETE api/customer/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _contex.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _contex.Customers.Remove(customerInDb);
            _contex.SaveChanges();

            return Ok();
        }
    }
}
