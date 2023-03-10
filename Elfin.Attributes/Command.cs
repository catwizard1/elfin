namespace Elfin.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ElfinCommandAttribute : Attribute
    {
        public string Name { get; init; }

        public ElfinCommandAttribute(string name)
        {
            this.Name = name;
        }
    }
}