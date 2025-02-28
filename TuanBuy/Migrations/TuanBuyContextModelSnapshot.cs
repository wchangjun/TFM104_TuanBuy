﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuanBuy.Models.Entities;

namespace TuanBuy.Migrations
{
    [DbContext(typeof(TuanBuyContext))]
    partial class TuanBuyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChatRoomUser", b =>
                {
                    b.Property<Guid>("ChatRoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("ChatRoomId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("ChatRoomUser");
                });

            modelBuilder.Entity("TuanBuy.Models.ChatMessages", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("ChatRoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("ChatRoomId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("TuanBuy.Models.ChatRoom", b =>
                {
                    b.Property<Guid>("ChatRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatRoomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChatRoomId");

                    b.ToTable("ChatRoom");
                });

            modelBuilder.Entity("TuanBuy.Models.ChatRoomMember", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<Guid>("ChatRoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("MemberId", "ChatRoomId");

                    b.HasIndex("ChatRoomId");

                    b.ToTable("ChatRoomMember");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disable")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disable")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentType")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.TestProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestProducts");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disable")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Friend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ChatRoomUser", b =>
                {
                    b.HasOne("TuanBuy.Models.ChatRoom", null)
                        .WithMany()
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TuanBuy.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TuanBuy.Models.ChatMessages", b =>
                {
                    b.HasOne("TuanBuy.Models.ChatRoom", "ChatRoom")
                        .WithMany()
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatRoom");
                });

            modelBuilder.Entity("TuanBuy.Models.ChatRoomMember", b =>
                {
                    b.HasOne("TuanBuy.Models.ChatRoom", "ChatRoom")
                        .WithMany()
                        .HasForeignKey("ChatRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TuanBuy.Models.Entities.User", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatRoom");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.Order", b =>
                {
                    b.HasOne("TuanBuy.Models.Entities.Product", "Product")
                        .WithOne("Order")
                        .HasForeignKey("TuanBuy.Models.Entities.Order", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TuanBuy.Models.Entities.User", "User")
                        .WithMany("Order")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.OrderDetail", b =>
                {
                    b.HasOne("TuanBuy.Models.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("TuanBuy.Models.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.Product", b =>
                {
                    b.HasOne("TuanBuy.Models.Entities.User", "User")
                        .WithMany("Product")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.Product", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("TuanBuy.Models.Entities.User", b =>
                {
                    b.Navigation("Order");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
