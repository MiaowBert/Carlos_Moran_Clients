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

namespace DbObjects;

/// <summary>
/// The object containing all the custom user settings for the app. 
/// </summary>
/// <remarks> The caller must implement this stuff on their side </remarks>
[Table("Tbl_Settings")]
public partial class TblSettings
{
    [Key]
    [Column("id")]
    public string Id { get; set; } = null!;

    [Column("bgcolor")]
    public long? Backgroundcolor{ get; set; }

    [Column("txtcolor")]
    public long? Textcolor{ get; set; }

    [Column("phonelength")]
    public long? Phonenumberlength{ get; set; }

    [Column("zipcodelength")]
    public long? Zipcodelength{ get; set; }

    public void ApplySettings( Form form) {

        try {
            form.BackColor = Color.FromArgb( (int)Backgroundcolor.Value );
            form.ForeColor = Color.FromArgb( (int)Textcolor.Value );
        }catch ( Exception ex) { }

    }

}
