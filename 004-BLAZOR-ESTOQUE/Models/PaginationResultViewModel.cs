namespace _004_BLAZOR_ESTOQUE.Models
{
    public class PaginationResultViewModel
    {

        public int Count { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public List<Categoria> categoria { get; set; }
    }
}
