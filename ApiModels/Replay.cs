namespace MiradorWebAPI.ApiModels
{
    public abstract class Replay
    {
        public int status_code { get; set; }
        public int error_code { get; set; }
        public string message { get; set; }
    }
}
