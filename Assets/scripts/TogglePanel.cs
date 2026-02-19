using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    [SerializeField]
    private GameObject upgradePanel;

    [SerializeField]
    private GameObject SettingsPanel;

    [SerializeField]
    private GameObject bonusPanel ;
    

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

    public void bonusSwitchPanel()
    {
        bool isActive = bonusPanel.activeSelf;
        bonusPanel.SetActive(!isActive) ;
    }

}