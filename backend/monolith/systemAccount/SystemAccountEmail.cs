using csCY_Avenue.backend.monolith.common;

namespace csCY_Avenue.backend.monolith.systemAccount;

public class SystemAccountEmail : EmailSendBase
{

    public void SendVerificationCodeEmail()
    {

    }


    protected override string LoadEmailTemplate()
    {
        return File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"template\",
            "EmailForgotPassword.html"));
    }

    // Override to fill in the placeholders for the client email
    protected override string SetEmailBody(string emailTemplate, string username, string? verificationCode)
    {
        return emailTemplate
            .Replace("<span id=\"username-placeholder\"></span>", $"<span>{username}</span>")
            .Replace("<div class=\"verification-code\" id=\"code-placeholder\">123456</div>", $"<div class=\"verification-code\">{verificationCode}</div>")
            .Replace("<span id=\"membership-type-placeholder\"></span>", $"<span>{verificationCode}</span>"); // Example for future use
    }
}