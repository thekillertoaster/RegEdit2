using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            debug.Text = "Welcome";
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regfolder.Text);
            key.SetValue(regname.Text,regvalue.Text);
            key.Close();
            debug.Text = "Registry created...";
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            string stringreturn = (string) Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\" + getregfolder.Text,getregname.Text,"Registry does not exist");
            debug.Text = "Registry found, value: " + stringreturn;
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey mykey = Microsoft.Win32.Registry.Users;
            GetSubKeys(mykey);

            
        }
        private void GetSubKeys(Microsoft.Win32.RegistryKey SubKey)
        {
            foreach (string sub in SubKey.GetSubKeyNames())
            {
                MessageBox.Show(sub);
                Microsoft.Win32.RegistryKey local = Microsoft.Win32.Registry.Users;
                local = SubKey.OpenSubKey(sub, true);
                GetSubKeys(local); // By recalling itselfit makes sure it get all the subkey names
            }
        }

    }
}
