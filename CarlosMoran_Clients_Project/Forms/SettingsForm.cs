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
using DbObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosMoran_Clients_Project.Forms {
    public partial class SettingsForm : Form {
        protected TblSettings settings;

        public SettingsForm() {
            InitializeComponent();

            LoadSettings();

            RefreshSettings();

        }

        /// <summary>
        /// Updates the ui elements with the values from the settings object
        /// </summary>
        /// <remarks>Use if loading the settings form</remarks>
        protected void RefreshSettings() {

            try {
                if (settings != null) {
                    pbx_bgcolor.BackColor = Color.FromArgb((int)settings.Backgroundcolor);
                    pbx_txtcolor.BackColor = Color.FromArgb((int)settings.Textcolor);

                    nmc_phonenumlen.Value = (int)settings?.Phonenumberlength;
                }
            } catch (Exception ex) { }

        }

        /// <summary>
        /// Loads the settings object from the database
        /// </summary>
        /// <remarks>yup</remarks>
        protected void LoadSettings() {

            using (CarlosMoran_Clients db = new()) {
                TblSettings? _settings = db.TblSettings.First() ?? null;

                if (_settings != null) {
                    settings = _settings;

                    settings.ApplySettings(this);
                }
            }

        }


        private void SettingsForm_Load(object sender, EventArgs e) {

        }

        private void btn_apply_Click(object sender, EventArgs e) {

            //save the current settings
            settings.Backgroundcolor = (long)pbx_bgcolor.BackColor.ToArgb();
            settings.Textcolor = (long)pbx_txtcolor.BackColor.ToArgb();

            settings.Phonenumberlength = (long)nmc_phonenumlen.Value;

            settings.ApplySettings(this);

            using (CarlosMoran_Clients db = new()) {
                TblSettings? _settings = db.TblSettings?.First() ?? null;
                if (_settings != null) {

                    _settings.Backgroundcolor = settings.Backgroundcolor;
                    _settings.Textcolor = settings.Textcolor;
                    _settings.Phonenumberlength = settings.Phonenumberlength;

                }

                int res = db.SaveChanges();

                if (res == 0) { MessageBox.Show("Error updating settings"); }
            }

        }

        private void pbx_bgcolor_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();

            var result = colorDialog.ShowDialog();

            if (result == DialogResult.OK) {
                settings.Backgroundcolor = colorDialog.Color.ToArgb();
                pbx_bgcolor.BackColor = colorDialog.Color;
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pbx_txtcolor_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();

            var result = colorDialog.ShowDialog();

            if (result == DialogResult.OK) {
                settings.Textcolor = colorDialog.Color.ToArgb();
                pbx_txtcolor.BackColor = colorDialog.Color;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            btn_apply_Click(sender, e);
            btn_cancel_Click(sender, e);
        }

        private void nmc_zipcodelength_ValueChanged(object sender, EventArgs e) {
           if( nmc_zipcodelength.Value < 1 ) nmc_zipcodelength.Value = 1;
        }
    }
}
