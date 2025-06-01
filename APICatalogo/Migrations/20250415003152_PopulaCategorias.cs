using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bebidas', 'https://www.linkparaimagem.com.br/bebidas.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Aperitivos', 'https://www.linkparaimagem.com.br/aperitivos.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Carnes', 'https://www.linkparaimagem.com.br/carnes.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Laticínios', 'https://www.linkparaimagem.com.br/laticinios.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Frutas', 'https://www.linkparaimagem.com.br/frutas.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Verduras', 'https://www.linkparaimagem.com.br/verduras.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Legumes', 'https://www.linkparaimagem.com.br/legumes.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Doces', 'https://www.linkparaimagem.com.br/doces.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Congelados', 'https://www.linkparaimagem.com.br/congelados.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Temperos', 'https://www.linkparaimagem.com.br/temperos.jpg')");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Grãos', 'https://www.linkparaimagem.com.br/graos.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.DropSequence("Categorias");
        }
    }
}
