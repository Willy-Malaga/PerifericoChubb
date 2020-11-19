using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Periferico.Models;

namespace Periferico.Models
{
    public class APIDBContext : DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<E270ConAseAcc>().HasKey(a => new { a.noTransaccion });
            modelBuilder.Entity<E270ConAse>().HasKey(b => new { b.noContratante });
            modelBuilder.Entity<E271SolAut>().HasKey(c => new { c.noMaTitular });
            modelBuilder.Entity<E271SolAutDetalleProEsp>().HasKey(d => new { d.coTiProConAmbulatoria });
            modelBuilder.Entity<E271SolAutDetalleRes>().HasKey(e => new { e.idRestricciones });
            modelBuilder.Entity<E271SolAutDetalleTieEsp>().HasKey(f => new { f.idTiEspera });
            modelBuilder.Entity<E271SolAutDetalleExeCar>().HasKey(g => new { g.idExCarencia });
            modelBuilder.Entity<E278ContEntVinc>().HasKey(h => new { h.idReceptor });
            modelBuilder.Entity<E278SolCg>().HasKey(i => new { i.idCorrelativo });
            modelBuilder.Entity<E271ConCod>().HasKey(j => new { j.idRemitente });
            modelBuilder.Entity<E271ConCodDetalle>().HasKey(k => new { k.idProducto });
            modelBuilder.Entity<E271ConDtad>().HasKey(l => new { l.idReceptor });
            modelBuilder.Entity<E271ConMed>().HasKey(m => new { m.idRemitente });
            modelBuilder.Entity<E271ConMedDetalle>().HasKey(n => new { n.idFuenteRE });
            modelBuilder.Entity<E271ConNom>().HasKey(o => new { o.idRemitente });
            modelBuilder.Entity<E271ConNomDetalle>().HasKey(p => new { p.noPaciente });
            modelBuilder.Entity<E271ConObs>().HasKey(q => new { q.idRemitente });
            modelBuilder.Entity<E271ConProc>().HasKey(r => new { r.idTransaccion });
            modelBuilder.Entity<E271ConProcDetalle>().HasKey(s => new { s.idFuentePE });
            modelBuilder.Entity<E271ResCg>().HasKey(t => new { t.idRemitente });
            modelBuilder.Entity<E271ResCgDetalle>().HasKey(u => new { u.noPaciente });
            modelBuilder.Entity<E271ResDeriva>().HasKey(v => new { v.idReceptor });
            modelBuilder.Entity<E271ResDerivaDetalle>().HasKey(w => new { w.idCaReferencia });
            modelBuilder.Entity<E271ResSctr>().HasKey(x => new { x.idRemitente });
            modelBuilder.Entity<E271ResSctrDetalle>().HasKey(y => new { y.idCaReContratante });
            modelBuilder.Entity<E278ResEntVinc>().HasKey(z => new { z.idRemitente });
            modelBuilder.Entity<E997ResAut>().HasKey(ab => new { ab.idReceptor });

        }

        public DbSet<E270ConAseAcc> E270ConAseAcc { get; set; }
        public DbSet<E270ConAse> E270ConAse { get; set; }
        public DbSet<E271SolAut> E271SolAut { get; set; }
        public DbSet<E271SolAutDetalleProEsp> E271SolAutDetalleProEsp { get; set; }
        public DbSet<E271SolAutDetalleRes> E271SolAutDetalleRes { get; set; }
        public DbSet<E271SolAutDetalleTieEsp> E271SolAutDetalleTieEsp { get; set; }
        public DbSet<E271SolAutDetalleExeCar> E271SolAutDetalleExeCar { get; set; }
        public DbSet<E278ContEntVinc> E278ContEntVinc { get; set; }
        public DbSet<E278SolCg> E278SolCg { get; set; }
        public DbSet<Periferico.Models.E271ConCod> E271ConCod { get; set; }
        public DbSet<Periferico.Models.E271ConCodDetalle> E271ConCodDetalle { get; set; }
        public DbSet<Periferico.Models.E271ConDtad> E271ConDtad { get; set; }
        public DbSet<Periferico.Models.E271ConMed> E271ConMed { get; set; }
        public DbSet<Periferico.Models.E271ConMedDetalle> E271ConMedDetalle { get; set; }
        public DbSet<Periferico.Models.E271ConNom> E271ConNom { get; set; }
        public DbSet<Periferico.Models.E271ConNomDetalle> E271ConNomDetalle { get; set; }
        public DbSet<Periferico.Models.E271ConObs> E271ConObs { get; set; }
        public DbSet<Periferico.Models.E271ConProc> E271ConProc { get; set; }
        public DbSet<Periferico.Models.E271ConProcDetalle> E271ConProcDetalle { get; set; }
        public DbSet<Periferico.Models.E271ResCg> E271ResCg { get; set; }
        public DbSet<Periferico.Models.E271ResCgDetalle> E271ResCgDetalle { get; set; }
        public DbSet<Periferico.Models.E271ResDeriva> E271ResDeriva { get; set; }
        public DbSet<Periferico.Models.E271ResDerivaDetalle> E271ResDerivaDetalle { get; set; }
        public DbSet<Periferico.Models.E271ResSctr> E271ResSctr { get; set; }
        public DbSet<Periferico.Models.E271ResSctrDetalle> E271ResSctrDetalle { get; set; }
        public DbSet<Periferico.Models.E278ResEntVinc> E278ResEntVinc { get; set; }
        public DbSet<Periferico.Models.E997ResAut> E997ResAut { get; set; }
    }
}
