using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Model;

namespace eRestoran.WebAPI.CBF
{
    public class WordBagGenerator
    {
        public string GenerateWordBag<T>(object item)
        {
            if (typeof(T) == typeof(Proizvodi))
            {
                var eventObj = item as Proizvodi;
                string wordBag = eventObj.Cijena + "_" + eventObj.Naziv.ToLower();


                return wordBag;
            }
            return String.Empty;
        }

    }
}