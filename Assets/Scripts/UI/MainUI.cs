using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void GoToWorldMap() => SceneManager.LoadScene("WorldMap");
    public void GoToBattleScene() => SceneManager.LoadScene("Battle");
    public void GoToInventory() => SceneManager.LoadScene("Inventory");
    public void ExitGame() => Application.Quit();
}
