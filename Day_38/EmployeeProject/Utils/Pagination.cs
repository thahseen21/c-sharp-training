namespace EmployeeProject.Utils
{
    public class Pagination
    {
        private int PageSize { get; } = 5;

        public int CurrentPage { get; set; }

        public int TotalItems { get; set; }

        public int TotalPage { get; set; }

        public int From { get; set; }

        public int To { get; set; }

        public Pagination(int totalItems)
        {
            this.TotalItems = totalItems / PageSize;
            this.CurrentPage = 1;
            this.From = 1;
            this.To = this.PageSize;
        }

        public void ResetPagination()
        {
            this.CurrentPage = 1;
            this.From = 1;
            this.To = this.PageSize;
        }

        public void ChangePage(int page)
        {
            this.CurrentPage = page;
            this.From = (this.CurrentPage - 1) * this.PageSize;

            // this.To = this.CurrentPage * this.PageSize;
            this.To = this.PageSize;
        }
    }
}
