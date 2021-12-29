namespace Core.Utilities.Results
{
    public class SerializeResult : IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
