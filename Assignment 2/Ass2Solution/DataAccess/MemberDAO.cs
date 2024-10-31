using BussinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null!;
        private static readonly object instanceLock = new object();
        private MemberDAO(){}
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
        //---------------
        public IEnumerable<MemberObject> GetMembers()
        {
            IDataReader dataReader = null!;
            string SQLSelect = "Select MemberID, Email, Password, CompanyName, City, Country from Member";
            var members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        CompanyName = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
        public MemberObject GetMemberByID(int memberID)
        {
            MemberObject member = null!;
            IDataReader dataReader = null!;
            string SQLSelect = "Select MemberID, Email, Password, CompanyName, City, Country " + "from Member where MemberID = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        CompanyName = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }
            return member;
        }
        //-------------
        public void AddNewMember(MemberObject member)
        {
            try
            {
                MemberObject pro = GetMemberByID(member.MemberID);
                if (pro == null)
                {
                    string SQLInsert = "Insert Member values(@MemberID, @Email, @Password, @CompanyName, @City, @Country)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 15, member.City!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 15, member.Country!, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //----------------------
        public void UpdateMember(MemberObject member)
        {
            try
            {
                MemberObject pro = GetMemberByID(member.MemberID);
                if (pro != null)
                {
                    string SQLUpdate = "Update Member set Email = @Email, Password = @Password, CompanyName = @CompanyName, City =@City, Country = @Country where MemberID = @MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 15, member.City!, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 15, member.Country!, DbType.String));
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //---------
        public void RemoveMember(int memberID)
        {
            try
            {
                MemberObject pro = GetMemberByID(memberID);
                if (pro != null)
                {
                    string SQLDelete = "Delete Member where MemberID = @MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }//End Remove f
        public MemberObject? Login(string Email, string Password)
        {
            MemberObject member = GetMemberByEmail(Email);
            if (member != null)
            {
                return member.Password!.Equals(Password) ? member : null;
            }
            return member;
        }
        public MemberObject GetMemberByEmail(string email)
        {
            MemberObject member = null!;
            IDataReader dataReader = null!;
            string SQLSelect = "Select MemberID, Email, Password, CompanyName, City, Country " + "from Member where Email = @Email";
            try
            {
                var param = dataProvider.CreateParameter("@Email", 100, email, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        CompanyName = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }
            return member;
        }
    }
}
