using System;
using System.Collections.Generic;
using Epsa.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Epsa.Server.Context;

public partial class EpsaDbContext : DbContext
{
    public EpsaDbContext()
    {
    }

    public EpsaDbContext(DbContextOptions<EpsaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AfActivofi> AfActivofis { get; set; }

    public virtual DbSet<AfBaja> AfBajas { get; set; }

    public virtual DbSet<AfContum> AfConta { get; set; }

    public virtual DbSet<AfFisico> AfFisicos { get; set; }

    public virtual DbSet<AfHisto> AfHistos { get; set; }

    public virtual DbSet<AfKardex> AfKardices { get; set; }

    public virtual DbSet<AfMescierre> AfMescierres { get; set; }

    public virtual DbSet<AfOrgan> AfOrgans { get; set; }

    public virtual DbSet<AfReport01> AfReport01s { get; set; }

    public virtual DbSet<AfReport02> AfReport02s { get; set; }

    public virtual DbSet<AfRespo> AfRespos { get; set; }

    public virtual DbSet<AfVikardex> AfVikardices { get; set; }

    public virtual DbSet<Caranavi> Caranavis { get; set; }

    public virtual DbSet<CarteraCar> CarteraCars { get; set; }

    public virtual DbSet<Catprod> Catprods { get; set; }

    public virtual DbSet<CliH> CliHs { get; set; }

    public virtual DbSet<Contabil> Contabils { get; set; }

    public virtual DbSet<CpCotizacionM> CpCotizacionMs { get; set; }

    public virtual DbSet<CpEncSolic> CpEncSolics { get; set; }

    public virtual DbSet<CpEntrega> CpEntregas { get; set; }

    public virtual DbSet<CpFirma> CpFirmas { get; set; }

    public virtual DbSet<CpGrupoprov> CpGrupoprovs { get; set; }

    public virtual DbSet<CpImpItem> CpImpItems { get; set; }

    public virtual DbSet<CpImpNprov> CpImpNprovs { get; set; }

    public virtual DbSet<CpImpProv> CpImpProvs { get; set; }

    public virtual DbSet<CpLugar> CpLugars { get; set; }

    public virtual DbSet<CpPago> CpPagos { get; set; }

    public virtual DbSet<CpParametro> CpParametros { get; set; }

    public virtual DbSet<CpProveedor> CpProveedors { get; set; }

    public virtual DbSet<CpSolicProv> CpSolicProvs { get; set; }

    public virtual DbSet<CpTransSolic> CpTransSolics { get; set; }

    public virtual DbSet<CpUbicacion> CpUbicacions { get; set; }

    public virtual DbSet<CpValide> CpValides { get; set; }

    public virtual DbSet<CrBalance> CrBalances { get; set; }

    public virtual DbSet<CrBalancesuc> CrBalancesucs { get; set; }

    public virtual DbSet<CrBalancompa> CrBalancompas { get; set; }

    public virtual DbSet<CrCcta> CrCctas { get; set; }

    public virtual DbSet<CrCobranza> CrCobranzas { get; set; }

    public virtual DbSet<CrCompra> CrCompras { get; set; }

    public virtual DbSet<CrCranfec> CrCranfecs { get; set; }

    public virtual DbSet<CrCtransa> CrCtransas { get; set; }

    public virtual DbSet<CrCtransas1> CrCtransas1s { get; set; }

    public virtual DbSet<CrEresult> CrEresults { get; set; }

    public virtual DbSet<CrEresultm> CrEresultms { get; set; }

    public virtual DbSet<CrEresultsuc> CrEresultsucs { get; set; }

    public virtual DbSet<CrEstadoejepre> CrEstadoejepres { get; set; }

    public virtual DbSet<CrImpdoc> CrImpdocs { get; set; }

    public virtual DbSet<CrLibrobanco> CrLibrobancos { get; set; }

    public virtual DbSet<CrSumasaldo> CrSumasaldos { get; set; }

    public virtual DbSet<CrTotejepre> CrTotejepres { get; set; }

    public virtual DbSet<CrUtilidadb> CrUtilidadbs { get; set; }

    public virtual DbSet<CrVenta> CrVentas { get; set; }

    public virtual DbSet<CtAsigpre> CtAsigpres { get; set; }

    public virtual DbSet<CtBanco> CtBancos { get; set; }

    public virtual DbSet<CtBancoctum> CtBancocta { get; set; }

    public virtual DbSet<CtCajachica> CtCajachicas { get; set; }

    public virtual DbSet<CtCajaop> CtCajaops { get; set; }

    public virtual DbSet<CtCcosto> CtCcostos { get; set; }

    public virtual DbSet<CtCheque> CtCheques { get; set; }

    public virtual DbSet<CtChequeNulo> CtChequeNulos { get; set; }

    public virtual DbSet<CtCierreP> CtCierrePs { get; set; }

    public virtual DbSet<CtCompra> CtCompras { get; set; }

    public virtual DbSet<CtComprasba> CtComprasbas { get; set; }

    public virtual DbSet<CtContabil> CtContabils { get; set; }

    public virtual DbSet<CtDeprectum> CtDeprecta { get; set; }

    public virtual DbSet<CtDeprelug> CtDeprelugs { get; set; }

    public virtual DbSet<CtDisChe> CtDisChes { get; set; }

    public virtual DbSet<CtDocpre> CtDocpres { get; set; }

    public virtual DbSet<CtDocument> CtDocuments { get; set; }

    public virtual DbSet<CtDocument01> CtDocument01s { get; set; }

    public virtual DbSet<CtDocumentR> CtDocumentRs { get; set; }

    public virtual DbSet<CtDosific> CtDosifics { get; set; }

    public virtual DbSet<CtEjecpre> CtEjecpres { get; set; }

    public virtual DbSet<CtEmpper> CtEmppers { get; set; }

    public virtual DbSet<CtEmpresa> CtEmpresas { get; set; }

    public virtual DbSet<CtGestion> CtGestions { get; set; }

    public virtual DbSet<CtGlosasEli> CtGlosasElis { get; set; }

    public virtual DbSet<CtItemAct> CtItemActs { get; set; }

    public virtual DbSet<CtLibventum> CtLibventa { get; set; }

    public virtual DbSet<CtObjGe> CtObjGes { get; set; }

    public virtual DbSet<CtObjeto> CtObjetos { get; set; }

    public virtual DbSet<CtParametro> CtParametros { get; set; }

    public virtual DbSet<CtPeriodome> CtPeriodomes { get; set; }

    public virtual DbSet<CtPersona> CtPersonas { get; set; }

    public virtual DbSet<CtPresu> CtPresus { get; set; }

    public virtual DbSet<CtRetencion> CtRetencions { get; set; }

    public virtual DbSet<CtSaldo> CtSaldos { get; set; }

    public virtual DbSet<CtSubcta> CtSubctas { get; set; }

    public virtual DbSet<CtSubctasEc> CtSubctasEcs { get; set; }

    public virtual DbSet<CtSubctasEc1> CtSubctasEcs1 { get; set; }

    public virtual DbSet<CtSubctasEc2> CtSubctasEcs2 { get; set; }

    public virtual DbSet<CtSubctasEcCc> CtSubctasEcCcs { get; set; }

    public virtual DbSet<CtSucursal> CtSucursals { get; set; }

    public virtual DbSet<CtTesoro> CtTesoros { get; set; }

    public virtual DbSet<CtTipcambio> CtTipcambios { get; set; }

    public virtual DbSet<CtTipodoc> CtTipodocs { get; set; }

    public virtual DbSet<CtTransa> CtTransas { get; set; }

    public virtual DbSet<CtTransa2> CtTransa2s { get; set; }

    public virtual DbSet<CtTransaA> CtTransaAs { get; set; }

    public virtual DbSet<CtTransaAct> CtTransaActs { get; set; }

    public virtual DbSet<CtTransaNulo> CtTransaNulos { get; set; }

    public virtual DbSet<CtTransaR> CtTransaRs { get; set; }

    public virtual DbSet<CtTransapre> CtTransapres { get; set; }

    public virtual DbSet<CtUpsaldo> CtUpsaldos { get; set; }

    public virtual DbSet<CtUsofina> CtUsofinas { get; set; }

    public virtual DbSet<CtUsrDoc> CtUsrDocs { get; set; }

    public virtual DbSet<FcActividad> FcActividads { get; set; }

    public virtual DbSet<FcAjustfac> FcAjustfacs { get; set; }

    public virtual DbSet<FcAlta> FcAltas { get; set; }

    public virtual DbSet<FcAltasavg> FcAltasavgs { get; set; }

    public virtual DbSet<FcAltasbk20170914> FcAltasbk20170914s { get; set; }

    public virtual DbSet<FcAltasbk20170922> FcAltasbk20170922s { get; set; }

    public virtual DbSet<FcAltasbk20171004> FcAltasbk20171004s { get; set; }

    public virtual DbSet<FcAltasbk20171006> FcAltasbk20171006s { get; set; }

    public virtual DbSet<FcAltasbk20171130> FcAltasbk20171130s { get; set; }

    public virtual DbSet<FcAltasfixeditem> FcAltasfixeditems { get; set; }

    public virtual DbSet<FcArea> FcAreas { get; set; }

    public virtual DbSet<FcBeneficiariodv> FcBeneficiariodvs { get; set; }

    public virtual DbSet<FcBeneficiarioex> FcBeneficiarioexes { get; set; }

    public virtual DbSet<FcCaja> FcCajas { get; set; }

    public virtual DbSet<FcCambioEst> FcCambioEsts { get; set; }

    public virtual DbSet<FcCambmedi> FcCambmedis { get; set; }

    public virtual DbSet<FcCambnomb> FcCambnombs { get; set; }

    public virtual DbSet<FcCamcateg> FcCamcategs { get; set; }

    public virtual DbSet<FcCiclo> FcCiclos { get; set; }

    public virtual DbSet<FcCliente> FcClientes { get; set; }

    public virtual DbSet<FcClientebk20170914> FcClientebk20170914s { get; set; }

    public virtual DbSet<FcClientebk20170922> FcClientebk20170922s { get; set; }

    public virtual DbSet<FcClinocorte> FcClinocortes { get; set; }

    public virtual DbSet<FcClinofact> FcClinofacts { get; set; }

    public virtual DbSet<FcCobrocaj> FcCobrocajs { get; set; }

    public virtual DbSet<FcCobrocajpp> FcCobrocajpps { get; set; }

    public virtual DbSet<FcComhist> FcComhists { get; set; }

    public virtual DbSet<FcConstruc> FcConstrucs { get; set; }

    public virtual DbSet<FcContrato> FcContratos { get; set; }

    public virtual DbSet<FcCorFecenvig> FcCorFecenvigs { get; set; }

    public virtual DbSet<FcCorRec> FcCorRecs { get; set; }

    public virtual DbSet<FcDosPrerec> FcDosPrerecs { get; set; }

    public virtual DbSet<FcDosific> FcDosifics { get; set; }

    public virtual DbSet<FcDosific20171006> FcDosific20171006s { get; set; }

    public virtual DbSet<FcDs4206alta> FcDs4206altas { get; set; }

    public virtual DbSet<FcDs4206desctype> FcDs4206desctypes { get; set; }

    public virtual DbSet<FcDs4206etrank> FcDs4206etranks { get; set; }

    public virtual DbSet<FcEstCargo> FcEstCargos { get; set; }

    public virtual DbSet<FcEstTar01> FcEstTar01s { get; set; }

    public virtual DbSet<FcEstTipoet> FcEstTipoets { get; set; }

    public virtual DbSet<FcEstUso> FcEstUsos { get; set; }

    public virtual DbSet<FcFechavig> FcFechavigs { get; set; }

    public virtual DbSet<FcHistog> FcHistogs { get; set; }

    public virtual DbSet<FcInstitucion> FcInstitucions { get; set; }

    public virtual DbSet<FcInstitucion1> FcInstitucion1s { get; set; }

    public virtual DbSet<FcInstitucion11> FcInstitucion1s1 { get; set; }

    public virtual DbSet<FcInstnueva> FcInstnuevas { get; set; }

    public virtual DbSet<FcLectore> FcLectores { get; set; }

    public virtual DbSet<FcLectura> FcLecturas { get; set; }

    public virtual DbSet<FcLey1886> FcLey1886 { get; set; }

    public virtual DbSet<FcLey1886Tot> FcLey1886Tots { get; set; }

    public virtual DbSet<FcLeyendum> FcLeyenda { get; set; }

    public virtual DbSet<FcManten> FcMantens { get; set; }

    public virtual DbSet<FcMarca> FcMarcas { get; set; }

    public virtual DbSet<FcMedidor> FcMedidors { get; set; }

    public virtual DbSet<FcMovcateg> FcMovcategs { get; set; }

    public virtual DbSet<FcMovcliente> FcMovclientes { get; set; }

    public virtual DbSet<FcMovhistorico> FcMovhistoricos { get; set; }

    public virtual DbSet<FcMovob> FcMovobs { get; set; }

    public virtual DbSet<FcOb> FcObs { get; set; }

    public virtual DbSet<FcObservation> FcObservations { get; set; }

    public virtual DbSet<FcObskardex> FcObskardices { get; set; }

    public virtual DbSet<FcOt> FcOts { get; set; }

    public virtual DbSet<FcOtca> FcOtcas { get; set; }

    public virtual DbSet<FcOtrosI> FcOtrosIs { get; set; }

    public virtual DbSet<FcParametro> FcParametros { get; set; }

    public virtual DbSet<FcPaybdy> FcPaybdies { get; set; }

    public virtual DbSet<FcPayhdr> FcPayhdrs { get; set; }

    public virtual DbSet<FcPlalect> FcPlalects { get; set; }

    public virtual DbSet<FcPlapagbody> FcPlapagbodies { get; set; }

    public virtual DbSet<FcPlapagfac> FcPlapagfacs { get; set; }

    public virtual DbSet<FcPlapaghead> FcPlapagheads { get; set; }

    public virtual DbSet<FcPrbalance> FcPrbalances { get; set; }

    public virtual DbSet<FcPrbalanceFA> FcPrbalanceFAs { get; set; }

    public virtual DbSet<FcPrbalanceRm> FcPrbalanceRms { get; set; }

    public virtual DbSet<FcPrbalancegrl> FcPrbalancegrls { get; set; }

    public virtual DbSet<FcPrcorte> FcPrcortes { get; set; }

    public virtual DbSet<FcPrcrnotran> FcPrcrnotrans { get; set; }

    public virtual DbSet<FcPret> FcPrets { get; set; }

    public virtual DbSet<FcPrkardexcli> FcPrkardexclis { get; set; }

    public virtual DbSet<FcPrkardexclipp> FcPrkardexclipps { get; set; }

    public virtual DbSet<FcPrkardexfac> FcPrkardexfacs { get; set; }

    public virtual DbSet<FcPrlecterr> FcPrlecterrs { get; set; }

    public virtual DbSet<FcPrlistlect> FcPrlistlects { get; set; }

    public virtual DbSet<FcPrmoraCp> FcPrmoraCps { get; set; }

    public virtual DbSet<FcPrndatum> FcPrndata { get; set; }

    public virtual DbSet<FcPrnoservice> FcPrnoservices { get; set; }

    public virtual DbSet<FcProcoop> FcProcoops { get; set; }

    public virtual DbSet<FcPrplanpago> FcPrplanpagos { get; set; }

    public virtual DbSet<FcPrproform> FcPrproforms { get; set; }

    public virtual DbSet<FcPrreconex> FcPrreconexes { get; set; }

    public virtual DbSet<FcRcrecordsexpireGlobal> FcRcrecordsexpireGlobals { get; set; }

    public virtual DbSet<FcRcrecordsexpirecc> FcRcrecordsexpireccs { get; set; }

    public virtual DbSet<FcRecorrido> FcRecorridos { get; set; }

    public virtual DbSet<FcRecplalect> FcRecplalects { get; set; }

    public virtual DbSet<FcRecplfact> FcRecplfacts { get; set; }

    public virtual DbSet<FcRecplfact1> FcRecplfact1s { get; set; }

    public virtual DbSet<FcRecsdelete> FcRecsdeletes { get; set; }

    public virtual DbSet<FcRefanuMot> FcRefanuMots { get; set; }

    public virtual DbSet<FcRepcli> FcRepclis { get; set; }

    public virtual DbSet<FcRepcli01> FcRepcli01s { get; set; }

    public virtual DbSet<FcSector> FcSectors { get; set; }

    public virtual DbSet<FcSolicitud> FcSolicituds { get; set; }

    public virtual DbSet<FcStatisticTf> FcStatisticTfs { get; set; }

    public virtual DbSet<FcStatisticTf01> FcStatisticTf01s { get; set; }

    public virtual DbSet<FcSuspReha> FcSuspRehas { get; set; }

    public virtual DbSet<FcTasabank> FcTasabanks { get; set; }

    public virtual DbSet<FcTecnico> FcTecnicos { get; set; }

    public virtual DbSet<FcTipocaja> FcTipocajas { get; set; }

    public virtual DbSet<FcTrasmedi> FcTrasmedis { get; set; }

    public virtual DbSet<FcUbicaja> FcUbicajas { get; set; }

    public virtual DbSet<InActivaT> InActivaTs { get; set; }

    public virtual DbSet<InArea> InAreas { get; set; }

    public virtual DbSet<InArmazonInv> InArmazonInvs { get; set; }

    public virtual DbSet<InBodega> InBodegas { get; set; }

    public virtual DbSet<InCorrelativo> InCorrelativos { get; set; }

    public virtual DbSet<InDescuento> InDescuentos { get; set; }

    public virtual DbSet<InDoccorre> InDoccorres { get; set; }

    public virtual DbSet<InDocument> InDocuments { get; set; }

    public virtual DbSet<InDocumentG> InDocumentGs { get; set; }

    public virtual DbSet<InFecha> InFechas { get; set; }

    public virtual DbSet<InFechatraspaso> InFechatraspasos { get; set; }

    public virtual DbSet<InFisico> InFisicos { get; set; }

    public virtual DbSet<InGrupoProm> InGrupoProms { get; set; }

    public virtual DbSet<InGrupoinv> InGrupoinvs { get; set; }

    public virtual DbSet<InHistorialPre> InHistorialPres { get; set; }

    public virtual DbSet<InHistorialPrecio> InHistorialPrecios { get; set; }

    public virtual DbSet<InIdfisico> InIdfisicos { get; set; }

    public virtual DbSet<InImpEnc> InImpEncs { get; set; }

    public virtual DbSet<InImpresionDoc> InImpresionDocs { get; set; }

    public virtual DbSet<InInvBodega> InInvBodegas { get; set; }

    public virtual DbSet<InInventario> InInventarios { get; set; }

    public virtual DbSet<InLote> InLotes { get; set; }

    public virtual DbSet<InMaterialPrecio> InMaterialPrecios { get; set; }

    public virtual DbSet<InMaterialProv> InMaterialProvs { get; set; }

    public virtual DbSet<InMovInv> InMovInvs { get; set; }

    public virtual DbSet<InParametro> InParametros { get; set; }

    public virtual DbSet<InPromotor> InPromotors { get; set; }

    public virtual DbSet<InProveedor> InProveedors { get; set; }

    public virtual DbSet<InRekardex> InRekardices { get; set; }

    public virtual DbSet<InRepmaterial> InRepmaterials { get; set; }

    public virtual DbSet<InRepnotac> InRepnotacs { get; set; }

    public virtual DbSet<InReporte> InReportes { get; set; }

    public virtual DbSet<InRepsaldo> InRepsaldos { get; set; }

    public virtual DbSet<InRepsocio> InRepsocios { get; set; }

    public virtual DbSet<InReptMaterial> InReptMaterials { get; set; }

    public virtual DbSet<InReservaMat> InReservaMats { get; set; }

    public virtual DbSet<InSaldosf> InSaldosfs { get; set; }

    public virtual DbSet<InSectore> InSectores { get; set; }

    public virtual DbSet<InTemptraspaso> InTemptraspasos { get; set; }

    public virtual DbSet<InTipocredito> InTipocreditos { get; set; }

    public virtual DbSet<InTipodoc> InTipodocs { get; set; }

    public virtual DbSet<InTransPar> InTransPars { get; set; }

    public virtual DbSet<InTransaG> InTransaGs { get; set; }

    public virtual DbSet<InTransac> InTransacs { get; set; }

    public virtual DbSet<InTransac1> InTransac1s { get; set; }

    public virtual DbSet<InUbicacion> InUbicacions { get; set; }

    public virtual DbSet<InUnidad> InUnidads { get; set; }

    public virtual DbSet<OdCliext> OdCliexts { get; set; }

    public virtual DbSet<OdHistconsumo> OdHistconsumos { get; set; }

    public virtual DbSet<OdInspeccion> OdInspeccions { get; set; }

    public virtual DbSet<OdReclamo> OdReclamos { get; set; }

    public virtual DbSet<OiCobranza> OiCobranzas { get; set; }

    public virtual DbSet<OiDetalle> OiDetalles { get; set; }

    public virtual DbSet<OiFacanu> OiFacanus { get; set; }

    public virtual DbSet<OiOperacion> OiOperacions { get; set; }

    public virtual DbSet<OiOperacionbk190607> OiOperacionbk190607s { get; set; }

    public virtual DbSet<OiOtrosi> OiOtrosis { get; set; }

    public virtual DbSet<OiRetencion> OiRetencions { get; set; }

    public virtual DbSet<OiRetenciondet> OiRetenciondets { get; set; }

    public virtual DbSet<OiServicio> OiServicios { get; set; }

    public virtual DbSet<OtrosI> OtrosIs { get; set; }

    public virtual DbSet<Plan> Plans { get; set; }

    public virtual DbSet<Plan1> Plan1s { get; set; }

    public virtual DbSet<PrEmpleado> PrEmpleados { get; set; }

    public virtual DbSet<Proveed> Proveeds { get; set; }

    public virtual DbSet<SiMenu> SiMenus { get; set; }

    public virtual DbSet<SiMenu1> SiMenus1 { get; set; }

    public virtual DbSet<SiMenubk20170926> SiMenubk20170926s { get; set; }

    public virtual DbSet<SiParametsy> SiParametsys { get; set; }

    public virtual DbSet<SiSession> SiSessions { get; set; }

    public virtual DbSet<SiSistema> SiSistemas { get; set; }

    public virtual DbSet<SiSupUserSist> SiSupUserSists { get; set; }

    public virtual DbSet<SiSupUserSist1> SiSupUserSists1 { get; set; }

    public virtual DbSet<SiTemp> SiTemps { get; set; }

    public virtual DbSet<SiUserMenu> SiUserMenus { get; set; }

    public virtual DbSet<SiUserMenu1> SiUserMenus1 { get; set; }

    public virtual DbSet<SiUsuario> SiUsuarios { get; set; }

    public virtual DbSet<Tipocrd> Tipocrds { get; set; }

    public virtual DbSet<Usomater> Usomaters { get; set; }

    public virtual DbSet<VfcEstTar> VfcEstTars { get; set; }

    public virtual DbSet<VfcRec> VfcRecs { get; set; }

    public virtual DbSet<ViTransa> ViTransas { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=4RNOL\\SQLEXPRESS;Database=EPSA;User Id=sa;Password=77494717Aarnol;TrustServerCertificate=True;");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AfActivofi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_ACTIVOFI");

            entity.Property(e => e.AcB)
                .HasColumnType("money")
                .HasColumnName("AC_B");
            entity.Property(e => e.AcBd)
                .HasColumnType("money")
                .HasColumnName("AC_BD");
            entity.Property(e => e.AcCodcta)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("AC_CODCTA");
            entity.Property(e => e.AcCodfis)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AC_CODFIS");
            entity.Property(e => e.AcCodorg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AC_CODORG");
            entity.Property(e => e.AcCodresp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AC_CODRESP");
            entity.Property(e => e.AcComprob)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AC_COMPROB");
            entity.Property(e => e.AcCorr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AC_CORR");
            entity.Property(e => e.AcCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AC_CTA");
            entity.Property(e => e.AcDesc)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AC_DESC");
            entity.Property(e => e.AcEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AC_ESTADO");
            entity.Property(e => e.AcFechai)
                .HasColumnType("datetime")
                .HasColumnName("AC_FECHAI");
            entity.Property(e => e.AcGaB)
                .HasColumnType("money")
                .HasColumnName("AC_GA_B");
            entity.Property(e => e.AcGaBd)
                .HasColumnType("money")
                .HasColumnName("AC_GA_BD");
            entity.Property(e => e.AcGaS)
                .HasColumnType("money")
                .HasColumnName("AC_GA_S");
            entity.Property(e => e.AcGaSd)
                .HasColumnType("money")
                .HasColumnName("AC_GA_SD");
            entity.Property(e => e.AcGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AC_GRUPO");
            entity.Property(e => e.AcS)
                .HasColumnType("money")
                .HasColumnName("AC_S");
            entity.Property(e => e.AcSd)
                .HasColumnType("money")
                .HasColumnName("AC_SD");
            entity.Property(e => e.AcSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("AC_SERIE");
            entity.Property(e => e.AcTcI).HasColumnName("AC_TC_I");
            entity.Property(e => e.AcValorI)
                .HasColumnType("money")
                .HasColumnName("AC_VALOR_I");
            entity.Property(e => e.AcVutilI).HasColumnName("AC_VUTIL_I");
        });

        modelBuilder.Entity<AfBaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_BAJAS");

            entity.Property(e => e.BaCodaf)
                .HasMaxLength(15)
                .HasColumnName("BA_CODAF");
            entity.Property(e => e.BaComprob)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("BA_COMPROB");
            entity.Property(e => e.BaFecha)
                .HasColumnType("datetime")
                .HasColumnName("BA_FECHA");
            entity.Property(e => e.BaSerieaf).HasColumnName("BA_SERIEAF");
            entity.Property(e => e.BaUser).HasColumnName("BA_USER");
        });

        modelBuilder.Entity<AfContum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_CONTA");

            entity.Property(e => e.CoCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CO_COD");
            entity.Property(e => e.CoDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CO_DESC");
            entity.Property(e => e.CoMovi).HasColumnName("CO_MOVI");
            entity.Property(e => e.CoNivel).HasColumnName("CO_NIVEL");
            entity.Property(e => e.CoPorcdepr)
                .HasColumnType("smallmoney")
                .HasColumnName("CO_PORCDEPR");
            entity.Property(e => e.CoTot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CO_TOT");
            entity.Property(e => e.CoUltcorr).HasColumnName("CO_ULTCORR");
        });

        modelBuilder.Entity<AfFisico>(entity =>
        {
            entity.HasKey(e => e.FiCod);

            entity.ToTable("AF_FISICO");

            entity.Property(e => e.FiCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("FI_COD");
            entity.Property(e => e.FiDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("FI_DESC");
        });

        modelBuilder.Entity<AfHisto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_HISTO");

            entity.Property(e => e.HiCoditem)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("HI_CODITEM");
            entity.Property(e => e.HiComprob)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("HI_COMPROB");
            entity.Property(e => e.HiFecha)
                .HasColumnType("datetime")
                .HasColumnName("HI_FECHA");
            entity.Property(e => e.HiFisiA)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HI_FISI_A");
            entity.Property(e => e.HiFisiN)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HI_FISI_N");
            entity.Property(e => e.HiOrgaA)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HI_ORGA_A");
            entity.Property(e => e.HiOrgaN)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HI_ORGA_N");
            entity.Property(e => e.HiRespoA)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HI_RESPO_A");
            entity.Property(e => e.HiRespoN)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HI_RESPO_N");
            entity.Property(e => e.HiSerieaf).HasColumnName("HI_SERIEAF");
            entity.Property(e => e.HiTipomov)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("HI_TIPOMOV");
        });

        modelBuilder.Entity<AfKardex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_KARDEX");

            entity.Property(e => e.KdDebs)
                .HasColumnType("money")
                .HasColumnName("KD_DEBS");
            entity.Property(e => e.KdDesus)
                .HasColumnType("money")
                .HasColumnName("KD_DESUS");
            entity.Property(e => e.KdFecha)
                .HasColumnType("datetime")
                .HasColumnName("KD_FECHA");
            entity.Property(e => e.KdOp).HasColumnName("KD_OP");
            entity.Property(e => e.KdSerieaf).HasColumnName("KD_SERIEAF");
            entity.Property(e => e.KdTc)
                .HasColumnType("money")
                .HasColumnName("KD_TC");
            entity.Property(e => e.KdVhbs)
                .HasColumnType("money")
                .HasColumnName("KD_VHBS");
            entity.Property(e => e.KdVhsus)
                .HasColumnType("money")
                .HasColumnName("KD_VHSUS");
        });

        modelBuilder.Entity<AfMescierre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_MESCIERRE");

            entity.Property(e => e.MeEstado)
                .HasMaxLength(1)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeFecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("ME_FECHA");
            entity.Property(e => e.MeTc).HasColumnName("ME_TC");
            entity.Property(e => e.MeUser).HasColumnName("ME_USER");
        });

        modelBuilder.Entity<AfOrgan>(entity =>
        {
            entity.HasKey(e => e.OgCod).HasName("PK_AF_ORGA");

            entity.ToTable("AF_ORGAN");

            entity.Property(e => e.OgCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("OG_COD");
            entity.Property(e => e.OgDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OG_DESC");
        });

        modelBuilder.Entity<AfReport01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_REPORT01");

            entity.Property(e => e.ReDa)
                .HasColumnType("money")
                .HasColumnName("RE_DA");
            entity.Property(e => e.ReDaa)
                .HasColumnType("money")
                .HasColumnName("RE_DAA");
            entity.Property(e => e.ReDai)
                .HasColumnType("money")
                .HasColumnName("RE_DAI");
            entity.Property(e => e.ReDp)
                .HasColumnType("money")
                .HasColumnName("RE_DP");
            entity.Property(e => e.ReIa)
                .HasColumnType("money")
                .HasColumnName("RE_IA");
            entity.Property(e => e.ReInA)
                .HasColumnType("money")
                .HasColumnName("RE_IN_A");
            entity.Property(e => e.ReMa)
                .HasColumnType("datetime")
                .HasColumnName("RE_MA");
            entity.Property(e => e.ReOp).HasColumnName("RE_OP");
            entity.Property(e => e.ReSeraf).HasColumnName("RE_SERAF");
            entity.Property(e => e.ReTc)
                .HasColumnType("smallmoney")
                .HasColumnName("RE_TC");
            entity.Property(e => e.ReVa)
                .HasColumnType("money")
                .HasColumnName("RE_VA");
            entity.Property(e => e.ReVi)
                .HasColumnType("money")
                .HasColumnName("RE_VI");
            entity.Property(e => e.ReVn)
                .HasColumnType("money")
                .HasColumnName("RE_VN");
            entity.Property(e => e.ReVr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RE_VR");
        });

        modelBuilder.Entity<AfReport02>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AF_REPORT02");

            entity.Property(e => e.ReBp)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_BP");
            entity.Property(e => e.ReConta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RE_CONTA");
            entity.Property(e => e.ReCorr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("RE_CORR");
            entity.Property(e => e.ReDacuBp)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_DACU_BP");
            entity.Property(e => e.ReDaf)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_DAF");
            entity.Property(e => e.ReDai)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_DAI");
            entity.Property(e => e.ReDesc)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("RE_DESC");
            entity.Property(e => e.ReDp)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_DP");
            entity.Property(e => e.ReDp1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_DP1");
            entity.Property(e => e.ReFechai)
                .HasColumnType("datetime")
                .HasColumnName("RE_FECHAI");
            entity.Property(e => e.ReFisi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("RE_FISI");
            entity.Property(e => e.ReGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_GRUPO");
            entity.Property(e => e.ReIncA)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_INC_A");
            entity.Property(e => e.ReIncA1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_INC_A1");
            entity.Property(e => e.ReIncP)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_INC_P");
            entity.Property(e => e.ReIp)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_IP");
            entity.Property(e => e.ReOrga)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("RE_ORGA");
            entity.Property(e => e.ReOrga1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("RE_ORGA1");
            entity.Property(e => e.ReSgn1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_SGN1");
            entity.Property(e => e.ReSgn2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_SGN2");
            entity.Property(e => e.ReSgn3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_SGN3");
            entity.Property(e => e.ReVa)
                .HasColumnType("money")
                .HasColumnName("RE_VA");
            entity.Property(e => e.ReVi)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_VI");
            entity.Property(e => e.ReVn)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("RE_VN");
            entity.Property(e => e.ReVu).HasColumnName("RE_VU");
            entity.Property(e => e.ReVur).HasColumnName("RE_VUR");
        });

        modelBuilder.Entity<AfRespo>(entity =>
        {
            entity.HasKey(e => e.ReCod);

            entity.ToTable("AF_RESPO");

            entity.Property(e => e.ReCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RE_COD");
            entity.Property(e => e.ReNombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RE_NOMBRE");
        });

        modelBuilder.Entity<AfVikardex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AF_VIKARDEX");

            entity.Property(e => e.AcB)
                .HasColumnType("money")
                .HasColumnName("AC_B");
            entity.Property(e => e.AcCodcta)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("AC_CODCTA");
            entity.Property(e => e.AcCodfis)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AC_CODFIS");
            entity.Property(e => e.AcCodorg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AC_CODORG");
            entity.Property(e => e.AcCodresp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AC_CODRESP");
            entity.Property(e => e.AcCorr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("AC_CORR");
            entity.Property(e => e.AcCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AC_CTA");
            entity.Property(e => e.AcDesc)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("AC_DESC");
            entity.Property(e => e.AcEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AC_ESTADO");
            entity.Property(e => e.AcFechai)
                .HasColumnType("datetime")
                .HasColumnName("AC_FECHAI");
            entity.Property(e => e.AcSerie).HasColumnName("AC_SERIE");
            entity.Property(e => e.AcTcI).HasColumnName("AC_TC_I");
            entity.Property(e => e.AcValorI)
                .HasColumnType("money")
                .HasColumnName("AC_VALOR_I");
            entity.Property(e => e.AcVutilI).HasColumnName("AC_VUTIL_I");
            entity.Property(e => e.DeAcuAct)
                .HasColumnType("money")
                .HasColumnName("DE_ACU_ACT");
            entity.Property(e => e.FiDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("FI_DESC");
            entity.Property(e => e.KdSerieaf).HasColumnName("KD_SERIEAF");
            entity.Property(e => e.OgDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("OG_DESC");
            entity.Property(e => e.ReNombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RE_NOMBRE");
            entity.Property(e => e.ValorNeto)
                .HasColumnType("money")
                .HasColumnName("VALOR_NETO");
        });

        modelBuilder.Entity<Caranavi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CARANAVI");

            entity.Property(e => e.Abr06)
                .HasMaxLength(50)
                .HasColumnName("ABR06");
            entity.Property(e => e.Abr07)
                .HasMaxLength(50)
                .HasColumnName("ABR07");
            entity.Property(e => e.Ago05)
                .HasMaxLength(50)
                .HasColumnName("AGO05");
            entity.Property(e => e.Ago06)
                .HasMaxLength(50)
                .HasColumnName("AGO06");
            entity.Property(e => e.Ago07)
                .HasMaxLength(50)
                .HasColumnName("AGO07");
            entity.Property(e => e.Alc)
                .HasColumnType("money")
                .HasColumnName("ALC");
            entity.Property(e => e.Ap)
                .HasColumnType("money")
                .HasColumnName("AP");
            entity.Property(e => e.Cod)
                .HasMaxLength(50)
                .HasColumnName("COD");
            entity.Property(e => e.Dic05)
                .HasMaxLength(50)
                .HasColumnName("DIC05");
            entity.Property(e => e.Dic06)
                .HasMaxLength(50)
                .HasColumnName("DIC06");
            entity.Property(e => e.Dic07)
                .HasMaxLength(50)
                .HasColumnName("DIC07");
            entity.Property(e => e.Ene06)
                .HasMaxLength(50)
                .HasColumnName("ENE06");
            entity.Property(e => e.Ene07)
                .HasMaxLength(50)
                .HasColumnName("ENE07");
            entity.Property(e => e.Feb06)
                .HasMaxLength(50)
                .HasColumnName("FEB06");
            entity.Property(e => e.Feb07)
                .HasMaxLength(50)
                .HasColumnName("FEB07");
            entity.Property(e => e.Jul05)
                .HasMaxLength(50)
                .HasColumnName("JUL05");
            entity.Property(e => e.Jul06)
                .HasMaxLength(50)
                .HasColumnName("JUL06");
            entity.Property(e => e.Jul07)
                .HasMaxLength(50)
                .HasColumnName("JUL07");
            entity.Property(e => e.Jun05)
                .HasMaxLength(50)
                .HasColumnName("JUN05");
            entity.Property(e => e.Jun06)
                .HasMaxLength(50)
                .HasColumnName("JUN06");
            entity.Property(e => e.Jun07)
                .HasMaxLength(50)
                .HasColumnName("JUN07");
            entity.Property(e => e.Ley1886).HasColumnName("LEY1886");
            entity.Property(e => e.Mar06)
                .HasMaxLength(50)
                .HasColumnName("MAR06");
            entity.Property(e => e.Mar07)
                .HasMaxLength(50)
                .HasColumnName("MAR07");
            entity.Property(e => e.May06)
                .HasMaxLength(50)
                .HasColumnName("MAY06");
            entity.Property(e => e.May07)
                .HasMaxLength(50)
                .HasColumnName("MAY07");
            entity.Property(e => e.Nada1)
                .HasMaxLength(50)
                .HasColumnName("NADA1");
            entity.Property(e => e.Nada2)
                .HasMaxLength(50)
                .HasColumnName("NADA2");
            entity.Property(e => e.Nada3)
                .HasMaxLength(50)
                .HasColumnName("NADA3");
            entity.Property(e => e.Nov05)
                .HasMaxLength(50)
                .HasColumnName("NOV05");
            entity.Property(e => e.Nov06)
                .HasMaxLength(50)
                .HasColumnName("NOV06");
            entity.Property(e => e.Nov07)
                .HasMaxLength(50)
                .HasColumnName("NOV07");
            entity.Property(e => e.Oct05)
                .HasMaxLength(50)
                .HasColumnName("OCT05");
            entity.Property(e => e.Oct06)
                .HasMaxLength(50)
                .HasColumnName("OCT06");
            entity.Property(e => e.Oct07)
                .HasMaxLength(50)
                .HasColumnName("OCT07");
            entity.Property(e => e.Sep05)
                .HasMaxLength(50)
                .HasColumnName("SEP05");
            entity.Property(e => e.Sep06)
                .HasMaxLength(50)
                .HasColumnName("SEP06");
            entity.Property(e => e.Sep07)
                .HasMaxLength(50)
                .HasColumnName("SEP07");
        });

        modelBuilder.Entity<CarteraCar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CARTERA_CAR");

            entity.Property(e => e.Abr06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ABR06");
            entity.Property(e => e.Abr07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ABR07");
            entity.Property(e => e.Abr08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ABR08");
            entity.Property(e => e.Ago05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AGO05");
            entity.Property(e => e.Ago06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AGO06");
            entity.Property(e => e.Ago07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AGO07");
            entity.Property(e => e.Ago08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AGO08");
            entity.Property(e => e.Cod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD");
            entity.Property(e => e.Dic05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIC05");
            entity.Property(e => e.Dic06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIC06");
            entity.Property(e => e.Dic07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIC07");
            entity.Property(e => e.Dic08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIC08");
            entity.Property(e => e.Ene06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENE06");
            entity.Property(e => e.Ene07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENE07");
            entity.Property(e => e.Ene08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENE08");
            entity.Property(e => e.Feb06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEB06");
            entity.Property(e => e.Feb07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEB07");
            entity.Property(e => e.Feb08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FEB08");
            entity.Property(e => e.Jul05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUL05");
            entity.Property(e => e.Jul06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUL06");
            entity.Property(e => e.Jul07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUL07");
            entity.Property(e => e.Jul08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUL08");
            entity.Property(e => e.Jun05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUN05");
            entity.Property(e => e.Jun06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUN06");
            entity.Property(e => e.Jun07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUN07");
            entity.Property(e => e.Jun08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUN08");
            entity.Property(e => e.Mar06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAR06");
            entity.Property(e => e.Mar07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAR07");
            entity.Property(e => e.Mar08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAR08");
            entity.Property(e => e.May06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAY06");
            entity.Property(e => e.May07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAY07");
            entity.Property(e => e.May08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAY08");
            entity.Property(e => e.Nov05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOV05");
            entity.Property(e => e.Nov06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOV06");
            entity.Property(e => e.Nov07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOV07");
            entity.Property(e => e.Nov08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOV08");
            entity.Property(e => e.Oct05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCT05");
            entity.Property(e => e.Oct06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCT06");
            entity.Property(e => e.Oct07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCT07");
            entity.Property(e => e.Oct08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCT08");
            entity.Property(e => e.Sep05)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEP05");
            entity.Property(e => e.Sep06)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEP06");
            entity.Property(e => e.Sep07)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEP07");
            entity.Property(e => e.Sep08)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEP08");
        });

        modelBuilder.Entity<Catprod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CATPROD");

            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .HasColumnName("CODIGO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(10)
                .HasColumnName("CUENTA");
            entity.Property(e => e.Descrip)
                .HasMaxLength(35)
                .HasColumnName("DESCRIP");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.Monto1).HasColumnName("MONTO1");
            entity.Property(e => e.Monto2).HasColumnName("MONTO2");
            entity.Property(e => e.Monto3).HasColumnName("MONTO3");
            entity.Property(e => e.Monto4).HasColumnName("MONTO4");
        });

        modelBuilder.Entity<CliH>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLI_H");

            entity.Property(e => e.Actividad)
                .HasMaxLength(20)
                .HasColumnName("ACTIVIDAD");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Ago06).HasColumnName("AGO_06");
            entity.Property(e => e.Alcant).HasColumnName("ALCANT");
            entity.Property(e => e.Ci)
                .HasMaxLength(16)
                .HasColumnName("CI");
            entity.Property(e => e.CodDir)
                .HasMaxLength(18)
                .HasColumnName("COD_DIR");
            entity.Property(e => e.CodFac)
                .HasMaxLength(3)
                .HasColumnName("COD_FAC");
            entity.Property(e => e.CodKar)
                .HasMaxLength(4)
                .HasColumnName("COD_KAR");
            entity.Property(e => e.CodLote)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("COD_LOTE");
            entity.Property(e => e.CodMa).HasColumnName("COD_MA");
            entity.Property(e => e.DigEnt).HasColumnName("DIG_ENT");
            entity.Property(e => e.Direccion)
                .HasMaxLength(60)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.FecCorA)
                .HasColumnType("smalldatetime")
                .HasColumnName("FEC_COR_A");
            entity.Property(e => e.FecCorB)
                .HasColumnType("smalldatetime")
                .HasColumnName("FEC_COR_B");
            entity.Property(e => e.FecIns)
                .HasColumnType("smalldatetime")
                .HasColumnName("FEC_INS");
            entity.Property(e => e.FecPag)
                .HasColumnType("smalldatetime")
                .HasColumnName("FEC_PAG");
            entity.Property(e => e.Irun).HasColumnName("IRUN");
            entity.Property(e => e.Jul06).HasColumnName("JUL_06");
            entity.Property(e => e.Jun06).HasColumnName("JUN_06");
            entity.Property(e => e.MarMed)
                .HasMaxLength(15)
                .HasColumnName("MAR_MED");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .HasColumnName("MATERNO");
            entity.Property(e => e.May06).HasColumnName("MAY_06");
            entity.Property(e => e.MesDeu).HasColumnName("MES_DEU");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.NroCta)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("NRO_CTA");
            entity.Property(e => e.NumFab)
                .HasMaxLength(10)
                .HasColumnName("NUM_FAB");
            entity.Property(e => e.Paterno)
                .HasMaxLength(40)
                .HasColumnName("PATERNO");
            entity.Property(e => e.Procede)
                .HasMaxLength(30)
                .HasColumnName("PROCEDE");
        });

        modelBuilder.Entity<Contabil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("contabil");

            entity.Property(e => e.CnAct).HasColumnName("CN_ACT");
            entity.Property(e => e.CnActB).HasColumnName("CN_ACT_B");
            entity.Property(e => e.CnActS).HasColumnName("CN_ACT_S");
            entity.Property(e => e.CnAux)
                .HasMaxLength(1)
                .HasColumnName("CN_AUX");
            entity.Property(e => e.CnB).HasColumnName("CN_B");
            entity.Property(e => e.CnCom)
                .HasMaxLength(1)
                .HasColumnName("CN_COM");
            entity.Property(e => e.CnCta)
                .HasMaxLength(10)
                .HasColumnName("CN_CTA");
            entity.Property(e => e.CnGaB).HasColumnName("CN_GA_B");
            entity.Property(e => e.CnGaS).HasColumnName("CN_GA_S");
            entity.Property(e => e.CnGnB).HasColumnName("CN_GN_B");
            entity.Property(e => e.CnGnS).HasColumnName("CN_GN_S");
            entity.Property(e => e.CnMnd)
                .HasMaxLength(1)
                .HasColumnName("CN_MND");
            entity.Property(e => e.CnMov).HasColumnName("CN_MOV");
            entity.Property(e => e.CnNivel).HasColumnName("CN_NIVEL");
            entity.Property(e => e.CnNom)
                .HasMaxLength(50)
                .HasColumnName("CN_NOM");
            entity.Property(e => e.CnObj)
                .HasMaxLength(1)
                .HasColumnName("CN_OBJ");
            entity.Property(e => e.CnPB).HasColumnName("CN_P_B");
            entity.Property(e => e.CnPS).HasColumnName("CN_P_S");
            entity.Property(e => e.CnS).HasColumnName("CN_S");
            entity.Property(e => e.CnTip)
                .HasMaxLength(1)
                .HasColumnName("CN_TIP");
            entity.Property(e => e.CnTot).HasColumnName("CN_TOT");
        });

        modelBuilder.Entity<CpCotizacionM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_COTIZACION_M");

            entity.Property(e => e.SoArchivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SO_ARCHIVO");
            entity.Property(e => e.SoFecha)
                .HasColumnType("datetime")
                .HasColumnName("SO_FECHA");
            entity.Property(e => e.SoSerial).HasColumnName("SO_SERIAL");
            entity.Property(e => e.SoUbicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SO_UBICACION");
        });

        modelBuilder.Entity<CpEncSolic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_ENC_SOLIC");

            entity.Property(e => e.EnEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('C')")
                .HasColumnName("EN_ESTADO");
            entity.Property(e => e.EnFechaAdj)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("EN_FECHA_ADJ");
            entity.Property(e => e.EnFechaAp)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("EN_FECHA_AP");
            entity.Property(e => e.EnFechaCot)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("EN_FECHA_COT");
            entity.Property(e => e.EnFechaElab)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("EN_FECHA_ELAB");
            entity.Property(e => e.EnFechaSc)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("EN_FECHA_SC");
            entity.Property(e => e.EnId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EN_ID");
            entity.Property(e => e.EnNroOc).HasColumnName("EN_NRO_OC");
            entity.Property(e => e.EnNroSc).HasColumnName("EN_NRO_SC");
            entity.Property(e => e.EnTipodoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("EN_TIPODOC");
        });

        modelBuilder.Entity<CpEntrega>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_ENTREGA");

            entity.Property(e => e.PrEntrega)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_ENTREGA");
        });

        modelBuilder.Entity<CpFirma>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_FIRMAS");

            entity.Property(e => e.FrFirma)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FR_FIRMA");
            entity.Property(e => e.FrMonto).HasColumnName("FR_MONTO");
            entity.Property(e => e.FrSerial).HasColumnName("FR_SERIAL");
        });

        modelBuilder.Entity<CpGrupoprov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_GRUPOPROV");

            entity.Property(e => e.GrCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("GR_CODIGO");
            entity.Property(e => e.GrCorr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("GR_CORR");
            entity.Property(e => e.GrDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("GR_DESC");
            entity.Property(e => e.GrId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GR_ID");
            entity.Property(e => e.GrObs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("GR_OBS");
            entity.Property(e => e.GrRep).HasColumnName("GR_REP");
            entity.Property(e => e.GrUnidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("GR_UNIDAD");
        });

        modelBuilder.Entity<CpImpItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_IMP_ITEM");

            entity.Property(e => e.TrCantidad).HasColumnName("TR_CANTIDAD");
            entity.Property(e => e.TrDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TR_DESC");
            entity.Property(e => e.TrId).HasColumnName("TR_ID");
            entity.Property(e => e.TrItem).HasColumnName("TR_ITEM");
            entity.Property(e => e.TrProv1).HasColumnName("TR_PROV1");
            entity.Property(e => e.TrProv10).HasColumnName("TR_PROV10");
            entity.Property(e => e.TrProv2).HasColumnName("TR_PROV2");
            entity.Property(e => e.TrProv3).HasColumnName("TR_PROV3");
            entity.Property(e => e.TrProv4).HasColumnName("TR_PROV4");
            entity.Property(e => e.TrProv5).HasColumnName("TR_PROV5");
            entity.Property(e => e.TrProv6).HasColumnName("TR_PROV6");
            entity.Property(e => e.TrProv7).HasColumnName("TR_PROV7");
            entity.Property(e => e.TrProv8).HasColumnName("TR_PROV8");
            entity.Property(e => e.TrProv9).HasColumnName("TR_PROV9");
        });

        modelBuilder.Entity<CpImpNprov>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_IMP_NPROV");

            entity.Property(e => e.ImFecAdj)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("IM_FEC_ADJ");
            entity.Property(e => e.ImFecElab)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("IM_FEC_ELAB");
            entity.Property(e => e.ImNroSc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("IM_NRO_SC");
            entity.Property(e => e.ImObs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_OBS");
            entity.Property(e => e.ImProv1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV1");
            entity.Property(e => e.ImProv10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV10");
            entity.Property(e => e.ImProv2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV2");
            entity.Property(e => e.ImProv3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV3");
            entity.Property(e => e.ImProv4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV4");
            entity.Property(e => e.ImProv5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV5");
            entity.Property(e => e.ImProv6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV6");
            entity.Property(e => e.ImProv7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV7");
            entity.Property(e => e.ImProv8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV8");
            entity.Property(e => e.ImProv9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV9");
            entity.Property(e => e.ImSerial).HasColumnName("IM_SERIAL");
        });

        modelBuilder.Entity<CpImpProv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_IMP_PROV");

            entity.Property(e => e.ImProv1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV1");
            entity.Property(e => e.ImProv10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV10");
            entity.Property(e => e.ImProv2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV2");
            entity.Property(e => e.ImProv3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV3");
            entity.Property(e => e.ImProv4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV4");
            entity.Property(e => e.ImProv5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV5");
            entity.Property(e => e.ImProv6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV6");
            entity.Property(e => e.ImProv7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV7");
            entity.Property(e => e.ImProv8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV8");
            entity.Property(e => e.ImProv9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IM_PROV9");
            entity.Property(e => e.ImSerial).HasColumnName("IM_SERIAL");
        });

        modelBuilder.Entity<CpLugar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_LUGAR");

            entity.Property(e => e.PrLugar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_LUGAR");
        });

        modelBuilder.Entity<CpPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_PAGO");

            entity.Property(e => e.PrPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_PAGO");
        });

        modelBuilder.Entity<CpParametro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_PARAMETROS");

            entity.Property(e => e.PrCorrCot).HasColumnName("PR_CORR_COT");
            entity.Property(e => e.PrDireccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("PR_DIRECCION");
        });

        modelBuilder.Entity<CpProveedor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_PROVEEDOR");

            entity.Property(e => e.PrCelular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PR_CELULAR");
            entity.Property(e => e.PrCodigo)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PR_CODIGO");
            entity.Property(e => e.PrContacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("PR_CONTACTO");
            entity.Property(e => e.PrContactoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("PR_CONTACTOC");
            entity.Property(e => e.PrDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("PR_DIRECCION");
            entity.Property(e => e.PrEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('xxx@hotmail.com')")
                .HasColumnName("PR_EMAIL");
            entity.Property(e => e.PrFax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PR_FAX");
            entity.Property(e => e.PrGrupo)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_GRUPO");
            entity.Property(e => e.PrId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PR_ID");
            entity.Property(e => e.PrNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("PR_NOMBRE");
            entity.Property(e => e.PrRegistro)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PR_REGISTRO");
            entity.Property(e => e.PrRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PR_RUC");
            entity.Property(e => e.PrTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("PR_TELEFONO");
            entity.Property(e => e.PrTipocredito)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_TIPOCREDITO");
            entity.Property(e => e.PrUbicacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("PR_UBICACION");
        });

        modelBuilder.Entity<CpSolicProv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_SOLIC_PROV");

            entity.Property(e => e.CoEntrega)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("CO_ENTREGA");
            entity.Property(e => e.CoIdnc).HasColumnName("CO_IDNC");
            entity.Property(e => e.CoIdoc).HasColumnName("CO_IDOC");
            entity.Property(e => e.CoIdprov).HasColumnName("CO_IDPROV");
            entity.Property(e => e.CoOferta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("CO_OFERTA");
            entity.Property(e => e.CoPago)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("CO_PAGO");
            entity.Property(e => e.CoTiempo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("CO_TIEMPO");
        });

        modelBuilder.Entity<CpTransSolic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_TRANS_SOLIC");

            entity.Property(e => e.TrCantidad)
                .HasColumnType("money")
                .HasColumnName("TR_CANTIDAD");
            entity.Property(e => e.TrCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("TR_CODIGO");
            entity.Property(e => e.TrDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TR_DESC");
            entity.Property(e => e.TrId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TR_ID");
            entity.Property(e => e.TrIdnc).HasColumnName("TR_IDNC");
            entity.Property(e => e.TrIdprov).HasColumnName("TR_IDPROV");
            entity.Property(e => e.TrItem).HasColumnName("TR_ITEM");
            entity.Property(e => e.TrMarcado).HasColumnName("TR_MARCADO");
            entity.Property(e => e.TrPrecioc)
                .HasColumnType("money")
                .HasColumnName("TR_PRECIOC");
            entity.Property(e => e.TrUnidad)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TR_UNIDAD");
        });

        modelBuilder.Entity<CpUbicacion>(entity =>
        {
            entity.HasKey(e => e.UbId);

            entity.ToTable("CP_UBICACION");

            entity.HasIndex(e => e.UbCiudad, "CIUDAD");

            entity.Property(e => e.UbId).HasColumnName("UB_ID");
            entity.Property(e => e.UbCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UB_CIUDAD");
            entity.Property(e => e.UbDpto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UB_DPTO");
        });

        modelBuilder.Entity<CpValide>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CP_VALIDES");

            entity.Property(e => e.PrValides)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_VALIDES");
        });

        modelBuilder.Entity<CrBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_BALANCE");

            entity.Property(e => e.BaCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BA_CTA");
            entity.Property(e => e.BaEmpid).HasColumnName("BA_EMPID");
            entity.Property(e => e.BaIdba)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BA_IDBA");
            entity.Property(e => e.BaMe)
                .HasColumnType("money")
                .HasColumnName("BA_ME");
            entity.Property(e => e.BaMn)
                .HasColumnType("money")
                .HasColumnName("BA_MN");
            entity.Property(e => e.BaMov).HasColumnName("BA_MOV");
            entity.Property(e => e.BaNiv).HasColumnName("BA_NIV");
            entity.Property(e => e.BaNom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BA_NOM");
            entity.Property(e => e.BaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BA_TIPO");
        });

        modelBuilder.Entity<CrBalancesuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_BALANCESUC");

            entity.Property(e => e.BaCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BA_CTA");
            entity.Property(e => e.BaEmpid).HasColumnName("BA_EMPID");
            entity.Property(e => e.BaMns0)
                .HasColumnType("money")
                .HasColumnName("BA_MNS0");
            entity.Property(e => e.BaMns1)
                .HasColumnType("money")
                .HasColumnName("BA_MNS1");
            entity.Property(e => e.BaMns2)
                .HasColumnType("money")
                .HasColumnName("BA_MNS2");
            entity.Property(e => e.BaMns3)
                .HasColumnType("money")
                .HasColumnName("BA_MNS3");
            entity.Property(e => e.BaMns4)
                .HasColumnType("money")
                .HasColumnName("BA_MNS4");
            entity.Property(e => e.BaMns5)
                .HasColumnType("money")
                .HasColumnName("BA_MNS5");
            entity.Property(e => e.BaMns6)
                .HasColumnType("money")
                .HasColumnName("BA_MNS6");
            entity.Property(e => e.BaMns7)
                .HasColumnType("money")
                .HasColumnName("BA_MNS7");
            entity.Property(e => e.BaMov).HasColumnName("BA_MOV");
            entity.Property(e => e.BaNiv).HasColumnName("BA_NIV");
            entity.Property(e => e.BaNom)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("BA_NOM");
            entity.Property(e => e.BaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BA_TIPO");
        });

        modelBuilder.Entity<CrBalancompa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_BALANCOMPA");

            entity.Property(e => e.BaCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BA_CTA");
            entity.Property(e => e.BaEmpid).HasColumnName("BA_EMPID");
            entity.Property(e => e.BaIdba)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BA_IDBA");
            entity.Property(e => e.BaMnac)
                .HasColumnType("money")
                .HasColumnName("BA_MNAC");
            entity.Property(e => e.BaMnan)
                .HasColumnType("money")
                .HasColumnName("BA_MNAN");
            entity.Property(e => e.BaMnvar)
                .HasColumnType("money")
                .HasColumnName("BA_MNVAR");
            entity.Property(e => e.BaMov).HasColumnName("BA_MOV");
            entity.Property(e => e.BaNiv).HasColumnName("BA_NIV");
            entity.Property(e => e.BaNom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BA_NOM");
            entity.Property(e => e.BaPorc)
                .HasColumnType("money")
                .HasColumnName("BA_PORC");
            entity.Property(e => e.BaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BA_TIPO");
        });

        modelBuilder.Entity<CrCcta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_CCTAS");

            entity.Property(e => e.RcCta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RC_CTA");
            entity.Property(e => e.RcDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RC_DESC");
            entity.Property(e => e.RcIdrep)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RC_IDREP");
            entity.Property(e => e.RcNivel).HasColumnName("RC_NIVEL");
            entity.Property(e => e.RcSaldome)
                .HasColumnType("money")
                .HasColumnName("RC_SALDOME");
            entity.Property(e => e.RcSaldomn)
                .HasColumnType("money")
                .HasColumnName("RC_SALDOMN");
            entity.Property(e => e.RcSerie).HasColumnName("RC_SERIE");
        });

        modelBuilder.Entity<CrCobranza>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_COBRANZA");

            entity.Property(e => e.CoCustomer)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_CUSTOMER");
            entity.Property(e => e.CoDate)
                .HasColumnType("datetime")
                .HasColumnName("CO_DATE");
            entity.Property(e => e.CoNdoc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_NDOC");
            entity.Property(e => e.CoOpid).HasColumnName("CO_OPID");
            entity.Property(e => e.CoSeller).HasColumnName("CO_SELLER");
            entity.Property(e => e.CoStep).HasColumnName("CO_STEP");
            entity.Property(e => e.CoTpayment)
                .HasColumnType("money")
                .HasColumnName("CO_TPAYMENT");
            entity.Property(e => e.CoTsale)
                .HasColumnType("money")
                .HasColumnName("CO_TSALE");
        });

        modelBuilder.Entity<CrCompra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_COMPRAS");

            entity.Property(e => e.CoCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_CCONTROL");
            entity.Property(e => e.CoDescu)
                .HasColumnType("money")
                .HasColumnName("CO_DESCU");
            entity.Property(e => e.CoEmpid).HasColumnName("CO_EMPID");
            entity.Property(e => e.CoEspecifi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CO_ESPECIFI");
            entity.Property(e => e.CoExen)
                .HasColumnType("money")
                .HasColumnName("CO_EXEN");
            entity.Property(e => e.CoFecha)
                .HasColumnType("datetime")
                .HasColumnName("CO_FECHA");
            entity.Property(e => e.CoGrab).HasColumnName("CO_GRAB");
            entity.Property(e => e.CoIce)
                .HasColumnType("money")
                .HasColumnName("CO_ICE");
            entity.Property(e => e.CoImportenscf)
                .HasColumnType("money")
                .HasColumnName("CO_IMPORTENSCF");
            entity.Property(e => e.CoMonto)
                .HasColumnType("money")
                .HasColumnName("CO_MONTO");
            entity.Property(e => e.CoNit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NIT");
            entity.Property(e => e.CoNombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CO_NOMBRE");
            entity.Property(e => e.CoNro).HasColumnName("CO_NRO");
            entity.Property(e => e.CoNroauto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NROAUTO");
            entity.Property(e => e.CoNrofac).HasColumnName("CO_NROFAC");
            entity.Property(e => e.CoNropoli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CO_NROPOLI");
            entity.Property(e => e.CoNroreg).HasColumnName("CO_NROREG");
            entity.Property(e => e.CoPag).HasColumnName("CO_PAG");
            entity.Property(e => e.CoSubtotal)
                .HasColumnType("money")
                .HasColumnName("CO_SUBTOTAL");
            entity.Property(e => e.CoTipoco)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CO_TIPOCO");
            entity.Property(e => e.CoTotalcf)
                .HasColumnType("money")
                .HasColumnName("CO_TOTALCF");
        });

        modelBuilder.Entity<CrCranfec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_CRANFEC");

            entity.Property(e => e.RfFecf)
                .HasColumnType("datetime")
                .HasColumnName("RF_FECF");
            entity.Property(e => e.RfFeci)
                .HasColumnType("datetime")
                .HasColumnName("RF_FECI");
            entity.Property(e => e.RfIdrep)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RF_IDREP");
            entity.Property(e => e.RfMext).HasColumnName("RF_MEXT");
            entity.Property(e => e.RfMnal).HasColumnName("RF_MNAL");
        });

        modelBuilder.Entity<CrCtransa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_CTRANSAS");

            entity.Property(e => e.TrCc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_CC");
            entity.Property(e => e.TrDhe)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("TR_DHE");
            entity.Property(e => e.TrDhn)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("TR_DHN");
            entity.Property(e => e.TrFecha)
                .HasColumnType("datetime")
                .HasColumnName("TR_FECHA");
            entity.Property(e => e.TrGlosa)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_GLOSA");
            entity.Property(e => e.TrIdcta)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TR_IDCTA");
            entity.Property(e => e.TrIdrep)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_IDREP");
            entity.Property(e => e.TrIdscta)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TR_IDSCTA");
            entity.Property(e => e.TrIdt)
                .ValueGeneratedOnAdd()
                .HasColumnName("TR_IDT");
            entity.Property(e => e.TrNum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TR_NUM");
            entity.Property(e => e.TrRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_REF");
            entity.Property(e => e.TrSaldoe)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("TR_SALDOE");
            entity.Property(e => e.TrSaldon)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("TR_SALDON");
            entity.Property(e => e.TrSeq)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TR_SEQ");
            entity.Property(e => e.TrTc)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("TR_TC");
            entity.Property(e => e.TrTd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_TD");
        });

        modelBuilder.Entity<CrCtransas1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_CTRANSAS1");

            entity.Property(e => e.TrFecha)
                .HasColumnType("datetime")
                .HasColumnName("TR_FECHA");
            entity.Property(e => e.TrGlosa)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("TR_GLOSA");
            entity.Property(e => e.TrIdcta).HasColumnName("TR_IDCTA");
            entity.Property(e => e.TrIdrep)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TR_IDREP");
            entity.Property(e => e.TrIdt).HasColumnName("TR_IDT");
            entity.Property(e => e.TrNum).HasColumnName("TR_NUM");
            entity.Property(e => e.TrRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TR_REF");
            entity.Property(e => e.TrSaldoe)
                .HasColumnType("money")
                .HasColumnName("TR_SALDOE");
            entity.Property(e => e.TrSaldon)
                .HasColumnType("money")
                .HasColumnName("TR_SALDON");
            entity.Property(e => e.TrSalme)
                .HasColumnType("money")
                .HasColumnName("TR_SALME");
            entity.Property(e => e.TrSalmn)
                .HasColumnType("money")
                .HasColumnName("TR_SALMN");
            entity.Property(e => e.TrTc)
                .HasColumnType("money")
                .HasColumnName("TR_TC");
            entity.Property(e => e.TrTd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TR_TD");
        });

        modelBuilder.Entity<CrEresult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_ERESULT");

            entity.Property(e => e.ErCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ER_CTA");
            entity.Property(e => e.ErEmpid).HasColumnName("ER_EMPID");
            entity.Property(e => e.ErIder)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ER_IDER");
            entity.Property(e => e.ErMe)
                .HasColumnType("money")
                .HasColumnName("ER_ME");
            entity.Property(e => e.ErMn)
                .HasColumnType("money")
                .HasColumnName("ER_MN");
            entity.Property(e => e.ErMov).HasColumnName("ER_MOV");
            entity.Property(e => e.ErNiv).HasColumnName("ER_NIV");
            entity.Property(e => e.ErNom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ER_NOM");
            entity.Property(e => e.ErTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ER_TIPO");
        });

        modelBuilder.Entity<CrEresultm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_ERESULTM");

            entity.Property(e => e.ErAbr)
                .HasColumnType("money")
                .HasColumnName("ER_ABR");
            entity.Property(e => e.ErAgo)
                .HasColumnType("money")
                .HasColumnName("ER_AGO");
            entity.Property(e => e.ErCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ER_CTA");
            entity.Property(e => e.ErDic)
                .HasColumnType("money")
                .HasColumnName("ER_DIC");
            entity.Property(e => e.ErEmpid).HasColumnName("ER_EMPID");
            entity.Property(e => e.ErEne)
                .HasColumnType("money")
                .HasColumnName("ER_ENE");
            entity.Property(e => e.ErFeb)
                .HasColumnType("money")
                .HasColumnName("ER_FEB");
            entity.Property(e => e.ErIdoper).HasColumnName("ER_IDOPER");
            entity.Property(e => e.ErJul)
                .HasColumnType("money")
                .HasColumnName("ER_JUL");
            entity.Property(e => e.ErJun)
                .HasColumnType("money")
                .HasColumnName("ER_JUN");
            entity.Property(e => e.ErMar)
                .HasColumnType("money")
                .HasColumnName("ER_MAR");
            entity.Property(e => e.ErMay)
                .HasColumnType("money")
                .HasColumnName("ER_MAY");
            entity.Property(e => e.ErMov).HasColumnName("ER_MOV");
            entity.Property(e => e.ErNiv).HasColumnName("ER_NIV");
            entity.Property(e => e.ErNombre)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("ER_NOMBRE");
            entity.Property(e => e.ErNov)
                .HasColumnType("money")
                .HasColumnName("ER_NOV");
            entity.Property(e => e.ErOct)
                .HasColumnType("money")
                .HasColumnName("ER_OCT");
            entity.Property(e => e.ErSep)
                .HasColumnType("money")
                .HasColumnName("ER_SEP");
            entity.Property(e => e.ErTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ER_TIPO");
            entity.Property(e => e.ErTot).HasColumnName("ER_TOT");
        });

        modelBuilder.Entity<CrEresultsuc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_ERESULTSUC");

            entity.Property(e => e.ErCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ER_CTA");
            entity.Property(e => e.ErEmpid).HasColumnName("ER_EMPID");
            entity.Property(e => e.ErMns0)
                .HasColumnType("money")
                .HasColumnName("ER_MNS0");
            entity.Property(e => e.ErMns1)
                .HasColumnType("money")
                .HasColumnName("ER_MNS1");
            entity.Property(e => e.ErMns2)
                .HasColumnType("money")
                .HasColumnName("ER_MNS2");
            entity.Property(e => e.ErMns3)
                .HasColumnType("money")
                .HasColumnName("ER_MNS3");
            entity.Property(e => e.ErMns4)
                .HasColumnType("money")
                .HasColumnName("ER_MNS4");
            entity.Property(e => e.ErMns5)
                .HasColumnType("money")
                .HasColumnName("ER_MNS5");
            entity.Property(e => e.ErMns6)
                .HasColumnType("money")
                .HasColumnName("ER_MNS6");
            entity.Property(e => e.ErMns7)
                .HasColumnType("money")
                .HasColumnName("ER_MNS7");
            entity.Property(e => e.ErMov).HasColumnName("ER_MOV");
            entity.Property(e => e.ErNiv).HasColumnName("ER_NIV");
            entity.Property(e => e.ErNom)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ER_NOM");
            entity.Property(e => e.ErTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ER_TIPO");
        });

        modelBuilder.Entity<CrEstadoejepre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_ESTADOEJEPRE");

            entity.Property(e => e.EjCap)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EJ_CAP");
            entity.Property(e => e.EjCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EJ_CTA");
            entity.Property(e => e.EjEjecacu)
                .HasColumnType("money")
                .HasColumnName("EJ_EJECACU");
            entity.Property(e => e.EjEjecmes)
                .HasColumnType("money")
                .HasColumnName("EJ_EJECMES");
            entity.Property(e => e.EjEmpid).HasColumnName("EJ_EMPID");
            entity.Property(e => e.EjMov).HasColumnName("EJ_MOV");
            entity.Property(e => e.EjNivel).HasColumnName("EJ_NIVEL");
            entity.Property(e => e.EjNom)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EJ_NOM");
            entity.Property(e => e.EjPreges)
                .HasColumnType("money")
                .HasColumnName("EJ_PREGES");
            entity.Property(e => e.EjPremes)
                .HasColumnType("money")
                .HasColumnName("EJ_PREMES");
            entity.Property(e => e.EjPresacu)
                .HasColumnType("money")
                .HasColumnName("EJ_PRESACU");
            entity.Property(e => e.EjPresaldo)
                .HasColumnType("money")
                .HasColumnName("EJ_PRESALDO");
            entity.Property(e => e.EjSercta).HasColumnName("EJ_SERCTA");
            entity.Property(e => e.EjTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EJ_TIP");
            entity.Property(e => e.EjTot).HasColumnName("EJ_TOT");
        });

        modelBuilder.Entity<CrImpdoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_IMPDOC");

            entity.Property(e => e.TrCorr).HasColumnName("TR_CORR");
            entity.Property(e => e.TrCta).HasColumnName("TR_CTA");
            entity.Property(e => e.TrDesc)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("TR_DESC");
            entity.Property(e => e.TrGlosa)
                .HasMaxLength(700)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TR_GLOSA");
            entity.Property(e => e.TrId).HasColumnName("TR_ID");
            entity.Property(e => e.TrMe)
                .HasColumnType("money")
                .HasColumnName("TR_ME");
            entity.Property(e => e.TrMn)
                .HasColumnType("money")
                .HasColumnName("TR_MN");
            entity.Property(e => e.TrObj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TR_OBJ");
            entity.Property(e => e.TrSerdoc).HasColumnName("TR_SERDOC");
        });

        modelBuilder.Entity<CrLibrobanco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_LIBROBANCO");

            entity.Property(e => e.LbCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LB_CTA");
            entity.Property(e => e.LbDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LB_DOC");
            entity.Property(e => e.LbEmpid).HasColumnName("LB_EMPID");
            entity.Property(e => e.LbFecha)
                .HasColumnType("datetime")
                .HasColumnName("LB_FECHA");
            entity.Property(e => e.LbGlosa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LB_GLOSA");
            entity.Property(e => e.LbId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LB_ID");
            entity.Property(e => e.LbIdtra).HasColumnName("LB_IDTRA");
            entity.Property(e => e.LbMe)
                .HasColumnType("money")
                .HasColumnName("LB_ME");
            entity.Property(e => e.LbMn)
                .HasColumnType("money")
                .HasColumnName("LB_MN");
            entity.Property(e => e.LbSaldo)
                .HasColumnType("money")
                .HasColumnName("LB_SALDO");
            entity.Property(e => e.LbTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("LB_TIPO");
        });

        modelBuilder.Entity<CrSumasaldo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_SUMASALDOS");

            entity.Property(e => e.SuCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SU_CTA");
            entity.Property(e => e.SuEmpid).HasColumnName("SU_EMPID");
            entity.Property(e => e.SuMeD)
                .HasColumnType("money")
                .HasColumnName("SU_ME_D");
            entity.Property(e => e.SuMeH)
                .HasColumnType("money")
                .HasColumnName("SU_ME_H");
            entity.Property(e => e.SuMeSa)
                .HasColumnType("money")
                .HasColumnName("SU_ME_SA");
            entity.Property(e => e.SuMnD)
                .HasColumnType("money")
                .HasColumnName("SU_MN_D");
            entity.Property(e => e.SuMnH)
                .HasColumnType("money")
                .HasColumnName("SU_MN_H");
            entity.Property(e => e.SuMnSa)
                .HasColumnType("money")
                .HasColumnName("SU_MN_SA");
            entity.Property(e => e.SuMov).HasColumnName("SU_MOV");
            entity.Property(e => e.SuNivel).HasColumnName("SU_NIVEL");
            entity.Property(e => e.SuNom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SU_NOM");
        });

        modelBuilder.Entity<CrTotejepre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_TOTEJEPRE");

            entity.Property(e => e.ToEjeacu)
                .HasColumnType("money")
                .HasColumnName("TO_EJEACU");
            entity.Property(e => e.ToEjemes)
                .HasColumnType("money")
                .HasColumnName("TO_EJEMES");
            entity.Property(e => e.ToPreacu)
                .HasColumnType("money")
                .HasColumnName("TO_PREACU");
            entity.Property(e => e.ToPreges)
                .HasColumnType("money")
                .HasColumnName("TO_PREGES");
            entity.Property(e => e.ToPremes)
                .HasColumnType("money")
                .HasColumnName("TO_PREMES");
            entity.Property(e => e.ToPresa)
                .HasColumnType("money")
                .HasColumnName("TO_PRESA");
            entity.Property(e => e.ToTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TO_TIP");
        });

        modelBuilder.Entity<CrUtilidadb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_UTILIDADB");

            entity.Property(e => e.UbCcosto)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("UB_CCOSTO");
            entity.Property(e => e.UbCta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UB_CTA");
            entity.Property(e => e.UbEmpid).HasColumnName("UB_EMPID");
            entity.Property(e => e.UbId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UB_ID");
            entity.Property(e => e.UbMe)
                .HasColumnType("money")
                .HasColumnName("UB_ME");
            entity.Property(e => e.UbMec)
                .HasColumnType("money")
                .HasColumnName("UB_MEC");
            entity.Property(e => e.UbMn)
                .HasColumnType("money")
                .HasColumnName("UB_MN");
            entity.Property(e => e.UbMnc)
                .HasColumnType("money")
                .HasColumnName("UB_MNC");
            entity.Property(e => e.UbSuc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UB_SUC");
            entity.Property(e => e.UbTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("UB_TIPO");
            entity.Property(e => e.UbUser).HasColumnName("UB_USER");
        });

        modelBuilder.Entity<CrVenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CR_VENTAS");

            entity.Property(e => e.VeCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VE_CCONTROL");
            entity.Property(e => e.VeDescu)
                .HasColumnType("money")
                .HasColumnName("VE_DESCU");
            entity.Property(e => e.VeEmpid).HasColumnName("VE_EMPID");
            entity.Property(e => e.VeEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VE_EST");
            entity.Property(e => e.VeExen)
                .HasColumnType("money")
                .HasColumnName("VE_EXEN");
            entity.Property(e => e.VeFecha)
                .HasColumnType("datetime")
                .HasColumnName("VE_FECHA");
            entity.Property(e => e.VeIce)
                .HasColumnType("money")
                .HasColumnName("VE_ICE");
            entity.Property(e => e.VeNit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VE_NIT");
            entity.Property(e => e.VeNombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VE_NOMBRE");
            entity.Property(e => e.VeNro).HasColumnName("VE_NRO");
            entity.Property(e => e.VeNroauto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VE_NROAUTO");
            entity.Property(e => e.VeNrofac).HasColumnName("VE_NROFAC");
            entity.Property(e => e.VePag).HasColumnName("VE_PAG");
            entity.Property(e => e.VeSubtotal)
                .HasColumnType("money")
                .HasColumnName("VE_SUBTOTAL");
            entity.Property(e => e.VeSuc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VE_SUC");
            entity.Property(e => e.VeTotal)
                .HasColumnType("money")
                .HasColumnName("VE_TOTAL");
            entity.Property(e => e.VeTotaldf)
                .HasColumnType("money")
                .HasColumnName("VE_TOTALDF");
            entity.Property(e => e.VeVegrata0)
                .HasColumnType("money")
                .HasColumnName("VE_VEGRATA0");
        });

        modelBuilder.Entity<CtAsigpre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_ASIGPRE");

            entity.Property(e => e.ApCcost)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AP_CCOST");
            entity.Property(e => e.ApEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AP_EST");
            entity.Property(e => e.ApFec)
                .HasColumnType("smalldatetime")
                .HasColumnName("AP_FEC");
            entity.Property(e => e.ApGes)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AP_GES");
            entity.Property(e => e.ApMe)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("AP_ME");
            entity.Property(e => e.ApMn)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("AP_MN");
            entity.Property(e => e.ApObj).HasColumnName("AP_OBJ");
            entity.Property(e => e.ApSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("AP_SERIE");
            entity.Property(e => e.ApTa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AP_TA");
            entity.Property(e => e.ApTc)
                .HasColumnType("smallmoney")
                .HasColumnName("AP_TC");
        });

        modelBuilder.Entity<CtBanco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_BANCO");

            entity.Property(e => e.BcEmpid).HasColumnName("BC_EMPID");
            entity.Property(e => e.BcId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BC_ID");
            entity.Property(e => e.BcNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BC_NOMBRE");
            entity.Property(e => e.BcSigla)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("BC_SIGLA");
        });

        modelBuilder.Entity<CtBancoctum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_BANCOCTA");

            entity.Property(e => e.BbBanco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BB_BANCO");
            entity.Property(e => e.BbCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BB_CTA");
            entity.Property(e => e.BbCtabco)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BB_CTABCO");
            entity.Property(e => e.BbEmpid).HasColumnName("BB_EMPID");
            entity.Property(e => e.BbId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BB_ID");
            entity.Property(e => e.BbIdba).HasColumnName("BB_IDBA");
            entity.Property(e => e.BbNro).HasColumnName("BB_NRO");
        });

        modelBuilder.Entity<CtCajachica>(entity =>
        {
            entity.HasKey(e => e.CaId);

            entity.ToTable("CT_CAJACHICA");

            entity.Property(e => e.CaId).HasColumnName("CA_ID");
            entity.Property(e => e.CaApconta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CA_APCONTA");
            entity.Property(e => e.CaApcontaco)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CA_APCONTACO");
            entity.Property(e => e.CaApcontaig)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CA_APCONTAIG");
            entity.Property(e => e.CaCcosto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CA_CCOSTO");
            entity.Property(e => e.CaCuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CA_CUENTA");
            entity.Property(e => e.CaDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CA_DESC");
            entity.Property(e => e.CaDescu)
                .HasColumnType("money")
                .HasColumnName("CA_DESCU");
            entity.Property(e => e.CaDocr)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CA_DOCR");
            entity.Property(e => e.CaEmpid).HasColumnName("CA_EMPID");
            entity.Property(e => e.CaExento)
                .HasColumnType("money")
                .HasColumnName("CA_EXENTO");
            entity.Property(e => e.CaFecha)
                .HasColumnType("datetime")
                .HasColumnName("CA_FECHA");
            entity.Property(e => e.CaGasto)
                .HasColumnType("money")
                .HasColumnName("CA_GASTO");
            entity.Property(e => e.CaIce)
                .HasColumnType("money")
                .HasColumnName("CA_ICE");
            entity.Property(e => e.CaIdco).HasColumnName("CA_IDCO");
            entity.Property(e => e.CaIddoc).HasColumnName("CA_IDDOC");
            entity.Property(e => e.CaIdka).HasColumnName("CA_IDKA");
            entity.Property(e => e.CaImp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CA_IMP");
            entity.Property(e => e.CaIva)
                .HasColumnType("smallmoney")
                .HasColumnName("CA_IVA");
            entity.Property(e => e.CaMn)
                .HasColumnType("money")
                .HasColumnName("CA_MN");
            entity.Property(e => e.CaNcomp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CA_NCOMP");
            entity.Property(e => e.CaNrofac)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CA_NROFAC");
            entity.Property(e => e.CaNrore)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CA_NRORE");
            entity.Property(e => e.CaPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('E')")
                .HasColumnName("CA_PAGO");
            entity.Property(e => e.CaPersona)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CA_PERSONA");
            entity.Property(e => e.CaProvee)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CA_PROVEE");
            entity.Property(e => e.CaSuc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("CA_SUC");
            entity.Property(e => e.CaTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('G')")
                .HasColumnName("CA_TIPO");
            entity.Property(e => e.CaUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CA_USER");
        });

        modelBuilder.Entity<CtCajaop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_CAJAOP");

            entity.Property(e => e.CtCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CT_CTA");
            entity.Property(e => e.CtCtaco)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CT_CTACO");
            entity.Property(e => e.CtCtaig)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CT_CTAIG");
            entity.Property(e => e.CtEmpid).HasColumnName("CT_EMPID");
            entity.Property(e => e.CtId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CT_ID");
            entity.Property(e => e.CtNombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CT_NOMBRE");
            entity.Property(e => e.CtOp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CT_OP");
        });

        modelBuilder.Entity<CtCcosto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_CCOSTO");

            entity.Property(e => e.CcCod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CC_COD");
            entity.Property(e => e.CcEmpid).HasColumnName("CC_EMPID");
            entity.Property(e => e.CcId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CC_ID");
            entity.Property(e => e.CcMov).HasColumnName("CC_MOV");
            entity.Property(e => e.CcNivel).HasColumnName("CC_NIVEL");
            entity.Property(e => e.CcNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CC_NOM");
            entity.Property(e => e.CcTot)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CC_TOT");
        });

        modelBuilder.Entity<CtCheque>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_CHEQUE");

            entity.Property(e => e.ChBanco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CH_BANCO");
            entity.Property(e => e.ChCta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CH_CTA");
            entity.Property(e => e.ChEmpid).HasColumnName("CH_EMPID");
            entity.Property(e => e.ChFecha)
                .HasColumnType("datetime")
                .HasColumnName("CH_FECHA");
            entity.Property(e => e.ChFechac)
                .HasColumnType("datetime")
                .HasColumnName("CH_FECHAC");
            entity.Property(e => e.ChFechae)
                .HasColumnType("datetime")
                .HasColumnName("CH_FECHAE");
            entity.Property(e => e.ChMn)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("CH_MN");
            entity.Property(e => e.ChNroimp).HasColumnName("CH_NROIMP");
            entity.Property(e => e.ChNulo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CH_NULO");
            entity.Property(e => e.ChNumdoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CH_NUMDOC");
            entity.Property(e => e.ChNumero).HasColumnName("CH_NUMERO");
            entity.Property(e => e.ChPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CH_PERSONA");
            entity.Property(e => e.ChSerdoc).HasColumnName("CH_SERDOC");
            entity.Property(e => e.ChSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("CH_SERIE");
            entity.Property(e => e.ChSertra).HasColumnName("CH_SERTRA");
            entity.Property(e => e.ChTipdoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CH_TIPDOC");
            entity.Property(e => e.ChTm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CH_TM");
        });

        modelBuilder.Entity<CtChequeNulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_CHEQUE_NULO");

            entity.Property(e => e.ChBanco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CH_BANCO");
            entity.Property(e => e.ChFecha)
                .HasColumnType("datetime")
                .HasColumnName("CH_FECHA");
            entity.Property(e => e.ChMn)
                .HasColumnType("money")
                .HasColumnName("CH_MN");
            entity.Property(e => e.ChNumero).HasColumnName("CH_NUMERO");
            entity.Property(e => e.ChPersona)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("CH_PERSONA");
            entity.Property(e => e.ChSerdoc).HasColumnName("CH_SERDOC");
            entity.Property(e => e.ChSerie).HasColumnName("CH_SERIE");
            entity.Property(e => e.ChSertra).HasColumnName("CH_SERTRA");
        });

        modelBuilder.Entity<CtCierreP>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_CIERRE_P");

            entity.Property(e => e.CiCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CI_CTA");
            entity.Property(e => e.CiFechaf)
                .HasColumnType("datetime")
                .HasColumnName("CI_FECHAF");
            entity.Property(e => e.CiFechai)
                .HasColumnType("datetime")
                .HasColumnName("CI_FECHAI");
            entity.Property(e => e.CiMe)
                .HasColumnType("money")
                .HasColumnName("CI_ME");
            entity.Property(e => e.CiMn)
                .HasColumnType("money")
                .HasColumnName("CI_MN");
            entity.Property(e => e.CiMov).HasColumnName("CI_MOV");
            entity.Property(e => e.CiNiv).HasColumnName("CI_NIV");
            entity.Property(e => e.CiNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CI_NOM");
            entity.Property(e => e.CiPer).HasColumnName("CI_PER");
            entity.Property(e => e.CiTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CI_TIP");
            entity.Property(e => e.CiTot)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CI_TOT");
        });

        modelBuilder.Entity<CtCompra>(entity =>
        {
            entity.HasKey(e => e.CoSerie);

            entity.ToTable("CT_COMPRA");

            entity.Property(e => e.CoSerie).HasColumnName("CO_SERIE");
            entity.Property(e => e.CoDescu)
                .HasColumnType("money")
                .HasColumnName("CO_DESCU");
            entity.Property(e => e.CoEmpid).HasColumnName("CO_EMPID");
            entity.Property(e => e.CoExento)
                .HasColumnType("money")
                .HasColumnName("CO_EXENTO");
            entity.Property(e => e.CoFecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("CO_FECHA");
            entity.Property(e => e.CoFechaco)
                .HasDefaultValueSql("('01/01/1980')")
                .HasColumnType("datetime")
                .HasColumnName("CO_FECHACO");
            entity.Property(e => e.CoIce)
                .HasColumnType("money")
                .HasColumnName("CO_ICE");
            entity.Property(e => e.CoImportensc)
                .HasColumnType("money")
                .HasColumnName("CO_IMPORTENSC");
            entity.Property(e => e.CoLitfac)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_LITFAC");
            entity.Property(e => e.CoMonto)
                .HasColumnType("money")
                .HasColumnName("CO_MONTO");
            entity.Property(e => e.CoNcomp)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_NCOMP");
            entity.Property(e => e.CoNgrab).HasColumnName("CO_NGRAB");
            entity.Property(e => e.CoNrofac)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NROFAC");
            entity.Property(e => e.CoNropoli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_NROPOLI");
            entity.Property(e => e.CoNumOrd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NUM_ORD");
            entity.Property(e => e.CoObser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_OBSER");
            entity.Property(e => e.CoOrigen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('C')")
                .HasColumnName("CO_ORIGEN");
            entity.Property(e => e.CoPag).HasColumnName("CO_PAG");
            entity.Property(e => e.CoProvee)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_PROVEE");
            entity.Property(e => e.CoRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_RUC");
            entity.Property(e => e.CoSersub).HasColumnName("CO_SERSUB");
            entity.Property(e => e.CoSertra).HasColumnName("CO_SERTRA");
            entity.Property(e => e.CoSubtotal)
                .HasColumnType("money")
                .HasColumnName("CO_SUBTOTAL");
            entity.Property(e => e.CoSuc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_SUC");
            entity.Property(e => e.CoTip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_TIP");
            entity.Property(e => e.CoTipoco)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_TIPOCO");
            entity.Property(e => e.CoTotalcf)
                .HasColumnType("money")
                .HasColumnName("CO_TOTALCF");
        });

        modelBuilder.Entity<CtComprasba>(entity =>
        {
            entity.HasKey(e => e.CoId);

            entity.ToTable("CT_COMPRASBA");

            entity.Property(e => e.CoId).HasColumnName("CO_ID");
            entity.Property(e => e.CoCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_CCONTROL");
            entity.Property(e => e.CoCla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CO_CLA");
            entity.Property(e => e.CoEmpid).HasColumnName("CO_EMPID");
            entity.Property(e => e.CoExento)
                .HasColumnType("money")
                .HasColumnName("CO_EXENTO");
            entity.Property(e => e.CoFecdocpa)
                .HasColumnType("datetime")
                .HasColumnName("CO_FECDOCPA");
            entity.Property(e => e.CoFecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("CO_FECHA");
            entity.Property(e => e.CoIce)
                .HasColumnType("money")
                .HasColumnName("CO_ICE");
            entity.Property(e => e.CoIdco).HasColumnName("CO_IDCO");
            entity.Property(e => e.CoMod).HasColumnName("CO_MOD");
            entity.Property(e => e.CoMonto)
                .HasColumnType("money")
                .HasColumnName("CO_MONTO");
            entity.Property(e => e.CoMontoacu)
                .HasColumnType("money")
                .HasColumnName("CO_MONTOACU");
            entity.Property(e => e.CoMontopa)
                .HasColumnType("money")
                .HasColumnName("CO_MONTOPA");
            entity.Property(e => e.CoNcomp).HasColumnName("CO_NCOMP");
            entity.Property(e => e.CoNgrab).HasColumnName("CO_NGRAB");
            entity.Property(e => e.CoNit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NIT");
            entity.Property(e => e.CoNitef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NITEF");
            entity.Property(e => e.CoNroauto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NROAUTO");
            entity.Property(e => e.CoNrocta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NROCTA");
            entity.Property(e => e.CoNrodocpa)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NRODOCPA");
            entity.Property(e => e.CoNrofac)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_NROFAC");
            entity.Property(e => e.CoObser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CO_OBSER");
            entity.Property(e => e.CoOrigen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CO_ORIGEN");
            entity.Property(e => e.CoPag).HasColumnName("CO_PAG");
            entity.Property(e => e.CoProvee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CO_PROVEE");
            entity.Property(e => e.CoSertra).HasColumnName("CO_SERTRA");
            entity.Property(e => e.CoTdocpago).HasColumnName("CO_TDOCPAGO");
            entity.Property(e => e.CoTip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CO_TIP");
            entity.Property(e => e.CoTiptra).HasColumnName("CO_TIPTRA");
        });

        modelBuilder.Entity<CtContabil>(entity =>
        {
            entity.HasKey(e => e.CnSerie);

            entity.ToTable("CT_CONTABIL");

            entity.Property(e => e.CnSerie).HasColumnName("CN_SERIE");
            entity.Property(e => e.CnAct).HasColumnName("CN_ACT");
            entity.Property(e => e.CnActB)
                .HasColumnType("money")
                .HasColumnName("CN_ACT_B");
            entity.Property(e => e.CnActS)
                .HasColumnType("money")
                .HasColumnName("CN_ACT_S");
            entity.Property(e => e.CnAux)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CN_AUX");
            entity.Property(e => e.CnB)
                .HasColumnType("money")
                .HasColumnName("CN_B");
            entity.Property(e => e.CnCcosto).HasColumnName("CN_CCOSTO");
            entity.Property(e => e.CnCom)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CN_COM");
            entity.Property(e => e.CnCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CN_CTA");
            entity.Property(e => e.CnEfe).HasColumnName("CN_EFE");
            entity.Property(e => e.CnEmpid).HasColumnName("CN_EMPID");
            entity.Property(e => e.CnGaB)
                .HasColumnType("money")
                .HasColumnName("CN_GA_B");
            entity.Property(e => e.CnGaS)
                .HasColumnType("money")
                .HasColumnName("CN_GA_S");
            entity.Property(e => e.CnGnB)
                .HasColumnType("money")
                .HasColumnName("CN_GN_B");
            entity.Property(e => e.CnGnS)
                .HasColumnType("money")
                .HasColumnName("CN_GN_S");
            entity.Property(e => e.CnMnd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CN_MND");
            entity.Property(e => e.CnMov).HasColumnName("CN_MOV");
            entity.Property(e => e.CnNivel).HasColumnName("CN_NIVEL");
            entity.Property(e => e.CnNom)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CN_NOM");
            entity.Property(e => e.CnObj)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CN_OBJ");
            entity.Property(e => e.CnPB)
                .HasColumnType("money")
                .HasColumnName("CN_P_B");
            entity.Property(e => e.CnPS)
                .HasColumnType("money")
                .HasColumnName("CN_P_S");
            entity.Property(e => e.CnS)
                .HasColumnType("money")
                .HasColumnName("CN_S");
            entity.Property(e => e.CnTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CN_TIP");
            entity.Property(e => e.CnTot).HasColumnName("CN_TOT");
        });

        modelBuilder.Entity<CtDeprectum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_DEPRECTA");

            entity.Property(e => e.DeEmpper).HasColumnName("DE_EMPPER");
            entity.Property(e => e.DeSerctaDe)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DE_SERCTA_DE");
            entity.Property(e => e.DeSerctaVh)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DE_SERCTA_VH");
            entity.Property(e => e.DeValor).HasColumnName("DE_VALOR");
        });

        modelBuilder.Entity<CtDeprelug>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_DEPRELUG");

            entity.Property(e => e.DlCodlug)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DL_CODLUG");
            entity.Property(e => e.DlSerctaGa)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DL_SERCTA_GA");
            entity.Property(e => e.DlSerctaVh)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DL_SERCTA_VH");
        });

        modelBuilder.Entity<CtDisChe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_DIS_CHE");

            entity.Property(e => e.DcBanco)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DC_BANCO");
            entity.Property(e => e.DcCanio)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CANIO");
            entity.Property(e => e.DcCdia)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CDIA");
            entity.Property(e => e.DcClit1)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CLIT1");
            entity.Property(e => e.DcClit2)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CLIT2");
            entity.Property(e => e.DcClug)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CLUG");
            entity.Property(e => e.DcCmes)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CMES");
            entity.Property(e => e.DcCnum)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CNUM");
            entity.Property(e => e.DcCorden)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_CORDEN");
            entity.Property(e => e.DcCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DC_CTA");
            entity.Property(e => e.DcFanio)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FANIO");
            entity.Property(e => e.DcFdia)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FDIA");
            entity.Property(e => e.DcFlit1)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FLIT1");
            entity.Property(e => e.DcFlit2)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FLIT2");
            entity.Property(e => e.DcFlug)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FLUG");
            entity.Property(e => e.DcFmes)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FMES");
            entity.Property(e => e.DcFnum)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FNUM");
            entity.Property(e => e.DcForden)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_FORDEN");
            entity.Property(e => e.DcLlit1).HasColumnName("DC_LLIT1");
            entity.Property(e => e.DcLlit2).HasColumnName("DC_LLIT2");
            entity.Property(e => e.DcSerie).HasColumnName("DC_SERIE");
        });

        modelBuilder.Entity<CtDocpre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_DOCPRE");

            entity.Property(e => e.PrDoc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PR_DOC");
            entity.Property(e => e.PrEmpid).HasColumnName("PR_EMPID");
            entity.Property(e => e.PrFecha)
                .HasColumnType("datetime")
                .HasColumnName("PR_FECHA");
            entity.Property(e => e.PrGes).HasColumnName("PR_GES");
            entity.Property(e => e.PrGlosa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PR_GLOSA");
            entity.Property(e => e.PrMnd)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("PR_MND");
            entity.Property(e => e.PrNiv).HasColumnName("PR_NIV");
            entity.Property(e => e.PrResp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_RESP");
            entity.Property(e => e.PrSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("PR_SERIE");
            entity.Property(e => e.PrSuc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_SUC");
            entity.Property(e => e.PrTc)
                .HasColumnType("smallmoney")
                .HasColumnName("PR_TC");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PR_TIPO");
        });

        modelBuilder.Entity<CtDocument>(entity =>
        {
            entity.HasKey(e => e.DcSerie);

            entity.ToTable("CT_DOCUMENT");

            entity.Property(e => e.DcSerie).HasColumnName("DC_SERIE");
            entity.Property(e => e.DcAju)
                .HasComment("")
                .HasColumnName("DC_AJU");
            entity.Property(e => e.DcCodsuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DC_CODSUC");
            entity.Property(e => e.DcCre).HasColumnName("DC_CRE");
            entity.Property(e => e.DcEmpid).HasColumnName("DC_EMPID");
            entity.Property(e => e.DcFecha)
                .HasColumnType("datetime")
                .HasColumnName("DC_FECHA");
            entity.Property(e => e.DcGlosa)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("DC_GLOSA");
            entity.Property(e => e.DcHora)
                .HasColumnType("smalldatetime")
                .HasColumnName("DC_HORA");
            entity.Property(e => e.DcNsepsa).HasColumnName("DC_NSEPSA");
            entity.Property(e => e.DcNulo).HasColumnName("DC_NULO");
            entity.Property(e => e.DcNum).HasColumnName("DC_NUM");
            entity.Property(e => e.DcNumfac).HasColumnName("DC_NUMFAC");
            entity.Property(e => e.DcPer).HasColumnName("DC_PER");
            entity.Property(e => e.DcTc)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_TC");
            entity.Property(e => e.DcTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DC_TIP");
            entity.Property(e => e.DcUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DC_USER");
        });

        modelBuilder.Entity<CtDocument01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_DOCUMENT01");

            entity.Property(e => e.DcAju).HasColumnName("DC_AJU");
            entity.Property(e => e.DcCodsuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DC_CODSUC");
            entity.Property(e => e.DcCre).HasColumnName("DC_CRE");
            entity.Property(e => e.DcEmpid).HasColumnName("DC_EMPID");
            entity.Property(e => e.DcFecha)
                .HasColumnType("datetime")
                .HasColumnName("DC_FECHA");
            entity.Property(e => e.DcGlosa)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("DC_GLOSA");
            entity.Property(e => e.DcHora)
                .HasColumnType("smalldatetime")
                .HasColumnName("DC_HORA");
            entity.Property(e => e.DcNsepsa).HasColumnName("DC_NSEPSA");
            entity.Property(e => e.DcNulo).HasColumnName("DC_NULO");
            entity.Property(e => e.DcNum).HasColumnName("DC_NUM");
            entity.Property(e => e.DcPer).HasColumnName("DC_PER");
            entity.Property(e => e.DcSerie).HasColumnName("DC_SERIE");
            entity.Property(e => e.DcTc)
                .HasColumnType("smallmoney")
                .HasColumnName("DC_TC");
            entity.Property(e => e.DcTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DC_TIP");
            entity.Property(e => e.DcUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DC_USER");
        });

        modelBuilder.Entity<CtDocumentR>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_DOCUMENT_R");

            entity.Property(e => e.DcCc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DC_CC");
            entity.Property(e => e.DcFecha)
                .HasColumnType("datetime")
                .HasColumnName("DC_FECHA");
            entity.Property(e => e.DcGlosa)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("DC_GLOSA");
            entity.Property(e => e.DcNro).HasColumnName("DC_NRO");
            entity.Property(e => e.DcSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("DC_SERIE");
            entity.Property(e => e.DcSuc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DC_SUC");
            entity.Property(e => e.DcTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DC_TIPO");
            entity.Property(e => e.DcUsu).HasColumnName("DC_USU");
        });

        modelBuilder.Entity<CtDosific>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_DOSIFIC");

            entity.Property(e => e.DsActivi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_ACTIVI");
            entity.Property(e => e.DsAlfanum)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_ALFANUM");
            entity.Property(e => e.DsEmpid).HasColumnName("DS_EMPID");
            entity.Property(e => e.DsEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_EST");
            entity.Property(e => e.DsFechaf)
                .HasColumnType("datetime")
                .HasColumnName("DS_FECHAF");
            entity.Property(e => e.DsFechai)
                .HasColumnType("datetime")
                .HasColumnName("DS_FECHAI");
            entity.Property(e => e.DsFeclimE)
                .HasColumnType("datetime")
                .HasColumnName("DS_FECLIM_E");
            entity.Property(e => e.DsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DS_ID");
            entity.Property(e => e.DsLlave)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_LLAVE");
            entity.Property(e => e.DsNauto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_NAUTO");
            entity.Property(e => e.DsNf).HasColumnName("DS_NF");
            entity.Property(e => e.DsNi).HasColumnName("DS_NI");
            entity.Property(e => e.DsNit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DS_NIT");
            entity.Property(e => e.DsNuso).HasColumnName("DS_NUSO");
            entity.Property(e => e.DsSuc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DS_SUC");
            entity.Property(e => e.DsUsado).HasColumnName("DS_USADO");
        });

        modelBuilder.Entity<CtEjecpre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_EJECPRE");

            entity.Property(e => e.EpEjecAcume)
                .HasColumnType("money")
                .HasColumnName("EP_EJEC_ACUME");
            entity.Property(e => e.EpEjecAcumn)
                .HasColumnType("money")
                .HasColumnName("EP_EJEC_ACUMN");
            entity.Property(e => e.EpEjecPerme)
                .HasColumnType("money")
                .HasColumnName("EP_EJEC_PERME");
            entity.Property(e => e.EpEjecPermn)
                .HasColumnType("money")
                .HasColumnName("EP_EJEC_PERMN");
            entity.Property(e => e.EpGes)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EP_GES");
            entity.Property(e => e.EpIdop)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EP_IDOP");
            entity.Property(e => e.EpMnda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EP_MNDA");
            entity.Property(e => e.EpPeaf)
                .HasColumnType("datetime")
                .HasColumnName("EP_PEAF");
            entity.Property(e => e.EpPeai)
                .HasColumnType("datetime")
                .HasColumnName("EP_PEAI");
            entity.Property(e => e.EpPerf)
                .HasColumnType("datetime")
                .HasColumnName("EP_PERF");
            entity.Property(e => e.EpPeri)
                .HasColumnType("datetime")
                .HasColumnName("EP_PERI");
            entity.Property(e => e.EpSerPar).HasColumnName("EP_SER_PAR");
            entity.Property(e => e.EpTot)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EP_TOT");
            entity.Property(e => e.EpTp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EP_TP");
        });

        modelBuilder.Entity<CtEmpper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_EMPPER");

            entity.Property(e => e.PeEmp).HasColumnName("PE_EMP");
            entity.Property(e => e.PeEstado).HasColumnName("PE_ESTADO");
            entity.Property(e => e.PeFechaf)
                .HasColumnType("datetime")
                .HasColumnName("PE_FECHAF");
            entity.Property(e => e.PeFechai)
                .HasColumnType("datetime")
                .HasColumnName("PE_FECHAI");
        });

        modelBuilder.Entity<CtEmpresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_EMPRESA");

            entity.Property(e => e.EmAnter)
                .HasColumnType("datetime")
                .HasColumnName("EM_ANTER");
            entity.Property(e => e.EmApert)
                .HasColumnType("datetime")
                .HasColumnName("EM_APERT");
            entity.Property(e => e.EmDesde)
                .HasColumnType("datetime")
                .HasColumnName("EM_DESDE");
            entity.Property(e => e.EmDirec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EM_DIREC");
            entity.Property(e => e.EmEMail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EM_E_MAIL");
            entity.Property(e => e.EmFinal)
                .HasColumnType("datetime")
                .HasColumnName("EM_FINAL");
            entity.Property(e => e.EmForLim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EM_FOR_LIM");
            entity.Property(e => e.EmHasta)
                .HasColumnType("datetime")
                .HasColumnName("EM_HASTA");
            entity.Property(e => e.EmId)
                .ValueGeneratedOnAdd()
                .HasColumnName("EM_ID");
            entity.Property(e => e.EmLimite)
                .HasColumnType("datetime")
                .HasColumnName("EM_LIMITE");
            entity.Property(e => e.EmLugar)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EM_LUGAR");
            entity.Property(e => e.EmNomBd)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("EM_NOM_BD");
            entity.Property(e => e.EmNomEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EM_NOM_EMP");
            entity.Property(e => e.EmPrinc)
                .HasColumnType("datetime")
                .HasColumnName("EM_PRINC");
            entity.Property(e => e.EmRuc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EM_RUC");
            entity.Property(e => e.EmSimMe)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EM_SIM_ME");
            entity.Property(e => e.EmSimMn)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EM_SIM_MN");
            entity.Property(e => e.EmStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EM_STATUS");
            entity.Property(e => e.EmTelf)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EM_TELF");
        });

        modelBuilder.Entity<CtGestion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_GESTION");

            entity.Property(e => e.GeGestion).HasColumnName("GE_GESTION");
            entity.Property(e => e.GeSeremp).HasColumnName("GE_SEREMP");
            entity.Property(e => e.GeSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("GE_SERIE");
        });

        modelBuilder.Entity<CtGlosasEli>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_GLOSAS_ELI");

            entity.Property(e => e.GlArc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GL_ARC");
            entity.Property(e => e.GlMem)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("GL_MEM");
            entity.Property(e => e.GlSerie).HasColumnName("GL_SERIE");
        });

        modelBuilder.Entity<CtItemAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_ITEM_ACT");

            entity.Property(e => e.ItCantidad).HasColumnName("IT_CANTIDAD");
            entity.Property(e => e.ItCodAct)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IT_COD_ACT");
            entity.Property(e => e.ItDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IT_DESC");
            entity.Property(e => e.ItItem)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IT_ITEM");
            entity.Property(e => e.ItPrecio).HasColumnName("IT_PRECIO");
            entity.Property(e => e.ItSerCta).HasColumnName("IT_SER_CTA");
            entity.Property(e => e.ItSerDoc).HasColumnName("IT_SER_DOC");
            entity.Property(e => e.ItSerTra).HasColumnName("IT_SER_TRA");
            entity.Property(e => e.ItSerie).HasColumnName("IT_SERIE");
        });

        modelBuilder.Entity<CtLibventum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_LIBVENTA");

            entity.Property(e => e.VeAlfanum)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VE_ALFANUM");
            entity.Property(e => e.VeCrefis)
                .HasColumnType("money")
                .HasColumnName("VE_CREFIS");
            entity.Property(e => e.VeDescu)
                .HasColumnType("money")
                .HasColumnName("VE_DESCU");
            entity.Property(e => e.VeEmpid).HasColumnName("VE_EMPID");
            entity.Property(e => e.VeEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('V')")
                .HasColumnName("VE_EST");
            entity.Property(e => e.VeExento)
                .HasColumnType("money")
                .HasColumnName("VE_EXENTO");
            entity.Property(e => e.VeFecha)
                .HasColumnType("datetime")
                .HasColumnName("VE_FECHA");
            entity.Property(e => e.VeIce)
                .HasColumnType("money")
                .HasColumnName("VE_ICE");
            entity.Property(e => e.VeNcomp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VE_NCOMP");
            entity.Property(e => e.VeNit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VE_NIT");
            entity.Property(e => e.VeNombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VE_NOMBRE");
            entity.Property(e => e.VeNrofac).HasColumnName("VE_NROFAC");
            entity.Property(e => e.VeNroord)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VE_NROORD");
            entity.Property(e => e.VeObser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VE_OBSER");
            entity.Property(e => e.VeOrigen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VE_ORIGEN");
            entity.Property(e => e.VePag).HasColumnName("VE_PAG");
            entity.Property(e => e.VeSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("VE_SERIE");
            entity.Property(e => e.VeSertra).HasColumnName("VE_SERTRA");
            entity.Property(e => e.VeSubtotal)
                .HasColumnType("money")
                .HasColumnName("VE_SUBTOTAL");
            entity.Property(e => e.VeSuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VE_SUC");
            entity.Property(e => e.VeTip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('CD')")
                .HasColumnName("VE_TIP");
            entity.Property(e => e.VeTotal)
                .HasColumnType("money")
                .HasColumnName("VE_TOTAL");
            entity.Property(e => e.VeTotaldf)
                .HasColumnType("money")
                .HasColumnName("VE_TOTALDF");
            entity.Property(e => e.VeVegrata0)
                .HasColumnType("money")
                .HasColumnName("VE_VEGRATA0");
        });

        modelBuilder.Entity<CtObjGe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_OBJ_GES");

            entity.Property(e => e.ObGes).HasColumnName("OB_GES");
        });

        modelBuilder.Entity<CtObjeto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_OBJETO");

            entity.Property(e => e.ObCod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OB_COD");
            entity.Property(e => e.ObDesc)
                .HasMaxLength(65)
                .IsUnicode(false)
                .HasColumnName("OB_DESC");
            entity.Property(e => e.ObEmpid).HasColumnName("OB_EMPID");
            entity.Property(e => e.ObGes).HasColumnName("OB_GES");
            entity.Property(e => e.ObMe)
                .HasColumnType("money")
                .HasColumnName("OB_ME");
            entity.Property(e => e.ObMn)
                .HasColumnType("money")
                .HasColumnName("OB_MN");
            entity.Property(e => e.ObMov).HasColumnName("OB_MOV");
            entity.Property(e => e.ObNivel).HasColumnName("OB_NIVEL");
            entity.Property(e => e.ObSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("OB_SERIE");
            entity.Property(e => e.ObTa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OB_TA");
            entity.Property(e => e.ObTot).HasColumnName("OB_TOT");
        });

        modelBuilder.Entity<CtParametro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_PARAMETROS");

            entity.Property(e => e.PrCtaAi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_AI");
            entity.Property(e => e.PrCtaCf)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CTA_CF");
            entity.Property(e => e.PrCtaCja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_CJA");
            entity.Property(e => e.PrCtaCjachi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_CJACHI");
            entity.Property(e => e.PrCtaDf)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CTA_DF");
            entity.Property(e => e.PrCtaE)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_E");
            entity.Property(e => e.PrCtaI)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_I");
            entity.Property(e => e.PrCtaIt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CTA_IT");
            entity.Property(e => e.PrCtaItp)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CTA_ITP");
            entity.Property(e => e.PrCtaRbienes)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CTA_RBIENES");
            entity.Property(e => e.PrCtaRg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_RG");
            entity.Property(e => e.PrCtaRit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_RIT");
            entity.Property(e => e.PrCtaRrciva)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CTA_RRCIVA");
            entity.Property(e => e.PrCtaRserv)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CTA_RSERV");
            entity.Property(e => e.PrEmpid).HasColumnName("PR_EMPID");
            entity.Property(e => e.PrIt)
                .HasColumnType("money")
                .HasColumnName("PR_IT");
            entity.Property(e => e.PrItf)
                .HasColumnType("money")
                .HasColumnName("PR_ITF");
            entity.Property(e => e.PrIva)
                .HasColumnType("money")
                .HasColumnName("PR_IVA");
        });

        modelBuilder.Entity<CtPeriodome>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_PERIODOMES");

            entity.Property(e => e.PeAnno).HasColumnName("PE_ANNO");
            entity.Property(e => e.PeEmpid).HasColumnName("PE_EMPID");
            entity.Property(e => e.PeEst).HasColumnName("PE_EST");
            entity.Property(e => e.PeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PE_ID");
            entity.Property(e => e.PeMes).HasColumnName("PE_MES");
        });

        modelBuilder.Entity<CtPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_PERSONA");

            entity.Property(e => e.PrEmpid).HasColumnName("PR_EMPID");
            entity.Property(e => e.PrNit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_NIT");
            entity.Property(e => e.PrNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_NOM");
            entity.Property(e => e.PrSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("PR_SERIE");
        });

        modelBuilder.Entity<CtPresu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_PRESU");

            entity.Property(e => e.ApAbr)
                .HasColumnType("money")
                .HasColumnName("AP_ABR");
            entity.Property(e => e.ApAgo)
                .HasColumnType("money")
                .HasColumnName("AP_AGO");
            entity.Property(e => e.ApCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AP_CTA");
            entity.Property(e => e.ApDic)
                .HasColumnType("money")
                .HasColumnName("AP_DIC");
            entity.Property(e => e.ApEne)
                .HasColumnType("money")
                .HasColumnName("AP_ENE");
            entity.Property(e => e.ApFeb)
                .HasColumnType("money")
                .HasColumnName("AP_FEB");
            entity.Property(e => e.ApJul)
                .HasColumnType("money")
                .HasColumnName("AP_JUL");
            entity.Property(e => e.ApJun)
                .HasColumnType("money")
                .HasColumnName("AP_JUN");
            entity.Property(e => e.ApMar)
                .HasColumnType("money")
                .HasColumnName("AP_MAR");
            entity.Property(e => e.ApMay)
                .HasColumnType("money")
                .HasColumnName("AP_MAY");
            entity.Property(e => e.ApMe)
                .HasColumnType("money")
                .HasColumnName("AP_ME");
            entity.Property(e => e.ApMem)
                .HasColumnType("money")
                .HasColumnName("AP_MEM");
            entity.Property(e => e.ApMes)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AP_MES");
            entity.Property(e => e.ApMn)
                .HasColumnType("money")
                .HasColumnName("AP_MN");
            entity.Property(e => e.ApMnm)
                .HasColumnType("money")
                .HasColumnName("AP_MNM");
            entity.Property(e => e.ApMov).HasColumnName("AP_MOV");
            entity.Property(e => e.ApNiv).HasColumnName("AP_NIV");
            entity.Property(e => e.ApNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AP_NOM");
            entity.Property(e => e.ApNov)
                .HasColumnType("money")
                .HasColumnName("AP_NOV");
            entity.Property(e => e.ApOct)
                .HasColumnType("money")
                .HasColumnName("AP_OCT");
            entity.Property(e => e.ApSep)
                .HasColumnType("money")
                .HasColumnName("AP_SEP");
            entity.Property(e => e.ApSercta).HasColumnName("AP_SERCTA");
            entity.Property(e => e.ApSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("AP_SERIE");
            entity.Property(e => e.ApSeriedp).HasColumnName("AP_SERIEDP");
            entity.Property(e => e.ApTot).HasColumnName("AP_TOT");
        });

        modelBuilder.Entity<CtRetencion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_RETENCION");

            entity.Property(e => e.ReDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_DESC");
            entity.Property(e => e.ReEmpid).HasColumnName("RE_EMPID");
            entity.Property(e => e.ReFecha)
                .HasColumnType("datetime")
                .HasColumnName("RE_FECHA");
            entity.Property(e => e.ReImpR)
                .HasColumnType("money")
                .HasColumnName("RE_IMP_R");
            entity.Property(e => e.ReImpT)
                .HasColumnType("money")
                .HasColumnName("RE_IMP_T");
            entity.Property(e => e.ReImpit)
                .HasColumnType("money")
                .HasColumnName("RE_IMPIT");
            entity.Property(e => e.ReImpiue)
                .HasColumnType("money")
                .HasColumnName("RE_IMPIUE");
            entity.Property(e => e.ReNum).HasColumnName("RE_NUM");
            entity.Property(e => e.ReProvee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_PROVEE");
            entity.Property(e => e.ReRec)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_REC");
            entity.Property(e => e.ReSertra).HasColumnName("RE_SERTRA");
            entity.Property(e => e.ReSuc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_SUC");
            entity.Property(e => e.ReTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_TIP");
            entity.Property(e => e.ReTipd)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_TIPD");
        });

        modelBuilder.Entity<CtSaldo>(entity =>
        {
            entity.HasKey(e => e.SaSerie);

            entity.ToTable("CT_SALDOS");

            entity.Property(e => e.SaSerie).HasColumnName("SA_SERIE");
            entity.Property(e => e.Sa)
                .HasColumnType("money")
                .HasColumnName("SA");
            entity.Property(e => e.SaAct)
                .HasColumnType("money")
                .HasColumnName("SA_ACT");
            entity.Property(e => e.SaGa)
                .HasColumnType("money")
                .HasColumnName("SA_GA");
            entity.Property(e => e.SaGn)
                .HasColumnType("money")
                .HasColumnName("SA_GN");
            entity.Property(e => e.SaP)
                .HasColumnType("money")
                .HasColumnName("SA_P");
            entity.Property(e => e.SaSeraux).HasColumnName("SA_SERAUX");
            entity.Property(e => e.SaSercta).HasColumnName("SA_SERCTA");
        });

        modelBuilder.Entity<CtSubcta>(entity =>
        {
            entity.HasKey(e => e.SuSerie);

            entity.ToTable("CT_SUBCTAS");

            entity.Property(e => e.SuSerie).HasColumnName("SU_SERIE");
            entity.Property(e => e.SuCi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("SU_CI");
            entity.Property(e => e.SuClub).HasColumnName("SU_CLUB");
            entity.Property(e => e.SuCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("SU_COD");
            entity.Property(e => e.SuDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("SU_DESC");
            entity.Property(e => e.SuDetalle)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_DETALLE");
            entity.Property(e => e.SuEmi)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("SU_EMI");
            entity.Property(e => e.SuEmpid).HasColumnName("SU_EMPID");
            entity.Property(e => e.SuNit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("SU_NIT");
            entity.Property(e => e.SuSuc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_SUC");
        });

        modelBuilder.Entity<CtSubctasEc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_SUBCTAS_EC");

            entity.Property(e => e.SuCc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_CC");
            entity.Property(e => e.SuDbe)
                .HasColumnType("money")
                .HasColumnName("SU_DBE");
            entity.Property(e => e.SuDbn)
                .HasColumnType("money")
                .HasColumnName("SU_DBN");
            entity.Property(e => e.SuDoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_DOC");
            entity.Property(e => e.SuFec)
                .HasColumnType("datetime")
                .HasColumnName("SU_FEC");
            entity.Property(e => e.SuGlosa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_GLOSA");
            entity.Property(e => e.SuHbe)
                .HasColumnType("money")
                .HasColumnName("SU_HBE");
            entity.Property(e => e.SuHbn)
                .HasColumnType("money")
                .HasColumnName("SU_HBN");
            entity.Property(e => e.SuIdc).HasColumnName("SU_IDC");
            entity.Property(e => e.SuIdop).HasColumnName("SU_IDOP");
            entity.Property(e => e.SuIdp).HasColumnName("SU_IDP");
            entity.Property(e => e.SuIds).HasColumnName("SU_IDS");
            entity.Property(e => e.SuIdt).HasColumnName("SU_IDT");
            entity.Property(e => e.SuNivel).HasColumnName("SU_NIVEL");
            entity.Property(e => e.SuNum).HasColumnName("SU_NUM");
            entity.Property(e => e.SuRef)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_REF");
            entity.Property(e => e.SuSaldoe)
                .HasColumnType("money")
                .HasColumnName("SU_SALDOE");
            entity.Property(e => e.SuSaldon)
                .HasColumnType("money")
                .HasColumnName("SU_SALDON");
            entity.Property(e => e.SuTc)
                .HasColumnType("money")
                .HasColumnName("SU_TC");
            entity.Property(e => e.SuTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SU_TIP");
        });

        modelBuilder.Entity<CtSubctasEc1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_SUBCTAS_EC_");

            entity.Property(e => e.SuCc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_CC");
            entity.Property(e => e.SuIdc).HasColumnName("SU_IDC");
            entity.Property(e => e.SuIdop).HasColumnName("SU_IDOP");
            entity.Property(e => e.SuIds).HasColumnName("SU_IDS");
            entity.Property(e => e.SuSaldoe)
                .HasColumnType("money")
                .HasColumnName("SU_SALDOE");
            entity.Property(e => e.SuSaldon)
                .HasColumnType("money")
                .HasColumnName("SU_SALDON");
            entity.Property(e => e.SuSale)
                .HasColumnType("money")
                .HasColumnName("SU_SALE");
            entity.Property(e => e.SuSaln)
                .HasColumnType("money")
                .HasColumnName("SU_SALN");
        });

        modelBuilder.Entity<CtSubctasEc2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_SUBCTAS_EC__");

            entity.Property(e => e.SuCc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_CC");
            entity.Property(e => e.SuIdc).HasColumnName("SU_IDC");
            entity.Property(e => e.SuIdop).HasColumnName("SU_IDOP");
            entity.Property(e => e.SuSale)
                .HasColumnType("money")
                .HasColumnName("SU_SALE");
            entity.Property(e => e.SuSaln)
                .HasColumnType("money")
                .HasColumnName("SU_SALN");
        });

        modelBuilder.Entity<CtSubctasEcCc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_SUBCTAS_EC_CC");

            entity.Property(e => e.SuCc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_CC");
            entity.Property(e => e.SuIdop).HasColumnName("SU_IDOP");
            entity.Property(e => e.SuNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SU_NOM");
            entity.Property(e => e.SuSale)
                .HasColumnType("money")
                .HasColumnName("SU_SALE");
            entity.Property(e => e.SuSaln)
                .HasColumnType("money")
                .HasColumnName("SU_SALN");
        });

        modelBuilder.Entity<CtSucursal>(entity =>
        {
            entity.HasKey(e => e.SuId);

            entity.ToTable("CT_SUCURSAL");

            entity.Property(e => e.SuId).HasColumnName("SU_ID");
            entity.Property(e => e.SuAlmacen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SU_ALMACEN");
            entity.Property(e => e.SuCod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SU_COD");
            entity.Property(e => e.SuCtaco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SU_CTACO");
            entity.Property(e => e.SuCtave)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SU_CTAVE");
            entity.Property(e => e.SuEmpid).HasColumnName("SU_EMPID");
            entity.Property(e => e.SuNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SU_NOMBRE");
            entity.Property(e => e.SuSucde)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SU_SUCDE");
        });

        modelBuilder.Entity<CtTesoro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TESORO");

            entity.Property(e => e.TsCta).HasColumnName("TS_CTA");
            entity.Property(e => e.TsTipo)
                .HasMaxLength(1)
                .HasColumnName("TS_TIPO");
        });

        modelBuilder.Entity<CtTipcambio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TIPCAMBIO");

            entity.Property(e => e.TcAct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TC_ACT");
            entity.Property(e => e.TcBolsin)
                .HasColumnType("money")
                .HasColumnName("TC_BOLSIN");
            entity.Property(e => e.TcCompra)
                .HasColumnType("money")
                .HasColumnName("TC_COMPRA");
            entity.Property(e => e.TcFecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("TC_FECHA");
            entity.Property(e => e.TcUfv).HasColumnName("TC_UFV");
            entity.Property(e => e.TcVenta)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("TC_VENTA");
        });

        modelBuilder.Entity<CtTipodoc>(entity =>
        {
            entity.HasKey(e => e.TdId);

            entity.ToTable("CT_TIPODOC");

            entity.Property(e => e.TdId).HasColumnName("TD_ID");
            entity.Property(e => e.TdCorr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TD_CORR");
            entity.Property(e => e.TdEmpid).HasColumnName("TD_EMPID");
            entity.Property(e => e.TdFirma1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TD_FIRMA1");
            entity.Property(e => e.TdFirma2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TD_FIRMA2");
            entity.Property(e => e.TdFirma3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TD_FIRMA3");
            entity.Property(e => e.TdFirma4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TD_FIRMA4");
            entity.Property(e => e.TdFormato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('D')")
                .HasColumnName("TD_FORMATO");
            entity.Property(e => e.TdNombre)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("TD_NOMBRE");
            entity.Property(e => e.TdOrden).HasColumnName("TD_ORDEN");
            entity.Property(e => e.TdPersona)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TD_PERSONA");
            entity.Property(e => e.TdSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('C')")
                .HasColumnName("TD_SIST");
            entity.Property(e => e.TdTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TD_TIPO");
        });

        modelBuilder.Entity<CtTransa>(entity =>
        {
            entity.HasKey(e => e.TrSerie);

            entity.ToTable("CT_TRANSA");

            entity.Property(e => e.TrSerie).HasColumnName("TR_SERIE");
            entity.Property(e => e.TrCcosto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TR_CCOSTO");
            entity.Property(e => e.TrCodin)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_CODIN");
            entity.Property(e => e.TrCorr).HasColumnName("TR_CORR");
            entity.Property(e => e.TrDref)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TR_DREF");
            entity.Property(e => e.TrEfe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_EFE");
            entity.Property(e => e.TrFec)
                .HasColumnType("datetime")
                .HasColumnName("TR_FEC");
            entity.Property(e => e.TrGlosa)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("TR_GLOSA");
            entity.Property(e => e.TrId).HasColumnName("TR_ID");
            entity.Property(e => e.TrIdtra).HasColumnName("TR_IDTRA");
            entity.Property(e => e.TrMe)
                .HasColumnType("money")
                .HasColumnName("TR_ME");
            entity.Property(e => e.TrMn)
                .HasColumnType("money")
                .HasColumnName("TR_MN");
            entity.Property(e => e.TrObj).HasColumnName("TR_OBJ");
            entity.Property(e => e.TrScta).HasColumnName("TR_SCTA");
            entity.Property(e => e.TrSercta).HasColumnName("TR_SERCTA");
            entity.Property(e => e.TrUfv).HasColumnName("TR_UFV");
            entity.Property(e => e.TrUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_USER");
        });

        modelBuilder.Entity<CtTransa2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TRANSA2");

            entity.Property(e => e.T2Fecha)
                .HasColumnType("datetime")
                .HasColumnName("T2_FECHA");
            entity.Property(e => e.T2Sersald).HasColumnName("T2_SERSALD");
            entity.Property(e => e.T2Sertra).HasColumnName("T2_SERTRA");
        });

        modelBuilder.Entity<CtTransaA>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TRANSA_A");

            entity.Property(e => e.TrFecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("TR_FECHA");
            entity.Property(e => e.TrMe)
                .HasColumnType("money")
                .HasColumnName("TR_ME");
            entity.Property(e => e.TrMn)
                .HasColumnType("money")
                .HasColumnName("TR_MN");
            entity.Property(e => e.TrSerAf).HasColumnName("TR_SER_AF");
            entity.Property(e => e.TrSertra).HasColumnName("TR_SERTRA");
        });

        modelBuilder.Entity<CtTransaAct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TRANSA_ACT");

            entity.Property(e => e.T2Fecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("T2_FECHA");
            entity.Property(e => e.T2Mn)
                .HasColumnType("money")
                .HasColumnName("T2_MN");
            entity.Property(e => e.T2SerAf).HasColumnName("T2_SER_AF");
            entity.Property(e => e.T2Sertra).HasColumnName("T2_SERTRA");
        });

        modelBuilder.Entity<CtTransaNulo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TRANSA_NULO");

            entity.Property(e => e.TrCorr).HasColumnName("TR_CORR");
            entity.Property(e => e.TrDpto).HasColumnName("TR_DPTO");
            entity.Property(e => e.TrFec)
                .HasColumnType("datetime")
                .HasColumnName("TR_FEC");
            entity.Property(e => e.TrGlosa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TR_GLOSA");
            entity.Property(e => e.TrId).HasColumnName("TR_ID");
            entity.Property(e => e.TrMe)
                .HasColumnType("money")
                .HasColumnName("TR_ME");
            entity.Property(e => e.TrMn)
                .HasColumnType("money")
                .HasColumnName("TR_MN");
            entity.Property(e => e.TrObj).HasColumnName("TR_OBJ");
            entity.Property(e => e.TrSercta).HasColumnName("TR_SERCTA");
            entity.Property(e => e.TrSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("TR_SERIE");
        });

        modelBuilder.Entity<CtTransaR>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TRANSA_R");

            entity.Property(e => e.TrCcosto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TR_CCOSTO");
            entity.Property(e => e.TrCorr).HasColumnName("TR_CORR");
            entity.Property(e => e.TrGlosa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TR_GLOSA");
            entity.Property(e => e.TrIddoc).HasColumnName("TR_IDDOC");
            entity.Property(e => e.TrMe)
                .HasColumnType("money")
                .HasColumnName("TR_ME");
            entity.Property(e => e.TrMn)
                .HasColumnType("money")
                .HasColumnName("TR_MN");
            entity.Property(e => e.TrObj).HasColumnName("TR_OBJ");
            entity.Property(e => e.TrRefe)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TR_REFE");
            entity.Property(e => e.TrSeraux).HasColumnName("TR_SERAUX");
            entity.Property(e => e.TrSercta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TR_SERCTA");
            entity.Property(e => e.TrSerial)
                .ValueGeneratedOnAdd()
                .HasColumnName("TR_SERIAL");
        });

        modelBuilder.Entity<CtTransapre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_TRANSAPRE");

            entity.Property(e => e.TpArea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TP_AREA");
            entity.Property(e => e.TpCo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TP_CO");
            entity.Property(e => e.TpDpto).HasColumnName("TP_DPTO");
            entity.Property(e => e.TpSertra).HasColumnName("TP_SERTRA");
        });

        modelBuilder.Entity<CtUpsaldo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_UPSALDOS");

            entity.Property(e => e.AcAm).HasColumnName("AC_AM");
            entity.Property(e => e.AcFecha)
                .HasColumnType("smalldatetime")
                .HasColumnName("AC_FECHA");
            entity.Property(e => e.AcPm).HasColumnName("AC_PM");
            entity.Property(e => e.AcSuc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AC_SUC");
        });

        modelBuilder.Entity<CtUsofina>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_USOFINA");

            entity.Property(e => e.FiDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FI_DESC");
            entity.Property(e => e.FiSercta).HasColumnName("FI_SERCTA");
        });

        modelBuilder.Entity<CtUsrDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CT_USR_DOC");

            entity.Property(e => e.UdConsulta).HasColumnName("UD_CONSULTA");
            entity.Property(e => e.UdCorrelativo).HasColumnName("UD_CORRELATIVO");
            entity.Property(e => e.UdCrea).HasColumnName("UD_CREA");
            entity.Property(e => e.UdDoc).HasColumnName("UD_DOC");
            entity.Property(e => e.UdElim).HasColumnName("UD_ELIM");
            entity.Property(e => e.UdFecha).HasColumnName("UD_FECHA");
            entity.Property(e => e.UdModif).HasColumnName("UD_MODIF");
            entity.Property(e => e.UdSupervisar).HasColumnName("UD_SUPERVISAR");
            entity.Property(e => e.UdTc).HasColumnName("UD_TC");
            entity.Property(e => e.UdUsr).HasColumnName("UD_USR");
        });

        modelBuilder.Entity<FcActividad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ACTIVIDAD");

            entity.HasIndex(e => e.AcCod, "IDX_COD");

            entity.HasIndex(e => e.AcDesc, "IDX_DESC");

            entity.Property(e => e.AcCod).HasColumnName("AC_COD");
            entity.Property(e => e.AcDesc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AC_DESC");
        });

        modelBuilder.Entity<FcAjustfac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_AJUSTFAC");

            entity.HasIndex(e => new { e.AfMes, e.AfAño, e.AfCli }, "IX_FC_AJUSTFAC");

            entity.HasIndex(e => new { e.AfMes, e.AfAño, e.AfCli, e.AfTipo }, "IX_FC_AJUSTFAC_1");

            entity.HasIndex(e => e.AfTipo, "IX_FC_AJUSTFAC_2");

            entity.HasIndex(e => new { e.AfSerfacO, e.AfNumfacO, e.AfCli }, "IX_FC_AJUSTFAC_3");

            entity.HasIndex(e => new { e.AfSerfacR, e.AfNumfacR, e.AfCli }, "IX_FC_AJUSTFAC_4");

            entity.HasIndex(e => new { e.AfSerfacO, e.AfNumfacO, e.AfMes, e.AfAño, e.AfCli, e.AfTipo }, "IX_FC_AJUSTFAC_5");

            entity.HasIndex(e => new { e.AfSerfacR, e.AfNumfacR, e.AfMes, e.AfAño, e.AfCli, e.AfTipo }, "IX_FC_AJUSTFAC_6");

            entity.HasIndex(e => e.AfFecaju, "IX_FC_AJUSTFAC_7");

            entity.HasIndex(e => new { e.AfFecaju, e.AfMes, e.AfAño, e.AfCli }, "IX_FC_AJUSTFAC_8");

            entity.Property(e => e.AfAmountn)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("AF_AMOUNTN");
            entity.Property(e => e.AfAmounto)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("AF_AMOUNTO");
            entity.Property(e => e.AfAño).HasColumnName("AF_AÑO");
            entity.Property(e => e.AfCctrlncd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AF_CCTRLNCD");
            entity.Property(e => e.AfCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AF_CLI");
            entity.Property(e => e.AfDosidncd)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AF_DOSIDNCD");
            entity.Property(e => e.AfDosseqncd)
                .HasDefaultValueSql("((0))")
                .HasColumnName("AF_DOSSEQNCD");
            entity.Property(e => e.AfFecaju)
                .HasColumnType("datetime")
                .HasColumnName("AF_FECAJU");
            entity.Property(e => e.AfMes).HasColumnName("AF_MES");
            entity.Property(e => e.AfNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AF_NITCI");
            entity.Property(e => e.AfNumfacO).HasColumnName("AF_NUMFAC_O");
            entity.Property(e => e.AfNumfacR).HasColumnName("AF_NUMFAC_R");
            entity.Property(e => e.AfSerfacO).HasColumnName("AF_SERFAC_O");
            entity.Property(e => e.AfSerfacR).HasColumnName("AF_SERFAC_R");
            entity.Property(e => e.AfTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AF_TIPO");
        });

        modelBuilder.Entity<FcAlta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTAS");

            entity.HasIndex(e => new { e.FcMes, e.FcAño }, "IX_FC_ALTAS");

            entity.HasIndex(e => new { e.FcFecl, e.FcEstf }, "IX_FC_ALTAS_1");

            entity.HasIndex(e => new { e.FcSer, e.FcNum }, "IX_FC_ALTAS_10");

            entity.HasIndex(e => e.FcCli, "IX_FC_ALTAS_2");

            entity.HasIndex(e => new { e.FcObs1, e.FcObs2 }, "IX_FC_ALTAS_3");

            entity.HasIndex(e => e.FcCaj, "IX_FC_ALTAS_4");

            entity.HasIndex(e => new { e.FcCaj, e.FcPag, e.FcEstf }, "IX_FC_ALTAS_5");

            entity.HasIndex(e => new { e.FcEstf, e.FcPag }, "IX_FC_ALTAS_6");

            entity.HasIndex(e => new { e.FcEstf, e.FcMes, e.FcAño, e.FcIt, e.FcArea, e.FcCic, e.FcSec, e.FcRut }, "IX_FC_ALTAS_7");

            entity.HasIndex(e => new { e.FcEstfant, e.FcPag }, "IX_FC_ALTAS_8");

            entity.HasIndex(e => new { e.FcSer, e.FcCaj }, "IX_FC_ALTAS_9");

            entity.Property(e => e.FcAlc)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("FC_ALC");
            entity.Property(e => e.FcApcf)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("FC_APCF");
            entity.Property(e => e.FcApcv)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("FC_APCV");
            entity.Property(e => e.FcArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_AREA");
            entity.Property(e => e.FcAño)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CAJ");
            entity.Property(e => e.FcCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CCONTROL");
            entity.Property(e => e.FcCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CIC");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcClid).HasColumnName("FC_CLID");
            entity.Property(e => e.FcCon)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_CON");
            entity.Property(e => e.FcEstf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("FC_ESTF");
            entity.Property(e => e.FcEstfant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_ESTFANT");
            entity.Property(e => e.FcEstl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('P')")
                .HasColumnName("FC_ESTL");
            entity.Property(e => e.FcFecf)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECF");
            entity.Property(e => e.FcFecl)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECL");
            entity.Property(e => e.FcFecproc)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECPROC");
            entity.Property(e => e.FcFecrefanu)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECREFANU");
            entity.Property(e => e.FcIdrefanu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_IDREFANU");
            entity.Property(e => e.FcImpPre)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_IMP_PRE");
            entity.Property(e => e.FcIt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_IT");
            entity.Property(e => e.FcLec)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_LEC");
            entity.Property(e => e.FcLecant).HasColumnName("FC_LECANT");
            entity.Property(e => e.FcMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_MEDIDOR");
            entity.Property(e => e.FcMes)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_MES");
            entity.Property(e => e.FcName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_NAME");
            entity.Property(e => e.FcNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_NITCI");
            entity.Property(e => e.FcNum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_NUM");
            entity.Property(e => e.FcObs1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_OBS1");
            entity.Property(e => e.FcObs2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_OBS2");
            entity.Property(e => e.FcPag)
                .HasColumnType("datetime")
                .HasColumnName("FC_PAG");
            entity.Property(e => e.FcRc)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("FC_RC");
            entity.Property(e => e.FcRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_RUT");
            entity.Property(e => e.FcSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_SEC");
            entity.Property(e => e.FcSeqpre)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_SEQPRE");
            entity.Property(e => e.FcSer)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_SER");
            entity.Property(e => e.FcSw)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FC_SW");
            entity.Property(e => e.FcTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAL");
            entity.Property(e => e.FcTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_TARAP");
        });

        modelBuilder.Entity<FcAltasavg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTASAVG");

            entity.HasIndex(e => new { e.FcAño, e.FcMes }, "IX_FC_ALTASAVG_01").IsClustered();

            entity.Property(e => e.FcAvg).HasColumnName("FC_AVG");
            entity.Property(e => e.FcAño).HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcCon).HasColumnName("FC_CON");
            entity.Property(e => e.FcMes).HasColumnName("FC_MES");
            entity.Property(e => e.FcN).HasColumnName("FC_N");
            entity.Property(e => e.FcPer)
                .HasColumnType("datetime")
                .HasColumnName("FC_PER");
        });

        modelBuilder.Entity<FcAltasbk20170914>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTASBK20170914");

            entity.Property(e => e.FcAlc)
                .HasColumnType("money")
                .HasColumnName("FC_ALC");
            entity.Property(e => e.FcApcf)
                .HasColumnType("money")
                .HasColumnName("FC_APCF");
            entity.Property(e => e.FcApcv)
                .HasColumnType("money")
                .HasColumnName("FC_APCV");
            entity.Property(e => e.FcArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_AREA");
            entity.Property(e => e.FcAño).HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FC_CAJ");
            entity.Property(e => e.FcCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CCONTROL");
            entity.Property(e => e.FcCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_CIC");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcClid).HasColumnName("FC_CLID");
            entity.Property(e => e.FcCon).HasColumnName("FC_CON");
            entity.Property(e => e.FcEstf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTF");
            entity.Property(e => e.FcEstfant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTFANT");
            entity.Property(e => e.FcEstl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTL");
            entity.Property(e => e.FcFecf)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECF");
            entity.Property(e => e.FcFecl)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECL");
            entity.Property(e => e.FcFecrefanu)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECREFANU");
            entity.Property(e => e.FcIdrefanu).HasColumnName("FC_IDREFANU");
            entity.Property(e => e.FcImpPre).HasColumnName("FC_IMP_PRE");
            entity.Property(e => e.FcIt).HasColumnName("FC_IT");
            entity.Property(e => e.FcLec).HasColumnName("FC_LEC");
            entity.Property(e => e.FcLecant).HasColumnName("FC_LECANT");
            entity.Property(e => e.FcMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_MEDIDOR");
            entity.Property(e => e.FcMes).HasColumnName("FC_MES");
            entity.Property(e => e.FcNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_NITCI");
            entity.Property(e => e.FcNum).HasColumnName("FC_NUM");
            entity.Property(e => e.FcObs1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS1");
            entity.Property(e => e.FcObs2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS2");
            entity.Property(e => e.FcPag)
                .HasColumnType("datetime")
                .HasColumnName("FC_PAG");
            entity.Property(e => e.FcRc)
                .HasColumnType("money")
                .HasColumnName("FC_RC");
            entity.Property(e => e.FcRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_RUT");
            entity.Property(e => e.FcSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_SEC");
            entity.Property(e => e.FcSeqpre).HasColumnName("FC_SEQPRE");
            entity.Property(e => e.FcSer).HasColumnName("FC_SER");
            entity.Property(e => e.FcSw).HasColumnName("FC_SW");
            entity.Property(e => e.FcTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAL");
            entity.Property(e => e.FcTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAP");
        });

        modelBuilder.Entity<FcAltasbk20170922>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTASBK20170922");

            entity.Property(e => e.FcAlc)
                .HasColumnType("money")
                .HasColumnName("FC_ALC");
            entity.Property(e => e.FcApcf)
                .HasColumnType("money")
                .HasColumnName("FC_APCF");
            entity.Property(e => e.FcApcv)
                .HasColumnType("money")
                .HasColumnName("FC_APCV");
            entity.Property(e => e.FcArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_AREA");
            entity.Property(e => e.FcAño).HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FC_CAJ");
            entity.Property(e => e.FcCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CCONTROL");
            entity.Property(e => e.FcCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_CIC");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcClid).HasColumnName("FC_CLID");
            entity.Property(e => e.FcCon).HasColumnName("FC_CON");
            entity.Property(e => e.FcEstf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTF");
            entity.Property(e => e.FcEstfant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTFANT");
            entity.Property(e => e.FcEstl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTL");
            entity.Property(e => e.FcFecf)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECF");
            entity.Property(e => e.FcFecl)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECL");
            entity.Property(e => e.FcFecrefanu)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECREFANU");
            entity.Property(e => e.FcIdrefanu).HasColumnName("FC_IDREFANU");
            entity.Property(e => e.FcImpPre).HasColumnName("FC_IMP_PRE");
            entity.Property(e => e.FcIt).HasColumnName("FC_IT");
            entity.Property(e => e.FcLec).HasColumnName("FC_LEC");
            entity.Property(e => e.FcLecant).HasColumnName("FC_LECANT");
            entity.Property(e => e.FcMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_MEDIDOR");
            entity.Property(e => e.FcMes).HasColumnName("FC_MES");
            entity.Property(e => e.FcNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_NITCI");
            entity.Property(e => e.FcNum).HasColumnName("FC_NUM");
            entity.Property(e => e.FcObs1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS1");
            entity.Property(e => e.FcObs2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS2");
            entity.Property(e => e.FcPag)
                .HasColumnType("datetime")
                .HasColumnName("FC_PAG");
            entity.Property(e => e.FcRc)
                .HasColumnType("money")
                .HasColumnName("FC_RC");
            entity.Property(e => e.FcRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_RUT");
            entity.Property(e => e.FcSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_SEC");
            entity.Property(e => e.FcSeqpre).HasColumnName("FC_SEQPRE");
            entity.Property(e => e.FcSer).HasColumnName("FC_SER");
            entity.Property(e => e.FcSw).HasColumnName("FC_SW");
            entity.Property(e => e.FcTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAL");
            entity.Property(e => e.FcTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAP");
        });

        modelBuilder.Entity<FcAltasbk20171004>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTASBK20171004");

            entity.Property(e => e.FcAlc)
                .HasColumnType("money")
                .HasColumnName("FC_ALC");
            entity.Property(e => e.FcApcf)
                .HasColumnType("money")
                .HasColumnName("FC_APCF");
            entity.Property(e => e.FcApcv)
                .HasColumnType("money")
                .HasColumnName("FC_APCV");
            entity.Property(e => e.FcArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_AREA");
            entity.Property(e => e.FcAño).HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FC_CAJ");
            entity.Property(e => e.FcCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CCONTROL");
            entity.Property(e => e.FcCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_CIC");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcClid).HasColumnName("FC_CLID");
            entity.Property(e => e.FcCon).HasColumnName("FC_CON");
            entity.Property(e => e.FcEstf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTF");
            entity.Property(e => e.FcEstfant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTFANT");
            entity.Property(e => e.FcEstl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTL");
            entity.Property(e => e.FcFecf)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECF");
            entity.Property(e => e.FcFecl)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECL");
            entity.Property(e => e.FcFecrefanu)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECREFANU");
            entity.Property(e => e.FcIdrefanu).HasColumnName("FC_IDREFANU");
            entity.Property(e => e.FcImpPre).HasColumnName("FC_IMP_PRE");
            entity.Property(e => e.FcIt).HasColumnName("FC_IT");
            entity.Property(e => e.FcLec).HasColumnName("FC_LEC");
            entity.Property(e => e.FcLecant).HasColumnName("FC_LECANT");
            entity.Property(e => e.FcMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_MEDIDOR");
            entity.Property(e => e.FcMes).HasColumnName("FC_MES");
            entity.Property(e => e.FcName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FC_NAME");
            entity.Property(e => e.FcNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_NITCI");
            entity.Property(e => e.FcNum).HasColumnName("FC_NUM");
            entity.Property(e => e.FcObs1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS1");
            entity.Property(e => e.FcObs2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS2");
            entity.Property(e => e.FcPag)
                .HasColumnType("datetime")
                .HasColumnName("FC_PAG");
            entity.Property(e => e.FcRc)
                .HasColumnType("money")
                .HasColumnName("FC_RC");
            entity.Property(e => e.FcRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_RUT");
            entity.Property(e => e.FcSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_SEC");
            entity.Property(e => e.FcSeqpre).HasColumnName("FC_SEQPRE");
            entity.Property(e => e.FcSer).HasColumnName("FC_SER");
            entity.Property(e => e.FcSw).HasColumnName("FC_SW");
            entity.Property(e => e.FcTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAL");
            entity.Property(e => e.FcTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAP");
        });

        modelBuilder.Entity<FcAltasbk20171006>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTASBK20171006");

            entity.Property(e => e.FcAlc)
                .HasColumnType("money")
                .HasColumnName("FC_ALC");
            entity.Property(e => e.FcApcf)
                .HasColumnType("money")
                .HasColumnName("FC_APCF");
            entity.Property(e => e.FcApcv)
                .HasColumnType("money")
                .HasColumnName("FC_APCV");
            entity.Property(e => e.FcArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_AREA");
            entity.Property(e => e.FcAño).HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FC_CAJ");
            entity.Property(e => e.FcCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CCONTROL");
            entity.Property(e => e.FcCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_CIC");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcClid).HasColumnName("FC_CLID");
            entity.Property(e => e.FcCon).HasColumnName("FC_CON");
            entity.Property(e => e.FcEstf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTF");
            entity.Property(e => e.FcEstfant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTFANT");
            entity.Property(e => e.FcEstl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTL");
            entity.Property(e => e.FcFecf)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECF");
            entity.Property(e => e.FcFecl)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECL");
            entity.Property(e => e.FcFecrefanu)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECREFANU");
            entity.Property(e => e.FcIdrefanu).HasColumnName("FC_IDREFANU");
            entity.Property(e => e.FcImpPre).HasColumnName("FC_IMP_PRE");
            entity.Property(e => e.FcIt).HasColumnName("FC_IT");
            entity.Property(e => e.FcLec).HasColumnName("FC_LEC");
            entity.Property(e => e.FcLecant).HasColumnName("FC_LECANT");
            entity.Property(e => e.FcMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_MEDIDOR");
            entity.Property(e => e.FcMes).HasColumnName("FC_MES");
            entity.Property(e => e.FcName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FC_NAME");
            entity.Property(e => e.FcNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_NITCI");
            entity.Property(e => e.FcNum).HasColumnName("FC_NUM");
            entity.Property(e => e.FcObs1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS1");
            entity.Property(e => e.FcObs2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS2");
            entity.Property(e => e.FcPag)
                .HasColumnType("datetime")
                .HasColumnName("FC_PAG");
            entity.Property(e => e.FcRc)
                .HasColumnType("money")
                .HasColumnName("FC_RC");
            entity.Property(e => e.FcRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_RUT");
            entity.Property(e => e.FcSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_SEC");
            entity.Property(e => e.FcSeqpre).HasColumnName("FC_SEQPRE");
            entity.Property(e => e.FcSer).HasColumnName("FC_SER");
            entity.Property(e => e.FcSw).HasColumnName("FC_SW");
            entity.Property(e => e.FcTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAL");
            entity.Property(e => e.FcTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAP");
        });

        modelBuilder.Entity<FcAltasbk20171130>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTASBK20171130");

            entity.Property(e => e.FcAlc)
                .HasColumnType("money")
                .HasColumnName("FC_ALC");
            entity.Property(e => e.FcApcf)
                .HasColumnType("money")
                .HasColumnName("FC_APCF");
            entity.Property(e => e.FcApcv)
                .HasColumnType("money")
                .HasColumnName("FC_APCV");
            entity.Property(e => e.FcArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_AREA");
            entity.Property(e => e.FcAño).HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FC_CAJ");
            entity.Property(e => e.FcCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CCONTROL");
            entity.Property(e => e.FcCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_CIC");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcClid).HasColumnName("FC_CLID");
            entity.Property(e => e.FcCon).HasColumnName("FC_CON");
            entity.Property(e => e.FcEstf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTF");
            entity.Property(e => e.FcEstfant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTFANT");
            entity.Property(e => e.FcEstl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FC_ESTL");
            entity.Property(e => e.FcFecf)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECF");
            entity.Property(e => e.FcFecl)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECL");
            entity.Property(e => e.FcFecproc)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECPROC");
            entity.Property(e => e.FcFecrefanu)
                .HasColumnType("datetime")
                .HasColumnName("FC_FECREFANU");
            entity.Property(e => e.FcIdrefanu).HasColumnName("FC_IDREFANU");
            entity.Property(e => e.FcImpPre).HasColumnName("FC_IMP_PRE");
            entity.Property(e => e.FcIt).HasColumnName("FC_IT");
            entity.Property(e => e.FcLec).HasColumnName("FC_LEC");
            entity.Property(e => e.FcLecant).HasColumnName("FC_LECANT");
            entity.Property(e => e.FcMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_MEDIDOR");
            entity.Property(e => e.FcMes).HasColumnName("FC_MES");
            entity.Property(e => e.FcName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FC_NAME");
            entity.Property(e => e.FcNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_NITCI");
            entity.Property(e => e.FcNum).HasColumnName("FC_NUM");
            entity.Property(e => e.FcObs1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS1");
            entity.Property(e => e.FcObs2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_OBS2");
            entity.Property(e => e.FcPag)
                .HasColumnType("datetime")
                .HasColumnName("FC_PAG");
            entity.Property(e => e.FcRc)
                .HasColumnType("money")
                .HasColumnName("FC_RC");
            entity.Property(e => e.FcRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_RUT");
            entity.Property(e => e.FcSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("FC_SEC");
            entity.Property(e => e.FcSeqpre).HasColumnName("FC_SEQPRE");
            entity.Property(e => e.FcSer).HasColumnName("FC_SER");
            entity.Property(e => e.FcSw).HasColumnName("FC_SW");
            entity.Property(e => e.FcTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAL");
            entity.Property(e => e.FcTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FC_TARAP");
        });

        modelBuilder.Entity<FcAltasfixeditem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_ALTASFIXEDITEMS");

            entity.HasIndex(e => e.FcCode, "IX_FC_ALTASFIXEDITEMS_01").IsClustered();

            entity.Property(e => e.FcCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CODE");
            entity.Property(e => e.FcSrvid).HasColumnName("FC_SRVID");
        });

        modelBuilder.Entity<FcArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_AREAS");

            entity.Property(e => e.AaCodare)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("AA_CODARE");
            entity.Property(e => e.AaDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AA_DESC");
            entity.Property(e => e.AaDir)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AA_DIR");
            entity.Property(e => e.AaEst).HasColumnName("AA_EST");
            entity.Property(e => e.AaFileIi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AA_FILE_II");
            entity.Property(e => e.AaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AA_ID");
            entity.Property(e => e.AaSeqCort).HasColumnName("AA_SEQ_CORT");
            entity.Property(e => e.AaSeqPrea).HasColumnName("AA_SEQ_PREA");
            entity.Property(e => e.AaSucIi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AA_SUC_II");
            entity.Property(e => e.AaTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AA_TEL");
        });

        modelBuilder.Entity<FcBeneficiariodv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_BENEFICIARIODV");

            entity.HasIndex(e => new { e.DvGes, e.DvCli }, "IX_FC_CLIENTESDV_01").IsClustered();

            entity.Property(e => e.DvCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_CLI");
            entity.Property(e => e.DvFfin)
                .HasDefaultValueSql("('31/12/2017')")
                .HasColumnType("datetime")
                .HasColumnName("DV_FFIN");
            entity.Property(e => e.DvFing)
                .HasDefaultValueSql("('01/01/2017')")
                .HasColumnType("datetime")
                .HasColumnName("DV_FING");
            entity.Property(e => e.DvFini)
                .HasDefaultValueSql("('01/01/2017')")
                .HasColumnType("datetime")
                .HasColumnName("DV_FINI");
            entity.Property(e => e.DvFnac)
                .HasColumnType("datetime")
                .HasColumnName("DV_FNAC");
            entity.Property(e => e.DvGes)
                .HasDefaultValueSql("((2017))")
                .HasColumnName("DV_GES");
            entity.Property(e => e.DvNdoc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DV_NDOC");
            entity.Property(e => e.DvOrigen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DV_ORIGEN");
            entity.Property(e => e.DvStatus).HasColumnName("DV_STATUS");
            entity.Property(e => e.DvTben)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('D')")
                .HasColumnName("DV_TBEN");
            entity.Property(e => e.DvTdoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_TDOC");
        });

        modelBuilder.Entity<FcBeneficiarioex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_BENEFICIARIOEX");

            entity.HasIndex(e => e.DvCli, "IX_FC_BENEFICIARIOEX_01");

            entity.Property(e => e.DvCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_CLI");
            entity.Property(e => e.DvName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_NAME");
            entity.Property(e => e.DvNdoc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_NDOC");
            entity.Property(e => e.DvObs)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_OBS");
        });

        modelBuilder.Entity<FcCaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CAJAS");

            entity.HasIndex(e => e.CjId, "IX_FC_CAJAS");

            entity.HasIndex(e => e.CjNro, "IX_FC_CAJAS_1");

            entity.Property(e => e.CjAreas)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CJ_AREAS");
            entity.Property(e => e.CjDosenuso)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CJ_DOSENUSO");
            entity.Property(e => e.CjId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CJ_ID");
            entity.Property(e => e.CjIddos)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CJ_IDDOS");
            entity.Property(e => e.CjNro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CJ_NRO");
        });

        modelBuilder.Entity<FcCambioEst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CAMBIO_EST");

            entity.Property(e => e.CeAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CE_AÑO");
            entity.Property(e => e.CeCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CE_COD");
            entity.Property(e => e.CeDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CE_DATE");
            entity.Property(e => e.CeEstAc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CE_EST_AC");
            entity.Property(e => e.CeEstAn)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CE_EST_AN");
            entity.Property(e => e.CeFeclAc)
                .HasColumnType("datetime")
                .HasColumnName("CE_FECL_AC");
            entity.Property(e => e.CeFeclAn)
                .HasColumnType("datetime")
                .HasColumnName("CE_FECL_AN");
            entity.Property(e => e.CeIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CE_IDOP");
            entity.Property(e => e.CeLecAc)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CE_LEC_AC");
            entity.Property(e => e.CeLecAn)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CE_LEC_AN");
            entity.Property(e => e.CeMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CE_MES");
            entity.Property(e => e.CeObs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CE_OBS");
        });

        modelBuilder.Entity<FcCambmedi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CAMBMEDI");

            entity.HasIndex(e => e.CmCtacli, "IDX_CTACLI");

            entity.HasIndex(e => e.CmNombre, "IDX_NOMBRE");

            entity.HasIndex(e => e.CmNroso, "IDX_NROSO");

            entity.Property(e => e.CmCateg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CM_CATEG");
            entity.Property(e => e.CmCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CM_CTACLI");
            entity.Property(e => e.CmDirec)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CM_DIREC");
            entity.Property(e => e.CmFechaf)
                .HasColumnType("datetime")
                .HasColumnName("CM_FECHAF");
            entity.Property(e => e.CmFechai)
                .HasColumnType("datetime")
                .HasColumnName("CM_FECHAI");
            entity.Property(e => e.CmInsp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CM_INSP");
            entity.Property(e => e.CmLectact)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CM_LECTACT");
            entity.Property(e => e.CmLectant)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CM_LECTANT");
            entity.Property(e => e.CmMarcaact)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CM_MARCAACT");
            entity.Property(e => e.CmMarcaant)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CM_MARCAANT");
            entity.Property(e => e.CmNombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("CM_NOMBRE");
            entity.Property(e => e.CmNromedact)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CM_NROMEDACT");
            entity.Property(e => e.CmNromedant)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CM_NROMEDANT");
            entity.Property(e => e.CmNroso).HasColumnName("CM_NROSO");
            entity.Property(e => e.CmRuta)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CM_RUTA");
            entity.Property(e => e.CmSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CM_SIST");
        });

        modelBuilder.Entity<FcCambnomb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CAMBNOMB");

            entity.HasIndex(e => e.CnCtacli, "IDX_CTACLI");

            entity.HasIndex(e => new { e.CnFechai, e.CnFechaf }, "IDX_FECHA");

            entity.HasIndex(e => e.CnNroso, "IDX_NROSO");

            entity.Property(e => e.CnCateg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CN_CATEG");
            entity.Property(e => e.CnCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CN_CTACLI");
            entity.Property(e => e.CnDireccion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CN_DIRECCION");
            entity.Property(e => e.CnFechaf)
                .HasColumnType("datetime")
                .HasColumnName("CN_FECHAF");
            entity.Property(e => e.CnFechai)
                .HasColumnType("datetime")
                .HasColumnName("CN_FECHAI");
            entity.Property(e => e.CnInsp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CN_INSP");
            entity.Property(e => e.CnNombreant)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CN_NOMBREANT");
            entity.Property(e => e.CnNombrenue)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CN_NOMBRENUE");
            entity.Property(e => e.CnNromed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CN_NROMED");
            entity.Property(e => e.CnNroso).HasColumnName("CN_NROSO");
            entity.Property(e => e.CnPoste)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("CN_POSTE");
            entity.Property(e => e.CnSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CN_SIST");
        });

        modelBuilder.Entity<FcCamcateg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CAMCATEG");

            entity.HasIndex(e => e.CcCtacli, "IDX_CTACLI");

            entity.HasIndex(e => new { e.CcFechai, e.CcFechaf }, "IDX_FECHA");

            entity.HasIndex(e => e.CcNroso, "IDX_NROSO");

            entity.Property(e => e.CcCategAlAct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CC_CATEG_AL_ACT");
            entity.Property(e => e.CcCategAlAnt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CC_CATEG_AL_ANT");
            entity.Property(e => e.CcCategact)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CC_CATEGACT");
            entity.Property(e => e.CcCategant)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CC_CATEGANT");
            entity.Property(e => e.CcCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CC_CTACLI");
            entity.Property(e => e.CcDireccion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CC_DIRECCION");
            entity.Property(e => e.CcFechaf)
                .HasColumnType("datetime")
                .HasColumnName("CC_FECHAF");
            entity.Property(e => e.CcFechai)
                .HasColumnType("datetime")
                .HasColumnName("CC_FECHAI");
            entity.Property(e => e.CcInsp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CC_INSP");
            entity.Property(e => e.CcLectura)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CC_LECTURA");
            entity.Property(e => e.CcNombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CC_NOMBRE");
            entity.Property(e => e.CcNromed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CC_NROMED");
            entity.Property(e => e.CcNroso).HasColumnName("CC_NROSO");
            entity.Property(e => e.CcPoste)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CC_POSTE");
            entity.Property(e => e.CcSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CC_SIST");
        });

        modelBuilder.Entity<FcCiclo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CICLOS");

            entity.Property(e => e.CiCodcir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CI_CODCIR");
            entity.Property(e => e.CiDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CI_DESC");
            entity.Property(e => e.CiId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CI_ID");
            entity.Property(e => e.CiIdare).HasColumnName("CI_IDARE");
        });

        modelBuilder.Entity<FcCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CLIENTE");

            entity.HasIndex(e => e.ClCtacli, "IDX_CTACLI");

            entity.HasIndex(e => e.ClPaterno, "IDX_PAT");

            entity.HasIndex(e => new { e.ClCategAp, e.ClCategAl }, "IX_FC_CLIENTE");

            entity.HasIndex(e => e.ClCategAp, "IX_FC_CLIENTE_1");

            entity.HasIndex(e => e.ClCategAl, "IX_FC_CLIENTE_2");

            entity.HasIndex(e => new { e.ClArea, e.ClCiclo, e.ClSector, e.ClRuta, e.ClEstado }, "IX_FC_CLIENTE_3");

            entity.Property(e => e.ClAbaste)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_ABASTE");
            entity.Property(e => e.ClActivi).HasColumnName("CL_ACTIVI");
            entity.Property(e => e.ClArea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_AREA");
            entity.Property(e => e.ClCategAl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CATEG_AL");
            entity.Property(e => e.ClCategAp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CATEG_AP");
            entity.Property(e => e.ClCiclo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_CICLO");
            entity.Property(e => e.ClCirun)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_CIRUN");
            entity.Property(e => e.ClCodred)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_CODRED");
            entity.Property(e => e.ClConexacom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CL_CONEXACOM");
            entity.Property(e => e.ClCostado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_COSTADO");
            entity.Property(e => e.ClCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_CTACLI");
            entity.Property(e => e.ClDiametro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CL_DIAMETRO");
            entity.Property(e => e.ClDiraco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_DIRACO");
            entity.Property(e => e.ClDirec)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CL_DIREC");
            entity.Property(e => e.ClDirentre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRENTRE");
            entity.Property(e => e.ClDiry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRY");
            entity.Property(e => e.ClDpto)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_DPTO");
            entity.Property(e => e.ClEntreaco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_ENTREACO");
            entity.Property(e => e.ClEstaacom)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_ESTAACOM");
            entity.Property(e => e.ClEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CL_ESTADO");
            entity.Property(e => e.ClEstcaja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_ESTCAJA");
            entity.Property(e => e.ClFechai)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHAI");
            entity.Property(e => e.ClFechanac)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHANAC");
            entity.Property(e => e.ClId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CL_ID");
            entity.Property(e => e.ClIspartner)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CL_ISPARTNER");
            entity.Property(e => e.ClItemruta).HasColumnName("CL_ITEMRUTA");
            entity.Property(e => e.ClLey1886)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CL_LEY1886");
            entity.Property(e => e.ClLongacom).HasColumnName("CL_LONGACOM");
            entity.Property(e => e.ClLote)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_LOTE");
            entity.Property(e => e.ClM3ctto)
                .HasColumnType("smallmoney")
                .HasColumnName("CL_M3CTTO");
            entity.Property(e => e.ClManzano)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_MANZANO");
            entity.Property(e => e.ClMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_MATERNO");
            entity.Property(e => e.ClMedi).HasColumnName("CL_MEDI");
            entity.Property(e => e.ClNombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CL_NOMBRE");
            entity.Property(e => e.ClNro)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CL_NRO");
            entity.Property(e => e.ClNroaco)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_NROACO");
            entity.Property(e => e.ClNroctto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_NROCTTO");
            entity.Property(e => e.ClNrodu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CL_NRODU");
            entity.Property(e => e.ClNroflia).HasColumnName("CL_NROFLIA");
            entity.Property(e => e.ClNrogrii)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CL_NROGRII");
            entity.Property(e => e.ClNrogrip)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CL_NROGRIP");
            entity.Property(e => e.ClNrohab).HasColumnName("CL_NROHAB");
            entity.Property(e => e.ClNrohabo).HasColumnName("CL_NROHABO");
            entity.Property(e => e.ClNroino)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CL_NROINO");
            entity.Property(e => e.ClNroperso).HasColumnName("CL_NROPERSO");
            entity.Property(e => e.ClNropisos).HasColumnName("CL_NROPISOS");
            entity.Property(e => e.ClObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_OBS");
            entity.Property(e => e.ClPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_PATERNO");
            entity.Property(e => e.ClPiso)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CL_PISO");
            entity.Property(e => e.ClRazons)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_RAZONS");
            entity.Property(e => e.ClRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_RUC");
            entity.Property(e => e.ClRuta)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_RUTA");
            entity.Property(e => e.ClSector)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_SECTOR");
            entity.Property(e => e.ClServalca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_SERVALCA");
            entity.Property(e => e.ClServaseo).HasColumnName("CL_SERVASEO");
            entity.Property(e => e.ClSocio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_SOCIO");
            entity.Property(e => e.ClTelefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_TELEFONO");
            entity.Property(e => e.ClTipcalza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_TIPCALZA");
            entity.Property(e => e.ClTipocaja)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_TIPOCAJA");
            entity.Property(e => e.ClTipoconst).HasColumnName("CL_TIPOCONST");
            entity.Property(e => e.ClUbcaja).HasColumnName("CL_UBCAJA");
            entity.Property(e => e.ClYaco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_YACO");
            entity.Property(e => e.ClZona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_ZONA");
        });

        modelBuilder.Entity<FcClientebk20170914>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CLIENTEBK20170914");

            entity.Property(e => e.ClAbaste)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_ABASTE");
            entity.Property(e => e.ClActivi).HasColumnName("CL_ACTIVI");
            entity.Property(e => e.ClArea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CL_AREA");
            entity.Property(e => e.ClCategAl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CATEG_AL");
            entity.Property(e => e.ClCategAp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CATEG_AP");
            entity.Property(e => e.ClCiclo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CICLO");
            entity.Property(e => e.ClCirun)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_CIRUN");
            entity.Property(e => e.ClCodred)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CL_CODRED");
            entity.Property(e => e.ClConexacom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CL_CONEXACOM");
            entity.Property(e => e.ClCostado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_COSTADO");
            entity.Property(e => e.ClCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_CTACLI");
            entity.Property(e => e.ClDiametro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CL_DIAMETRO");
            entity.Property(e => e.ClDiraco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRACO");
            entity.Property(e => e.ClDirec)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CL_DIREC");
            entity.Property(e => e.ClDirentre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRENTRE");
            entity.Property(e => e.ClDiry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRY");
            entity.Property(e => e.ClDpto)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CL_DPTO");
            entity.Property(e => e.ClEntreaco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_ENTREACO");
            entity.Property(e => e.ClEstaacom)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_ESTAACOM");
            entity.Property(e => e.ClEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CL_ESTADO");
            entity.Property(e => e.ClEstcaja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_ESTCAJA");
            entity.Property(e => e.ClFechai)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHAI");
            entity.Property(e => e.ClFechanac)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHANAC");
            entity.Property(e => e.ClId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CL_ID");
            entity.Property(e => e.ClItemruta).HasColumnName("CL_ITEMRUTA");
            entity.Property(e => e.ClLey1886).HasColumnName("CL_LEY1886");
            entity.Property(e => e.ClLongacom).HasColumnName("CL_LONGACOM");
            entity.Property(e => e.ClLote)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CL_LOTE");
            entity.Property(e => e.ClM3ctto)
                .HasColumnType("smallmoney")
                .HasColumnName("CL_M3CTTO");
            entity.Property(e => e.ClManzano)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CL_MANZANO");
            entity.Property(e => e.ClMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_MATERNO");
            entity.Property(e => e.ClMedi).HasColumnName("CL_MEDI");
            entity.Property(e => e.ClNombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CL_NOMBRE");
            entity.Property(e => e.ClNro)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CL_NRO");
            entity.Property(e => e.ClNroaco)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CL_NROACO");
            entity.Property(e => e.ClNroctto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CL_NROCTTO");
            entity.Property(e => e.ClNrodu).HasColumnName("CL_NRODU");
            entity.Property(e => e.ClNroflia).HasColumnName("CL_NROFLIA");
            entity.Property(e => e.ClNrogrii).HasColumnName("CL_NROGRII");
            entity.Property(e => e.ClNrogrip).HasColumnName("CL_NROGRIP");
            entity.Property(e => e.ClNrohab).HasColumnName("CL_NROHAB");
            entity.Property(e => e.ClNrohabo).HasColumnName("CL_NROHABO");
            entity.Property(e => e.ClNroino).HasColumnName("CL_NROINO");
            entity.Property(e => e.ClNroperso).HasColumnName("CL_NROPERSO");
            entity.Property(e => e.ClNropisos).HasColumnName("CL_NROPISOS");
            entity.Property(e => e.ClObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CL_OBS");
            entity.Property(e => e.ClPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_PATERNO");
            entity.Property(e => e.ClPiso).HasColumnName("CL_PISO");
            entity.Property(e => e.ClRazons)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_RAZONS");
            entity.Property(e => e.ClRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_RUC");
            entity.Property(e => e.ClRuta)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CL_RUTA");
            entity.Property(e => e.ClSector)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_SECTOR");
            entity.Property(e => e.ClServalca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_SERVALCA");
            entity.Property(e => e.ClServaseo).HasColumnName("CL_SERVASEO");
            entity.Property(e => e.ClSocio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_SOCIO");
            entity.Property(e => e.ClTelefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_TELEFONO");
            entity.Property(e => e.ClTipcalza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_TIPCALZA");
            entity.Property(e => e.ClTipocaja)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_TIPOCAJA");
            entity.Property(e => e.ClTipoconst).HasColumnName("CL_TIPOCONST");
            entity.Property(e => e.ClUbcaja).HasColumnName("CL_UBCAJA");
            entity.Property(e => e.ClYaco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_YACO");
            entity.Property(e => e.ClZona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_ZONA");
        });

        modelBuilder.Entity<FcClientebk20170922>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CLIENTEBK20170922");

            entity.Property(e => e.ClAbaste)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_ABASTE");
            entity.Property(e => e.ClActivi).HasColumnName("CL_ACTIVI");
            entity.Property(e => e.ClArea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CL_AREA");
            entity.Property(e => e.ClCategAl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CATEG_AL");
            entity.Property(e => e.ClCategAp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CATEG_AP");
            entity.Property(e => e.ClCiclo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_CICLO");
            entity.Property(e => e.ClCirun)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_CIRUN");
            entity.Property(e => e.ClCodred)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CL_CODRED");
            entity.Property(e => e.ClConexacom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CL_CONEXACOM");
            entity.Property(e => e.ClCostado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_COSTADO");
            entity.Property(e => e.ClCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_CTACLI");
            entity.Property(e => e.ClDiametro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CL_DIAMETRO");
            entity.Property(e => e.ClDiraco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRACO");
            entity.Property(e => e.ClDirec)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CL_DIREC");
            entity.Property(e => e.ClDirentre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRENTRE");
            entity.Property(e => e.ClDiry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_DIRY");
            entity.Property(e => e.ClDpto)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CL_DPTO");
            entity.Property(e => e.ClEntreaco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_ENTREACO");
            entity.Property(e => e.ClEstaacom)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_ESTAACOM");
            entity.Property(e => e.ClEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CL_ESTADO");
            entity.Property(e => e.ClEstcaja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_ESTCAJA");
            entity.Property(e => e.ClFechai)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHAI");
            entity.Property(e => e.ClFechanac)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHANAC");
            entity.Property(e => e.ClId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CL_ID");
            entity.Property(e => e.ClItemruta).HasColumnName("CL_ITEMRUTA");
            entity.Property(e => e.ClLey1886).HasColumnName("CL_LEY1886");
            entity.Property(e => e.ClLongacom).HasColumnName("CL_LONGACOM");
            entity.Property(e => e.ClLote)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CL_LOTE");
            entity.Property(e => e.ClM3ctto)
                .HasColumnType("smallmoney")
                .HasColumnName("CL_M3CTTO");
            entity.Property(e => e.ClManzano)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CL_MANZANO");
            entity.Property(e => e.ClMaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_MATERNO");
            entity.Property(e => e.ClMedi).HasColumnName("CL_MEDI");
            entity.Property(e => e.ClNombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CL_NOMBRE");
            entity.Property(e => e.ClNro)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CL_NRO");
            entity.Property(e => e.ClNroaco)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CL_NROACO");
            entity.Property(e => e.ClNroctto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CL_NROCTTO");
            entity.Property(e => e.ClNrodu).HasColumnName("CL_NRODU");
            entity.Property(e => e.ClNroflia).HasColumnName("CL_NROFLIA");
            entity.Property(e => e.ClNrogrii).HasColumnName("CL_NROGRII");
            entity.Property(e => e.ClNrogrip).HasColumnName("CL_NROGRIP");
            entity.Property(e => e.ClNrohab).HasColumnName("CL_NROHAB");
            entity.Property(e => e.ClNrohabo).HasColumnName("CL_NROHABO");
            entity.Property(e => e.ClNroino).HasColumnName("CL_NROINO");
            entity.Property(e => e.ClNroperso).HasColumnName("CL_NROPERSO");
            entity.Property(e => e.ClNropisos).HasColumnName("CL_NROPISOS");
            entity.Property(e => e.ClObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("CL_OBS");
            entity.Property(e => e.ClPaterno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_PATERNO");
            entity.Property(e => e.ClPiso).HasColumnName("CL_PISO");
            entity.Property(e => e.ClRazons)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_RAZONS");
            entity.Property(e => e.ClRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_RUC");
            entity.Property(e => e.ClRuta)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CL_RUTA");
            entity.Property(e => e.ClSector)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_SECTOR");
            entity.Property(e => e.ClServalca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_SERVALCA");
            entity.Property(e => e.ClServaseo).HasColumnName("CL_SERVASEO");
            entity.Property(e => e.ClSocio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_SOCIO");
            entity.Property(e => e.ClTelefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_TELEFONO");
            entity.Property(e => e.ClTipcalza)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CL_TIPCALZA");
            entity.Property(e => e.ClTipocaja)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CL_TIPOCAJA");
            entity.Property(e => e.ClTipoconst).HasColumnName("CL_TIPOCONST");
            entity.Property(e => e.ClUbcaja).HasColumnName("CL_UBCAJA");
            entity.Property(e => e.ClYaco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_YACO");
            entity.Property(e => e.ClZona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_ZONA");
        });

        modelBuilder.Entity<FcClinocorte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CLINOCORTE");

            entity.Property(e => e.NcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NC_CLI");
        });

        modelBuilder.Entity<FcClinofact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CLINOFACT");

            entity.HasIndex(e => e.NfCli, "IX_FC_CLINOFACT");

            entity.Property(e => e.NfCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NF_CLI");
        });

        modelBuilder.Entity<FcCobrocaj>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_COBROCAJ");

            entity.HasIndex(e => e.CoCli, "IX_FC_COBROCAJ");

            entity.HasIndex(e => e.CoIdop, "IX_FC_COBROCAJ_1");

            entity.HasIndex(e => new { e.CoCli, e.CoMes, e.CoAño }, "IX_FC_COBROCAJ_2");

            entity.Property(e => e.CoAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_AÑO");
            entity.Property(e => e.CoCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CLI");
            entity.Property(e => e.CoCobrar).HasColumnName("CO_COBRAR");
            entity.Property(e => e.CoEstf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_ESTF");
            entity.Property(e => e.CoFecf)
                .HasColumnType("datetime")
                .HasColumnName("CO_FECF");
            entity.Property(e => e.CoIddos)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_IDDOS");
            entity.Property(e => e.CoIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_IDOP");
            entity.Property(e => e.CoInt)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_INT");
            entity.Property(e => e.CoIntPc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_INT_PC");
            entity.Property(e => e.CoMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_MES");
            entity.Property(e => e.CoMul)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_MUL");
            entity.Property(e => e.CoMulPc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_MUL_PC");
            entity.Property(e => e.CoNumdos)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_NUMDOS");
            entity.Property(e => e.CoOi)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_OI");
            entity.Property(e => e.CoRec)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_REC");
            entity.Property(e => e.CoServ)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_SERV");
            entity.Property(e => e.CoTope)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_TOPE");
        });

        modelBuilder.Entity<FcCobrocajpp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_COBROCAJPP");

            entity.HasIndex(e => e.CoSol, "IX_FC_COBROCAJPP");

            entity.HasIndex(e => new { e.CoCli, e.CoMes, e.CoAño }, "IX_FC_COBROCAJPP_1");

            entity.Property(e => e.CoAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_AÑO");
            entity.Property(e => e.CoCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CLI");
            entity.Property(e => e.CoCobrar).HasColumnName("CO_COBRAR");
            entity.Property(e => e.CoIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_IDOP");
            entity.Property(e => e.CoImp)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_IMP");
            entity.Property(e => e.CoMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_MES");
            entity.Property(e => e.CoSeq)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_SEQ");
            entity.Property(e => e.CoSol)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_SOL");
        });

        modelBuilder.Entity<FcComhist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_COMHIST");

            entity.HasIndex(e => e.HcId, "IX_FC_COMHIST");

            entity.HasIndex(e => e.HcFi, "IX_FC_COMHIST_1");

            entity.HasIndex(e => e.HcFc, "IX_FC_COMHIST_2");

            entity.HasIndex(e => new { e.HcFi, e.HcFc }, "IX_FC_COMHIST_3");

            entity.Property(e => e.HcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("HC_CLI");
            entity.Property(e => e.HcEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("HC_EST");
            entity.Property(e => e.HcFc)
                .HasColumnType("datetime")
                .HasColumnName("HC_FC");
            entity.Property(e => e.HcFi)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("HC_FI");
            entity.Property(e => e.HcId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("HC_ID");
        });

        modelBuilder.Entity<FcConstruc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CONSTRUC");

            entity.Property(e => e.CoCod).HasColumnName("CO_COD");
            entity.Property(e => e.CoDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CO_DESC");
        });

        modelBuilder.Entity<FcContrato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_CONTRATO");

            entity.Property(e => e.CtActividad)
                .HasMaxLength(42)
                .IsUnicode(false)
                .HasColumnName("CT_ACTIVIDAD");
            entity.Property(e => e.CtAñocto)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CT_AÑOCTO");
            entity.Property(e => e.CtCalibre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CT_CALIBRE");
            entity.Property(e => e.CtCategoria)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CT_CATEGORIA");
            entity.Property(e => e.CtCirun)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CT_CIRUN");
            entity.Property(e => e.CtConduct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CT_CONDUCT");
            entity.Property(e => e.CtConexacom)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CT_CONEXACOM");
            entity.Property(e => e.CtCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CT_CTACLI");
            entity.Property(e => e.CtDireccion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CT_DIRECCION");
            entity.Property(e => e.CtDirecnro)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CT_DIRECNRO");
            entity.Property(e => e.CtFasea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CT_FASEA");
            entity.Property(e => e.CtFaseb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CT_FASEB");
            entity.Property(e => e.CtFasec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CT_FASEC");
            entity.Property(e => e.CtFechai)
                .HasColumnType("datetime")
                .HasColumnName("CT_FECHAI");
            entity.Property(e => e.CtLocalidad)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CT_LOCALIDAD");
            entity.Property(e => e.CtLongvano).HasColumnName("CT_LONGVANO");
            entity.Property(e => e.CtMarca)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CT_MARCA");
            entity.Property(e => e.CtMaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_MATERNO");
            entity.Property(e => e.CtNeutro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CT_NEUTRO");
            entity.Property(e => e.CtNombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CT_NOMBRE");
            entity.Property(e => e.CtNrocto).HasColumnName("CT_NROCTO");
            entity.Property(e => e.CtNromed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CT_NROMED");
            entity.Property(e => e.CtPaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CT_PATERNO");
            entity.Property(e => e.CtPoste)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CT_POSTE");
            entity.Property(e => e.CtPotenc).HasColumnName("CT_POTENC");
            entity.Property(e => e.CtTipoconex)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CT_TIPOCONEX");
            entity.Property(e => e.CtZona)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CT_ZONA");
        });

        modelBuilder.Entity<FcCorFecenvig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_COR_FECENVIG");

            entity.HasIndex(e => e.CoFecenvig, "IX_FC_COR_FECENVIG");

            entity.HasIndex(e => e.CoCli, "IX_FC_COR_FECENVIG_1");

            entity.Property(e => e.CoCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CLI");
            entity.Property(e => e.CoFecenvig)
                .HasColumnType("datetime")
                .HasColumnName("CO_FECENVIG");
        });

        modelBuilder.Entity<FcCorRec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_COR_REC");

            entity.HasIndex(e => e.CoCli, "IX_FC_COR_REC");

            entity.HasIndex(e => new { e.CoObs, e.ReObs }, "IX_FC_COR_REC_1");

            entity.Property(e => e.CoArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_AREA");
            entity.Property(e => e.CoAñoC)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_AÑO_C");
            entity.Property(e => e.CoAñoCorte)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_AÑO_CORTE");
            entity.Property(e => e.CoAñoMora)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_AÑO_MORA");
            entity.Property(e => e.CoAñoToppag)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_AÑO_TOPPAG");
            entity.Property(e => e.CoCauc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CAUC");
            entity.Property(e => e.CoCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CIC");
            entity.Property(e => e.CoCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CLI");
            entity.Property(e => e.CoEncc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_ENCC");
            entity.Property(e => e.CoEstcli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_ESTCLI");
            entity.Property(e => e.CoFcor)
                .HasColumnType("datetime")
                .HasColumnName("CO_FCOR");
            entity.Property(e => e.CoFord)
                .HasColumnType("datetime")
                .HasColumnName("CO_FORD");
            entity.Property(e => e.CoIt)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_IT");
            entity.Property(e => e.CoLugC)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_LUG_C");
            entity.Property(e => e.CoMesC)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_MES_C");
            entity.Property(e => e.CoMesCorte)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_MES_CORTE");
            entity.Property(e => e.CoMesMora)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_MES_MORA");
            entity.Property(e => e.CoMesToppag)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_MES_TOPPAG");
            entity.Property(e => e.CoN)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_N");
            entity.Property(e => e.CoObs)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_OBS");
            entity.Property(e => e.CoResc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_RESC");
            entity.Property(e => e.CoRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_RUT");
            entity.Property(e => e.CoSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_SEC");
            entity.Property(e => e.CoTdeuda)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CO_TDEUDA");
            entity.Property(e => e.ReCaur)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_CAUR");
            entity.Property(e => e.ReEncr)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_ENCR");
            entity.Property(e => e.ReEstcli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_ESTCLI");
            entity.Property(e => e.ReFord)
                .HasColumnType("datetime")
                .HasColumnName("RE_FORD");
            entity.Property(e => e.ReFrec)
                .HasColumnType("datetime")
                .HasColumnName("RE_FREC");
            entity.Property(e => e.ReLugR)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_LUG_R");
            entity.Property(e => e.ReN)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RE_N");
            entity.Property(e => e.ReObs)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_OBS");
            entity.Property(e => e.ReResr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_RESR");
            entity.Property(e => e.ReTpag)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("RE_TPAG");
        });

        modelBuilder.Entity<FcDosPrerec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_DOS_PREREC");

            entity.HasIndex(e => e.DsIddos, "IX_FC_DOS_PREREC");

            entity.HasIndex(e => e.DsIdcaja, "IX_FC_DOS_PREREC_1");

            entity.HasIndex(e => e.DsFecha, "IX_FC_DOS_PREREC_2");

            entity.Property(e => e.DsDosF).HasColumnName("DS_DOS_F");
            entity.Property(e => e.DsDosI).HasColumnName("DS_DOS_I");
            entity.Property(e => e.DsDosInicio).HasColumnName("DS_DOS_INICIO");
            entity.Property(e => e.DsFecha)
                .HasColumnType("datetime")
                .HasColumnName("DS_FECHA");
            entity.Property(e => e.DsIdcaja)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DS_IDCAJA");
            entity.Property(e => e.DsIddos).HasColumnName("DS_IDDOS");
        });

        modelBuilder.Entity<FcDosific>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_DOSIFIC");

            entity.HasIndex(e => e.DsFec, "IX_FC_DOSIFIC");

            entity.HasIndex(e => e.DsId, "IX_FC_DOSIFIC_1");

            entity.HasIndex(e => e.DsNum, "IX_FC_DOSIFIC_2");

            entity.HasIndex(e => new { e.DsNum, e.DsId }, "IX_FC_DOSIFIC_3");

            entity.Property(e => e.DsArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DS_AREA");
            entity.Property(e => e.DsEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("DS_EST");
            entity.Property(e => e.DsFec)
                .HasColumnType("datetime")
                .HasColumnName("DS_FEC");
            entity.Property(e => e.DsFecClose)
                .HasColumnType("datetime")
                .HasColumnName("DS_FEC_CLOSE");
            entity.Property(e => e.DsFeclimE)
                .HasColumnType("datetime")
                .HasColumnName("DS_FECLIM_E");
            entity.Property(e => e.DsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DS_ID");
            entity.Property(e => e.DsLegend)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_LEGEND");
            entity.Property(e => e.DsLit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DS_LIT");
            entity.Property(e => e.DsLlave)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_LLAVE");
            entity.Property(e => e.DsN0).HasColumnName("DS_N0");
            entity.Property(e => e.DsN1).HasColumnName("DS_N1");
            entity.Property(e => e.DsNum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DS_NUM");
            entity.Property(e => e.DsNuso)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DS_NUSO");
            entity.Property(e => e.DsType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DS_TYPE");
        });

        modelBuilder.Entity<FcDosific20171006>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_DOSIFIC20171006");

            entity.Property(e => e.DsArea)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("DS_AREA");
            entity.Property(e => e.DsEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DS_EST");
            entity.Property(e => e.DsFec)
                .HasColumnType("datetime")
                .HasColumnName("DS_FEC");
            entity.Property(e => e.DsFecClose)
                .HasColumnType("datetime")
                .HasColumnName("DS_FEC_CLOSE");
            entity.Property(e => e.DsFeclimE)
                .HasColumnType("datetime")
                .HasColumnName("DS_FECLIM_E");
            entity.Property(e => e.DsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DS_ID");
            entity.Property(e => e.DsLegend)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DS_LEGEND");
            entity.Property(e => e.DsLit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DS_LIT");
            entity.Property(e => e.DsLlave)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DS_LLAVE");
            entity.Property(e => e.DsN0).HasColumnName("DS_N0");
            entity.Property(e => e.DsN1).HasColumnName("DS_N1");
            entity.Property(e => e.DsNum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DS_NUM");
            entity.Property(e => e.DsNuso).HasColumnName("DS_NUSO");
            entity.Property(e => e.DsType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DS_TYPE");
        });

        modelBuilder.Entity<FcDs4206alta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_DS4206ALTAS");

            entity.HasIndex(e => new { e.FcAño, e.FcMes, e.FcCli }, "IX_FC_DS4206ALTAS_01");

            entity.HasIndex(e => new { e.FcDosid, e.FcDosseq, e.FcCli }, "IX_FC_DS4206ALTAS_02");

            entity.Property(e => e.FcAño).HasColumnName("FC_AÑO");
            entity.Property(e => e.FcCateg)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CATEG");
            entity.Property(e => e.FcCli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcCon).HasColumnName("FC_CON");
            entity.Property(e => e.FcDesAs)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FC_DES_AS");
            entity.Property(e => e.FcDescDom)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FC_DESC_DOM");
            entity.Property(e => e.FcDosid).HasColumnName("FC_DOSID");
            entity.Property(e => e.FcDosseq).HasColumnName("FC_DOSSEQ");
            entity.Property(e => e.FcEstf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_ESTF");
            entity.Property(e => e.FcFanu)
                .HasColumnType("datetime")
                .HasColumnName("FC_FANU");
            entity.Property(e => e.FcIap)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("FC_IAP");
            entity.Property(e => e.FcMes).HasColumnName("FC_MES");
            entity.Property(e => e.FcPercent)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("FC_PERCENT");
        });

        modelBuilder.Entity<FcDs4206desctype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_DS4206DESCTYPE");

            entity.HasIndex(e => new { e.EcEt, e.EcAño, e.EcMes }, "IX_FC_DS4206DESCTYPE_01");

            entity.Property(e => e.EcAño).HasColumnName("EC_AÑO");
            entity.Property(e => e.EcEt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EC_ET");
            entity.Property(e => e.EcMes).HasColumnName("EC_MES");
            entity.Property(e => e.EcType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EC_TYPE");
        });

        modelBuilder.Entity<FcDs4206etrank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_DS4206ETRANK");

            entity.HasIndex(e => new { e.EcEt, e.EcAño, e.EcMes }, "IX_FC_DS4206ETRANK_01");

            entity.Property(e => e.EcAño).HasColumnName("EC_AÑO");
            entity.Property(e => e.EcEt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EC_ET");
            entity.Property(e => e.EcMes).HasColumnName("EC_MES");
            entity.Property(e => e.EcPercent)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("EC_PERCENT");
            entity.Property(e => e.EcRan1)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("EC_RAN1");
            entity.Property(e => e.EcRan2)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("EC_RAN2");
            entity.Property(e => e.EcSeq).HasColumnName("EC_SEQ");
            entity.Property(e => e.EcType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EC_TYPE");
        });

        modelBuilder.Entity<FcEstCargo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_EST_CARGOS");

            entity.HasIndex(e => e.EcCargo, "IX_FC_CARGOS_ET_1");

            entity.HasIndex(e => e.EcIdfv, "IX_FC_EST_CARGOS");

            entity.Property(e => e.EcBase)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("EC_BASE");
            entity.Property(e => e.EcBloq1)
                .HasDefaultValueSql("(0)")
                .HasColumnName("EC_BLOQ1");
            entity.Property(e => e.EcBloq2)
                .HasDefaultValueSql("(0)")
                .HasColumnName("EC_BLOQ2");
            entity.Property(e => e.EcCargo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EC_CARGO");
            entity.Property(e => e.EcIdet)
                .HasDefaultValueSql("(0)")
                .HasColumnName("EC_IDET");
            entity.Property(e => e.EcIdfv)
                .HasDefaultValueSql("(0)")
                .HasColumnName("EC_IDFV");
        });

        modelBuilder.Entity<FcEstTar01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_EST_TAR01");

            entity.HasIndex(e => e.EtId, "IX_FC_CATEGORIA");

            entity.HasIndex(e => e.EtCodet, "IX_FC_CATEGORIA_1");

            entity.HasIndex(e => new { e.EtId, e.EtCodet }, "IX_FC_CATEGORIA_2");

            entity.HasIndex(e => e.EtUso, "IX_FC_CATEGORIA_3");

            entity.HasIndex(e => e.EtIdfv, "IX_FC_EST_TAR01");

            entity.Property(e => e.EtCodet)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_CODET");
            entity.Property(e => e.EtDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_DESC");
            entity.Property(e => e.EtId)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ET_ID");
            entity.Property(e => e.EtIdfv)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ET_IDFV");
            entity.Property(e => e.EtRc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("ET_RC");
            entity.Property(e => e.EtReconex)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("ET_RECONEX");
            entity.Property(e => e.EtTipoet)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_TIPOET");
            entity.Property(e => e.EtUso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_USO");
        });

        modelBuilder.Entity<FcEstTipoet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_EST_TIPOET");

            entity.HasIndex(e => e.EtCodtip, "IX_FC_EST_TIPOET");

            entity.Property(e => e.EtCodtip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ET_CODTIP");
            entity.Property(e => e.EtDescet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ET_DESCET");
        });

        modelBuilder.Entity<FcEstUso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_EST_USOS");

            entity.HasIndex(e => e.EtCoduso, "IX_FC_EST_USOS");

            entity.HasIndex(e => e.EtDescuso, "IX_FC_EST_USOS_1");

            entity.Property(e => e.EtCoduso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_CODUSO");
            entity.Property(e => e.EtDescuso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_DESCUSO");
        });

        modelBuilder.Entity<FcFechavig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_FECHAVIG");

            entity.HasIndex(e => e.FvFecvig, "IX_FC_FECHAVIG");

            entity.HasIndex(e => new { e.FvMes, e.FvAño }, "IX_FC_FECHAVIG_1");

            entity.Property(e => e.FvActivated)
                .HasColumnType("datetime")
                .HasColumnName("FV_ACTIVATED");
            entity.Property(e => e.FvAño)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FV_AÑO");
            entity.Property(e => e.FvCreated)
                .HasColumnType("datetime")
                .HasColumnName("FV_CREATED");
            entity.Property(e => e.FvEst)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FV_EST");
            entity.Property(e => e.FvFacindex)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("FV_FACINDEX");
            entity.Property(e => e.FvFecvig)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("FV_FECVIG");
            entity.Property(e => e.FvFibase).HasColumnName("FV_FIBASE");
            entity.Property(e => e.FvId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FV_ID");
            entity.Property(e => e.FvMes)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FV_MES");
            entity.Property(e => e.FvUfvact)
                .HasDefaultValueSql("((2.08521))")
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("FV_UFVACT");
            entity.Property(e => e.FvUfvant)
                .HasDefaultValueSql("((2.08521))")
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("FV_UFVANT");
            entity.Property(e => e.FvUsera).HasColumnName("FV_USERA");
            entity.Property(e => e.FvUserc).HasColumnName("FV_USERC");
        });

        modelBuilder.Entity<FcHistog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_HISTOG");

            entity.Property(e => e.HiCateg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HI_CATEG");
            entity.Property(e => e.HiCliente).HasColumnName("HI_CLIENTE");
            entity.Property(e => e.HiCliente1).HasColumnName("HI_CLIENTE1");
            entity.Property(e => e.HiCliente2).HasColumnName("HI_CLIENTE2");
            entity.Property(e => e.HiCliente3).HasColumnName("HI_CLIENTE3");
            entity.Property(e => e.HiCliente4).HasColumnName("HI_CLIENTE4");
            entity.Property(e => e.HiCliente5).HasColumnName("HI_CLIENTE5");
        });

        modelBuilder.Entity<FcInstitucion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_INSTITUCION");

            entity.HasIndex(e => e.InId, "IX_FC_INSTITUCION");

            entity.Property(e => e.InId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IN_ID");
            entity.Property(e => e.InInstitucion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_INSTITUCION");
        });

        modelBuilder.Entity<FcInstitucion1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_INSTITUCION_1");

            entity.HasIndex(e => e.InIdins, "IX_FC_INSTITUCION_1");

            entity.Property(e => e.InCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_CLI");
            entity.Property(e => e.InIdins)
                .HasDefaultValueSql("(0)")
                .HasColumnName("IN_IDINS");
        });

        modelBuilder.Entity<FcInstitucion11>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_INSTITUCION_1_");

            entity.HasIndex(e => new { e.InIdins, e.InIdop }, "IX_FC_INSTITUCION_1_");

            entity.Property(e => e.InCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_CLI");
            entity.Property(e => e.InIdins)
                .HasDefaultValueSql("(0)")
                .HasColumnName("IN_IDINS");
            entity.Property(e => e.InIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("IN_IDOP");
        });

        modelBuilder.Entity<FcInstnueva>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_INSTNUEVA");

            entity.Property(e => e.InCategAl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IN_CATEG_AL");
            entity.Property(e => e.InCategAp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IN_CATEG_AP");
            entity.Property(e => e.InCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IN_CTACLI");
            entity.Property(e => e.InDirec)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("IN_DIREC");
            entity.Property(e => e.InFechaf)
                .HasColumnType("datetime")
                .HasColumnName("IN_FECHAF");
            entity.Property(e => e.InFechai)
                .HasColumnType("datetime")
                .HasColumnName("IN_FECHAI");
            entity.Property(e => e.InInsp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IN_INSP");
            entity.Property(e => e.InLectura)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("IN_LECTURA");
            entity.Property(e => e.InM3ctto)
                .HasColumnType("money")
                .HasColumnName("IN_M3CTTO");
            entity.Property(e => e.InNombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("IN_NOMBRE");
            entity.Property(e => e.InNromed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN_NROMED");
            entity.Property(e => e.InNroso).HasColumnName("IN_NROSO");
            entity.Property(e => e.InRuta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IN_RUTA");
            entity.Property(e => e.InSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IN_SIST");
        });

        modelBuilder.Entity<FcLectore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_LECTORES");

            entity.HasIndex(e => e.LcCodlec, "IX_FC_LECTOR");

            entity.HasIndex(e => e.LcId, "IX_FC_LECTORES");

            entity.Property(e => e.LcCodlec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LC_CODLEC");
            entity.Property(e => e.LcEst)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LC_EST");
            entity.Property(e => e.LcId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LC_ID");
            entity.Property(e => e.LcNom)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LC_NOM");
        });

        modelBuilder.Entity<FcLectura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_LECTURAS");

            entity.Property(e => e.Anyo).HasColumnName("ANYO");
            entity.Property(e => e.Cli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLI");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Lectura).HasColumnName("LECTURA");
            entity.Property(e => e.Medidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MEDIDOR");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Obs)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OBS");
        });

        modelBuilder.Entity<FcLey1886>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_LEY1886");

            entity.HasIndex(e => new { e.LeCli, e.LeMes, e.LeAño }, "IX_FC_LEY1886");

            entity.Property(e => e.LeAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LE_AÑO");
            entity.Property(e => e.LeCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LE_CLI");
            entity.Property(e => e.LeDosid).HasColumnName("LE_DOSID");
            entity.Property(e => e.LeDosseq).HasColumnName("LE_DOSSEQ");
            entity.Property(e => e.LeEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LE_EST");
            entity.Property(e => e.LeFecproc)
                .HasColumnType("datetime")
                .HasColumnName("LE_FECPROC");
            entity.Property(e => e.LeMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LE_MES");
            entity.Property(e => e.LeMonto)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("LE_MONTO");
            entity.Property(e => e.LePag)
                .HasColumnType("datetime")
                .HasColumnName("LE_PAG");
        });

        modelBuilder.Entity<FcLey1886Tot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_LEY1886_TOT");

            entity.HasIndex(e => new { e.DvOpid, e.DvCod }, "IX_FC_LEY1886_TOT_01").IsClustered();

            entity.Property(e => e.DvAño).HasColumnName("DV_AÑO");
            entity.Property(e => e.DvCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_CCONTROL");
            entity.Property(e => e.DvCi)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_CI");
            entity.Property(e => e.DvCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_COD");
            entity.Property(e => e.DvConm3).HasColumnName("DV_CONM3");
            entity.Property(e => e.DvD1886D)
                .HasColumnType("money")
                .HasColumnName("DV_D1886_D");
            entity.Property(e => e.DvD1886I)
                .HasColumnType("money")
                .HasColumnName("DV_D1886_I");
            entity.Property(e => e.DvDosid).HasColumnName("DV_DOSID");
            entity.Property(e => e.DvFnac)
                .HasColumnType("datetime")
                .HasColumnName("DV_FNAC");
            entity.Property(e => e.DvMes).HasColumnName("DV_MES");
            entity.Property(e => e.DvNfac).HasColumnName("DV_NFAC");
            entity.Property(e => e.DvNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_NOM");
            entity.Property(e => e.DvNord)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_NORD");
            entity.Property(e => e.DvOpid).HasColumnName("DV_OPID");
            entity.Property(e => e.DvTci)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DV_TCI");
            entity.Property(e => e.DvTfac)
                .HasColumnType("money")
                .HasColumnName("DV_TFAC");
        });

        modelBuilder.Entity<FcLeyendum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_LEYENDA");

            entity.Property(e => e.LyEst)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LY_EST");
            entity.Property(e => e.LyFecha)
                .HasColumnType("datetime")
                .HasColumnName("LY_FECHA");
            entity.Property(e => e.LyLeyenda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LY_LEYENDA");
        });

        modelBuilder.Entity<FcManten>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_MANTEN");

            entity.Property(e => e.MaCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MA_CTACLI");
            entity.Property(e => e.MaFecha)
                .HasColumnType("datetime")
                .HasColumnName("MA_FECHA");
            entity.Property(e => e.MaHora)
                .HasColumnType("smalldatetime")
                .HasColumnName("MA_HORA");
            entity.Property(e => e.MaObs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MA_OBS");
            entity.Property(e => e.MaOp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("MA_OP");
            entity.Property(e => e.MaUsu).HasColumnName("MA_USU");
        });

        modelBuilder.Entity<FcMarca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_MARCAS");

            entity.HasIndex(e => e.MaDesc, "IDX_DESC");

            entity.Property(e => e.MaDesc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("MA_DESC");
            entity.Property(e => e.MaInd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MA_IND");
            entity.Property(e => e.MaSerial)
                .ValueGeneratedOnAdd()
                .HasColumnName("MA_SERIAL");
        });

        modelBuilder.Entity<FcMedidor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_MEDIDOR");

            entity.HasIndex(e => e.MeCtacli, "IDX_CTA");

            entity.HasIndex(e => e.MeNumero, "IDX_MED");

            entity.Property(e => e.MeAño)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ME_AÑO");
            entity.Property(e => e.MeCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ME_CTACLI");
            entity.Property(e => e.MeDigitos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ME_DIGITOS");
            entity.Property(e => e.MeEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ME_ESTADO");
            entity.Property(e => e.MeFechai)
                .HasColumnType("datetime")
                .HasColumnName("ME_FECHAI");
            entity.Property(e => e.MeLectura).HasColumnName("ME_LECTURA");
            entity.Property(e => e.MeMarca)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ME_MARCA");
            entity.Property(e => e.MeMedestado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ME_MEDESTADO");
            entity.Property(e => e.MeNumero)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ME_NUMERO");
        });

        modelBuilder.Entity<FcMovcateg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_MOVCATEGS");

            entity.HasIndex(e => new { e.McPeriodo, e.McFeclec, e.McCateg, e.McCargo }, "IX_FC_MOVCATEGS_01").IsClustered();

            entity.Property(e => e.McBase)
                .HasDefaultValueSql("('')")
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("MC_BASE");
            entity.Property(e => e.McBloquef).HasColumnName("MC_BLOQUEF");
            entity.Property(e => e.McBloquei).HasColumnName("MC_BLOQUEI");
            entity.Property(e => e.McCargo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_CARGO");
            entity.Property(e => e.McCateg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_CATEG");
            entity.Property(e => e.McFeclec)
                .HasColumnType("datetime")
                .HasColumnName("MC_FECLEC");
            entity.Property(e => e.McPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("MC_PERIODO");
        });

        modelBuilder.Entity<FcMovcliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_MOVCLIENTE");

            entity.HasIndex(e => new { e.McFeclec, e.McLeccod, e.McCli }, "IX_FC_MOVCLIENTE_01").IsClustered();

            entity.Property(e => e.McCat)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_CAT");
            entity.Property(e => e.McCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_CLI");
            entity.Property(e => e.McConavg).HasColumnName("MC_CONAVG");
            entity.Property(e => e.McConsumo).HasColumnName("MC_CONSUMO");
            entity.Property(e => e.McDir)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_DIR");
            entity.Property(e => e.McFeclec)
                .HasColumnType("datetime")
                .HasColumnName("MC_FECLEC");
            entity.Property(e => e.McIt).HasColumnName("MC_IT");
            entity.Property(e => e.McLecact).HasColumnName("MC_LECACT");
            entity.Property(e => e.McLecant).HasColumnName("MC_LECANT");
            entity.Property(e => e.McLeccod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_LECCOD");
            entity.Property(e => e.McLecnom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_LECNOM");
            entity.Property(e => e.McMed)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_MED");
            entity.Property(e => e.McNom)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_NOM");
            entity.Property(e => e.McObs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_OBS");
            entity.Property(e => e.McPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("MC_PERIODO");
            entity.Property(e => e.McRut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_RUT");
            entity.Property(e => e.McSrv)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MC_SRV");
        });

        modelBuilder.Entity<FcMovhistorico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_MOVHISTORICO");

            entity.HasIndex(e => new { e.MhFeclec, e.MhLeccod, e.MhCli }, "IX_FC_MOVHISTORICO_01").IsClustered();

            entity.Property(e => e.MhCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MH_CLI");
            entity.Property(e => e.MhConsumo).HasColumnName("MH_CONSUMO");
            entity.Property(e => e.MhFeclec)
                .HasColumnType("datetime")
                .HasColumnName("MH_FECLEC");
            entity.Property(e => e.MhLeccod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MH_LECCOD");
            entity.Property(e => e.MhPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("MH_PERIODO");
            entity.Property(e => e.MhRut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MH_RUT");
            entity.Property(e => e.MhStatus).HasColumnName("MH_STATUS");
            entity.Property(e => e.MhTotal)
                .HasColumnType("money")
                .HasColumnName("MH_TOTAL");
        });

        modelBuilder.Entity<FcMovob>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_MOVOBS");

            entity.HasIndex(e => e.ObCode, "IX_FC_MOVOBS_01").IsClustered();

            entity.Property(e => e.ObCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OB_CODE");
            entity.Property(e => e.ObDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OB_DESC");
            entity.Property(e => e.ObEvent)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OB_EVENT");
        });

        modelBuilder.Entity<FcOb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_OBS");

            entity.HasIndex(e => e.ObCodobs, "IX_FC_OBS_1");

            entity.Property(e => e.ObCl)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_CL");
            entity.Property(e => e.ObCodobs)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OB_CODOBS");
            entity.Property(e => e.ObCor)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_COR");
            entity.Property(e => e.ObDesc)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OB_DESC");
            entity.Property(e => e.ObLd)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_LD");
            entity.Property(e => e.ObN)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_N");
            entity.Property(e => e.ObNextmonth)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_NEXTMONTH");
            entity.Property(e => e.ObPl)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_PL");
            entity.Property(e => e.ObRec)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_REC");
            entity.Property(e => e.ObRl)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OB_RL");
        });

        modelBuilder.Entity<FcObservation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_OBSERVATIONS");

            entity.Property(e => e.ObCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OB_CODE");
            entity.Property(e => e.ObDesc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("OB_DESC");
            entity.Property(e => e.ObEvent)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OB_EVENT");
            entity.Property(e => e.ObId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OB_ID");
            entity.Property(e => e.ObNcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OB_NCODE");
            entity.Property(e => e.ObOcode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OB_OCODE");
            entity.Property(e => e.ObRcode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("OB_RCODE");
            entity.Property(e => e.ObRdet)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OB_RDET");
            entity.Property(e => e.ObSec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OB_SEC");
            entity.Property(e => e.ObSuceso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OB_SUCESO");
        });

        modelBuilder.Entity<FcObskardex>(entity =>
        {
            entity.HasKey(e => e.OkId);

            entity.ToTable("FC_OBSKARDEX");

            entity.HasIndex(e => e.OkCli, "IX_FC_OBSKARDEX");

            entity.HasIndex(e => e.OkFec, "IX_FC_OBSKARDEX_1");

            entity.Property(e => e.OkId).HasColumnName("OK_ID");
            entity.Property(e => e.OkCaja)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OK_CAJA");
            entity.Property(e => e.OkCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OK_CLI");
            entity.Property(e => e.OkFec)
                .HasColumnType("datetime")
                .HasColumnName("OK_FEC");
            entity.Property(e => e.OkObs)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OK_OBS");
            entity.Property(e => e.OkVerif)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OK_VERIF");
        });

        modelBuilder.Entity<FcOt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_OT");

            entity.HasIndex(e => new { e.OtFechai, e.OtFechaf }, "IDX_FECHA");

            entity.HasIndex(e => e.OtNro, "IDX_NRO");

            entity.HasIndex(e => e.OtNroso, "IDX_NROSO");

            entity.Property(e => e.OtEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OT_ESTADO");
            entity.Property(e => e.OtFechaf)
                .HasColumnType("datetime")
                .HasColumnName("OT_FECHAF");
            entity.Property(e => e.OtFechai)
                .HasColumnType("datetime")
                .HasColumnName("OT_FECHAI");
            entity.Property(e => e.OtInsp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("OT_INSP");
            entity.Property(e => e.OtNro)
                .ValueGeneratedOnAdd()
                .HasColumnName("OT_NRO");
            entity.Property(e => e.OtNroso).HasColumnName("OT_NROSO");
            entity.Property(e => e.OtObser)
                .HasMaxLength(550)
                .IsUnicode(false)
                .HasColumnName("OT_OBSER");
            entity.Property(e => e.OtOper).HasColumnName("OT_OPER");
            entity.Property(e => e.OtRes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OT_RES");
            entity.Property(e => e.OtTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OT_TIPO");
        });

        modelBuilder.Entity<FcOtca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_OTCA");

            entity.Property(e => e.OtAmp)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("OT_AMP");
            entity.Property(e => e.OtClase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OT_CLASE");
            entity.Property(e => e.OtDig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OT_DIG");
            entity.Property(e => e.OtEjec).HasColumnName("OT_EJEC");
            entity.Property(e => e.OtEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OT_ESTADO");
            entity.Property(e => e.OtFechaf)
                .HasColumnType("datetime")
                .HasColumnName("OT_FECHAF");
            entity.Property(e => e.OtFechai)
                .HasColumnType("datetime")
                .HasColumnName("OT_FECHAI");
            entity.Property(e => e.OtLectura).HasColumnName("OT_LECTURA");
            entity.Property(e => e.OtMarca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OT_MARCA");
            entity.Property(e => e.OtMotivo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OT_MOTIVO");
            entity.Property(e => e.OtNromed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OT_NROMED");
            entity.Property(e => e.OtNroot)
                .ValueGeneratedOnAdd()
                .HasColumnName("OT_NROOT");
            entity.Property(e => e.OtNroso).HasColumnName("OT_NROSO");
        });

        modelBuilder.Entity<FcOtrosI>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_OTROS_I");

            entity.HasIndex(e => new { e.OtCli, e.OtMesO, e.OtAñoO }, "IX_FC_OTROS_I");

            entity.HasIndex(e => new { e.OtMesO, e.OtAñoO }, "IX_FC_OTROS_I_5");

            entity.HasIndex(e => new { e.OtMesO, e.OtAñoO, e.OtConcepto }, "IX_FC_OTROS_I_6");

            entity.HasIndex(e => e.OtConcepto, "IX_FC_OTROS_I_9");

            entity.Property(e => e.OtAñoC)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OT_AÑO_C");
            entity.Property(e => e.OtAñoO)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OT_AÑO_O");
            entity.Property(e => e.OtCaj)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OT_CAJ");
            entity.Property(e => e.OtCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OT_CCONTROL");
            entity.Property(e => e.OtCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OT_CLI");
            entity.Property(e => e.OtConcepto)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OT_CONCEPTO");
            entity.Property(e => e.OtDosnum)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OT_DOSNUM");
            entity.Property(e => e.OtEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('P')")
                .HasColumnName("OT_EST");
            entity.Property(e => e.OtFecanu)
                .HasColumnType("datetime")
                .HasColumnName("OT_FECANU");
            entity.Property(e => e.OtIddos)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OT_IDDOS");
            entity.Property(e => e.OtIdrefanu)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OT_IDREFANU");
            entity.Property(e => e.OtMesC)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OT_MES_C");
            entity.Property(e => e.OtMesO)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OT_MES_O");
            entity.Property(e => e.OtMonto)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("OT_MONTO");
            entity.Property(e => e.OtName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OT_NAME");
            entity.Property(e => e.OtNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OT_NITCI");
            entity.Property(e => e.OtPag)
                .HasColumnType("datetime")
                .HasColumnName("OT_PAG");
        });

        modelBuilder.Entity<FcParametro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PARAMETROS");

            entity.Property(e => e.PaContrau).HasColumnName("PA_CONTRAU");
            entity.Property(e => e.PaSerie)
                .ValueGeneratedOnAdd()
                .HasColumnName("PA_SERIE");
            entity.Property(e => e.PaSerieu).HasColumnName("PA_SERIEU");
            entity.Property(e => e.PaUbica)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PA_UBICA");
        });

        modelBuilder.Entity<FcPaybdy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PAYBDY");

            entity.HasIndex(e => new { e.Opid, e.Dosid, e.Nfac, e.Seq }, "IX_PAYBDY_01").IsClustered();

            entity.Property(e => e.Codigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Ditem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DITEM");
            entity.Property(e => e.Dosid).HasColumnName("DOSID");
            entity.Property(e => e.Monto)
                .HasColumnType("money")
                .HasColumnName("MONTO");
            entity.Property(e => e.Montou)
                .HasColumnType("money")
                .HasColumnName("MONTOU");
            entity.Property(e => e.N).HasDefaultValueSql("('')");
            entity.Property(e => e.Nfac).HasColumnName("NFAC");
            entity.Property(e => e.Opid)
                .HasDefaultValueSql("('')")
                .HasColumnName("OPID");
            entity.Property(e => e.Per)
                .HasColumnType("datetime")
                .HasColumnName("PER");
            entity.Property(e => e.Scf).HasColumnName("SCF");
            entity.Property(e => e.Seq)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEQ");
        });

        modelBuilder.Entity<FcPayhdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PAYHDR");

            entity.HasIndex(e => new { e.Opid, e.Per }, "IX_PAYHDR_01").IsClustered();

            entity.Property(e => e.Caja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAJA");
            entity.Property(e => e.Cat)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CAT");
            entity.Property(e => e.Cctrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CCTROL");
            entity.Property(e => e.Codigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Consumo).HasColumnName("CONSUMO");
            entity.Property(e => e.Desctos)
                .HasColumnType("money")
                .HasColumnName("DESCTOS");
            entity.Property(e => e.Diasv).HasColumnName("DIASV");
            entity.Property(e => e.Direcc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIRECC");
            entity.Property(e => e.Dosid).HasColumnName("DOSID");
            entity.Property(e => e.Doskey)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DOSKEY");
            entity.Property(e => e.Ffac)
                .HasColumnType("datetime")
                .HasColumnName("FFAC");
            entity.Property(e => e.Flecact)
                .HasColumnType("datetime")
                .HasColumnName("FLECACT");
            entity.Property(e => e.Flecant)
                .HasColumnType("datetime")
                .HasColumnName("FLECANT");
            entity.Property(e => e.Flime)
                .HasColumnType("datetime")
                .HasColumnName("FLIME");
            entity.Property(e => e.Fpag)
                .HasColumnType("datetime")
                .HasColumnName("FPAG");
            entity.Property(e => e.Fvenc)
                .HasColumnType("datetime")
                .HasColumnName("FVENC");
            entity.Property(e => e.Lecact).HasColumnName("LECACT");
            entity.Property(e => e.Lecant).HasColumnName("LECANT");
            entity.Property(e => e.Legend)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LEGEND");
            entity.Property(e => e.Literal)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LITERAL");
            entity.Property(e => e.Medidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MEDIDOR");
            entity.Property(e => e.Nauto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("NAUTO");
            entity.Property(e => e.Nfac).HasColumnName("NFAC");
            entity.Property(e => e.Nitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("NITCI");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Opid)
                .HasDefaultValueSql("('')")
                .HasColumnName("OPID");
            entity.Property(e => e.Per)
                .HasColumnType("datetime")
                .HasColumnName("PER");
            entity.Property(e => e.Qrcode)
                .HasColumnType("image")
                .HasColumnName("QRCODE");
            entity.Property(e => e.Rut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("RUT");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Seqrut).HasColumnName("SEQRUT");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("TOTAL");
            entity.Property(e => e.Tpago)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TPAGO");
        });

        modelBuilder.Entity<FcPlalect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PLALECT");

            entity.HasIndex(e => new { e.PlArea, e.PlCic, e.PlSec }, "IX_FC_PLALECT");

            entity.HasIndex(e => e.PlFlec, "IX_FC_PLALECT_1");

            entity.HasIndex(e => e.PlEst, "IX_FC_PLALECT_2");

            entity.HasIndex(e => new { e.PlMes, e.PlAño }, "IX_FC_PLALECT_3");

            entity.HasIndex(e => new { e.PlArea, e.PlCic, e.PlSec, e.PlRut }, "IX_FC_PLALECT_4");

            entity.Property(e => e.PlArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PL_AREA");
            entity.Property(e => e.PlAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_AÑO");
            entity.Property(e => e.PlCentp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PL_CENTP");
            entity.Property(e => e.PlCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PL_CIC");
            entity.Property(e => e.PlClec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PL_CLEC");
            entity.Property(e => e.PlEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('L')")
                .HasColumnName("PL_EST");
            entity.Property(e => e.PlFentp)
                .HasColumnType("datetime")
                .HasColumnName("PL_FENTP");
            entity.Property(e => e.PlFfac)
                .HasColumnType("datetime")
                .HasColumnName("PL_FFAC");
            entity.Property(e => e.PlFlec)
                .HasColumnType("datetime")
                .HasColumnName("PL_FLEC");
            entity.Property(e => e.PlIdfv)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_IDFV");
            entity.Property(e => e.PlM1886)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PL_M1886");
            entity.Property(e => e.PlMal)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PL_MAL");
            entity.Property(e => e.PlMap)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PL_MAP");
            entity.Property(e => e.PlMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_MES");
            entity.Property(e => e.PlMfac)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PL_MFAC");
            entity.Property(e => e.PlMrc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PL_MRC");
            entity.Property(e => e.PlNentp)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_NENTP");
            entity.Property(e => e.PlNfac)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_NFAC");
            entity.Property(e => e.PlNlec)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_NLEC");
            entity.Property(e => e.PlNrec)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_NREC");
            entity.Property(e => e.PlPflec)
                .HasColumnType("datetime")
                .HasColumnName("PL_PFLEC");
            entity.Property(e => e.PlRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PL_RUT");
            entity.Property(e => e.PlSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PL_SEC");
            entity.Property(e => e.PlSeqcorF)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_SEQCOR_F");
            entity.Property(e => e.PlSeqcorI)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PL_SEQCOR_I");
        });

        modelBuilder.Entity<FcPlapagbody>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PLAPAGBODY");

            entity.HasIndex(e => e.PpId, "IX_FC_PLAPAGBODY_01").IsClustered();

            entity.HasIndex(e => new { e.PpMes, e.PpAño }, "IX_FC_PLAPAGBODY_02");

            entity.Property(e => e.PpAño).HasColumnName("PP_AÑO");
            entity.Property(e => e.PpCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_CAJ");
            entity.Property(e => e.PpCoid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PP_COID");
            entity.Property(e => e.PpDosid).HasColumnName("PP_DOSID");
            entity.Property(e => e.PpEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('P')")
                .HasColumnName("PP_EST");
            entity.Property(e => e.PpFanu)
                .HasColumnType("datetime")
                .HasColumnName("PP_FANU");
            entity.Property(e => e.PpFpag)
                .HasColumnType("datetime")
                .HasColumnName("PP_FPAG");
            entity.Property(e => e.PpId).HasColumnName("PP_ID");
            entity.Property(e => e.PpIdanu).HasColumnName("PP_IDANU");
            entity.Property(e => e.PpMes).HasColumnName("PP_MES");
            entity.Property(e => e.PpMonto)
                .HasColumnType("money")
                .HasColumnName("PP_MONTO");
            entity.Property(e => e.PpNrecibo)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PP_NRECIBO");
            entity.Property(e => e.PpPagpla)
                .HasColumnType("datetime")
                .HasColumnName("PP_PAGPLA");
            entity.Property(e => e.PpReconex)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PP_RECONEX");
            entity.Property(e => e.PpSeq).HasColumnName("PP_SEQ");
        });

        modelBuilder.Entity<FcPlapagfac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PLAPAGFACS");

            entity.HasIndex(e => e.PpId, "IX_FC_PLAPAGFACS_01").IsClustered();

            entity.HasIndex(e => new { e.PpMes, e.PpAño }, "IX_FC_PLAPAGFACS_02");

            entity.Property(e => e.PpAño).HasColumnName("PP_AÑO");
            entity.Property(e => e.PpCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_CLI");
            entity.Property(e => e.PpId).HasColumnName("PP_ID");
            entity.Property(e => e.PpMes).HasColumnName("PP_MES");
            entity.Property(e => e.PpMonto)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("PP_MONTO");
        });

        modelBuilder.Entity<FcPlapaghead>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PLAPAGHEAD");

            entity.HasIndex(e => e.PpId, "IX_FC_PLAPAGHEAD_01").IsClustered();

            entity.HasIndex(e => e.PpCli, "IX_FC_PLAPAGHEAD_02");

            entity.Property(e => e.PpCash)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("PP_CASH");
            entity.Property(e => e.PpCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_CLI");
            entity.Property(e => e.PpEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PP_EST");
            entity.Property(e => e.PpEstc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_ESTC");
            entity.Property(e => e.PpFcie)
                .HasColumnType("datetime")
                .HasColumnName("PP_FCIE");
            entity.Property(e => e.PpFsol)
                .HasColumnType("datetime")
                .HasColumnName("PP_FSOL");
            entity.Property(e => e.PpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PP_ID");
            entity.Property(e => e.PpIdanu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PP_IDANU");
            entity.Property(e => e.PpNcuotas)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PP_NCUOTAS");
            entity.Property(e => e.PpPagomin)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("PP_PAGOMIN");
            entity.Property(e => e.PpSrvid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PP_SRVID");
            entity.Property(e => e.PpStartp)
                .HasColumnType("datetime")
                .HasColumnName("PP_STARTP");
            entity.Property(e => e.PpTcuotas)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PP_TCUOTAS");
            entity.Property(e => e.PpTotdeuda)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("PP_TOTDEUDA");
            entity.Property(e => e.PpType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_TYPE");
        });

        modelBuilder.Entity<FcPrbalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRBALANCE");

            entity.HasIndex(e => e.PbPag, "IX_FC_IMP_BAL");

            entity.HasIndex(e => e.PbCaj, "IX_FC_IMP_BAL_1");

            entity.HasIndex(e => new { e.PbPag, e.PbCaj }, "IX_FC_IMP_BAL_2");

            entity.HasIndex(e => e.PbIdop, "IX_FC_PRBALANCE");

            entity.Property(e => e.PbAl)
                .HasColumnType("money")
                .HasColumnName("PB_AL");
            entity.Property(e => e.PbAp)
                .HasColumnType("money")
                .HasColumnName("PB_AP");
            entity.Property(e => e.PbAño).HasColumnName("PB_AÑO");
            entity.Property(e => e.PbAñoO).HasColumnName("PB_AÑO_O");
            entity.Property(e => e.PbCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PB_CAJ");
            entity.Property(e => e.PbCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PB_CCONTROL");
            entity.Property(e => e.PbCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PB_CLI");
            entity.Property(e => e.PbDosid).HasColumnName("PB_DOSID");
            entity.Property(e => e.PbIdop).HasColumnName("PB_IDOP");
            entity.Property(e => e.PbInt)
                .HasColumnType("money")
                .HasColumnName("PB_INT");
            entity.Property(e => e.PbLey1886)
                .HasColumnType("money")
                .HasColumnName("PB_LEY1886");
            entity.Property(e => e.PbMes).HasColumnName("PB_MES");
            entity.Property(e => e.PbMesO).HasColumnName("PB_MES_O");
            entity.Property(e => e.PbN).HasColumnName("PB_N");
            entity.Property(e => e.PbNfac).HasColumnName("PB_NFAC");
            entity.Property(e => e.PbOi)
                .HasColumnType("money")
                .HasColumnName("PB_OI");
            entity.Property(e => e.PbPag)
                .HasColumnType("datetime")
                .HasColumnName("PB_PAG");
            entity.Property(e => e.PbProcoop)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("PB_PROCOOP");
            entity.Property(e => e.PbRc)
                .HasColumnType("money")
                .HasColumnName("PB_RC");
            entity.Property(e => e.PbRec)
                .HasColumnType("money")
                .HasColumnName("PB_REC");
            entity.Property(e => e.PbTar)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PB_TAR");
        });

        modelBuilder.Entity<FcPrbalanceFA>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRBALANCE_F_A");

            entity.HasIndex(e => e.PbCli, "IX_FC_PRBAL_F_A");

            entity.HasIndex(e => e.PbIdop, "IX_FC_PRBAL_F_A_1");

            entity.Property(e => e.PbAño).HasColumnName("PB_AÑO");
            entity.Property(e => e.PbCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PB_CAJ");
            entity.Property(e => e.PbCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PB_CCONTROL");
            entity.Property(e => e.PbCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PB_CLI");
            entity.Property(e => e.PbHanu)
                .HasColumnType("datetime")
                .HasColumnName("PB_HANU");
            entity.Property(e => e.PbIdop).HasColumnName("PB_IDOP");
            entity.Property(e => e.PbImporte)
                .HasColumnType("money")
                .HasColumnName("PB_IMPORTE");
            entity.Property(e => e.PbMes).HasColumnName("PB_MES");
            entity.Property(e => e.PbMot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PB_MOT");
            entity.Property(e => e.PbN).HasColumnName("PB_N");
            entity.Property(e => e.PbNfac).HasColumnName("PB_NFAC");
            entity.Property(e => e.PbPag)
                .HasColumnType("datetime")
                .HasColumnName("PB_PAG");
        });

        modelBuilder.Entity<FcPrbalanceRm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRBALANCE_RM");

            entity.HasIndex(e => new { e.PbIdop, e.PbAño, e.PbMes }, "IX_FC_PRBALANCE_RM_01").IsClustered();

            entity.Property(e => e.PbAño).HasColumnName("PB_AÑO");
            entity.Property(e => e.PbIdop).HasColumnName("PB_IDOP");
            entity.Property(e => e.PbMes).HasColumnName("PB_MES");
            entity.Property(e => e.PbMont)
                .HasColumnType("money")
                .HasColumnName("PB_MONT");
            entity.Property(e => e.PbN).HasColumnName("PB_N");
            entity.Property(e => e.PbType).HasColumnName("PB_TYPE");
        });

        modelBuilder.Entity<FcPrbalancegrl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRBALANCEGRL");

            entity.HasIndex(e => e.BgOpid, "IX_FC_PRBALANCEGRL_01").IsClustered();

            entity.Property(e => e.BgAmount)
                .HasColumnType("money")
                .HasColumnName("BG_AMOUNT");
            entity.Property(e => e.BgConcept)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BG_CONCEPT");
            entity.Property(e => e.BgOpid).HasColumnName("BG_OPID");
            entity.Property(e => e.BgSrvid).HasColumnName("BG_SRVID");
        });

        modelBuilder.Entity<FcPrcorte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRCORTES");

            entity.HasIndex(e => e.CoIdop, "IX_FC_PRCORTES");

            entity.Property(e => e.CoAre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_ARE");
            entity.Property(e => e.CoCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CIC");
            entity.Property(e => e.CoClec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CLEC");
            entity.Property(e => e.CoDescr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_DESCR");
            entity.Property(e => e.CoEncc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_ENCC");
            entity.Property(e => e.CoEst)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_EST");
            entity.Property(e => e.CoIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_IDOP");
            entity.Property(e => e.CoJob)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_JOB");
            entity.Property(e => e.CoN)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CO_N");
            entity.Property(e => e.CoRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_RUT");
            entity.Property(e => e.CoSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_SEC");
        });

        modelBuilder.Entity<FcPrcrnotran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRCRNOTRANS");

            entity.HasIndex(e => e.PrIdop, "IX_FC_PRCRNOTRANS");

            entity.HasIndex(e => new { e.PrAre, e.PrType, e.PrIdop }, "IX_FC_PRCRNOTRANS_1");

            entity.Property(e => e.PrAre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ARE");
            entity.Property(e => e.PrCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CIC");
            entity.Property(e => e.PrCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CLI");
            entity.Property(e => e.PrDare)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DARE");
            entity.Property(e => e.PrDcic)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DCIC");
            entity.Property(e => e.PrDrec)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DREC");
            entity.Property(e => e.PrDsec)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DSEC");
            entity.Property(e => e.PrEst)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_EST");
            entity.Property(e => e.PrFo)
                .HasColumnType("datetime")
                .HasColumnName("PR_FO");
            entity.Property(e => e.PrIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IDOP");
            entity.Property(e => e.PrNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_NOM");
            entity.Property(e => e.PrRec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_REC");
            entity.Property(e => e.PrSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_SEC");
            entity.Property(e => e.PrType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TYPE");
        });

        modelBuilder.Entity<FcPret>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRET");

            entity.HasIndex(e => e.EtIdop, "IX_FC_PRET01");

            entity.Property(e => e.EtBase)
                .HasColumnType("money")
                .HasColumnName("ET_BASE");
            entity.Property(e => e.EtCargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_CARGO");
            entity.Property(e => e.EtEt)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_ET");
            entity.Property(e => e.EtFi)
                .HasColumnType("decimal(8, 5)")
                .HasColumnName("ET_FI");
            entity.Property(e => e.EtId).HasColumnName("ET_ID");
            entity.Property(e => e.EtIdop).HasColumnName("ET_IDOP");
            entity.Property(e => e.EtImporte)
                .HasColumnType("money")
                .HasColumnName("ET_IMPORTE");
            entity.Property(e => e.EtN).HasColumnName("ET_N");
            entity.Property(e => e.EtUse)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ET_USE");
        });

        modelBuilder.Entity<FcPrkardexcli>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRKARDEXCLI");

            entity.HasIndex(e => e.PrIdop, "IX_FC_PRKARDEXCLI");

            entity.HasIndex(e => new { e.PrCli, e.PrIdop }, "IX_FC_PRKARDEXCLI_1");

            entity.Property(e => e.PrAct)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ACT");
            entity.Property(e => e.PrAre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ARE");
            entity.Property(e => e.PrCal)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CAL");
            entity.Property(e => e.PrCap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CAP");
            entity.Property(e => e.PrCic)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CIC");
            entity.Property(e => e.PrCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CLI");
            entity.Property(e => e.PrCost)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_COST");
            entity.Property(e => e.PrDir)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DIR");
            entity.Property(e => e.PrEst)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_EST");
            entity.Property(e => e.PrFi)
                .HasColumnType("datetime")
                .HasColumnName("PR_FI");
            entity.Property(e => e.PrId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PR_ID");
            entity.Property(e => e.PrIdop).HasColumnName("PR_IDOP");
            entity.Property(e => e.PrIt)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IT");
            entity.Property(e => e.PrLey)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_LEY");
            entity.Property(e => e.PrLote)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_LOTE");
            entity.Property(e => e.PrMan)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_MAN");
            entity.Property(e => e.PrMed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_MED");
            entity.Property(e => e.PrNit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_NIT");
            entity.Property(e => e.PrNom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_NOM");
            entity.Property(e => e.PrObscaja)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_OBSCAJA");
            entity.Property(e => e.PrRed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_RED");
            entity.Property(e => e.PrRut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_RUT");
            entity.Property(e => e.PrSec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_SEC");
            entity.Property(e => e.PrSol)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_SOL");
            entity.Property(e => e.PrTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TEL");
        });

        modelBuilder.Entity<FcPrkardexclipp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRKARDEXCLIPP");

            entity.Property(e => e.PrAct)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ACT");
            entity.Property(e => e.PrAre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ARE");
            entity.Property(e => e.PrCal)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CAL");
            entity.Property(e => e.PrCap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CAP");
            entity.Property(e => e.PrCic)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CIC");
            entity.Property(e => e.PrCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CLI");
            entity.Property(e => e.PrCost)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_COST");
            entity.Property(e => e.PrDir)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DIR");
            entity.Property(e => e.PrEst)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_EST");
            entity.Property(e => e.PrFi)
                .HasColumnType("datetime")
                .HasColumnName("PR_FI");
            entity.Property(e => e.PrIdop).HasColumnName("PR_IDOP");
            entity.Property(e => e.PrIt)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IT");
            entity.Property(e => e.PrLey)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_LEY");
            entity.Property(e => e.PrLote)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_LOTE");
            entity.Property(e => e.PrMan)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_MAN");
            entity.Property(e => e.PrMed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_MED");
            entity.Property(e => e.PrNit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_NIT");
            entity.Property(e => e.PrNom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_NOM");
            entity.Property(e => e.PrRed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_RED");
            entity.Property(e => e.PrRut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_RUT");
            entity.Property(e => e.PrSec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_SEC");
            entity.Property(e => e.PrTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TEL");
        });

        modelBuilder.Entity<FcPrkardexfac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRKARDEXFAC");

            entity.HasIndex(e => e.PrIdop, "IX_FC_PRKARDEXFAC");

            entity.HasIndex(e => new { e.PrCli, e.PrIdop }, "IX_FC_PRKARDEXFAC_1");

            entity.Property(e => e.PrAl)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_AL");
            entity.Property(e => e.PrAp)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_AP");
            entity.Property(e => e.PrAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_AÑO");
            entity.Property(e => e.PrCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CAJ");
            entity.Property(e => e.PrCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CLI");
            entity.Property(e => e.PrCon)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_CON");
            entity.Property(e => e.PrDv)
                .HasColumnType("money")
                .HasColumnName("PR_DV");
            entity.Property(e => e.PrEstf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ESTF");
            entity.Property(e => e.PrFfac)
                .HasColumnType("datetime")
                .HasColumnName("PR_FFAC");
            entity.Property(e => e.PrFlec)
                .HasColumnType("datetime")
                .HasColumnName("PR_FLEC");
            entity.Property(e => e.PrIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IDOP");
            entity.Property(e => e.PrImp)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_IMP");
            entity.Property(e => e.PrInt)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_INT");
            entity.Property(e => e.PrIntPc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_INT_PC");
            entity.Property(e => e.PrLec)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_LEC");
            entity.Property(e => e.PrMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_MES");
            entity.Property(e => e.PrMul)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_MUL");
            entity.Property(e => e.PrMulPc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_MUL_PC");
            entity.Property(e => e.PrObs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_OBS");
            entity.Property(e => e.PrOi)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_OI");
            entity.Property(e => e.PrPag)
                .HasColumnType("datetime")
                .HasColumnName("PR_PAG");
            entity.Property(e => e.PrPer)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_PER");
            entity.Property(e => e.PrPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("PR_PERIODO");
            entity.Property(e => e.PrRc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_RC");
            entity.Property(e => e.PrRec)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_REC");
        });

        modelBuilder.Entity<FcPrlecterr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRLECTERR");

            entity.Property(e => e.PrA)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_A");
            entity.Property(e => e.PrAvg)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_AVG");
            entity.Property(e => e.PrC)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_C");
            entity.Property(e => e.PrCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CLI");
            entity.Property(e => e.PrCon)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_CON");
            entity.Property(e => e.PrDa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DA");
            entity.Property(e => e.PrDc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DC");
            entity.Property(e => e.PrDeuda)
                .HasColumnType("money")
                .HasColumnName("PR_DEUDA");
            entity.Property(e => e.PrDir)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DIR");
            entity.Property(e => e.PrDr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DR");
            entity.Property(e => e.PrDs)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DS");
            entity.Property(e => e.PrEnclec)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ENCLEC");
            entity.Property(e => e.PrEstado)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ESTADO");
            entity.Property(e => e.PrFecl)
                .HasColumnType("datetime")
                .HasColumnName("PR_FECL");
            entity.Property(e => e.PrIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IDOP");
            entity.Property(e => e.PrIt)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IT");
            entity.Property(e => e.PrLec)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_LEC");
            entity.Property(e => e.PrN)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_N");
            entity.Property(e => e.PrNom)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("PR_NOM");
            entity.Property(e => e.PrObs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_OBS");
            entity.Property(e => e.PrPer)
                .HasColumnType("datetime")
                .HasColumnName("PR_PER");
            entity.Property(e => e.PrPervar)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_PERVAR");
            entity.Property(e => e.PrR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_R");
            entity.Property(e => e.PrS)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_S");
            entity.Property(e => e.PrTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TARAL");
            entity.Property(e => e.PrTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TARAP");
        });

        modelBuilder.Entity<FcPrlistlect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRLISTLECT");

            entity.HasIndex(e => e.LlObssm, "IX_FC_PRLISTLECT");

            entity.HasIndex(e => e.LlObsnf, "IX_FC_PRLISTLECT_1");

            entity.HasIndex(e => e.LlIdop, "IX_FC_PRLISTLECT_2");

            entity.HasIndex(e => e.LlCli, "IX_FC_PRLISTLECT_3");

            entity.Property(e => e.LlAdes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_ADES");
            entity.Property(e => e.LlAre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_ARE");
            entity.Property(e => e.LlAvg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("LL_AVG");
            entity.Property(e => e.LlAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LL_AÑO");
            entity.Property(e => e.LlCdes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_CDES");
            entity.Property(e => e.LlCic)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_CIC");
            entity.Property(e => e.LlCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_CLI");
            entity.Property(e => e.LlDir)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_DIR");
            entity.Property(e => e.LlFl)
                .HasColumnType("datetime")
                .HasColumnName("LL_FL");
            entity.Property(e => e.LlIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LL_IDOP");
            entity.Property(e => e.LlIt)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LL_IT");
            entity.Property(e => e.LlLact)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LL_LACT");
            entity.Property(e => e.LlLant)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LL_LANT");
            entity.Property(e => e.LlLector)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_LECTOR");
            entity.Property(e => e.LlMed)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_MED");
            entity.Property(e => e.LlMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("LL_MES");
            entity.Property(e => e.LlNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_NOM");
            entity.Property(e => e.LlObs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_OBS");
            entity.Property(e => e.LlObsnf)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_OBSNF");
            entity.Property(e => e.LlObssm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_OBSSM");
            entity.Property(e => e.LlRdes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_RDES");
            entity.Property(e => e.LlRut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_RUT");
            entity.Property(e => e.LlSdes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_SDES");
            entity.Property(e => e.LlSec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_SEC");
            entity.Property(e => e.LlTar)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LL_TAR");
        });

        modelBuilder.Entity<FcPrmoraCp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRMORA_CP");

            entity.HasIndex(e => e.PrIdop, "IX_FC_PRMORA_CP");

            entity.Property(e => e.PrA)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_A");
            entity.Property(e => e.PrAvg)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_AVG");
            entity.Property(e => e.PrC)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_C");
            entity.Property(e => e.PrCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CLI");
            entity.Property(e => e.PrCon)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_CON");
            entity.Property(e => e.PrDa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DA");
            entity.Property(e => e.PrDc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DC");
            entity.Property(e => e.PrDeuda)
                .HasColumnType("money")
                .HasColumnName("PR_DEUDA");
            entity.Property(e => e.PrDir)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DIR");
            entity.Property(e => e.PrDr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DR");
            entity.Property(e => e.PrDs)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_DS");
            entity.Property(e => e.PrEstado)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_ESTADO");
            entity.Property(e => e.PrIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IDOP");
            entity.Property(e => e.PrIt)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IT");
            entity.Property(e => e.PrN)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_N");
            entity.Property(e => e.PrNom)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("PR_NOM");
            entity.Property(e => e.PrObs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_OBS");
            entity.Property(e => e.PrPervar)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_PERVAR");
            entity.Property(e => e.PrR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_R");
            entity.Property(e => e.PrS)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_S");
            entity.Property(e => e.PrTaral)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TARAL");
            entity.Property(e => e.PrTarap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TARAP");
        });

        modelBuilder.Entity<FcPrndatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRNDATA");

            entity.HasIndex(e => e.PdOpid, "IX_FC_PRNDATA_01").IsClustered();

            entity.Property(e => e.PdAmount)
                .HasColumnType("money")
                .HasColumnName("PD_AMOUNT");
            entity.Property(e => e.PdCateg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PD_CATEG");
            entity.Property(e => e.PdCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PD_CCONTROL");
            entity.Property(e => e.PdCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PD_CLI");
            entity.Property(e => e.PdConcept)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PD_CONCEPT");
            entity.Property(e => e.PdDosid).HasColumnName("PD_DOSID");
            entity.Property(e => e.PdDosseq).HasColumnName("PD_DOSSEQ");
            entity.Property(e => e.PdEstf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PD_ESTF");
            entity.Property(e => e.PdId).HasColumnName("PD_ID");
            entity.Property(e => e.PdMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PD_MEDIDOR");
            entity.Property(e => e.PdNauto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PD_NAUTO");
            entity.Property(e => e.PdOpid).HasColumnName("PD_OPID");
            entity.Property(e => e.PdPer)
                .HasColumnType("datetime")
                .HasColumnName("PD_PER");
            entity.Property(e => e.PdSeq).HasColumnName("PD_SEQ");
        });

        modelBuilder.Entity<FcPrnoservice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRNOSERVICES");

            entity.HasIndex(e => new { e.OsOpid, e.OsAño, e.OsMes, e.OsCod }, "IX_FC_PRNOSERVICES_01").IsClustered();

            entity.Property(e => e.OsAmount)
                .HasColumnType("money")
                .HasColumnName("OS_AMOUNT");
            entity.Property(e => e.OsAño).HasColumnName("OS_AÑO");
            entity.Property(e => e.OsCateg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_CATEG");
            entity.Property(e => e.OsCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_CCONTROL");
            entity.Property(e => e.OsCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_COD");
            entity.Property(e => e.OsConcept)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_CONCEPT");
            entity.Property(e => e.OsDosid).HasColumnName("OS_DOSID");
            entity.Property(e => e.OsMes).HasColumnName("OS_MES");
            entity.Property(e => e.OsNfac).HasColumnName("OS_NFAC");
            entity.Property(e => e.OsNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_NOM");
            entity.Property(e => e.OsNord)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_NORD");
            entity.Property(e => e.OsOpid).HasColumnName("OS_OPID");
            entity.Property(e => e.OsStep)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OS_STEP");
        });

        modelBuilder.Entity<FcProcoop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PROCOOP");

            entity.HasIndex(e => new { e.PcPer, e.PcCli, e.PcDosid }, "IX_FC_PROCOOP_01").IsClustered();

            entity.HasIndex(e => new { e.PcCli, e.PcDosid, e.PcDosseq }, "IX_FC_PROCOOP_02");

            entity.Property(e => e.PcCli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_CLI");
            entity.Property(e => e.PcDosid).HasColumnName("PC_DOSID");
            entity.Property(e => e.PcDosseq).HasColumnName("PC_DOSSEQ");
            entity.Property(e => e.PcFecrefanu)
                .HasColumnType("datetime")
                .HasColumnName("PC_FECREFANU");
            entity.Property(e => e.PcFproc)
                .HasColumnType("datetime")
                .HasColumnName("PC_FPROC");
            entity.Property(e => e.PcPag)
                .HasColumnType("datetime")
                .HasColumnName("PC_PAG");
            entity.Property(e => e.PcPer)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PC_PER");
            entity.Property(e => e.PcStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_STATUS");
            entity.Property(e => e.PcValue)
                .HasColumnType("money")
                .HasColumnName("PC_VALUE");
        });

        modelBuilder.Entity<FcPrplanpago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRPLANPAGOS");

            entity.HasIndex(e => e.PpIdop, "IX_FC_PRPLANPAGOS");

            entity.Property(e => e.PpAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_AÑO");
            entity.Property(e => e.PpCaja)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_CAJA");
            entity.Property(e => e.PpCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_CLI");
            entity.Property(e => e.PpDiasmora)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_DIASMORA");
            entity.Property(e => e.PpFclose)
                .HasColumnType("datetime")
                .HasColumnName("PP_FCLOSE");
            entity.Property(e => e.PpFpag)
                .HasColumnType("datetime")
                .HasColumnName("PP_FPAG");
            entity.Property(e => e.PpFsol)
                .HasColumnType("datetime")
                .HasColumnName("PP_FSOL");
            entity.Property(e => e.PpIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_IDOP");
            entity.Property(e => e.PpIdsol)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_IDSOL");
            entity.Property(e => e.PpMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_MES");
            entity.Property(e => e.PpNow)
                .HasColumnType("datetime")
                .HasColumnName("PP_NOW");
            entity.Property(e => e.PpNpagados)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_NPAGADOS");
            entity.Property(e => e.PpNpagos)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_NPAGOS");
            entity.Property(e => e.PpNrec)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PP_NREC");
            entity.Property(e => e.PpPagmin)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PP_PAGMIN");
            entity.Property(e => e.PpPagpla)
                .HasColumnType("datetime")
                .HasColumnName("PP_PAGPLA");
            entity.Property(e => e.PpTdeuda)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PP_TDEUDA");
            entity.Property(e => e.PpTpagado)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PP_TPAGADO");
            entity.Property(e => e.PpType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PP_TYPE");
        });

        modelBuilder.Entity<FcPrproform>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRPROFORM");

            entity.Property(e => e.PrCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_CLI");
            entity.Property(e => e.PrCon)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_CON");
            entity.Property(e => e.PrFval)
                .HasColumnType("datetime")
                .HasColumnName("PR_FVAL");
            entity.Property(e => e.PrIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_IDOP");
            entity.Property(e => e.PrImp)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("PR_IMP");
            entity.Property(e => e.PrIns)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_INS");
            entity.Property(e => e.PrLact)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_LACT");
            entity.Property(e => e.PrLant)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_LANT");
            entity.Property(e => e.PrLit)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_LIT");
            entity.Property(e => e.PrMed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_MED");
            entity.Property(e => e.PrPer)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_PER");
            entity.Property(e => e.PrSeq)
                .HasDefaultValueSql("(0)")
                .HasColumnName("PR_SEQ");
        });

        modelBuilder.Entity<FcPrreconex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_PRRECONEX");

            entity.HasIndex(e => e.ReIdop, "IX_FC_PRRECONEX");

            entity.Property(e => e.ReAre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_ARE");
            entity.Property(e => e.ReCat)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_CAT");
            entity.Property(e => e.ReCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_CIC");
            entity.Property(e => e.ReCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_CLI");
            entity.Property(e => e.ReDesa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_DESA");
            entity.Property(e => e.ReDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_DESC");
            entity.Property(e => e.ReDesr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_DESR");
            entity.Property(e => e.ReDess)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_DESS");
            entity.Property(e => e.ReDir)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_DIR");
            entity.Property(e => e.ReFo)
                .HasColumnType("datetime")
                .HasColumnName("RE_FO");
            entity.Property(e => e.ReIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RE_IDOP");
            entity.Property(e => e.ReIt)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RE_IT");
            entity.Property(e => e.ReLec)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_LEC");
            entity.Property(e => e.ReMed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_MED");
            entity.Property(e => e.ReNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_NOM");
            entity.Property(e => e.ReRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_RUT");
            entity.Property(e => e.ReSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_SEC");
        });

        modelBuilder.Entity<FcRcrecordsexpireGlobal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_RCRECORDSEXPIRE_GLOBAL");

            entity.HasIndex(e => e.CcIdop, "IX_CR_FLOWOFCHARGES01");

            entity.HasIndex(e => e.CcRut, "IX_CR_FLOWOFCHARGES02");

            entity.HasIndex(e => new { e.CcIdop, e.CcStep }, "IX_CR_FLOWOFCHARGES03");

            entity.Property(e => e.CcAl)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CC_AL");
            entity.Property(e => e.CcAp)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CC_AP");
            entity.Property(e => e.CcArea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_AREA");
            entity.Property(e => e.CcAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CC_AÑO");
            entity.Property(e => e.CcCatal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CATAL");
            entity.Property(e => e.CcCatap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CATAP");
            entity.Property(e => e.CcCic)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CIC");
            entity.Property(e => e.CcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CLI");
            entity.Property(e => e.CcDescr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_DESCR");
            entity.Property(e => e.CcDirec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_DIREC");
            entity.Property(e => e.CcDosid)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CC_DOSID");
            entity.Property(e => e.CcDosseq)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CC_DOSSEQ");
            entity.Property(e => e.CcDveg)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CC_DVEG");
            entity.Property(e => e.CcEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_ESTADO");
            entity.Property(e => e.CcIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CC_IDOP");
            entity.Property(e => e.CcMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CC_MES");
            entity.Property(e => e.CcN)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CC_N");
            entity.Property(e => e.CcNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_NOM");
            entity.Property(e => e.CcRc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("CC_RC");
            entity.Property(e => e.CcRut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_RUT");
            entity.Property(e => e.CcSec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_SEC");
            entity.Property(e => e.CcStep)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_STEP");
            entity.Property(e => e.CcTotal)
                .HasComputedColumnSql("([CC_AP] + [CC_AL] + [CC_RC] - [CC_DVEG])", false)
                .HasColumnType("money")
                .HasColumnName("CC_TOTAL");
        });

        modelBuilder.Entity<FcRcrecordsexpirecc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_RCRECORDSEXPIRECC");

            entity.HasIndex(e => e.CcOpid, "IX_FC_RCRECORDSEXPIRECC_01");

            entity.Property(e => e.CcAl)
                .HasColumnType("money")
                .HasColumnName("CC_AL");
            entity.Property(e => e.CcAp)
                .HasColumnType("money")
                .HasColumnName("CC_AP");
            entity.Property(e => e.CcAño).HasColumnName("CC_AÑO");
            entity.Property(e => e.CcCatal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CATAL");
            entity.Property(e => e.CcCatap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CATAP");
            entity.Property(e => e.CcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_CLI");
            entity.Property(e => e.CcDescr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_DESCR");
            entity.Property(e => e.CcDirec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_DIREC");
            entity.Property(e => e.CcDv)
                .HasColumnType("money")
                .HasColumnName("CC_DV");
            entity.Property(e => e.CcMes).HasColumnName("CC_MES");
            entity.Property(e => e.CcN)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CC_N");
            entity.Property(e => e.CcNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_NOM");
            entity.Property(e => e.CcOi)
                .HasColumnType("money")
                .HasColumnName("CC_OI");
            entity.Property(e => e.CcOpid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CC_OPID");
            entity.Property(e => e.CcPer)
                .HasColumnType("datetime")
                .HasColumnName("CC_PER");
            entity.Property(e => e.CcProcoop)
                .HasColumnType("money")
                .HasColumnName("CC_PROCOOP");
            entity.Property(e => e.CcRc)
                .HasColumnType("money")
                .HasColumnName("CC_RC");
            entity.Property(e => e.CcRut)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_RUT");
            entity.Property(e => e.CcSeq)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CC_SEQ");
            entity.Property(e => e.CcStep)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CC_STEP");
            entity.Property(e => e.CcTotal)
                .HasComputedColumnSql("(([CC_AP]+[CC_AL])+[CC_RC])", false)
                .HasColumnType("money")
                .HasColumnName("CC_TOTAL");
        });

        modelBuilder.Entity<FcRecorrido>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_RECORRIDOS");

            entity.Property(e => e.RcCodrec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_CODREC");
            entity.Property(e => e.RcDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_DESC");
            entity.Property(e => e.RcIdare)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RC_IDARE");
            entity.Property(e => e.RcIdcic)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RC_IDCIC");
            entity.Property(e => e.RcIdsec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RC_IDSEC");
            entity.Property(e => e.RcLector)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RC_LECTOR");
        });

        modelBuilder.Entity<FcRecplalect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_RECPLALECT_");

            entity.Property(e => e.RcAre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_ARE");
            entity.Property(e => e.RcCic)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_CIC");
            entity.Property(e => e.RcEst)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RC_EST");
            entity.Property(e => e.RcIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RC_IDOP");
            entity.Property(e => e.RcJob)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_JOB");
            entity.Property(e => e.RcLec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_LEC");
            entity.Property(e => e.RcRec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RC_REC");
            entity.Property(e => e.RcSec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_SEC");
        });

        modelBuilder.Entity<FcRecplfact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_RECPLFACT_");

            entity.Property(e => e.RcAre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_ARE");
            entity.Property(e => e.RcCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_CIC");
            entity.Property(e => e.RcErrors)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_ERRORS");
            entity.Property(e => e.RcEst)
                .HasDefaultValueSql("(0)")
                .HasColumnName("RC_EST");
            entity.Property(e => e.RcRec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_REC");
            entity.Property(e => e.RcSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RC_SEC");
        });

        modelBuilder.Entity<FcRecplfact1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_RECPLFACT1_");

            entity.Property(e => e.RcAre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RC_ARE");
            entity.Property(e => e.RcCic)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RC_CIC");
            entity.Property(e => e.RcCodlec)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RC_CODLEC");
            entity.Property(e => e.RcEst).HasColumnName("RC_EST");
            entity.Property(e => e.RcFeclec)
                .HasColumnType("datetime")
                .HasColumnName("RC_FECLEC");
            entity.Property(e => e.RcN).HasColumnName("RC_N");
            entity.Property(e => e.RcRec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RC_REC");
            entity.Property(e => e.RcSec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("RC_SEC");
        });

        modelBuilder.Entity<FcRecsdelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_RECSDELETE");

            entity.HasIndex(e => e.DeIdop, "IX_FC_RECSDELETE");

            entity.HasIndex(e => new { e.DeAre, e.DeCic, e.DeSec, e.DeRut, e.DeFec }, "IX_FC_RECSDELETE_1");

            entity.Property(e => e.DeAre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DE_ARE");
            entity.Property(e => e.DeCic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DE_CIC");
            entity.Property(e => e.DeEst)
                .HasDefaultValueSql("(0)")
                .HasColumnName("DE_EST");
            entity.Property(e => e.DeFec)
                .HasColumnType("datetime")
                .HasColumnName("DE_FEC");
            entity.Property(e => e.DeIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("DE_IDOP");
            entity.Property(e => e.DeRut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DE_RUT");
            entity.Property(e => e.DeSec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DE_SEC");
            entity.Property(e => e.DeType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DE_TYPE");
        });

        modelBuilder.Entity<FcRefanuMot>(entity =>
        {
            entity.HasKey(e => e.RaId);

            entity.ToTable("FC_REFANU_MOT");

            entity.Property(e => e.RaId).HasColumnName("RA_ID");
            entity.Property(e => e.RaDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RA_DESC");
            entity.Property(e => e.RaUso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RA_USO");
        });

        modelBuilder.Entity<FcRepcli>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_REPCLI");

            entity.HasIndex(e => e.RpCodcli, "IDX_CODCLI");

            entity.HasIndex(e => e.RpEstado, "IDX_MED");

            entity.HasIndex(e => e.RpNombre, "IDX_NOM");

            entity.Property(e => e.RpArea)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RP_AREA");
            entity.Property(e => e.RpCategAl)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RP_CATEG_AL");
            entity.Property(e => e.RpCategAp)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("RP_CATEG_AP");
            entity.Property(e => e.RpCiclo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RP_CICLO");
            entity.Property(e => e.RpCodcli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RP_CODCLI");
            entity.Property(e => e.RpDirec)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RP_DIREC");
            entity.Property(e => e.RpEstado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RP_ESTADO");
            entity.Property(e => e.RpMedidor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RP_MEDIDOR");
            entity.Property(e => e.RpNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RP_NITCI");
            entity.Property(e => e.RpNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RP_NOMBRE");
            entity.Property(e => e.RpOpid).HasColumnName("RP_OPID");
            entity.Property(e => e.RpRuta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RP_RUTA");
            entity.Property(e => e.RpSecc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RP_SECC");
            entity.Property(e => e.RpSector)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RP_SECTOR");
        });

        modelBuilder.Entity<FcRepcli01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_REPCLI01");

            entity.Property(e => e.RpDater)
                .HasColumnType("datetime")
                .HasColumnName("RP_dater");
            entity.Property(e => e.RpDatew)
                .HasColumnType("datetime")
                .HasColumnName("RP_datew");
        });

        modelBuilder.Entity<FcSector>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_SECTOR");

            entity.Property(e => e.SeCodsec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SE_CODSEC");
            entity.Property(e => e.SeDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SE_DESC");
            entity.Property(e => e.SeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SE_ID");
            entity.Property(e => e.SeIdare).HasColumnName("SE_IDARE");
            entity.Property(e => e.SeIdcic).HasColumnName("SE_IDCIC");
        });

        modelBuilder.Entity<FcSolicitud>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_SOLICITUD");

            entity.HasIndex(e => new { e.SoFechai, e.SoFechaf }, "IDX_FECHA");

            entity.HasIndex(e => new { e.SoPaterno, e.SoMaterno, e.SoNombre }, "IDX_NOMBRE");

            entity.HasIndex(e => e.SoNro, "IDX_NRO");

            entity.Property(e => e.SoCateg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SO_CATEG");
            entity.Property(e => e.SoCheck)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SO_CHECK");
            entity.Property(e => e.SoCirun)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SO_CIRUN");
            entity.Property(e => e.SoCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SO_CTACLI");
            entity.Property(e => e.SoCtto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SO_CTTO");
            entity.Property(e => e.SoDirec)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SO_DIREC");
            entity.Property(e => e.SoDirentre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SO_DIRENTRE");
            entity.Property(e => e.SoDirnro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SO_DIRNRO");
            entity.Property(e => e.SoDiry)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SO_DIRY");
            entity.Property(e => e.SoEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SO_ESTADO");
            entity.Property(e => e.SoFechaf)
                .HasColumnType("datetime")
                .HasColumnName("SO_FECHAF");
            entity.Property(e => e.SoFechai)
                .HasColumnType("datetime")
                .HasColumnName("SO_FECHAI");
            entity.Property(e => e.SoLocalidad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SO_LOCALIDAD");
            entity.Property(e => e.SoMaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SO_MATERNO");
            entity.Property(e => e.SoMed).HasColumnName("SO_MED");
            entity.Property(e => e.SoModred)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SO_MODRED");
            entity.Property(e => e.SoNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SO_NOMBRE");
            entity.Property(e => e.SoNro).HasColumnName("SO_NRO");
            entity.Property(e => e.SoObser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SO_OBSER");
            entity.Property(e => e.SoOper).HasColumnName("SO_OPER");
            entity.Property(e => e.SoPaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SO_PATERNO");
            entity.Property(e => e.SoPropDo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SO_PROP_DO");
            entity.Property(e => e.SoSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SO_SISTEMA");
            entity.Property(e => e.SoTelefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SO_TELEFONO");
            entity.Property(e => e.SoTiempo).HasColumnName("SO_TIEMPO");
            entity.Property(e => e.SoTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SO_TIPO");
            entity.Property(e => e.SoZona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SO_ZONA");
        });

        modelBuilder.Entity<FcStatisticTf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_STATISTIC_TF");

            entity.HasIndex(e => e.TfIdop, "IX_FC_STATISTIC_TF01");

            entity.Property(e => e.TfAl)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("TF_AL");
            entity.Property(e => e.TfAp)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("TF_AP");
            entity.Property(e => e.TfApal)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("TF_APAL");
            entity.Property(e => e.TfAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_AÑO");
            entity.Property(e => e.TfCf)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("TF_CF");
            entity.Property(e => e.TfCon)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_CON");
            entity.Property(e => e.TfIdop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_IDOP");
            entity.Property(e => e.TfLey)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("TF_LEY");
            entity.Property(e => e.TfMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_MES");
            entity.Property(e => e.TfOie)
                .HasColumnType("money")
                .HasColumnName("TF_OIE");
            entity.Property(e => e.TfProcoop)
                .HasColumnType("money")
                .HasColumnName("TF_PROCOOP");
            entity.Property(e => e.TfRc)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money")
                .HasColumnName("TF_RC");
            entity.Property(e => e.TfTar)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TF_TAR");
            entity.Property(e => e.TfTotclifac)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_TOTCLIFAC");
            entity.Property(e => e.TfTotclimin)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_TOTCLIMIN");
            entity.Property(e => e.TfTotclinor)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_TOTCLINOR");
            entity.Property(e => e.TfType)
                .HasDefaultValueSql("(0)")
                .HasColumnName("TF_TYPE");
        });

        modelBuilder.Entity<FcStatisticTf01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_STATISTIC_TF01");

            entity.HasIndex(e => new { e.Opid, e.Codigo }, "IX_FC_STATISTIC_TF01_01").IsClustered();

            entity.Property(e => e.Año).HasColumnName("AÑO");
            entity.Property(e => e.Categap)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CATEGAP");
            entity.Property(e => e.Categas)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CATEGAS");
            entity.Property(e => e.Ccontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CCONTROL");
            entity.Property(e => e.Codigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CODIGO");
            entity.Property(e => e.Consumo).HasColumnName("CONSUMO");
            entity.Property(e => e.Desas)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DESAS");
            entity.Property(e => e.Descdom)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("DESCDOM");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Dosid).HasColumnName("DOSID");
            entity.Property(e => e.Dosseq).HasColumnName("DOSSEQ");
            entity.Property(e => e.Exedente)
                .HasColumnType("money")
                .HasColumnName("EXEDENTE");
            entity.Property(e => e.Feclact)
                .HasColumnType("datetime")
                .HasColumnName("FECLACT");
            entity.Property(e => e.Feclant)
                .HasColumnType("datetime")
                .HasColumnName("FECLANT");
            entity.Property(e => e.Ialc)
                .HasColumnType("money")
                .HasColumnName("IALC");
            entity.Property(e => e.Iley1886)
                .HasColumnType("money")
                .HasColumnName("ILEY1886");
            entity.Property(e => e.Irc)
                .HasColumnType("money")
                .HasColumnName("IRC");
            entity.Property(e => e.Itotal)
                .HasComputedColumnSql("((((([MINIMO]+[EXEDENTE])+[IALC])+[IRC])+[ILEY1886])+([DESCDOM]+[DESAS]))", false)
                .HasColumnType("decimal(20, 4)")
                .HasColumnName("ITOTAL");
            entity.Property(e => e.Lecact).HasColumnName("LECACT");
            entity.Property(e => e.Lecant).HasColumnName("LECANT");
            entity.Property(e => e.Mes).HasColumnName("MES");
            entity.Property(e => e.Minimo)
                .HasColumnType("money")
                .HasColumnName("MINIMO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Opid).HasColumnName("OPID");
            entity.Property(e => e.Ruta)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RUTA");
        });

        modelBuilder.Entity<FcSuspReha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_SUSP_REHA");

            entity.HasIndex(e => e.SrCtacli, "IDX_CTACLI");

            entity.HasIndex(e => new { e.SrFechai, e.SrFechaf }, "IDX_FECHA");

            entity.HasIndex(e => e.SrNroso, "IDX_NROSO");

            entity.Property(e => e.SrCateg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SR_CATEG");
            entity.Property(e => e.SrCtacli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SR_CTACLI");
            entity.Property(e => e.SrDirec)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SR_DIREC");
            entity.Property(e => e.SrFechaf)
                .HasColumnType("datetime")
                .HasColumnName("SR_FECHAF");
            entity.Property(e => e.SrFechai)
                .HasColumnType("datetime")
                .HasColumnName("SR_FECHAI");
            entity.Property(e => e.SrInsp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SR_INSP");
            entity.Property(e => e.SrLectura)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SR_LECTURA");
            entity.Property(e => e.SrNombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SR_NOMBRE");
            entity.Property(e => e.SrNromed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SR_NROMED");
            entity.Property(e => e.SrNroso).HasColumnName("SR_NROSO");
            entity.Property(e => e.SrPoste)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SR_POSTE");
            entity.Property(e => e.SrSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SR_SIST");
            entity.Property(e => e.SrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SR_TIPO");
            entity.Property(e => e.SrTipos).HasColumnName("SR_TIPOS");
        });

        modelBuilder.Entity<FcTasabank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_TASABANK");

            entity.HasIndex(e => e.TbFecvig, "IX_FC_TASAS");

            entity.Property(e => e.TbFecvig)
                .HasColumnType("datetime")
                .HasColumnName("TB_FECVIG");
            entity.Property(e => e.TbTasabank)
                .HasColumnType("money")
                .HasColumnName("TB_TASABANK");
        });

        modelBuilder.Entity<FcTecnico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_TECNICO");

            entity.HasIndex(e => e.TeCod, "IDX_COD");

            entity.HasIndex(e => e.TeNombre, "IDX_NOMBRE");

            entity.Property(e => e.TeActividad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TE_ACTIVIDAD");
            entity.Property(e => e.TeCod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TE_COD");
            entity.Property(e => e.TeDesUni)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TE_DES_UNI");
            entity.Property(e => e.TeNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TE_NOMBRE");
            entity.Property(e => e.TeUnidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TE_UNIDAD");
        });

        modelBuilder.Entity<FcTipocaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_TIPOCAJA");

            entity.HasIndex(e => e.CaCod, "IDX_COD");

            entity.Property(e => e.CaCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CA_COD");
            entity.Property(e => e.CaDesc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CA_DESC");
        });

        modelBuilder.Entity<FcTrasmedi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_TRASMEDI");

            entity.HasIndex(e => new { e.TmFechai, e.TmFechaf }, "IDX_FECHA");

            entity.HasIndex(e => e.TmNroso, "IDX_NROSO");

            entity.Property(e => e.TmCambiodir).HasColumnName("TM_CAMBIODIR");
            entity.Property(e => e.TmCateg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TM_CATEG");
            entity.Property(e => e.TmCtacliA)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TM_CTACLI_A");
            entity.Property(e => e.TmCtacliN)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TM_CTACLI_N");
            entity.Property(e => e.TmDirec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TM_DIREC");
            entity.Property(e => e.TmFechaf)
                .HasColumnType("datetime")
                .HasColumnName("TM_FECHAF");
            entity.Property(e => e.TmFechai)
                .HasColumnType("datetime")
                .HasColumnName("TM_FECHAI");
            entity.Property(e => e.TmInsp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TM_INSP");
            entity.Property(e => e.TmLectura)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TM_LECTURA");
            entity.Property(e => e.TmModred).HasColumnName("TM_MODRED");
            entity.Property(e => e.TmNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TM_NOMBRE");
            entity.Property(e => e.TmNromed)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TM_NROMED");
            entity.Property(e => e.TmNroso).HasColumnName("TM_NROSO");
            entity.Property(e => e.TmPosteact)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TM_POSTEACT");
            entity.Property(e => e.TmPosteant)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TM_POSTEANT");
            entity.Property(e => e.TmPotckw)
                .HasColumnType("money")
                .HasColumnName("TM_POTCKW");
            entity.Property(e => e.TmSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TM_SIST");
        });

        modelBuilder.Entity<FcUbicaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FC_UBICAJA");

            entity.HasIndex(e => e.UbCod, "IDX_COD");

            entity.Property(e => e.UbCod).HasColumnName("UB_COD");
            entity.Property(e => e.UbDesc)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("UB_DESC");
        });

        modelBuilder.Entity<InActivaT>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_ACTIVA_T");

            entity.Property(e => e.TiActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("TI_ACTIVO");
            entity.Property(e => e.TiId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TI_ID");
        });

        modelBuilder.Entity<InArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_AREA");

            entity.Property(e => e.ArCodigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.ArDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("AR_DESC");
            entity.Property(e => e.ArId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AR_ID");
        });

        modelBuilder.Entity<InArmazonInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_ARMAZON_INV");

            entity.Property(e => e.ArCantidad).HasColumnName("AR_CANTIDAD");
            entity.Property(e => e.ArForma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AR_FORMA");
            entity.Property(e => e.ArMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AR_MATERIAL");
            entity.Property(e => e.ArSerInv).HasColumnName("AR_SER_INV");
            entity.Property(e => e.ArSerial).HasColumnName("AR_SERIAL");
        });

        modelBuilder.Entity<InBodega>(entity =>
        {
            entity.HasKey(e => e.BoId);

            entity.ToTable("IN_BODEGA");

            entity.Property(e => e.BoId).HasColumnName("BO_ID");
            entity.Property(e => e.BoArea)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('U')")
                .HasColumnName("BO_AREA");
            entity.Property(e => e.BoCentral).HasColumnName("BO_CENTRAL");
            entity.Property(e => e.BoCodconta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("BO_CODCONTA");
            entity.Property(e => e.BoCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("BO_CODIGO");
            entity.Property(e => e.BoContracta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("BO_CONTRACTA");
            entity.Property(e => e.BoDireccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("BO_DIRECCION");
            entity.Property(e => e.BoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("BO_NOMBRE");
            entity.Property(e => e.BoRespon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BO_RESPON");
            entity.Property(e => e.BoSuc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BO_SUC");
        });

        modelBuilder.Entity<InCorrelativo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_CORRELATIVO");

            entity.Property(e => e.CoAsentar).HasColumnName("CO_ASENTAR");
            entity.Property(e => e.CoCuentaC).HasColumnName("CO_CUENTA_C");
            entity.Property(e => e.CoCuentaP).HasColumnName("CO_CUENTA_P");
            entity.Property(e => e.CoFlete).HasColumnName("CO_FLETE");
            entity.Property(e => e.CoNotaa).HasColumnName("CO_NOTAA");
            entity.Property(e => e.CoNotac).HasColumnName("CO_NOTAC");
            entity.Property(e => e.CoPrestamo).HasColumnName("CO_PRESTAMO");
        });

        modelBuilder.Entity<InDescuento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_DESCUENTO");

            entity.Property(e => e.TdCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TD_CODIGO");
            entity.Property(e => e.TdDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TD_DESC");
            entity.Property(e => e.TdFactor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TD_FACTOR");
            entity.Property(e => e.TdSerial).HasColumnName("TD_SERIAL");
            entity.Property(e => e.TdTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TD_TIPO");
        });

        modelBuilder.Entity<InDoccorre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_DOCCORRE");

            entity.Property(e => e.CoFactuma).HasColumnName("CO_FACTUMA");
            entity.Property(e => e.CoFactuve).HasColumnName("CO_FACTUVE");
            entity.Property(e => e.CoReciboco).HasColumnName("CO_RECIBOCO");
            entity.Property(e => e.CoRecibove).HasColumnName("CO_RECIBOVE");
            entity.Property(e => e.CoSuc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CO_SUC");
        });

        modelBuilder.Entity<InDocument>(entity =>
        {
            entity.HasKey(e => e.DiId);

            entity.ToTable("IN_DOCUMENT");

            entity.Property(e => e.DiId).HasColumnName("DI_ID");
            entity.Property(e => e.DiAlmacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_ALMACEN");
            entity.Property(e => e.DiCambio)
                .HasColumnType("money")
                .HasColumnName("DI_CAMBIO");
            entity.Property(e => e.DiCcosto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_CCOSTO");
            entity.Property(e => e.DiCtapag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_CTAPAG");
            entity.Property(e => e.DiDocumen)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DI_DOCUMEN");
            entity.Property(e => e.DiEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("DI_ESTADO");
            entity.Property(e => e.DiFac).HasColumnName("DI_FAC");
            entity.Property(e => e.DiFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("smalldatetime")
                .HasColumnName("DI_FECHA");
            entity.Property(e => e.DiFechae)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("smalldatetime")
                .HasColumnName("DI_FECHAE");
            entity.Property(e => e.DiFechaman)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("DI_FECHAMAN");
            entity.Property(e => e.DiFormapago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("DI_FORMAPAGO");
            entity.Property(e => e.DiGlosa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("DI_GLOSA");
            entity.Property(e => e.DiIdagen).HasColumnName("DI_IDAGEN");
            entity.Property(e => e.DiIdconta).HasColumnName("DI_IDCONTA");
            entity.Property(e => e.DiIdprocli)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_IDPROCLI");
            entity.Property(e => e.DiIdtran).HasColumnName("DI_IDTRAN");
            entity.Property(e => e.DiIngreso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DI_INGRESO");
            entity.Property(e => e.DiNomche)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_NOMCHE");
            entity.Property(e => e.DiNomsolic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("DI_NOMSOLIC");
            entity.Property(e => e.DiNroche)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_NROCHE");
            entity.Property(e => e.DiNrodoc).HasColumnName("DI_NRODOC");
            entity.Property(e => e.DiNrofac)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DI_NROFAC");
            entity.Property(e => e.DiNrosolic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("DI_NROSOLIC");
            entity.Property(e => e.DiNrove).HasColumnName("DI_NROVE");
            entity.Property(e => e.DiOp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('I')")
                .HasColumnName("DI_OP");
            entity.Property(e => e.DiSector)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("DI_SECTOR");
            entity.Property(e => e.DiSuc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_SUC");
            entity.Property(e => e.DiTipodoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("DI_TIPODOC");
            entity.Property(e => e.DiTipogasto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("DI_TIPOGASTO");
            entity.Property(e => e.DiToagen)
                .HasColumnType("money")
                .HasColumnName("DI_TOAGEN");
            entity.Property(e => e.DiToprov)
                .HasColumnType("money")
                .HasColumnName("DI_TOPROV");
            entity.Property(e => e.DiTotran)
                .HasColumnType("money")
                .HasColumnName("DI_TOTRAN");
            entity.Property(e => e.DiTxfac)
                .HasMaxLength(550)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_TXFAC");
            entity.Property(e => e.DiUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_USER");
            entity.Property(e => e.DiVende)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DI_VENDE");
        });

        modelBuilder.Entity<InDocumentG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_DOCUMENT_G");

            entity.Property(e => e.MoCodcli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("MO_CODCLI");
            entity.Property(e => e.MoCorre).HasColumnName("MO_CORRE");
            entity.Property(e => e.MoEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .IsFixedLength()
                .HasColumnName("MO_ESTADO");
            entity.Property(e => e.MoFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("MO_FECHA");
            entity.Property(e => e.MoGlosa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("MO_GLOSA");
            entity.Property(e => e.MoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MO_ID");
            entity.Property(e => e.MoMoneda)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('B')")
                .HasColumnName("MO_MONEDA");
            entity.Property(e => e.MoNrove).HasColumnName("MO_NROVE");
            entity.Property(e => e.MoTc)
                .HasColumnType("smallmoney")
                .HasColumnName("MO_TC");
            entity.Property(e => e.MoTipodoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("MO_TIPODOC");
        });

        modelBuilder.Entity<InFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_FECHA");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InFechatraspaso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_FECHATRASPASO");

            entity.Property(e => e.TrFecha)
                .HasColumnType("datetime")
                .HasColumnName("TR_FECHA");
            entity.Property(e => e.TrFechaF)
                .HasColumnType("datetime")
                .HasColumnName("TR_FECHA_F");
            entity.Property(e => e.TrFechaI)
                .HasColumnType("datetime")
                .HasColumnName("TR_FECHA_I");
        });

        modelBuilder.Entity<InFisico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_FISICO");

            entity.Property(e => e.FiCantdif)
                .HasColumnType("money")
                .HasColumnName("FI_CANTDIF");
            entity.Property(e => e.FiCantidad)
                .HasColumnType("money")
                .HasColumnName("FI_CANTIDAD");
            entity.Property(e => e.FiCantidadr)
                .HasColumnType("money")
                .HasColumnName("FI_CANTIDADR");
            entity.Property(e => e.FiFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("FI_FECHA");
            entity.Property(e => e.FiId).HasColumnName("FI_ID");
            entity.Property(e => e.FiIdcta).HasColumnName("FI_IDCTA");
            entity.Property(e => e.FiIdin).HasColumnName("FI_IDIN");
        });

        modelBuilder.Entity<InGrupoProm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_GRUPO_PROM");

            entity.Property(e => e.GrCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GR_CIUDAD");
            entity.Property(e => e.GrCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("GR_CODIGO");
            entity.Property(e => e.GrCorr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GR_CORR");
            entity.Property(e => e.GrNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GR_NOMBRE");
            entity.Property(e => e.GrRep).HasColumnName("GR_REP");
            entity.Property(e => e.GrSerial).HasColumnName("GR_SERIAL");
        });

        modelBuilder.Entity<InGrupoinv>(entity =>
        {
            entity.HasKey(e => e.GrId);

            entity.ToTable("IN_GRUPOINV");

            entity.Property(e => e.GrId).HasColumnName("GR_ID");
            entity.Property(e => e.GrCodigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GR_CODIGO");
            entity.Property(e => e.GrConta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("GR_CONTA");
            entity.Property(e => e.GrCorr).HasColumnName("GR_CORR");
            entity.Property(e => e.GrNombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("GR_NOMBRE");
            entity.Property(e => e.GrObs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("GR_OBS");
            entity.Property(e => e.GrRep).HasColumnName("GR_REP");
        });

        modelBuilder.Entity<InHistorialPre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_HISTORIAL_PRE");

            entity.Property(e => e.InPreCom)
                .HasColumnType("money")
                .HasColumnName("IN_PRE_COM");
            entity.Property(e => e.InPreCosto)
                .HasColumnType("money")
                .HasColumnName("IN_PRE_COSTO");
            entity.Property(e => e.InPreU)
                .HasColumnType("money")
                .HasColumnName("IN_PRE_U");
            entity.Property(e => e.InSerInv).HasColumnName("IN_SER_INV");
            entity.Property(e => e.InSerial).HasColumnName("IN_SERIAL");
            entity.Property(e => e.InTc)
                .HasColumnType("money")
                .HasColumnName("IN_TC");
        });

        modelBuilder.Entity<InHistorialPrecio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_HISTORIAL_PRECIO");

            entity.Property(e => e.InId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IN_ID");
            entity.Property(e => e.InIdin).HasColumnName("IN_IDIN");
            entity.Property(e => e.InPrecom)
                .HasColumnType("money")
                .HasColumnName("IN_PRECOM");
            entity.Property(e => e.InPrecosto)
                .HasColumnType("money")
                .HasColumnName("IN_PRECOSTO");
            entity.Property(e => e.InPreu)
                .HasColumnType("money")
                .HasColumnName("IN_PREU");
            entity.Property(e => e.InTc)
                .HasColumnType("money")
                .HasColumnName("IN_TC");
        });

        modelBuilder.Entity<InIdfisico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_IDFISICO");

            entity.Property(e => e.IfDetalle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IF_DETALLE");
            entity.Property(e => e.IfFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("IF_FECHA");
            entity.Property(e => e.IfId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IF_ID");
        });

        modelBuilder.Entity<InImpEnc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_IMP_ENC");

            entity.Property(e => e.ImEntrega).HasColumnName("IM_ENTREGA");
            entity.Property(e => e.ImFecha)
                .HasColumnType("datetime")
                .HasColumnName("IM_FECHA");
            entity.Property(e => e.ImFechaOc)
                .HasColumnType("datetime")
                .HasColumnName("IM_FECHA_OC");
            entity.Property(e => e.ImNro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IM_NRO");
            entity.Property(e => e.ImNroImp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IM_NRO_IMP");
            entity.Property(e => e.ImNroOc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IM_NRO_OC");
            entity.Property(e => e.ImNroSolic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IM_NRO_SOLIC");
            entity.Property(e => e.ImSector)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IM_SECTOR");
            entity.Property(e => e.ImSerial).HasColumnName("IM_SERIAL");
            entity.Property(e => e.ImSolicitante)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IM_SOLICITANTE");
        });

        modelBuilder.Entity<InImpresionDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_IMPRESION_DOC");

            entity.Property(e => e.IdBco)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_BCO");
            entity.Property(e => e.IdCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_CODIGO");
            entity.Property(e => e.IdContrato).HasColumnName("ID_CONTRATO");
            entity.Property(e => e.IdDetalle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ID_DETALLE");
            entity.Property(e => e.IdDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID_DOC");
            entity.Property(e => e.IdIdent).HasColumnName("ID_IDENT");
            entity.Property(e => e.IdImporteD)
                .HasColumnType("smallmoney")
                .HasColumnName("ID_IMPORTE_D");
            entity.Property(e => e.IdImporteH)
                .HasColumnType("smallmoney")
                .HasColumnName("ID_IMPORTE_H");
            entity.Property(e => e.IdNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_NOMBRE");
            entity.Property(e => e.IdSerial).HasColumnName("ID_SERIAL");
        });

        modelBuilder.Entity<InInvBodega>(entity =>
        {
            entity.HasKey(e => e.BiId);

            entity.ToTable("IN_INV_BODEGA");

            entity.Property(e => e.BiId).HasColumnName("BI_ID");
            entity.Property(e => e.BiCant)
                .HasColumnType("money")
                .HasColumnName("BI_CANT");
            entity.Property(e => e.BiCodbode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("BI_CODBODE");
            entity.Property(e => e.BiCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("BI_CODIGO");
            entity.Property(e => e.BiCodigoba)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("BI_CODIGOBA");
            entity.Property(e => e.BiFechave)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("smalldatetime")
                .HasColumnName("BI_FECHAVE");
            entity.Property(e => e.BiIdinv).HasColumnName("BI_IDINV");
            entity.Property(e => e.BiNombode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("BI_NOMBODE");
            entity.Property(e => e.BiPrecosto)
                .HasColumnType("money")
                .HasColumnName("BI_PRECOSTO");
            entity.Property(e => e.BiSaldo)
                .HasColumnType("money")
                .HasColumnName("BI_SALDO");
        });

        modelBuilder.Entity<InInventario>(entity =>
        {
            entity.HasKey(e => e.InId);

            entity.ToTable("IN_INVENTARIO");

            entity.Property(e => e.InId).HasColumnName("IN_ID");
            entity.Property(e => e.InCantmax)
                .HasColumnType("smallmoney")
                .HasColumnName("IN_CANTMAX");
            entity.Property(e => e.InCantmin)
                .HasColumnType("smallmoney")
                .HasColumnName("IN_CANTMIN");
            entity.Property(e => e.InCodant)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_CODANT");
            entity.Property(e => e.InCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("IN_CODIGO");
            entity.Property(e => e.InCodigoba)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("IN_CODIGOBA");
            entity.Property(e => e.InCompra).HasColumnName("IN_COMPRA");
            entity.Property(e => e.InDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IN_DESC");
            entity.Property(e => e.InEmpid)
                .HasDefaultValueSql("((1))")
                .HasColumnName("IN_EMPID");
            entity.Property(e => e.InFechaC)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("smalldatetime")
                .HasColumnName("IN_FECHA_C");
            entity.Property(e => e.InFechaM)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("smalldatetime")
                .HasColumnName("IN_FECHA_M");
            entity.Property(e => e.InForma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_FORMA");
            entity.Property(e => e.InGrupo).HasColumnName("IN_GRUPO");
            entity.Property(e => e.InLongmt).HasColumnName("IN_LONGMT");
            entity.Property(e => e.InLongpu).HasColumnName("IN_LONGPU");
            entity.Property(e => e.InLote).HasColumnName("IN_LOTE");
            entity.Property(e => e.InMed1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_MED1");
            entity.Property(e => e.InMed2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_MED2");
            entity.Property(e => e.InNivel)
                .HasDefaultValueSql("((1))")
                .HasColumnName("IN_NIVEL");
            entity.Property(e => e.InNombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IN_NOMBRE");
            entity.Property(e => e.InPrecom)
                .HasColumnType("smallmoney")
                .HasColumnName("IN_PRECOM");
            entity.Property(e => e.InPrecosto)
                .HasColumnType("money")
                .HasColumnName("IN_PRECOSTO");
            entity.Property(e => e.InPrecostous)
                .HasColumnType("money")
                .HasColumnName("IN_PRECOSTOUS");
            entity.Property(e => e.InPrepon)
                .HasColumnType("smallmoney")
                .HasColumnName("IN_PREPON");
            entity.Property(e => e.InPreventa)
                .HasColumnType("money")
                .HasColumnName("IN_PREVENTA");
            entity.Property(e => e.InPreventamax)
                .HasColumnType("money")
                .HasColumnName("IN_PREVENTAMAX");
            entity.Property(e => e.InPreventaus)
                .HasColumnType("money")
                .HasColumnName("IN_PREVENTAUS");
            entity.Property(e => e.InProceso)
                .HasDefaultValueSql("((1))")
                .HasColumnName("IN_PROCESO");
            entity.Property(e => e.InPuntoped)
                .HasColumnType("smallmoney")
                .HasColumnName("IN_PUNTOPED");
            entity.Property(e => e.InStock).HasColumnName("IN_STOCK");
            entity.Property(e => e.InUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("IN_UNIDAD");
            entity.Property(e => e.InVenta)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("IN_VENTA");
        });

        modelBuilder.Entity<InLote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_LOTE");

            entity.Property(e => e.LoCantidad)
                .HasColumnType("money")
                .HasColumnName("LO_CANTIDAD");
            entity.Property(e => e.LoCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LO_CODIGO");
            entity.Property(e => e.LoFecha)
                .HasColumnType("datetime")
                .HasColumnName("LO_FECHA");
            entity.Property(e => e.LoId).HasColumnName("LO_ID");
            entity.Property(e => e.LoIdbode).HasColumnName("LO_IDBODE");
            entity.Property(e => e.LoIdprod).HasColumnName("LO_IDPROD");
            entity.Property(e => e.LoPrecio)
                .HasColumnType("money")
                .HasColumnName("LO_PRECIO");
            entity.Property(e => e.LoUbicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LO_UBICACION");
        });

        modelBuilder.Entity<InMaterialPrecio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_MATERIAL_PRECIO");

            entity.Property(e => e.PcPrecio)
                .HasColumnType("money")
                .HasColumnName("PC_PRECIO");
            entity.Property(e => e.PcSerInv).HasColumnName("PC_SER_INV");
            entity.Property(e => e.PcSerProv).HasColumnName("PC_SER_PROV");
            entity.Property(e => e.PcSerial).HasColumnName("PC_SERIAL");
        });

        modelBuilder.Entity<InMaterialProv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_MATERIAL_PROV");

            entity.Property(e => e.PrSerInv).HasColumnName("PR_SER_INV");
            entity.Property(e => e.PrSerProv).HasColumnName("PR_SER_PROV");
            entity.Property(e => e.PrSerial).HasColumnName("PR_SERIAL");
        });

        modelBuilder.Entity<InMovInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_MOV_INV");

            entity.Property(e => e.MoBodlote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_BODLOTE");
            entity.Property(e => e.MoCodigo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("MO_CODIGO");
            entity.Property(e => e.MoCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("MO_CTA");
            entity.Property(e => e.MoDebe)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_DEBE");
            entity.Property(e => e.MoDoc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("MO_DOC");
            entity.Property(e => e.MoEntradas)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_ENTRADAS");
            entity.Property(e => e.MoFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("smalldatetime")
                .HasColumnName("MO_FECHA");
            entity.Property(e => e.MoHaber)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_HABER");
            entity.Property(e => e.MoHora)
                .HasDefaultValueSql("('00:00')")
                .HasColumnType("smalldatetime")
                .HasColumnName("MO_HORA");
            entity.Property(e => e.MoNroCbte)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("MO_NRO_CBTE");
            entity.Property(e => e.MoOpid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_OPID");
            entity.Property(e => e.MoOrden)
                .ValueGeneratedOnAdd()
                .HasColumnName("MO_ORDEN");
            entity.Property(e => e.MoSaldoF)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_SALDO_F");
            entity.Property(e => e.MoSaldoV)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_SALDO_V");
            entity.Property(e => e.MoSaldoiF)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_SALDOI_F");
            entity.Property(e => e.MoSaldoiV)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_SALDOI_V");
            entity.Property(e => e.MoSalidas)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MO_SALIDAS");
            entity.Property(e => e.MoSerInv).HasColumnName("MO_SER_INV");
        });

        modelBuilder.Entity<InParametro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_PARAMETRO");

            entity.Property(e => e.PrCodgrupo)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("PR_CODGRUPO");
            entity.Property(e => e.PrCodlibre).HasColumnName("PR_CODLIBRE");
            entity.Property(e => e.PrCodunica).HasColumnName("PR_CODUNICA");
            entity.Property(e => e.PrCorrCc).HasColumnName("PR_CORR_CC");
            entity.Property(e => e.PrCorrIr).HasColumnName("PR_CORR_IR");
            entity.Property(e => e.PrCorrNc).HasColumnName("PR_CORR_NC");
            entity.Property(e => e.PrCorrNcp).HasColumnName("PR_CORR_NCP");
            entity.Property(e => e.PrCorrNi).HasColumnName("PR_CORR_NI");
            entity.Property(e => e.PrCorrNip).HasColumnName("PR_CORR_NIP");
            entity.Property(e => e.PrCorrNs).HasColumnName("PR_CORR_NS");
            entity.Property(e => e.PrCorrSc).HasColumnName("PR_CORR_SC");
            entity.Property(e => e.PrCuenta).HasColumnName("PR_CUENTA");
            entity.Property(e => e.PrPrecio).HasColumnName("PR_PRECIO");
            entity.Property(e => e.PrReporte)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PR_REPORTE");
            entity.Property(e => e.PrSalida).HasColumnName("PR_SALIDA");
            entity.Property(e => e.PrSecdoc).HasColumnName("PR_SECDOC");
        });

        modelBuilder.Entity<InPromotor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_PROMOTOR");

            entity.Property(e => e.ClActivo).HasColumnName("CL_ACTIVO");
            entity.Property(e => e.ClContacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_CONTACTO");
            entity.Property(e => e.ClCuenta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_CUENTA");
            entity.Property(e => e.ClDirec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_DIREC");
            entity.Property(e => e.ClEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_EMAIL");
            entity.Property(e => e.ClFechai)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHAI");
            entity.Property(e => e.ClFechan)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHAN");
            entity.Property(e => e.ClGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_GRUPO");
            entity.Property(e => e.ClNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CL_NOMBRE");
            entity.Property(e => e.ClObs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CL_OBS");
            entity.Property(e => e.ClRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CL_RUC");
            entity.Property(e => e.ClTelf)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CL_TELF");
            entity.Property(e => e.ClTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CL_TIPO");
            entity.Property(e => e.ClUbicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CL_UBICACION");
        });

        modelBuilder.Entity<InProveedor>(entity =>
        {
            entity.HasKey(e => e.PrId);

            entity.ToTable("IN_PROVEEDOR");

            entity.Property(e => e.PrId).HasColumnName("PR_ID");
            entity.Property(e => e.PrCelular)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_CELULAR");
            entity.Property(e => e.PrClub).HasColumnName("PR_CLUB");
            entity.Property(e => e.PrCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_CODIGO");
            entity.Property(e => e.PrDireccion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PR_DIRECCION");
            entity.Property(e => e.PrGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PR_GRUPO");
            entity.Property(e => e.PrIdsub).HasColumnName("PR_IDSUB");
            entity.Property(e => e.PrNitfa)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_NITFA");
            entity.Property(e => e.PrNombre)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("PR_NOMBRE");
            entity.Property(e => e.PrNombrefa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PR_NOMBREFA");
            entity.Property(e => e.PrSuc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_SUC");
            entity.Property(e => e.PrTelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_TELEFONO");
            entity.Property(e => e.PrUbicacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PR_UBICACION");
            entity.Property(e => e.PrVendedor)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("PR_VENDEDOR");
        });

        modelBuilder.Entity<InRekardex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_REKARDEX");

            entity.Property(e => e.KaAlmacen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KA_ALMACEN");
            entity.Property(e => e.KaCodigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KA_CODIGO");
            entity.Property(e => e.KaDocref)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KA_DOCREF");
            entity.Property(e => e.KaFecha)
                .HasColumnType("datetime")
                .HasColumnName("KA_FECHA");
            entity.Property(e => e.KaGlosa)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("KA_GLOSA");
            entity.Property(e => e.KaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("KA_ID");
            entity.Property(e => e.KaIddoc).HasColumnName("KA_IDDOC");
            entity.Property(e => e.KaIdin).HasColumnName("KA_IDIN");
            entity.Property(e => e.KaIngref)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_INGREF");
            entity.Property(e => e.KaIngrev)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_INGREV");
            entity.Property(e => e.KaNrodoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KA_NRODOC");
            entity.Property(e => e.KaNrofac)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("KA_NROFAC");
            entity.Property(e => e.KaOper)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_OPER");
            entity.Property(e => e.KaSaldoff)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_SALDOFF");
            entity.Property(e => e.KaSaldoif)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_SALDOIF");
            entity.Property(e => e.KaSaldoiv)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_SALDOIV");
            entity.Property(e => e.KaSaldovf)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_SALDOVF");
            entity.Property(e => e.KaSalif)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_SALIF");
            entity.Property(e => e.KaSaliv)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KA_SALIV");
            entity.Property(e => e.KaTipdoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KA_TIPDOC");
        });

        modelBuilder.Entity<InRepmaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_REPMATERIAL");

            entity.Property(e => e.RmId).HasColumnName("RM_ID");
            entity.Property(e => e.RmSaldo)
                .HasColumnType("money")
                .HasColumnName("RM_SALDO");
        });

        modelBuilder.Entity<InRepnotac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_REPNOTAC");

            entity.Property(e => e.RnAp).HasColumnName("RN_AP");
            entity.Property(e => e.RnAutorizado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("RN_AUTORIZADO");
            entity.Property(e => e.RnCot).HasColumnName("RN_COT");
            entity.Property(e => e.RnEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("RN_ESTADO");
            entity.Property(e => e.RnFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("RN_FECHA");
            entity.Property(e => e.RnId).HasColumnName("RN_ID");
            entity.Property(e => e.RnNrodoc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("RN_NRODOC");
            entity.Property(e => e.RnPcot).HasColumnName("RN_PCOT");
            entity.Property(e => e.RnSolicitado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("RN_SOLICITADO");
            entity.Property(e => e.RnTc)
                .HasColumnType("money")
                .HasColumnName("RN_TC");
        });

        modelBuilder.Entity<InReporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_REPORTES");

            entity.Property(e => e.RpDireccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RP_DIRECCION");
            entity.Property(e => e.RpEstado).HasColumnName("RP_ESTADO");
            entity.Property(e => e.RpNombre)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("RP_NOMBRE");
        });

        modelBuilder.Entity<InRepsaldo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_REPSALDOS");

            entity.Property(e => e.SaCodcli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SA_CODCLI");
            entity.Property(e => e.SaDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SA_DESC");
            entity.Property(e => e.SaDoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SA_DOC");
            entity.Property(e => e.SaFecha)
                .HasColumnType("datetime")
                .HasColumnName("SA_FECHA");
            entity.Property(e => e.SaMonto)
                .HasColumnType("money")
                .HasColumnName("SA_MONTO");
            entity.Property(e => e.SaSaldo)
                .HasColumnType("money")
                .HasColumnName("SA_SALDO");
            entity.Property(e => e.SaTc)
                .HasColumnType("smallmoney")
                .HasColumnName("SA_TC");
            entity.Property(e => e.SaUser).HasColumnName("SA_USER");
        });

        modelBuilder.Entity<InRepsocio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_REPSOCIO");

            entity.Property(e => e.RpDebe)
                .HasColumnType("money")
                .HasColumnName("RP_DEBE");
            entity.Property(e => e.RpEntrada)
                .HasColumnType("money")
                .HasColumnName("RP_ENTRADA");
            entity.Property(e => e.RpFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("RP_FECHA");
            entity.Property(e => e.RpHaber)
                .HasColumnType("money")
                .HasColumnName("RP_HABER");
            entity.Property(e => e.RpNrodoc).HasColumnName("RP_NRODOC");
            entity.Property(e => e.RpSaldof)
                .HasColumnType("money")
                .HasColumnName("RP_SALDOF");
            entity.Property(e => e.RpSaldov)
                .HasColumnType("money")
                .HasColumnName("RP_SALDOV");
            entity.Property(e => e.RpSalida)
                .HasColumnType("money")
                .HasColumnName("RP_SALIDA");
        });

        modelBuilder.Entity<InReptMaterial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_REPT_MATERIAL");

            entity.Property(e => e.RpCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("RP_CODIGO");
            entity.Property(e => e.RpSerial).HasColumnName("RP_SERIAL");
        });

        modelBuilder.Entity<InReservaMat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_RESERVA_MAT");

            entity.Property(e => e.RmCantidad)
                .HasColumnType("money")
                .HasColumnName("RM_CANTIDAD");
            entity.Property(e => e.RmCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RM_CODIGO");
            entity.Property(e => e.RmNrodoc).HasColumnName("RM_NRODOC");
            entity.Property(e => e.RmTipodoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("RM_TIPODOC");
        });

        modelBuilder.Entity<InSaldosf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_SALDOSF");

            entity.Property(e => e.SaFact)
                .HasColumnType("money")
                .HasColumnName("SA_FACT");
            entity.Property(e => e.SaId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SA_ID");
            entity.Property(e => e.SaIdalm)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("SA_IDALM");
            entity.Property(e => e.SaIdin).HasColumnName("SA_IDIN");
            entity.Property(e => e.SaVact)
                .HasColumnType("money")
                .HasColumnName("SA_VACT");
        });

        modelBuilder.Entity<InSectore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_SECTORES");

            entity.Property(e => e.TsCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TS_CODIGO");
            entity.Property(e => e.TsCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TS_CTA");
            entity.Property(e => e.TsId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TS_ID");
            entity.Property(e => e.TsNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TS_NOMBRE");
            entity.Property(e => e.TsRep).HasColumnName("TS_REP");
        });

        modelBuilder.Entity<InTemptraspaso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_TEMPTRASPASO");

            entity.Property(e => e.TpBodega)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TP_BODEGA");
            entity.Property(e => e.TpCant)
                .HasColumnType("smallmoney")
                .HasColumnName("TP_CANT");
            entity.Property(e => e.TpCompu).HasColumnName("TP_COMPU");
            entity.Property(e => e.TpId).HasColumnName("TP_ID");
            entity.Property(e => e.TpLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TP_LOTE");
            entity.Property(e => e.TpPrecio)
                .HasColumnType("smallmoney")
                .HasColumnName("TP_PRECIO");
            entity.Property(e => e.TpSerinv).HasColumnName("TP_SERINV");
            entity.Property(e => e.TpUsr).HasColumnName("TP_USR");
        });

        modelBuilder.Entity<InTipocredito>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_TIPOCREDITO");

            entity.Property(e => e.TcCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TC_CODIGO");
            entity.Property(e => e.TcDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TC_DESCRIPCION");
            entity.Property(e => e.TcId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TC_ID");
        });

        modelBuilder.Entity<InTipodoc>(entity =>
        {
            entity.HasKey(e => e.TdId);

            entity.ToTable("IN_TIPODOC");

            entity.Property(e => e.TdId).HasColumnName("TD_ID");
            entity.Property(e => e.TdCodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TD_CODIGO");
            entity.Property(e => e.TdCorrelativo).HasColumnName("TD_CORRELATIVO");
            entity.Property(e => e.TdDescripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TD_DESCRIPCION");
            entity.Property(e => e.TdEmpid).HasColumnName("TD_EMPID");
            entity.Property(e => e.TdEstado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("TD_ESTADO");
            entity.Property(e => e.TdNumera)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TD_NUMERA");
            entity.Property(e => e.TdTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("TD_TIPO");
        });

        modelBuilder.Entity<InTransPar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_TRANS_PAR");

            entity.Property(e => e.TfCantap)
                .HasColumnType("money")
                .HasColumnName("TF_CANTAP");
            entity.Property(e => e.TfCantpe)
                .HasColumnType("money")
                .HasColumnName("TF_CANTPE");
            entity.Property(e => e.TfDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TF_DESC");
            entity.Property(e => e.TfFactura).HasColumnName("TF_FACTURA");
            entity.Property(e => e.TfGraCont).HasColumnName("TF_GRA_CONT");
            entity.Property(e => e.TfId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TF_ID");
            entity.Property(e => e.TfIdcta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("TF_IDCTA");
            entity.Property(e => e.TfIdctag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("TF_IDCTAG");
            entity.Property(e => e.TfIddoc).HasColumnName("TF_IDDOC");
            entity.Property(e => e.TfIdin).HasColumnName("TF_IDIN");
            entity.Property(e => e.TfIdprov).HasColumnName("TF_IDPROV");
            entity.Property(e => e.TfIngresa).HasColumnName("TF_INGRESA");
            entity.Property(e => e.TfItem).HasColumnName("TF_ITEM");
            entity.Property(e => e.TfLote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TF_LOTE");
            entity.Property(e => e.TfPretotSus)
                .HasColumnType("money")
                .HasColumnName("TF_PRETOT_SUS");
            entity.Property(e => e.TfPreun)
                .HasColumnType("money")
                .HasColumnName("TF_PREUN");
            entity.Property(e => e.TfPreunSus)
                .HasColumnType("money")
                .HasColumnName("TF_PREUN_SUS");
            entity.Property(e => e.TfPreunTot)
                .HasColumnType("money")
                .HasColumnName("TF_PREUN_TOT");
            entity.Property(e => e.TfRechazo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TF_RECHAZO");
            entity.Property(e => e.TfUnidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TF_UNIDAD");
        });

        modelBuilder.Entity<InTransaG>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_TRANSA_G");

            entity.Property(e => e.MdCta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("MD_CTA");
            entity.Property(e => e.MdDetalle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("MD_DETALLE");
            entity.Property(e => e.MdDoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("MD_DOC");
            entity.Property(e => e.MdEstado).HasColumnName("MD_ESTADO");
            entity.Property(e => e.MdId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MD_ID");
            entity.Property(e => e.MdIddoc).HasColumnName("MD_IDDOC");
            entity.Property(e => e.MdMe)
                .HasColumnType("money")
                .HasColumnName("MD_ME");
            entity.Property(e => e.MdMn)
                .HasColumnType("money")
                .HasColumnName("MD_MN");
        });

        modelBuilder.Entity<InTransac>(entity =>
        {
            entity.HasKey(e => e.TfId);

            entity.ToTable("IN_TRANSAC");

            entity.Property(e => e.TfId).HasColumnName("TF_ID");
            entity.Property(e => e.TfCantap)
                .HasColumnType("money")
                .HasColumnName("TF_CANTAP");
            entity.Property(e => e.TfCante)
                .HasColumnType("money")
                .HasColumnName("TF_CANTE");
            entity.Property(e => e.TfCantpe)
                .HasColumnType("money")
                .HasColumnName("TF_CANTPE");
            entity.Property(e => e.TfDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TF_DESC");
            entity.Property(e => e.TfFactura).HasColumnName("TF_FACTURA");
            entity.Property(e => e.TfFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("TF_FECHA");
            entity.Property(e => e.TfFechav)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("TF_FECHAV");
            entity.Property(e => e.TfGracont).HasColumnName("TF_GRACONT");
            entity.Property(e => e.TfIddoc).HasColumnName("TF_IDDOC");
            entity.Property(e => e.TfIdin).HasColumnName("TF_IDIN");
            entity.Property(e => e.TfIdprov).HasColumnName("TF_IDPROV");
            entity.Property(e => e.TfIngresa).HasColumnName("TF_INGRESA");
            entity.Property(e => e.TfItem).HasColumnName("TF_ITEM");
            entity.Property(e => e.TfLote)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("TF_LOTE");
            entity.Property(e => e.TfPrecosto)
                .HasColumnType("money")
                .HasColumnName("TF_PRECOSTO");
            entity.Property(e => e.TfPrecostome)
                .HasColumnType("money")
                .HasColumnName("TF_PRECOSTOME");
            entity.Property(e => e.TfPreventa)
                .HasColumnType("money")
                .HasColumnName("TF_PREVENTA");
            entity.Property(e => e.TfPreventame)
                .HasColumnType("money")
                .HasColumnName("TF_PREVENTAME");
            entity.Property(e => e.TfSector).HasColumnName("TF_SECTOR");
            entity.Property(e => e.TfSolic)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("TF_SOLIC");
            entity.Property(e => e.TfTotalco)
                .HasColumnType("money")
                .HasColumnName("TF_TOTALCO");
            entity.Property(e => e.TfTotalve)
                .HasColumnType("money")
                .HasColumnName("TF_TOTALVE");
            entity.Property(e => e.TfUnidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("TF_UNIDAD");
        });

        modelBuilder.Entity<InTransac1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_TRANSAC1");

            entity.Property(e => e.TfCantAp).HasColumnName("TF_CANT_AP");
            entity.Property(e => e.TfCantPe).HasColumnName("TF_CANT_PE");
            entity.Property(e => e.TfDesc)
                .HasMaxLength(255)
                .HasColumnName("TF_DESC");
            entity.Property(e => e.TfFactura).HasColumnName("TF_FACTURA");
            entity.Property(e => e.TfGraCont).HasColumnName("TF_GRA_CONT");
            entity.Property(e => e.TfIngresa).HasColumnName("TF_INGRESA");
            entity.Property(e => e.TfItem).HasColumnName("TF_ITEM");
            entity.Property(e => e.TfLote)
                .HasMaxLength(20)
                .HasColumnName("TF_LOTE");
            entity.Property(e => e.TfPreTotSus)
                .HasColumnType("money")
                .HasColumnName("TF_PRE_TOT_SUS");
            entity.Property(e => e.TfPreUTot)
                .HasColumnType("money")
                .HasColumnName("TF_PRE_U_TOT");
            entity.Property(e => e.TfPreUn).HasColumnName("TF_PRE_UN");
            entity.Property(e => e.TfPreUnSus)
                .HasColumnType("money")
                .HasColumnName("TF_PRE_UN_SUS");
            entity.Property(e => e.TfRechazo)
                .HasMaxLength(250)
                .HasColumnName("TF_RECHAZO");
            entity.Property(e => e.TfSerCta)
                .HasMaxLength(15)
                .HasColumnName("TF_SER_CTA");
            entity.Property(e => e.TfSerCtaG)
                .HasMaxLength(15)
                .HasColumnName("TF_SER_CTA_G");
            entity.Property(e => e.TfSerEnc).HasColumnName("TF_SER_ENC");
            entity.Property(e => e.TfSerIn).HasColumnName("TF_SER_IN");
            entity.Property(e => e.TfSerial).HasColumnName("TF_SERIAL");
            entity.Property(e => e.TfUnidad)
                .HasMaxLength(15)
                .HasColumnName("TF_UNIDAD");
        });

        modelBuilder.Entity<InUbicacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_UBICACION");

            entity.Property(e => e.UbCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UB_CIUDAD");
            entity.Property(e => e.UbDpto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UB_DPTO");
            entity.Property(e => e.UbSerial).HasColumnName("UB_SERIAL");
        });

        modelBuilder.Entity<InUnidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IN_UNIDAD");

            entity.Property(e => e.UnCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("UN_CODIGO");
            entity.Property(e => e.UnDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("UN_DESC");
            entity.Property(e => e.UnId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UN_ID");
        });

        modelBuilder.Entity<OdCliext>(entity =>
        {
            entity.HasKey(e => e.CeIdrec);

            entity.ToTable("OD_CLIEXT");

            entity.Property(e => e.CeIdrec)
                .ValueGeneratedNever()
                .HasColumnName("CE_IDREC");
            entity.Property(e => e.CeAmat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CE_AMAT");
            entity.Property(e => e.CeApat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CE_APAT");
            entity.Property(e => e.CeCategAp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CE_CategAP");
            entity.Property(e => e.CeCi)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CE_CI");
            entity.Property(e => e.CeCtacli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CE_CTACLI");
            entity.Property(e => e.CeDir)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CE_DIR");
            entity.Property(e => e.CeNit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CE_NIT");
            entity.Property(e => e.CeNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CE_NOM");
            entity.Property(e => e.CeNroctto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CE_NROCTTO");
            entity.Property(e => e.CeRuta)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CE_RUTA");
            entity.Property(e => e.CeTelf)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("(0)")
                .HasColumnName("CE_TELF");
            entity.Property(e => e.CeZona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CE_ZONA");
        });

        modelBuilder.Entity<OdHistconsumo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OD_HISTCONSUMOS");

            entity.HasIndex(e => e.HcIdrec, "IX_OD_HISTCONSUMOS_01");

            entity.Property(e => e.HcCon01)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HC_CON01");
            entity.Property(e => e.HcCon02)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HC_CON02");
            entity.Property(e => e.HcCon03)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HC_CON03");
            entity.Property(e => e.HcCon04)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HC_CON04");
            entity.Property(e => e.HcCon05)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HC_CON05");
            entity.Property(e => e.HcCon06)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HC_CON06");
            entity.Property(e => e.HcIdrec).HasColumnName("HC_IDREC");
        });

        modelBuilder.Entity<OdInspeccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OD_INSPECCION");

            entity.HasIndex(e => e.InIdrec, "IX_OD_INSPECCION_01");

            entity.Property(e => e.HcDate)
                .HasColumnType("datetime")
                .HasColumnName("HC_DATE");
            entity.Property(e => e.InComment)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IN_COMMENT");
            entity.Property(e => e.InCon).HasColumnName("IN_CON");
            entity.Property(e => e.InDiagn)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IN_DIAGN");
            entity.Property(e => e.InGrifos).HasColumnName("IN_GRIFOS");
            entity.Property(e => e.InIdrec).HasColumnName("IN_IDREC");
            entity.Property(e => e.InInspec)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IN_INSPEC");
            entity.Property(e => e.InLec).HasColumnName("IN_LEC");
            entity.Property(e => e.InLlave).HasColumnName("IN_LLAVE");
        });

        modelBuilder.Entity<OdReclamo>(entity =>
        {
            entity.HasKey(e => e.ReId);

            entity.ToTable("OD_RECLAMOS");

            entity.Property(e => e.ReId).HasColumnName("RE_ID");
            entity.Property(e => e.ReCisol)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_CISOL");
            entity.Property(e => e.ReConforme)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("RE_CONFORME");
            entity.Property(e => e.ReDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RE_DETALLE");
            entity.Property(e => e.ReDocobs)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_DOCOBS");
            entity.Property(e => e.ReEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("RE_ESTADO");
            entity.Property(e => e.ReFrecep)
                .HasColumnType("datetime")
                .HasColumnName("RE_FRECEP");
            entity.Property(e => e.ReFres)
                .HasColumnType("datetime")
                .HasColumnName("RE_FRES");
            entity.Property(e => e.ReFsol)
                .HasColumnType("datetime")
                .HasColumnName("RE_FSOL");
            entity.Property(e => e.ReNomsol)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_NOMSOL");
            entity.Property(e => e.ReOper).HasColumnName("RE_OPER");
            entity.Property(e => e.ReRes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_RES");
            entity.Property(e => e.ReSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_SEXO");
            entity.Property(e => e.ReSisab).HasColumnName("RE_SISAB");
            entity.Property(e => e.ReTelsol)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_TELSOL");
            entity.Property(e => e.ReTiempo).HasColumnName("RE_TIEMPO");
            entity.Property(e => e.ReTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('T')")
                .HasColumnName("RE_TIPO");
            entity.Property(e => e.ReVisitasol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RE_VISITASOL");
        });

        modelBuilder.Entity<OiCobranza>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_COBRANZA");

            entity.HasIndex(e => e.CoFechaCo, "IDX_FECCO");

            entity.HasIndex(e => e.CoFechaVe, "IDX_FECVE");

            entity.HasIndex(e => e.CoId, "IDX_ID");

            entity.HasIndex(e => e.CoTipo, "IDX_TIPO");

            entity.Property(e => e.CoCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CCONTROL");
            entity.Property(e => e.CoCliente)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("CO_CLIENTE");
            entity.Property(e => e.CoCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_CODIGO");
            entity.Property(e => e.CoCodserv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("CO_CODSERV");
            entity.Property(e => e.CoCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("CO_CTA");
            entity.Property(e => e.CoCuota)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_CUOTA");
            entity.Property(e => e.CoDirec)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_DIREC");
            entity.Property(e => e.CoDoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("CO_DOC");
            entity.Property(e => e.CoEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("CO_ESTADO");
            entity.Property(e => e.CoEstadoAlm)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_ESTADO_ALM");
            entity.Property(e => e.CoFechaCo)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("CO_FECHA_CO");
            entity.Property(e => e.CoFechaVe)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("CO_FECHA_VE");
            entity.Property(e => e.CoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CO_ID");
            entity.Property(e => e.CoNroauto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CO_NROAUTO");
            entity.Property(e => e.CoNumfac)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_NUMFAC");
            entity.Property(e => e.CoPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('E')")
                .HasColumnName("CO_PAGO");
            entity.Property(e => e.CoRuc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("CO_RUC");
            entity.Property(e => e.CoSerdosif)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_SERDOSIF");
            entity.Property(e => e.CoSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('U')")
                .HasColumnName("CO_SISTEMA");
            entity.Property(e => e.CoTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('V')")
                .HasColumnName("CO_TIPO");
            entity.Property(e => e.CoTipov)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_TIPOV");
            entity.Property(e => e.CoTotcob)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("CO_TOTCOB");
            entity.Property(e => e.CoTotfac)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("CO_TOTFAC");
            entity.Property(e => e.CoUserCo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CO_USER_CO");
            entity.Property(e => e.CoUserVe)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("CO_USER_VE");
        });

        modelBuilder.Entity<OiDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_DETALLE");

            entity.Property(e => e.DeCanti)
                .HasDefaultValueSql("(0)")
                .HasColumnName("DE_CANTI");
            entity.Property(e => e.DeCta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DE_CTA");
            entity.Property(e => e.DeDesc)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasDefaultValueSql("('NN')")
                .HasColumnName("DE_DESC");
            entity.Property(e => e.DeIdco).HasColumnName("DE_IDCO");
            entity.Property(e => e.DeImporteT)
                .HasDefaultValueSql("(0)")
                .HasColumnType("smallmoney")
                .HasColumnName("DE_IMPORTE_T");
            entity.Property(e => e.DeItem)
                .HasDefaultValueSql("(0)")
                .HasColumnName("DE_ITEM");
            entity.Property(e => e.DeLug)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DE_LUG");
            entity.Property(e => e.DePrecioU)
                .HasDefaultValueSql("(0)")
                .HasColumnType("smallmoney")
                .HasColumnName("DE_PRECIO_U");
            entity.Property(e => e.DeSerieaux)
                .HasDefaultValueSql("(0)")
                .HasColumnName("DE_SERIEAUX");
            entity.Property(e => e.DeSerieop)
                .HasDefaultValueSql("(0)")
                .HasColumnName("DE_SERIEOP");
        });

        modelBuilder.Entity<OiFacanu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_FACANU");

            entity.Property(e => e.FcCaj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CAJ");
            entity.Property(e => e.FcCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FC_CLI");
            entity.Property(e => e.FcFecha)
                .HasDefaultValueSql("('01/01/1900')")
                .HasColumnType("datetime")
                .HasColumnName("FC_FECHA");
            entity.Property(e => e.FcIdco).HasColumnName("FC_IDCO");
            entity.Property(e => e.FcLiteral)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("FC_LITERAL");
            entity.Property(e => e.FcNroOrden)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("FC_NRO_ORDEN");
            entity.Property(e => e.FcNumf).HasColumnName("FC_NUMF");
            entity.Property(e => e.FcObs)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("FC_OBS");
            entity.Property(e => e.FcPag)
                .HasColumnType("datetime")
                .HasColumnName("FC_PAG");
            entity.Property(e => e.FcSerief).HasColumnName("FC_SERIEF");
            entity.Property(e => e.FcUser).HasColumnName("FC_USER");
        });

        modelBuilder.Entity<OiOperacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_OPERACION");

            entity.Property(e => e.OpCantidad).HasColumnName("OP_CANTIDAD");
            entity.Property(e => e.OpCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_COD");
            entity.Property(e => e.OpCta1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_CTA1");
            entity.Property(e => e.OpCta2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_CTA2");
            entity.Property(e => e.OpDoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OP_DOC");
            entity.Property(e => e.OpEstado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_ESTADO");
            entity.Property(e => e.OpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OP_ID");
            entity.Property(e => e.OpImporte)
                .HasColumnType("smallmoney")
                .HasColumnName("OP_IMPORTE");
            entity.Property(e => e.OpIsfixed)
                .HasDefaultValueSql("((0))")
                .HasColumnName("OP_ISFIXED");
            entity.Property(e => e.OpIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('S')")
                .HasColumnName("OP_IVA");
            entity.Property(e => e.OpLugar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OP_LUGAR");
            entity.Property(e => e.OpNombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("OP_NOMBRE");
            entity.Property(e => e.OpTipo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP_TIPO");
            entity.Property(e => e.OpWhichone)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OP_WHICHONE");
        });

        modelBuilder.Entity<OiOperacionbk190607>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_OPERACIONBK190607");

            entity.Property(e => e.OpCantidad).HasColumnName("OP_CANTIDAD");
            entity.Property(e => e.OpCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_COD");
            entity.Property(e => e.OpCta1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_CTA1");
            entity.Property(e => e.OpCta2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_CTA2");
            entity.Property(e => e.OpDoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OP_DOC");
            entity.Property(e => e.OpEstado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OP_ESTADO");
            entity.Property(e => e.OpId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OP_ID");
            entity.Property(e => e.OpImporte)
                .HasColumnType("smallmoney")
                .HasColumnName("OP_IMPORTE");
            entity.Property(e => e.OpIsfixed).HasColumnName("OP_ISFIXED");
            entity.Property(e => e.OpIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OP_IVA");
            entity.Property(e => e.OpLugar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OP_LUGAR");
            entity.Property(e => e.OpNombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("OP_NOMBRE");
            entity.Property(e => e.OpTipo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("OP_TIPO");
            entity.Property(e => e.OpWhichone)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OP_WHICHONE");
        });

        modelBuilder.Entity<OiOtrosi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_OTROSI");

            entity.HasIndex(e => new { e.OiCodcli, e.OiMes, e.OiAño }, "IX_OI_OTROSI");

            entity.Property(e => e.OiAño)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OI_AÑO");
            entity.Property(e => e.OiCodcli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("OI_CODCLI");
            entity.Property(e => e.OiCodserv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("OI_CODSERV");
            entity.Property(e => e.OiCuota).HasColumnName("OI_CUOTA");
            entity.Property(e => e.OiEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("OI_ESTADO");
            entity.Property(e => e.OiIdventa).HasColumnName("OI_IDVENTA");
            entity.Property(e => e.OiImporte)
                .HasColumnType("money")
                .HasColumnName("OI_IMPORTE");
            entity.Property(e => e.OiMes)
                .HasDefaultValueSql("(0)")
                .HasColumnName("OI_MES");
        });

        modelBuilder.Entity<OiRetencion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_RETENCION");

            entity.Property(e => e.RtDescripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("RT_DESCRIPCION");
            entity.Property(e => e.RtId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RT_ID");
            entity.Property(e => e.RtMonto)
                .HasColumnType("money")
                .HasColumnName("RT_MONTO");
        });

        modelBuilder.Entity<OiRetenciondet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_RETENCIONDET");

            entity.Property(e => e.RdCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("RD_CTA");
            entity.Property(e => e.RdDesc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')")
                .HasColumnName("RD_DESC");
            entity.Property(e => e.RdId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RD_ID");
            entity.Property(e => e.RdIdret).HasColumnName("RD_IDRET");
            entity.Property(e => e.RdMonto)
                .HasColumnType("money")
                .HasColumnName("RD_MONTO");
        });

        modelBuilder.Entity<OiServicio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OI_SERVICIOS");

            entity.HasIndex(e => e.SeCodigo, "IDX_COD");

            entity.HasIndex(e => e.SeNombre, "IDX_NOM");

            entity.Property(e => e.SeArea)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SE_AREA");
            entity.Property(e => e.SeCodigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SE_CODIGO");
            entity.Property(e => e.SeCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('0')")
                .HasColumnName("SE_CTA");
            entity.Property(e => e.SeDoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SE_DOC");
            entity.Property(e => e.SeNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SE_NOMBRE");
            entity.Property(e => e.SePago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('E')")
                .HasColumnName("SE_PAGO");
        });

        modelBuilder.Entity<OtrosI>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("otros_i");

            entity.Property(e => e.OtAñoC).HasColumnName("OT_AÑO_C");
            entity.Property(e => e.OtAñoO).HasColumnName("OT_AÑO_O");
            entity.Property(e => e.OtCaj)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OT_CAJ");
            entity.Property(e => e.OtCcontrol)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OT_CCONTROL");
            entity.Property(e => e.OtCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OT_CLI");
            entity.Property(e => e.OtConcepto)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OT_CONCEPTO");
            entity.Property(e => e.OtDosnum).HasColumnName("OT_DOSNUM");
            entity.Property(e => e.OtEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OT_EST");
            entity.Property(e => e.OtFecanu)
                .HasColumnType("datetime")
                .HasColumnName("OT_FECANU");
            entity.Property(e => e.OtIddos).HasColumnName("OT_IDDOS");
            entity.Property(e => e.OtIdrefanu).HasColumnName("OT_IDREFANU");
            entity.Property(e => e.OtMesC).HasColumnName("OT_MES_C");
            entity.Property(e => e.OtMesO).HasColumnName("OT_MES_O");
            entity.Property(e => e.OtMonto)
                .HasColumnType("money")
                .HasColumnName("OT_MONTO");
            entity.Property(e => e.OtName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OT_NAME");
            entity.Property(e => e.OtNitci)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("OT_NITCI");
            entity.Property(e => e.OtPag)
                .HasColumnType("datetime")
                .HasColumnName("OT_PAG");
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAN");

            entity.Property(e => e.Actifluj).HasColumnName("ACTIFLUJ");
            entity.Property(e => e.Bcentcost).HasColumnName("BCENTCOST");
            entity.Property(e => e.Bctamov).HasColumnName("BCTAMOV");
            entity.Property(e => e.Binsumo).HasColumnName("BINSUMO");
            entity.Property(e => e.Btarea).HasColumnName("BTAREA");
            entity.Property(e => e.Cchica).HasColumnName("CCHICA");
            entity.Property(e => e.Cuenmoneda).HasColumnName("CUENMONEDA");
            entity.Property(e => e.Cuentaaju)
                .HasMaxLength(19)
                .HasColumnName("CUENTAAJU");
            entity.Property(e => e.Descrip)
                .HasMaxLength(254)
                .HasColumnName("DESCRIP");
            entity.Property(e => e.Descripcio)
                .HasMaxLength(40)
                .HasColumnName("DESCRIPCIO");
            entity.Property(e => e.Modulo).HasColumnName("MODULO");
            entity.Property(e => e.Nivel).HasColumnName("NIVEL");
            entity.Property(e => e.NroCuenta)
                .HasMaxLength(19)
                .HasColumnName("NRO_CUENTA");
            entity.Property(e => e.Subcuenta).HasColumnName("SUBCUENTA");
        });

        modelBuilder.Entity<Plan1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PLAN1");

            entity.Property(e => e.Campo1).HasMaxLength(255);
            entity.Property(e => e.Campo3).HasMaxLength(255);
            entity.Property(e => e.Campo6).HasMaxLength(255);
            entity.Property(e => e.Campo7).HasMaxLength(255);
            entity.Property(e => e.Campo8).HasMaxLength(255);
            entity.Property(e => e.Campo9).HasMaxLength(255);
        });

        modelBuilder.Entity<PrEmpleado>(entity =>
        {
            entity.HasKey(e => e.EmSerial);

            entity.ToTable("PR_EMPLEADOS");

            entity.Property(e => e.EmSerial).HasColumnName("EM_SERIAL");
            entity.Property(e => e.EmAfp).HasColumnName("EM_AFP");
            entity.Property(e => e.EmAporta).HasColumnName("EM_APORTA");
            entity.Property(e => e.EmCarnetMed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EM_CarnetMed");
            entity.Property(e => e.EmCi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EM_CI");
            entity.Property(e => e.EmDocs)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("EM_DOCS");
            entity.Property(e => e.EmDomicilio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EM_DOMICILIO");
            entity.Property(e => e.EmEcivil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EM_ECIVIL");
            entity.Property(e => e.EmEmptipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('P')")
                .HasColumnName("EM_EMPTIPO");
            entity.Property(e => e.EmEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('A')")
                .HasColumnName("EM_ESTADO");
            entity.Property(e => e.EmFing)
                .HasColumnType("datetime")
                .HasColumnName("EM_FING");
            entity.Property(e => e.EmFnac)
                .HasColumnType("datetime")
                .HasColumnName("EM_FNAC");
            entity.Property(e => e.EmFoto)
                .HasColumnType("image")
                .HasColumnName("EM_FOTO");
            entity.Property(e => e.EmFretiro)
                .HasColumnType("datetime")
                .HasColumnName("EM_FRETIRO");
            entity.Property(e => e.EmInstruccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EM_INSTRUCCION");
            entity.Property(e => e.EmJefe).HasColumnName("EM_JEFE");
            entity.Property(e => e.EmLugnac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EM_LUGNAC");
            entity.Property(e => e.EmMarca)
                .IsRequired()
                .HasDefaultValueSql("(1)")
                .HasColumnName("EM_MARCA");
            entity.Property(e => e.EmMaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EM_MATERNO");
            entity.Property(e => e.EmMotivo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EM_MOTIVO");
            entity.Property(e => e.EmNacionalidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EM_NACIONALIDAD");
            entity.Property(e => e.EmNommadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EM_NOMMADRE");
            entity.Property(e => e.EmNompadre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EM_NOMPADRE");
            entity.Property(e => e.EmNoms)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("EM_NOMS");
            entity.Property(e => e.EmNua)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EM_NUA");
            entity.Property(e => e.EmObserv)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EM_OBSERV");
            entity.Property(e => e.EmOcupacion)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EM_OCUPACION");
            entity.Property(e => e.EmOrden).HasColumnName("EM_ORDEN");
            entity.Property(e => e.EmPaterno)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("EM_PATERNO");
            entity.Property(e => e.EmProfesion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EM_PROFESION");
            entity.Property(e => e.EmProvnac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EM_PROVNAC");
            entity.Property(e => e.EmReloj).HasColumnName("EM_RELOJ");
            entity.Property(e => e.EmSaldomesant)
                .HasColumnType("money")
                .HasColumnName("EM_SALDOMESANT");
            entity.Property(e => e.EmSede).HasColumnName("EM_SEDE");
            entity.Property(e => e.EmSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("EM_SEXO");
            entity.Property(e => e.EmSeñales)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EM_SEÑALES");
            entity.Property(e => e.EmSueldo)
                .HasColumnType("money")
                .HasColumnName("EM_SUELDO");
            entity.Property(e => e.EmTelf)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(0)")
                .HasColumnName("EM_TELF");
            entity.Property(e => e.EmTipotelf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('P')")
                .HasColumnName("EM_TIPOTELF");
            entity.Property(e => e.EmTurno1).HasColumnName("EM_TURNO1");
            entity.Property(e => e.EmTurno2).HasColumnName("EM_TURNO2");
        });

        modelBuilder.Entity<Proveed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROVEED");

            entity.Property(e => e.Carnet).HasColumnName("CARNET");
            entity.Property(e => e.Casilla).HasColumnName("CASILLA");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.Comentar)
                .HasMaxLength(120)
                .HasColumnName("COMENTAR");
            entity.Property(e => e.Dav).HasColumnName("DAV");
            entity.Property(e => e.Descrip)
                .HasMaxLength(30)
                .HasColumnName("DESCRIP");
            entity.Property(e => e.DirecOfi)
                .HasMaxLength(30)
                .HasColumnName("DIREC_OFI");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(30)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.Encargado)
                .HasMaxLength(30)
                .HasColumnName("ENCARGADO");
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .HasColumnName("FAX");
            entity.Property(e => e.Lugar)
                .HasMaxLength(2)
                .HasColumnName("LUGAR");
            entity.Property(e => e.Monto1).HasColumnName("MONTO1");
            entity.Property(e => e.Monto2).HasColumnName("MONTO2");
            entity.Property(e => e.Ruc).HasColumnName("RUC");
            entity.Property(e => e.TelefDom)
                .HasMaxLength(15)
                .HasColumnName("TELEF_DOM");
            entity.Property(e => e.TelefOfi)
                .HasMaxLength(15)
                .HasColumnName("TELEF_OFI");
        });

        modelBuilder.Entity<SiMenu>(entity =>
        {
            entity.HasKey(e => e.MeIdm);

            entity.ToTable("SI_MENUS");

            entity.Property(e => e.MeIdm).HasColumnName("ME_IDM");
            entity.Property(e => e.MeCaption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ME_CAPTION");
            entity.Property(e => e.MeEnabled)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ME_ENABLED");
            entity.Property(e => e.MeForm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('N')")
                .HasColumnName("ME_FORM");
            entity.Property(e => e.MeIdp).HasColumnName("ME_IDP");
            entity.Property(e => e.MeModal)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ME_MODAL");
            entity.Property(e => e.MeNivel)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ME_NIVEL");
            entity.Property(e => e.MeNofrec)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ME_NOFREC");
            entity.Property(e => e.MeSeq)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ME_SEQ");
            entity.Property(e => e.MeSistema)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ME_SISTEMA");
            entity.Property(e => e.MeVisible)
                .HasDefaultValueSql("(0)")
                .HasColumnName("ME_VISIBLE");
        });

        modelBuilder.Entity<SiMenu1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_MENUS_");

            entity.HasIndex(e => e.TmIdm, "IX_SI_MENUS_");

            entity.HasIndex(e => new { e.TmIdm, e.TmSys }, "IX_SI_MENUS_1");

            entity.HasIndex(e => e.TmSys, "IX_SI_MENUS_2");

            entity.HasIndex(e => e.TmId, "IX_SI_MENUS_3");

            entity.Property(e => e.TmId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TM_ID");
            entity.Property(e => e.TmIdm).HasColumnName("TM_IDM");
            entity.Property(e => e.TmNiv).HasColumnName("TM_NIV");
            entity.Property(e => e.TmSys)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TM_SYS");
        });

        modelBuilder.Entity<SiMenubk20170926>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_MENUBK20170926");

            entity.Property(e => e.MeCaption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ME_CAPTION");
            entity.Property(e => e.MeEnabled).HasColumnName("ME_ENABLED");
            entity.Property(e => e.MeForm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ME_FORM");
            entity.Property(e => e.MeIdm)
                .ValueGeneratedOnAdd()
                .HasColumnName("ME_IDM");
            entity.Property(e => e.MeIdp).HasColumnName("ME_IDP");
            entity.Property(e => e.MeModal).HasColumnName("ME_MODAL");
            entity.Property(e => e.MeNivel).HasColumnName("ME_NIVEL");
            entity.Property(e => e.MeNofrec).HasColumnName("ME_NOFREC");
            entity.Property(e => e.MeSeq).HasColumnName("ME_SEQ");
            entity.Property(e => e.MeSistema)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ME_SISTEMA");
            entity.Property(e => e.MeVisible).HasColumnName("ME_VISIBLE");
        });

        modelBuilder.Entity<SiParametsy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_PARAMETSYS");

            entity.HasIndex(e => e.PrSys, "IX_SI_PARAMETSYS");

            entity.HasIndex(e => new { e.PrSys, e.PrToken }, "IX_SI_PARAMETSYS_1");

            entity.Property(e => e.PrSys)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_SYS");
            entity.Property(e => e.PrToken)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_TOKEN");
            entity.Property(e => e.PrValue)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PR_VALUE");
        });

        modelBuilder.Entity<SiSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_SESSION");

            entity.Property(e => e.SsComputersession)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SS_COMPUTERSESSION");
            entity.Property(e => e.SsDatesession)
                .HasColumnType("datetime")
                .HasColumnName("SS_DATESESSION");
            entity.Property(e => e.SsGarbage)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SS_GARBAGE");
            entity.Property(e => e.SsSession)
                .ValueGeneratedOnAdd()
                .HasColumnName("SS_SESSION");
        });

        modelBuilder.Entity<SiSistema>(entity =>
        {
            entity.HasKey(e => e.SiId).IsClustered(false);

            entity.ToTable("SI_SISTEMAS");

            entity.Property(e => e.SiId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("SI_ID");
            entity.Property(e => e.SiDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SI_DESC");
        });

        modelBuilder.Entity<SiSupUserSist>(entity =>
        {
            entity.HasKey(e => new { e.SuUser, e.SuSist })
                .HasName("PK_SI_USR_SIST")
                .IsClustered(false);

            entity.ToTable("SI_SUP_USER_SISTS");

            entity.Property(e => e.SuUser).HasColumnName("SU_USER");
            entity.Property(e => e.SuSist)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SU_SIST");
        });

        modelBuilder.Entity<SiSupUserSist1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_SUP_USER_SISTS_");

            entity.HasIndex(e => e.SuUser, "IX_SI_SUP_USER_SISTS_");

            entity.HasIndex(e => e.SuSist, "IX_SI_SUP_USER_SISTS__1");

            entity.HasIndex(e => new { e.SuUser, e.SuSist }, "IX_SI_SUP_USER_SISTS__2");

            entity.HasIndex(e => new { e.SuUser, e.SuSession }, "IX_SI_SUP_USER_SISTS__3");

            entity.Property(e => e.SuCheck)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SU_CHECK");
            entity.Property(e => e.SuSession).HasColumnName("SU_SESSION");
            entity.Property(e => e.SuSist)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SU_SIST");
            entity.Property(e => e.SuUser).HasColumnName("SU_USER");
        });

        modelBuilder.Entity<SiTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_TEMP");

            entity.HasIndex(e => e.Idm, "IX_si_temp");

            entity.HasIndex(e => new { e.Sis, e.IdSession }, "IX_si_temp_1");

            entity.Property(e => e.Cap)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CAP");
            entity.Property(e => e.Ena).HasColumnName("ENA");
            entity.Property(e => e.Form)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FORM");
            entity.Property(e => e.Frec).HasColumnName("FREC");
            entity.Property(e => e.IdSession).HasColumnName("ID_SESSION");
            entity.Property(e => e.Idm).HasColumnName("IDM");
            entity.Property(e => e.Idp).HasColumnName("IDP");
            entity.Property(e => e.Mod).HasColumnName("MOD");
            entity.Property(e => e.Niv).HasColumnName("NIV");
            entity.Property(e => e.Seq).HasColumnName("SEQ");
            entity.Property(e => e.Sis)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SIS");
            entity.Property(e => e.Vis).HasColumnName("VIS");
        });

        modelBuilder.Entity<SiUserMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_USER_MENUS");

            entity.HasIndex(e => e.MuIduser, "IX_SI_MENUUSERS");

            entity.HasIndex(e => e.MuIdmenu, "IX_SI_MENUUSERS_1");

            entity.HasIndex(e => new { e.MuIduser, e.MuIdmenu }, "IX_SI_MENUUSERS_2");

            entity.Property(e => e.MuIdmenu).HasColumnName("MU_IDMENU");
            entity.Property(e => e.MuIduser).HasColumnName("MU_IDUSER");
        });

        modelBuilder.Entity<SiUserMenu1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SI_USER_MENUS_");

            entity.HasIndex(e => e.TmId, "IX_SI_USER_MENUS");

            entity.HasIndex(e => e.TmIdm, "IX_SI_USER_MENUS_1");

            entity.HasIndex(e => new { e.TmId, e.TmIdm }, "IX_SI_USER_MENUS_2");

            entity.HasIndex(e => e.TmSession, "IX_SI_USER_MENUS_3");

            entity.Property(e => e.TmCheck)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TM_CHECK");
            entity.Property(e => e.TmId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TM_ID");
            entity.Property(e => e.TmIdm).HasColumnName("TM_IDM");
            entity.Property(e => e.TmIdop).HasColumnName("TM_IDOP");
            entity.Property(e => e.TmNiv).HasColumnName("TM_NIV");
            entity.Property(e => e.TmSession).HasColumnName("TM_SESSION");
            entity.Property(e => e.TmSys)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TM_SYS");
        });

        modelBuilder.Entity<SiUsuario>(entity =>
        {
            entity.HasKey(e => e.UsId);

            entity.ToTable("SI_USUARIOS");

            entity.Property(e => e.UsId).HasColumnName("US_ID");
            entity.Property(e => e.UsDepto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_DEPTO");
            entity.Property(e => e.UsLogin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("US_LOGIN");
            entity.Property(e => e.UsNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_NOMBRE");
            entity.Property(e => e.UsPassword)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("US_PASSWORD");
            entity.Property(e => e.SiToken)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SI_TOKEN");
        });

        modelBuilder.Entity<Tipocrd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TIPOCRD");

            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.Contracta)
                .HasMaxLength(10)
                .HasColumnName("CONTRACTA");
            entity.Property(e => e.Credito)
                .HasMaxLength(1)
                .HasColumnName("CREDITO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(10)
                .HasColumnName("CUENTA");
            entity.Property(e => e.DescCort)
                .HasMaxLength(12)
                .HasColumnName("DESC_CORT");
            entity.Property(e => e.Descrip)
                .HasMaxLength(20)
                .HasColumnName("DESCRIP");
            entity.Property(e => e.Factmes)
                .HasMaxLength(1)
                .HasColumnName("FACTMES");
            entity.Property(e => e.Iva)
                .HasMaxLength(1)
                .HasColumnName("IVA");
            entity.Property(e => e.Monto1).HasColumnName("MONTO1");
            entity.Property(e => e.Monto2).HasColumnName("MONTO2");
            entity.Property(e => e.Monto3).HasColumnName("MONTO3");
            entity.Property(e => e.Monto4).HasColumnName("MONTO4");
            entity.Property(e => e.Monto5).HasColumnName("MONTO5");
            entity.Property(e => e.Monto6).HasColumnName("MONTO6");
            entity.Property(e => e.Monto7).HasColumnName("MONTO7");
        });

        modelBuilder.Entity<Usomater>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("USOMATER");

            entity.Property(e => e.Cuenta)
                .HasMaxLength(10)
                .HasColumnName("CUENTA");
            entity.Property(e => e.DescCorta)
                .HasMaxLength(10)
                .HasColumnName("DESC_CORTA");
            entity.Property(e => e.Descrip)
                .HasMaxLength(30)
                .HasColumnName("DESCRIP");
            entity.Property(e => e.Destino).HasColumnName("DESTINO");
            entity.Property(e => e.Iva)
                .HasMaxLength(1)
                .HasColumnName("IVA");
            entity.Property(e => e.Monto01).HasColumnName("MONTO01");
            entity.Property(e => e.Monto02).HasColumnName("MONTO02");
            entity.Property(e => e.Monto03).HasColumnName("MONTO03");
            entity.Property(e => e.Rubro).HasColumnName("RUBRO");
        });

        modelBuilder.Entity<VfcEstTar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VFC_EST_TAR");

            entity.Property(e => e.EtCodet)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ET_CODET");
            entity.Property(e => e.EtDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ET_DESC");
            entity.Property(e => e.EtDescet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ET_DESCET");
            entity.Property(e => e.EtDescuso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ET_DESCUSO");
            entity.Property(e => e.EtId).HasColumnName("ET_ID");
            entity.Property(e => e.EtIdfv).HasColumnName("ET_IDFV");
            entity.Property(e => e.EtUso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ET_USO");
        });

        modelBuilder.Entity<VfcRec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VFC_REC");

            entity.Property(e => e.LcCodlec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LC_CODLEC");
            entity.Property(e => e.RcCodrec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("RC_CODREC");
            entity.Property(e => e.RcDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RC_DESC");
            entity.Property(e => e.RcIdare).HasColumnName("RC_IDARE");
            entity.Property(e => e.RcIdcic).HasColumnName("RC_IDCIC");
            entity.Property(e => e.RcIdsec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("RC_IDSEC");
        });

        modelBuilder.Entity<ViTransa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VI_TRANSA");

            entity.Property(e => e.Aux)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AUX");
            entity.Property(e => e.CnCta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CN_CTA");
            entity.Property(e => e.CnMnd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CN_MND");
            entity.Property(e => e.CnNom)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("CN_NOM");
            entity.Property(e => e.CnTot).HasColumnName("CN_TOT");
            entity.Property(e => e.Obj)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OBJ");
            entity.Property(e => e.TrCcosto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TR_CCOSTO");
            entity.Property(e => e.TrCorr).HasColumnName("TR_CORR");
            entity.Property(e => e.TrDref)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TR_DREF");
            entity.Property(e => e.TrGlosa)
                .HasMaxLength(700)
                .IsUnicode(false)
                .HasColumnName("TR_GLOSA");
            entity.Property(e => e.TrId).HasColumnName("TR_ID");
            entity.Property(e => e.TrMe)
                .HasColumnType("money")
                .HasColumnName("TR_ME");
            entity.Property(e => e.TrMn)
                .HasColumnType("money")
                .HasColumnName("TR_MN");
            entity.Property(e => e.TrSerie).HasColumnName("tr_serie");
        });

        modelBuilder.Entity<Zona>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZONAS");

            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.DescCort)
                .HasMaxLength(10)
                .HasColumnName("DESC_CORT");
            entity.Property(e => e.Descrip)
                .HasMaxLength(20)
                .HasColumnName("DESCRIP");
            entity.Property(e => e.Grupo)
                .HasMaxLength(1)
                .HasColumnName("GRUPO");
            entity.Property(e => e.Monto00).HasColumnName("MONTO00");
            entity.Property(e => e.Monto01).HasColumnName("MONTO01");
            entity.Property(e => e.Monto02).HasColumnName("MONTO02");
            entity.Property(e => e.Monto03).HasColumnName("MONTO03");
            entity.Property(e => e.Monto04).HasColumnName("MONTO04");
            entity.Property(e => e.Monto05).HasColumnName("MONTO05");
            entity.Property(e => e.Socios0).HasColumnName("SOCIOS0");
            entity.Property(e => e.Socios1).HasColumnName("SOCIOS1");
            entity.Property(e => e.Socios2).HasColumnName("SOCIOS2");
            entity.Property(e => e.Socios3).HasColumnName("SOCIOS3");
            entity.Property(e => e.Socios4).HasColumnName("SOCIOS4");
            entity.Property(e => e.Socios5).HasColumnName("SOCIOS5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
