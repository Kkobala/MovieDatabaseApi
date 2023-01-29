using MovieDatabaseApi.Db.Entities;
using MovieDatabaseApi.Models.Requests;

namespace MovieDatabaseApi.Repositories
{
    public interface IMovieRepository
    {
        Task AddMovieAsync(AddMovieRequest request);
        Task<MovieEntity> GetMovieByIdAsync(int id);
        Task<List<MovieEntity>> SearchMovieAsync(SearchMovieRequest request);
        Task<MovieEntity> UpdateMovieAsync(UpdateMoviesRequest request);
        Task RemoveMovieAsync(DeleteMovieRequest request);
        Task SaveChangesAsync();
    }
}
