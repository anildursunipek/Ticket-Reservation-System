﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ticket_Reservation_System;

#nullable disable

namespace Ticket_Reservation_System.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Ticket_Reservation_System.Models.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("lat")
                        .HasColumnType("double");

                    b.Property<double>("lng")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketId")
                        .IsUnique();

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("SeatType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("SeatTypeId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeatTypeId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.SeatType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SeatTypes");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int>("TaskPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.HasIndex("TaskPlanId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.TaskPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DestinationPointId")
                        .HasColumnType("int");

                    b.Property<double>("Duration")
                        .HasColumnType("double");

                    b.Property<int>("Route")
                        .HasColumnType("int");

                    b.Property<int>("StartingPointId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationPointId");

                    b.HasIndex("StartingPointId");

                    b.HasIndex("TripId");

                    b.ToTable("TaskPlans");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TicketPlanId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketPlanId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.TicketPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("TaskPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.HasIndex("TaskPlanId");

                    b.ToTable("TicketPlans");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DestinationPointId")
                        .HasColumnType("int");

                    b.Property<double>("Duration")
                        .HasColumnType("double");

                    b.Property<int>("StartingPointId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationPointId");

                    b.HasIndex("StartingPointId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TotalSeat")
                        .HasColumnType("int");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.VehicleBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VehicleType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("VehicleBrands");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VehicleBrandId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleBrandId");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FirmId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tc")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Process", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Reservation", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Ticket", "Ticket")
                        .WithOne("Reservation")
                        .HasForeignKey("Ticket_Reservation_System.Models.Reservation", "TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Seat", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.SeatType", null)
                        .WithMany("Seats")
                        .HasForeignKey("SeatTypeId");

                    b.HasOne("Ticket_Reservation_System.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Task", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.TaskPlan", "TaskPlan")
                        .WithMany()
                        .HasForeignKey("TaskPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Process");

                    b.Navigation("TaskPlan");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.TaskPlan", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Location", "DestinationPoint")
                        .WithMany()
                        .HasForeignKey("DestinationPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.Location", "StartingPoint")
                        .WithMany()
                        .HasForeignKey("StartingPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DestinationPoint");

                    b.Navigation("StartingPoint");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Ticket", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.TicketPlan", "TicketPlan")
                        .WithMany()
                        .HasForeignKey("TicketPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicketPlan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.TicketPlan", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Seat", "Seat")
                        .WithMany("TicketPlans")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.TaskPlan", "TaskPlan")
                        .WithMany()
                        .HasForeignKey("TaskPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seat");

                    b.Navigation("TaskPlan");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Trip", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Location", "DestinationPoint")
                        .WithMany()
                        .HasForeignKey("DestinationPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.Location", "StartingPoint")
                        .WithMany()
                        .HasForeignKey("StartingPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DestinationPoint");

                    b.Navigation("StartingPoint");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Vehicle", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Firm", "Firm")
                        .WithMany()
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ticket_Reservation_System.Models.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firm");

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.VehicleModel", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.VehicleBrand", "VehicleBrand")
                        .WithMany()
                        .HasForeignKey("VehicleBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleBrand");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Worker", b =>
                {
                    b.HasOne("Ticket_Reservation_System.Models.Firm", "Firm")
                        .WithMany()
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firm");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Seat", b =>
                {
                    b.Navigation("TicketPlans");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.SeatType", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.Ticket", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Ticket_Reservation_System.Models.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
