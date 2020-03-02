using System.Collections.Generic;
using UnityEngine;

public abstract class UIController : MonoBehaviour
{
    public UIScreen[] screenPrefs;
    public UIScreen defaultScreenPref;

    private List<UIScreen> screenPool;

    protected virtual void Awake()
    {
        CreateSingleton();
        Initialize();
    }

    protected abstract void CreateSingleton();

    protected virtual void Initialize()
    {
        screenPool = new List<UIScreen>();
        foreach(UIScreen screenPref in screenPrefs)
        {
            UIScreen createScreen = CreateScreen(screenPref);
            createScreen.Hide();
            screenPool.Add(createScreen);
        }
        UIScreen defScreen = CreateScreen(defaultScreenPref);
        defScreen.Show();
        screenPool.Add(defScreen);
    }

    protected UIScreen CreateScreen(UIScreen pref)
    {
        return Instantiate(pref, transform);
    }

    protected UIScreen GetScreenOfType(ScreenType type)
    {
        foreach (UIScreen screen in screenPool)
        {
            if(screen.type == type)
            {
                return screen;
            }
        }
        throw new System.Exception("There is no screen of type: " + type);
    }
}
