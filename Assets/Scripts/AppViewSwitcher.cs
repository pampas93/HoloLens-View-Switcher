using HoloToolkit.Unity;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class AppViewSwitcher : MonoBehaviour
{

    public delegate void NavigateToFlatDelegate();
    public static NavigateToFlatDelegate NavigateToFlat;

    void Start()
    {
        StartCoroutine(NewView());
    }

    IEnumerator NewView()
    {
        yield return new WaitForSeconds(5);
        if (NavigateToFlat != null)
        {
#if WINDOWS_UWP
            UnityEngine.WSA.Application.InvokeOnUIThread(() =>
            {
                NavigateToFlat();
            }, false);
#endif
        }
    }
}