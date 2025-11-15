using eZionBlazor.Contabil.Models;

namespace eZionBlazor.Contabil.Services;

public interface IEmpresaService
{
    IEnumerable<Empresa> List();
    Empresa? Get(int id);
    Empresa Create(Empresa empresa);
    void Update(Empresa empresa);
    void Delete(int id);
}