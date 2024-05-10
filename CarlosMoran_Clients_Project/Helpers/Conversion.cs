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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarlosMoran_Clients_Project.Helpers {
    public static class Conversion {

        /// <summary>
        ///  Converts a long representing the date in unix epoch time
        /// to a <see cref="DateTime"/> object.
        /// </summary>
        /// <param name="_ue_date">The number of seconds the date is from the unix epoch </param>
        /// <returns>The <see cref="DateTime"/> object as the number of seconds since the unix
        /// epoch</returns>
        public static DateTime FromUnixEpoch(  long? _ue_date) { 
            DateTime res = DateTime.Now;

            if( _ue_date != null && _ue_date.HasValue ) { 
                long seconds = _ue_date.Value;

                res = DateTimeOffset.FromUnixTimeSeconds( seconds ).DateTime;   
                
            }

            return res;
        }


        /// <summary>
        ///  Converts a <see cref="DateTime"/> object to a long representing
        /// the date as unix epoch time.
        /// </summary>
        /// <param name="_date">The date to convert</param>
        /// <returns>The number of seconds since the unix epoch</returns>
        public static long ToUnixEpoch(  DateTime _date ) { 
            //the result....
            long res = 0;

            //get the current date as a date offset
            DateTimeOffset date_asOffset = new DateTimeOffset( _date );

            //convert to long
            res = date_asOffset.ToUnixTimeSeconds();

            //return the result.
            return res;
        }

        /// <summary>
        /// Converts a string <see cref="string">_input</see> into a SHA512 hash string represented\
        /// in hexadecimal
        /// </summary>
        /// <param name="_input">The string to hash</param>
        /// <returns>A string containing the hash represented as hexadecimal</returns>
        public static string ToSha512Hash( string _input) {
            //make the cipher
            SHA512 cipher = SHA512.Create();

            //convert input to bytes for computeHash function
            byte[] input = Encoding.UTF8.GetBytes( _input);
            byte[] hash = cipher.ComputeHash( input );

            //um idk
            StringBuilder str = new();

            //X2 formats in hexadecimal
            foreach(  byte b in hash ) {
                str.Append( b.ToString("X2") );
            }

            //string is what I need
            return str.ToString();
        }

    }
}
