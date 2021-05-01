using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Domain
{
    public class SellService
    {
        public void Pay(
            //idUsuario que veio da request
            )
        {
            //pegar informações do usuário - acessar banco de dados

            //determinar meio de pagamento
            //pegar cartão de crédito - acessar banco de dados

            //validar cartão de crédito

            //verificar se tem o produto em estoque - acessar banco de dados
            //TemEmEstoque
            var estoqueSqlServerRepository = new EstoqueSqlServerRepository();
            estoqueSqlServerRepository.TemEmEstoque();

            //reservar em estoque - acessar banco de dados
            //ReservarItem
            estoqueSqlServerRepository.ReservarItem();
            //cobrar do cartão

            //decrementar do estoque - acessar banco de dados
            //DecrementarEstoque
            estoqueSqlServerRepository.DecrementarEstoque();
            //enviar email para usuario

            //retornar relatório pro usuário
        }

        public void PayAfter()
        {
            //pegar informações do usuário

            //determinar meio de pagamento
            //cartão de crédito

            //validar cartão de crédito

            //verificar se tem o produto em estoque

            //cobrar do cartão

            //decrementar do estoque

            //enviar email para usuario

            //retornar relatório pro usuário
        }
    }
}
