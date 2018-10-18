using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Video_Rentals.Models;
using System.Data.Entity;
using Video_Rentals.Dtos;
using AutoMapper;

namespace Video_Rentals.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        //Get/api/movies
        public IEnumerable<MoviesDto> GetMovies()
        {
            return _context.Movies.ToList()
                .Select(Mapper.Map<Movie,MoviesDto>);
        }


        //Get/api/movie/1

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie,MoviesDto>(movie));
        }

        //Post/api/movie/
        [HttpPost]
        public IHttpActionResult CreateMovie(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MoviesDto, Movie>(moviesDto);

            _context.Movies.Add(movie);
            _context.SaveChanges();


            moviesDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" +movie.Id),moviesDto);
        }

        //Put/api/movie/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDB == null)
                return NotFound();

            Mapper.Map(moviesDto, movieInDB);

            _context.SaveChanges();

            return Ok();
        }

        //Deltete/api/movie/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDB = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDB == null)
                return NotFound();

            _context.Movies.Remove(movieInDB);
            _context.SaveChanges();

            return Ok();
        }
    }
}
