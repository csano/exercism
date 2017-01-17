using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

[TestFixture]
public class ErrorHandlingTest
{
    // Read more about exception handling here:
    // https://msdn.microsoft.com/en-us/library/ms173162.aspx?f=255&MSPPError=-2147217396
    [TestCase]
    public void ThrowException()
    {
        Assert.Throws<Exception>(ErrorHandling.HandleErrorByThrowingException);
    }

    // Read more about nullable types here:
    // https://msdn.microsoft.com/en-us/library/1t3y8s4s.aspx?f=255&MSPPError=-2147217396
    [TestCase]
    public void ReturnNullableType()
    {
        var successfulResult = ErrorHandling.HandleErrorByReturningNullableType("1");
        Assert.That(successfulResult, Is.EqualTo(1));

        var failureResult = ErrorHandling.HandleErrorByReturningNullableType("a");
        Assert.That(failureResult, Is.EqualTo(null));
    }

    // Read more about out parameters here:
    // https://msdn.microsoft.com/en-us/library/t3c3bfhx.aspx?f=255&MSPPError=-2147217396
    [TestCase]
    public void ReturnWithOutParameter()
    {
        int result;
        var successfulResult = ErrorHandling.HandleErrorWithOutParam("1", out result);
        Assert.That(successfulResult, Is.EqualTo(true));
        Assert.That(result, Is.EqualTo(1));
        
        var failureResult = ErrorHandling.HandleErrorWithOutParam("a", out result);
        Assert.That(failureResult, Is.EqualTo(false));
        // The value of result is meaningless here (it could be anything) so it shouldn't be used and it's not validated 
    }

    public class DisposableResource : IDisposable
    {
        public bool IsDisposed { get; private set; }

        public void Dispose()
        {
            IsDisposed = true;
        }
    }

    // Read more about IDisposable here:
    // https://msdn.microsoft.com/en-us/library/system.idisposable(v=vs.110).aspx
    [TestCase]
    [Ignore("Remove to run test")]
    public void DisposableObjectsAreDisposedWhenThrowingAnException()
    {
        var disposableResouce = new DisposableResource();

        Assert.Throws<Exception>(() => ErrorHandling.DisposableResourcesAreDisposedWhenExceptionIsThrown(disposableResouce));
        Assert.That(disposableResouce.IsDisposed, Is.EqualTo(true));
    }
}

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