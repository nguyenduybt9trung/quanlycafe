using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLýQuánCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<QuảnLýQuánCafe.DTO.Menu> GetListMenuByTable(int id)
        {
            List<QuảnLýQuánCafe.DTO.Menu> listMenu = new List<QuảnLýQuánCafe.DTO.Menu>();

            string query = "select f.name, f.price, bi.count, f.price*bi.count as totalPrice from  dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                QuảnLýQuánCafe.DTO.Menu menu = new QuảnLýQuánCafe.DTO.Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
