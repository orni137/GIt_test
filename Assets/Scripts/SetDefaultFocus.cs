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
    int Sphere02 = 3;
    public void SetDefualtFocuse() {
        EventSystem.current.SetSelectedGameObject(defaultFocuse);
    }
}
