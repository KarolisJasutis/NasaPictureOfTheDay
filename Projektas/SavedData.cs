using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Projektas
{
    
    internal class SavedData
    {
        public string fname = "SavedPics.json";
        public void SaveToFile(PotdData json)
        {
            string existingJson;

            if (File.Exists(fname))
            {
                existingJson = File.ReadAllText(fname);
            }
            else
            {
                existingJson = "[]";
            }

            List<PotdData> existingData = JsonConvert.DeserializeObject<List<PotdData>>(existingJson) ?? new List<PotdData>();
            existingData.Add(json);
            string updatedJson = JsonConvert.SerializeObject(existingData,Formatting.Indented);
            File.WriteAllText(fname, updatedJson);
            
        }
        public void SaveNotesToFile(string notes, DateTime date)
        {
            string existingJson;

            if (File.Exists(fname))
            {
                existingJson = File.ReadAllText(fname);
            }
            else
            {
                existingJson = "[]";
            }

            List<PotdData> existingData = JsonConvert.DeserializeObject<List<PotdData>>(existingJson) ?? new List<PotdData>();          
            PotdData dataToUpdate = existingData.First(data => DateTime.Parse(data.Date) == date);
            dataToUpdate.Notes = notes;
            string updatedJson = JsonConvert.SerializeObject(existingData, Formatting.Indented);
            File.WriteAllText(fname, updatedJson);

        }
        public List<PotdData> LoadFromFile()
        {
            string existingJson;

            if (File.Exists(fname))
            {
                existingJson = File.ReadAllText(fname);
            }
            else
            {
                existingJson = "[]";
            }

            List<PotdData> existingData = JsonConvert.DeserializeObject<List<PotdData>>(existingJson);

            return existingData;
        }
        public PotdData GetDataFromTitle(string title)
        {
            List<PotdData> allData = LoadFromFile();
            PotdData filtDate = allData.First(potd => potd.Title == title);
            return filtDate;
        }
        public string[] GetAllTitles()
        {
            List<PotdData> allData = LoadFromFile();
            string[] titles  = allData.Select(potd => potd.Title).ToArray();
            return titles;

        }
        public string[] GetAllDates()
        {
            List<PotdData> allData = LoadFromFile();
            string[] dates = allData.Select(potd => potd.Date).ToArray();
            return dates;

        }
        public void DeleteDataFromTitle(string title)
        {
            string existingJson;


            if (File.Exists(fname))
            {
                existingJson = File.ReadAllText(fname);
            }
            else
            {
                existingJson = "[]";
            }

            List<PotdData> existingData = JsonConvert.DeserializeObject<List<PotdData>>(existingJson) ?? new List<PotdData>();
            PotdData removeData = existingData.FirstOrDefault(potd => potd.Title == title);
            existingData.Remove(removeData);
            string updatedJson = JsonConvert.SerializeObject(existingData, Formatting.Indented);
            File.WriteAllText(fname, updatedJson);
        }

    }
}
