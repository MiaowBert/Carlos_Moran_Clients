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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DbObjects;

[Table("Tbl_Client")]
public partial class TblClient
{
    [Key]
    [Column("id")]
    public string Id { get; set; } = null!;

    [Column("firstname")]
    public string? Firstname { get; set; }

    [Column("lastname")]
    public string? Lastname { get; set; }

    [Column("dob")]
    public long? Dob { get; set; }

    [Column("anumber")]
    public long? Anumber { get; set; }

    [Column("pointofentry")]
    public string? Pointofentry { get; set; }

    [Column("phonenumber")]
    public long? Phonenumber { get; set; }

    [Column("address_id")]
    public string? AddressId { get; set; }

    [Column("dateofentry")]
    public long? Dateofentry { get; set; }

    [Column("isactive")]
    public int? Isactive { get; set; }

    /// <summary>
    /// This object will have a copy of the _other <see cref=TblClient></see> when it returns
    /// </summary>
    /// <remarks> This is necessary for entity frameworks change tracking</remarks>
    /// <param name="other"> The object to copy </param>
    public void copy( TblClient _other) {
        Id = _other.Id;
        Firstname = _other.Firstname;
        Lastname = _other.Lastname;
        Dob = _other.Dob;
        Anumber = _other.Anumber;
        Pointofentry = _other.Pointofentry;
        Phonenumber = _other.Phonenumber;
        AddressId = _other.AddressId;
        Dateofentry = _other.Dateofentry;
        Isactive = _other.Isactive;

    }
}


/*
    Insert into Tbl_Client ( id , firstname, lastname, dob, anumber, pointofentry, phonenumber, address_id ) VALUES
( '84d9f515-6431-412b-9c65-5b8a0b942763' , 'Bob' , 'Villanueva-Carson' , 1710812505 , 123456789 , 'Your mom' , 1234567890 , 'f69676e3-c0c5-46f1-b5b6-ad7f5a5426e2' );
*/