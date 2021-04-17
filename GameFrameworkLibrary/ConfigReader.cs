using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace GameFrameworkLibrary
{
    public class ConfigReader
    {
        public XmlTextReader reader;

        public void ReadFile(string Filename)
        {
            try
            {
                reader = new XmlTextReader(Filename);

                while (reader.Read())
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}