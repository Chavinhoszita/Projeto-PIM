using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
    Tema: Levantamento e analise de requisitos de um sistema de controle de uma fazenda urbana de uma startup
focada em garatir inovação para área de segurança alimentar.

    Objetivo Geral: Levantamento e analise de todos os processos necessários para controle de produção,
fornecedores, venda aos clientes, relatórios do negócio e etc. Deverá ser desenvolvido um conjunto preliminar
de bibliotecas de acesso testadas em aplicativo console, a lei geral de proteção de dados deve ser aplicada
para todas as pessoas físicas.

    Contextualização: inovação da segurança alimentar, criamos uma fazenda urbana uzando I.A (vamos usar uma
API de I.A gratuita desenvolvida por uma universidade (fictíca) que fornece informações sobre tipo de alimentos
que devem ser produzidos em uma determinada época do ano para uma localidade geográfica específica.
Nossa missão é seguir os objetivos de desenvolvimento sustentável delineados pela ONU.
Precisamos apresentar nossa viabilidade da fazenda urbana para segurança alimentar, para concretizar seu objetivo
serão desenvolvidos vários sistemas, entre eles, UM SISTEMA DE CONTROLE DE FORNECEDORES, PRODUÇÃO, VENDA DOS PRODUTOS
RELATÓRIOS E ETC.
Realizar uma interface gráfica em C#*/
/*
UM SISTEMA DE CONTROLE DE:
FORNECEDORES
PRODUÇÃO
VENDA DOS PRODUTOS
RELATÓRIOS*/

namespace Trabalho___PIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistroFornecedor rf = new RegistroFornecedor("00.000.000/0000-00","Dados","Dados","(16) 9999-8888","Dados","Dados","Dados");
            Console.WriteLine();
            rf.imprimirResgForn();
            Console.WriteLine();

            PedidoFornecedor pf = new PedidoFornecedor("Dados","Dados","Dados","Dados","Dados"); // nome_empresa, frutas, equipamento, fruta, legumes, verdura
            pf.contato_Emp();
            
            pf.pedido_Eqp();
            pf.pedido_Fru();            
            pf.pedido_Leg();
            pf.pedido_Ver();
            Console.WriteLine();

            Plant_Produção p_prod = new Plant_Produção("24/05/2024",7,9,5); //data, caixas frutas, caixas verduras, caixas alface_verdura
            p_prod.plant_ProdInfo();
            p_prod.plant_maça(2);
            p_prod.plant_morango(2);
            p_prod.plant_uva(1);
            p_prod.plant_alface(3);
            p_prod.plant_rucula(2);
            p_prod.plant_brocolis(2);
            p_prod.plant_ervilha(1);
            p_prod.plant_abobora(1);
            p_prod.plant_pimentao(1);
            Console.WriteLine();
            
            Colhe_Produção c_prod = new Colhe_Produção(7,10,9);
            c_prod.setEst_f(10);
            c_prod.setEst_v(10);
            c_prod.setEst_l(5);
            c_prod.estoq_Produção();
            //c_prod.colh_maça(2);
            Console.WriteLine();
            c_prod.vender_estf(2);
            c_prod.vender_estv(5);
            c_prod.vender_estl(10);
            Console.WriteLine();
            c_prod.colhe_ProdInfo();
            Console.WriteLine();
            c_prod.estoque_Colheita();
            Console.WriteLine();
        }
    }
}
