﻿using Sys10.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys10.Data.Mapping
{
    public class ArtistMap : EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            ToTable("Artist");

            HasKey(t => t.Id);
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name").HasMaxLength(500).IsRequired();
            Property(t => t.Type).HasColumnName("Type").IsRequired();
        }
    }
}
