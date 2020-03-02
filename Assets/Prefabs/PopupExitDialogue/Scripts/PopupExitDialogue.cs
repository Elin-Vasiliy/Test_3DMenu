using UnityEngine;
using UnityEditor;

public class PopupExitDialogue : UIScreen
{
    public override void Show()
    {
        base.Show();
    }

    public void OnYesBtnClick()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void OnNoBtnClick()
    {
        Hide();
    }
}
