using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public class StockMapper
    {
        public Stock ConvertWebserviceToInterface(PartnerPortalWebservice.StockItem wsStock)
        {
            Stock stock = new Stock();
            stock.CodVendor = wsStock.CodVendor;
            stock.Description = wsStock.Descricao;
            stock.FatorVenda = wsStock.FatorVenda;
            stock.FatorVendaCode = wsStock.FatorVendaCodigo;
            stock.ICMS = wsStock.ICMS;
            stock.IPI = wsStock.IPI;
            stock.LocalStock = wsStock.LocalStock;
            stock.NCM = wsStock.NCM;
            stock.NetPrice = wsStock.NetPrice;
            stock.Partnumber = wsStock.Partnumber;
            stock.Promo = wsStock.Promo;
            stock.ResellerPrice = wsStock.ResellerPrice;
            stock.TransitStock = wsStock.TransitStock;
            stock.Type = wsStock.Type;
            stock.Vendor = wsStock.Fabricante;
            stock.Message = wsStock.ErrorMessage;
            stock.Success = wsStock.Success;

            return stock;
        }
    }
}