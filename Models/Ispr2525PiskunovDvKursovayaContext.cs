using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Pis.Models;

public partial class Ispr2525PiskunovDvKursovayaContext : DbContext
{
    public Ispr2525PiskunovDvKursovayaContext()
    {
    }

    public Ispr2525PiskunovDvKursovayaContext(DbContextOptions<Ispr2525PiskunovDvKursovayaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AlertLog> AlertLogs { get; set; }

    public virtual DbSet<DeviceType> DeviceTypes { get; set; }

    public virtual DbSet<MonitoringDatum> MonitoringData { get; set; }

    public virtual DbSet<PerformanceReport> PerformanceReports { get; set; }

    public virtual DbSet<PlcDevice> PlcDevices { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Severity> Severities { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;database=ISPr25-25_PiskunovDV_Kursovaya;uid=ISPr25-25_PiskunovDV;pwd=ISPr25-25_PiskunovDV", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.41-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AlertLog>(entity =>
        {
            entity.HasKey(e => e.IdAlertLogs).HasName("PRIMARY");

            entity.HasIndex(e => e.PlcDevicesIdPlcDevices, "fk_AlertLogs_PLC_Devices1_idx");

            entity.Property(e => e.IdAlertLogs).HasColumnName("idAlertLogs");
            entity.Property(e => e.AlertMessage).HasColumnType("tinytext");
            entity.Property(e => e.PlcDevicesIdPlcDevices).HasColumnName("PLC_Devices_idPLC_Devices");
            entity.Property(e => e.Severity).HasColumnType("enum('Низкий','Средний','Высокий')");
            entity.Property(e => e.Timestamp).HasColumnType("datetime");

            entity.HasOne(d => d.PlcDevicesIdPlcDevicesNavigation).WithMany(p => p.AlertLogs)
                .HasForeignKey(d => d.PlcDevicesIdPlcDevices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AlertLogs_PLC_Devices1");
        });

        modelBuilder.Entity<DeviceType>(entity =>
        {
            entity.HasKey(e => e.IdDeviceType).HasName("PRIMARY");

            entity.ToTable("Device_Type");

            entity.Property(e => e.IdDeviceType).HasColumnName("idDevice_Type");
            entity.Property(e => e.Device).HasMaxLength(100);
        });

        modelBuilder.Entity<MonitoringDatum>(entity =>
        {
            entity.HasKey(e => e.IdMonitoringData).HasName("PRIMARY");

            entity.HasIndex(e => e.PlcDevicesIdPlcDevices, "fk_MonitoringData_PLC_Devices_idx");

            entity.Property(e => e.IdMonitoringData).HasColumnName("idMonitoringData");
            entity.Property(e => e.Load).HasMaxLength(45);
            entity.Property(e => e.PlcDevicesIdPlcDevices).HasColumnName("PLC_Devices_idPLC_Devices");
            entity.Property(e => e.Temperature).HasMaxLength(255);
            entity.Property(e => e.Timestamp).HasMaxLength(255);

            entity.HasOne(d => d.PlcDevicesIdPlcDevicesNavigation).WithMany(p => p.MonitoringData)
                .HasForeignKey(d => d.PlcDevicesIdPlcDevices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_MonitoringData_PLC_Devices");
        });

        modelBuilder.Entity<PerformanceReport>(entity =>
        {
            entity.HasKey(e => e.IdPerformanceReports).HasName("PRIMARY");

            entity.HasIndex(e => e.PlcDevicesIdPlcDevices, "fk_PerformanceReports_PLC_Devices1_idx");

            entity.Property(e => e.IdPerformanceReports).HasColumnName("idPerformanceReports");
            entity.Property(e => e.EndTime).HasMaxLength(200);
            entity.Property(e => e.PlcDevicesIdPlcDevices).HasColumnName("PLC_Devices_idPLC_Devices");
            entity.Property(e => e.StartTime).HasMaxLength(200);

            entity.HasOne(d => d.PlcDevicesIdPlcDevicesNavigation).WithMany(p => p.PerformanceReports)
                .HasForeignKey(d => d.PlcDevicesIdPlcDevices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_PerformanceReports_PLC_Devices1");
        });

        modelBuilder.Entity<PlcDevice>(entity =>
        {
            entity.HasKey(e => e.IdPlcDevices).HasName("PRIMARY");

            entity.ToTable("PLC_Devices");

            entity.Property(e => e.IdPlcDevices).HasColumnName("idPLC_Devices");
            entity.Property(e => e.DeviceName).HasMaxLength(300);
            entity.Property(e => e.DeviceType).HasMaxLength(100);
            entity.Property(e => e.Status).HasColumnType("enum('Работает','Остановлено','В ремонте')");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("Role");

            entity.HasIndex(e => e.UsersIdUsers, "fk_Role_Users1_idx");

            entity.Property(e => e.IdRole).HasColumnName("idRole");
            entity.Property(e => e.Role1)
                .HasColumnType("enum('Администратор','зам директора','директор','разработчик','тестировщик')")
                .HasColumnName("Role");
            entity.Property(e => e.UsersIdUsers).HasColumnName("Users_idUsers");

            entity.HasOne(d => d.UsersIdUsersNavigation).WithMany(p => p.Roles)
                .HasForeignKey(d => d.UsersIdUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Role_Users1");
        });

        modelBuilder.Entity<Severity>(entity =>
        {
            entity.HasKey(e => e.IdSeverity).HasName("PRIMARY");

            entity.ToTable("Severity");

            entity.HasIndex(e => e.AlertLogsIdAlertLogs, "fk_Severity_AlertLogs1_idx");

            entity.Property(e => e.IdSeverity).HasColumnName("idSeverity");
            entity.Property(e => e.AlertLogsIdAlertLogs).HasColumnName("AlertLogs_idAlertLogs");
            entity.Property(e => e.Severity1)
                .HasColumnType("enum('Низкий','Средний','Высокий')")
                .HasColumnName("Severity");

            entity.HasOne(d => d.AlertLogsIdAlertLogsNavigation).WithMany(p => p.Severities)
                .HasForeignKey(d => d.AlertLogsIdAlertLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Severity_AlertLogs1");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("Status");

            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.Status1)
                .HasColumnType("enum('Работает','Остановлено','В ремонте')")
                .HasColumnName("Status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUsers).HasName("PRIMARY");

            entity.Property(e => e.IdUsers).HasColumnName("idUsers");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Role).HasColumnType("enum('Администратор','зам директора','директор','разработчик','тестировщик')");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
