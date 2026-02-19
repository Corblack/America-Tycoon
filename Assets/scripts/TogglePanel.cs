using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    [SerializeField]
    private GameObject upgradePanel;

    [SerializeField]
    private GameObject SettingsPanel;

    public void UpgradeSwitchPanel()
    {
        bool isActive = upgradePanel.activeSelf;
        upgradePanel.SetActive(!isActive);
    }

        public void SettingsSwitchPanel()
    {
        bool isActive = SettingsPanel.activeSelf;
        SettingsPanel.SetActive(!isActive);
    }

}