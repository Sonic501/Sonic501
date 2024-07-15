namespace Domain.Models.Pagination
{
    public class Paged<T>
    {
        public PaginationViewModel Pagination { get; set; } = null!;
        public ICollection<T> Data { get; set; } = null!;
    }
}
