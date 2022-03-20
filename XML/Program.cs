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
   public partial class Program : Form 
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
                XML.EntertaimentCenter_ xmlList = (XML.EntertaimentCenter_)xmls.Deserialize(rewData);
                MessageBox.Show("XML обработан");
                return xmlList;
          //  int num = 0;
          //  for (int i = 0; i <= xmlList.shops.ShopsArray.Length; i++)
          // ShopsdataGridView.Rows.Add(xmlList.shops.ShopsArray[num].Sname.ToString(), name, etc); ;
          ////  }

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
