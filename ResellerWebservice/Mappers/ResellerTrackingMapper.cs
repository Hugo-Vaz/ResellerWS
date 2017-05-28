using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public class ResellerTrackingMapper
    {
        public ResellerTracking[] ConvertDatatableToInterface(DataTable data)
        {
            List<ResellerTracking> tracks = new List<ResellerTracking>();
            foreach (DataRow row in data.Rows)
            {
                ResellerTracking track = new ResellerTracking();
                track.BrazilianDate = this.ToDate(row["DataBrasil"].ToString());
                track.CiscoOrderApprovalDate = this.ToDate(row["DataPoCisco"].ToString());
                track.CiscoOriginalForecast = this.ToDate(row["PrevisaoOriginalPoCisco"].ToString());
                track.CurrentBrazilianForecast = this.ToDate(row["PrevisaoAtualBrasil"].ToString());
                track.CurrentForecast = this.ToDate(row["PrevisaoAtual"].ToString());
                track.CustomCurrentForecast = this.ToDate(row["PrevisaoAtualAlfandega"].ToString());
                track.OrderApprovalDate = this.ToDate(row["DataAceiteOV"].ToString());
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

        private DateTime? ToDate(string value)
        {
            try
            {
                if (String.IsNullOrEmpty(value))
                {
                    return null;
                }

                string[] formats = new string[4];
                formats[0] = "dd-MMM-yy";
                formats[1] = "dd/MMM/yyyy";
                formats[2] = "dd-MMM-yy;HH:mm:ss";
                formats[3] = "dd/MM/yyyy";
                return DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture,
                                               DateTimeStyles.AssumeUniversal |
                                               DateTimeStyles.AdjustToUniversal);
            }
            catch
            {
                return null;
            }


        }
    }
}