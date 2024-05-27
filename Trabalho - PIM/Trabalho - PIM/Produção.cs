using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho___PIM
{
    //são classificadas como legumes são os frutos, as raízes, os caules e os tubérculos.
    //as verdura são tipos de plantas em forma de folhas e fruta que são comestíveis.

    internal class Plant_Produção
    {
        private string data;
        private int frutas;
        private int verduras;
        private int legumes;
        private int maca, morango, uva;
        private int alface, rucula, brocolis;
        private int ervilha, abobora, pimentao;

        public Plant_Produção(string data, int frutas, int verduras, int legumes)
        {
            this.data = data;
            this.frutas = frutas;
            this.verduras = verduras;
            this.legumes = legumes;
        }
        public void plant_ProdInfo()
        {
            Console.WriteLine("Produção total do dia: {0}", data);
            Console.WriteLine("Frutas plantadas: {0}", frutas);
            Console.WriteLine("Verduras plantadas: {0}", verduras);
            Console.WriteLine("Legumes plantados: {0}", legumes);
        }

        public void plant_maça(int qtd)
        {
            maca = qtd;
            Console.WriteLine("\nDas {0} frutas:\n{1} Macieira(s) plantada(s).", frutas, maca);
        }
        public void plant_morango(int qtd)
        {
            morango = qtd;
            Console.WriteLine("{0} Morangueiro(s) plantado(s).", morango);
        }
        public void plant_uva(int qtd)
        {
            uva = qtd;
            Console.WriteLine("{0} Vinha(s) plantada(s).", uva);
        }
        public void plant_alface(int qtd)
        {
            alface = qtd;
            Console.WriteLine("\nDas {0} verduras:\n{1} Alface(s) plantada(s).", verduras, alface);
        }
        public void plant_rucula(int qtd)
        {
            rucula = qtd;
            Console.WriteLine("{0} Rúcula(s) plantada(s).", rucula);
        }
        public void plant_brocolis(int qtd)
        {
            brocolis = qtd;
            Console.WriteLine("{0} Brócoli(s) plantado(s).", brocolis);
        }
        public void plant_ervilha(int qtd)
        {
            ervilha = qtd;
            Console.WriteLine("\nDos {0} legumes:\n{1} Ervilheira(s) plantada(s).", legumes, ervilha);
        }
        public void plant_abobora(int qtd)
        {
            abobora = qtd;
            Console.WriteLine("{0} Aboboreira(s) plantada(s).", abobora);
        }
        public void plant_pimentao(int qtd)
        {
            pimentao = qtd;
            Console.WriteLine("{0} Pimentão(ões) plantado(s).", pimentao);
        }        
    }

    public class Colhe_Produção
    {
        private int col_f, col_v, col_l;
        private int est_basef, est_basev, est_basel;
        private int est_f, est_v, est_l;
        private int maca, morango, uva;
        private int alface, rucula, brocolis;
        private int ervilha, abobora, pimentao;

        public Colhe_Produção(int col_f, int col_v, int col_l)
        {
            this.col_f = col_f;
            this.col_v = col_v;
            this.col_l = col_l;
        }

        public void colhe_ProdInfo()
        {
            Console.WriteLine("Total de frutas colhidas: {0}", col_f);
            Console.WriteLine("Total de verduras colhidas: {0}", col_v);
            Console.WriteLine("Total de legumes colhidas: {0}", col_l);
        }


        public void setEst_f(int qtd)
        {
            est_basef = qtd;
        }
        public void setEst_v(int qtd)
        {
            est_basev = qtd;
        }

        public void setEst_l(int qtd)
        {
            est_basel = qtd;
        }

        public void estoq_Produção()
        {
            Console.WriteLine("Estoque de frutas: {0}", est_basef);
            Console.WriteLine("Estoque de verduras: {0}", est_basev);
            Console.WriteLine("Estoque de legumes: {0}", est_basel);
            Console.WriteLine();
        }

        public void estoque_Colheita()
        {

            est_f = est_basef + col_f;
            Console.WriteLine("Estoque fruta após colheita: {0}", est_f);
            est_v += est_basev +col_v;
            Console.WriteLine("Estoque verduras após colheita: {0}", est_v);
            est_l += est_basel +col_l;
            Console.WriteLine("Estoque legumes após colheita: {0}", est_l);
            Console.WriteLine();
        }

        public void colh_maça(int qtd)
        {
            maca = qtd;
            Console.WriteLine("\nDas {0} frutas:\n{1} Maçãs colhidas.", est_f, maca);
        }
        public void colh_morango(int qtd)
        {
            morango = qtd;
            Console.WriteLine("{0} Morangos colhidos.", morango);
        }
        public void colh_uva(int qtd)
        {
            uva = qtd;
            Console.WriteLine("{0} Uvas colhida(s).", uva);
        }
        public void colh_alface(int qtd)
        {
            alface = qtd;
            Console.WriteLine("\nDas {0} verduras:\n{1} Alfaces colhidas.", est_v, alface);
        }
        public void colh_rucula(int qtd)
        {
            rucula = qtd;
            Console.WriteLine("{0} Rúculas colhidas.", rucula);
        }
        public void colh_brocolis(int qtd)
        {
            brocolis = qtd;
            Console.WriteLine("{0} Brócolis colhidos.", brocolis);
        }
        public void colh_ervilha(int qtd)
        {
            ervilha = qtd;
            Console.WriteLine("\nDos {0} legumes:\n{1} Ervilheiras colhidas.", est_l, ervilha);
        }
        public void colh_abobora(int qtd)
        {
            abobora = qtd;
            Console.WriteLine("{0} Abóboras colhidas.", abobora);
        }
        public void colh_pimentao(int qtd)
        {
            pimentao = qtd;
            Console.WriteLine("{0} Pimentões colhidos.", pimentao);
        }



        public void vender_estf(int qtd)
        {
            if (qtd == 0)
            {

            }
            else
            {
                
                if (est_basef >= qtd)
                {
                    est_basef -= qtd;
                    Console.WriteLine("Foram vendidas {0} caixas de frutas.", qtd);
                }
                else { Console.WriteLine("Venda negada, pois a quantidade de caixas de fruta no estoque é menor que o pedido"); }
            }
        }

        public void vender_estv(int qtd)
        {
            if (qtd == 0)
            {

            }
            else
            {
                
                if (est_basev >= qtd)
                {
                    est_basev -= qtd;
                    Console.WriteLine("Foram vendidas {0} caixas de verduras.", qtd); 
                }
                else { Console.WriteLine("Venda negada, pois a quantidade de caixas de verduras no estoque é menor que o pedido"); }
            }
        }

        public void vender_estl(int qtd)
        {
            if (qtd == 0)
            {

            }
            else
            {
                
                if (est_basel >= qtd)
                {
                    est_basel -= qtd;
                    Console.WriteLine("Foram vendidas {0} caixas de legumes.", qtd); 
                }
                else { Console.WriteLine("Venda negada, pois a quantidade de caixas de legumes no estoque é menor que o pedido"); }
            }
        }                        
    }
}

