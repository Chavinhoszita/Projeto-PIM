using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho___PIM
{
    
    internal class RegistroFornecedor
    {
        private string cnpj_f;
        private string f_empresa;
        private string f_contato;
        private string f_telefone;
        private string f_email;
        private string f_cidade;
        private string f_produtos;
        public RegistroFornecedor(string cnpj_f, string f_empresa, string f_contato, string f_telefone, string f_email, string f_cidade, string f_produtos)
        {
            this.cnpj_f = cnpj_f;
            this.f_empresa = f_empresa;
            this.f_contato = f_contato;
            this.f_telefone = f_telefone;
            this.f_email = f_email;
            this.f_cidade = f_cidade;
            this.f_produtos = f_produtos;
        }

        public void imprimirResgForn() 
        {
            Console.WriteLine("Registro Fornecedor:");
            Console.WriteLine("Número do CNPJ: {0}", cnpj_f);
            Console.WriteLine("Nome da empresa: {0}", f_empresa);
            Console.WriteLine("Nome funcionário responsável: {0}", f_contato);
            Console.WriteLine("Contato funcionário responsável: {0}", f_telefone);
            Console.WriteLine("Email para contato: {0}", f_email);
            Console.WriteLine("Local da unidade do fornecedor: {0}", f_cidade);
            Console.WriteLine("Serviço(s) fornecido(s): {0}", f_produtos);
        }


    }

    internal class PedidoFornecedor
    {
        private string nome_empresa;
        private string equipamento;
        private string fruta;
        private string legumes;
        private string verdura;

        public PedidoFornecedor(string nome_empresa, string equipamento, string fruta, string legumes, string verdura)
        {
            this.nome_empresa = nome_empresa;
            this.equipamento = equipamento;
            this.fruta = fruta;
            this.legumes = legumes;            
            this.verdura = verdura;
        }
        
        public void contato_Emp()
        {
            Console.WriteLine("Contatar a empresa: {0}", nome_empresa);
        }

        public void pedido_Fru()
        {
            if (fruta != "")
            {
                Console.WriteLine("Quantidade(s) e nome da fruta(s): {0}", fruta);
            }
            else {}                        
        }

        public void pedido_Eqp()
        {
            if (equipamento != "")
            {
                Console.WriteLine("Quantidade(s), nome(s) e informações do(s) equipamento(s) solicitado(s): {0}", equipamento);
            }
            else {}
        }
        public void pedido_Leg()
        {
            if (legumes != "")
            {
                Console.WriteLine("Quantidade(s) e especificações (legumes): {0}", legumes);
            }
            else {}
        }
        public void pedido_Ver()
        {
            if (verdura != "")
            {
                Console.WriteLine("Quantidade(s) e especificações (verduras): {0}", verdura);
            }
            else { }
        }
    }
}
