using UnityEngine;
using UnityEngine.EventSystems;

public class SetDefaultFocus : MonoBehaviour
{
    public GameObject defaultFocuse;

    void Start() {
        SetDefualtFocuse();
    }

    int Cube = 1;
    int Somthing = 0;
    int More = 0;
    public void SetDefualtFocuse() {
        EventSystem.current.SetSelectedGameObject(defaultFocuse);
    }
}
