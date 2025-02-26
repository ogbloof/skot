﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Virus : IVirus
    {
        protected string _code;
        protected bool _reinfection;
        protected float _infection;
        protected float _letality;

        #region Interface
        public string Code => _code;

        public bool Reinfection => _reinfection;

        public float Infection => _infection;

        public float Lethality => _letality;
        public abstract int AgeToInfect { get; }
        #endregion
        protected Virus(string code, bool reinfection, float infection, float letality)
        {
            _code = code;
            _reinfection = reinfection;
            _infection = infection;
            _letality = letality;
        }

        abstract public bool Death(Person person);
    
        abstract public void Infect(Person person);
    }
}
