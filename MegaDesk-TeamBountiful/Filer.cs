using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace MegaDesk_TeamBountiful
{
    public class Filer
    {
        public readonly List<DeskQuote> DeskQuotes;
        private readonly string _jsonFile = @"quotes.json";

        public Filer()
        {
            try
            {
                var jsonData = File.ReadAllText(_jsonFile);
                DeskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
            }
            catch (Exception)
            {
                // Since it failed array wasn't initialized. Do so.
                DeskQuotes = new List<DeskQuote>();
            }
        }

        public void SaveToJson()
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(DeskQuotes, Formatting.Indented);
                File.WriteAllText(_jsonFile, jsonData);
            }
            catch (Exception)
            {
                MessageBox.Show(@"There was an error saving DeskQuotes.");
            }
        }

        public void Search(DesktopMaterial surfaceMaterial, ref List<DeskQuote> searchDeskQuotes)
        {
            searchDeskQuotes.Clear();
            foreach (var quote in DeskQuotes)
            {
                if (quote.TheDesk.SurfaceMaterial == surfaceMaterial)
                    searchDeskQuotes.Add(quote);
            }
        }

        public void AddQuote(ref DeskQuote quote)
        { 
            DeskQuotes.Add(quote);
        }
    }
}
