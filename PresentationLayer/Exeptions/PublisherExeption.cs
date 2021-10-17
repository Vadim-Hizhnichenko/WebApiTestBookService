using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Exeptions
{
    //soon

    [Serializable]
    public class PublisherExeption : Exception
    {
        public string PublisherName { get; set; }
        public PublisherExeption()
        {

        }
        
    }
}
