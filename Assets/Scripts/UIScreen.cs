using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ScreenType
{
    None,
    ScreenMainMenu,
    PopupExitDialogue
}

public class UIScreen : MonoBehaviour
{
    public ScreenType type;

    public virtual void Show()
    {
        gameObject.SetActive(true);
        MoveScreenForward();
    }

    private void MoveScreenForward()
    {
        RectTransform rect = GetComponent<RectTransform>();
        rect.SetAsLastSibling();
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }
}
