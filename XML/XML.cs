using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML
{
    [System.Xml.Serialization.XmlRoot("EntertaimentCenter")]
    public partial class XML : Form
    {
        public XML()
        {
            InitializeComponent();
        }


        public class EntertaimentCenter_
        {
            [System.Xml.Serialization.XmlElement("shops")]
            public Shops_ shops { get; set; }

            [System.Xml.Serialization.XmlElement("workers")]

            public Workers_ workers { get; set; }

            [System.Xml.Serialization.XmlElement("positions")]

            public Positions_ positions { get; set; }
        }

        public class Shops_
        {
            [System.Xml.Serialization.XmlElement("shop")]

            public Shop [] ShopsArray { get; set; }
        }


        public class Shop
        {
            [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
            public int sid { get; set; }

            [System.Xml.Serialization.XmlElement("sname", Namespace = "")]
       
            public string Sname { get; set; }

            [System.Xml.Serialization.XmlElement("kindofshop", Namespace = "")]
        
            public string _kindofshop { get; set; }

            [System.Xml.Serialization.XmlElement("numofworkingplaces", Namespace = "")]

            public int _numofworkingplaces { get; set; }
        }
        
        public class Workers_
        {
            [System.Xml.Serialization.XmlElement("worker")]
            public Worker [] WorkerArray { get; set; }
        }
         
        public class Worker
        {
            [System.Xml.Serialization.XmlAttribute("number", Namespace = "")]
            
            public int wnum { get; set; }

            [System.Xml.Serialization.XmlElement("wname", Namespace = "")]
       
            public string wname { get; set; }

            [System.Xml.Serialization.XmlElement("sex", Namespace = "")]
       
            public string sex { get; set; }
            [System.Xml.Serialization.XmlElement("age", Namespace = "")]
            public int age { get; set; }
            [System.Xml.Serialization.XmlElement("workingplace", Namespace = "")]
            public int workingplace { get; set; }
            [System.Xml.Serialization.XmlElement("position", Namespace = "")]
       
            public int position { get; set; }
        }

        public class Positions_
        {
            [System.Xml.Serialization.XmlElement("position")]
        
            public Position [] positionArray { get; set; }
        }

        public class Position
        {
            [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
            public int pid { get; set; }

            [System.Xml.Serialization.XmlElement("name", Namespace = "")]

            public string pname { get; set; }

            [System.Xml.Serialization.XmlElement("dutes", Namespace = "")]

            public string dutes { get; set; }

            [System.Xml.Serialization.XmlElement("payment", Namespace = "")]

            public int payment { get; set; }


        }








    }
}
