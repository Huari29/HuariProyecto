using OpenTK;
using OpenTK.Graphics.OpenGL;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Extras
{
    public class Figura
    {
        public Dictionary<string, Punto> Puntos { get; set; }
        public int figuraColor { get; set; }
        public Punto centro { get; set; }


        public Figura(Dictionary<string, Punto> Puntos, int figuraColor, Punto centro)
        {
            this.Puntos = Puntos;
            this.figuraColor = figuraColor;
            this.centro = centro;
        }

        public void dibujar(int TipoDeTextura)
        {
            Color drawingColor = Color.FromArgb(figuraColor);
            GL.Color4(drawingColor);
            GL.Begin((PrimitiveType)TipoDeTextura);
            foreach (var punto in Puntos)
            {
                GL.Vertex3(punto.Value.X + centro.X, punto.Value.Y + centro.Y, punto.Value.Z + centro.Z);
            }

            GL.End();
            GL.Flush();
        }
    }
}
