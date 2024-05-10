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
using CarlosMoran_Clients_Project.Helpers;
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
using System.Security.Cryptography;
using CarlosMoran_Clients_Project.Cryptography;

namespace CarlosMoran_Clients_Project.Forms {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) {

            string username = txt_username.Text;
            string password = txt_password.Text;

            //get the password for the provided username and compare it against the
            //provided one
            using( CarlosMoran_Clients db = new()) {
                TblUser? user = db.TblUsers.Where( u => u.Username == username )
                                    .FirstOrDefault() ?? null;

                if( user != null ) {

                    //if password matches
                    if( PasswordHasher.HashPassword( password ) == user.Password ) {

                        //spawn the program
                        MainForm form = new();

                        //hide login screen
                        this.Hide();

                        //show what user is logged in 
                        form.AddMessage($"Logged in as {username}");
                        form.ShowDialog(this);

                        this.Close();

                    }else {
                        MessageBox.Show( "Incorrect Username/Password Combination" );
                    }

                } else {
                    MessageBox.Show( "User not found" );
                } 
            }


        }

        /// <summary>
        /// Dev use only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_newuser_Click(object sender, EventArgs e) {

            //This function is disabled
            //return;

            if( txt_password.Text.Length == 0 || txt_username.Text.Length == 0 ) return;

            TblUser newUser = new TblUser {
                Username = txt_username.Text,
                Password = PasswordHasher.HashPassword( txt_password.Text ),
                Permissions = 15,
                Created = Conversion.ToUnixEpoch( DateTime.Now )
            };

            using ( CarlosMoran_Clients db = new()) {

                db.TblUsers.Add(newUser);

                int res = 0;

                try {
                    //try to save
                    res = db.SaveChanges();

                } catch( Exception ex ) {
                    MessageBox.Show( ex.Message );
                }

                if( res == 0) { MessageBox.Show( "User Failed to Add" ); }
                else {
                    MessageBox.Show( $"New User {newUser.Username} added successfully" );
                }

            }
        }


    }
}
