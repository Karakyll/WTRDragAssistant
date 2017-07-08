using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WTRDragAssistant
{
    [Serializable]
    public class Races
    {
        private List<CheckIn> _races;

        private XmlSerializer formatter = new XmlSerializer(typeof(List<CheckIn>), new XmlRootAttribute() { ElementName = "Races" });

        private string fileName;

        public Races()
        {

        }

        public Races(string fileName)
        {
            this.fileName = fileName;
            _races = new List<CheckIn>();
            Deserialize();
        }

        public void AddNewChekIn(CheckIn checkIn)
        {
            _races.Add(checkIn);
        }

        public void DeleteChekIn(CheckIn checkIn)
        {
            _races.Remove(checkIn);
        }

        public List<CheckIn> GetAllRaces()
        {
            return _races;
        }

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            formatter.Serialize(fs, _races);
            fs.Close();
        }

        private void Deserialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            if (fs.Length == 0)
            {
                fs.Close();
                return;
            }
            var races = (List<CheckIn>)formatter.Deserialize(fs);
            _races = races;
            fs.Close();
        }
    }
}
