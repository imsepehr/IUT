using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Vaccine_Payanterm
{
    public class SaveLoadeManageUser_streamwriterreader : ISaveLoadManageUser
    {
        public void SaveUserListToFile(string filepath, List<User> userlist)
        {
            FileStream fs1 = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            foreach (var user in userlist)
            {
                
                writer.WriteLine(User.UserToString(user));
            }
            writer.Close();
            //fs1.Close();
        }

        public List<User> ReadUserListFromFile(string filepath)
        {
            List<User> userlist = new List<User>();
            FileStream fs1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs1);

            string line;
            while((line=reader.ReadLine())!=null)
            {
                userlist.Add(User.StringToUser(line));
            }
            //fs1.Close();

            reader.Close();
            return userlist;

        }
    }
}
