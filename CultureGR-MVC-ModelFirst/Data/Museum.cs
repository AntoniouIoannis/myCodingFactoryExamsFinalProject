using CultureGR_MVC_ModelFirst.Core;

namespace CultureGR_MVC_ModelFirst.Data
{
    public class Museum : BaseEntity
    {
        public int Id { get; set; } //Not manipulated by us. It take efect from the DB
        public string mus_region { get; set; } = null!;   // NOT nullable 
        public string mus_name { get; set; } = null!;
        public string mus_desc { get; set; } = null!;
        public string mus_address { get; set; } = null!;     // repeat type psw, for the case of wrong typing than the user had his mind
        public string mus_coordinate { get; set; } = null!;
        public string mus_phone { get; set; } = null!;
        public string mus_open { get; set; } = null!;
        public CategoryMuseum CategoryMuseum { get; set; }
        public CollectionsGR Collections { get; set; }
        public double mus_avg_rate { get; set; }


        public int UserId { get; set; }

        // FK chacge of plants inactive FKs. replaces by enums in Core subfolder
        //public virtual CategoryMuseum CategoryMuseum { get; set; } = null!;
        //public virtual CollectionGr Collection { get; set; } = null!;
        //public virtual TimePeriod TimePeriod { get; set; } = null!;

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Record> Records { get; set; } = new HashSet<Record>();
    }
}
