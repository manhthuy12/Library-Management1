using BussinessObject;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class MemberDAO
    {
        // Get default user from appsettings
        public static MemberObject GetDefaultMember()
        {
            string basePath = Directory.GetCurrentDirectory();
            string configFilePath = Path.Combine(basePath, "appsettings.json");

            if (!File.Exists(configFilePath))
            {
                throw new FileNotFoundException("appsettings.json not found.");
            }

            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string email = config["account:defaultAccount:email"]!;
            string password = config["account:defaultAccount:password"]!;

            if (email == null || password == null)
            {
                throw new InvalidOperationException("Cấu hình không chứa thông tin mặc định.");
            }

            MemberObject Default = new MemberObject
            {
                MemberID = 1,
                Email = email,
                Password = password,
                City = "",
                Country = "",
                MemberName = "Admin"
            };

            return Default;
        }
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject{MemberID=2, MemberName="NXBach", Email = "bachnx@gmail.com", Password = "123456", City = "Hanoi", Country = "VietNam" },
            new MemberObject{MemberID=3,MemberName="Alan",Email="alan@gmail.com",Password = "123456789",City="London",Country="England"},
            new MemberObject{MemberID=4,MemberName="BBB",Email="bbb@gmail.com",Password = "123456789",City="HCM",Country="VietNam"},
            new MemberObject{MemberID=5,MemberName="CCC",Email="ccc@gmail.com",Password = "123456789",City="DaNang",Country="VietNam"},
            new MemberObject{MemberID=6,MemberName="DDD",Email="ddd@gmail.com",Password = "123456789",City="Liverpool",Country="England"},
            new MemberObject{MemberID=7,MemberName="EEE",Email="eee@gmail.com",Password = "123456789",City="Tokyo",Country="Japan"},
            new MemberObject{MemberID=8,MemberName="FFF",Email="fff@gmail.com",Password = "123456789",City="Osaka",Country="Japan"},
            new MemberObject{MemberID=9,MemberName="GGG",Email="ggg@gmail.com",Password = "123456789",City="Kyoto",Country="Japan"},
        };
        private static MemberDAO instance = null!;
        private static readonly object instanceLock = new object();
        private MemberDAO() 
        {
            MemberObject DefaultAdmin = GetDefaultMember();
            if (DefaultAdmin != null)
            {
                MemberList.Add(DefaultAdmin);
            }
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberObject> GetMemberList() => MemberList;


        public MemberObject Login(string Email, string Password)
        {
            MemberObject member = MemberList.SingleOrDefault(mb => mb.Email.Equals(Email) && mb.Password!.Equals(Password))!;
            return member;
        }
        public MemberObject GetMemberByID(int MemberId)
        {
            return MemberList.SingleOrDefault(mb => mb.MemberID == MemberId)!;
        }
        public MemberObject GetMemberbyEmail(string Email)
        {
            return MemberList.SingleOrDefault(mb => mb.Email.Equals(Email))!;
        }

        //Add new member
        public void AddMember(MemberObject member)
        {
            MemberObject pro = GetMemberByID(member.MemberID);
            if(pro == null) 
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member already Exist");
            }
        }
        //Update Member information
        public void UpdateMember (MemberObject member)
        {
            MemberObject m = GetMemberByID(member.MemberID);
            if(m != null)
            {
                var index = MemberList.IndexOf(m);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
        }
        //Remove a member
        public void Delete(int memberID)
        {
            MemberObject m = GetMemberByID(memberID);
            if (m != null)
            {
                MemberList.Remove(m);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        //Search by ID
        public List<MemberObject> SearchMemberByID(int id)
        {
            List<MemberObject> searchResult = null!;

            var memberSearch = from member in MemberList where member.MemberID == id
                               select member;
            if (memberSearch.Any())
            {
                searchResult = new List<MemberObject>(memberSearch);
            }
            return searchResult;
        }
        public List<MemberObject> SearchMemberByName(string name)
        {
            List<MemberObject> searchResult = null!;

            var memberSearch = from member in MemberList
                               where member.MemberName!.ToLower().Contains(name.ToLower())
                               select member;
            if (memberSearch.Any())
            {
                searchResult = new List<MemberObject>(memberSearch);
            }

            return searchResult;
        }

        public List<MemberObject> SearchMemberByCountry(string country, List<MemberObject> searchList)
        {
            List<MemberObject> searchResult = null!;

            var memberSearch = from member in searchList
                               where member.Country == country
                               select member;
            if (country.Equals("All"))
            {
                memberSearch = from member in searchList
                               select member;
            }
            searchResult = new List<MemberObject>(memberSearch);

            return searchResult;
        }

        public List<MemberObject> SearchMemberByCity(string country, string city, List<MemberObject> searchList)
        {
            List<MemberObject> searchResult = null!;

            var memberSearch = from member in searchList
                               where member.City == city
                               select member;
            if (city.Equals("All"))
            {
                memberSearch = from member in searchList
                               where member.Country == country
                               select member;
                if (country.Equals("All"))
                {
                    memberSearch = from member in searchList
                                   select member;
                }
            }
            searchResult = new List<MemberObject>(memberSearch);

            return searchResult;
        }
    }
}
