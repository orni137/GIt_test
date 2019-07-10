using UnityEngine;
using UnityEngine.EventSystems;

public class SetDefaultFocus : MonoBehaviour
{
    public GameObject defaultFocuse;

    int fromTheRoot02 = 7;

    void Start() {
        SetDefualtFocuse();
    }
    public void SetDefualtFocuse() {
        EventSystem.current.SetSelectedGameObject(defaultFocuse);
    }
}
