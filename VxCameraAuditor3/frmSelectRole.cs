using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VxCameraAuditor3
{
    public partial class frmSelectRole : Form
    {
        public List<vxRole> roleselector { get; set; }

        public vxRole selected_role { get; set; }

        public frmSelectRole(List<vxRole> _systemroles)
        {
            InitializeComponent();
            roleselector = _systemroles;
            olvRoleListSelector.SetObjects(roleselector);
        }

        private void olvRoleListSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_role = (vxRole)olvRoleListSelector.SelectedObject;
        }
    }
}
