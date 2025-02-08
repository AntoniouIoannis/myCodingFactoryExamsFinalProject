namespace CultureGR_MVC_ModelFirst.Data
{
    public class BaseEntity
    {
        public DateTime InsertedAt { get; set; }    // this is for the timestamp of instance for history of actions, records 
        public DateTime ModifiedAt { get; set; }    // this is for the timestamp of instance for history of actions, records 
    }
}
