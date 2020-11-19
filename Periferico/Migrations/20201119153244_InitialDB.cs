using Microsoft.EntityFrameworkCore.Migrations;

namespace Periferico.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "E270ConAse",
                columns: table => new
                {
                    noContratante = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    txRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coInProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coCalservicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    beMaxInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSuTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAplicativoTx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEspecialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coParentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuAutOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiCaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E270ConAse", x => x.noContratante);
                });

            migrationBuilder.CreateTable(
                name: "E270ConAseAcc",
                columns: table => new
                {
                    noTransaccion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    txRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coInProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coCalservicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    beMaxInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSuTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAplicativoTx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEspecialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coParentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuAutOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiCaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    txDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E270ConAseAcc", x => x.noTransaccion);
                });

            migrationBuilder.CreateTable(
                name: "E271ConCod",
                columns: table => new
                {
                    idRemitente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feUpFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEsPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuIdenPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuContratoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPoliza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCertificado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiPoliza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiPlanSalud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coMoneda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coParentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soBeneficio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuSoBeneficio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esMarital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feIniVigencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinVigencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiCaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feInsTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConCod", x => x.idRemitente);
                });

            migrationBuilder.CreateTable(
                name: "E271ConDtad",
                columns: table => new
                {
                    idReceptor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deDirPaciente1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deDirPaciente2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coUbigeoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuTeContacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiCaCalificador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaNoEmCalificador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noEmCalificador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaCalificador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConDtad", x => x.idReceptor);
                });

            migrationBuilder.CreateTable(
                name: "E271ConMed",
                columns: table => new
                {
                    idRemitente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConMed", x => x.idRemitente);
                });

            migrationBuilder.CreateTable(
                name: "E271ConNom",
                columns: table => new
                {
                    idRemitente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConNom", x => x.idRemitente);
                });

            migrationBuilder.CreateTable(
                name: "E271ConObs",
                columns: table => new
                {
                    idRemitente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSubCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teMsgLibre1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teMsgLibre2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConObs", x => x.idRemitente);
                });

            migrationBuilder.CreateTable(
                name: "E271ConProc",
                columns: table => new
                {
                    idTransaccion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConProc", x => x.idTransaccion);
                });

            migrationBuilder.CreateTable(
                name: "E271ResCg",
                columns: table => new
                {
                    idRemitente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ResCg", x => x.idRemitente);
                });

            migrationBuilder.CreateTable(
                name: "E271ResDeriva",
                columns: table => new
                {
                    idReceptor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ResDeriva", x => x.idReceptor);
                });

            migrationBuilder.CreateTable(
                name: "E271ResSctr",
                columns: table => new
                {
                    idRemitente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDocPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ResSctr", x => x.idRemitente);
                });

            migrationBuilder.CreateTable(
                name: "E271SolAut",
                columns: table => new
                {
                    noMaTitular = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAdmisionista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEsPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuIdenEmpleador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuContratoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPoliza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCertificado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiPolizaAfiliacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiPlanSalud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coMoneda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coParentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soBeneficio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuSoBeneficio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEspecialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esMarital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feIniVigencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinVigencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDecAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idInfAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deTiAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feAfiliacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feOcuAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idDerFarmacia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deProductoDeFarmacia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    obsCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgConEspeciales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feIncTitular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCobPreExistencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    beMaxInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    canServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idDeProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSubTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgObsPre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgConEspecialesPre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiMoneda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coPagoFijo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coCalServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    canCalServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coPagoVariable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flagCG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deflagCG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feNaRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coPaisRegafi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271SolAut", x => x.noMaTitular);
                });

            migrationBuilder.CreateTable(
                name: "E278ContEntVinc",
                columns: table => new
                {
                    idReceptor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caIPRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noIPRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoIPRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuRucIPRESS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E278ContEntVinc", x => x.idReceptor);
                });

            migrationBuilder.CreateTable(
                name: "E278ResEntVinc",
                columns: table => new
                {
                    idRemitente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    respuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgRespuesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E278ResEntVinc", x => x.idRemitente);
                });

            migrationBuilder.CreateTable(
                name: "E278SolCg",
                columns: table => new
                {
                    idCorrelativo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReceptor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiFinalidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuSoCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E278SolCg", x => x.idCorrelativo);
                });

            migrationBuilder.CreateTable(
                name: "E997ResAut",
                columns: table => new
                {
                    idReceptor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    noTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idRemitente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCorrelativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idTransaccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuAutorizacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSeguridad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inCoErrorEncontrado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codError = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descError = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E997ResAut", x => x.idReceptor);
                });

            migrationBuilder.CreateTable(
                name: "E271ConCodDetalle",
                columns: table => new
                {
                    idProducto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    infBeneficio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    beMaxInicial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    moCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coInRestriccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    canServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSubTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgObs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgConEspeciales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiMoneda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coPagoFijo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coCalServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    canCalServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coPagoVariable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flagCaGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deflagCaGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271ConCodidRemitente = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConCodDetalle", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_E271ConCodDetalle_E271ConCod_E271ConCodidRemitente",
                        column: x => x.E271ConCodidRemitente,
                        principalTable: "E271ConCod",
                        principalColumn: "idRemitente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271ConMedDetalle",
                columns: table => new
                {
                    idFuenteRE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    coSeCIE10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coRestriccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dePreexistencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgObsPr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    moDiagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271ConMedidRemitente = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConMedDetalle", x => x.idFuenteRE);
                    table.ForeignKey(
                        name: "FK_E271ConMedDetalle_E271ConMed_E271ConMedidRemitente",
                        column: x => x.E271ConMedidRemitente,
                        principalTable: "E271ConMed",
                        principalColumn: "idRemitente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271ConNomDetalle",
                columns: table => new
                {
                    noPaciente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEsPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuContratoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuSCTR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coParentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esMarital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiCaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271ConNomidRemitente = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConNomDetalle", x => x.noPaciente);
                    table.ForeignKey(
                        name: "FK_E271ConNomDetalle_E271ConNom_E271ConNomidRemitente",
                        column: x => x.E271ConNomidRemitente,
                        principalTable: "E271ConNom",
                        principalColumn: "idRemitente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271ConProcDetalle",
                columns: table => new
                {
                    idFuentePE = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    coInProcedimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coInRestriccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProcedimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imDeducible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    poCuExDecimal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuFrecuencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiNuDias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teMsgObservacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deTiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinVigencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teMsgTiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idFuenteTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coExCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deExCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teMsgExCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idFuenteEC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271ConProcidTransaccion = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ConProcDetalle", x => x.idFuentePE);
                    table.ForeignKey(
                        name: "FK_E271ConProcDetalle_E271ConProc_E271ConProcidTransaccion",
                        column: x => x.E271ConProcidTransaccion,
                        principalTable: "E271ConProc",
                        principalColumn: "idTransaccion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271ResCgDetalle",
                columns: table => new
                {
                    noPaciente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monPago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiCaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noMaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCaReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCaReContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuSoCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    veCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    esCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coProcedimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deProcedimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiPlanSalud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coMoneda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feCarGarantia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271ResCgidRemitente = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ResCgDetalle", x => x.noPaciente);
                    table.ForeignKey(
                        name: "FK_E271ResCgDetalle_E271ResCg_E271ResCgidRemitente",
                        column: x => x.E271ResCgidRemitente,
                        principalTable: "E271ResCg",
                        principalColumn: "idRemitente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271ResDerivaDetalle",
                columns: table => new
                {
                    idCaReferencia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    caPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apPaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coAfPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apMaternoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coParentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoTrabajoAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuDoTrabajoAfiliado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teMsgLibre1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coSubTiCobertura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feAtSalud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiDoContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reIdContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271ResDerivaidReceptor = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ResDerivaDetalle", x => x.idCaReferencia);
                    table.ForeignKey(
                        name: "FK_E271ResDerivaDetalle_E271ResDeriva_E271ResDerivaidReceptor",
                        column: x => x.E271ResDerivaidReceptor,
                        principalTable: "E271ResDeriva",
                        principalColumn: "idReceptor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271ResSctrDetalle",
                columns: table => new
                {
                    idCaReContratante = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tiCaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noEmApPaContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEmContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reIdContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiCaLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noEmLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coEmReLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idCaReLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reIdLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coLuAtencion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deTiAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feAfiliacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feOcAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271ResSctridRemitente = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271ResSctrDetalle", x => x.idCaReContratante);
                    table.ForeignKey(
                        name: "FK_E271ResSctrDetalle_E271ResSctr_E271ResSctridRemitente",
                        column: x => x.E271ResSctridRemitente,
                        principalTable: "E271ResSctr",
                        principalColumn: "idRemitente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271SolAutDetalleExeCar",
                columns: table => new
                {
                    idExCarencia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    coExCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deExCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgExCarencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271SolAutnoMaTitular = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271SolAutDetalleExeCar", x => x.idExCarencia);
                    table.ForeignKey(
                        name: "FK_E271SolAutDetalleExeCar_E271SolAut_E271SolAutnoMaTitular",
                        column: x => x.E271SolAutnoMaTitular,
                        principalTable: "E271SolAut",
                        principalColumn: "noMaTitular",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271SolAutDetalleProEsp",
                columns: table => new
                {
                    coTiProConAmbulatoria = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    coInProcedimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nuPlanConAmbulatoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imDeducible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    poConAmbulatoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    frConAmbulatoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    geConAmbulatoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caConAmbulatoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgConAmbulatoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271SolAutnoMaTitular = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271SolAutDetalleProEsp", x => x.coTiProConAmbulatoria);
                    table.ForeignKey(
                        name: "FK_E271SolAutDetalleProEsp_E271SolAut_E271SolAutnoMaTitular",
                        column: x => x.E271SolAutnoMaTitular,
                        principalTable: "E271SolAut",
                        principalColumn: "noMaTitular",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271SolAutDetalleRes",
                columns: table => new
                {
                    idRestricciones = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CIE10Restricciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    obsRestricciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deRestricciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgRestricciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monTopeRestricciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinEsperaRestricciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271SolAutnoMaTitular = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271SolAutDetalleRes", x => x.idRestricciones);
                    table.ForeignKey(
                        name: "FK_E271SolAutDetalleRes_E271SolAut_E271SolAutnoMaTitular",
                        column: x => x.E271SolAutnoMaTitular,
                        principalTable: "E271SolAut",
                        principalColumn: "noMaTitular",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E271SolAutDetalleTieEsp",
                columns: table => new
                {
                    idTiEspera = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    coTiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deTiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    feFinVigenciaTiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    msgTiEspera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E271SolAutnoMaTitular = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E271SolAutDetalleTieEsp", x => x.idTiEspera);
                    table.ForeignKey(
                        name: "FK_E271SolAutDetalleTieEsp_E271SolAut_E271SolAutnoMaTitular",
                        column: x => x.E271SolAutnoMaTitular,
                        principalTable: "E271SolAut",
                        principalColumn: "noMaTitular",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_E271ConCodDetalle_E271ConCodidRemitente",
                table: "E271ConCodDetalle",
                column: "E271ConCodidRemitente");

            migrationBuilder.CreateIndex(
                name: "IX_E271ConMedDetalle_E271ConMedidRemitente",
                table: "E271ConMedDetalle",
                column: "E271ConMedidRemitente");

            migrationBuilder.CreateIndex(
                name: "IX_E271ConNomDetalle_E271ConNomidRemitente",
                table: "E271ConNomDetalle",
                column: "E271ConNomidRemitente");

            migrationBuilder.CreateIndex(
                name: "IX_E271ConProcDetalle_E271ConProcidTransaccion",
                table: "E271ConProcDetalle",
                column: "E271ConProcidTransaccion");

            migrationBuilder.CreateIndex(
                name: "IX_E271ResCgDetalle_E271ResCgidRemitente",
                table: "E271ResCgDetalle",
                column: "E271ResCgidRemitente");

            migrationBuilder.CreateIndex(
                name: "IX_E271ResDerivaDetalle_E271ResDerivaidReceptor",
                table: "E271ResDerivaDetalle",
                column: "E271ResDerivaidReceptor");

            migrationBuilder.CreateIndex(
                name: "IX_E271ResSctrDetalle_E271ResSctridRemitente",
                table: "E271ResSctrDetalle",
                column: "E271ResSctridRemitente");

            migrationBuilder.CreateIndex(
                name: "IX_E271SolAutDetalleExeCar_E271SolAutnoMaTitular",
                table: "E271SolAutDetalleExeCar",
                column: "E271SolAutnoMaTitular");

            migrationBuilder.CreateIndex(
                name: "IX_E271SolAutDetalleProEsp_E271SolAutnoMaTitular",
                table: "E271SolAutDetalleProEsp",
                column: "E271SolAutnoMaTitular");

            migrationBuilder.CreateIndex(
                name: "IX_E271SolAutDetalleRes_E271SolAutnoMaTitular",
                table: "E271SolAutDetalleRes",
                column: "E271SolAutnoMaTitular");

            migrationBuilder.CreateIndex(
                name: "IX_E271SolAutDetalleTieEsp_E271SolAutnoMaTitular",
                table: "E271SolAutDetalleTieEsp",
                column: "E271SolAutnoMaTitular");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "E270ConAse");

            migrationBuilder.DropTable(
                name: "E270ConAseAcc");

            migrationBuilder.DropTable(
                name: "E271ConCodDetalle");

            migrationBuilder.DropTable(
                name: "E271ConDtad");

            migrationBuilder.DropTable(
                name: "E271ConMedDetalle");

            migrationBuilder.DropTable(
                name: "E271ConNomDetalle");

            migrationBuilder.DropTable(
                name: "E271ConObs");

            migrationBuilder.DropTable(
                name: "E271ConProcDetalle");

            migrationBuilder.DropTable(
                name: "E271ResCgDetalle");

            migrationBuilder.DropTable(
                name: "E271ResDerivaDetalle");

            migrationBuilder.DropTable(
                name: "E271ResSctrDetalle");

            migrationBuilder.DropTable(
                name: "E271SolAutDetalleExeCar");

            migrationBuilder.DropTable(
                name: "E271SolAutDetalleProEsp");

            migrationBuilder.DropTable(
                name: "E271SolAutDetalleRes");

            migrationBuilder.DropTable(
                name: "E271SolAutDetalleTieEsp");

            migrationBuilder.DropTable(
                name: "E278ContEntVinc");

            migrationBuilder.DropTable(
                name: "E278ResEntVinc");

            migrationBuilder.DropTable(
                name: "E278SolCg");

            migrationBuilder.DropTable(
                name: "E997ResAut");

            migrationBuilder.DropTable(
                name: "E271ConCod");

            migrationBuilder.DropTable(
                name: "E271ConMed");

            migrationBuilder.DropTable(
                name: "E271ConNom");

            migrationBuilder.DropTable(
                name: "E271ConProc");

            migrationBuilder.DropTable(
                name: "E271ResCg");

            migrationBuilder.DropTable(
                name: "E271ResDeriva");

            migrationBuilder.DropTable(
                name: "E271ResSctr");

            migrationBuilder.DropTable(
                name: "E271SolAut");
        }
    }
}
