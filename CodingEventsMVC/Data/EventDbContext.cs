using System;
using CodingEventsMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CodingEventsMVC.Data
{
    public class EventDbContext : DbContext
    {
        
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventCategory> Categories { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<EventTag> EventTags { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Event>()
            //.HasMany(p => p.Tags)
            //.WithMany(p => p.Events)
            //.UsingEntity<EventTag>(
            //    j => j
            //        .HasOne(pt => pt.Tag)
            //        .WithMany(t => t.EventTags)
            //        .HasForeignKey(pt => pt.TagId),
            //    j => j
            //        .HasOne(pt => pt.Event)
            //        .WithMany(p => p.EventTags)
            //        .HasForeignKey(pt => pt.EventId),
            //    j =>
            //    {
            //j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            //    j.HasKey(t => new { t.EventId, t.TagId });
            //});
            modelBuilder.Entity<EventTag>().HasKey(sc => new { sc.EventId, sc.TagId });
        }
    }
}

//A -- https://learn.microsoft.com/en-us/ef/core/modeling/relationships?tabs=data-annotations%2Cfluent-api-simple-key%2Csimple-key#many-to-many
//B -- https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration