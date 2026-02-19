using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    [SerializeField]
    private GameObject upgradePanel;

    public void SwitchPanel()
    {
        bool isActive = upgradePanel.activeSelf;
        upgradePanel.SetActive(!isActive);
    }

}