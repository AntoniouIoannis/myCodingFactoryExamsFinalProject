namespace CultureGR_MVC_ModelFirst.Core
{
    public enum UserRole
    {
        Select,
        Admin,              // Owner Full Acces
        ChiefEditor,        //Managed the content strategy, ensuring the quality and reliability of information.
        TextEditor,         // Manages texts, editing the articles 
        WebTextWriter,      // Read, Write (Author, Editor of a new record, for example new Museum)
        DigitalMarketing,  // photographer, video makers
        WebEditor,          //Manages software of Web Site. Collaborates with IT Suport
        ITSuport,          //Manages hardware of Web Site. Collaborates with Web Editor
        SEO_Marketing,      //Collaborates with Web Editor for SEO and marketing 
        Reader,              // Read for Subscraber Viewer 
        Sponsor             //Donate support activities and donate
    }
}
