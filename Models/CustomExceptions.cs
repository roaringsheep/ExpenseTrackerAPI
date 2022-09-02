[System.Serializable]
public class InvalidCategoryException : System.Exception
{
    public InvalidCategoryException() { }
    public InvalidCategoryException(string message) : base(message) { }
    public InvalidCategoryException(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidCategoryException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}