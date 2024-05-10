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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosMoran_Clients_Project.Cryptography {

    public static class PasswordHasher {

        /// <summary>
        /// Takes the password and creates a password hash
        /// </summary>
        /// <param name="password"> The string to hash</param>
        /// <returns> A hash of the password </returns>
        public static string HashPassword(string password) {

            //The hash that will be returned and the salt
            string hash = Conversion.ToSha512Hash( password );
            string salt= Conversion.ToSha512Hash( "D33z_Nut5" );

            //repeat the process password.Length times
            for( int i = 0; i < password.Length; i++) {

                //first round, calculate hash from password
                hash = Conversion.ToSha512Hash( hash );

                //second round, combine both and store hash in hash
                hash = Conversion.ToSha512Hash( hash + salt );

                //third round, do all three, why not.
                hash = Conversion.ToSha512Hash( hash + salt + password );

            }

            //return the computed hash
            return hash;

        }

    }

}
