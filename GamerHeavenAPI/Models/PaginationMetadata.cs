namespace GamerHeavenAPI.Models
{
    public class PaginationMetadata
    {
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; } 
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationMetadata(int totalItemCount, int pageSize, int currentPage) {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int) Math.Ceiling(totalItemCount / (double) PageSize); 
        }
    }

    public class PaginationList<T>
    {
        public IEnumerable<T> Items { get; set; }   
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationList(int totalItemCount, int pageSize, int currentPage, IEnumerable<T> items)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)PageSize);
            Items = items;
        }
    }

    public class PaginationListGenereic<T>:List<T>
    {
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }

        public PaginationListGenereic(int totalItemCount, int pageSize, int currentPage, IEnumerable<T> items)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)PageSize);
            AddRange(items);
        }
    }
}
