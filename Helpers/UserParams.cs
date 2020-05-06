namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int _maxPageSize = 50;
        private int _pageSize = 10;
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > _maxPageSize) ? _maxPageSize : value; }
        }

        public int UserId { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 99;
        public bool Likers { get; set; } = false;
        public bool Likees { get; set; } = false;
        public string OrderBy { get; set; }
    }
}