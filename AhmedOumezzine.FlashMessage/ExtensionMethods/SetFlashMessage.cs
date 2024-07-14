using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace AhmedOumezzine.FlashMessage
{
    /// <summary>
    /// Extension Methods class for extending built-in methods.
    /// </summary>
    public static partial class ExtensionMethods
    {
        public static void SetMessage(this ITempDataDictionary tempData, AlertMessage alertMessage, string tempKeyName = "FlashMessage")
        {
            if (string.IsNullOrEmpty(tempKeyName) || string.IsNullOrWhiteSpace(tempKeyName))
                tempKeyName = "FlashMessage";

            tempData[$"{tempKeyName}.Text"] = string.IsNullOrEmpty(alertMessage.Text) ? string.Empty : alertMessage.Text;
            tempData[$"{tempKeyName}.Title"] = string.IsNullOrEmpty(alertMessage.Title) ? string.Empty : alertMessage.Title;
            tempData[$"{tempKeyName}.Type"] = alertMessage.Type.ToString().ToLower();
            tempData[$"{tempKeyName}.Dismissible"] = alertMessage.Dismissible ? "true" : "false";
            tempData[$"{tempKeyName}.UseBootstrap4"] = alertMessage.UseBootstrap4 ? "true" : "false";
        }

        public static void SetFlashMessage(this ITempDataDictionary tempData, AlertMessage alertMessage)
        {
            SetMessage(tempData, alertMessage, "FlashMessage");
        }

        public static void SetFlashMessage(
            this ITempDataDictionary tempData,
            string text,
            string? title,
            AlertType alertType,
            bool dismissible = false,
            bool useBootstrap4 = false)
        {
            AlertMessage alertMessage = new(text, title, alertType, dismissible, useBootstrap4);
            SetMessage(tempData, alertMessage, "FlashMessage");
        }

        public static void SetFormMessage(this ITempDataDictionary tempData, FormAlert formAlert)
        {
            SetMessage(tempData, formAlert, "FormMessage");

            tempData["FormMessage.Errors"] = string.IsNullOrEmpty(formAlert.Errors) ? string.Empty : formAlert.Errors;
        }

        #region Convience Methods

        public static void SetSuccessMessage(
            this ITempDataDictionary tempData,
            string text,
            string? title,
            bool dismissible = true,
            bool useBootstrap4 = false)
        => SetFlashMessage(tempData, text, title, AlertType.Success, dismissible, useBootstrap4);

        public static void SetErrorMessage(
            this ITempDataDictionary tempData,
            string text,
            string? title,
            bool dismissible = false,
            bool useBootstrap4 = false)
        => SetFlashMessage(tempData, text, title, AlertType.Danger, dismissible, useBootstrap4);

        public static void SetWarningMessage(
            this ITempDataDictionary tempData,
            string text,
            string? title,
            bool dismissible = true,
            bool useBootstrap4 = false)
        => SetFlashMessage(tempData, text, title, AlertType.Warning, dismissible, useBootstrap4);

        public static void SetInfoMessage(
            this ITempDataDictionary tempData,
            string text,
            string? title,
            bool dismissible = true,
            bool useBootstrap4 = false)
        => SetFlashMessage(tempData, text, title, AlertType.Info, dismissible, useBootstrap4);

        #endregion Convience Methods
    }
}