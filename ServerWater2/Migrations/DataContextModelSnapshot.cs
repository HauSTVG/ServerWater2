﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ServerWater2.Models;

#nullable disable

namespace ServerWater2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ServerWater2.Models.SqlAction", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Action");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlArea", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("groupID")
                        .HasColumnType("bigint");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("groupID");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlCalcItems", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("CalcItems");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlCertificate", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlCustomer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("images")
                        .HasColumnType("text[]");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("persons")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("route")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlFile", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("time")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.ToTable("File");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlGroup", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogOrder", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long?>("actionID")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("images")
                        .HasColumnType("text[]");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("orderID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("time")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("userID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("actionID");

                    b.HasIndex("orderID");

                    b.HasIndex("userID");

                    b.ToTable("LogOrder");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlOrder", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("addressContract")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("addressCustomer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("addressWater")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("areaID")
                        .HasColumnType("bigint");

                    b.Property<List<string>>("certificates")
                        .HasColumnType("text[]");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("customerID")
                        .HasColumnType("bigint");

                    b.Property<string>("document")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("groupID")
                        .HasColumnType("bigint");

                    b.Property<bool>("isDelete")
                        .HasColumnType("boolean");

                    b.Property<bool>("isFinish")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastestTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("managerID")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("persons")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("receiverID")
                        .HasColumnType("bigint");

                    b.Property<long?>("serviceID")
                        .HasColumnType("bigint");

                    b.Property<long?>("stateID")
                        .HasColumnType("bigint");

                    b.Property<long?>("surveyID")
                        .HasColumnType("bigint");

                    b.Property<long?>("typeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("workerID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("areaID");

                    b.HasIndex("customerID");

                    b.HasIndex("groupID");

                    b.HasIndex("managerID");

                    b.HasIndex("receiverID");

                    b.HasIndex("serviceID");

                    b.HasIndex("stateID");

                    b.HasIndex("surveyID");

                    b.HasIndex("typeID");

                    b.HasIndex("workerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlRole", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlService", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlState", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<int>("code")
                        .HasColumnType("integer");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlUser", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("des")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("displayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isClear")
                        .HasColumnType("boolean");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("notification")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("roleID")
                        .HasColumnType("bigint");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("roleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlViewForm", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("ViewForm");
                });

            modelBuilder.Entity("SqlGroupSqlUser", b =>
                {
                    b.Property<long>("groupsID")
                        .HasColumnType("bigint");

                    b.Property<long>("usersID")
                        .HasColumnType("bigint");

                    b.HasKey("groupsID", "usersID");

                    b.HasIndex("usersID");

                    b.ToTable("SqlGroupSqlUser");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlArea", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlGroup", "group")
                        .WithMany("areas")
                        .HasForeignKey("groupID");

                    b.Navigation("group");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlLogOrder", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlAction", "action")
                        .WithMany()
                        .HasForeignKey("actionID");

                    b.HasOne("ServerWater2.Models.SqlOrder", "order")
                        .WithMany()
                        .HasForeignKey("orderID");

                    b.HasOne("ServerWater2.Models.SqlUser", "user")
                        .WithMany()
                        .HasForeignKey("userID");

                    b.Navigation("action");

                    b.Navigation("order");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlOrder", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlArea", "area")
                        .WithMany()
                        .HasForeignKey("areaID");

                    b.HasOne("ServerWater2.Models.SqlCustomer", "customer")
                        .WithMany("orders")
                        .HasForeignKey("customerID");

                    b.HasOne("ServerWater2.Models.SqlGroup", "group")
                        .WithMany()
                        .HasForeignKey("groupID");

                    b.HasOne("ServerWater2.Models.SqlUser", "manager")
                        .WithMany("managerOrders")
                        .HasForeignKey("managerID");

                    b.HasOne("ServerWater2.Models.SqlUser", "receiver")
                        .WithMany("receiverOrders")
                        .HasForeignKey("receiverID");

                    b.HasOne("ServerWater2.Models.SqlService", "service")
                        .WithMany()
                        .HasForeignKey("serviceID");

                    b.HasOne("ServerWater2.Models.SqlState", "state")
                        .WithMany()
                        .HasForeignKey("stateID");

                    b.HasOne("ServerWater2.Models.SqlUser", "survey")
                        .WithMany("surveyOrders")
                        .HasForeignKey("surveyID");

                    b.HasOne("ServerWater2.Models.SqlType", "type")
                        .WithMany()
                        .HasForeignKey("typeID");

                    b.HasOne("ServerWater2.Models.SqlUser", "worker")
                        .WithMany("workerOrders")
                        .HasForeignKey("workerID");

                    b.Navigation("area");

                    b.Navigation("customer");

                    b.Navigation("group");

                    b.Navigation("manager");

                    b.Navigation("receiver");

                    b.Navigation("service");

                    b.Navigation("state");

                    b.Navigation("survey");

                    b.Navigation("type");

                    b.Navigation("worker");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlUser", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlRole", "role")
                        .WithMany()
                        .HasForeignKey("roleID");

                    b.Navigation("role");
                });

            modelBuilder.Entity("SqlGroupSqlUser", b =>
                {
                    b.HasOne("ServerWater2.Models.SqlGroup", null)
                        .WithMany()
                        .HasForeignKey("groupsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerWater2.Models.SqlUser", null)
                        .WithMany()
                        .HasForeignKey("usersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServerWater2.Models.SqlCustomer", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlGroup", b =>
                {
                    b.Navigation("areas");
                });

            modelBuilder.Entity("ServerWater2.Models.SqlUser", b =>
                {
                    b.Navigation("managerOrders");

                    b.Navigation("receiverOrders");

                    b.Navigation("surveyOrders");

                    b.Navigation("workerOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
