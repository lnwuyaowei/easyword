using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EasyWord.Models
{
    public partial class mydb : DbContext
    {
        public virtual DbSet<词库> 词库 { get; set; }
        public virtual DbSet<汉字38万词海> 汉字38万词海 { get; set; }
        public virtual DbSet<汉字十六韵> 汉字十六韵 { get; set; }
        public virtual DbSet<汉字使用频率> 汉字使用频率 { get; set; }
        public virtual DbSet<系统报表> 系统报表 { get; set; }
        public virtual DbSet<系统报表明细> 系统报表明细 { get; set; }
        public virtual DbSet<系统公告> 系统公告 { get; set; }
        public virtual DbSet<系统公司信息> 系统公司信息 { get; set; }
        public virtual DbSet<系统功能权限分组> 系统功能权限分组 { get; set; }
        public virtual DbSet<系统功能权限分组明细> 系统功能权限分组明细 { get; set; }
        public virtual DbSet<系统日志> 系统日志 { get; set; }
        public virtual DbSet<系统数据检查> 系统数据检查 { get; set; }
        public virtual DbSet<系统数据检查检查参数> 系统数据检查检查参数 { get; set; }
        public virtual DbSet<系统数据清除> 系统数据清除 { get; set; }
        public virtual DbSet<系统数据清除明细> 系统数据清除明细 { get; set; }
        public virtual DbSet<系统通知记录> 系统通知记录 { get; set; }
        public virtual DbSet<系统信息> 系统信息 { get; set; }
        public virtual DbSet<系统用户> 系统用户 { get; set; }
        public virtual DbSet<系统用户部门> 系统用户部门 { get; set; }
        public virtual DbSet<系统用户角色> 系统用户角色 { get; set; }
        public virtual DbSet<系统用户角色角色权限> 系统用户角色角色权限 { get; set; }
        public virtual DbSet<系统主键编号> 系统主键编号 { get; set; }
        public virtual DbSet<自来水报表开出水费报表> 自来水报表开出水费报表 { get; set; }
        public virtual DbSet<自来水报表收费人员通知单> 自来水报表收费人员通知单 { get; set; }
        public virtual DbSet<自来水报表收费人员统计表> 自来水报表收费人员统计表 { get; set; }
        public virtual DbSet<自来水报表营业销售收入稽核明细表> 自来水报表营业销售收入稽核明细表 { get; set; }
        public virtual DbSet<自来水报表用水成本> 自来水报表用水成本 { get; set; }
        public virtual DbSet<自来水报表用水性质> 自来水报表用水性质 { get; set; }
        public virtual DbSet<自来水报表用水性质汇总表> 自来水报表用水性质汇总表 { get; set; }
        public virtual DbSet<自来水编号段号> 自来水编号段号 { get; set; }
        public virtual DbSet<自来水编号片号> 自来水编号片号 { get; set; }
        public virtual DbSet<自来水编号区号> 自来水编号区号 { get; set; }
        public virtual DbSet<自来水编号水表> 自来水编号水表 { get; set; }
        public virtual DbSet<自来水编号水表安装位置> 自来水编号水表安装位置 { get; set; }
        public virtual DbSet<自来水编号小区编号> 自来水编号小区编号 { get; set; }
        public virtual DbSet<自来水编号用水性质> 自来水编号用水性质 { get; set; }
        public virtual DbSet<自来水编号用水性质阶梯水价> 自来水编号用水性质阶梯水价 { get; set; }
        public virtual DbSet<自来水财务记帐凭证> 自来水财务记帐凭证 { get; set; }
        public virtual DbSet<自来水财务营业收费情况汇总单> 自来水财务营业收费情况汇总单 { get; set; }
        public virtual DbSet<自来水抄表抄表台帐> 自来水抄表抄表台帐 { get; set; }
        public virtual DbSet<自来水缴费用户> 自来水缴费用户 { get; set; }
        public virtual DbSet<自来水缴费用户变更信息> 自来水缴费用户变更信息 { get; set; }
        public virtual DbSet<自来水收费个人收费汇总单> 自来水收费个人收费汇总单 { get; set; }
        public virtual DbSet<自来水收费收费减免> 自来水收费收费减免 { get; set; }
        public virtual DbSet<自来水系统参数设置> 自来水系统参数设置 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Z:\程序源码\CoreWEB\EasyWord\EasyWord\DB\CKDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<词库>(entity =>
            {
                entity.HasKey(e => e.编号);

                entity.Property(e => e.上位词).HasMaxLength(50);

                entity.Property(e => e.下位词).HasMaxLength(50);

                entity.Property(e => e.反义词).HasMaxLength(50);

                entity.Property(e => e.发音).HasMaxLength(100);

                entity.Property(e => e.同义词).HasMaxLength(50);

                entity.Property(e => e.情感).HasMaxLength(50);

                entity.Property(e => e.押韵).HasMaxLength(50);

                entity.Property(e => e.时代).HasMaxLength(50);

                entity.Property(e => e.用途).HasMaxLength(50);

                entity.Property(e => e.联想).HasMaxLength(50);

                entity.Property(e => e.词名).HasMaxLength(50);

                entity.Property(e => e.词性).HasMaxLength(50);
            });

            modelBuilder.Entity<汉字38万词海>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Words)
                    .HasColumnName("words")
                    .HasMaxLength(255);

                entity.Property(e => e.WordsReverse)
                    .HasColumnName("words_reverse")
                    .HasMaxLength(255);

                entity.Property(e => e.押韵).HasMaxLength(2);

                entity.Property(e => e.解释).HasMaxLength(255);
            });

            modelBuilder.Entity<汉字十六韵>(entity =>
            {
                entity.HasKey(e => e.序号);

                entity.Property(e => e.序号)
                    .HasColumnType("nchar(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.押韵).HasMaxLength(2);

                entity.Property(e => e.汉字).HasMaxLength(2);
            });

            modelBuilder.Entity<汉字使用频率>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.汉字).HasColumnType("nchar(2)");
            });

            modelBuilder.Entity<系统报表>(entity =>
            {
                entity.HasKey(e => e.报表编号);

                entity.ToTable("系统_报表");

                entity.Property(e => e.报表名称)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<系统报表明细>(entity =>
            {
                entity.HasKey(e => e.报表明细编号);

                entity.ToTable("系统_报表_明细");

                entity.Property(e => e.单元格内容)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.单元格类型).HasMaxLength(10);
            });

            modelBuilder.Entity<系统公告>(entity =>
            {
                entity.HasKey(e => e.公告编号);

                entity.ToTable("系统_公告");

                entity.Property(e => e.公告标题)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.发布人姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.发布时间).HasColumnType("datetime");

                entity.Property(e => e.标题色彩).HasMaxLength(50);
            });

            modelBuilder.Entity<系统公司信息>(entity =>
            {
                entity.HasKey(e => e.公司信息编号);

                entity.ToTable("系统_公司信息");

                entity.Property(e => e.公司传真).HasMaxLength(50);

                entity.Property(e => e.公司全称).HasMaxLength(50);

                entity.Property(e => e.公司地址).HasMaxLength(50);

                entity.Property(e => e.公司简称).HasMaxLength(50);

                entity.Property(e => e.公司网址).HasMaxLength(50);

                entity.Property(e => e.电子邮件).HasMaxLength(50);

                entity.Property(e => e.联系电话).HasMaxLength(50);

                entity.Property(e => e.邮政编码).HasMaxLength(50);
            });

            modelBuilder.Entity<系统功能权限分组>(entity =>
            {
                entity.HasKey(e => e.RighGroupId);

                entity.ToTable("系统_功能权限分组");

                entity.Property(e => e.RighGroupId).HasColumnName("RighGroupID");

                entity.Property(e => e.RightGroupDescribe).HasMaxLength(50);

                entity.Property(e => e.RightGroupName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<系统功能权限分组明细>(entity =>
            {
                entity.HasKey(e => e.RightId);

                entity.ToTable("系统_功能权限分组明细");

                entity.Property(e => e.RightId).HasColumnName("RightID");

                entity.Property(e => e.Picture).HasMaxLength(50);

                entity.Property(e => e.RightGroupId).HasColumnName("RightGroupID");

                entity.Property(e => e.RightName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.RightGroup)
                    .WithMany(p => p.系统功能权限分组明细)
                    .HasForeignKey(d => d.RightGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OA_Right_OA_RightGroup");
            });

            modelBuilder.Entity<系统日志>(entity =>
            {
                entity.HasKey(e => e.日志编号);

                entity.ToTable("系统_日志");

                entity.Property(e => e.内容).IsRequired();

                entity.Property(e => e.发生日期).HasColumnType("datetime");

                entity.Property(e => e.操作人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.模块)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<系统数据检查>(entity =>
            {
                entity.HasKey(e => e.数据检查编号);

                entity.ToTable("系统_数据检查");

                entity.Property(e => e.数据检查sql)
                    .IsRequired()
                    .HasColumnName("数据检查SQL");

                entity.Property(e => e.数据检查名称)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<系统数据检查检查参数>(entity =>
            {
                entity.HasKey(e => e.参数编号);

                entity.ToTable("系统_数据检查_检查参数");

                entity.Property(e => e.参数值)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.参数值示例).HasMaxLength(50);

                entity.Property(e => e.参数名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.参数说明).HasMaxLength(255);
            });

            modelBuilder.Entity<系统数据清除>(entity =>
            {
                entity.HasKey(e => e.数据清除编号);

                entity.ToTable("系统_数据清除");

                entity.Property(e => e.分类名称).HasMaxLength(50);

                entity.Property(e => e.名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.说明).HasMaxLength(255);
            });

            modelBuilder.Entity<系统数据清除明细>(entity =>
            {
                entity.HasKey(e => e.数据清除明细编号);

                entity.ToTable("系统_数据清除_明细");

                entity.Property(e => e.Sql)
                    .IsRequired()
                    .HasColumnName("SQL")
                    .HasMaxLength(255);

                entity.HasOne(d => d.数据清除编号Navigation)
                    .WithMany(p => p.系统数据清除明细)
                    .HasForeignKey(d => d.数据清除编号)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_系统_数据清除_明细_系统_数据清除");
            });

            modelBuilder.Entity<系统通知记录>(entity =>
            {
                entity.HasKey(e => e.通知编号);

                entity.ToTable("系统_通知记录");

                entity.Property(e => e.发件人姓名).HasMaxLength(50);

                entity.Property(e => e.发送时间).HasColumnType("datetime");

                entity.Property(e => e.收件人姓名).HasMaxLength(50);

                entity.Property(e => e.通知内容)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.通知标题)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.通知类型)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<系统信息>(entity =>
            {
                entity.HasKey(e => e.系统编号);

                entity.ToTable("系统_信息");

                entity.Property(e => e.数据库版本).HasMaxLength(50);

                entity.Property(e => e.软件版本).HasMaxLength(50);
            });

            modelBuilder.Entity<系统用户>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("系统_用户");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.Property(e => e.UserLoginName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPosition).HasMaxLength(50);

                entity.Property(e => e.UserTrueName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.系统用户)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OA_User_OA_Branch");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.系统用户)
                    .HasForeignKey(d => d.UserGroupId)
                    .HasConstraintName("FK_OA_User_OA_UserGroup");
            });

            modelBuilder.Entity<系统用户部门>(entity =>
            {
                entity.HasKey(e => e.部门编号);

                entity.ToTable("系统_用户部门");

                entity.Property(e => e.部门名称)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<系统用户角色>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.ToTable("系统_用户_角色");

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.Property(e => e.UserGroupExplanation).HasMaxLength(50);

                entity.Property(e => e.UserGroupName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<系统用户角色角色权限>(entity =>
            {
                entity.HasKey(e => e.UserGroupRightId);

                entity.ToTable("系统_用户_角色_角色权限");

                entity.Property(e => e.UserGroupRightId).HasColumnName("UserGroupRightID");

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.Property(e => e.UserGroupRightMenuId).HasColumnName("UserGroupRightMenuID");

                entity.Property(e => e.UserGroupRightMenuName).HasMaxLength(50);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.系统用户角色角色权限)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OA_UserGroupRight_OA_UserGroup");

                entity.HasOne(d => d.UserGroupRightMenu)
                    .WithMany(p => p.系统用户角色角色权限)
                    .HasForeignKey(d => d.UserGroupRightMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OA_UserGroupRight_OA_Right");
            });

            modelBuilder.Entity<系统主键编号>(entity =>
            {
                entity.HasKey(e => e.表名称);

                entity.ToTable("系统_主键编号");

                entity.Property(e => e.表名称)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<自来水报表开出水费报表>(entity =>
            {
                entity.HasKey(e => e.开出水费报表编号);

                entity.ToTable("自来水_报表_开出水费报表");

                entity.Property(e => e.时间段名称).HasMaxLength(50);

                entity.Property(e => e.用水性质分类名称).HasMaxLength(50);
            });

            modelBuilder.Entity<自来水报表收费人员通知单>(entity =>
            {
                entity.HasKey(e => e.收费人员通知单编号);

                entity.ToTable("自来水_报表_收费人员通知单");

                entity.Property(e => e.建档类型)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.收费人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.收费月份).HasColumnType("datetime");

                entity.Property(e => e.用水性质名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用水性质编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.通知单名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.预存上次预存余额).HasColumnName("预存_上次预存余额");

                entity.Property(e => e.预存实缴金额).HasColumnName("预存_实缴金额");

                entity.Property(e => e.预存本月预存).HasColumnName("预存_本月预存");

                entity.Property(e => e.预存预存余额).HasColumnName("预存_预存余额");
            });

            modelBuilder.Entity<自来水报表收费人员统计表>(entity =>
            {
                entity.HasKey(e => e.收费人员统计表编号);

                entity.ToTable("自来水_报表_收费人员统计表");

                entity.Property(e => e.应收其它费用).HasColumnName("应收_其它费用");

                entity.Property(e => e.应收减免收费).HasColumnName("应收_减免收费");

                entity.Property(e => e.应收减免滞纳金).HasColumnName("应收_减免滞纳金");

                entity.Property(e => e.应收水费).HasColumnName("应收_水费");

                entity.Property(e => e.应收污水费).HasColumnName("应收_污水费");

                entity.Property(e => e.应收滞纳金).HasColumnName("应收_滞纳金");

                entity.Property(e => e.应收用水量).HasColumnName("应收_用水量");

                entity.Property(e => e.应收附加费).HasColumnName("应收_附加费");

                entity.Property(e => e.收费人员姓名).HasMaxLength(50);

                entity.Property(e => e.收费人员统计表名称).HasMaxLength(50);

                entity.Property(e => e.时间止)
                    .HasColumnName("时间_止")
                    .HasColumnType("datetime");

                entity.Property(e => e.时间起)
                    .HasColumnName("时间_起")
                    .HasColumnType("datetime");

                entity.Property(e => e.预存上次预存余额).HasColumnName("预存_上次预存余额");

                entity.Property(e => e.预存实缴金额).HasColumnName("预存_实缴金额");

                entity.Property(e => e.预存本月预存).HasColumnName("预存_本月预存");

                entity.Property(e => e.预存预存余额).HasColumnName("预存_预存余额");
            });

            modelBuilder.Entity<自来水报表营业销售收入稽核明细表>(entity =>
            {
                entity.HasKey(e => e.稽核明细表编号);

                entity.ToTable("自来水_报表_营业销售收入稽核明细表");

                entity.Property(e => e.用水性质类别)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<自来水报表用水成本>(entity =>
            {
                entity.HasKey(e => e.成本分析编号);

                entity.ToTable("自来水_报表_用水成本");

                entity.Property(e => e.所属时期).HasColumnType("datetime");
            });

            modelBuilder.Entity<自来水报表用水性质>(entity =>
            {
                entity.HasKey(e => e.用水性质编号);

                entity.ToTable("自来水_报表_用水性质");

                entity.Property(e => e.用水性质编号)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.上年同期数吨数).HasColumnName("上年同期数_吨数");

                entity.Property(e => e.上年同期数金额).HasColumnName("上年同期数_金额");

                entity.Property(e => e.本期数吨数).HasColumnName("本期数_吨数");

                entity.Property(e => e.本期数吨数占总量比例).HasColumnName("本期数_吨数占总量比例");

                entity.Property(e => e.本期数金额).HasColumnName("本期数_金额");

                entity.Property(e => e.本期数金额占总量比例).HasColumnName("本期数_金额占总量比例");

                entity.Property(e => e.比上年同期增减比例吨数).HasColumnName("比上年同期增减比例_吨数");

                entity.Property(e => e.比上年同期增减比例金额).HasColumnName("比上年同期增减比例_金额");

                entity.Property(e => e.比上年同期增减额吨数).HasColumnName("比上年同期增减额_吨数");

                entity.Property(e => e.比上年同期增减额金额).HasColumnName("比上年同期增减额_金额");

                entity.Property(e => e.用水性质名称)
                    .IsRequired()
                    .HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<自来水报表用水性质汇总表>(entity =>
            {
                entity.HasKey(e => e.用水性质汇总表编号);

                entity.ToTable("自来水_报表_用水性质汇总表");

                entity.Property(e => e.报表类型)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用水性质名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用水性质编号)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<自来水编号段号>(entity =>
            {
                entity.HasKey(e => e.段号主键);

                entity.ToTable("自来水_编号_段号");

                entity.Property(e => e.段号名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.段号编号)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<自来水编号片号>(entity =>
            {
                entity.HasKey(e => e.片号主键);

                entity.ToTable("自来水_编号_片号");

                entity.Property(e => e.片号名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.片号编号)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<自来水编号区号>(entity =>
            {
                entity.HasKey(e => e.区号主键);

                entity.ToTable("自来水_编号_区号");

                entity.Property(e => e.区号名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.区号编号)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<自来水编号水表>(entity =>
            {
                entity.HasKey(e => e.水表型号编号);

                entity.ToTable("自来水_编号_水表");

                entity.Property(e => e.水表型号编号)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.水表型号名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.水表最大量程).HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<自来水编号水表安装位置>(entity =>
            {
                entity.HasKey(e => e.安装位置编号);

                entity.ToTable("自来水_编号_水表安装位置");

                entity.Property(e => e.安装位置名称).HasMaxLength(50);
            });

            modelBuilder.Entity<自来水编号小区编号>(entity =>
            {
                entity.HasKey(e => e.小区名称编号);

                entity.ToTable("自来水_编号_小区编号");

                entity.Property(e => e.小区名称).HasMaxLength(50);
            });

            modelBuilder.Entity<自来水编号用水性质>(entity =>
            {
                entity.HasKey(e => e.用水性质编号);

                entity.ToTable("自来水_编号_用水性质");

                entity.HasIndex(e => e.用水性质编号)
                    .HasName("IX_自来水_编号_用水性质")
                    .IsUnique();

                entity.Property(e => e.用水性质编号)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.分类名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.滞纳金).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.用水性质名称)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<自来水编号用水性质阶梯水价>(entity =>
            {
                entity.HasKey(e => e.阶梯水价编号);

                entity.ToTable("自来水_编号_用水性质_阶梯水价");

                entity.Property(e => e.用水性质名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用水性质编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.用水性质编号Navigation)
                    .WithMany(p => p.自来水编号用水性质阶梯水价)
                    .HasForeignKey(d => d.用水性质编号)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_自来水_编号_用水性质_阶梯水价_自来水_编号_用水性质");
            });

            modelBuilder.Entity<自来水财务记帐凭证>(entity =>
            {
                entity.HasKey(e => e.记帐凭证编号);

                entity.ToTable("自来水_财务_记帐凭证");

                entity.Property(e => e.记帐凭证编号)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.减免收费).HasColumnName("减免_收费");

                entity.Property(e => e.减免滞纳金).HasColumnName("减免_滞纳金");

                entity.Property(e => e.凭证类型)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.应收其它费用).HasColumnName("应收_其它费用");

                entity.Property(e => e.应收合计).HasColumnName("应收_合计");

                entity.Property(e => e.应收实际应收).HasColumnName("应收_实际应收");

                entity.Property(e => e.应收小计).HasColumnName("应收_小计");

                entity.Property(e => e.应收水费).HasColumnName("应收_水费");

                entity.Property(e => e.应收污水费).HasColumnName("应收_污水费");

                entity.Property(e => e.应收滞纳金).HasColumnName("应收_滞纳金");

                entity.Property(e => e.应收附加费).HasColumnName("应收_附加费");

                entity.Property(e => e.抄表人员姓名).HasMaxLength(50);

                entity.Property(e => e.收款人员姓名).HasMaxLength(50);

                entity.Property(e => e.收款方式).HasMaxLength(10);

                entity.Property(e => e.收款日期).HasColumnType("datetime");

                entity.Property(e => e.收费人员姓名).HasMaxLength(50);

                entity.Property(e => e.收费月份).HasColumnType("datetime");

                entity.Property(e => e.用水性质分类).HasMaxLength(50);

                entity.Property(e => e.用水性质名称).HasMaxLength(50);

                entity.Property(e => e.用水性质编号).HasMaxLength(10);

                entity.Property(e => e.结帐月份).HasColumnType("date");

                entity.Property(e => e.营业汇总人员姓名).HasMaxLength(50);

                entity.Property(e => e.营业汇总编号).HasMaxLength(10);

                entity.Property(e => e.记帐人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.记帐日期).HasColumnType("datetime");

                entity.Property(e => e.费率其它费用).HasColumnName("费率_其它费用");

                entity.Property(e => e.费率水费).HasColumnName("费率_水费");

                entity.Property(e => e.费率污水费).HasColumnName("费率_污水费");

                entity.Property(e => e.费率滞纳金)
                    .HasColumnName("费率_滞纳金")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.费率附加费).HasColumnName("费率_附加费");

                entity.Property(e => e.预存上次预存余额).HasColumnName("预存_上次预存余额");

                entity.Property(e => e.预存实缴金额).HasColumnName("预存_实缴金额");

                entity.Property(e => e.预存本月预存).HasColumnName("预存_本月预存");

                entity.Property(e => e.预存预存余额).HasColumnName("预存_预存余额");
            });

            modelBuilder.Entity<自来水财务营业收费情况汇总单>(entity =>
            {
                entity.HasKey(e => e.收费情况汇总单编号);

                entity.ToTable("自来水_财务_营业收费情况汇总单");

                entity.Property(e => e.收费情况汇总单编号)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.实收其它费用).HasColumnName("实收_其它费用");

                entity.Property(e => e.实收合计).HasColumnName("实收_合计");

                entity.Property(e => e.实收小计).HasColumnName("实收_小计");

                entity.Property(e => e.实收本期预存).HasColumnName("实收_本期预存");

                entity.Property(e => e.实收水费).HasColumnName("实收_水费");

                entity.Property(e => e.实收污水费).HasColumnName("实收_污水费");

                entity.Property(e => e.实收滞纳金).HasColumnName("实收_滞纳金");

                entity.Property(e => e.实收用水量).HasColumnName("实收_用水量");

                entity.Property(e => e.实收附加费).HasColumnName("实收_附加费");

                entity.Property(e => e.当期其它费用).HasColumnName("当期_其它费用");

                entity.Property(e => e.当期合计).HasColumnName("当期_合计");

                entity.Property(e => e.当期小计).HasColumnName("当期_小计");

                entity.Property(e => e.当期本期预存).HasColumnName("当期_本期预存");

                entity.Property(e => e.当期水费).HasColumnName("当期_水费");

                entity.Property(e => e.当期污水费).HasColumnName("当期_污水费");

                entity.Property(e => e.当期滞纳金).HasColumnName("当期_滞纳金");

                entity.Property(e => e.当期用水量).HasColumnName("当期_用水量");

                entity.Property(e => e.当期附加费).HasColumnName("当期_附加费");

                entity.Property(e => e.汇总人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.汇总日期).HasColumnType("datetime");

                entity.Property(e => e.用水分类)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.结帐月份).HasColumnType("date");

                entity.Property(e => e.陈欠其它费用).HasColumnName("陈欠_其它费用");

                entity.Property(e => e.陈欠合计).HasColumnName("陈欠_合计");

                entity.Property(e => e.陈欠小计).HasColumnName("陈欠_小计");

                entity.Property(e => e.陈欠本期预存).HasColumnName("陈欠_本期预存");

                entity.Property(e => e.陈欠水费).HasColumnName("陈欠_水费");

                entity.Property(e => e.陈欠污水费).HasColumnName("陈欠_污水费");

                entity.Property(e => e.陈欠滞纳金).HasColumnName("陈欠_滞纳金");

                entity.Property(e => e.陈欠用水量).HasColumnName("陈欠_用水量");

                entity.Property(e => e.陈欠附加费).HasColumnName("陈欠_附加费");
            });

            modelBuilder.Entity<自来水抄表抄表台帐>(entity =>
            {
                entity.HasKey(e => e.抄表台帐编号);

                entity.ToTable("自来水_抄表_抄表台帐");

                entity.Property(e => e.减免收费).HasColumnName("减免_收费");

                entity.Property(e => e.减免滞纳金).HasColumnName("减免_滞纳金");

                entity.Property(e => e.区号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.发票上次表数).HasColumnName("发票_上次表数");

                entity.Property(e => e.发票分表数).HasColumnName("发票_分表数");

                entity.Property(e => e.发票应收其它费用).HasColumnName("发票_应收_其它费用");

                entity.Property(e => e.发票应收合计).HasColumnName("发票_应收_合计");

                entity.Property(e => e.发票应收水费).HasColumnName("发票_应收_水费");

                entity.Property(e => e.发票应收污水费).HasColumnName("发票_应收_污水费");

                entity.Property(e => e.发票应收滞纳金).HasColumnName("发票_应收_滞纳金");

                entity.Property(e => e.发票应收附加费).HasColumnName("发票_应收_附加费");

                entity.Property(e => e.发票本次表数).HasColumnName("发票_本次表数");

                entity.Property(e => e.发票汇总人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.发票汇总日期).HasColumnType("datetime");

                entity.Property(e => e.发票汇总编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.发票用水量).HasColumnName("发票_用水量");

                entity.Property(e => e.发票编号).HasMaxLength(50);

                entity.Property(e => e.台帐状态).HasMaxLength(50);

                entity.Property(e => e.台帐生成人员姓名).HasMaxLength(50);

                entity.Property(e => e.地址).HasMaxLength(50);

                entity.Property(e => e.小区名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.应收其它费用).HasColumnName("应收_其它费用");

                entity.Property(e => e.应收合计).HasColumnName("应收_合计");

                entity.Property(e => e.应收实际应收).HasColumnName("应收_实际应收");

                entity.Property(e => e.应收小计).HasColumnName("应收_小计");

                entity.Property(e => e.应收水费).HasColumnName("应收_水费");

                entity.Property(e => e.应收污水费).HasColumnName("应收_污水费");

                entity.Property(e => e.应收滞纳金).HasColumnName("应收_滞纳金");

                entity.Property(e => e.应收附加费).HasColumnName("应收_附加费");

                entity.Property(e => e.建档类型).HasMaxLength(50);

                entity.Property(e => e.抄表人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.抄表录入人员姓名).HasMaxLength(50);

                entity.Property(e => e.抄表录入日期).HasColumnType("datetime");

                entity.Property(e => e.收款人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.收款方式)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.收款日期).HasColumnType("datetime");

                entity.Property(e => e.收费人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.收费月份).HasColumnType("date");

                entity.Property(e => e.段号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.水表安装位置).HasMaxLength(10);

                entity.Property(e => e.汇总销号人员姓名).HasMaxLength(50);

                entity.Property(e => e.汇总销号日期).HasColumnType("datetime");

                entity.Property(e => e.片号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.生成台帐日期).HasColumnType("datetime");

                entity.Property(e => e.用户名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用户状态)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用户简码).HasMaxLength(50);

                entity.Property(e => e.用户编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用水性质分类)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用水性质名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用水性质编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.联系电话).HasMaxLength(50);

                entity.Property(e => e.记帐人员名称已收)
                    .HasColumnName("记帐人员名称_已收")
                    .HasMaxLength(50);

                entity.Property(e => e.记帐人员名称应收)
                    .HasColumnName("记帐人员名称_应收")
                    .HasMaxLength(50);

                entity.Property(e => e.记帐人员编号已收).HasColumnName("记帐人员编号_已收");

                entity.Property(e => e.记帐人员编号应收).HasColumnName("记帐人员编号_应收");

                entity.Property(e => e.记帐凭证编号已收)
                    .HasColumnName("记帐凭证编号_已收")
                    .HasMaxLength(10);

                entity.Property(e => e.记帐凭证编号应收)
                    .HasColumnName("记帐凭证编号_应收")
                    .HasMaxLength(10);

                entity.Property(e => e.记帐日期已收)
                    .HasColumnName("记帐日期_已收")
                    .HasColumnType("datetime");

                entity.Property(e => e.记帐日期应收)
                    .HasColumnName("记帐日期_应收")
                    .HasColumnType("datetime");

                entity.Property(e => e.记帐标志已收).HasColumnName("记帐标志_已收");

                entity.Property(e => e.记帐标志应收).HasColumnName("记帐标志_应收");

                entity.Property(e => e.费率其它费用).HasColumnName("费率_其它费用");

                entity.Property(e => e.费率水费).HasColumnName("费率_水费");

                entity.Property(e => e.费率污水费).HasColumnName("费率_污水费");

                entity.Property(e => e.费率滞纳金)
                    .HasColumnName("费率_滞纳金")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.费率附加费).HasColumnName("费率_附加费");

                entity.Property(e => e.预存上次预存余额).HasColumnName("预存_上次预存余额");

                entity.Property(e => e.预存实缴金额).HasColumnName("预存_实缴金额");

                entity.Property(e => e.预存扣除金额).HasColumnName("预存_扣除金额");

                entity.Property(e => e.预存本月预存).HasColumnName("预存_本月预存");

                entity.Property(e => e.预存预存余额).HasColumnName("预存_预存余额");
            });

            modelBuilder.Entity<自来水缴费用户>(entity =>
            {
                entity.HasKey(e => e.用户编号);

                entity.ToTable("自来水_缴费用户");

                entity.Property(e => e.用户编号)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bybz).HasColumnName("bybz");

                entity.Property(e => e.Sybz).HasColumnName("sybz");

                entity.Property(e => e.Syye).HasColumnName("syye");

                entity.Property(e => e.Ycsf).HasColumnName("ycsf");

                entity.Property(e => e.Ye).HasColumnName("ye");

                entity.Property(e => e.Ysl).HasColumnName("ysl");

                entity.Property(e => e.主表用户编号).HasMaxLength(50);

                entity.Property(e => e.区号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.单元).HasMaxLength(50);

                entity.Property(e => e.地址).HasMaxLength(50);

                entity.Property(e => e.地址简码).HasMaxLength(50);

                entity.Property(e => e.备注).HasMaxLength(1000);

                entity.Property(e => e.审核人员姓名).HasMaxLength(50);

                entity.Property(e => e.小区名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.建档日期).HasColumnType("datetime");

                entity.Property(e => e.建档类型)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.开户银行).HasMaxLength(50);

                entity.Property(e => e.开户银行帐号).HasMaxLength(50);

                entity.Property(e => e.抄表人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.操作人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.收费人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.最后更新日期).HasColumnType("datetime");

                entity.Property(e => e.楼号).HasMaxLength(50);

                entity.Property(e => e.段号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.水表产地)
                    .HasColumnName("水表_产地")
                    .HasMaxLength(50);

                entity.Property(e => e.水表型号名称).HasMaxLength(50);

                entity.Property(e => e.水表安装位置)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.水表安装日期).HasColumnType("datetime");

                entity.Property(e => e.水表表号码)
                    .HasColumnName("水表_表号码")
                    .HasMaxLength(50);

                entity.Property(e => e.水表表锁)
                    .HasColumnName("水表_表锁")
                    .HasMaxLength(50);

                entity.Property(e => e.水表铝封号)
                    .HasColumnName("水表_铝封号")
                    .HasMaxLength(50);

                entity.Property(e => e.片号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用户名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用户状态)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用户简码)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用水性质分类).HasMaxLength(50);

                entity.Property(e => e.用水性质名称).HasMaxLength(50);

                entity.Property(e => e.用水性质编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.联系手机).HasMaxLength(50);

                entity.Property(e => e.联系电话).HasMaxLength(50);

                entity.Property(e => e.证件号码).HasMaxLength(50);

                entity.Property(e => e.证件类型).HasMaxLength(50);

                entity.Property(e => e.门牌号).HasMaxLength(50);

                entity.Property(e => e.顺序号).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<自来水缴费用户变更信息>(entity =>
            {
                entity.HasKey(e => e.变更编号);

                entity.ToTable("自来水_缴费用户_变更信息");

                entity.Property(e => e.Bybz).HasColumnName("bybz");

                entity.Property(e => e.Sybz).HasColumnName("sybz");

                entity.Property(e => e.Syye).HasColumnName("syye");

                entity.Property(e => e.Ycsf).HasColumnName("ycsf");

                entity.Property(e => e.Ye).HasColumnName("ye");

                entity.Property(e => e.Ysl).HasColumnName("ysl");

                entity.Property(e => e.主表用户编号).HasMaxLength(50);

                entity.Property(e => e.区号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.单元).HasMaxLength(50);

                entity.Property(e => e.变更人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.变更原因)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.变更日期).HasColumnType("datetime");

                entity.Property(e => e.变更类型)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.地址).HasMaxLength(50);

                entity.Property(e => e.地址简码).HasMaxLength(50);

                entity.Property(e => e.备注).HasMaxLength(1000);

                entity.Property(e => e.审核人员姓名).HasMaxLength(50);

                entity.Property(e => e.小区名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.建档日期).HasColumnType("datetime");

                entity.Property(e => e.建档类型)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.开户银行).HasMaxLength(50);

                entity.Property(e => e.开户银行帐号).HasMaxLength(50);

                entity.Property(e => e.抄表人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.操作人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.收费人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.最后更新日期).HasColumnType("datetime");

                entity.Property(e => e.楼号).HasMaxLength(50);

                entity.Property(e => e.段号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.水表产地)
                    .HasColumnName("水表_产地")
                    .HasMaxLength(50);

                entity.Property(e => e.水表型号名称).HasMaxLength(50);

                entity.Property(e => e.水表安装位置)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.水表安装日期).HasColumnType("datetime");

                entity.Property(e => e.水表表号码)
                    .HasColumnName("水表_表号码")
                    .HasMaxLength(50);

                entity.Property(e => e.水表表锁)
                    .HasColumnName("水表_表锁")
                    .HasMaxLength(50);

                entity.Property(e => e.水表铝封号)
                    .HasColumnName("水表_铝封号")
                    .HasMaxLength(50);

                entity.Property(e => e.片号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用户名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用户状态)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用户简码)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用户编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用水性质分类).HasMaxLength(50);

                entity.Property(e => e.用水性质名称).HasMaxLength(50);

                entity.Property(e => e.用水性质编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.联系手机).HasMaxLength(50);

                entity.Property(e => e.联系电话).HasMaxLength(50);

                entity.Property(e => e.证件号码).HasMaxLength(50);

                entity.Property(e => e.证件类型).HasMaxLength(50);

                entity.Property(e => e.门牌号).HasMaxLength(50);

                entity.Property(e => e.顺序号).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<自来水收费个人收费汇总单>(entity =>
            {
                entity.HasKey(e => e.汇总编号);

                entity.ToTable("自来水_收费_个人收费汇总单");

                entity.Property(e => e.汇总编号)
                    .HasMaxLength(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.二级汇总编号).HasMaxLength(15);

                entity.Property(e => e.备注).HasMaxLength(50);

                entity.Property(e => e.审核人员姓名).HasMaxLength(50);

                entity.Property(e => e.审核日期).HasColumnType("datetime");

                entity.Property(e => e.汇总人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.汇总日期).HasColumnType("datetime");
            });

            modelBuilder.Entity<自来水收费收费减免>(entity =>
            {
                entity.HasKey(e => e.减免编号);

                entity.ToTable("自来水_收费_收费减免");

                entity.Property(e => e.减免编号)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.减免情况及原因).HasMaxLength(255);

                entity.Property(e => e.地址).HasMaxLength(50);

                entity.Property(e => e.收费人员姓名)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用户名称)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.用户编号)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.用水性质)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.申请日期).HasColumnType("datetime");

                entity.Property(e => e.经理意见).HasMaxLength(255);

                entity.Property(e => e.联系电话).HasMaxLength(50);

                entity.Property(e => e.营业股意见).HasMaxLength(255);
            });

            modelBuilder.Entity<自来水系统参数设置>(entity =>
            {
                entity.HasKey(e => e.编号);

                entity.ToTable("自来水_系统_参数设置");
            });
        }
    }
}
