using CultureGR_MVC_ModelFirst.Core;

namespace CultureGR_MVC_ModelFirst.Data
{
    public partial class User : BaseEntity  //extended 
    {
        public int Id { get; set; }                     //Not manipulated by us. It take efect from the DB
        public Idenity Identity { get; set; }           //retrives form enum class each time new user
        public string Username { get; set; } = null!;   // NOT nullable 
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string RePassword { get; set; } = null!;     // repeat type psw, for the case of wrong typing than the user had his mind
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public required string WorkPhoneNumber { get; set; }  // θα ρτο παρει απο τους Members 
        public UserRole UserRole { get; set; }          //retrives form enum class each time new user

        public virtual WriterArchPlaces? WriterArchPlaces { get; set; }  //Write records for Arch Places & excavations
        public virtual WriterMonuments? WriterMonuments { get; set; }    //Write records Monuments & restorations
        public virtual WriterMuseums? WriterMuseums { get; set; }        //Write records Museums & cultural centers

        public virtual HistorianArchPlaces? HistorianArchPlaces { get; set; } //Managed & Approved records for Arch Places & excavations
        public virtual HistorianMonuments? HistorianMonuments { get; set; }   //Managed & Approved records for Monuments & restorations
        public virtual HistorianMuseums? HistorianMuseums { get; set; }       //Managed & Approved records for Museums & cultural centers

        public virtual Subscriber? Subscriber { get; set; }                   //Website viewer with registration. Does comments & rating on records

        public virtual TextEditor? TextEditor { get; set; }                   //Editing, Correcting all records

    }
}

// this is the navigation property , is virtual! give the certen user the form
//this part of code will complete after the users will be create
//public virtual

//  my research for editorial team about members and roles between them
// https://chatgpt.com/share/679e8a04-ce9c-8009-bf71-ac18ecd0e940 //
// https://chatgpt.com/share/679ea19c-f818-8009-9fcb-860a1ea3350a //
// 1 Chief Editor
// 2 Online Editor
// 3 Writer
// 4 Digital Marketing
// 5 Multimedia Specialist
//


