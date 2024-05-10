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
using Microsoft.EntityFrameworkCore;

namespace DbObjects;

public partial class CarlosMoran_Clients : DbContext
{
    public CarlosMoran_Clients()
    {
    }

    public CarlosMoran_Clients(DbContextOptions<CarlosMoran_Clients> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAddress>        TblAddresses    { get; set; }

    public virtual DbSet<TblClient>         TblClients      { get; set; }

    public virtual DbSet<TblDocument>       TblDocuments    { get; set; }

    public virtual DbSet<TblSettings>       TblSettings     { get; set; }

    public virtual DbSet<TblColumnWidths>   TblColumnWidths { get; set; }

    public virtual DbSet<TblUser>           TblUsers        { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Filename=CarlosMoran_Clients.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

/*
        scaffolded 

 dotnet ef dbcontext scaffold "Filename=CarlosMoran_Clients.db" Microsoft.EntityFrameworkCore.Sqlite --table Tbl_Client --table Tbl_Documents --table Tbl_Address --output-dir Models --namespace DbObjects --data-annotations --context CarlosMoran_Clients
    
 */
