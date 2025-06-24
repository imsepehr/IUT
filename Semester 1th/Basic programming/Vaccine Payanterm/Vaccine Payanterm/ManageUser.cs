using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Vaccine_Payanterm
{
    public interface ISaveLoadManageUser
    {
        void SaveUserListToFile(string filepath, List<User> userlist);
        List<User> ReadUserListFromFile(string filepath);
    }

    [Serializable]
    class ManageUser
    {
        private readonly string FilePath;
        private List<User> UserList { get; set; }
        private readonly ISaveLoadManageUser _SaveLoader;

        public ManageUser(string filePath, ISaveLoadManageUser saveLoader)
        {
            FilePath = filePath;
            _SaveLoader = saveLoader;
            UserList = new List<User>();

            if (!File.Exists(FilePath))
                File.Create(FilePath).Close();
            else
                UserList = _SaveLoader.ReadUserListFromFile(FilePath);
        }

        public void AddUser(User user)
        {
            UserList.Add(user);
            _SaveLoader.SaveUserListToFile(FilePath, UserList);
        }

        public void RemoveUser(User user)
        {
            UserList.Remove(user);
            _SaveLoader.SaveUserListToFile(FilePath, UserList);
        }

        public List<User> PrintAllUser()
        {
            //foreach (var user in UserList)
            //{
            //    Console.WriteLine(User.UserToString(user));

            //}
            return UserList;
        }

        public void insertUser(int index,User user)
        {
            UserList.Insert(index, user);
            _SaveLoader.SaveUserListToFile(FilePath, UserList);
        }
       
    }

    

    
}
