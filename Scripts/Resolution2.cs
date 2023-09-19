using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Resolution2 : MonoBehaviour
{
public Dropdown DropDown;
public void DropD2()
{
    if (DropDown.value == 0)
    {
        Screen.SetResolution(1280, 720, MMenuButtons.is_FS);
    }
    if (DropDown.value == 1)
    {
        Screen.SetResolution(1366, 768, MMenuButtons.is_FS);
    }
    if (DropDown.value == 2)
    {
        Screen.SetResolution(1920, 1080, MMenuButtons.is_FS);
    }
    if (DropDown.value == 3)
    {
        Screen.SetResolution(2560, 1440, MMenuButtons.is_FS);
    }
}

}
