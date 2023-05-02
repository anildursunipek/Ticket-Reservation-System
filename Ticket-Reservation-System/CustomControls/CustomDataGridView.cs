using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Reservation_System.CustomControls
{
    public partial class CustomDataGridView : Form
    {
        public CustomDataGridView()
        {
            InitializeComponent();
        }

        private void CustomDataGridView_Load(object sender, EventArgs e)
        {
            customDataGrid.Rows.Add(new object[] { "1", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "2", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "3", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "4", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "5", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "6", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "7", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "7", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "7", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "7", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "7", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });
            customDataGrid.Rows.Add(new object[] { "7", "Anıl Dursun İpek", "anildursunipek@gmail.com", "+905315177125", "Man", "11/08/1999" });

        }
    }
}
