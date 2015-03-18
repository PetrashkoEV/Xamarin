using SelfEducation.Business.Private;

namespace SelfEducation.Business.Service
{
    public class LogInService : ILogInService
    {
        public int ReturnNum(int x)
        {
            return ++x;
        }
    }
}