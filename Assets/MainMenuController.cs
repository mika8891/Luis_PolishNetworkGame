using UnityEngine;
using Unity.Netcode;

public class MainMenuController : NetworkBehaviour
{   
    public GameObject mainMenuPanel;

    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        mainMenuPanel.SetActive(false);
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        mainMenuPanel.SetActive(false);
    }
    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
        mainMenuPanel.SetActive(false);
    }

}
