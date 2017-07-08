using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WTRDragAssistant
{
    public class Result
    {
        public Result()
        {

        }
        public Result(string reregistrationPlate, double reactionTime, double elapsedTime)
        {
            this.reregistrationPlate = reregistrationPlate;
            this.elapsedTime = elapsedTime;
            this.reactionTime = reactionTime;
        }
        
        [XmlAttribute]
        public string reregistrationPlate;
        [XmlAttribute]
        public double reactionTime;
        [XmlAttribute]
        public double elapsedTime;
    }
}
