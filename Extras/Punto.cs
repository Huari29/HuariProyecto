using OpenTK;
using Proyecto1_01.Extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
   
    public class Punto
    {
        public Double X { get; set; }
        public Double Y { get; set; }
        public Double Z { get; set; }

        public Punto(Double x, Double y, Double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //public static Punto operator +(Punto a, Punto b) => new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        //public static Punto operator *(Punto a, Matrix3 b) => new(
          //  a.X * b.M11 + a.Y * b.M21 + a.Z * b.M31, a.X * b.M12 + a.Y * b.M22 + a.Z * b.M32,
            //a.X * b.M13 + a.Y * b.M23 + a.Z * b.M33
       // );
        

        public override string ToString()
        {
            return "[" + X + "|" + Y + "|" + Z + "]";
        }

        public void Set(Punto newVertex)
        {
            X = newVertex.X;
            Y = newVertex.Y;
            Z = newVertex.Z;
        }
    }
}

/*
  public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vertex(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vertex operator +(Vertex a, Vertex b) => new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Vertex operator *(Vertex a, Matrix3 b) => new (
            a.X * b.M11 + a.Y * b.M21 + a.Z * b.M31, a.X * b.M12 + a.Y * b.M22 + a.Z * b.M32,
            a.X * b.M13 + a.Y * b.M23 + a.Z * b.M33
        );

        public override string ToString()
        {
            return "[" + X + "|" + Y + "|" + Z + "]";
        }

        public void Set(Vertex newVertex)
        {
            X = newVertex.X;
            Y = newVertex.Y;
            Z = newVertex.Z;
        }
 */



/*
  //atributos
        private float ejeX { get; set; }
        private float ejeY { get; set; }
        private float ejeZ { get; set; }
        //properties
        public float x { get { return ejeX; } set { ejeX = value; } }
        public float y { get { return ejeY; } set { ejeY = value; } }
        public float z { get { return ejeZ; } set { ejeZ = value; } }


        //contructor con parametros---------------------------------------------------------
        public Punto(float x, float y, float z)
        {
            this.ejeX = x;
            this.ejeY = y;
            this.ejeZ = z;
        }
        //-----------------------------------------------------------------------------------------------------------------
        public Punto() : this(0, 0, 0) { }
        //-----------------------------------------------------------------------------------------------------------------
        //Contructor copia
        public Punto(Punto p)
        {
            this.ejeX = p.ejeX;
            this.ejeY = p.ejeY;
            this.ejeZ = p.ejeZ;
        }
        //-----------------------------------------------------------------------------------------------------------------
        //Contructor con el mismo valor inicial 
        public Punto(float valor)
        {
            this.ejeX = this.ejeY = this.ejeZ = valor;
        }
        //-----------------------------------------------------------------------------------------------------------------
        public Vector3 ToVector3()
        {
            return new Vector3(this.ejeX, this.ejeY, this.ejeZ);
        }
        //-----------------------------------------------------------------------------------------------------------------
        public void acumular(Punto p)
        {
            this.ejeX += p.x;
            this.ejeY += p.y;
            this.ejeZ += p.z;
        }
        public void acumular(float x, float y, float z)
        {
            this.ejeX += x;
            this.ejeY += y;
            this.ejeZ += z;
        }
        public void multiplicar(float x, float y, float z)
        {
            this.ejeX *= x;
            this.ejeY *= y;
            this.ejeZ *= z;
        }
        public void setPunto(float valor)
        {
            this.ejeX = this.ejeY = this.ejeZ = valor;
        }
        //-----------------------------------------------------------------------------------------------------------------
        public bool compareTo(Punto a)
        {
            return (this.ejeX == a.ejeX && this.ejeY == a.ejeY && this.ejeZ == a.ejeZ);
        }
        public override string ToString() => $"({ejeX}|{ejeY}|{ejeZ})";
*/