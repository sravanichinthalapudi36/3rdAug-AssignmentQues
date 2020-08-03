using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IVolume
    {
      double Volume { get; }

    }
    interface IArea
    {
        double SurfaceAre();
    }
    interface ISolid : IVolume, IArea
    {

    }
    abstract class Solid : ISolid
    {
        public double radius;
        public const double pi = 3.14;
        public abstract double Volume
        {
            get;
        }
        // public double Volume => throw new NotImplementedException();
        public abstract double SurfaceAre();
        public Solid(double _radius,double pi)
        {
            radius = _radius;
        }

  
      
    }
    class Cylinder : Solid
    {
        public double height;
       //public double Volume;
        //public override double Volume
        //{
        //    get;
        //}
        public Cylinder(double _height, double radius,double pi) : base(radius,pi)
        {
            height = _height;
        }
        
        public override double Volume
        {
            get { return pi * radius * radius * height; }
        }
        public override double SurfaceAre()
        {
             return  2 * pi * radius * (radius + height); 
            
        }
        
    }
    class Sphere : Solid
    {
        public Sphere(double _radius,double pi) : base(_radius,pi)
        {

        }
        public override double SurfaceAre()
        {
            return (4 / 3) * pi * radius * radius * radius;
        }
        public override double Volume
        {
            get { return 4 * pi * radius * radius; }
        }
    }
    class Assign3Interface
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder(5.6,3.2,3.14);
            Console.WriteLine("Surface Volume of Cyclinder:{0}",c.Volume);
            Console.WriteLine("Surface Area of Cyclinder:{0}",c.SurfaceAre());
            Console.WriteLine("--------------------------------------------------------------------------");
            Sphere s = new Sphere(3.2, 3.14);
            Console.WriteLine("Surface Volume of Sphere {0}",s.Volume);
            Console.WriteLine("Surface  Volume of area of Sphere {0}",s.SurfaceAre());
            Console.WriteLine("-----------------------------------------------------------------------------");
        }

    }
}
