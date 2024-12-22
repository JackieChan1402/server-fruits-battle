﻿// <auto-generated />
using System;
using LidgrenServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LidgrenServer.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    partial class ApplicationDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LidgrenServer.Models.CharacterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Armor")
                        .HasColumnType("int")
                        .HasColumnName("armor");

                    b.Property<int>("Damage")
                        .HasColumnType("int")
                        .HasColumnName("damage");

                    b.Property<int>("Hp")
                        .HasColumnType("int")
                        .HasColumnName("hp");

                    b.Property<int>("Luck")
                        .HasColumnType("int")
                        .HasColumnName("luck");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("Stamina")
                        .HasColumnType("int")
                        .HasColumnName("stamina");

                    b.HasKey("Id");

                    b.ToTable("character");
                });

            modelBuilder.Entity("LidgrenServer.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("duration");

                    b.Property<string>("EffectType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("effect_type");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("image_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("target");

                    b.Property<int>("Value")
                        .HasColumnType("int")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.ToTable("items");
                });

            modelBuilder.Entity("LidgrenServer.Models.LoginHistoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool>("IsLoginNow")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_online_now");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("login_time");

                    b.Property<DateTime?>("LogoutTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("logout_time");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "IsLoginNow")
                        .HasDatabaseName("IX_User_LoginHistory_IsLoginNow");

                    b.ToTable("login_history");
                });

            modelBuilder.Entity("LidgrenServer.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("RelatedId")
                        .HasColumnType("int")
                        .HasColumnName("related_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("LidgrenServer.Models.RankModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("AssetName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("asset_name");

                    b.Property<int>("MaxStar")
                        .HasColumnType("int")
                        .HasColumnName("max_star");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("rank");
                });

            modelBuilder.Entity("LidgrenServer.Models.SeasonModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.HasKey("Id");

                    b.ToTable("seasons");
                });

            modelBuilder.Entity("LidgrenServer.Models.ShopModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("shop");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserCharacterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("ArmorPoint")
                        .HasColumnType("int")
                        .HasColumnName("armor_point");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int")
                        .HasColumnName("character_id");

                    b.Property<int>("DamagePoint")
                        .HasColumnType("int")
                        .HasColumnName("damage_point");

                    b.Property<int>("Experience")
                        .HasColumnType("int")
                        .HasColumnName("experience");

                    b.Property<int>("HpPoint")
                        .HasColumnType("int")
                        .HasColumnName("hp_point");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_selected");

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("level");

                    b.Property<int>("LuckPoint")
                        .HasColumnType("int")
                        .HasColumnName("luck_point");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("UserId", "CharacterId")
                        .HasDatabaseName("IX_UserCharacter_UserId_CharacterId");

                    b.HasIndex("UserId", "IsSelected")
                        .HasDatabaseName("IX_UserCharacter_UserId_IsSelected");

                    b.ToTable("user_characters");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserInventoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("user_inventories");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Coin")
                        .HasColumnType("int")
                        .HasColumnName("coin");

                    b.Property<string>("Display_name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("display_name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("registered_at");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.Property<bool>("isVerify")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("isVerifyEmail");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserRankModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("CurrentStar")
                        .HasColumnType("int")
                        .HasColumnName("current_star");

                    b.Property<int>("RankId")
                        .HasColumnType("int")
                        .HasColumnName("rank_id");

                    b.Property<int>("SeasonId")
                        .HasColumnType("int")
                        .HasColumnName("season_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RankId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("UserId");

                    b.ToTable("user_ranks");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserRelationship", b =>
                {
                    b.Property<int>("UserFirstId")
                        .HasColumnType("int")
                        .HasColumnName("user_first_id");

                    b.Property<int>("UserSecondId")
                        .HasColumnType("int")
                        .HasColumnName("user_second_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("type");

                    b.HasKey("UserFirstId", "UserSecondId");

                    b.HasIndex("UserSecondId");

                    b.ToTable("user_relationship");
                });

            modelBuilder.Entity("LidgrenServer.Models.LoginHistoryModel", b =>
                {
                    b.HasOne("LidgrenServer.Models.UserModel", "UserModel")
                        .WithMany("LoginHistory")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("LidgrenServer.Models.ShopModel", b =>
                {
                    b.HasOne("LidgrenServer.Models.ProductModel", "Products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserCharacterModel", b =>
                {
                    b.HasOne("LidgrenServer.Models.CharacterModel", "Character")
                        .WithMany("UserCharacters")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LidgrenServer.Models.UserModel", "User")
                        .WithMany("UserCharacters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserInventoryModel", b =>
                {
                    b.HasOne("LidgrenServer.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LidgrenServer.Models.UserModel", "User")
                        .WithOne("Inventory")
                        .HasForeignKey("LidgrenServer.Models.UserInventoryModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserRankModel", b =>
                {
                    b.HasOne("LidgrenServer.Models.RankModel", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LidgrenServer.Models.SeasonModel", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LidgrenServer.Models.UserModel", "User")
                        .WithMany("Ranks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rank");

                    b.Navigation("Season");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserRelationship", b =>
                {
                    b.HasOne("LidgrenServer.Models.UserModel", "UserFirst")
                        .WithMany("Relationships")
                        .HasForeignKey("UserFirstId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LidgrenServer.Models.UserModel", "UserSecond")
                        .WithMany()
                        .HasForeignKey("UserSecondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserFirst");

                    b.Navigation("UserSecond");
                });

            modelBuilder.Entity("LidgrenServer.Models.CharacterModel", b =>
                {
                    b.Navigation("UserCharacters");
                });

            modelBuilder.Entity("LidgrenServer.Models.UserModel", b =>
                {
                    b.Navigation("Inventory")
                        .IsRequired();

                    b.Navigation("LoginHistory");

                    b.Navigation("Ranks");

                    b.Navigation("Relationships");

                    b.Navigation("UserCharacters");
                });
#pragma warning restore 612, 618
        }
    }
}
