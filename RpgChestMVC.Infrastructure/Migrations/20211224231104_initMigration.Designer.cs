﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgChestMVC.Infrastructure;

namespace RpgChestMVC.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211224231104_initMigration")]
    partial class initMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.BonusDmgFromElemental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FullWeaponTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FullWeaponTypeId");

                    b.ToTable("BonusDmgFromElementals");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.FullArmorType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DailyRegenerationFor4Turns")
                        .HasColumnType("int");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<int>("HpPerLvl")
                        .HasColumnType("int");

                    b.Property<int>("ItemRef")
                        .HasColumnType("int");

                    b.Property<int>("Kp")
                        .HasColumnType("int");

                    b.Property<int>("MagicalAbsorption")
                        .HasColumnType("int");

                    b.Property<int>("MagicalReduction")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalAbsorption")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalReduction")
                        .HasColumnType("int");

                    b.Property<int>("ResistanceForAll")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemRef")
                        .IsUnique();

                    b.ToTable("FullArmorTypes");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.FullWeaponType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bonus10ForKpPenetration")
                        .HasColumnType("int");

                    b.Property<int>("BonusDmgVsSummons")
                        .HasColumnType("int");

                    b.Property<int>("BonusSA")
                        .HasColumnType("int");

                    b.Property<int>("CritBonusDmg")
                        .HasColumnType("int");

                    b.Property<int>("CritChance")
                        .HasColumnType("int");

                    b.Property<int>("CritMultiplier")
                        .HasColumnType("int");

                    b.Property<int>("Dmg")
                        .HasColumnType("int");

                    b.Property<int>("ExtraKpPenetrationForHammer")
                        .HasColumnType("int");

                    b.Property<int>("ExtraWeaponRange")
                        .HasColumnType("int");

                    b.Property<int>("HpDrain")
                        .HasColumnType("int");

                    b.Property<int>("ItemRef")
                        .HasColumnType("int");

                    b.Property<int>("ShieldPointDestroyer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemRef")
                        .IsUnique();

                    b.ToTable("FullWeaponTypes");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Concentration")
                        .HasColumnType("int");

                    b.Property<int>("ItemLvl")
                        .HasColumnType("int");

                    b.Property<int>("RarityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RarityId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.Rarity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Rarities");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.Resistance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasicResistances")
                        .HasColumnType("int");

                    b.Property<int>("FullArmorTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ValueR")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FullArmorTypeId");

                    b.ToTable("Resistances");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.TypeOfArmor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnumArmorType")
                        .HasColumnType("int");

                    b.Property<int>("FullArmorTypeRef")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FullArmorTypeRef")
                        .IsUnique();

                    b.ToTable("TypeOfArmors");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.TypeOfWeapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnumWeaponType")
                        .HasColumnType("int");

                    b.Property<int>("FullWeaponTypesRef")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FullWeaponTypesRef")
                        .IsUnique();

                    b.ToTable("TypeOfWeapons");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.BonusDmgFromElemental", b =>
                {
                    b.HasOne("RpgChestMVC.Domain.Model.FullWeaponType", "FullWeaponType")
                        .WithMany("BonusDmgFromElementals")
                        .HasForeignKey("FullWeaponTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FullWeaponType");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.FullArmorType", b =>
                {
                    b.HasOne("RpgChestMVC.Domain.Model.Item", "Item")
                        .WithOne("FullArmorType")
                        .HasForeignKey("RpgChestMVC.Domain.Model.FullArmorType", "ItemRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.FullWeaponType", b =>
                {
                    b.HasOne("RpgChestMVC.Domain.Model.Item", "Item")
                        .WithOne("FullWeaponType")
                        .HasForeignKey("RpgChestMVC.Domain.Model.FullWeaponType", "ItemRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.Item", b =>
                {
                    b.HasOne("RpgChestMVC.Domain.Model.Rarity", "Rarity")
                        .WithMany("Items")
                        .HasForeignKey("RarityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rarity");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.Resistance", b =>
                {
                    b.HasOne("RpgChestMVC.Domain.Model.FullArmorType", "FullArmorType")
                        .WithMany("Resistances")
                        .HasForeignKey("FullArmorTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FullArmorType");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.TypeOfArmor", b =>
                {
                    b.HasOne("RpgChestMVC.Domain.Model.FullArmorType", "FullArmorType")
                        .WithOne("TypeOfArmor")
                        .HasForeignKey("RpgChestMVC.Domain.Model.TypeOfArmor", "FullArmorTypeRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FullArmorType");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.TypeOfWeapon", b =>
                {
                    b.HasOne("RpgChestMVC.Domain.Model.FullWeaponType", "FullWeaponType")
                        .WithOne("TypeOfWeapon")
                        .HasForeignKey("RpgChestMVC.Domain.Model.TypeOfWeapon", "FullWeaponTypesRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FullWeaponType");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.FullArmorType", b =>
                {
                    b.Navigation("Resistances");

                    b.Navigation("TypeOfArmor");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.FullWeaponType", b =>
                {
                    b.Navigation("BonusDmgFromElementals");

                    b.Navigation("TypeOfWeapon");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.Item", b =>
                {
                    b.Navigation("FullArmorType");

                    b.Navigation("FullWeaponType");
                });

            modelBuilder.Entity("RpgChestMVC.Domain.Model.Rarity", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
