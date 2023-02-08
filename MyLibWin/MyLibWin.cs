namespace MyLibWin
{
    public class MyLibWin
    {
        public string DoSomethingWin()
        {
            var libEng = new MyLibEng.MyLibEng();
            return $"MyLibEng.DoSomethingWin() was called => {libEng.DoSomethingEng()}";
        }
    }
}