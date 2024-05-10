﻿/**
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
using CarlosMoran_Clients_Project.Helpers;

namespace DbObjects;

[Table("Tbl_Users")]
public partial class TblUser
{
    [Key]
    [Column("Username")]
    public string Username { get; set; } = "";

    [Column("Password")]
    public string Password { get; set; } = "";

    [Column("Permissions")]
    public long Permissions { get; set; } = 0;

    [Column("Created")]
    public long Created { get; set; } = 69;

    public DateTime DateCreated() {
        return Conversion.FromUnixEpoch( Created );
    }

}