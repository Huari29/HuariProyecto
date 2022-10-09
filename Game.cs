using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Proyecto1_01;
using Proyecto1_01.Extras;
using Proyecto1_01.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Game : GameWindow
    {
        private int TextureType = 2;
        Serealize<Objeto> serealizador = new Serealize<Objeto>();
        private Escenario escenario;
        //private Escenario escenario2;
        //private int angleCounter = 0;
        //Figura triangulo;
        //Figura triangulo2;


        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState inputKey = Keyboard.GetState();

            if (inputKey.IsKeyDown(Key.Number0)) TextureType = 0;
            else if (inputKey.IsKeyDown(Key.Number1)) TextureType = 1;
            else if (inputKey.IsKeyDown(Key.Number2)) TextureType = 2;
            else if (inputKey.IsKeyDown(Key.Number3)) TextureType = 3;
            else if (inputKey.IsKeyDown(Key.Number4)) TextureType = 4;
            else if (inputKey.IsKeyDown(Key.Number5)) TextureType = 5;
            else if (inputKey.IsKeyDown(Key.Number6)) TextureType = 6;
            else if (inputKey.IsKeyDown(Key.Number7)) TextureType = 7;
            else if (inputKey.IsKeyDown(Key.Number8)) TextureType = 8;
            else if (inputKey.IsKeyDown(Key.Number9)) TextureType = 9;
            else if (inputKey.IsKeyDown(Key.Q)) TextureType = 10;
            else if (inputKey.IsKeyDown(Key.W)) TextureType = 11;
            else if (inputKey.IsKeyDown(Key.E)) TextureType = 12;
            else if (inputKey.IsKeyDown(Key.R)) TextureType = 13;
            else if (inputKey.IsKeyDown(Key.T)) TextureType = 14;
            else if (inputKey.IsKeyDown(Key.Y)) TextureType = 15;
            else if (inputKey.IsKeyDown(Key.U)) TextureType = 16;

            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(255, 65, 87, 6);

            // Object3D cube = ObjLoader.loadObj("../../../Casa.obj", new Vector3(0f, 0f, 0f));
            // Object3D roof = ObjLoader.loadObj("../../../Techo.obj", new Vector3(0f, 1.5f, 0f));
            // Object3D cone = ObjLoader.loadObj("../../../Cono.obj", new Vertex(2.5f, 0f, 0f));

            // JSONLoader.SaveFile("../../../object/Casa.json", cube);
            // JSONLoader.SaveFile("../../../object/Techo.json", roof);
            // JSONLoader.SaveFile("../../../object/Cono.json", cone);
            //Dictionary<String, Punto> figura1 = new Dictionary<string, Punto>();
            //figura1.Add("0", new Punto(-1, -1, 2));
            //figura1.Add("1", new Punto(-1, 1, 2));
            //figura1.Add("2", new Punto(-1, 1, -2));
            //figura1.Add("3", new Punto(-1, -1, -2));

            //Dictionary<String, Punto> figura2 = new Dictionary<string, Punto>();
            //figura2.Add("0", new Punto(-1, -1, -2));
            //figura2.Add("1", new Punto(-1, 1, -2));
            //figura2.Add("2", new Punto(1, 1, -2));
            //figura2.Add("3", new Punto(1, -1, -2));

            //Dictionary<String, Punto> figura3 = new Dictionary<string, Punto>();
            //figura3.Add("0", new Punto(1, 0.5, -0.95));
            //figura3.Add("1", new Punto(1, -0.5, -0.95));
            //figura3.Add("2", new Punto(1, -1, -2));
            //figura3.Add("3", new Punto(1, 1, -2));

            //Dictionary<String, Punto> figura4 = new Dictionary<string, Punto>();
            //figura4.Add("0", new Punto(1, -0.5, 0.95));
            //figura4.Add("1", new Punto(1, -1, 2));
            //figura4.Add("2", new Punto(1, -1, -2));
            //figura4.Add("3", new Punto(1, -0.5, -0.95));

            //Dictionary<String, Punto> figura5 = new Dictionary<string, Punto>();
            //figura5.Add("0", new Punto(0.5, -1, 2));
            //figura5.Add("1", new Punto(1, -1, 2));
            //figura5.Add("2", new Punto(1, 1, 2));
            //figura5.Add("3", new Punto(0.5, 0.2, 2));

            //Dictionary<String, Punto> figura6 = new Dictionary<string, Punto>();
            //figura6.Add("0", new Punto(1, 1, -2));
            //figura6.Add("1", new Punto(-1, 1, -2));
            //figura6.Add("2", new Punto(-1, 1, 2));
            //figura6.Add("3", new Punto(1, 1, 2));

            //Dictionary<String, Punto> figura7 = new Dictionary<string, Punto>();
            //figura7.Add("0", new Punto(-0.5, -1, 2));
            //figura7.Add("1", new Punto(-1, -1, 2));
            //figura7.Add("2", new Punto(-1, -1, -2));
            //figura7.Add("3", new Punto(1, -1, -2));
            //figura7.Add("4", new Punto(1, -1, 2));
            //figura7.Add("5", new Punto(0.5, -1, 2));

            //Dictionary<String, Punto> figura8 = new Dictionary<string, Punto>();
            //figura8.Add("0", new Punto(-0.5, 0.2, 2));
            //figura8.Add("1", new Punto(-1, 1, 2));
            //figura8.Add("2", new Punto(-1, -1, 2));
            //figura8.Add("3", new Punto(-0.5, -1, 2));

            //Dictionary<String, Punto> figura9 = new Dictionary<string, Punto>();
            //figura9.Add("0", new Punto(0.5, 0.2, 2));
            //figura9.Add("1", new Punto(1, 1, 2));
            //figura9.Add("2", new Punto(-1, 1, 2));
            //figura9.Add("3", new Punto(-0.5, 0.2, 2));

            //Dictionary<String, Punto> figura10 = new Dictionary<string, Punto>();
            //figura10.Add("0", new Punto(1, 0.5, 0.95));
            //figura10.Add("1", new Punto(1, 1, 2));
            //figura10.Add("2", new Punto(1, -1, 2));
            //figura10.Add("3", new Punto(1, -0.5, 0.95));

            //Dictionary<String, Punto> figura11 = new Dictionary<string, Punto>();
            //figura11.Add("0", new Punto(1, 1, -2));
            //figura11.Add("1", new Punto(1, 1, 2));
            //figura11.Add("2", new Punto(1, 0.5, 0.95));
            //figura11.Add("3", new Punto(1, 0.5, -0.95));

            Objeto casa = serealizador.recuperarArchivo("Casa1");
            Console.WriteLine(casa);
            //Objeto roof = serealizador.recuperarArchivo("Techo");
            //Objeto cone = serealizador.recuperarArchivo("Cono");

            Dictionary<string, Objeto> objetos = new Dictionary<string, Objeto>();
            objetos.Add("casa", casa);
            //objetos.Add("techo", roof);
            //objetos.Add("cono", cone);
            //Dictionary<String, Figura> casa = new Dictionary<string, Figura>();
            //casa.Add("c1", new Figura(figura1, TextureType, new Punto(0,0,0)));
            //casa.Add("c2", new Figura(figura2, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c3", new Figura(figura3, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c4", new Figura(figura4, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c5", new Figura(figura5, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c6", new Figura(figura6, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c7", new Figura(figura7, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c8", new Figura(figura8, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c9", new Figura(figura9, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c10", new Figura(figura10, TextureType, new Punto(0, 0, 0)));
            //casa.Add("c11", new Figura(figura11, TextureType, new Punto(0, 0, 0)));
            //Objeto Casa = new Objeto(casa, new Punto(0,0,0));
            //Dictionary<String, Objeto> objetos = new Dictionary<string, Objeto>();
            //objetos.Add("O1", new Objeto(casa, new Punto(0, 0, 0)));

            escenario = new Escenario(objetos, new Punto(0f, 0f, 0f));

            //serealizador.guardarArchivo(Casa, "Casa1");
            // Punto p1 = new Punto(-0.5, -0.5, 0);
            // Punto p2 = new Punto(0, 0.5, 0);
            // Punto p3 = new Punto(0.5, -0.5, 0);
            // Dictionary<String, Punto> f1 = new Dictionary<string, Punto>();
            // f1.Add("p1", p1);
            // f1.Add("p2", p2);
            // f1.Add("p3", p3);
            //triangulo = new Figura(f1, TextureType, new Punto(0,0,0));
            //triangulo2 = new Figura(f1, TextureType, new Punto(-4, 4, 0));
            //serealizador.guardarArchivo(triangulo,"Triangulo");
            //Dictionary<string, Objeto> objects2 = new Dictionary<string, Objeto>();
            //objects2.Add("cubo", serealizador.recuperarArchivo("Casa"));
            //objects2.Add("techo", serealizador.recuperarArchivo("Techo"));
            //objects2.Add("cono", serealizador.recuperarArchivo("Cono"));
            //Dictionary<String, Figura> c = new Dictionary<String, Figura>();
            //c.Add("1",p1);

            int orthoSize = 5;
            GL.Ortho(-orthoSize, orthoSize, -orthoSize, orthoSize, -orthoSize, orthoSize);

            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);

            escenario.dibujar(TextureType);
           
            //triangulo2.dibujar(TextureType);
            // _scene2.Draw(TextureType);
            GL.Rotate(0.1, 0.1f, 0.1f, 0.2f);
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
    }
}
