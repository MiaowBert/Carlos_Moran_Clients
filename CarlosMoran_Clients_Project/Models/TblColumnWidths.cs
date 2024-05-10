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

[Table("Tbl_ColumnWidths")]
public partial class TblColumnWidths
{
    [Key]
    [Column("Id")]
    public string Id { get; set; } = null!;

    [Column("col1")]
    public long? Column1 { get; set; }

    [Column("col2")]
    public long? Column2 { get; set; }

    [Column("col3")]
    public long? Column3 { get; set; }

    [Column("col4")]
    public long? Column4 { get; set; }

    [Column("col5")]
    public long? Column5 { get; set; }

    public List<int> GetRows() {
        List<int> res = new();

        try {
            res.Add( (int)Column1 );
            res.Add( (int)Column2 );    
            res.Add( (int)Column3 );
            res.Add( (int)Column4 );
            res.Add( (int)Column5 );
        } catch (Exception ex) {
            MessageBox.Show( "Bruh .. ERR08 ");

        }
        return res;
    }

    public void SetRows( List<int> newValues ) {

        try {
            Column1 = (long?)newValues[0];
            Column2 = (long?)newValues[1];
            Column3 = (long?)newValues[2];
            Column4 = (long?)newValues[3];
            Column5 = (long?)newValues[4];
        } catch( Exception e ) { }

    }

}

