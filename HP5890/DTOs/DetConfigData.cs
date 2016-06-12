namespace HP5890.DTOs
{
    enum DetType { FID, TCD, NPD, NONE, ECD, RESERVED1, RESERVED2 };

    public class DetectorConfigDataObj
    {
        DetType DetA { get; set; }
        DetType DetB { get; set; }
        bool InjAheatZone { get; set; }
        bool InjBheatZone { get; set; }
        bool DetAheatZone { get; set; }
        bool DetBheatZone { get; set; }
    }
}
