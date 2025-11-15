using eZionBlazor.Contabil.Models;

namespace eZionBlazor.Contabil.Services;

public class EmpresaService : IEmpresaService
{
    private readonly List<Empresa> _empresas = new();
    private int _seq = 1;

    public IEnumerable<Empresa> List() => _empresas.OrderBy(e => e.RazaoSocial);

    public Empresa? Get(int id) => _empresas.FirstOrDefault(e => e.Id == id);

    public Empresa Create(Empresa empresa)
    {
        empresa.Id = _seq++;
        _empresas.Add(empresa);
        return empresa;
    }

    public void Update(Empresa empresa)
    {
        var current = Get(empresa.Id);
        if (current is null) return;
        current.RazaoSocial = empresa.RazaoSocial;
        current.Cnpj = empresa.Cnpj;
        current.Ativa = empresa.Ativa;
    }

    public void Delete(int id)
    {
        var current = Get(id);
        if (current is null) return;
        _empresas.Remove(current);
    }
}