namespace GamerHeavenAPI.Models
{
    public class PaginationData<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationData(int totalItemCount, int pageSize, int currentPage, IEnumerable<T> items)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)PageSize);
            Items = items;
        }
    }
}
