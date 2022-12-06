namespace UserDefinedExceptionHandling
{
    public class TestFitnessMainClass
    {
        public static void Main(string[] args)
        {
            Fitness fitness = new Fitness();
            try
            {
                fitness.showResult();
            }
            catch(FitnessTestFailedException e)
            {
                Console.WriteLine("User Defined Exception - " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Excuted");
            }
        }
    }
}