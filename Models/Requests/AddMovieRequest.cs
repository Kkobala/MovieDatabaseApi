namespace MovieDatabaseApi.Models.Requests
{
    public class AddMovieRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseYear { get; set; }
        public string Director { get; set; }
    }
}
