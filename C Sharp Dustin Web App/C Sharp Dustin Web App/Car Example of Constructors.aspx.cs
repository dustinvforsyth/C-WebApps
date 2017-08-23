using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C_Sharp_Dustin_Web_App
{
    public partial class Car_Example_of_Constructors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var seat1 = new seat("Gray", "Leather");
            var seat2 = new seat();
            var engine1 = new engine();
            var engine2 = new engine(12, "high compression", "48 valve hi flow", "High lift stroker", "internal coil and HV ignition", "fuel injected");

            var car = new car(4, 5);
            car.addSeat(seat1);
            car.addSeat(seat2);

            


        }





    }

    public class car
    {
        private int _Doors;
       public int Doors { get { return _Doors; } private set { _Doors = value; } }
        public int Windows;
        public List<seat> seats;
        public engine Engine;
        public car(int doors, int windows)
        {
            Doors = doors;
            Windows = windows;
            seats = new List<seat>();
            
        }

        public void addSeat(seat seat)
        {
            seats.Add(seat);

        }
        public void addEngine(engine engine)
        {
            Engine = engine;
        }
    }
    public class seat
    {
        public string Color;
        public string Type;
        public seat(string color, string type)
        {
            Color = color;
            Type = type;

        }
        public seat()
        {
            Color = "Black";
            Type = "cloth";
        }
    }
        
    public class engine
    {
        public int cylinders;
        public string crank;
        public int connectingRod;
        public string cylinderHead;
        public string cam;
        public string distributor;
        public string intake;

        public engine(int howManyCylinders, string whatCrank, string whatCylinderHead, string whatCam, string whatDistributer, string whatIntake)
        {
            cylinders = howManyCylinders;
            connectingRod = howManyCylinders;
            crank = whatCrank;
            cylinderHead = whatCylinderHead;
            cam = whatCam;
            distributor = whatDistributer;
            intake = whatIntake;
 
        }


        public engine()
        {
            cylinders = 8;
            crank = "Standard Crank";
            connectingRod = 8;
            cylinderHead = "24 valve, Overhead Cam";
            cam = "High lift, High flow overhead cam";
            distributor = "Ignition coil contained electronic ignition";
            intake = "Fuel injected";
        }

    }

}

