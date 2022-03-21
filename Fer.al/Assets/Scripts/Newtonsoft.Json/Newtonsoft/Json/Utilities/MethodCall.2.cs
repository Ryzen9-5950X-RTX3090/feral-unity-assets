namespace Newtonsoft.Json.Utilities
{
	internal delegate TResult MethodCall<T, TResult>(T target, object[] args);
}
