using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall.Entities
{
    class Viga
    {
        #region atributos
        public double BaseViga { get; set; }
        public double AlturaViga { get; set; }
        public double ComprimentoViga { get; set; }
        public double DLinha { get; set; }
        public double AlturaUtil { get; set; }
        public double ComprConsolo { get; set; }
        public double AlturaRecorteConsolo { get; set; }
        public double AreaLateral {
            get { return AreaLateral = (AlturaViga * ComprimentoViga - AlturaRecorteConsolo * ComprConsolo * 2); }
            set { }
        }
        public double DiametroPino { get; set; }
        public double QtdPino { get; set; }
        public double VolumePino { 
            get { return VolumePino = (Math.Pow(DiametroPino, 2) * Math.PI / 4) * (AlturaViga - AlturaRecorteConsolo); }
            set { }
         }
        public double Volume
        {
            get { return Volume = AreaLateral * BaseViga; }
            set { }
        }
        public double Peso
        {
            get { return Peso = Volume * 2500; /*Por enquanto o peso específico do concreto é fixo*/ }
            set { }
        }

        #endregion
    }
}
