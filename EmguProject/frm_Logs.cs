using DataLayer;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguProject
{
    public partial class frm_Logs : Form
    {
        AppDbContext _context = new AppDbContext();
        public frm_Logs()
        {
            InitializeComponent();
        }

        private void frm_Logs_Load(object sender, EventArgs e)
        {
            dgv_Logs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var logs = _context.Logs.ToList().Select(_ => new { UserId = _.UserId, Date = _.TimeStamp, Message = _.Message });
            
            dgv_Logs.DataSource = new BindingSource(logs, null);
        }
    }
}
