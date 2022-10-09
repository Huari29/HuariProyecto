using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using System.Collections;

namespace Proyecto1_01.Extras
{
    public class Objeto
    {
        public Dictionary<string, Figura> Lfigura { get; set; }

        public Punto Centro { get; set; }

        public Objeto(Dictionary<string, Figura> figura, Punto centro)
        {
            this.Lfigura = figura;
            this.Centro = centro;
            SetCenter(centro);
        }

        public void SetCenter(Punto nuevocentro)
        {
            foreach (var figura in Lfigura)
                figura.Value.centro = nuevocentro;
        }

        public Punto GetCenter()
        {
            return Centro;
        }

        public Figura getFigura(string key)
        {
            return Lfigura[key];
        }

        public void dibujar(int TextureType)
        {
            foreach (var figura in Lfigura)
                figura.Value.dibujar(TextureType);
        }

        public Dictionary<string, Figura> getFiguras()
        {
            return Lfigura;
        }
    }
}
