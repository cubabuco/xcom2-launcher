using System;
using System.ComponentModel;
using XCOM2Launcher.Mod;

namespace XCOM2Launcher.Classes.Mod
{
    /// <summary>
    /// A class used for the purpose of data binding to object property view, controlling which field can be edited and handle any
    /// code needed when a field is edited.
    /// </summary>
    public class ModProperty : INotifyPropertyChanged
    {
        [Browsable(false)]
        private ModEntry modEntry;

        public event PropertyChangedEventHandler PropertyChanged;

        [Browsable(false)]
        public ModEntry ModEntry
        {
            get { return modEntry; }
        }

        [Category("Mod Info")]
        public string Name
        {
            get { return modEntry.Name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    modEntry.Name = "";
                    modEntry.ManualName = false;
                    PropertyChangedEventArgs e = new PropertyChangedEventArgs("Name");
                    PropertyChanged?.Invoke(this, e);
                }
                else if (!value.Equals(modEntry.Name))
                {
                    modEntry.Name = value;
                    modEntry.ManualName = true;
                    PropertyChangedEventArgs e = new PropertyChangedEventArgs("Name");
                    PropertyChanged?.Invoke(this, e);
                }
            }
        }

        public ModProperty(ModEntry modEntry)
        {
            this.modEntry = modEntry;
        }
    }
}
