
namespace Lecture01
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = CommonHelper.CommonHelper.GetValue("Enter cathetus a:");
            var b = CommonHelper.CommonHelper.GetValue("Enter cathetus b:");
            var result = BeginTask.Begin12(double.Parse(a), double.Parse(b));
            CommonHelper.CommonHelper.Print(result);
        }
    }
}
