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

namespace Proyecto1_01.Json
{
    class Serializador<Obj>
    {
        public void guardarArchivo(Obj objeto, string archivo)
        {
            var miJSon = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(@"D:\Json\" + archivo, miJSon);
        }

        public Obj recuperarArchivo(string archivo)
        {
            var miJson1 = File.ReadAllText(@"D:\Json\" + archivo);
            return JsonConvert.DeserializeObject<Obj>(miJson1);
        }
    }
}
