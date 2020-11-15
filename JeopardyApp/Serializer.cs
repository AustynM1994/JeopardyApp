using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyApp
{
    class Serializer
    {
        public static void SerializeNow(Player myPlayer)
        {
            MemoryStream myStream = new MemoryStream();

            BinaryFormatter myFormat = new BinaryFormatter();

            myFormat.Serialize(myStream, myPlayer);

            string serializedValue = Convert.ToBase64String(myStream.ToArray());

            DataAdapter.Insert(serializedValue);

            myStream.Close();
        }

        public static Player DeserializeNow(string encodedData)
        {
            object type;
            Player myPlayer = new Player();

            MemoryStream myStream = new MemoryStream(Convert.FromBase64String(encodedData));
            BinaryFormatter myFormat = new BinaryFormatter();

            type = myFormat.Deserialize(myStream);

            if (type.GetType().Name == "Player")
            {
                myPlayer = (Player)type;
            }

            myStream.Close();

            return myPlayer;
        }
    }
}
