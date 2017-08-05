using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace stvShadowGroup
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
    }

    //Element host which will host the control - in main you reffer to this class only.
    public class GroupHoster_WinformsHost : System.Windows.Forms.Integration.ElementHost
    {
        protected UserControl1 _usrctrl = new UserControl1();

        public GroupHoster_WinformsHost()
        {
            base.Child = _usrctrl;
        }
    }
}
