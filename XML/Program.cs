using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;


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
           XML you = new XML();
            
            MessageBox.Show("Началась обработка данных");
            try
            {
                MemoryStream rewData = new MemoryStream(File.ReadAllBytes(EntertaimentCenter));
                XmlSerializer xmls = new XmlSerializer(typeof(XML.EntertaimentCenter_));
                XML.EntertaimentCenter_ xmlList = (XML.EntertaimentCenter_)xmls.Deserialize(rewData);

                int num = 0;
                you.ShopsdataGridView.Rows.Clear();
                for (int i = 0; i < xmlList.shops.ShopsArray.Length; i++)
                {
                    you.ShopsdataGridView.Rows.Add(xmlList.shops.ShopsArray[num].Sname.ToString(), xmlList.shops.ShopsArray[num]._kindofshop.ToString(), xmlList.shops.ShopsArray[num]._numofworkingplaces.ToString());
                    num++;
                }

                num = 0;
                you.WdataGridView.Rows.Clear();
                for (int i = 0; i < xmlList.workers.WorkerArray.Length; i++)
                {
                    you.WdataGridView.Rows.Add(xmlList.workers.WorkerArray[num].wname.ToString(), xmlList.workers.WorkerArray[num].sex.ToString(), xmlList.workers.WorkerArray[num].age.ToString(), xmlList.workers.WorkerArray[num].position.ToString());
                    num++;
                }
                num = 0;
                you.PdataGridView.Rows.Clear();
                for (int i = 0; i < xmlList.positions.positionArray.Length; i++)
                {
                    you.PdataGridView.Rows.Add(xmlList.positions.positionArray[num].pname.ToString(), xmlList.positions.positionArray[num].dutes.ToString(), xmlList.positions.positionArray[num].payment.ToString());
                    num++;
                }

                MessageBox.Show("XML обработан");
                return xmlList;
            }

            catch (Exception e)
            {
                MessageBox.Show("Ошибка обработки XML данных");
                return null;

            }
            finally
            {
                you.ShowDialog();
            }
           

        }


        

        [STAThread]
        static void Main()
        {
            string EntertaimentCenter = "EntertaimentCenter.xml";
            var result = LoadXML(EntertaimentCenter);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XML());
        }
    }
}
