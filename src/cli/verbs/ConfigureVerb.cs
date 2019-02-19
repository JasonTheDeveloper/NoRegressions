using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace cli.Verbs
{
    [Verb("config", HelpText = "Configure the CLI")]
    public class ConfigureVerb
    {
        [Option("azure-blob-string", Required = false, HelpText = "Set Azure Blob connection string. Make sure to wrap connection string around \"\"")]
        public string AzureBlobConnectionString { get; set; }

        [Option('d', "default", Default = false, Required = false, HelpText = "Specify if value is default")]
        public bool IsDefault { get; set; }

        [Option('k', "key", Required = false, HelpText = "The key to the value in settings to change")]
        public string Key { get; set; }

        [Option('v', "value", Required = false, HelpText = "New value of key in settings")]
        public string Value { get; set; }

        [Usage(ApplicationAlias = "noreg")] 
        public static IEnumerable<Example> Examples 
        { 
            get 
            { 
                return new List<Example>() { 
                    new Example("Set CustomVision endpoint", new ConfigureVerb { Key = "cv-endpoint", Value = "https://REGION.api.cognitive.microsoft.com/customvision/v2.0/Prediction/" }),
                    new Example("Set CustomVision key", new ConfigureVerb { Key = "cv-key", Value = "YOUR-PREDICTION-KEY" }),
                    new Example("Set CustomVision project Id", new ConfigureVerb { Key = "cv-projectId", Value = "YOUR-PROJECT-ID" }),
                    new Example("Set CustomVision iteration Id", new ConfigureVerb { Key = "cv-iterationId", Value = "YOUR-ITERATION-ID" }),
                }; 
            } 
        }
    }
}