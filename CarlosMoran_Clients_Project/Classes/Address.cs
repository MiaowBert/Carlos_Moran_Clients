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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CarlosMoran_Clients_Project.Classes {
    public class Address {

        /// <summary>
        /// For use when creating a new client. Will be filled in hopefully
        /// </summary>
        public Address () { 
            Id = Guid.NewGuid();  
            
            Line1   = "";
            Line2   = "";
            City    = "";
            State   = "";
            Zip     = 0;
        }

        public Address( TblAddress _address ) { 
            
            Id = new Guid( _address.Id );

            Line1   = _address.Line1;
            Line2   = _address.Line2;
            City    = _address.City;
            State   = _address.State;
            Zip     = _address.Zip.Value;

        }

        public TblAddress ToDbObject() {
            return new TblAddress {
                Id = Id.ToString(),
                Line1 = Line1,
                Line2 = Line2,
                City = City,
                State = State,
                Zip = Zip
            };
        }


        public Guid Id { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public long Zip { get; set; }

    }
}
