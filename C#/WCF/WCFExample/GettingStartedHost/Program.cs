﻿using System;
using System.ServiceModel;
using GettingStartedLib;
using System.ServiceModel.Description;

namespace GettingStartedHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 Create a URI to server as the base address.
            // The base address is formatted as follows:[transport]://[machine-name or domain][:optional port #]/[optional URI segment] 
             
            Uri baseAddress = new Uri("http://localhost:8899/GettingStarted/");
            // Create a ServiceHost instance
            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                // Step 3 Add a service endpoint
                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }catch(CommunicationException ce)
            {
                Console.WriteLine("An exception ocurred: {0}", ce.Message);
                selfHost.Close();
            }
        }
    }
}
