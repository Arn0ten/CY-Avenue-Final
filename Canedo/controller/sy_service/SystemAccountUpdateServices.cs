using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.employee;
using CarlosYulo.backend.monolith.systemAccount.sy_login;

namespace CarlosYulo.backend.monolith.systemAccount;

public class SystemAccountUpdateServices
{
    private readonly SystemAccountUpdateDetails _updateDetails;
    private readonly SystemAccountUpdatePassword _updatePassword;
    private readonly ErrorMessageBox _messageBox;

    public SystemAccountUpdateServices(
        SystemAccountUpdateDetails updateDetails,
        SystemAccountUpdatePassword updatePassword)
    {
        _updateDetails = updateDetails;
        _updatePassword = updatePassword;
        _messageBox = new ErrorMessageBox();
    }

    public bool UpdateDetails(SystemAccount account)
    {
        string message;
        if (!_updateDetails.UpdateDetails(account, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }

        return true;
    }

    public bool ChangePasswordInForgetPassword(SystemAccount account, string password, string confirmPassword)
    {
        string message;
        if (!_updatePassword.ChangePasswordInForgetPassword(account, password, confirmPassword, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }
        return true;
    }

    public bool ChangePasswordAsAdmin(SystemAccount account, string password)
    {
        string message;
        if (!_updatePassword.ChangePasswordAsAdmin(account, password, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }

        return true;
    }

    public bool ChangePassword(SystemAccount account, string previousPassword, string newPassword)
    {
        string message;
        if (!_updatePassword.ChangePassword(account, previousPassword, newPassword, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }

        return true;
    }
}