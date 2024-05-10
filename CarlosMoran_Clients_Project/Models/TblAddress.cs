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

[Table("Tbl_Address")]
public partial class TblAddress
{
    [Key]
    [Column("id")]
    public string Id { get; set; } = null!;

    [Column("line1")]
    public string? Line1 { get; set; }

    [Column("line2")]
    public string? Line2 { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("zip")]
    public long? Zip { get; set; }

    /// <summary>
    /// clones all of the arguments fields except for Id
    /// </summary>
    /// <param name="rhs"></param>
    public void copy( TblAddress rhs) {
        Line1 = rhs.Line1;
        Line2 = rhs.Line2;
        City = rhs.City;
        State = rhs.State;
        Zip = rhs.Zip;
    }

}

/*
 Insert into Tbl_Address (  id, line1, line2, city, state, zip ) VALUES
( '03c9595d-c16f-48ba-a0eb-4fdc84ff4e20','22 Broadwaay','','minkastai','catabula',90215); 
 */

/*
 INSERT INTO Tbl_Address (id, line1, line2, city, state, zip) VALUES 
('b2994647-66d0-4e7f-b6d8-baa34eb92cb4', '123 Main St', 'Apt 1', 'New York', 'NY', 10001),
('2d58c3e1-5b95-4d59-86d2-78778f82351e', '456 Elm St', '', 'Los Angeles', 'CA', 90001),
('92502d2a-f8a4-4376-95ed-00d46db9f98a', '789 Oak St', 'Suite 100', 'Chicago', 'IL', 60601),
('a1f52f3d-2f45-4f63-8eb0-2f1924f99965', '101 Pine St', '', 'Houston', 'TX', 77002),
('685b6653-492f-432f-9b44-9fbc8c4ebe6c', '222 Maple St', 'Unit B', 'Phoenix', 'AZ', 85001),
('e6aeb99f-7b6d-4a49-b713-7d9783b8af02', '777 Cedar St', '', 'Philadelphia', 'PA', 19103),
('cba2b2cc-b50a-46d1-88cb-c2d098bc83c5', '888 Birch St', 'Suite 300', 'San Antonio', 'TX', 78205),
('78c6d42c-4a2b-4bc4-a907-aa848d19cfa3', '999 Walnut St', 'Floor 5', 'San Diego', 'CA', 92101),
('4b14daa4-909e-4463-81ae-0c42a3d3c489', '333 Ash St', '', 'Dallas', 'TX', 75201),
('f4bc7d82-4c05-4b3f-8e0f-647b7e19086c', '555 Pineapple St', 'Penthouse', 'Miami', 'FL', 33101);
 */