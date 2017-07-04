using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public static class ProposalMapper
    {
        public static Order ConvertWebserviceToInterface(ResellerWebservice.ProposalResponse wsProposal)
        {
            Order proposal = new Order();
            proposal.Name = wsProposal.Proposta.NomeProposta;
            proposal.CodForecast = wsProposal.CodForecast;
            proposal.ExpiryDate = wsProposal.DataValidade;
            proposal.NetAmount = wsProposal.Proposta.Valor;
            proposal.ComissionValue = wsProposal.Proposta.ValorComissao;
            proposal.DollarValue = wsProposal.Proposta.ValorDollar;
            proposal.ICMS = wsProposal.Proposta.ICMS;
            proposal.OrderCode = wsProposal.CodPedido;
            proposal.ProposalDate = wsProposal.DataProposta;
            proposal.ProposalId = wsProposal.CodProposta;
            proposal.SalesTaxesRate = wsProposal.Proposta.SalesTaxRate;
            proposal.TotalWithoutTaxes = wsProposal.Proposta.ValorSemImposto;
            proposal.TotalWitoutICMS = wsProposal.Proposta.ValorSemIcms;
            proposal.Version = wsProposal.Proposta.Versao;
            proposal.Success = wsProposal.Success;
            proposal.Message = wsProposal.ErrorMessage;

            List<OrderOption> options = new List<OrderOption>();
            foreach (ResellerWebservice.OptionResponse wsOption in wsProposal.Opcoes)
            {
                options.Add(ProposalMapper.ConvertWebserviceToInterface(wsOption));
            }

            proposal.Options = options.ToArray();
            return proposal;
        }

        public static OrderOption ConvertWebserviceToInterface(ResellerWebservice.OptionResponse wsOption)
        {
            OrderOption option = new OrderOption();
            option.DollarValue = wsOption.ValorDollar;
            option.TotalWithoutTaxes = wsOption.TotalSemImposto;
            option.TotalWithoutICMS = wsOption.TotalSemICMS;
            option.NetValue = wsOption.TotalOpcao;
            option.ShowInBRL = wsOption.MostrarEmReal;

            List<Item> items = new List<Item>();
            foreach(ResellerWebservice.OpcaoPart wsItem in wsOption.Itens)
            {
                items.Add(ProposalMapper.ConvertWebserviceToInterface(wsItem));
            }

            option.Items = items.ToArray();
            return option;
        }

        public static Item ConvertWebserviceToInterface(ResellerWebservice.OpcaoPart wsItem)
        {
            Item item = new Item();
            item.Discount = wsItem.Desconto;
            item.NetPrice = wsItem.Preco;
            item.SKU = wsItem.SKU;
            item.PurchasePrice = wsItem.PrecoFabricante;
            item.Quantity = (int)wsItem.Quantidade;
            item.Uplift = wsItem.Uplift;
            return item;
        }
    }
}