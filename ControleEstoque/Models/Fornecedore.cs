using System;
using System.Collections.Generic;

namespace ControleEstoque.Models;

public partial class Fornecedore
{
    public int FornecedorId { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cnpj { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
