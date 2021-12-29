namespace Core.Utilities.Results
{
    public class SerializeDataResult<T> : SerializeResult, IDataResult<T>
    {
        public T Data { get; set; }
    }
}
