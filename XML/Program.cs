using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace XML
{
    class Program
    {
        public static XML.EntertaimentCenter_ LoadXML (string EntertaimentCenter)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(EntertaimentCenter);

            if (!File.Exists(EntertaimentCenter))
            {
                MessageBox.Show("Нет доступа к файлу: {0}", EntertaimentCenter);

                return null;
            }

            MessageBox.Show("Началась обработка данных");
          //  try
           // {
                MemoryStream rewData = new MemoryStream(File.ReadAllBytes(EntertaimentCenter));
                XmlSerializer xmls = new XmlSerializer(typeof(XML.EntertaimentCenter_));
                var xmlList = (XML.EntertaimentCenter_)xmls.Deserialize(rewData);
                MessageBox.Show("XML обработан");
                return xmlList;
          //  }

           // catch (Exception e)
         //   {
                MessageBox.Show("Ошибка обработки XML данных");
                return null;
           // }


        }




        [STAThread]
        static void Main()
        {
            string EntertaimentCenter = "EntertaimentCenter.xml";
            var result = LoadXML(EntertaimentCenter);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XML());
        }
    }
}
