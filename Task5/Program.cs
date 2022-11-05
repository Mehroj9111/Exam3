namespace Task5;
var st1 = new Student(1, "Mehroj", "123");
var st2 = new Student(2, "Mehroj46", "234");

var tr1 = new Teacher(1, "Anvar", "123");
var tr2 = new Teacher(2, "Hakimov", "234");

var list = new List<User>()
{
    st1,
    st2,
    tr1,
    tr2
};
 foreach(var item in list)
 {
    item.GetUserInfo();
 }