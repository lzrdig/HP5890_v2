namespace HP5890.DTOs
{
    public class ReadyStateDataObj
    {
        public int RunStatus { get; set; }
        public string Ramp { get; set; }
        public bool OvenSCRAM { get; set; }
        public bool Signal2DetBnotOn { get; set; }
        public bool Signal2DetAnotOn { get; set; }
        public bool Signal1DetBnotOn { get; set; }
        public bool Signal1DetAnotOn { get; set; }
        public bool InjBzoneNotReady { get; set; }
        public bool InjAzoneNotReady { get; set; }
        public bool DetAzoneNotReady { get; set; }
        public bool OvenNotReady { get; set; }
        public bool ExternalNotReady { get; set; }
        public bool DetBzoneNotReady { get; set; }
        public bool HostNotReady { get; set; }
        public bool Fault { get; set; }
    }
}
