using Newtonsoft.Json;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Proyecto1_01
{
    class Program
    {
        private static string _path = @"cubo.txt";
        static void Main(string[] args)
        {
            //Punto p = new Punto(0,0,0);
            //Cubo cubo = new Cubo(p,44,44,44);
            //cubo.Dibujar();
            //string miJSon = JsonConvert.SerializeObject(cubo, Formatting.Indented);
             Game juego = new Game(800, 600, "Demo OpenTK");
            var miJSon = JsonConvert.SerializeObject(juego, Formatting.Indented);
            File.WriteAllText(_path, miJSon);
            //Console.WriteLine(miJSon);
            //XmlSerializer xmlSerializer = new XmlSerializer(cubo.GetType());
            //FileStream fileStream = File.Open("cubo.xml", FileMode.Create, FileAccess.Write);
            //xmlSerializer.Serialize(fileStream, cubo);
            //fileStream.Close();
            //fileStream.Dispose();
            // var miJSon = JsonConvert.SerializeObject(juego.cubo);
            //Console.WriteLine(miJSon);
            //string juego2 = File.ReadAllText("juego.txt");
            //Console.WriteLine(juego2);
            //Game juego = JsonConvert.DeserializeObject<Game>(juego2);
            juego.Run(60);           
        }

       

    }
}
