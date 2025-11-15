namespace eZionBlazor.Services;

public class AuthService
{
    public bool IsAuthenticated { get; private set; }
    public string? UserName { get; private set; }
    public event Action? OnAuthChanged;
    public int? SelectedEmpresaId { get; private set; }
    public string? SelectedEmpresaName { get; private set; }
    public event Action? OnEmpresaChanged;

    public void Login(string user)
    {
        IsAuthenticated = true;
        UserName = user;
        OnAuthChanged?.Invoke();
    }

    public void Logout()
    {
        IsAuthenticated = false;
        UserName = null;
        SelectedEmpresaId = null;
        SelectedEmpresaName = null;
        OnAuthChanged?.Invoke();
    }

    public void SetEmpresa(int? id, string? name)
    {
        SelectedEmpresaId = id;
        SelectedEmpresaName = name;
        OnEmpresaChanged?.Invoke();
    }
}