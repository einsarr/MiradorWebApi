using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiradorWebAPI.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "ATLAS_SYS_DEF_ALL",
            //    columns: table => new
            //    {
            //        code00 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        code06 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        IA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        code05 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        Département = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        code04 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        IDEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        code03 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        Commune = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        code02 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        Arrondissement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        code01 = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        Communautérurale = table.Column<string>(name: "Communauté rurale", type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ATLAS_SYS_DEF_ALL", x => x.code00);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ENSEIGNANT",
            //    columns: table => new
            //    {
            //        IDENTIFIANT_ENSEIGNANT = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CODE_CORPS = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_DIPLOME = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_DIPLOME_PROFESSIONNEL = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_NATIONALITE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_LANGUE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_EMPLOYEUR = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_GRADE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_ETABLISSEMENT = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        CODE_MATIERE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        MATRICULE_ENSEIGNANT = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
            //        NOM_ENSEIGNANT = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
            //        PRENOMS_ENSEIGNANT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SEXE_ENSEIGNANT = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
            //        DATE_NAISS_ENSEIGNANT = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        DATE_ENTREE_ETABLISSEMENT_ENSE = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        DATE_ENTREE_FONCTION_PUBLIQUE_ = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        DATE_ENTREE_ENSEIGNEMENT_ENSEI = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        VOLUME_HORAIRE_DU = table.Column<int>(type: "int", nullable: true),
            //        CODE_FONCTION = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_SPECIALITE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        NB_HEURES_ASSURES = table.Column<short>(type: "smallint", nullable: true),
            //        CODE_STATUT_PERSONNEL = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        NB_JOUR_FORMATION = table.Column<short>(type: "smallint", nullable: true),
            //        CODE_TYPE_POSTE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true, defaultValueSql: "((-99))"),
            //        OK = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(0)"),
            //        CODE_MOUVEMENT = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        IDENTIFIANT_ENSEIGNANT_POINTAGE = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        IDENTIFIANT_ENSEIGNANT_FUP = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        OLD_MATRICULE = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
            //        DATE_CORPS = table.Column<DateTime>(type: "datetime", nullable: true),
            //        SITUATION_MATRIMONIALE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        NBRE_ENFANTS = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        FUP_CODE_CORPS06 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        FUP_CODE_GRADE06 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CREE_PAR = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
            //        DATE_CREATION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
            //        MODIFIE_PAR = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
            //        DATE_DERNIERE_MODIFICATION = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CODE_MOUVEMENT_2006 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        FUP_CODE_CORPS07 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        FUP_CODE_GRADE07 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_MOUVEMENT_2007_1erMvmt = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        CODE_MOUVEMENT_2007_2emeMvmt = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        FUP_CODE_CORPS08 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        FUP_CODE_GRADE08 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_MOUVEMENT_2008_1emeMvmt = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        CODE_MOUVEMENT_2008_2emeMvmt = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        IDENTIFIANT_ENSEIGNANT_AXE = table.Column<int>(type: "int", nullable: true),
            //        CODE_CLASSE_TENUE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CNI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CODE_MOUVEMENT_2009_1erMvmt = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        CODE_MOUVEMENT_2010 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        CODE_MOUVEMENT_2011 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        CODE_MOUVEMENT_2012 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        DECLARATION_PSV = table.Column<bool>(type: "bit", nullable: true),
            //        COMMENTAIRE_ENSEIGNANT = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        LIEU_NAISSANCE_ENSEIGNANT = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        MAIL_ENSEIGNANT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        MAIL_ENSEIGNANT2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        MOBILE_ENSEIGNANT = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        MOBILE_ENSEIGNANT2 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        PASSWORD_ENSEIGNANT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        PASSWORD_VALIDE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
            //        STATUS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
            //        CODE_MOUVEMENT_2014 = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        DATE_INSCRIPTION_MIRADOR = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CODE_TYPE_UTILISATION = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "('000')"),
            //        DATE_OBTENTION_DIPLOME_ACA = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DATE_OBTENTION_DIPLOME_PRO = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CODE_POSITION = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
            //        ADRESSE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        IEN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        EMAIL_PRO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CODE_PI_LANGUE = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        EST_BILLINGUE = table.Column<bool>(type: "bit", nullable: true),
            //        MVT = table.Column<bool>(type: "bit", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ENSEIGNANT", x => x.IDENTIFIANT_ENSEIGNANT);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ETABLISSEMENT",
            //    columns: table => new
            //    {
            //        CODE_ETABLISSEMENT = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        CODE_TYPE_ETABLISSEMENT = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_STATUT = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_SYSTEME = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_TYPE_SOCIOLOGIQUE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_STATUT_PRIVE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        NOM_ETABLISSEMENT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ADRESSE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        BOITE_POSTALE = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        TELEPHONE = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
            //        TELECOPIE = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
            //        MEL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        DATE_CREATION = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        CODE_ADMINISTRATIF = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        DATE_RECONNAISSANCE = table.Column<DateTime>(type: "smalldatetime", nullable: true),
            //        REFERENCE_AUTORISATION = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        NOM_CHEF_ETABLISSEMENT = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
            //        CODE_TYPE_STRUCTURE_ADM = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        ECOLE_APPLICATION = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true, defaultValueSql: "(N'Non')"),
            //        NB_CLASSE = table.Column<int>(type: "int", nullable: true),
            //        CODE_ADMINISTRATIF_old = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
            //        ETAB_VERROUILLE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('N')"),
            //        ETAB_PRIORITE_FEMME = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
            //        OLD_CODE_ADMINISTRATIF = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        OLD_NOM_ETABLISSEMENT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CODE_PI = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        CODE_PI_LANGUE = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
            //        EST_PRIORITE_BILLINGUE = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ETABLISSEMENT", x => x.CODE_ETABLISSEMENT);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "ENSEIGNANT_ETABLISSEMENT",
            //    columns: table => new
            //    {
            //        IDENTIFIANT_ENSEIGNANT = table.Column<int>(type: "int", nullable: false),
            //        CODE_ETABLISSEMENT = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        CODE_ANNEE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        CODE_SITUATION = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
            //        NUMERO_ORDRE_ENSEIGNANT = table.Column<int>(type: "int", nullable: true),
            //        Temp = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(0)"),
            //        CREE_PAR = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true, defaultValueSql: "(user_name())"),
            //        DATE_CREATION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
            //        MODIFIE_PAR = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
            //        DATE_DERNIERE_MODIFICATION = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ENSEIGNANT_ETABLISSEMENT", x => new { x.IDENTIFIANT_ENSEIGNANT, x.CODE_ETABLISSEMENT });
            //        table.ForeignKey(
            //            name: "FK_ENSEIGNANT_ETABLISSEMENT_ENSEIGNANT",
            //            column: x => x.IDENTIFIANT_ENSEIGNANT,
            //            principalTable: "ENSEIGNANT",
            //            principalColumn: "IDENTIFIANT_ENSEIGNANT");
            //        table.ForeignKey(
            //            name: "FK_ENSEIGNANT_ETABLISSEMENT_ETABLISSEMENT",
            //            column: x => x.CODE_ETABLISSEMENT,
            //            principalTable: "ETABLISSEMENT",
            //            principalColumn: "CODE_ETABLISSEMENT");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ETABLISSEMENT_REGROUPEMENT",
            //    columns: table => new
            //    {
            //        CODE_ETABLISSEMENT = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        CODE_REGROUPEMENT = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ETABLISSEMENT_REGROUPEMENT", x => new { x.CODE_ETABLISSEMENT, x.CODE_REGROUPEMENT });
            //        table.ForeignKey(
            //            name: "FK_ETABLISSEMENT_REGROUPEMENT_ETABLISSEMENT",
            //            column: x => x.CODE_ETABLISSEMENT,
            //            principalTable: "ETABLISSEMENT",
            //            principalColumn: "CODE_ETABLISSEMENT");
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "idx_nom_prenom",
        //        table: "ENSEIGNANT",
        //        columns: new[] { "NOM_ENSEIGNANT", "PRENOMS_ENSEIGNANT" });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CORPS",
        //        table: "ENSEIGNANT",
        //        column: "CODE_CORPS");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ENSEIGNANT",
        //        table: "ENSEIGNANT",
        //        column: "MATRICULE_ENSEIGNANT",
        //        unique: true);

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ENSEIGNANT_1",
        //        table: "ENSEIGNANT",
        //        column: "CODE_CORPS")
        //        .Annotation("SqlServer:FillFactor", 90);

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ENSEIGNANT_2",
        //        table: "ENSEIGNANT",
        //        column: "CODE_ETABLISSEMENT")
        //        .Annotation("SqlServer:FillFactor", 90);

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ENSEIGNANT_ETABLISSEMENT_CODE_ETABLISSEMENT",
        //        table: "ENSEIGNANT_ETABLISSEMENT",
        //        column: "CODE_ETABLISSEMENT");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ETABLISSEMENT",
        //        table: "ETABLISSEMENT",
        //        column: "NOM_ETABLISSEMENT")
        //        .Annotation("SqlServer:FillFactor", 90);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ATLAS_SYS_DEF_ALL");

            //migrationBuilder.DropTable(
            //    name: "ENSEIGNANT_ETABLISSEMENT");

            //migrationBuilder.DropTable(
            //    name: "ETABLISSEMENT_REGROUPEMENT");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ENSEIGNANT");

            migrationBuilder.DropTable(
                name: "ETABLISSEMENT");
        }
    }
}
