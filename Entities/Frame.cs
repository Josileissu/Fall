using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall.Entities
{
    internal class Frame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NodeI { get; set; } //tem que ser um objeto do tipo Nó
        public int NodeF { get; set; } //Mesma coisa que o de cima;
        public bool RotI { get; set; }
        public bool RotF { get; set; }
        public string Type { get; set; }
        public double Length { get; set; }
        public double Theta { get; set; } //angulo no plano xy;
        public double Gamma { get; set; } //angulo no plano xy;
        public string Section { get; set; } //objeto da seção - ver como atrelar um objeto;
        //Tem que pegar as propriedades de área a1, a2, a3, E, G, I1, I2, I3, Peso,
        public double QyLoad { get; set; }
        public double QxLoad { get; set; }
        public double PyLoad { get; set; }
        public double PxLoad { get; set; }
        public double MzLoad { get; set; }
        public double DistPyLoad { get; set; }
        public double DistPxLoad { get; set; } //fazer um array com as cargas Px consideradas e um array com as posições sendo correspondentes, por exemplo P1 na posição 1 e D1 na posição 1...
        public double DistMzLoad { get; set; }
        public double[][] RotateLocalToGlobal { get; set; }
        public double[][] RotateGlobalToLocal { get; set; }
        public double[][] FactorLoading { get; set; }
        public double[][] Stiffness { get; set; }
        public double[][] Forces { get; set; }
        public double[][] Displacements { get; set; }
        public Frame(int Id, string Name, double Gamma, int NodeI, int NodeF)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gamma = Gamma;

        }
        public static double Atn2(double x, double y)
        {
            if (x == 0)
            {
                if (y == 0)
                {
                    return 9999999;
                }
                else if (y > 0)
                {
                    return Math.PI / 2;
                }
                else
                {
                    return -Math.PI / 2;
                }
            }
            else if (x > 0)
            {
                if (y == 0)
                {
                    return 0;
                }
                else
                {
                    return Math.Atan(y / x);
                }
            }
            else
            {
                if (y == 0)
                {
                    return Math.PI;
                }
                else
                {
                    return Math.PI - (Math.Sign(y) * Math.Atan(Math.Abs(y) / Math.Abs(x))
                    }
            }
        }
        }
    }
