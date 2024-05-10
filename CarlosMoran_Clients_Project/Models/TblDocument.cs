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

[Table("Tbl_Documents")]
public partial class TblDocument
{
    [Key]
    [Column("id")]
    public string Id { get; set; } = null!;

    [Column("title")]
    public string? Title { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("client_id")]
    public string? ClientId { get; set; }

    [Column("create_date")]
    public long? CreateDate { get; set; }

    [Column("due_date")]
    public long? DueDate { get; set; }

    [Column("filed_date")]
    public long? FiledDate { get; set; }

    /// <summary>
    /// will be null if freal document
    /// </summary>
    [Column("document_id")]
    public string? DocumentId { get; set; }

    [Column("completed")]
    public long? Completed { get; set; }

    /// <summary>
    /// Necessary for entity framework, assigns all data from _d to this
    /// </summary>
    /// <param name="_d"></param>
    public void Copy( TblDocument _d) {
        Id = _d.Id;
        Title = _d.Title;
        Description = _d.Description;
        Type = _d.Type;
        ClientId = _d.ClientId;
        CreateDate = _d.CreateDate;
        FiledDate = _d.FiledDate;
        DueDate = _d.DueDate;
        DocumentId = _d.DocumentId;
    }

}
