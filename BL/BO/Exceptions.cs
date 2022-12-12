namespace BO;

[Serializable]
public class BadIdException : Exception
{
    public BadIdException(string message) : base(message) { }
}

[Serializable]
public class NotEnoughException : Exception
{
    public NotEnoughException(string message) : base(message) { }
}

[Serializable]
public class InternalProblemException : Exception
{
    public InternalProblemException(string message) : base(message) { }
    public InternalProblemException(string message, Exception inner) : base(message, inner) { }
}

[Serializable]
public class EntityDoesNotExistException : Exception
{
    public EntityDoesNotExistException(string message, Exception inner) : base(message, inner) { }
}