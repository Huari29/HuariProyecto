using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Collections;

namespace Proyecto1_01.Extras
{
    public class Escenario
    {
        public Dictionary<string, Objeto> objetos;
        public Punto centro;

        public Escenario(Dictionary<string, Objeto> objeto, Punto centro)
        {
            this.objetos = objeto;
            this.centro = centro;
            SetCentro(centro);
        }

        public void SetCentro(Punto centro)
        {
            foreach (var objetos in objetos)
            {
                Punto formerCenter = objetos.Value.GetCenter();
                //object3D.Value.SetCenter(centro + formerCenter);
            }
        }

        public Punto GetCentro()
        {
            return centro;
        }

        public Dictionary<string, Objeto> GetObjeto()
        {
            return objetos;
        }

        public Objeto GetObjeto(string key)
        {
            return objetos[key];
        }
        public void dibujar(int TextureType)
        {
            foreach (var object3D in objetos)
                object3D.Value.dibujar(TextureType);
        }
    }
}
