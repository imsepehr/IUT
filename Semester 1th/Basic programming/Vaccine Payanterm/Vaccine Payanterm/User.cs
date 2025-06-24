using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Vaccine_Payanterm
{
    [Serializable]
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Adress UAdress { get; set; }
        public DateTime BDate { get; set; }
        public long NationalCode { get; set; }


        public static string UserToString(User user)
        {
            return user.Username + "," +
                user.Password + "," +
                user.FirstName + "," +
                user.LastName + "," +
                user.PhoneNumber + "," +
                user.UAdress.Country + "," +
                user.UAdress.City + "," +
                user.UAdress.Street + "," +
                user.UAdress.PostCode + "," +
                user.BDate + "," +
                user.NationalCode;
            
        }

        public static User StringToUser(string usertext)
        {
            string[] propertiesText = usertext.Split(',');

            Adress adress = new Adress
            {
                Country = propertiesText[5],
                City = propertiesText[6],
                Street = propertiesText[7],
                PostCode = propertiesText[8]
            };

            User user = new User
            {
                Username = propertiesText[0],
                Password = propertiesText[1],
                FirstName = propertiesText[2],
                LastName = propertiesText[3],
                PhoneNumber = propertiesText[4],
                UAdress = adress,
                BDate = Convert.ToDateTime(propertiesText[9]),
                NationalCode=Convert.ToInt64(propertiesText[10])
                

            };

            return user;
        }

    }
}
