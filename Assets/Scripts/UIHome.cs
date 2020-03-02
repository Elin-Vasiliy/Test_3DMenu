public class UIHome : UIController
{
    public static UIHome instance { get; private set; }

    protected override void CreateSingleton()
    {
        instance = this;
    }

    public void ShowPopupExitDialogue()
    {
        UIScreen popupExit = GetScreenOfType(ScreenType.PopupExitDialogue);
        popupExit.Show();
    }
}
