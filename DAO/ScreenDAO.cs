namespace DAO
{
    public class ScreenDAO
    {
        private static ScreenDAO instance;

        public static ScreenDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ScreenDAO();
                return ScreenDAO.instance;
            }
        }

        private ScreenDAO() { }
    }

}
