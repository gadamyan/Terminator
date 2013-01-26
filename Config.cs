using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Terminator
{
    [Serializable]
    public partial class Config
    {
        int currentLevel, accessLevel, speed;
        bool sound, mos;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }
        public bool Mos
        {
            get { return mos; }
            set { mos = value; }
        }
        public bool Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public int CurrentLevel
        {
            get { return currentLevel; }
            set { currentLevel = value; }
        }

        public Config()
        {
            if (!File.Exists("Config.cnf"))
            {
                sound = true;
                currentLevel = 1;
                accessLevel = 1;
                speed = 3;
                mos = true;
                Write();
            }
            else
                Read();
        }

        public void Write()
        {
            FileStream fs = new FileStream("Config.cnf", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public void Read()
        {
            FileStream fs = new FileStream("Config.cnf", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Config NewCnf= (Config)bf.Deserialize(fs);
            fs.Close();
            accessLevel = NewCnf.AccessLevel;
            CurrentLevel = NewCnf.CurrentLevel;
            Mos = NewCnf.Mos;
            Sound = NewCnf.Sound;
            speed = NewCnf.Speed;
        }
    }
}
