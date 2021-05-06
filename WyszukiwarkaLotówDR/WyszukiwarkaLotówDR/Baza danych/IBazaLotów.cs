﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WyszukiwarkaLotówDR.Loty;

namespace WyszukiwarkaLotówDR.Baza_danych
{
    public interface IBazaLotów
    {
        public Lot getLot(int id);
        public List<Lot> getLoty();
    }
}
