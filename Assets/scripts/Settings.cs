using UnityEngine;

public class SettingsMenu : MonoBehaviour

{
    [SerializeField] private Wallet wallet;
        public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }


}