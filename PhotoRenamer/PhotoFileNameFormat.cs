using System.Collections.Generic;
using System.Linq;

namespace PhotoRenamer
{
    public enum PhotoFileNameType { Num_sep_text = 1, Num = 2 }
    public class PhotoFileNameFormat
    {       
        public PhotoFileNameType Type { get; }
        public PhotoFileNameFormat(PhotoFileNameType type, string seperator)
        {
            this.Type = type;
            this.Separator = seperator;
        }
        public string Separator { get; set; }        
    }    
}
