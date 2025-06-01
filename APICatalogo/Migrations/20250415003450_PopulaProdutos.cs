using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Cerveja', 'Cerveja Pilsen', 5.99, 'https://www.linkparaimagem.com.br/cerveja.jpg', 100, NOW(), 1)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Refrigerante', 'Refrigerante de Cola', 3.49, 'https://www.linkparaimagem.com.br/refrigerante.jpg', 200, NOW(), 1)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Batata Frita', 'Batata Frita Congelada', 4.99, 'https://www.linkparaimagem.com.br/batatinha.jpg', 150, NOW(), 2)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Frango', 'Frango Congelado', 10.99, 'https://www.linkparaimagem.com.br/frango.jpg', 50, NOW(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {

        }
    }
}
