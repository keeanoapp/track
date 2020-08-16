﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Navtrack.DataAccess.Model;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Navtrack.DataAccess.Migrations.PostgreSql.Migrations
{
    [DbContext(typeof(NavtrackDbContext))]
    [Migration("20200816210332_Migration7")]
    partial class Migration7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Navtrack.DataAccess.Model.AssetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.ConfigurationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.DeviceConnectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("OpenedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RemoteEndPoint")
                        .IsRequired()
                        .HasColumnType("character varying(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("DeviceConnections");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.DeviceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AssetId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DeviceId")
                        .HasColumnType("text");

                    b.Property<int>("DeviceTypeId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("ProtocolPort")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.LocationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal?>("Altitude")
                        .HasColumnType("decimal(7, 2)");

                    b.Property<int>("AssetId")
                        .HasColumnType("integer");

                    b.Property<int?>("CellId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DeviceId")
                        .HasColumnType("integer");

                    b.Property<short?>("GsmSignal")
                        .HasColumnType("smallint");

                    b.Property<decimal?>("HDOP")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<decimal?>("Heading")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<int?>("LocationAreaCode")
                        .HasColumnType("integer");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(9, 6)");

                    b.Property<int?>("MobileCountryCode")
                        .HasColumnType("integer");

                    b.Property<int?>("MobileNetworkCode")
                        .HasColumnType("integer");

                    b.Property<double?>("Odometer")
                        .HasColumnType("double precision");

                    b.Property<bool?>("PositionStatus")
                        .HasColumnType("boolean");

                    b.Property<short?>("Satellites")
                        .HasColumnType("smallint");

                    b.Property<decimal?>("Speed")
                        .HasColumnType("decimal(6, 2)");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("DeviceId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.LogEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.UserAssetEntity", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("AssetId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("UserId", "AssetId");

                    b.HasIndex("AssetId");

                    b.ToTable("UserAsset");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(254)")
                        .HasMaxLength(254);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("character varying(88)")
                        .HasMaxLength(88);

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("character varying(44)")
                        .HasMaxLength(44);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.DeviceEntity", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.AssetEntity", "Asset")
                        .WithMany("Devices")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.LocationEntity", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.AssetEntity", "Asset")
                        .WithMany("Locations")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Navtrack.DataAccess.Model.DeviceEntity", "Device")
                        .WithMany("Locations")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Navtrack.DataAccess.Model.UserAssetEntity", b =>
                {
                    b.HasOne("Navtrack.DataAccess.Model.AssetEntity", "Asset")
                        .WithMany("Users")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Navtrack.DataAccess.Model.UserEntity", "User")
                        .WithMany("Assets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
