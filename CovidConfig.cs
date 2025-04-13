using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace tpmodul8_103022300003
{
    class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public string batas_hari_deman { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        private const string FilePath = "../../../covid_config.json";

        public void ReadJSON()
        {
            string json = File.ReadAllText(FilePath);
            var config = JsonSerializer.Deserialize<CovidConfig>(json);

            satuan_suhu = config.satuan_suhu == "CONFIG1" ? "celcius" : config.satuan_suhu;
            batas_hari_deman = config.batas_hari_deman.ToString() == "CONFIG2" ? "14" : config.batas_hari_deman;
            pesan_ditolak = config.pesan_ditolak == "CONFIG3" ? "Anda tidak diperbolehkan masuk ke dalam gedung ini" : config.pesan_ditolak;
            pesan_diterima = config.pesan_diterima == "CONFIG4" ? "Anda dipersilahkan untuk masuk ke dalam gedung ini" : config.pesan_diterima;
        }

        public void UbahSatuan()
        {
            if (satuan_suhu.ToLower() == "celcius")
                satuan_suhu = "fahrenheit";
            else
                satuan_suhu = "celcius";

            Save();
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}
