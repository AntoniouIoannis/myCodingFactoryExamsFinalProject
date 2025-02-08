using System.ComponentModel;

namespace CultureGR_MVC_ModelFirst.Core
{
    public enum CategoryMuseum
    {
        [Description("Ιστορικό Μουσείο")]
        Istoriko,

        [Description("Λαογραφικό Μουσείο")]
        Laografiko,

        [Description("Μουσείο Τέχνης")]
        MouseioTechnis,

        [Description("Μουσείο Φυσικής Ιστορίας")]
        MouseioFysikisIstorias,

        [Description("Μουσείο Τεχνολογίας")]
        MouseioTechnologias,

        [Description("Πολεμικό Μουσείο")]
        Polemiko,

        [Description("Μουσείο Επιστημών")]
        MouseioEpistimon,

        [Description("Νομισματικό Μουσείο")]
        Nomismatiko,

        [Description("Εθνολογικό Μουσείο")]
        Ethnologiko,

        [Description("Φυσικής Ιστορίας")]
        FisikisIstorias
    }
}
