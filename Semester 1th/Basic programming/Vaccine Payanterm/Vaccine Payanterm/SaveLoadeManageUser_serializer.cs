using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Vaccine_Payanterm
{
    [Serializable]
    public class SaveLoadeManageUser_serializer : ISaveLoadManageUser
    {
        public void SaveUserListToFile(string filepath, List<User> userlist)
        {
            FileStream fs1 = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(fs1, userlist);
            fs1.Close();

        }

        public List<User> ReadUserListFromFile(string filepath)
        {
            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryFormatter bformatter = new BinaryFormatter();
            List<User> userlist = (List<User>)bformatter.Deserialize(fs1);
            fs1.Close();
            return userlist;
        }
    }
}
