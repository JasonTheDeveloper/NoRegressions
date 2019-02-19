using CommandLine;

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
    }
}