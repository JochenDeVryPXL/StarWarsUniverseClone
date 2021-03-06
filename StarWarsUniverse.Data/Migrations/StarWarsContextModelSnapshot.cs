﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarWarsUniverse.Data;

namespace StarWarsUniverse.Data.Migrations
{
    [DbContext(typeof(StarWarsContext))]
    partial class StarWarsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StarWarsUniverse.Domain.Movie", b =>
                {
                    b.Property<string>("Uri")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Edited")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<string>("OpeningCrawl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Producer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uri");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Uri = "http://swapi.dev/api/films/1/",
                            Created = new DateTime(2014, 12, 10, 14, 23, 31, 880, DateTimeKind.Utc),
                            Director = "George Lucas",
                            Edited = new DateTime(2014, 12, 20, 19, 49, 45, 256, DateTimeKind.Utc),
                            EpisodeId = 4,
                            OpeningCrawl = @"It is a period of civil war.
Rebel spaceships, striking
from a hidden base, have won
their first victory against
the evil Galactic Empire.

During the battle, Rebel
spies managed to steal secret
plans to the Empire's
ultimate weapon, the DEATH
STAR, an armored space
station with enough power
to destroy an entire planet.

Pursued by the Empire's
sinister agents, Princess
Leia races home aboard her
starship, custodian of the
stolen plans that can save her
people and restore
freedom to the galaxy....",
                            Producer = "Gary Kurtz, Rick McCallum",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "A New Hope"
                        },
                        new
                        {
                            Uri = "http://swapi.dev/api/films/2/",
                            Created = new DateTime(2014, 12, 12, 11, 26, 24, 656, DateTimeKind.Utc),
                            Director = "Irvin Kershner",
                            Edited = new DateTime(2014, 12, 15, 13, 7, 53, 386, DateTimeKind.Utc),
                            EpisodeId = 5,
                            OpeningCrawl = @"It is a dark time for the
Rebellion. Although the Death
Star has been destroyed,
Imperial troops have driven the
Rebel forces from their hidden
base and pursued them across
the galaxy.

Evading the dreaded Imperial
Starfleet, a group of freedom
fighters led by Luke Skywalker
has established a new secret
base on the remote ice world
of Hoth.

The evil lord Darth Vader,
obsessed with finding young
Skywalker, has dispatched
thousands of remote probes into
the far reaches of space....",
                            Producer = "Gary Kurtz, Rick McCallum",
                            ReleaseDate = new DateTime(1980, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Empire Strikes Back"
                        },
                        new
                        {
                            Uri = "http://swapi.dev/api/films/3/",
                            Created = new DateTime(2014, 12, 18, 10, 39, 33, 255, DateTimeKind.Utc),
                            Director = "Richard Marquand",
                            Edited = new DateTime(2014, 12, 20, 9, 48, 37, 462, DateTimeKind.Utc),
                            EpisodeId = 6,
                            OpeningCrawl = @"Luke Skywalker has returned to
his home planet of Tatooine in
an attempt to rescue his
friend Han Solo from the
clutches of the vile gangster
Jabba the Hutt.

Little does Luke know that the
GALACTIC EMPIRE has secretly
begun construction on a new
armored space station even
more powerful than the first
dreaded Death Star.

When completed, this ultimate
weapon will spell certain doom
for the small band of rebels
struggling to restore freedom
to the galaxy...",
                            Producer = "Howard G. Kazanjian, George Lucas, Rick McCallum",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Return of the Jedi"
                        },
                        new
                        {
                            Uri = "http://swapi.dev/api/films/4/",
                            Created = new DateTime(2014, 12, 19, 16, 52, 55, 740, DateTimeKind.Utc),
                            Director = "George Lucas",
                            Edited = new DateTime(2014, 12, 20, 10, 54, 7, 216, DateTimeKind.Utc),
                            EpisodeId = 1,
                            OpeningCrawl = @"Turmoil has engulfed the
Galactic Republic. The taxation
of trade routes to outlying star
systems is in dispute.

Hoping to resolve the matter
with a blockade of deadly
battleships, the greedy Trade
Federation has stopped all
shipping to the small planet
of Naboo.

While the Congress of the
Republic endlessly debates
this alarming chain of events,
the Supreme Chancellor has
secretly dispatched two Jedi
Knights, the guardians of
peace and justice in the
galaxy, to settle the conflict....",
                            Producer = "Rick McCallum",
                            ReleaseDate = new DateTime(1999, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Phantom Menace"
                        },
                        new
                        {
                            Uri = "http://swapi.dev/api/films/5/",
                            Created = new DateTime(2014, 12, 20, 10, 57, 57, 886, DateTimeKind.Utc),
                            Director = "George Lucas",
                            Edited = new DateTime(2014, 12, 20, 20, 18, 48, 516, DateTimeKind.Utc),
                            EpisodeId = 2,
                            OpeningCrawl = @"There is unrest in the Galactic
Senate. Several thousand solar
systems have declared their
intentions to leave the Republic.

This separatist movement,
under the leadership of the
mysterious Count Dooku, has
made it difficult for the limited
number of Jedi Knights to maintain 
peace and order in the galaxy.

Senator Amidala, the former
Queen of Naboo, is returning
to the Galactic Senate to vote
on the critical issue of creating
an ARMY OF THE REPUBLIC
to assist the overwhelmed
Jedi....",
                            Producer = "Rick McCallum",
                            ReleaseDate = new DateTime(2002, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Attack of the Clones"
                        },
                        new
                        {
                            Uri = "http://swapi.dev/api/films/6/",
                            Created = new DateTime(2014, 12, 20, 18, 49, 38, 403, DateTimeKind.Utc),
                            Director = "George Lucas",
                            Edited = new DateTime(2014, 12, 20, 20, 47, 52, 73, DateTimeKind.Utc),
                            EpisodeId = 3,
                            OpeningCrawl = @"War! The Republic is crumbling
under attacks by the ruthless
Sith Lord, Count Dooku.
There are heroes on both sides.
Evil is everywhere.

In a stunning move, the
fiendish droid leader, General
Grievous, has swept into the
Republic capital and kidnapped
Chancellor Palpatine, leader of
the Galactic Senate.

As the Separatist Droid Army
attempts to flee the besieged
capital with their valuable
hostage, two Jedi Knights lead a
desperate mission to rescue the
captive Chancellor....",
                            Producer = "Rick McCallum",
                            ReleaseDate = new DateTime(2005, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Revenge of the Sith"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
