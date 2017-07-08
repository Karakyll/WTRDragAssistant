using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WTRDragAssistant
{
    public class CheckIn
    {
        public CheckIn()
        {

        }
        public CheckIn(DateTime dateTime, Result leftCar, Result rightCar)
        {
            this.dateTime = dateTime;
            this.leftCar = leftCar;
            this.rightCar = rightCar;
        }
        [XmlAttribute]
        public DateTime dateTime;
        [XmlElement]
        public Result leftCar;
        [XmlElement]
        public Result rightCar;
    }
}
