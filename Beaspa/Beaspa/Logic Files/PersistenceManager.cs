using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Beaspa.Logic_Files
{
    public class PersistenceManager
    {
        private string PersistenceFolder { get; } = Application.StartupPath + "\\Persistencia";
        private string PersistenceFilePath { get; } = Application.StartupPath + "\\Persistencia\\Persistencia.beaspa";

        public List<Person> People { get; set; }
        public List<AestheticCenter> AestheticCenters { get; set; }

        public PersistenceManager()
        {
            People = new List<Person>();
            AestheticCenters = new List<AestheticCenter>();
        }

        public void Save()
        {
            PersistenceContainer persistenceContainer = new PersistenceContainer(People, AestheticCenters);
            Directory.CreateDirectory(PersistenceFolder);
            using (var fileStream = new FileStream(PersistenceFilePath, FileMode.Create))
            {
                var bFormatter = new BinaryFormatter();
                bFormatter.Serialize(fileStream, persistenceContainer);
            }
        }

        public void Load()
        {
            Directory.CreateDirectory(PersistenceFolder);
            using (var fileStream = new FileStream(PersistenceFilePath, FileMode.OpenOrCreate))
            {
                deserializeFileIfNotEmpty(fileStream);
            }
        }

        private void deserializeFileIfNotEmpty(FileStream fileStream)
        {
            if (fileStream.Length > 0)
            {
                var bFormatter = new BinaryFormatter();
                PersistenceContainer persistenceContainer = (PersistenceContainer)bFormatter.Deserialize(fileStream);
                People = persistenceContainer.People;
                AestheticCenters = persistenceContainer.AestheticCenters;
            }
        }

        [Serializable]
        private class PersistenceContainer
        {
            public PersistenceContainer(List<Person> people, List<AestheticCenter> aestheticCenters)
            {
                People = people;
                AestheticCenters = aestheticCenters;
            }

            public List<Person> People { get; set; }
            public List<AestheticCenter> AestheticCenters { get; set; }
        }
    }
}
