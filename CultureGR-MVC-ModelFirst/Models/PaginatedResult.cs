namespace CultureGR_MVC_ModelFirst.Models
{
    public class PaginatedResult<T>
    {
        public List<T> Data { get; set; } = null!;
        public int TotalRecords { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        // to appear the number of the pages. int is to show 2 pages NOT 2.4 page
        public int TotalPages => (int)Math.Ceiling((double)TotalRecords / PageSize);
    }
}
