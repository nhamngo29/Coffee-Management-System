using System;

using DAO;

namespace BUS
{
	public class SecurityBUS
	{
		private static SecurityBUS instance;

		public static SecurityBUS Instance
		{
			get
			{
				if (instance == null)
                    instance = new SecurityBUS();
				return instance;
			}
		}

		public SecurityBUS() { }

		public void BackupData(string path)
		{
			try
			{
                SecurityDAO.Instance.BackupData(path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void RestoreData(string path)
		{
			try
			{
                SecurityDAO.Instance.RestoreData(path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
