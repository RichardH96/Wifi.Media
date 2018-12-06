using System;
using System.Xml;

namespace TestXmlFile
{
	class Program
	{
		static void Main(string[] args)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(@"C:\Solutions\Beispiel.xml");

			XmlNodeList nodes = xmlDocument.SelectNodes("wifi/contact");
			foreach (XmlNode node in nodes) Console.WriteLine(node.Value);

		}
	}
}
