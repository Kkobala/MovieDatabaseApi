namespace MovieDatabaseApi.Models.Requests
{
    public class DeleteMovieRequest
    {
        public int Id { get; set; }
        public MovieStatus Status { get; set; }
    }
}
