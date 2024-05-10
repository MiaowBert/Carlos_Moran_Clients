using CarlosMoran_Clients_Project.Cryptography;
using CarlosMoran_Clients_Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
/**
   Copyright 2024 Nathan Krone

   Licensed under the Creative Commons Attribution-NonCommercial 4.0 International License (CC BY-NC 4.0).
   You may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       https://creativecommons.org/licenses/by-nc/4.0/

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosMoran_Clients_Project.Forms {
    public partial class HelperBox : Form {
        public HelperBox() {
            InitializeComponent();

            ToolTip btn_hash_tooltip = new ToolTip();
            btn_hash_tooltip.SetToolTip( btn_calchash , "Calculate a hash from the string to the left of this button");

            ToolTip btn_pwd_hash_tooltip = new();
            btn_pwd_hash_tooltip.SetToolTip( btn_passwordhash , "Do the full password hash algorithm using the string to the left of this button");

        }

        private void btn_newGuid_Click(object sender, EventArgs e) {
            txt_guidbox.Text = Guid.NewGuid().ToString();
        }

        private void btn_calchash_Click(object sender, EventArgs e) {

            txt_hashresult.Text = Conversion.ToSha512Hash( txt_hashtarget.Text );

        }

        private void btn_passwordhash_Click(object sender, EventArgs e) {

            txt_passwordhashresult.Text = PasswordHasher.HashPassword( txt_passwordhashtarget.Text );

        }
    }
}
