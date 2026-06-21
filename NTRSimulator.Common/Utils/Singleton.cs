namespace NTRSimulator.Common.Utils
{
    public abstract class Singleton<T>
        where T : new()
    {
        private static T? instance;

        public static T Instance
        {
            get
            {
                instance ??= new T();
                return instance;
            }
            set => instance = value;
        }
    }
}
