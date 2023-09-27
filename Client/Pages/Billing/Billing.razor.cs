using Epsa.Client.Services.Client;
using Epsa.Shared.Entities;
using Epsa.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;
using System;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace Epsa.Client.Pages.Billing
{
    public partial class Billing : IDisposable
    {
        [Inject]
        public ClientsViewModel clientsModel { get; set; } = new ClientsViewModel();

        [Inject]
        public IClientService _clientService { get; set; }

        [Inject]
        public FcPaymentsViewModel _fcPaymentsModel { get; set; }

        [Inject]
        public IJSRuntime jSRuntime { get; set; }

        public int cliid = 0;
        public decimal TotalPagar = 0;

        public string[] mesesLit = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" }; 

        public List<CobranzaDataViewModel> PaymentList = new List<CobranzaDataViewModel>();
        public List<CobranzaDataViewModel> CobranzaLista = new List<CobranzaDataViewModel>();       

        protected override async Task OnInitializedAsync()
        {
            //await jSRuntime.InvokeAsync<IJSObjectReference>("import", "./js/cobranzas.js");                       
        }        

        public async Task SubmitSearch()
        {            
            var Data = await _clientService.Search(clientsModel.search);
            CobranzaLista = new List<CobranzaDataViewModel>();
            TotalPagar = 0;
            if (Data != null)
            {
                clientsModel.FcClienteList = Data;
            }                  
        }

        public async Task PendingPayments(int param)
        {
            PaymentList = new List<CobranzaDataViewModel>();
            cliid = param;
            var Data = await _clientService.PendingPayments(param);
            if (Data != null)
            {
                CobranzaLista = Data;                
            }
        }
        public void SelectPayments(CobranzaDataViewModel _Cobranza) 
        {    
            
            if (_Cobranza.Checked)
            {
                _Cobranza.Checked = false;
            }
            else {
                int index = CobranzaLista.FindIndex(x => x.FcMes == _Cobranza.FcMes && x.FcAño == _Cobranza.FcAño);
                for (int i = 0; index >= i; i++)
                {
                    CobranzaLista[i].Checked = true;
                }                
            }
            SumarTotalPagar();

        }

        public void SumarTotalPagar()
        {
            TotalPagar = 0;
            foreach (CobranzaDataViewModel _Cob in CobranzaLista)
            {
                if (_Cob.Checked)
                {
                    TotalPagar = TotalPagar + (decimal)(_Cob.FcApcf + _Cob.FcApcv + _Cob.FcAlc + _Cob.FcRc - _Cob.LeMonto);
                }
            }            
        }

        public void Dispose()
        {
            cliid = 0;            
            clientsModel.FcClienteList = null;
            clientsModel.search = "";            
        }

    }
}
