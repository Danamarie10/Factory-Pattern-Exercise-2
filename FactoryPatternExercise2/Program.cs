namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var database = DataAccessFactory.GetDatabase("sql");

            database.LoadData();
            database.SaveData();
        }
    }
}
