using System;

namespace Elfin.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ElfinAliasesAttribute : Attribute
    {
        public string[] Aliases;

        public ElfinAliasesAttribute(string[] aliases)
        {
            this.Aliases = aliases;
        }
    }
}