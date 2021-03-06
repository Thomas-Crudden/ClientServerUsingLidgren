﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServerConsole
{
    public class PlayerData
    {
        public string header = string.Empty;
        public string imageName = string.Empty;
        public string playerID;
        public string gamerTag;
        public float X;
        public float Y;

        public PlayerData(string messageHeader, string ImgName, string GamerTag, string id, float x, float y)
        {
            header = messageHeader;
            playerID = id;
            imageName = ImgName;
            gamerTag = GamerTag;
            X = x;
            Y = y;
        }

        public string PlayerMessage(string header)
        {
            return header + ":" + playerID + ":" + gamerTag + "." + X.ToString() + ":" + Y.ToString();
        }
    }
}
