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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosMoran_Clients_Project.Helpers {
    static public class Filter {


        /// <summary>
        /// Place inside of the KeyPress event handler  for text boxes that 
        /// are only expected to contain numbers to prevent non-numeric values
        /// from being enterred
        /// </summary>
        static public void FilterTextBox_Numeric( object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancel the keypress event if the character is not a digit or backspace
                e.Handled = true;
            }

        }

        /// <summary>
        ///  ValueChanged event handler for datetimepickers; Sets the value to blank if not checked. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static public void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.ShowCheckBox)
            {
                if (dtp.Checked)
                {
                    dtp.Format = DateTimePickerFormat.Short;
                    
                }
                else
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
            }
            else
            {
                dtp.Format = DateTimePickerFormat.Short;
            }
        }
    }
}
