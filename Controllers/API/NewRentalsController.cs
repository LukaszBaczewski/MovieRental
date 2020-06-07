using AutoMapper;
using MovieRental.DTOS;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieRental.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //POST api/NewRentals
        [HttpPost]
        public IHttpActionResult CreateNewRentals(RentalDto newRental)
        {
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given");

            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("CustomerId is not valid");

            // filter out movies where the rating is above the customer's age
            var age = DateTime.Today.Year - customer.DateOfBirth.Value.Year;

            var movies = _context.Movies
                .Where(
                m => newRental.MovieIds.Contains(m.Id))
                .Where(m => m.AgeRating <= age)
                .ToList();

            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more MovieIds are invalid");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;
                var rental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();

        }


        // GET api/newRentals
        //public IEnumerable<RentalDto> GetRentals(int customerId)
        //{

        //}

    }
}
