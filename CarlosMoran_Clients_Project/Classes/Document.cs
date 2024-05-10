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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbObjects;
using CarlosMoran_Clients_Project.Helpers;

namespace CarlosMoran_Clients_Project.Classes {

    public partial class Document
    {
        /// <summary>
        ///  Converts a database object to a better c# object
        /// </summary>
        /// <param name="_document">The document from the database </param>
        public Document( TblDocument _document) {
            Id = new Guid( _document.Id );
            Title = _document.Title;
            Description = _document.Description;
            Type = _document.Type;
            ClientId = new Guid( _document.ClientId );
            CreateDate = Conversion.FromUnixEpoch(  _document.CreateDate );
            DueDate = Conversion.FromUnixEpoch( _document.DueDate );
            FiledDate = Conversion.FromUnixEpoch( _document.FiledDate );
            DocumentId = _document.DocumentId != null ? new Guid( _document.DocumentId ) : null;
            Completed = _document.Completed != 0 ? true : false;
        }

        /// <summary>
        /// Constructor for a new Document with blank data save for the Client Id which is required
        /// </summary>
        /// <param name="_client_id">The id of the client the document is for. </param>
        public Document( Guid _client_id ) {

            Title = "";
            Description = "";
            Type = "";

            Id = Guid.NewGuid();
            ClientId = _client_id;
            CreateDate = DateTime.Now;
            DueDate = DateTime.Now.AddDays( 7 );
            FiledDate = Conversion.FromUnixEpoch(0);
            DocumentId = null;
            Completed = false;

        }

        /// <summary>
        /// converts this document object into the database object equivalent
        /// </summary>
        /// <returns></returns>
        public TblDocument ToDbObject() {
            return new TblDocument {
                Id = Id.ToString(),
                Title = Title,
                Description = Description,
                Type = Type,
                ClientId = ClientId.ToString(),
                CreateDate = Conversion.ToUnixEpoch( CreateDate ),
                DueDate = Conversion.ToUnixEpoch( DueDate ),
                FiledDate = Conversion.ToUnixEpoch( FiledDate ),
                DocumentId = DocumentId == null ? null : DocumentId.ToString(),
                Completed = Completed ? 1 : 0
            };
        }

        public Guid Id { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public Guid ClientId { get; set; }

        /// <summary>
        /// should default to Now but should be editable by the user
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// this should primarily be used for required items attached to a document
        /// </summary>
        // <remarks> ie payment </remarks>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// This is the date that a primary documetn was filed
        /// </summary>
        public DateTime FiledDate { get; set; }

        /// <summary>
        /// This field actually is exclusive to required documents
        /// If a document requires this document, this document must keep 
        /// a copy of the master document
        /// </summary>
        /// <remarks> For freal documents, this value is null</remarks>
        public Guid? DocumentId { get; set; }

        public bool Completed {  get; set; }

    }
}
