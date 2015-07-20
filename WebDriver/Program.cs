using IEWebDriverLib;

namespace WebDriver
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			const string cmd =
				@"{""name"": ""newSession"", ""parameters"": {""desiredCapabilities"": {}, ""requiredCapabilities"":{}}, ""sessionId"": null}";
			var wd = new IEWebDriverManager();
			string response;
			wd.ExecuteCommand(cmd, out response);
		}
	}
}