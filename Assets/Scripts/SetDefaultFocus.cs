using UnityEngine;
using UnityEngine.EventSystems;

public class SetDefaultFocus : MonoBehaviour
{
    public GameObject defaultFocuse;

    void Start() {
        SetDefualtFocuse();
    }
    public void SetDefualtFocuse() {
        EventSystem.current.SetSelectedGameObject(defaultFocuse);
    }
}
