namespace AhmedOumezzine.FlashMessage;

/// <summary>
/// Base Message Class.
/// </summary>
public class AlertMessage
{
    private string? _text;
    private string? _title;
    private AlertType _type;
    private bool _dismissible;
    private bool _useBootstrap4;

    public AlertMessage(
        string? alertText,
        string? alertTitle,
        AlertType alertType,
        bool isDismissible = false,
        bool useBS4 = false)
    {
        _text = alertText;
        _title = alertTitle;
        _type = alertType;
        _dismissible = isDismissible;
        _useBootstrap4 = useBS4;
    }

    public AlertMessage()
    { }

    public string? Text
    {
        get => _text;
        set => _text = value;
    }

    public string? Title
    {
        get => _title;
        set => _title = value;
    }

    public AlertType Type
    {
        get => _type;
        set => _type = value;
    }

    public bool Dismissible
    {
        get => _dismissible;
        set => _dismissible = value;
    }

    public bool UseBootstrap4
    {
        get => _useBootstrap4;
        set => _useBootstrap4 = value;
    }
}