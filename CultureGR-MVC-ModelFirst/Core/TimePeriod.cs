using System.ComponentModel;

namespace CultureGR_MVC_ModelFirst.Core
{
    public enum TimePeriod
    {
        [Description("Παλαιολιθική περίοδος")]
        PalaiolithikiPeriodos,

        [Description("Μεσολιθική περίοδος")]
        MesolithikiPeriodos,

        [Description("Νεολιθική περίοδος")]
        NeolithikiPeriodos,

        [Description("Εποχή του Χαλκού")]
        EpoxiTouXalkou,

        [Description("Εποχή του Σιδήρου")]
        EpoxiTouSidirou,

        [Description("Αρχαϊκή περίοδος")]
        ArchaikiPeriodos,

        [Description("Κλασική περίοδος")]
        KlassikiPeriodos,

        [Description("Ελληνιστική περίοδος")]
        EllinistikiPeriodos,

        [Description("Ρωμαϊκή περίοδος")]
        RomaikiPeriodos,

        [Description("Βυζαντινή περίοδος")]
        VyzantiniPeriodos,

        [Description("Οθωμανική περίοδος")]
        OthomanikiPeriodos,

        [Description("Νεότερη Ελληνική περίοδος")]
        NeoteraEllinikiPeriodos
    }
}
