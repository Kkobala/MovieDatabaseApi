using Microsoft.AspNetCore.Mvc;
using MovieDatabaseApi.Db.Entities;
using MovieDatabaseApi.Models.Requests;
using MovieDatabaseApi.Repositories;

namespace MovieDatabaseApi.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        private const int pagemaxsize = 100;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpPost("add-movie")]
        public async Task<IActionResult> AddMovies(AddMovieRequest request)
        {
            var movie = new MovieEntity();

            if (movie == null)
            {
                return NotFound("Cannot find a movie");
            }

            await _movieRepository.AddMovieAsync(request);
            await _movieRepository.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("get-movie")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var movie = new MovieEntity();

            if (movie == null)
            {
                return NotFound("Cannot find a movie");
            }
            await _movieRepository.GetMovieByIdAsync(id);

            return Ok();
        }

        [HttpPost("search-movie")]
        public async Task<IActionResult> SearchMovie(SearchMovieRequest request)
        {
            if (request.PageSize > 100)
            {
                return BadRequest("Page size exceed its limit");
            }

            var searchedMovie = await _movieRepository.SearchMovieAsync(request);

            return Ok(searchedMovie);
        }

        [HttpPost("update-movie")]
        public async Task<IActionResult> UpdateMovie(UpdateMoviesRequest request)
        {
            var updatedMovie = await _movieRepository.UpdateMovieAsync(request);
            await _movieRepository.SaveChangesAsync();

            return Ok(updatedMovie);
        }

        [HttpDelete("delete-movie")]
        public async Task<IActionResult> DeleteMovie(DeleteMovieRequest request)
        {
            await _movieRepository.RemoveMovieAsync(request);
            await _movieRepository.SaveChangesAsync();

            return Ok();
        }
    }
}
