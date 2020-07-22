using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using MongoDB.Bson.Serialization;

namespace MsgCountPlusNET.json
{
    public class jColor
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public byte[] bgColor { get; set; }
        public byte[] lineColor { get; set; }

        //public OxyColor bgDefault = OxyColors.Beige;
        //public OxyColor lineDefault = OxyColors.Green;
    }
}
