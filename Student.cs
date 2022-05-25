namespace inheritance
{
    class Student : User
    {

        public Student( )
        {
            
        }
        public int Grade;
        public override void GetData()
        {
            System.Console.WriteLine(Grade);
        }
    }
}
