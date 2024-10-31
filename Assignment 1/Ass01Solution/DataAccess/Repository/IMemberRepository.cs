using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public List<MemberObject> GetMemberList();
        public MemberObject Login(string Email, String Password);
        public void AddMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(int MemberID);
        public List<MemberObject> SearchMember(int id);
        public List<MemberObject> SearchMember(string name);
        public List<MemberObject> SearchMemberByCountry(string country, List<MemberObject> searchList);
        public List<MemberObject> SearchMemberByCity(string country, string city, List<MemberObject> searchList);
    }
}
