using Microsoft.Win32;
using System.Xml.Linq;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Splash screen
        var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
        Console.WriteLine($"{Path.GetFileNameWithoutExtension(assemblyLocation)}");
        Console.WriteLine($"Version: {fileVersion}");
        Console.WriteLine("This program is licensed under the MIT License.");
        Console.WriteLine("-----------------------------------------------");


        // The location of the configuration file is something like: C:\Users\username\AppData\Roaming\mRemoteNG\confCons.xml
        // Use this path with the local user profile location
        string confConsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "mRemoteNG", "confCons.xml");
        if (!File.Exists(confConsPath))
        {
            Console.WriteLine("mRemoteNG configuration file not found.");
            return;
        }

        // Load confCons.xml 
        XDocument doc = XDocument.Load(confConsPath);

        // Read PuTTY sessions from Registry
        using (var puttyKey = Registry.CurrentUser.OpenSubKey(@"Software\SimonTatham\PuTTY\Sessions"))
        {
            if (puttyKey != null)
            {
                foreach (string sessionName in puttyKey.GetSubKeyNames())
                {
                    // Check if a session entry with the same name already exists
                    if (doc.Root?.Elements("Node").Any(e => e.Attribute("Name")?.Value == sessionName) == true)
                    {
                        Console.WriteLine("Session already exists: " + sessionName);
                        continue;
                    }

                    Console.WriteLine("Processing session: " + sessionName);
                    using (var sessionKey = puttyKey.OpenSubKey(sessionName))
                    {
                        // You can read host, username, etc. from sessionKey.GetValue("HostName"), etc.
                        string host = sessionKey?.GetValue("HostName") as string;
                        string port = sessionKey?.GetValue("Port") as string;
                        string username = sessionKey?.GetValue("UserName") as string;
                        string password = sessionKey?.GetValue("Password") as string;

                        // Create node object
                        var node = new mRemoteNG_PuttyImporter.Node
                        {
                            Name = sessionName,
                            Hostname = host ?? "UnknownHost",
                            Port = port ?? "22",
                            Username = username ?? "UnknownUser",
                            Password = password ?? ""
                        };

                        // Create new connection entry from the node object                        
                        XElement newConnection = XmlHelper.SerializeToXElement(node);

                        // Insert it into the XML structure
                        doc.Root?.Add(newConnection);
                    }
                }
            }
            else
            {
                Console.WriteLine("PuTTY sessions not found in the Registry.");
                return;
            }
        }

        // Save the updated file
        doc.Save(confConsPath);
    }
    public static class XmlHelper
    {
        public static XElement SerializeToXElement<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw, obj);         // Serialize to string
                return XElement.Parse(sw.ToString());  // Parse into XElement
            }
        }
    }
}
