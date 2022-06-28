using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM_QLCF.Model.Repository;

namespace PM_QLCF.Singleton
{
    internal class SingletonLogin
    {
        
        private Model.TaiKhoan tk;
        private static SingletonLogin instance;
        private static readonly object lockObject = new object();
        private SingletonLogin(Model.TaiKhoan tk)
        {
            this.tk = tk;
        }
        public static SingletonLogin GetInstance(Model.TaiKhoan tk)
        {
            if (instance == null)
            {
                lock (lockObject)
                {

                    if (instance == null)
                    {
                        TaiKhoanRepository repoTK = new TaiKhoanRepository();
                        List<Model.TaiKhoan> listtk = repoTK.GetAllTaiKhoan();
                        foreach (Model.TaiKhoan item in listtk)
                        {
                            if (tk.Username == item.Username && tk.Password == item.Password)
                            {
                                instance = new SingletonLogin(tk);
                                return instance;
                            }
                            else instance = new SingletonLogin(null);
                        }
                    }                  
                }

            }
            return instance;

        }
        public Model.TaiKhoan TaiKhoan()
        {
            return tk;
        }
    }
}