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
using Proyecto1_01.Extras;

namespace Proyecto1_01
{
    class Serealize<Obj>
    {
        /*public Cubo cubo;
        public Game game;
        public Punto punto;
        public Escenario escenario;
        */
        //------------------------------GUARDAR----------------------------------------------
        public void guardarArchivo(Obj objeto,string archivo)
        {
            var miJSon = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(@"D:\Json\"+archivo+".txt", miJSon);
        }
        public void guardarArchivo(Dictionary<Obj, Obj> objeto, string archivo)
        {
            var miJSon = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(@"D:\Json\" + archivo + ".txt", miJSon);
        }
        /*public void guardarGame(Game objeto, string archivo)
        {
            var miJSon = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(@"D:\Json\" + archivo + ".txt", miJSon);
        }
        public void guardarPunto(Punto objeto, string archivo)
        {
            var miJSon = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(@"D:\Json\" + archivo + ".txt", miJSon);
        }
        public void guardarEscenario(Escenario objeto, string archivo)
        {
            var miJSon = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(@"D:\Json\" + archivo + ".txt", miJSon);
        }*/

        //------------------------------------RECUPERAR-----------------------------------------
        public Obj recuperarArchivo(string archivo)
        {
            var miJson1 = File.ReadAllText(@"D:\Json\" + archivo+".txt");
            return JsonConvert.DeserializeObject<Obj>(miJson1);
        }
        /*
        public Game recuperarGame(string archivo)
        {
            var miJson1 = File.ReadAllText(@"D:\Json\" + archivo + ".txt");
            return game = JsonConvert.DeserializeObject<Game>(miJson1);
        }
        public Punto recuperarPunto(string archivo)
        {
            var miJson1 = File.ReadAllText(@"D:\Json\" + archivo + ".txt");
            return punto = JsonConvert.DeserializeObject<Punto>(miJson1);
        }
        public Escenario recuperarEscenario(string archivo)
        {
            var miJson1 = File.ReadAllText(@"D:\Json\" + archivo + ".txt");
            return escenario = JsonConvert.DeserializeObject<Escenario>(miJson1);
        }*/
    }
}

