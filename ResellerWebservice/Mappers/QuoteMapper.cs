using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public class QuoteMapper
    {
        public static Quote WebserviceToInterface(PartnerPortalWebservice.Quotation wsQuote)
        {
            Quote quote = new Quote();
            quote.Details = wsQuote.Detalhes;
            quote.FatorMapeado = wsQuote.FatorMapeado;
            quote.Remarks = wsQuote.Observacao;
            
            List<QuoteLine> lines = new List<QuoteLine>();
            foreach(PartnerPortalWebservice.Item wsItem in wsQuote.Itens)
            {
                lines.Add(QuoteMapper.WebserviceToInterface(wsItem));
            }
            quote.QuoteLines = lines.ToArray();
            return quote;
        }

        public static QuoteLine WebserviceToInterface(PartnerPortalWebservice.Item wsItem)
        {
            QuoteLine line = new QuoteLine();
            line.Currency = wsItem.Moeda;
            line.Description = wsItem.Descricao;
            line.Discount = wsItem.Desconto;
            line.FatorDeVenda = wsItem.FatorDeVenda;
            line.FatorDeVendaCode = wsItem.FatorDeVenda_Codigo;
            line.FOBPrice = wsItem.PrecoFOB;
            line.GplPrice = wsItem.PrecoGPL;
            line.ICMS = wsItem.ICMS;
            line.ICMSSTListPrice = wsItem.ICMSSTPrecoLista;
            line.ICMSSTResellerPrice = wsItem.ICMSSTPrecoRevenda;
            line.ICMSSTResellerPriceWithUplift = wsItem.ICMSSTPrecoRevendaComUplift;
            line.Increase = wsItem.Acrescimo;
            line.IPI = wsItem.IPI;
            line.IsActive = wsItem.Ativo;
            line.ListPrice = wsItem.PrecoLista;
            line.NCM = wsItem.NCM;
            line.NetPrice = wsItem.PrecoNET;
            line.RegionCode = wsItem.CodRegiao;
            line.ResellerPrice = wsItem.PrecoRevenda;
            line.ResellerPriceWithUplift = wsItem.PrecoRevendaComUplift;
            line.SBA = wsItem.SBA;
            line.SKU = wsItem.CodPart;
            line.Type = wsItem.Tipo;
            line.Vendor = wsItem.Fabricante;
            line.VendorCode = wsItem.CodFabricante;
            line.VendorDiscout = wsItem.DescontoFabricante;
            line.VendorDollar = wsItem.DolarFabricante;
            line.Qty = wsItem.Quantidade;
            line.MinQty = wsItem.QuantidadeMinima;

            return line;
        }
    }
}