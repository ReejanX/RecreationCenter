using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_System
{

    class PriceData
    {
        private string _filePath = "price.txt";
        public int PriceID { get; set; }
        public int GroupCount { get; set; }
        public int Duration { get; set; }
        public int WeekendChildPrice { get; set; }
        public int WeekDaysChildPrice { get; set; }
        public int WeekendAdultPrice { get; set; }
        public int WeekDaysAdultPrice { get; set; }
        public int WeekendAgedPrice { get; set; }
        public int WeekDaysAgedPrice { get; set; }

        public List<PriceData> List()
        {
            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
                List<PriceData> lst = JsonConvert.DeserializeObject<List<PriceData>>(d);
                return lst;
            }
            return null;
        }

        public void Delete(int id)
        {

            List<PriceData> list = List();
            PriceData priceDate = list.Where(x => x.PriceID == id).FirstOrDefault();
            list.Remove(priceDate);
            int count = list.Count;
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility1.WriteToTextFile(_filePath, data, false,count);
        }
        public void Add(PriceData info)
        {

            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);

        }
        public void Edit(PriceData info)
        {

            List<PriceData> list = List();
            PriceData s = list.Where(x => x.PriceID == info.PriceID).FirstOrDefault();
            list.Remove(s);
            list.Add(info);
            string data = JsonConvert.SerializeObject(list,Formatting.None);
            Utility1.WriteToTextFile(_filePath, data, false);
        }

    }
}
