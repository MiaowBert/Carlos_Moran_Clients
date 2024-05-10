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
using CarlosMoran_Clients_Project.Helpers;
using DbObjects;

namespace CarlosMoran_Clients_Project.Classes {

    /// <summary>
    /// created from a TblClient object. Discards Address ID in 
    /// exchange for Address object
    /// </summary>
    public class Client {

        public Client() { 
            Id = Guid.NewGuid();
            Address = new Address();

            DateOfBirth = DateTime.Now;
            DateOfEntry = DateTime.Now;

            IsActive = true;
        }

        //create a client from a tblClient
        public Client( TblClient _client ) {

            using( CarlosMoran_Clients db = new()){
                TblAddress? addr = db.TblAddresses?.Where( a => a.Id == _client.AddressId ).FirstOrDefault() ?? null;

                if( addr  != null) {
                    Address = new Address( addr );
                }

            }

            Id = new Guid( _client.Id );
            FirstName = _client.Firstname;
            LastName = _client.Lastname;

            DateOfBirth = Conversion.FromUnixEpoch( _client.Dob );

            PhoneNumber = _client.Phonenumber.Value;

            A_Number = _client.Anumber.Value;
            PointOfEntry = _client.Pointofentry;
            DateOfEntry = Conversion.FromUnixEpoch( _client.Dateofentry );

            IsActive = _client.Isactive != 0 ;

        }

        public TblClient ToDbObject() {
            return new TblClient {
                Id = Id.ToString(),
                Firstname = FirstName,
                Lastname = LastName,
                Dob = Conversion.ToUnixEpoch( DateOfBirth ),
                Phonenumber = PhoneNumber,
                AddressId = Address.Id.ToString(),
                Anumber = A_Number,
                Pointofentry = PointOfEntry,
                Dateofentry = Conversion.ToUnixEpoch( DateOfEntry ),
                Isactive = ( IsActive ? 1 : 0 )
            };
        }

        //personal info
        public Guid     Id { get; set; }
        public string   FirstName { get; set; }
        public string   LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //contact info
        public long     PhoneNumber { get; set; }
        public Address  Address { get; set; }

        //immigration things
        public long     A_Number { get; set; }
        public string   PointOfEntry { get; set; }
        public DateTime DateOfEntry { get; set; }

        //meta data 
        //whether the client is still a client
        public bool IsActive { get; set; }

    }
}
