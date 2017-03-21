using System;

public class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType<T>(T parameter)
    {
        int output;
        if (int.TryParse(parameter.ToString(), out output))
        {
            return output;
        }
        return null;
    }

    public static bool HandleErrorWithOutParam(string parameter, out int result)
    {
        var output = HandleErrorByReturningNullableType(parameter);
        result = output ?? 0;
        return output != null;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(ErrorHandlingTest.DisposableResource disposbaleResource)
    {
        using (disposbaleResource)
        {
            throw new Exception();
        }
    }
}