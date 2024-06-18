namespace DS_Practice 
{
    public abstract class Abstratex1 
    {
        public abstract void M1();
        public abstract void M2();
    }

    public class A : Abstratex1
    {
        public override void M1()
        {
            throw new NotImplementedException();
        }

        public override void M2()
        {
            throw new NotImplementedException();
        }
    }
    
}