namespace CarlosYulo.backend.monolith.systemAccount;

public class SystemAccountController
{
    private readonly SystemAccountOtherServices _others;
    private readonly SystemAccountLoginServices _login;
    private readonly SystemAccountSearchServices _search;
    private readonly SystemAccountUpdateServices _update;

    public SystemAccountController(
        SystemAccountOtherServices others,
        SystemAccountLoginServices login,
        SystemAccountSearchServices search,
        SystemAccountUpdateServices update)
    {
        _others = others;
        _login = login;
        _search = search;
        _update = update;
    }

    // OTHERS (CREATE, DELETE, EMAIL)
    public bool Create(SystemAccount systemAccount)
    {
        return _others.Create(systemAccount);
    }

    public bool Delete(SystemAccount systemAccount)
    {
        return _others.Delete(systemAccount);
    }

    public bool DeleteById(int systemAccountId)
    {
        return _others.DeleteById(systemAccountId);
    }

    public bool SendVerificationCodeEmail(SystemVerification verification, string accountEmail)
    {
        return _others.SendVerificationCodeEmail(verification, accountEmail);
    }
    
    
    // LOGIN
    public bool CheckAccountIfStaff(SystemAccount systemAccount)
    {
        return _login.CheckAccountIfStaff(systemAccount);
    }

    public bool CheckAccountIfAdmin(SystemAccount systemAccount)
    {
        return _login.CheckAccountIfAdmin(systemAccount);
    }

    public bool CompareVerification(SystemVerification verification, SystemAccount account, string userInput)
    {
        return _login.CompareVerification(verification, account, userInput);
    }

    public bool GenerateSystemAccountVerificationAndSave(SystemAccount? account,
        out SystemVerification systemVerification)
    {
        return _login.GenerateSystemAccountVerificationAndSave(account, out systemVerification);
    }

    public void DeleteVerificationById(int? userId)
    {
        _login.DeleteVerificationById(userId);
    }
    
    
    // SEARCH
    public List<SystemAccount>? SearchAll()
    {
        return _search.SearchAll();
    }

    public SystemAccount? SearchByEmail(string email)
    {
        return _search.SearchByEmail(email);
    }

    public SystemAccount? SearchById(int userId)
    {
        return _search.SearchById(userId);
    }
    
    
    // UPDATE
    public bool UpdateDetails(SystemAccount account)
    {
        return _update.UpdateDetails(account);
    }

    public bool ChangePasswordInForgetPassword(SystemAccount account, string password, string confirmPassword)
    {
        return _update.ChangePasswordInForgetPassword(account, password, confirmPassword);
    }
    
    public bool ChangePasswordAsAdmin(SystemAccount account, string password)
    {
        return _update.ChangePasswordAsAdmin(account, password);
    }

    public bool ChangePassword(SystemAccount account, string previousPassword, string newPassword)
    {
        return _update.ChangePassword(account, previousPassword, newPassword);
    }
}