using Epsa.Server.Authorization;
using Epsa.Server.Context;
using Epsa.Shared.Entities;
using Epsa.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Epsa.Server.Repository.Client
{
    public class ClientRepository : IClientRepository
    {
        private readonly EpsaDbContext _context;
        private IJwtUtils _jwtUtils;

        public ClientRepository(EpsaDbContext context, IJwtUtils jwtUtils)
        {
            _context = context;
            _jwtUtils = jwtUtils;
        }

        public List<FcCliente> Search(string keyword)
        {
            List<FcCliente> users 
                = (List<FcCliente>)(from client in _context.FcClientes
                                    where (client.ClId==Int16.Parse(keyword))                                                      
                                    select new FcCliente
                                    {
                                        ClNombre = client.ClNombre,
                                        ClCirun = client.ClCirun,
                                        ClMaterno = client.ClMaterno,
                                        ClPaterno = client.ClPaterno,
                                        ClRuc = client.ClRuc,
                                        ClId = client.ClId
                                    }).ToList();

            return users;
        }        
        
        public List<CobranzaDataViewModel> GetPendingPayments(int _clientId)
        {
            List<CobranzaDataViewModel> fcAltas
              = (from _fcAlta in _context.FcAltas
                     //from _fcLey1886 in _context.FcLey1886s.Where(x=>x.LeCli==_fcAlta.FcCli && x.LeAño==_fcAlta.FcAño && x.LeMes==_fcAlta.FcMes)
                     //join _fcLey1886 in _context.FcLey1886 on new { a=_fcAlta.FcMes, b=_fcAlta.FcAño, c=_fcAlta.FcCli} equals new {a=_fcLey1886.LeMes, b=_fcLey1886.LeAño, c=_fcLey1886.LeCli}
                 where (_fcAlta.FcClid == _clientId && _fcAlta.FcEstf.Equals("P"))
                 orderby _fcAlta.FcFecf ascending
                 select new CobranzaDataViewModel
                 {
                     /*FcImporteTotal = (decimal)(_fcAlta.FcApcf + 
                                     _fcAlta.FcApcv + 
                                     _fcAlta.FcAlc + 
                                     _fcAlta.FcRc - 
                                     Convert.ToDecimal(_context.FcLey1886.Where(x => x.LeCli == _fcAlta.FcCli && x.LeMes == _fcAlta.FcMes && x.LeAño == _fcAlta.FcAño).FirstOrDefault().LeMonto)),*/
                     FcAño=_fcAlta.FcAño,
                     FcMes=_fcAlta.FcMes,
                     FcCli= _fcAlta.FcCli,
                     FcNum= _fcAlta.FcNum,
                     FcApcf= _fcAlta.FcApcf,
                     FcApcv=_fcAlta.FcApcv,
                     FcAlc= _fcAlta.FcAlc,
                     FcRc= _fcAlta.FcRc,
                     LeMonto= Convert.ToDecimal(_context.FcLey1886.Where(x => x.LeCli == _fcAlta.FcCli && x.LeMes == _fcAlta.FcMes && x.LeAño == _fcAlta.FcAño).FirstOrDefault().LeMonto)
                 }).ToList();
            

            return fcAltas;
           
        }

        public async Task MakePayment(List<FcAlta> fcAltas)
        {
            foreach (var fcAlta in fcAltas)
            {
                
            }
        }
    }
}
