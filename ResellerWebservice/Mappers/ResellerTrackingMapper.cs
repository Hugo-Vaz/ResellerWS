using ResellerWebservice.Entities;
using ResellerWebservice.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public static class ResellerTrackingMapper
    {
        public static ResellerTracking[] ConvertDatatableToInterface(DataTable data)
        {
            List<ResellerTracking> tracks = new List<ResellerTracking>();
            foreach (DataRow row in data.Rows)
            {
                ResellerTracking track = new ResellerTracking();
                track.BrazilianDate = ConversionTool.ToDate(row["DataBrasil"].ToString());
                track.CiscoOrderApprovalDate = ConversionTool.ToDate(row["DataPoCisco"].ToString());
                track.CiscoOriginalForecast = ConversionTool.ToDate(row["PrevisaoOriginalPoCisco"].ToString());
                track.CurrentBrazilianForecast = ConversionTool.ToDate(row["PrevisaoAtualBrasil"].ToString());
                track.CurrentForecast = ConversionTool.ToDate(row["PrevisaoAtual"].ToString());
                track.CustomCurrentForecast = ConversionTool.ToDate(row["PrevisaoAtualAlfandega"].ToString());
                track.OrderApprovalDate = ConversionTool.ToDate(row["DataAceiteOV"].ToString());
                track.ParametrizCanal = row["ParametrizCanal"].ToString();
                track.Qty = Convert.ToInt32(row["Qtd"].ToString());
                track.Remarks = row["Observacoes"].ToString();
                track.SKU = row["Partnumber"].ToString();
                track.SkuSource = row["OrigemPartnumber"].ToString();
                track.Source = row["Origem"].ToString();
                track.Status= row["Status"].ToString();
                track.StatusExpediteComstor = row["StatusExpediteComstor"].ToString();
                track.Vendor = row["Fabricante"].ToString();

                tracks.Add(track);
            }
            return tracks.ToArray();
        }

       
    }
}