﻿// <auto-generated />
using System;
using SPNewApi2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SPNewApi2.Migrations
{
    [DbContext(typeof(FinalPlugDBContext))]
    partial class FinalPlugDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiFriday.Models.Booking", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<DateTime>("BookDate")
                        .HasColumnType("date")
                        .HasColumnName("book_date");

                    b.Property<string>("BookMessage")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("book_message");

                    b.Property<string>("BookStatus")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("book_status");

                    b.Property<TimeSpan>("BookTime")
                        .HasColumnType("time")
                        .HasColumnName("book_time");

                    b.Property<int>("MerchId")
                        .HasColumnType("int")
                        .HasColumnName("merch_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("BookId");

                    b.HasIndex("MerchId");

                    b.HasIndex("UserId");

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("ApiFriday.Models.Client", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_address");

                    b.Property<string>("UserCity")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_city");

                    b.Property<string>("UserContactdetails")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_contactdetails");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_email");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_name");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_password");

                    b.Property<string>("UserProvince")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_province");

                    b.Property<string>("UserStatus")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_status");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("user_surname");

                    b.HasKey("UserId");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("ApiFriday.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("job_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<DateTime?>("JobDateend")
                        .HasColumnType("date")
                        .HasColumnName("job_dateend");

                    b.Property<DateTime?>("JobDatestart")
                        .HasColumnType("date")
                        .HasColumnName("job_datestart");

                    b.Property<string>("JobStatus")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("job_status");

                    b.Property<TimeSpan?>("JobTimeend")
                        .HasColumnType("time")
                        .HasColumnName("job_timeend");

                    b.Property<TimeSpan?>("JobTimestart")
                        .HasColumnType("time")
                        .HasColumnName("job_timestart");

                    b.Property<int>("MerchId")
                        .HasColumnType("int")
                        .HasColumnName("merch_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("JobId");

                    b.HasIndex("BookId");

                    b.HasIndex("MerchId");

                    b.HasIndex("UserId");

                    b.ToTable("Job", (string)null);
                });

            modelBuilder.Entity("ApiFriday.Models.Merchant", b =>
                {
                    b.Property<int>("MerchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("merch_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MerchId"), 1L, 1);

                    b.Property<string>("MerchAddress")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_address");

                    b.Property<string>("MerchCity")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_city");

                    b.Property<string>("MerchContactdetails")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_contactdetails");

                    b.Property<string>("MerchEmail")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_email");

                    b.Property<string>("MerchFile")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_file");

                    b.Property<string>("MerchIdnumber")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_idnumber");

                    b.Property<string>("MerchName")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_name");

                    b.Property<string>("MerchPassword")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_password");

                    b.Property<string>("MerchPictures1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_pictures1");

                    b.Property<string>("MerchPictures2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_pictures2");

                    b.Property<string>("MerchPictures3")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_pictures3");

                    b.Property<string>("MerchProfilepicture")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_profilepicture");

                    b.Property<string>("MerchProvince")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_province");

                    b.Property<string>("MerchStatus")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_status");

                    b.Property<string>("MerchSurname")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_surname");

                    b.Property<string>("MerchTaxnumber")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_taxnumber");

                    b.Property<string>("MerchType")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_type");

                    b.Property<string>("MerchVerify")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("merch_verify");

                    b.HasKey("MerchId");

                    b.ToTable("Merchant", (string)null);
                });

            modelBuilder.Entity("ApiFriday.Models.Quotation", b =>
                {
                    b.Property<int>("QuotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("quot_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuotId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int>("MerchId")
                        .HasColumnType("int")
                        .HasColumnName("merch_id");

                    b.Property<string>("QuotAmount")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("quot_amount");

                    b.Property<string>("QuotDescription")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("quot_description");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("QuotId");

                    b.HasIndex("BookId");

                    b.HasIndex("MerchId");

                    b.HasIndex("UserId");

                    b.ToTable("Quotation", (string)null);
                });

            modelBuilder.Entity("ApiFriday.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("review_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"), 1L, 1);

                    b.Property<int>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("job_id");

                    b.Property<int>("MerchId")
                        .HasColumnType("int")
                        .HasColumnName("merch_id");

                    b.Property<string>("ReviewMessage")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("review_message");

                    b.Property<string>("ReviewRating")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("review_rating");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("ReviewId");

                    b.HasIndex("JobId");

                    b.HasIndex("MerchId");

                    b.HasIndex("UserId");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("ApiFriday.Models.Booking", b =>
                {
                    b.HasOne("ApiFriday.Models.Merchant", "Merch")
                        .WithMany("Bookings")
                        .HasForeignKey("MerchId")
                        .IsRequired()
                        .HasConstraintName("FK_Booking_Merchant");

                    b.HasOne("ApiFriday.Models.Client", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Booking_Client");

                    b.Navigation("Merch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiFriday.Models.Job", b =>
                {
                    b.HasOne("ApiFriday.Models.Booking", "Book")
                        .WithMany("Jobs")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK_Job_Booking");

                    b.HasOne("ApiFriday.Models.Merchant", "Merch")
                        .WithMany("Jobs")
                        .HasForeignKey("MerchId")
                        .IsRequired()
                        .HasConstraintName("FK_Job_Merchant");

                    b.HasOne("ApiFriday.Models.Client", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Job_Client");

                    b.Navigation("Book");

                    b.Navigation("Merch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiFriday.Models.Quotation", b =>
                {
                    b.HasOne("ApiFriday.Models.Booking", "Book")
                        .WithMany("Quotations")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK_Quotation_Booking");

                    b.HasOne("ApiFriday.Models.Merchant", "Merch")
                        .WithMany("Quotations")
                        .HasForeignKey("MerchId")
                        .IsRequired()
                        .HasConstraintName("FK_Quotation_Merchant");

                    b.HasOne("ApiFriday.Models.Client", "User")
                        .WithMany("Quotations")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Quotation_Client");

                    b.Navigation("Book");

                    b.Navigation("Merch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiFriday.Models.Review", b =>
                {
                    b.HasOne("ApiFriday.Models.Job", "Job")
                        .WithMany("Reviews")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK_Review_Job");

                    b.HasOne("ApiFriday.Models.Merchant", "Merch")
                        .WithMany("Reviews")
                        .HasForeignKey("MerchId")
                        .IsRequired()
                        .HasConstraintName("FK_Review_Merchant");

                    b.HasOne("ApiFriday.Models.Client", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Review_Client");

                    b.Navigation("Job");

                    b.Navigation("Merch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiFriday.Models.Booking", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Quotations");
                });

            modelBuilder.Entity("ApiFriday.Models.Client", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Jobs");

                    b.Navigation("Quotations");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ApiFriday.Models.Job", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ApiFriday.Models.Merchant", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Jobs");

                    b.Navigation("Quotations");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
