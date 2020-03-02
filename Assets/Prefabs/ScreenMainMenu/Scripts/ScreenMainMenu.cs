using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenMainMenu : UIScreen
{
    public void OnExitBtnClick()
    {
        UIHome.instance.ShowPopupExitDialogue();
    }
}
