namespace MetaNodes
{
    using System.ComponentModel.DataAnnotations;

    public class Plugin : FileFlows.Plugin.IPlugin
    {
        public string Name => "Meta Nodes";

        public void Init() { }
    }
}