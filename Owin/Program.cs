namespace DynamicPowerShellApi.Owin
{
	using System;

	using DynamicPowerShellApi.Configuration;

	using Microsoft.Owin.Hosting;

	/// <summary>
	/// The main program.
	/// </summary>
	class Program
	{
		/// <summary>
		/// The main.
		/// </summary>
		static void Main()
		{

			try
			{
                // Start OWIN host 
                using (WebApp.Start<Startup>(WebApiConfiguration.Instance.HostAddress))
                {
                    
                    Console.WriteLine("Listening on {0}. Press any key to exit.", WebApiConfiguration.Instance.HostAddress);

                    Console.ReadLine();
                }
			}
			catch (Exception ex)
			{
				Console.WriteLine("Could not start service {0}", ex.Message);
				Console.ReadLine();
			}
		}
	}
}