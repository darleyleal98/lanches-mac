using LanchesMac.Context;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            // Define uma sessão
            ISession session =
                services.GetRequiredService<HttpContextAccessor>()?.HttpContext.Session;

            // Obtém um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            // Obtém ou gera o Id do carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            // Atribui o Id do carrinho na sessão
            session.SetString("CarrinhoId", carrinhoId);

            // Retorna o carrinho com o contexto e o Id atribuído ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

        public void AdicionarAoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem =
                _context.CarrinhoComprasItens.SingleOrDefault(
                    value => value.Lanche.LancheId == lanche.LancheId &&
                    value.CarrinhoCompraId == CarrinhoCompraId);

            if (carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };

                _context.CarrinhoComprasItens.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }
            _context.SaveChanges();
        }

        public int RemoveDoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem =
                _context.CarrinhoComprasItens.SingleOrDefault(
                    value => value.Lanche.LancheId == lanche.LancheId &&
                    value.CarrinhoCompraId == CarrinhoCompraId);

            var quantidadeLocal = 0;

            if (carrinhoCompraItem != null)
            {
                if (carrinhoCompraItem.Quantidade >= 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else
                {
                    _context.CarrinhoComprasItens.Remove(carrinhoCompraItem);
                }
            }

            _context.SaveChanges();
            return quantidadeLocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            return CarrinhoCompraItens ?? 
                            (CarrinhoCompraItens = 
                             _context.CarrinhoComprasItens
                             .Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
                             .Include(s => s.Lanche)
                             .ToList());
        }

        public void LimparCarrinho()
        {
            var carrinhoItens = _context.CarrinhoComprasItens
                                .Where(carrinho => carrinho.CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoComprasItens.RemoveRange(carrinhoItens);
            _context.SaveChanges();
        }

        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.CarrinhoComprasItens
                        .Where(carrinho => carrinho.CarrinhoCompraId == CarrinhoCompraId)
                        .Select(carrinho => carrinho.Lanche.Preco * carrinho.Quantidade).Sum();

            return total;
        }
    }
}