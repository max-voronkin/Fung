using System.Reflection;

namespace Fung.BLL.Services
{
    public static class ResourceService
    {
        private readonly static Dictionary<string, string> resources = new();

        public static async Task<string> GetResource(string resourceName)
        {
            if (resources.TryGetValue(resourceName, out string? value))
            {
                return value;
            }
            string resource = await Read(resourceName);
            resources.Add(resourceName, resource);
            return resource;
        }

        private static async Task<string> Read(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var s = assembly.GetManifestResourceNames();
            string path = assembly.GetManifestResourceNames().Single(res => res.EndsWith(resourceName));
            using (Stream stream = assembly.GetManifestResourceStream(path)!)
            {
                using (StreamReader sr = new(stream))
                {
                    return await sr.ReadToEndAsync();
                }
            }
        }
    }
}
