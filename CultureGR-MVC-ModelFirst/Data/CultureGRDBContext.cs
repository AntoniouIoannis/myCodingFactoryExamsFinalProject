using CultureGR_MVC_ModelFirst.Core;
using Microsoft.EntityFrameworkCore;

namespace CultureGR_MVC_ModelFirst.Data
{
    public class CultureGRDBContext : DbContext
    {
        public CultureGRDBContext() { }

        public CultureGRDBContext(DbContextOptions<CultureGRDBContext> options) : base(options) { }

        // Collections 
        public DbSet<User> Users { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<HistorianArchPlaces> historianArchPlaces { get; set; }
        public DbSet<HistorianMonuments> historianMonuments { get; set; }
        public DbSet<HistorianMuseums> historianMuseums { get; set; }
        public DbSet<WriterArchPlaces> writerArchPlaces { get; set; }
        public DbSet<WriterMonuments> writerMonuments { get; set; }
        public DbSet<WriterMuseums> writerMuseums { get; set; }
        public DbSet<Record> records { get; set; }
        public DbSet<Museum> Museums { get; set; }
        public DbSet<Monument> Monuments { get; set; }
        public DbSet<Excavation> Excavations { get; set; }
        public DbSet<ArchaeologicalSite> ArchaeologicalSites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //mapping
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>        // mapping for user starting here
            {
                // εδω δημιουργείται ο πίνακας Users στο embedded server Kestrel!
                entity.ToTable("Users");
                entity.HasKey(e => e.Id);   // Optional if convention holds
                entity.Property(e => e.Identity).HasMaxLength(255);
                entity.Property(e => e.Username).HasMaxLength(255);   // default length is MAX
                entity.Property(e => e.Email).HasMaxLength(255);
                entity.Property(e => e.Password).HasMaxLength(60);
                entity.Property(e => e.RePassword).HasMaxLength(60);
                entity.Property(e => e.Firstname).HasMaxLength(255);
                entity.Property(e => e.Lastname).HasMaxLength(255);
                entity.Property(e => e.UserRole).HasMaxLength(255).HasConversion<string>();

                // Timestamps for Inser & Modified!
                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                // Indexes on the table Users
                entity.HasIndex(e => e.Username, "IX_Users_Username").IsUnique();
                entity.HasIndex(e => e.Email, "IX_Users_Email").IsUnique();
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                // mapping for Subscribers starting here
                entity.ToTable("Subscribers");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).HasMaxLength(255);
                entity.Property(e => e.Email).HasMaxLength(255);
                entity.Property(e => e.Password).HasMaxLength(255);
                entity.Property(e => e.RePassword).HasMaxLength(255);
                entity.Property(e => e.Firstname).HasMaxLength(255);
                entity.Property(e => e.Lastname).HasMaxLength(255);
                entity.Property(e => e.Banned);     //bollean type

                entity.Property(e => e.UserRole).HasMaxLength(255);

                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.Username, "IX_Subscribers_Username");
                entity.HasIndex(e => e.Banned, "IX_Subscribers_Banned");    // if true = Banned, if not true = Not Banned
                entity.HasIndex(e => e.Firstname, "IX_Subscribers_Firstname").IsUnique();
                entity.HasIndex(e => e.Lastname, "IX_Subscribers_Lastname").IsUnique();
                entity.HasIndex(e => e.UserId, "IX_Subscribers_UserId").IsUnique();
            });

            modelBuilder.Entity<WriterArchPlaces>(entity =>
            {
                // mapping for WriterArchPlaces starting here
                entity.ToTable("WriterArchPlaces");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.EditorialTeam).HasMaxLength(255);
                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(255);

                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.EditorialTeam, "IX_WriterArchPlaces_EditorialTeam");
                entity.HasIndex(e => e.WorkPhoneNumber, "IX_WriterArchPlaces_WorkPhoneNumber").IsUnique();
                entity.HasIndex(e => e.UserId, "IX_WriterArchPlaces_UserId").IsUnique();
            });

            modelBuilder.Entity<WriterMonuments>(entity =>
            {
                // mapping for WriterMonuments starting here
                entity.ToTable("WriterMonuments");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.EditorialTeam).HasMaxLength(255);
                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(255);

                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.EditorialTeam, "IX_WriterMonuments_EditorialTeam");
                entity.HasIndex(e => e.WorkPhoneNumber, "IX_WriterMonuments_WorkPhoneNumber").IsUnique();
                entity.HasIndex(e => e.UserId, "IX_WriterMonuments_UserId").IsUnique();
            });

            modelBuilder.Entity<WriterMuseums>(entity =>
            {
                // mapping for WriterMuseums starting here
                entity.ToTable("WriterMuseums");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.EditorialTeam).HasMaxLength(255);
                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(255);

                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.EditorialTeam, "IX_WriterMuseums_EditorialTeam");
                entity.HasIndex(e => e.WorkPhoneNumber, "IX_WriterMuseums_WorkPhoneNumber").IsUnique();
                entity.HasIndex(e => e.UserId, "IX_WriterMuseums_UserId").IsUnique();
            });

            modelBuilder.Entity<HistorianArchPlaces>(entity =>
            {
                // mapping for HistorianArchPlaces starting here
                entity.ToTable("HistorianArchPlaces");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.EditorialTeam).HasMaxLength(255);
                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(255);

                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.EditorialTeam, "IX_HistorianArchPlaces_EditorialTeam");
                entity.HasIndex(e => e.Username, "IX_HistorianArchPlaces_Username");
                entity.HasIndex(e => e.WorkPhoneNumber, "IX_HistorianArchPlaces_WorkPhoneNumber").IsUnique();
                entity.HasIndex(e => e.UserId, "IX_HistorianArchPlaces_UserId").IsUnique();
            });

            modelBuilder.Entity<HistorianMonuments>(entity =>
            {
                // mapping for HistorianMonuments starting here
                entity.ToTable("HistorianMonuments");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.EditorialTeam).HasMaxLength(255);
                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(255);

                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.EditorialTeam, "IX_HistorianMonuments_EditorialTeam");
                entity.HasIndex(e => e.Username, "IX_HistorianMonuments_Username");
                entity.HasIndex(e => e.WorkPhoneNumber, "IX_HistorianMonuments_WorkPhoneNumber").IsUnique();
                entity.HasIndex(e => e.UserId, "IX_HistorianMonuments_UserId").IsUnique();
            });

            modelBuilder.Entity<HistorianMuseums>(entity =>
            {
                // mapping for HistorianMuseums starting here
                entity.ToTable("HistorianMuseums");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.EditorialTeam).HasMaxLength(255);
                entity.Property(e => e.WorkPhoneNumber).HasMaxLength(255);

                entity.Property(e => e.InsertedAt).ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.ModifiedAt).ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()");

                entity.HasIndex(e => e.EditorialTeam, "IX_HistorianMuseums_EditorialTeam");
                entity.HasIndex(e => e.Username, "IX_HistorianMuseums_Username");
                entity.HasIndex(e => e.WorkPhoneNumber, "IX_HistorianMuseums_WorkPhoneNumber").IsUnique();
                entity.HasIndex(e => e.UserId, "IX_HistorianMuseums_UserId").IsUnique();
            });

            modelBuilder.Entity<Record>(entity =>
            {
                // mapping for Record starting here
                entity.ToTable("Records");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Descr).HasMaxLength(255);

                entity.HasIndex(e => e.Descr, "IX_Records_Description");
            });

            modelBuilder.Entity<Museum>(entity =>
            {
                entity.ToTable("Museums");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.mus_region).HasMaxLength(150);
                entity.Property(e => e.mus_name).HasMaxLength(150);
                entity.Property(e => e.mus_desc).HasColumnType("nvarchar(MAX)");
                entity.Property(e => e.mus_address).HasMaxLength(150);
                entity.Property(e => e.mus_coordinate).HasMaxLength(150);
                entity.Property(e => e.mus_phone).HasMaxLength(150);
                entity.Property(e => e.mus_open).HasMaxLength(150);
                entity.Property(e => e.mus_avg_rate).HasColumnType("decimal(3,2)");

                // Μετατροπή των Enums σε string
                entity.Property(e => e.CategoryMuseum)
                    .HasConversion<string>();

                entity.Property(e => e.Collections)
                    .HasConversion<string>();

                // Εισαγωγή δεδομένων
                entity.HasData(
                    new Museum
                    {
                        Id = 1,
                        mus_region = "Αθήνα",
                        mus_name = "Αρχαιολογικό Μουσείο Αθήνας",
                        mus_desc = "Ένα από τα παλαιότερα μουσεία στην Ελλάδα.",
                        mus_address = "Πατησίων 44, Αθήνα",
                        mus_phone = "210-8217724",
                        mus_open = "08:00 - 20:00",
                        CategoryMuseum = CategoryMuseum.Istoriko,
                        Collections = CollectionsGR.AngeiaPsifidotaErgaleia,
                        mus_avg_rate = 4.8
                    },
                    new Museum
                    {
                        Id = 2,
                        mus_region = "Θεσσαλονίκη",
                        mus_name = "Βυζαντινό Μουσείο Θεσσαλονίκης",
                        mus_desc = "Μουσείο με πλούσια συλλογή από τη βυζαντινή περίοδο.",
                        mus_address = "Λεωφόρος Στρατού 2, Θεσσαλονίκη",
                        mus_phone = "2310-868570",
                        mus_open = "09:00 - 17:00",
                        CategoryMuseum = CategoryMuseum.FisikisIstorias,
                        Collections = CollectionsGR.GlyptaAgalmataProtomesTafikaGlypta,
                        mus_avg_rate = 4.6
                    }
                );
            });

            modelBuilder.Entity<ArchaeologicalSite>(entity =>
                {
                    entity.ToTable("ArchaeologicalSites");
                    entity.HasKey(e => e.Id);
                    entity.Property(e => e.Region).HasMaxLength(150);
                    entity.Property(e => e.Name).HasMaxLength(150);
                    entity.Property(e => e.Description).HasColumnType("nvarchar(MAX)");
                    entity.Property(e => e.Location).HasMaxLength(150);

                    entity.HasData(
                    new ArchaeologicalSite
                    {
                        Id = 1,
                        Region = "Αττική",
                        Name = "Ακρόπολη Αθηνών",
                        Description = "Το σπουδαιότερο μνημείο της κλασικής αρχαιότητας, με τον Παρθενώνα ως κεντρικό στοιχείο.",
                        Location = "Αθήνα"

                    },
                    new ArchaeologicalSite
                    {
                        Id = 2,
                        Region = "Κρήτη",
                        Name = "Κνωσός",
                        Description = "Tο μεγαλύτερο μινωικό ανάκτορο, κέντρο του μινωικού πολιτισμού.",
                        Location = "Ηράκλειο, Κρήτη"
                    },
                    new ArchaeologicalSite
                    {
                        Id = 3,
                        Region = "Αργολίδα",
                        Name = "Επίδαυρος",
                        Description = "Αρχαιολογικό Μουσείο Αθήνας",
                        Location = "Επίδαυρος, Αργολίδα"
                    },
                    new ArchaeologicalSite
                    {
                        Id = 4,
                        Region = "Αργολίδα",
                        Name = "Τίρυνθα",
                        Description = "Ακρόπολη με Κυκλώπεια Τείχη, χαρακτηριστικό δείγμα μυκηναϊκής αρχιτεκτονικής.",
                        Location = "Αργολίδα"
                    }
                );

                });

            modelBuilder.Entity<Excavation>(entity =>
            {
                entity.ToTable("Excavations");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Region).HasMaxLength(150);
                entity.Property(e => e.Description).HasColumnType("nvarchar(MAX)");
            });

            modelBuilder.Entity<Monument>(entity =>
            {
                entity.ToTable("Monuments");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.monumentName).HasMaxLength(150);
                entity.Property(e => e.monumentDesc).HasColumnType("nvarchar(MAX)");
                entity.Property(e => e.monumentLocation).HasMaxLength(150);

                modelBuilder.Entity<Monument>().HasData(
                new Monument
                {
                    monumentLocation = "Αθήνα",
                    monumentName = "Μνημείο Αγνώστου Στρατιώτη",
                    monumentEra = "Σύγχρονη εποχή",
                    monumentDesc = "Κατασκευασμένο το 1932, το μνημείο τιμά τους Έλληνες στρατιώτες που έπεσαν στη μάχη. Βρίσκεται μπροστά από τη Βουλή."
                },
                    new Monument
                    {
                        monumentLocation = "Θερμοπύλες",
                        monumentName = "Άγαλμα Λεωνίδα",
                        monumentEra = "Κλασική εποχή",
                        monumentDesc = "Το μνημείο τιμά τον βασιλιά της Σπάρτης Λεωνίδα και τους 300 Σπαρτιάτες για τη θυσία τους το 480 π.Χ."
                    },
                    new Monument
                    {
                        monumentLocation = "Δίστομο",
                        monumentName = "Μνημείο Σφαγής Διστόμου",
                        monumentEra = "Σύγχρονη εποχή",
                        monumentDesc = "Αφιερωμένο στα θύματα της ναζιστικής σφαγής στις 10 Ιουνίου 1944."
                    },
                    new Monument
                    {
                        monumentLocation = "Μεσολόγγι",
                        monumentName = "Κήπος των Ηρώων Επανάστασης 1821",
                        monumentEra = "Σύγχρονη εποχή",
                        monumentDesc = "Περιλαμβάνει μνημεία προς τιμήν των πεσόντων της Εξόδου του Μεσολογγίου."
                    },
                    new Monument
                    {
                        monumentLocation = "Σούλι",
                        monumentName = "Μνημείο Γυναικών Σουλίου",
                        monumentEra = "Σύγχρονη εποχή, Επανάσταση 1821",
                        monumentDesc = "Τιμά τη θυσία των γυναικών του Σουλίου που έπεσαν στον ποταμό Αχέροντα το 1803."
                    }
                );

            });

        }
    }
}
//modelBuilder.Entity<TimePeriod>().Property(
//    new TimePeriod { per_id = 1, per_name = "Παλαιολιθική Περίοδος", per_time_start = "2.5 εκ. χρόνια π.Χ.", per_time_end = "10,000 π.Χ.", per_desc = "Η παλαιότερη φάση της προϊστορίας, όταν οι άνθρωποι ζούσαν ως κυνηγοί-τροφοσυλλέκτες." },
//    new TimePeriod { per_id = 2, per_name = "Μεσολιθική Περίοδος", per_time_start = "10,000 π.Χ.", per_time_end = "8,000 π.Χ.", per_desc = "Μεταβατική περίοδος όπου αναπτύχθηκαν πρωτόγονα εργαλεία και τεχνικές καλλιέργειας." },
//    new TimePeriod { per_id = 3, per_name = "Νεολιθική Περίοδος", per_time_start = "8,000 π.Χ.", per_time_end = "3,200 π.Χ.", per_desc = "Περίοδος σημαντικής εξέλιξης με την καθιέρωση της γεωργίας και των μόνιμων οικισμών." },
//    new TimePeriod { per_id = 4, per_name = "Εποχή του Χαλκού", per_time_start = "3,200 π.Χ.", per_time_end = "1,200 π.Χ.", per_desc = "Περίοδος που χαρακτηρίζεται από την ευρεία χρήση του χαλκού για εργαλεία και όπλα." },
//    new TimePeriod { per_id = 5, per_name = "Εποχή του Σιδήρου", per_time_start = "1,200 π.Χ.", per_time_end = "800 π.Χ.", per_desc = "Η εποχή όπου ο σίδηρος αντικατέστησε τον χαλκό ως κύριο υλικό για κατασκευή εργαλείων." },
//    new TimePeriod { per_id = 6, per_name = "Αρχαϊκή Περίοδος", per_time_start = "800 π.Χ.", per_time_end = "480 π.Χ.", per_desc = "Η περίοδος διαμόρφωσης των ελληνικών πόλεων-κρατών και της πρώτης γραπτής λογοτεχνίας." },
//    new TimePeriod { per_id = 7, per_name = "Κλασική Περίοδος", per_time_start = "480 π.Χ.", per_time_end = "323 π.Χ.", per_desc = "Η χρυσή εποχή της αρχαίας Ελλάδας, με μεγάλη ακμή στις τέχνες, τη φιλοσοφία και τη δημοκρατία." },
//    new TimePeriod { per_id = 8, per_name = "Ελληνιστική Περίοδος", per_time_start = "323 π.Χ.", per_time_end = "30 π.Χ.", per_desc = "Περίοδος εξάπλωσης του ελληνικού πολιτισμού υπό την κυριαρχία των επιγόνων του Μεγάλου Αλεξάνδρου." },
//    new TimePeriod { per_id = 9, per_name = "Ρωμαϊκή Περίοδος", per_time_start = "30 π.Χ.", per_time_end = "330 μ.Χ.", per_desc = "Περίοδος κατά την οποία η Ελλάδα βρέθηκε υπό ρωμαϊκή κυριαρχία." },
//    new TimePeriod { per_id = 10, per_name = "Βυζαντινή Περίοδος", per_time_start = "330 μ.Χ.", per_time_end = "1453 μ.Χ.", per_desc = "Η περίοδος του Ανατολικού Ρωμαϊκού Κράτους με έδρα την Κωνσταντινούπολη." },
//    new TimePeriod { per_id = 11, per_name = "Οθωμανική Περίοδος", per_time_start = "1453 μ.Χ.", per_time_end = "1821 μ.Χ.", per_desc = "Περίοδος κατά την οποία η Ελλάδα ήταν μέρος της Οθωμανικής Αυτοκρατορίας." });



//modelBuilder.Entity<ArchaeologicalSite>().Property(
//    new ArchaeologicalSite { Id = 1, Region = "Ιστορικό Μουσείο", Description = "a", Location = "v" },
//    new ArchaeologicalSite { Id = 2, Region = "Λαογραφικό Μουσείο", Description = "a", Location = "v" },
//    new DbLoggerCategory { Id = 3, cat_name = "Μουσείο Τέχνης" },
//    new CategoryMuseum { Id = 4, cat_name = "Μουσείο Φυσικής Ιστορίας" },
//    new CategoryMuseum { Id = 5, cat_name = "Μουσείο Τεχνολογίας" },
//    new CategoryMuseum { Id = 6, cat_name = "Πολεμικό Μουσείο" },
//    new CategoryMuseum { Id = 7, cat_name = "Μουσείο Επιστημών" },
//    new CategoryMuseum { Id = 8, cat_name = "Νομισματικό Μουσείο" },
//    new CategoryMuseum { Id = 9, cat_name = "Εθνολογικό Μουσείο" }
//    )
