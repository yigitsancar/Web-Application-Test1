namespace MeetingApp.Models
{
public static class Repository
    {
        private static List<UserInfo> _users= new();


                static Repository()
                {
                    _users.Add(new UserInfo{Id=1, Name="Yigit",Phone="123456789",Email="asd@gsds",WillAttend=true});
                    _users.Add(new UserInfo{Id=2, Name="Akif",Phone="6564564",Email="dsa@daas",WillAttend=false});
                    _users.Add(new UserInfo{Id=3, Name="Alperen",Phone="56464",Email="cxxc@dssd",WillAttend=true});

                }

                public static List<UserInfo> Users{
                    get{
                        return _users;
                    }
                }

                public static void CreateUser(UserInfo user)
                {
                    user.Id = _users.Count + 1;
                    _users.Add(user);
                }

                public static UserInfo? GetById(int id)
                {
                    return _users.FirstOrDefault(info => info.Id == id);
                }

    }   

}