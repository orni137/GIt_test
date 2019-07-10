using UnityEngine;
using UnityEngine.EventSystems;

public class SetDefaultFocus : MonoBehaviour
{
    public GameObject defaultFocuse;

    void Start() {
        SetDefualtFocuse();
    }

    int fromTheRoot03 = 14;

    int fromTheRoot01 = 4;
    int fromTheRoot02 = 4;
    int fromTheRoot04 = 4;

    public void SetDefualtFocuse() {
        EventSystem.current.SetSelectedGameObject(defaultFocuse);
    }
}
