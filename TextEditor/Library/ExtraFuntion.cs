using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TextEditor.Library
{
    public static class ExtraFunctions
    {
        public static int CountOf<T>(this IEnumerable<T> elements, T target)
        {
            int result = 0;
            foreach (T i in elements)
                if (i.Equals(target))
                    result++;

            return result;
        }
        public static void Insert(this TextBox textBox, string text)
        {
            textBox.SelectedText = text;
            textBox.CaretIndex += text.Length;
            textBox.SelectionLength = 0;
        }
    }
}
