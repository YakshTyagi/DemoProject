using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backstage.Models
{
    public partial class BackstageContext : DbContext
    {
        public BackstageContext()
        {
        }

        public BackstageContext(DbContextOptions<BackstageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetAdditionalDetails> AssetAdditionalDetails { get; set; }
        public virtual DbSet<AssetCast> AssetCast { get; set; }
        public virtual DbSet<AssetCastDetails> AssetCastDetails { get; set; }
        public virtual DbSet<AssetGenres> AssetGenres { get; set; }
        public virtual DbSet<AssetLanguages> AssetLanguages { get; set; }
        public virtual DbSet<AssetLogos> AssetLogos { get; set; }
        public virtual DbSet<AssetMovieDetails> AssetMovieDetails { get; set; }
        public virtual DbSet<AssetOffers> AssetOffers { get; set; }
        public virtual DbSet<AssetPreviewDetails> AssetPreviewDetails { get; set; }
        public virtual DbSet<AssetTitleDescriptions> AssetTitleDescriptions { get; set; }
        public virtual DbSet<AssetTitleDetails> AssetTitleDetails { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<AssetView> AssetView { get; set; }
        public virtual DbSet<AssetView2> AssetView2 { get; set; }
        public virtual DbSet<BackstageModules> BackstageModules { get; set; }
        public virtual DbSet<BrandSeriesCrossref> BrandSeriesCrossref { get; set; }
        public virtual DbSet<CaEntitlements> CaEntitlements { get; set; }
        public virtual DbSet<CastingTypes> CastingTypes { get; set; }
        public virtual DbSet<Configurations> Configurations { get; set; }
        public virtual DbSet<ContentCategories> ContentCategories { get; set; }
        public virtual DbSet<ContentProviders> ContentProviders { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DeviceEncryptionProfiles> DeviceEncryptionProfiles { get; set; }
        public virtual DbSet<ElementalDeltaIps> ElementalDeltaIps { get; set; }
        public virtual DbSet<EpgAudioLanguages> EpgAudioLanguages { get; set; }
        public virtual DbSet<EpgCaEntitlements> EpgCaEntitlements { get; set; }
        public virtual DbSet<EpgCasting> EpgCasting { get; set; }
        public virtual DbSet<EpgDescriptions> EpgDescriptions { get; set; }
        public virtual DbSet<EpgEventIdentifiers> EpgEventIdentifiers { get; set; }
        public virtual DbSet<EpgEvents> EpgEvents { get; set; }
        public virtual DbSet<EpgGenre> EpgGenre { get; set; }
        public virtual DbSet<EpgGroupRecord> EpgGroupRecord { get; set; }
        public virtual DbSet<EpgLanguages> EpgLanguages { get; set; }
        public virtual DbSet<EpgPoster> EpgPoster { get; set; }
        public virtual DbSet<EpgScheduleFiles> EpgScheduleFiles { get; set; }
        public virtual DbSet<EpgSettings> EpgSettings { get; set; }
        public virtual DbSet<EpgTags> EpgTags { get; set; }
        public virtual DbSet<EpgXtiEventCrossref> EpgXtiEventCrossref { get; set; }
        public virtual DbSet<Html5AppBuildVersions> Html5AppBuildVersions { get; set; }
        public virtual DbSet<Html5Apps> Html5Apps { get; set; }
        public virtual DbSet<Html5FileDetails> Html5FileDetails { get; set; }
        public virtual DbSet<Html5Files> Html5Files { get; set; }
        public virtual DbSet<Html5OnlineApps> Html5OnlineApps { get; set; }
        public virtual DbSet<HtmlPaitVersion> HtmlPaitVersion { get; set; }
        public virtual DbSet<Iapp> Iapp { get; set; }
        public virtual DbSet<IappBuildVersions> IappBuildVersions { get; set; }
        public virtual DbSet<IappFileDetails> IappFileDetails { get; set; }
        public virtual DbSet<IappFileMaster> IappFileMaster { get; set; }
        public virtual DbSet<IappFiles> IappFiles { get; set; }
        public virtual DbSet<Ischedule> Ischedule { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LogoContentTypes> LogoContentTypes { get; set; }
        public virtual DbSet<MetadataContentTypes> MetadataContentTypes { get; set; }
        public virtual DbSet<OfficeLocations> OfficeLocations { get; set; }
        public virtual DbSet<OttPlatforms> OttPlatforms { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<SeriesProgramCrossref> SeriesProgramCrossref { get; set; }
        public virtual DbSet<ServiceAddtionalDetails> ServiceAddtionalDetails { get; set; }
        public virtual DbSet<ServiceConfigurations> ServiceConfigurations { get; set; }
        public virtual DbSet<ServiceDescriptions> ServiceDescriptions { get; set; }
        public virtual DbSet<ServiceDisplayedSubscriptionPackages> ServiceDisplayedSubscriptionPackages { get; set; }
        public virtual DbSet<ServiceEncryptionProfiles> ServiceEncryptionProfiles { get; set; }
        public virtual DbSet<ServiceEpgConfigurations> ServiceEpgConfigurations { get; set; }
        public virtual DbSet<ServiceGenres> ServiceGenres { get; set; }
        public virtual DbSet<ServiceLanguages> ServiceLanguages { get; set; }
        public virtual DbSet<ServiceLogos> ServiceLogos { get; set; }
        public virtual DbSet<ServiceSubscriptionPackages> ServiceSubscriptionPackages { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ShowTypes> ShowTypes { get; set; }
        public virtual DbSet<SmilProfiles> SmilProfiles { get; set; }
        public virtual DbSet<SubPolicyContentCrossref> SubPolicyContentCrossref { get; set; }
        public virtual DbSet<SubscriptionDescriptions> SubscriptionDescriptions { get; set; }
        public virtual DbSet<SubscriptionDetails> SubscriptionDetails { get; set; }
        public virtual DbSet<SubscriptionLanguages> SubscriptionLanguages { get; set; }
        public virtual DbSet<SubscriptionOffers> SubscriptionOffers { get; set; }
        public virtual DbSet<SubscriptionPackages> SubscriptionPackages { get; set; }
        public virtual DbSet<SubscriptionPolicies> SubscriptionPolicies { get; set; }
        public virtual DbSet<SubsriptionTerms> SubsriptionTerms { get; set; }
        public virtual DbSet<UserRoleMapping> UserRoleMapping { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VwAppFileDetails> VwAppFileDetails { get; set; }
        public virtual DbSet<VwApplicationBuilds> VwApplicationBuilds { get; set; }
        public virtual DbSet<VwApplicationDetails> VwApplicationDetails { get; set; }
        public virtual DbSet<VwAssetCasting> VwAssetCasting { get; set; }
        public virtual DbSet<VwDistributionList> VwDistributionList { get; set; }
        public virtual DbSet<VwEpgEntitlements> VwEpgEntitlements { get; set; }
        public virtual DbSet<VwEpgEventInfo> VwEpgEventInfo { get; set; }
        public virtual DbSet<VwEpgLanguages> VwEpgLanguages { get; set; }
        public virtual DbSet<VwHApps2ingest> VwHApps2ingest { get; set; }
        public virtual DbSet<VwHtml5Applicationfiledetails> VwHtml5Applicationfiledetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-26JC778;Database=Backstage;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("asset");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.AssetTypeId).HasColumnName("asset_type_id");

                entity.Property(e => e.CreationDateTime)
                    .HasColumnName("creationDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EncryptionTypeId).HasColumnName("encryption_type_id");

                entity.Property(e => e.EndDateTime)
                    .HasColumnName("endDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageAssetId)
                    .IsRequired()
                    .HasColumnName("package_asset_id")
                    .IsUnicode(false);

                entity.Property(e => e.PkgDescriptionEng)
                    .IsRequired()
                    .HasColumnName("pkg_description_eng")
                    .IsUnicode(false);

                entity.Property(e => e.PkgDescriptionHin)
                    .IsRequired()
                    .HasColumnName("pkg_description_hin");

                entity.Property(e => e.PkgVerMaj)
                    .HasColumnName("pkg_ver_maj")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PkgVerMin).HasColumnName("pkg_ver_min");

                entity.Property(e => e.StartDateTime)
                    .HasColumnName("startDateTime")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.AssetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_asset_type");

                entity.HasOne(d => d.EncryptionType)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.EncryptionTypeId)
                    .HasConstraintName("FK_asset_subscription_policies");
            });

            modelBuilder.Entity<AssetAdditionalDetails>(entity =>
            {
                entity.ToTable("asset_additional_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalBy).HasColumnName("approval_by");

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.IngestionTime)
                    .HasColumnName("ingestion_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModificationTime)
                    .HasColumnName("modification_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetAdditionalDetails)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_additional_details_asset");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AssetAdditionalDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_asset_additional_details_users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AssetAdditionalDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_asset_additional_details_users1");
            });

            modelBuilder.Entity<AssetCast>(entity =>
            {
                entity.ToTable("asset_cast");

                entity.HasIndex(e => e.AssetId)
                    .HasName("IX_OPT_asset_cast_asset_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.CastTypeId).HasColumnName("cast_type_id");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetCast)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_cast_asset");

                entity.HasOne(d => d.CastType)
                    .WithMany(p => p.AssetCast)
                    .HasForeignKey(d => d.CastTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_cast_casting_types");
            });

            modelBuilder.Entity<AssetCastDetails>(entity =>
            {
                entity.ToTable("asset_cast_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CastId).HasColumnName("cast_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .IsUnicode(false);

                entity.HasOne(d => d.Cast)
                    .WithMany(p => p.AssetCastDetails)
                    .HasForeignKey(d => d.CastId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_cast_details_asset_cast");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AssetCastDetails)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_cast_details_languages");
            });

            modelBuilder.Entity<AssetGenres>(entity =>
            {
                entity.ToTable("asset_genres");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetGenres)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_genres_asset");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.AssetGenres)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_genres_epg_genre");
            });

            modelBuilder.Entity<AssetLanguages>(entity =>
            {
                entity.ToTable("asset_languages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetLanguages)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_languages_asset");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AssetLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_languages_languages");
            });

            modelBuilder.Entity<AssetLogos>(entity =>
            {
                entity.ToTable("asset_logos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.ContentCheckSum)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ContentId).HasColumnName("contentId");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .IsUnicode(false);

                entity.Property(e => e.XResolution)
                    .HasColumnName("x_resolution")
                    .HasDefaultValueSql("((288))");

                entity.Property(e => e.YResolution)
                    .HasColumnName("y_resolution")
                    .HasDefaultValueSql("((216))");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetLogos)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_logos_asset");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.AssetLogos)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_logos_LogoContentTypes");
            });

            modelBuilder.Entity<AssetMovieDetails>(entity =>
            {
                entity.ToTable("asset_movie_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.AudioType)
                    .IsRequired()
                    .HasColumnName("audio_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentFilename)
                    .IsRequired()
                    .HasColumnName("content_filename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaIpId).HasColumnName("DeltaIP_id");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.IsHd).HasColumnName("isHD");

                entity.Property(e => e.ScreenFormat)
                    .IsRequired()
                    .HasColumnName("screen_format")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetMovieDetails)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_movie_details_asset");

                entity.HasOne(d => d.DeltaIp)
                    .WithMany(p => p.AssetMovieDetails)
                    .HasForeignKey(d => d.DeltaIpId)
                    .HasConstraintName("FK_asset_movie_details_ElementalDeltaIPs");
            });

            modelBuilder.Entity<AssetOffers>(entity =>
            {
                entity.ToTable("asset_offers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.BillingId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderContentTier)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetOffers)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_offers_asset");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.AssetOffers)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_offers_content_providers");
            });

            modelBuilder.Entity<AssetPreviewDetails>(entity =>
            {
                entity.ToTable("asset_preview_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.AudioType)
                    .IsRequired()
                    .HasColumnName("audio_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentFilename)
                    .IsRequired()
                    .HasColumnName("content_filename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeltaIpId).HasColumnName("DeltaIP_id");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.IsHd).HasColumnName("isHD");

                entity.Property(e => e.ScreenFormat)
                    .IsRequired()
                    .HasColumnName("screen_format")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetPreviewDetails)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_preview_details_asset");

                entity.HasOne(d => d.DeltaIp)
                    .WithMany(p => p.AssetPreviewDetails)
                    .HasForeignKey(d => d.DeltaIpId)
                    .HasConstraintName("FK_asset_preview_details_ElementalDeltaIPs");
            });

            modelBuilder.Entity<AssetTitleDescriptions>(entity =>
            {
                entity.ToTable("asset_title_descriptions");

                entity.HasIndex(e => new { e.AssetId, e.LanguageId })
                    .HasName("IX_OPT_asset_title_descriptions_asset_id_language_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetTitleDescriptions)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_title_descriptions_asset");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.AssetTitleDescriptions)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_title_descriptions_languages");
            });

            modelBuilder.Entity<AssetTitleDetails>(entity =>
            {
                entity.ToTable("asset_title_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.DownloadExpiry).HasDefaultValueSql("((0))");

                entity.Property(e => e.EpisodeId).HasColumnName("EpisodeID");

                entity.Property(e => e.EpisodeName).IsUnicode(false);

                entity.Property(e => e.IsClosedCaptioning).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDownloadable)
                    .HasColumnName("isDownloadable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShowcase)
                    .HasColumnName("isShowcase")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .IsUnicode(false);

                entity.Property(e => e.MaxConcurrentStreams).HasDefaultValueSql("((3))");

                entity.Property(e => e.Msorating).HasColumnName("MSORating");

                entity.Property(e => e.PGenreId).HasColumnName("p_genre_id");

                entity.Property(e => e.PlatformId).HasColumnName("platform_id");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.RentalExpiry).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowId).HasColumnName("show_id");

                entity.Property(e => e.Year).HasDefaultValueSql("((1900))");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetTitleDetails)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_title_details_asset");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.AssetTitleDetails)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_title_details_content_categories");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AssetTitleDetails)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_asset_title_details_countries");

                entity.HasOne(d => d.PGenre)
                    .WithMany(p => p.AssetTitleDetails)
                    .HasForeignKey(d => d.PGenreId)
                    .HasConstraintName("FK_asset_title_details_epg_genre");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.AssetTitleDetails)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_asset_title_details_ott_platforms");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.AssetTitleDetails)
                    .HasForeignKey(d => d.RatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_asset_title_details_ratings");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.AssetTitleDetails)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK_asset_title_details_show_types");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.ToTable("asset_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("asset_view");

                entity.Property(e => e.AudioType)
                    .IsRequired()
                    .HasColumnName("audio_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .IsUnicode(false);

                entity.Property(e => e.ContentFilename)
                    .IsRequired()
                    .HasColumnName("content_filename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .IsUnicode(false);

                entity.Property(e => e.CreationDateTime)
                    .HasColumnName("creationDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.ElementalDeltaIp)
                    .IsRequired()
                    .HasColumnName("ElementalDeltaIP")
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime)
                    .HasColumnName("endDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EpisodeId).HasColumnName("EpisodeID");

                entity.Property(e => e.EpisodeName).IsUnicode(false);

                entity.Property(e => e.IsDownloadable).HasColumnName("isDownloadable");

                entity.Property(e => e.IsHd).HasColumnName("isHD");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnName("language_name")
                    .IsUnicode(false);

                entity.Property(e => e.Msorating).HasColumnName("MSORating");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PackageAssetId)
                    .IsRequired()
                    .HasColumnName("package_asset_id")
                    .IsUnicode(false);

                entity.Property(e => e.PkgDescriptionEng)
                    .IsRequired()
                    .HasColumnName("pkg_description_eng")
                    .IsUnicode(false);

                entity.Property(e => e.PkgVerMaj).HasColumnName("pkg_ver_maj");

                entity.Property(e => e.PkgVerMin).HasColumnName("pkg_ver_min");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProviderContentTier)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasColumnName("provider_name")
                    .IsUnicode(false);

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.RatingId1).HasColumnName("ratingId");

                entity.Property(e => e.ScreenFormat)
                    .IsRequired()
                    .HasColumnName("screen_format")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowType)
                    .IsRequired()
                    .HasColumnName("show_type")
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime)
                    .HasColumnName("startDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("asset_view2");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.AudioType)
                    .IsRequired()
                    .HasColumnName("audio_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.ContentFilename)
                    .IsRequired()
                    .HasColumnName("content_filename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .IsUnicode(false);

                entity.Property(e => e.CreationDateTime)
                    .HasColumnName("creationDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("time(0)");

                entity.Property(e => e.ElementalDeltaIp)
                    .IsRequired()
                    .HasColumnName("ElementalDeltaIP")
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime)
                    .HasColumnName("endDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.EpisodeId).HasColumnName("EpisodeID");

                entity.Property(e => e.EpisodeName).IsUnicode(false);

                entity.Property(e => e.IsDownloadable).HasColumnName("isDownloadable");

                entity.Property(e => e.IsHd).HasColumnName("isHD");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnName("language_name")
                    .IsUnicode(false);

                entity.Property(e => e.Msorating).HasColumnName("MSORating");

                entity.Property(e => e.PackageAssetId)
                    .IsRequired()
                    .HasColumnName("package_asset_id")
                    .IsUnicode(false);

                entity.Property(e => e.PkgDescriptionEng)
                    .IsRequired()
                    .HasColumnName("pkg_description_eng")
                    .IsUnicode(false);

                entity.Property(e => e.PkgVerMaj).HasColumnName("pkg_ver_maj");

                entity.Property(e => e.PkgVerMin).HasColumnName("pkg_ver_min");

                entity.Property(e => e.PlatformId).HasColumnName("platform_id");

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProviderContentTier)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.ScreenFormat)
                    .IsRequired()
                    .HasColumnName("screen_format")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowType)
                    .IsRequired()
                    .HasColumnName("show_type")
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime)
                    .HasColumnName("startDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackstageModules>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("backstage_modules");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("module_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAdminOnly).HasColumnName("is_admin_only");

                entity.Property(e => e.ModuleCode)
                    .IsRequired()
                    .HasColumnName("module_code")
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasColumnName("module_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrandSeriesCrossref>(entity =>
            {
                entity.ToTable("brand_series_crossref");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.SeriesId).HasColumnName("series_id");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.BrandSeriesCrossrefBrand)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_brand");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.BrandSeriesCrossrefSeries)
                    .HasForeignKey(d => d.SeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_series");
            });

            modelBuilder.Entity<CaEntitlements>(entity =>
            {
                entity.HasKey(e => e.CaSubId);

                entity.ToTable("ca_entitlements");

                entity.Property(e => e.CaSubId).HasColumnName("ca_sub_id");

                entity.Property(e => e.CaId).HasColumnName("ca_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CastingTypes>(entity =>
            {
                entity.ToTable("casting_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CastOrder).HasColumnName("cast_order");

                entity.Property(e => e.CastType)
                    .IsRequired()
                    .HasColumnName("cast_type")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Configurations>(entity =>
            {
                entity.HasKey(e => e.ConfId);

                entity.ToTable("configurations");

                entity.Property(e => e.ConfId).HasColumnName("conf_id");

                entity.Property(e => e.ConfCode)
                    .IsRequired()
                    .HasColumnName("conf_code")
                    .IsUnicode(false);

                entity.Property(e => e.ConfValue)
                    .IsRequired()
                    .HasColumnName("conf_value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContentCategories>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("content_categories");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContentProviders>(entity =>
            {
                entity.HasKey(e => e.ProviderId);

                entity.ToTable("content_providers");

                entity.HasIndex(e => e.BillingId)
                    .HasName("IX_content_providers")
                    .IsUnique();

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.BillingId).HasColumnName("billing_id");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("date_added")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicenseEnd)
                    .HasColumnName("license_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicenseStart)
                    .HasColumnName("license_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaximumViewingLength)
                    .HasColumnName("maximum_viewing_length")
                    .HasColumnType("time(0)");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasColumnName("provider")
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasColumnName("provider_name")
                    .IsUnicode(false);

                entity.Property(e => e.SmilSpecialProfile).HasColumnName("smil_special_profile");

                entity.Property(e => e.SuggestedPrice).HasColumnName("suggestedPrice");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("countries");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("departments");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasColumnName("department_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceEncryptionProfiles>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("device_encryption_profiles");

                entity.Property(e => e.ProfileId).HasColumnName("profile_id");

                entity.Property(e => e.DeviceClass)
                    .IsRequired()
                    .HasColumnName("deviceClass")
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.IsEncrypted).HasColumnName("isEncrypted");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.PackagingType)
                    .IsRequired()
                    .HasColumnName("packagingType")
                    .IsUnicode(false);

                entity.Property(e => e.ProfileName)
                    .IsRequired()
                    .HasColumnName("profile_name")
                    .IsUnicode(false);

                entity.Property(e => e.TranscodeProfileName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElementalDeltaIps>(entity =>
            {
                entity.HasKey(e => e.IpId);

                entity.ToTable("ElementalDeltaIPs");

                entity.Property(e => e.IpId).HasColumnName("Ip_id");

                entity.Property(e => e.CdnCatchupUrlprefix)
                    .HasColumnName("cdnCatchupURLPrefix")
                    .IsUnicode(false);

                entity.Property(e => e.CdnLiveUrlprefix)
                    .HasColumnName("cdnLiveURLPrefix")
                    .IsUnicode(false);

                entity.Property(e => e.CdnVodurlPrefix)
                    .HasColumnName("CdnVODUrlPrefix")
                    .IsUnicode(false);

                entity.Property(e => e.DomainName)
                    .HasColumnName("domain_name")
                    .IsUnicode(false);

                entity.Property(e => e.ElementalDeltaIp)
                    .IsRequired()
                    .HasColumnName("ElementalDeltaIP")
                    .IsUnicode(false);

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.ServerName)
                    .HasColumnName("server_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpgAudioLanguages>(entity =>
            {
                entity.ToTable("epg_audio_languages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.LanguageId).HasColumnName("languageId");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgAudioLanguages)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_audio_languages_epg_events");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EpgAudioLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_audio_languages_languages");
            });

            modelBuilder.Entity<EpgCaEntitlements>(entity =>
            {
                entity.HasKey(e => e.EntId);

                entity.ToTable("epg_ca_entitlements");

                entity.HasIndex(e => e.EventId)
                    .HasName("IX_OPT_epg_ca_entitlements_event_id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.CaSubId).HasColumnName("ca_sub_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.HasOne(d => d.CaSub)
                    .WithMany(p => p.EpgCaEntitlements)
                    .HasForeignKey(d => d.CaSubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_ca_entitlements_ca_entitlements");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgCaEntitlements)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_ca_entitlements_epg_events");
            });

            modelBuilder.Entity<EpgCasting>(entity =>
            {
                entity.ToTable("epg_casting");

                entity.HasIndex(e => new { e.Id, e.Actor, e.Producer, e.Director, e.EventId })
                    .HasName("IX_OPT_epg_casting_event_id_id_actor_producer_director");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actor)
                    .HasColumnName("actor")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Director)
                    .HasColumnName("director")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Producer)
                    .HasColumnName("producer")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgCasting)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_casting_epg_events");
            });

            modelBuilder.Entity<EpgDescriptions>(entity =>
            {
                entity.ToTable("epg_descriptions");

                entity.HasIndex(e => e.EventId)
                    .HasName("IX_OPT_epg_descriptions_event_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.LanguageId).HasColumnName("languageId");

                entity.Property(e => e.MarketingMsg).HasColumnName("marketingMsg");

                entity.Property(e => e.StbDescription).HasColumnName("stb_description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgDescriptions)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_descriptions_epg_events");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EpgDescriptions)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_descriptions_epg_languages");
            });

            modelBuilder.Entity<EpgEventIdentifiers>(entity =>
            {
                entity.ToTable("epg_event_identifiers");

                entity.HasIndex(e => new { e.Id, e.SlotId, e.Title, e.IconId, e.EventId })
                    .HasName("IX_OPT_epg_event_identifiers_event_id_id_slotId_title_iconId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconId).HasColumnName("iconId");

                entity.Property(e => e.SlotId)
                    .IsRequired()
                    .HasColumnName("slotId")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgEventIdentifiers)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_event_identifiers_epg_events");

                entity.HasOne(d => d.Icon)
                    .WithMany(p => p.EpgEventIdentifiers)
                    .HasForeignKey(d => d.IconId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_event_identifiers_epg_poster");
            });

            modelBuilder.Entity<EpgEvents>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("epg_events");

                entity.HasIndex(e => new { e.EventId, e.FileId })
                    .HasName("IX_OPT_epg_events_fileId_event_id");

                entity.HasIndex(e => new { e.EventId, e.EndTime, e.FileId, e.ServiceId, e.StartTime })
                    .HasName("IX_OPT_epg_events_event_id_endTime_fileId");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("fileId");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.EpgEvents)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_events_epg_schedule_files");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.EpgEvents)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_events_services");
            });

            modelBuilder.Entity<EpgGenre>(entity =>
            {
                entity.HasKey(e => e.GenreId);

                entity.ToTable("epg_genre");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genre_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpgGroupRecord>(entity =>
            {
                entity.ToTable("epg_group_record");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.GroupKey)
                    .IsRequired()
                    .HasColumnName("groupKey")
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .IsRequired()
                    .HasColumnName("groupType")
                    .IsUnicode(false);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgGroupRecord)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_group_record_epg_events");
            });

            modelBuilder.Entity<EpgLanguages>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("epg_languages");

                entity.HasIndex(e => e.LanguageCode)
                    .HasName("UNQ__epg_languages__language_code")
                    .IsUnique();

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("language_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .HasColumnName("language_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpgPoster>(entity =>
            {
                entity.HasKey(e => e.IngestUrlId);

                entity.ToTable("epg_poster");

                entity.HasIndex(e => e.IngestUrl)
                    .HasName("UNQ__epg_poster__catchup_service_id")
                    .IsUnique();

                entity.Property(e => e.IngestUrlId).HasColumnName("ingest_url_id");

                entity.Property(e => e.IngestUrl)
                    .IsRequired()
                    .HasColumnName("ingest_url")
                    .HasMaxLength(450)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpgScheduleFiles>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("epg_schedule_files");

                entity.HasIndex(e => e.ServiceReference)
                    .HasName("IX_OPT_epg_schedule_files_service_reference");

                entity.HasIndex(e => new { e.FileId, e.EpgDate })
                    .HasName("IX_OPT_epg_schedule_files_epg_date_file_id");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.EpgDate)
                    .HasColumnName("epg_date")
                    .HasColumnType("date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .IsUnicode(false);

                entity.Property(e => e.ImportDate)
                    .HasColumnName("import_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.IsCurrentVersion).HasColumnName("isCurrentVersion");

                entity.Property(e => e.ServiceReference).HasColumnName("service_reference");

                entity.HasOne(d => d.ServiceReferenceNavigation)
                    .WithMany(p => p.EpgScheduleFiles)
                    .HasForeignKey(d => d.ServiceReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_schedule_files_services");
            });

            modelBuilder.Entity<EpgSettings>(entity =>
            {
                entity.ToTable("epg_settings");

                entity.HasIndex(e => new { e.Id, e.ShowId, e.RatingId, e.IsCatchup, e.GenreId, e.EventId })
                    .HasName("IX_OPT_epg_settings_event_id_id_showId_ratingId_isCatchup_genreId_languageId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Blackout).HasColumnName("blackout");

                entity.Property(e => e.CaTemplateId).HasColumnName("caTemplateId");

                entity.Property(e => e.Downloadable).HasColumnName("downloadable");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.GenreId).HasColumnName("genreId");

                entity.Property(e => e.IsCatchup).HasColumnName("isCatchup");

                entity.Property(e => e.IsCloudDvr).HasColumnName("isCloudDvr");

                entity.Property(e => e.PrimaryGenreId).HasColumnName("primaryGenreId");

                entity.Property(e => e.RatingId).HasColumnName("ratingId");

                entity.Property(e => e.RestartTvAllowed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowId).HasColumnName("showId");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgSettings)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_settings_epg_events");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.EpgSettingsGenre)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_settings_epg_genre");

                entity.HasOne(d => d.PrimaryGenre)
                    .WithMany(p => p.EpgSettingsPrimaryGenre)
                    .HasForeignKey(d => d.PrimaryGenreId)
                    .HasConstraintName("FK_epg_settings_epg_genre1");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.EpgSettings)
                    .HasForeignKey(d => d.RatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_settings_ratings");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.EpgSettings)
                    .HasForeignKey(d => d.ShowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_settings_show_types");
            });

            modelBuilder.Entity<EpgTags>(entity =>
            {
                entity.ToTable("epg_tags");

                entity.HasIndex(e => e.EventId)
                    .HasName("IX_OPT_epg_tags_event_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Episodeid).HasColumnName("episodeid");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .IsUnicode(false);

                entity.Property(e => e.MarketingMsg)
                    .HasColumnName("marketingMsg")
                    .IsUnicode(false);

                entity.Property(e => e.Missedcall)
                    .HasColumnName("missedcall")
                    .IsUnicode(false);

                entity.Property(e => e.OppvPurchaseCode)
                    .HasColumnName("oppvPurchaseCode")
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Programmeid)
                    .HasColumnName("programmeid")
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ShowcaseImageUrl)
                    .HasColumnName("showcaseImageUrl")
                    .IsUnicode(false);

                entity.Property(e => e.YearOfRelease).HasColumnName("yearOfRelease");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgTags)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_tags_epg_events");
            });

            modelBuilder.Entity<EpgXtiEventCrossref>(entity =>
            {
                entity.ToTable("epg_xti_event_crossref");

                entity.HasIndex(e => new { e.Id, e.EventId })
                    .HasName("IX_OPT_epg_xti_event_crossref_event_id_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ProgramKey)
                    .HasColumnName("programKey")
                    .IsUnicode(false);

                entity.Property(e => e.XtiEventId).HasColumnName("xti_eventId");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EpgXtiEventCrossref)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_epg_xti_event_crossref_epg_events");
            });

            modelBuilder.Entity<Html5AppBuildVersions>(entity =>
            {
                entity.HasKey(e => new { e.BuildId, e.MajorVersion, e.MinorVersion });

                entity.ToTable("html5_app_build_versions");

                entity.Property(e => e.BuildId)
                    .HasColumnName("build_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Html5AppBuildVersions)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_html5_app_build_versions_html5_apps");
            });

            modelBuilder.Entity<Html5Apps>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK_html5_apps_1");

                entity.ToTable("html5_apps");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasColumnName("application_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Html5FileDetails>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("html5_file_details");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("file_path")
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("file_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.HasOne(d => d.Html5AppBuildVersions)
                    .WithMany(p => p.Html5FileDetails)
                    .HasForeignKey(d => new { d.BuildId, d.MajorVersion, d.MinorVersion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_html5_file_details_html5_app_build_versions");
            });

            modelBuilder.Entity<Html5Files>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("html5_files");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileData).HasColumnName("file_data");

                entity.HasOne(d => d.File)
                    .WithOne(p => p.Html5Files)
                    .HasForeignKey<Html5Files>(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_html5_files_html5_file_details");
            });

            modelBuilder.Entity<Html5OnlineApps>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.ToTable("html5_online_apps");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasColumnName("application_name")
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("date");

                entity.Property(e => e.MajorVersion)
                    .HasColumnName("major_version")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");
            });

            modelBuilder.Entity<HtmlPaitVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("html_pait_version");

                entity.Property(e => e.PaitMajVersion).HasColumnName("pait_maj_version");

                entity.Property(e => e.PaitMinVersion).HasColumnName("pait_min_version");
            });

            modelBuilder.Entity<Iapp>(entity =>
            {
                entity.ToTable("iapp");

                entity.HasIndex(e => e.Itvid)
                    .HasName("UNQ__iapp__itvid")
                    .IsUnique();

                entity.Property(e => e.IappId).HasColumnName("iapp_id");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnName("app_name")
                    .IsUnicode(false);

                entity.Property(e => e.CycleTime).HasColumnName("cycle_time");

                entity.Property(e => e.Itvid)
                    .IsRequired()
                    .HasColumnName("itvid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatValue).HasColumnName("sat_value");
            });

            modelBuilder.Entity<IappBuildVersions>(entity =>
            {
                entity.HasKey(e => new { e.BuildId, e.MajorVersion, e.MinorVersion });

                entity.ToTable("Iapp_build_versions");

                entity.Property(e => e.BuildId)
                    .HasColumnName("build_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.IappBuildVersions)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Iapp_build_versions_html5_apps");
            });

            modelBuilder.Entity<IappFileDetails>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_iapp_file_details_1");

                entity.ToTable("iapp_file_details");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.CycleTime).HasColumnName("cycle_time");

                entity.Property(e => e.FileMasterId).HasColumnName("file_master_id");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("file_path")
                    .IsUnicode(false);

                entity.Property(e => e.FileSize).HasColumnName("file_size");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("file_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SatValue).HasColumnName("sat_value");

                entity.HasOne(d => d.FileMaster)
                    .WithMany(p => p.IappFileDetails)
                    .HasForeignKey(d => d.FileMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_iapp_file_details_iapp_file_master");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.IappFileDetails)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_iapp_file_details_users");

                entity.HasOne(d => d.IappBuildVersions)
                    .WithMany(p => p.IappFileDetails)
                    .HasForeignKey(d => new { d.BuildId, d.MajorVersion, d.MinorVersion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_iapp_file_details_Iapp_build_versions");
            });

            modelBuilder.Entity<IappFileMaster>(entity =>
            {
                entity.HasKey(e => e.MasterFileId);

                entity.ToTable("iapp_file_master");

                entity.Property(e => e.MasterFileId).HasColumnName("master_file_id");

                entity.Property(e => e.AppId).HasColumnName("app_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.App)
                    .WithMany(p => p.IappFileMaster)
                    .HasForeignKey(d => d.AppId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_iapp_file_master_iapp");
            });

            modelBuilder.Entity<IappFiles>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_iapp_files_1");

                entity.ToTable("iapp_files");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileData).HasColumnName("file_data");

                entity.HasOne(d => d.File)
                    .WithOne(p => p.IappFiles)
                    .HasForeignKey<IappFiles>(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_iapp_files_iapp_file_details");
            });

            modelBuilder.Entity<Ischedule>(entity =>
            {
                entity.HasKey(e => e.IschId);

                entity.ToTable("ischedule");

                entity.Property(e => e.IschId).HasColumnName("isch_id");

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.IappId).HasColumnName("iapp_id");

                entity.Property(e => e.IngestedDatetime)
                    .HasColumnName("ingested_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IngestionDatetime)
                    .HasColumnName("ingestion_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.Ischedule)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK_ischedule_users");

                entity.HasOne(d => d.Iapp)
                    .WithMany(p => p.Ischedule)
                    .HasForeignKey(d => d.IappId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ischedule_iapp");

                entity.HasOne(d => d.IappBuildVersions)
                    .WithMany(p => p.Ischedule)
                    .HasForeignKey(d => new { d.BuildId, d.MajorVersion, d.MinorVersion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ischedule_Iapp_build_versions");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("languages");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("language_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnName("language_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogoContentTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentName)
                    .IsRequired()
                    .HasColumnName("contentName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasColumnName("contentType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetadataContentTypes>(entity =>
            {
                entity.ToTable("Metadata_contentTypes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfficeLocations>(entity =>
            {
                entity.HasKey(e => e.OfficeId);

                entity.ToTable("office_locations");

                entity.Property(e => e.OfficeId).HasColumnName("office_id");

                entity.Property(e => e.OfficeLocation)
                    .IsRequired()
                    .HasColumnName("office_location")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OttPlatforms>(entity =>
            {
                entity.HasKey(e => e.PlatformId);

                entity.ToTable("ott_platforms");

                entity.Property(e => e.PlatformId).HasColumnName("platform_id");

                entity.Property(e => e.PlatformName)
                    .IsRequired()
                    .HasColumnName("platform_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.RatingId);

                entity.ToTable("ratings");

                entity.Property(e => e.RatingId).HasColumnName("ratingId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<SeriesProgramCrossref>(entity =>
            {
                entity.ToTable("series_program_crossref");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.SeriesId).HasColumnName("series_id");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.SeriesProgramCrossref)
                    .HasForeignKey(d => d.SeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_program");
            });

            modelBuilder.Entity<ServiceAddtionalDetails>(entity =>
            {
                entity.ToTable("service_addtional_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalBy).HasColumnName("approval_by");

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.IngestionTime)
                    .HasColumnName("ingestion_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .IsUnicode(false);

                entity.Property(e => e.ModificationTime)
                    .HasColumnName("modification_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ShowId).HasColumnName("show_id");

                entity.HasOne(d => d.ApprovalByNavigation)
                    .WithMany(p => p.ServiceAddtionalDetailsApprovalByNavigation)
                    .HasForeignKey(d => d.ApprovalBy)
                    .HasConstraintName("FK_service_addtional_details_users2");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ServiceAddtionalDetails)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_addtional_details_countries");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ServiceAddtionalDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_service_addtional_details_users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ServiceAddtionalDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_service_addtional_details_users1");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceAddtionalDetails)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_addtional_details_services");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.ServiceAddtionalDetails)
                    .HasForeignKey(d => d.ShowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_addtional_details_epg_sub_genre");
            });

            modelBuilder.Entity<ServiceConfigurations>(entity =>
            {
                entity.ToTable("service_configurations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AvailablePlatformCloudDvr).HasColumnName("availablePlatformCloudDvr");

                entity.Property(e => e.BroadcasterFtadashUrl)
                    .HasColumnName("broadcasterFTADashUrl")
                    .IsUnicode(false);

                entity.Property(e => e.BroadcasterFtahlsUrl)
                    .HasColumnName("broadcasterFTAHlsUrl")
                    .IsUnicode(false);

                entity.Property(e => e.CloudDvrCdnPrefix)
                    .HasColumnName("cloudDvrCdnPrefix")
                    .IsUnicode(false);

                entity.Property(e => e.CloudDvrDrmRequired).HasColumnName("cloudDvrDrmRequired");

                entity.Property(e => e.CloudDvrRetentionDuration)
                    .HasColumnName("cloudDvrRetentionDuration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationDateTime)
                    .HasColumnName("creationDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeltaIpId).HasColumnName("DeltaIP_id");

                entity.Property(e => e.DurationToKeep).HasColumnName("durationToKeep");

                entity.Property(e => e.EndDateTime)
                    .HasColumnName("endDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(year,(3),getdate()))");

                entity.Property(e => e.HlsIndexDuration).HasColumnName("hlsIndexDuration");

                entity.Property(e => e.IsCableTvChannel).HasColumnName("isCableTvChannel");

                entity.Property(e => e.IsCatchUpChannel).HasColumnName("isCatchUpChannel");

                entity.Property(e => e.IsCloudDvr).HasColumnName("isCloudDvr");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.IsEncrypted).HasColumnName("isEncrypted");

                entity.Property(e => e.IsFreeChannel).HasColumnName("isFreeChannel");

                entity.Property(e => e.IsHdchannel).HasColumnName("isHDChannel");

                entity.Property(e => e.IsOttchannel).HasColumnName("isOTTChannel");

                entity.Property(e => e.IsRemoteRecordAllowed).HasColumnName("isRemoteRecordAllowed");

                entity.Property(e => e.MajVersion)
                    .HasColumnName("majVersion")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinVersion).HasColumnName("minVersion");

                entity.Property(e => e.NumberOfAudio).HasDefaultValueSql("((1))");

                entity.Property(e => e.PlatformId).HasColumnName("platform_id");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.StartDateTime)
                    .HasColumnName("startDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UdpmulticastIp)
                    .IsRequired()
                    .HasColumnName("UDPMulticastIP")
                    .IsUnicode(false);

                entity.Property(e => e.UniqueDvrRecordingCopy).HasColumnName("uniqueDvrRecordingCopy");

                entity.HasOne(d => d.AvailablePlatformCloudDvrNavigation)
                    .WithMany(p => p.ServiceConfigurationsAvailablePlatformCloudDvrNavigation)
                    .HasForeignKey(d => d.AvailablePlatformCloudDvr)
                    .HasConstraintName("FK_service_configurations_ott_platforms1");

                entity.HasOne(d => d.DeltaIp)
                    .WithMany(p => p.ServiceConfigurations)
                    .HasForeignKey(d => d.DeltaIpId)
                    .HasConstraintName("FK_service_configurations_ElementalDeltaIPs");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.ServiceConfigurationsPlatform)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_service_configurations_ott_platforms");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceConfigurations)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_configurations_services");
            });

            modelBuilder.Entity<ServiceDescriptions>(entity =>
            {
                entity.ToTable("service_descriptions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.SummaryLong).IsUnicode(false);

                entity.Property(e => e.SummaryMedium).IsUnicode(false);

                entity.Property(e => e.SummaryShort).IsUnicode(false);

                entity.Property(e => e.TitleBrief).IsUnicode(false);

                entity.Property(e => e.TitleLong).IsUnicode(false);

                entity.Property(e => e.TitleMedium).IsUnicode(false);

                entity.Property(e => e.TitleSortName).IsUnicode(false);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ServiceDescriptions)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_descriptions_languages");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceDescriptions)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_descriptions_services");
            });

            modelBuilder.Entity<ServiceDisplayedSubscriptionPackages>(entity =>
            {
                entity.ToTable("service_displayedSubscriptionPackages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DisplayedSubscriptionPackage)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceDisplayedSubscriptionPackages)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_displayedSubscriptionPackages_services");
            });

            modelBuilder.Entity<ServiceEncryptionProfiles>(entity =>
            {
                entity.ToTable("service_encryption_profiles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EncodeProfileName).IsUnicode(false);

                entity.Property(e => e.EncodeProfileUri).IsUnicode(false);

                entity.Property(e => e.ProfileId).HasColumnName("profile_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ServiceEncryptionProfiles)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_encryption_profiles_device_encryption_profiles");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceEncryptionProfiles)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_encryption_profiles_services");
            });

            modelBuilder.Entity<ServiceEpgConfigurations>(entity =>
            {
                entity.ToTable("service_epg_configurations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Catchup).HasColumnName("catchup");

                entity.Property(e => e.Downloadable).HasColumnName("downloadable");

                entity.Property(e => e.Downloadexpiryperiod).HasColumnName("downloadexpiryperiod");

                entity.Property(e => e.DvbTriplet).IsUnicode(false);

                entity.Property(e => e.EpgCode)
                    .IsRequired()
                    .HasColumnName("epg_code")
                    .IsUnicode(false);

                entity.Property(e => e.Expiryperiod).HasColumnName("expiryperiod");

                entity.Property(e => e.IsShowcaseService).HasColumnName("isShowcaseService");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.Stbenabled).HasColumnName("stbenabled");

                entity.Property(e => e.VoiceKeywords)
                    .HasColumnName("voice_keywords")
                    .IsUnicode(false);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceEpgConfigurations)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_epg_configurations_services");
            });

            modelBuilder.Entity<ServiceGenres>(entity =>
            {
                entity.ToTable("service_genres");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.ServiceGenres)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_genres_epg_genre");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceGenres)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_genres_services");
            });

            modelBuilder.Entity<ServiceLanguages>(entity =>
            {
                entity.ToTable("service_languages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ServiceLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_languages_languages");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceLanguages)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_languages_services");
            });

            modelBuilder.Entity<ServiceLogos>(entity =>
            {
                entity.HasKey(e => e.BoxcoverId);

                entity.ToTable("service_logos");

                entity.Property(e => e.BoxcoverId).HasColumnName("boxcover_id");

                entity.Property(e => e.ContentCheckSum)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ContentId).HasColumnName("contentId");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.XResolution)
                    .HasColumnName("x_resolution")
                    .HasDefaultValueSql("((288))");

                entity.Property(e => e.YResolution)
                    .HasColumnName("y_resolution")
                    .HasDefaultValueSql("((216))");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ServiceLogos)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_logos_LogoContentTypes");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceLogos)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_logos_services");
            });

            modelBuilder.Entity<ServiceSubscriptionPackages>(entity =>
            {
                entity.ToTable("service_subscription_packages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDisplayed).HasColumnName("isDisplayed");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceSubscriptionPackages)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_subscription_packages_services");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.ServiceSubscriptionPackages)
                    .HasForeignKey(d => d.SubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_service_subscription_packages_subscription_packages");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("services");

                entity.HasIndex(e => e.LinearServiceId)
                    .HasName("UNQ__services__linear_service_id")
                    .IsUnique();

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.CatchupServiceId).HasColumnName("catchup_service_id");

                entity.Property(e => e.LcnNumber).HasColumnName("LCN_number");

                entity.Property(e => e.LinearServiceId).HasColumnName("linear_service_id");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasColumnName("service_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShowTypes>(entity =>
            {
                entity.HasKey(e => e.ShowId);

                entity.ToTable("show_types");

                entity.Property(e => e.ShowId).HasColumnName("show_id");

                entity.Property(e => e.ShowType)
                    .IsRequired()
                    .HasColumnName("show_type")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmilProfiles>(entity =>
            {
                entity.ToTable("smil_profiles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Profile)
                    .IsRequired()
                    .HasColumnName("profile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubPolicyContentCrossref>(entity =>
            {
                entity.ToTable("sub_policy_content_crossref");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContentId).HasColumnName("contentId");

                entity.Property(e => e.PolicyId).HasColumnName("policyId");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.SubPolicyContentCrossref)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sub_policy_content_crossref_Metadata_contentTypes");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.SubPolicyContentCrossref)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_sub_policy_content_crossref_subscription_policies");
            });

            modelBuilder.Entity<SubscriptionDescriptions>(entity =>
            {
                entity.ToTable("subscription_descriptions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.Property(e => e.SummaryLong).IsUnicode(false);

                entity.Property(e => e.SummaryMedium).IsUnicode(false);

                entity.Property(e => e.SummaryShort).IsUnicode(false);

                entity.Property(e => e.TitleBrief).IsUnicode(false);

                entity.Property(e => e.TitleLong).IsUnicode(false);

                entity.Property(e => e.TitleMedium).IsUnicode(false);

                entity.Property(e => e.TitleSortName).IsUnicode(false);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SubscriptionDescriptions)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subscription_descriptions_languages");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.SubscriptionDescriptions)
                    .HasForeignKey(d => d.SubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subscription_descriptions_subscription_packages");
            });

            modelBuilder.Entity<SubscriptionDetails>(entity =>
            {
                entity.ToTable("subscription_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovalBy).HasColumnName("approval_by");

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.IngestionTime)
                    .HasColumnName("ingestion_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .IsUnicode(false);

                entity.Property(e => e.ModificationTime)
                    .HasColumnName("modification_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowId).HasColumnName("show_id");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.HasOne(d => d.ApprovalByNavigation)
                    .WithMany(p => p.SubscriptionDetailsApprovalByNavigation)
                    .HasForeignKey(d => d.ApprovalBy)
                    .HasConstraintName("FK_subscription_details_users2");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SubscriptionDetails)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_subscription_details_countries");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SubscriptionDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_subscription_details_users");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SubscriptionDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_subscription_details_users1");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.SubscriptionDetails)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK_subscription_details_show_types");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.SubscriptionDetails)
                    .HasForeignKey(d => d.SubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subscription_details_subscription_packages");
            });

            modelBuilder.Entity<SubscriptionLanguages>(entity =>
            {
                entity.ToTable("subscription_languages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SubscriptionLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subscription_languages_languages");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.SubscriptionLanguages)
                    .HasForeignKey(d => d.SubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subscription_languages_subscription_packages");
            });

            modelBuilder.Entity<SubscriptionOffers>(entity =>
            {
                entity.HasKey(e => e.OfferId);

                entity.ToTable("subscription_offers");

                entity.Property(e => e.OfferId).HasColumnName("offer_id");

                entity.Property(e => e.BillingId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDateTime)
                    .HasColumnName("creationDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDateTime)
                    .HasColumnName("endDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorVersion)
                    .HasColumnName("major_version")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.ProviderContentTier)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime)
                    .HasColumnName("startDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.SubscriptionOffers)
                    .HasForeignKey(d => d.SubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subscription_offers_subscription_packages");
            });

            modelBuilder.Entity<SubscriptionPackages>(entity =>
            {
                entity.HasKey(e => e.SubId);

                entity.ToTable("subscription_packages");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.SmspackageId).HasColumnName("SMSPackageId");
            });

            modelBuilder.Entity<SubscriptionPolicies>(entity =>
            {
                entity.ToTable("subscription_policies");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContractName)
                    .IsRequired()
                    .HasColumnName("contractName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.IsEncrypted)
                    .IsRequired()
                    .HasColumnName("isEncrypted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsFree).HasColumnName("isFree");

                entity.Property(e => e.PolicyId).HasColumnName("policyId");

                entity.Property(e => e.PolicyType)
                    .IsRequired()
                    .HasColumnName("policyType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubsriptionTerms>(entity =>
            {
                entity.HasKey(e => e.TermId);

                entity.ToTable("subsription_terms");

                entity.Property(e => e.TermId).HasColumnName("term_id");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");

                entity.Property(e => e.SubId).HasColumnName("sub_id");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.SubsriptionTerms)
                    .HasForeignKey(d => d.PolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subsription_terms_subscription_policies");

                entity.HasOne(d => d.Sub)
                    .WithMany(p => p.SubsriptionTerms)
                    .HasForeignKey(d => d.SubId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subsription_terms_subscription_packages");
            });

            modelBuilder.Entity<UserRoleMapping>(entity =>
            {
                entity.ToTable("user_role_mapping");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Moduleid).HasColumnName("moduleid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.UserRoleMapping)
                    .HasForeignKey(d => d.Moduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_role_mapping_backstage_modules");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleMapping)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_role_mapping_users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address")
                    .IsUnicode(false);

                entity.Property(e => e.IsAdmin).HasColumnName("is_admin");

                entity.Property(e => e.IsApproved).HasColumnName("is_approved");

                entity.Property(e => e.IsLocked).HasColumnName("is_locked");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.OfficeLocationId).HasColumnName("office_location_id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_users_departments");

                entity.HasOne(d => d.OfficeLocation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.OfficeLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_users_office_locations");
            });

            modelBuilder.Entity<VwAppFileDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_app_file_details");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.CycleTime).HasColumnName("cycle_time");

                entity.Property(e => e.FileData).HasColumnName("file_data");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("file_path")
                    .IsUnicode(false);

                entity.Property(e => e.FileSize).HasColumnName("file_size");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("file_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IappId).HasColumnName("iapp_id");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.Itvid)
                    .IsRequired()
                    .HasColumnName("itvid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.SatValue).HasColumnName("sat_value");
            });

            modelBuilder.Entity<VwApplicationBuilds>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_application_builds");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.IappId).HasColumnName("iapp_id");
            });

            modelBuilder.Entity<VwApplicationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_application_details");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnName("app_name")
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.ApprovedBy).HasColumnName("approved_by");

                entity.Property(e => e.BuildId).HasColumnName("build_id");

                entity.Property(e => e.CycleTime).HasColumnName("cycle_time");

                entity.Property(e => e.IappId).HasColumnName("iapp_id");

                entity.Property(e => e.IngestedDatetime)
                    .HasColumnName("ingested_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IngestionDatetime)
                    .HasColumnName("ingestion_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.Itvid)
                    .IsRequired()
                    .HasColumnName("itvid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.SatValue).HasColumnName("sat_value");
            });

            modelBuilder.Entity<VwAssetCasting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_asset_casting");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.CastId).HasColumnName("cast_id");

                entity.Property(e => e.CastOrder).HasColumnName("cast_order");

                entity.Property(e => e.CastType)
                    .IsRequired()
                    .HasColumnName("cast_type")
                    .IsUnicode(false);

                entity.Property(e => e.CastTypeId).HasColumnName("cast_type_id");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDistributionList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_distribution_list");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnName("app_name")
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalStatus).HasColumnName("approval_status");

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.Itvid)
                    .IsRequired()
                    .HasColumnName("itvid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");
            });

            modelBuilder.Entity<VwEpgEntitlements>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_epg_entitlements");

                entity.Property(e => e.CaId).HasColumnName("ca_id");

                entity.Property(e => e.CaSubId).HasColumnName("ca_sub_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEpgEventInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_epg_event_info");

                entity.Property(e => e.Actor)
                    .HasColumnName("actor")
                    .IsUnicode(false);

                entity.Property(e => e.Blackout).HasColumnName("blackout");

                entity.Property(e => e.CaTemplateId).HasColumnName("caTemplateId");

                entity.Property(e => e.CastId).HasColumnName("castId");

                entity.Property(e => e.Director)
                    .HasColumnName("director")
                    .IsUnicode(false);

                entity.Property(e => e.Downloadable).HasColumnName("downloadable");

                entity.Property(e => e.EndTime)
                    .HasColumnName("endTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Episodeid).HasColumnName("episodeid");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FileId).HasColumnName("fileId");

                entity.Property(e => e.GenreId).HasColumnName("genreId");

                entity.Property(e => e.GenreId1).HasColumnName("genre_id");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genre_name")
                    .IsUnicode(false);

                entity.Property(e => e.IconId).HasColumnName("iconId");

                entity.Property(e => e.IngestUrl)
                    .IsRequired()
                    .HasColumnName("ingest_url")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.IsCatchup).HasColumnName("isCatchup");

                entity.Property(e => e.IsCloudDvr).HasColumnName("isCloudDvr");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .IsUnicode(false);

                entity.Property(e => e.MarketingMsg)
                    .HasColumnName("marketingMsg")
                    .IsUnicode(false);

                entity.Property(e => e.Missedcall)
                    .HasColumnName("missedcall")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OppvPurchaseCode)
                    .HasColumnName("oppvPurchaseCode")
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PrimaryGenreId).HasColumnName("primaryGenreId");

                entity.Property(e => e.Producer)
                    .HasColumnName("producer")
                    .IsUnicode(false);

                entity.Property(e => e.Programmeid)
                    .HasColumnName("programmeid")
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RatingId).HasColumnName("ratingId");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.SettingId).HasColumnName("settingId");

                entity.Property(e => e.ShowId).HasColumnName("showId");

                entity.Property(e => e.ShowId1).HasColumnName("show_id");

                entity.Property(e => e.ShowType)
                    .IsRequired()
                    .HasColumnName("show_type")
                    .IsUnicode(false);

                entity.Property(e => e.ShowcaseImageUrl)
                    .HasColumnName("showcaseImageUrl")
                    .IsUnicode(false);

                entity.Property(e => e.SlotId)
                    .IsRequired()
                    .HasColumnName("slotId")
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasColumnName("startTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TagId).HasColumnName("tagId");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.YearOfRelease).HasColumnName("yearOfRelease");
            });

            modelBuilder.Entity<VwEpgLanguages>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_epg_languages");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasColumnName("language_name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwHApps2ingest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_H_apps2ingest");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasColumnName("application_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");
            });

            modelBuilder.Entity<VwHtml5Applicationfiledetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Html5Applicationfiledetails");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasColumnName("application_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasColumnName("file_path")
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("file_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IngestionStatus).HasColumnName("ingestion_status");

                entity.Property(e => e.IsAppIngested).HasColumnName("isAppIngested");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorVersion).HasColumnName("major_version");

                entity.Property(e => e.MinorVersion).HasColumnName("minor_version");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
