namespace _27_FrontToBackSqlConnection.Models.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
