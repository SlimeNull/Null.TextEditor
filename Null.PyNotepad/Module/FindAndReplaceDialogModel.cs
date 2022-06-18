using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null.PyNotepad.Module
{
    internal class FindAndReplaceDialogModel : INotifyPropertyChanged
    {
        public string ToFind { get; set; } = string.Empty;
        public string ReplaceTo { get; set; } = string.Empty;

        public bool MatchCase { get; set; }
        public bool MatchWholeWord { get; set; }
        public bool UseRegularExpression { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
