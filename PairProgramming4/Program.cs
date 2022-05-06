using System;

namespace PairProgramming4
{
    class Program
    {
        static double TryAndCatchDouble(string msg)
        {
            bool f = false;
            double option = 0;
            do
            {
                Console.Write(msg);
                string s = Console.ReadLine();
                try
                {
                    option = double.Parse(s);
                    f = true;

                }
                catch (Exception)
                {

                    Console.WriteLine("Ingreso un dato invalido!!");
                }
            } while (f != true);
            return option;

        }


        static void Main(string[] args)
        {
            Circulo o = new Circulo(0, 10, 10);
            Rectangulo r = new Rectangulo(0, 0, 20, 20);
            Console.WriteLine("UML");
            r.Lado1 = TryAndCatchDouble("Ingrese lado 1: ");
            r.Lado2 = TryAndCatchDouble("Ingrese lado 2: ");
            o.Radio = TryAndCatchDouble("Ingrese el radio del circulo");
            Console.WriteLine(r.ToString());
            Console.WriteLine(o.ToString());

        }
    }

    class Ubicacion
    {
        private double x;
        private double y;

        public Ubicacion(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }

    interface Forma
    {
        public Ubicacion c { get; set; }

        public string ToString();

        public double Area();
        public double Perimetro();
    }

    class Rectangulo : Forma
    {
        protected double lado1 { get; set; }
        protected double lado2 { get; set; }
        public Ubicacion c { get; set; }

        public Rectangulo(double l1, double l2, int x, int y)
        {
            lado1 = l1;
            lado2 = l2;
            c = new Ubicacion(x, y);
        }

        public double Lado1
        {
            get
            {
                return lado1;
            }
            set
            {
                lado1 = value;
            }
        }
        public double Lado2
        {
            get
            {
                return lado2;
            }
            set
            {
                lado2 = value;
            }
        }

        public override string ToString()
        {
            string s = $"Rectangulo:\nLado1: {Lado1}\nLado2: {Lado2}\nArea: {Area()}\nPerimetro: {Perimetro()}\nUbicacion: x= {c.X} y= {c.Y}";
            return s;
        }

        public double Area()
        {
            double r = lado1 * lado2;
            return r;
        }
        public double Perimetro()
        {
            double r = lado1*2 + lado2*2;
            return r;
        }
    }

    class Circulo : Forma
    {
        protected double radio;
        public Ubicacion c { get; set; }

        public Circulo(double r, int x, int y)
        {
            radio = r;
            c = new Ubicacion(x, y);
        }

        public double Radio
        {
            get
            {
                return radio;
            }
            set
            {
                radio = value;
            }
        }

        public override string ToString()
        {
            string s = $"Circulo:\nRadio: {Radio}\nArea: {Area()}\nPerimetro: {Perimetro()}\nUbicacion: x= {c.X} y= {c.Y}";
            return s;
        }

        public double Area()
        {
            double r = Math.Pow(radio, 2)*Math.PI;
            return r;
        }
        public double Perimetro()
        {
            double r = radio*2* Math.PI;
            return r;
        }
    }
}
